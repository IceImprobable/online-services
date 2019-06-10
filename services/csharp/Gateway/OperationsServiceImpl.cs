﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Google.LongRunning;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Improbable.OnlineServices.Common;
using Improbable.OnlineServices.DataModel;
using Improbable.OnlineServices.DataModel.Gateway;
using Improbable.OnlineServices.DataModel.Party;
using Improbable.OnlineServices.Proto.Gateway;
using Improbable.SpatialOS.PlayerAuth.V2Alpha1;
using MemoryStore;
using Serilog;
using PartyDataModel = Improbable.OnlineServices.DataModel.Party.Party;

namespace Gateway
{
    public class OperationsServiceImpl : Operations.OperationsBase
    {
        private readonly IMemoryStoreClientManager<IMemoryStoreClient> _memoryStoreClientManager;
        private readonly PlayerAuthServiceClient _playerAuthServiceClient;

        public OperationsServiceImpl(
            IMemoryStoreClientManager<IMemoryStoreClient> memoryStoreClientManager,
            PlayerAuthServiceClient playerAuthServiceClient)
        {
            _memoryStoreClientManager = memoryStoreClientManager;
            _playerAuthServiceClient = playerAuthServiceClient;
        }

        public override Task<Operation> GetOperation(GetOperationRequest request, ServerCallContext context)
        {
            var playerIdentity = AuthHeaders.ExtractPlayerId(context);
            if (!string.Equals(request.Name, playerIdentity))
            {
                throw new RpcException(new Status(StatusCode.PermissionDenied,
                    "Fetching another player's operation is forbidden."));
            }

            PlayerJoinRequest joinRequest;
            using (var memClient = _memoryStoreClientManager.GetClient())
            {
                try
                {
                    joinRequest = memClient.Get<PlayerJoinRequest>(request.Name) ??
                                  throw new EntryNotFoundException(request.Name);
                    if (joinRequest.IsComplete())
                    {
                        using (var tx = memClient.CreateTransaction())
                        {
                            tx.DeleteAll(joinRequest.Yield());
                        }
                    }
                }
                catch (EntryNotFoundException e)
                {
                    Reporter.OperationStateNotFoundInc();
                    Log.Warning($"Join request for {e.Id} does not exist");
                    throw new RpcException(new Status(StatusCode.NotFound, "requested player does not exist"));
                }
                catch (TransactionAbortedException)
                {
                    Reporter.TransactionAbortedInc("GetOperation");
                    Log.Warning("Transaction for operation deletion was aborted");
                    throw new RpcException(new Status(StatusCode.Unavailable,
                        "deletion aborted due to concurrent modification; safe to retry"));
                }
            }

            var op = new Operation
            {
                Name = joinRequest.PlayerIdentity,
                Done = joinRequest.IsComplete()
            };

            if (!op.Done)
            {
                Reporter.OperationStateInc(MatchState.Requested);
                return Task.FromResult(op);
            }

            switch (joinRequest.State)
            {
                case MatchState.Matched:
                    op.Response = CreateJoinResponse(joinRequest);
                    break;
                case MatchState.Error:
                    op.Error = new Google.Rpc.Status
                    {
                        Code = (int) Google.Rpc.Code.Unknown,
                        Message = "the join request encountered an error"
                    };
                    break;
            }

            Reporter.OperationStateInc(joinRequest.State);
            Log.Information($"Join request for {op.Name} done in state {joinRequest.State}.");
            return Task.FromResult(op);
        }

        public override Task<Empty> DeleteOperation(DeleteOperationRequest request, ServerCallContext context)
        {
            var playerIdentity = AuthHeaders.ExtractPlayerId(context);
            if (!string.Equals(request.Name, playerIdentity))
            {
                throw new RpcException(new Status(StatusCode.PermissionDenied,
                    "Deleting another player's operation is forbidden."));
            }

            Log.Information($"Requested cancellation for the party of player identifier {request.Name}.");
            using (var memClient = _memoryStoreClientManager.GetClient())
            {
                var party = GetPartyOfMember(memClient, request.Name);
                if (party == null)
                {
                    throw new RpcException(new Status(StatusCode.NotFound,
                        "The player making this call is not a member of any party"));
                }

                if (party.LeaderPlayerId != request.Name)
                {
                    throw new RpcException(new Status(StatusCode.PermissionDenied,
                        "Only the leader can delete a matchmaking join request"));
                }

                try
                {
                    var partyJoinRequest = memClient.Get<PartyJoinRequest>(party.Id) ??
                                           throw new EntryNotFoundException(party.Id);

                    var toDelete = new List<Entry> { partyJoinRequest };
                    foreach (var (member, _) in partyJoinRequest.Party.MemberIdToPit)
                    {
                        toDelete.Add(memClient.Get<PlayerJoinRequest>(member) ??
                                     throw new EntryNotFoundException(member));
                    }

                    using (var tx = memClient.CreateTransaction())
                    {
                        tx.RemoveAllFromQueue(partyJoinRequest.Yield());
                        tx.DeleteAll(toDelete);
                    }

                    Reporter.CancelOperationInc();
                    return Task.FromResult(new Empty());
                }
                catch (EntryNotFoundException exception)
                {
                    Log.Warning($"Delete for {request.Name} failed.");
                    if (exception.Id.Contains(party.Id))
                    {
                        Reporter.CancelOperationNotFoundInc();
                        throw new RpcException(new Status(StatusCode.NotFound,
                            "requested party is not in matchmaking"));
                    }

                    throw new RpcException(new Status(StatusCode.Internal,
                        $"could not find join request for player {exception.Id}"));
                }
                catch (TransactionAbortedException)
                {
                    Reporter.TransactionAbortedInc("DeleteOperation");
                    Log.Warning("Transaction for operation deletion was aborted");
                    throw new RpcException(new Status(StatusCode.Unavailable,
                        "deletion aborted due to concurrent modification; safe to retry"));
                }
            }
        }

        #region Unimplemented methods

        public override Task<ListOperationsResponse> ListOperations(ListOperationsRequest request,
            ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Unimplemented, "ListOperations not implemented"));
        }

        public override Task<Empty> CancelOperation(CancelOperationRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Unimplemented, "CancelOperation not implemented"));
        }

        #endregion

        private Any CreateJoinResponse(PlayerJoinRequest request)
        {
            try
            {
                var loginTokenResp = _playerAuthServiceClient.CreateLoginToken(new CreateLoginTokenRequest
                {
                    DeploymentId = request.DeploymentId,
                    PlayerIdentityToken = request.PlayerIdentityToken
                });
                var response = new JoinResponse
                {
                    DeploymentName = request.DeploymentName,
                    LoginToken = loginTokenResp.LoginToken
                };
                return Any.Pack(response);
            }
            catch (Exception e)
            {
                Log.Error(e, "encountered an error creating a login token");
                throw new RpcException(new Status(StatusCode.Internal, "encountered an error creating a login token"));
            }
        }

        private static PartyDataModel GetPartyOfMember(IMemoryStoreClient memClient, string playerId)
        {
            var member = memClient.Get<Member>(playerId);
            return member == null ? null : memClient.Get<PartyDataModel>(member.PartyId);
        }
    }
}