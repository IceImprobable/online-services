// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: party/party.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Improbable.OnlineServices.Proto.Party {
  public static partial class PartyService
  {
    static readonly string __ServiceName = "party.PartyService";

    static readonly grpc::Marshaller<global::Improbable.OnlineServices.Proto.Party.CreatePartyRequest> __Marshaller_party_CreatePartyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.OnlineServices.Proto.Party.CreatePartyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.OnlineServices.Proto.Party.CreatePartyResponse> __Marshaller_party_CreatePartyResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.OnlineServices.Proto.Party.CreatePartyResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdRequest> __Marshaller_party_GetPartyByPlayerIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdResponse> __Marshaller_party_GetPartyByPlayerIdResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.OnlineServices.Proto.Party.DeletePartyRequest> __Marshaller_party_DeletePartyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.OnlineServices.Proto.Party.DeletePartyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.OnlineServices.Proto.Party.DeletePartyResponse> __Marshaller_party_DeletePartyResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.OnlineServices.Proto.Party.DeletePartyResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.OnlineServices.Proto.Party.JoinPartyRequest> __Marshaller_party_JoinPartyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.OnlineServices.Proto.Party.JoinPartyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.OnlineServices.Proto.Party.JoinPartyResponse> __Marshaller_party_JoinPartyResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.OnlineServices.Proto.Party.JoinPartyResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.OnlineServices.Proto.Party.LeavePartyRequest> __Marshaller_party_LeavePartyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.OnlineServices.Proto.Party.LeavePartyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.OnlineServices.Proto.Party.LeavePartyResponse> __Marshaller_party_LeavePartyResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.OnlineServices.Proto.Party.LeavePartyResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.OnlineServices.Proto.Party.KickOutPlayerRequest> __Marshaller_party_KickOutPlayerRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.OnlineServices.Proto.Party.KickOutPlayerRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.OnlineServices.Proto.Party.KickOutPlayerResponse> __Marshaller_party_KickOutPlayerResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.OnlineServices.Proto.Party.KickOutPlayerResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.OnlineServices.Proto.Party.UpdatePartyRequest> __Marshaller_party_UpdatePartyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.OnlineServices.Proto.Party.UpdatePartyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.OnlineServices.Proto.Party.UpdatePartyResponse> __Marshaller_party_UpdatePartyResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.OnlineServices.Proto.Party.UpdatePartyResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Improbable.OnlineServices.Proto.Party.CreatePartyRequest, global::Improbable.OnlineServices.Proto.Party.CreatePartyResponse> __Method_CreateParty = new grpc::Method<global::Improbable.OnlineServices.Proto.Party.CreatePartyRequest, global::Improbable.OnlineServices.Proto.Party.CreatePartyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateParty",
        __Marshaller_party_CreatePartyRequest,
        __Marshaller_party_CreatePartyResponse);

    static readonly grpc::Method<global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdRequest, global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdResponse> __Method_GetPartyByPlayerId = new grpc::Method<global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdRequest, global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPartyByPlayerId",
        __Marshaller_party_GetPartyByPlayerIdRequest,
        __Marshaller_party_GetPartyByPlayerIdResponse);

    static readonly grpc::Method<global::Improbable.OnlineServices.Proto.Party.DeletePartyRequest, global::Improbable.OnlineServices.Proto.Party.DeletePartyResponse> __Method_DeleteParty = new grpc::Method<global::Improbable.OnlineServices.Proto.Party.DeletePartyRequest, global::Improbable.OnlineServices.Proto.Party.DeletePartyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteParty",
        __Marshaller_party_DeletePartyRequest,
        __Marshaller_party_DeletePartyResponse);

    static readonly grpc::Method<global::Improbable.OnlineServices.Proto.Party.JoinPartyRequest, global::Improbable.OnlineServices.Proto.Party.JoinPartyResponse> __Method_JoinParty = new grpc::Method<global::Improbable.OnlineServices.Proto.Party.JoinPartyRequest, global::Improbable.OnlineServices.Proto.Party.JoinPartyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "JoinParty",
        __Marshaller_party_JoinPartyRequest,
        __Marshaller_party_JoinPartyResponse);

    static readonly grpc::Method<global::Improbable.OnlineServices.Proto.Party.LeavePartyRequest, global::Improbable.OnlineServices.Proto.Party.LeavePartyResponse> __Method_LeaveParty = new grpc::Method<global::Improbable.OnlineServices.Proto.Party.LeavePartyRequest, global::Improbable.OnlineServices.Proto.Party.LeavePartyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "LeaveParty",
        __Marshaller_party_LeavePartyRequest,
        __Marshaller_party_LeavePartyResponse);

    static readonly grpc::Method<global::Improbable.OnlineServices.Proto.Party.KickOutPlayerRequest, global::Improbable.OnlineServices.Proto.Party.KickOutPlayerResponse> __Method_KickOutPlayer = new grpc::Method<global::Improbable.OnlineServices.Proto.Party.KickOutPlayerRequest, global::Improbable.OnlineServices.Proto.Party.KickOutPlayerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "KickOutPlayer",
        __Marshaller_party_KickOutPlayerRequest,
        __Marshaller_party_KickOutPlayerResponse);

    static readonly grpc::Method<global::Improbable.OnlineServices.Proto.Party.UpdatePartyRequest, global::Improbable.OnlineServices.Proto.Party.UpdatePartyResponse> __Method_UpdateParty = new grpc::Method<global::Improbable.OnlineServices.Proto.Party.UpdatePartyRequest, global::Improbable.OnlineServices.Proto.Party.UpdatePartyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateParty",
        __Marshaller_party_UpdatePartyRequest,
        __Marshaller_party_UpdatePartyResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Improbable.OnlineServices.Proto.Party.PartyReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PartyService</summary>
    [grpc::BindServiceMethod(typeof(PartyService), "BindService")]
    public abstract partial class PartyServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Improbable.OnlineServices.Proto.Party.CreatePartyResponse> CreateParty(global::Improbable.OnlineServices.Proto.Party.CreatePartyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdResponse> GetPartyByPlayerId(global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Improbable.OnlineServices.Proto.Party.DeletePartyResponse> DeleteParty(global::Improbable.OnlineServices.Proto.Party.DeletePartyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Improbable.OnlineServices.Proto.Party.JoinPartyResponse> JoinParty(global::Improbable.OnlineServices.Proto.Party.JoinPartyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Improbable.OnlineServices.Proto.Party.LeavePartyResponse> LeaveParty(global::Improbable.OnlineServices.Proto.Party.LeavePartyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Improbable.OnlineServices.Proto.Party.KickOutPlayerResponse> KickOutPlayer(global::Improbable.OnlineServices.Proto.Party.KickOutPlayerRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Does not update the member list of the party. Modifications to the member list can be made using 
      /// Join/Leave/KickOut.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Improbable.OnlineServices.Proto.Party.UpdatePartyResponse> UpdateParty(global::Improbable.OnlineServices.Proto.Party.UpdatePartyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PartyService</summary>
    public partial class PartyServiceClient : grpc::ClientBase<PartyServiceClient>
    {
      /// <summary>Creates a new client for PartyService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PartyServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PartyService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PartyServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PartyServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PartyServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Improbable.OnlineServices.Proto.Party.CreatePartyResponse CreateParty(global::Improbable.OnlineServices.Proto.Party.CreatePartyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateParty(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Improbable.OnlineServices.Proto.Party.CreatePartyResponse CreateParty(global::Improbable.OnlineServices.Proto.Party.CreatePartyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateParty, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Improbable.OnlineServices.Proto.Party.CreatePartyResponse> CreatePartyAsync(global::Improbable.OnlineServices.Proto.Party.CreatePartyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreatePartyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Improbable.OnlineServices.Proto.Party.CreatePartyResponse> CreatePartyAsync(global::Improbable.OnlineServices.Proto.Party.CreatePartyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateParty, null, options, request);
      }
      public virtual global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdResponse GetPartyByPlayerId(global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPartyByPlayerId(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdResponse GetPartyByPlayerId(global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPartyByPlayerId, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdResponse> GetPartyByPlayerIdAsync(global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPartyByPlayerIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdResponse> GetPartyByPlayerIdAsync(global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPartyByPlayerId, null, options, request);
      }
      public virtual global::Improbable.OnlineServices.Proto.Party.DeletePartyResponse DeleteParty(global::Improbable.OnlineServices.Proto.Party.DeletePartyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteParty(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Improbable.OnlineServices.Proto.Party.DeletePartyResponse DeleteParty(global::Improbable.OnlineServices.Proto.Party.DeletePartyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteParty, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Improbable.OnlineServices.Proto.Party.DeletePartyResponse> DeletePartyAsync(global::Improbable.OnlineServices.Proto.Party.DeletePartyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePartyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Improbable.OnlineServices.Proto.Party.DeletePartyResponse> DeletePartyAsync(global::Improbable.OnlineServices.Proto.Party.DeletePartyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteParty, null, options, request);
      }
      public virtual global::Improbable.OnlineServices.Proto.Party.JoinPartyResponse JoinParty(global::Improbable.OnlineServices.Proto.Party.JoinPartyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return JoinParty(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Improbable.OnlineServices.Proto.Party.JoinPartyResponse JoinParty(global::Improbable.OnlineServices.Proto.Party.JoinPartyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_JoinParty, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Improbable.OnlineServices.Proto.Party.JoinPartyResponse> JoinPartyAsync(global::Improbable.OnlineServices.Proto.Party.JoinPartyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return JoinPartyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Improbable.OnlineServices.Proto.Party.JoinPartyResponse> JoinPartyAsync(global::Improbable.OnlineServices.Proto.Party.JoinPartyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_JoinParty, null, options, request);
      }
      public virtual global::Improbable.OnlineServices.Proto.Party.LeavePartyResponse LeaveParty(global::Improbable.OnlineServices.Proto.Party.LeavePartyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LeaveParty(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Improbable.OnlineServices.Proto.Party.LeavePartyResponse LeaveParty(global::Improbable.OnlineServices.Proto.Party.LeavePartyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_LeaveParty, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Improbable.OnlineServices.Proto.Party.LeavePartyResponse> LeavePartyAsync(global::Improbable.OnlineServices.Proto.Party.LeavePartyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LeavePartyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Improbable.OnlineServices.Proto.Party.LeavePartyResponse> LeavePartyAsync(global::Improbable.OnlineServices.Proto.Party.LeavePartyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_LeaveParty, null, options, request);
      }
      public virtual global::Improbable.OnlineServices.Proto.Party.KickOutPlayerResponse KickOutPlayer(global::Improbable.OnlineServices.Proto.Party.KickOutPlayerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return KickOutPlayer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Improbable.OnlineServices.Proto.Party.KickOutPlayerResponse KickOutPlayer(global::Improbable.OnlineServices.Proto.Party.KickOutPlayerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_KickOutPlayer, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Improbable.OnlineServices.Proto.Party.KickOutPlayerResponse> KickOutPlayerAsync(global::Improbable.OnlineServices.Proto.Party.KickOutPlayerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return KickOutPlayerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Improbable.OnlineServices.Proto.Party.KickOutPlayerResponse> KickOutPlayerAsync(global::Improbable.OnlineServices.Proto.Party.KickOutPlayerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_KickOutPlayer, null, options, request);
      }
      /// <summary>
      /// Does not update the member list of the party. Modifications to the member list can be made using 
      /// Join/Leave/KickOut.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.OnlineServices.Proto.Party.UpdatePartyResponse UpdateParty(global::Improbable.OnlineServices.Proto.Party.UpdatePartyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateParty(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Does not update the member list of the party. Modifications to the member list can be made using 
      /// Join/Leave/KickOut.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.OnlineServices.Proto.Party.UpdatePartyResponse UpdateParty(global::Improbable.OnlineServices.Proto.Party.UpdatePartyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateParty, null, options, request);
      }
      /// <summary>
      /// Does not update the member list of the party. Modifications to the member list can be made using 
      /// Join/Leave/KickOut.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.OnlineServices.Proto.Party.UpdatePartyResponse> UpdatePartyAsync(global::Improbable.OnlineServices.Proto.Party.UpdatePartyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdatePartyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Does not update the member list of the party. Modifications to the member list can be made using 
      /// Join/Leave/KickOut.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.OnlineServices.Proto.Party.UpdatePartyResponse> UpdatePartyAsync(global::Improbable.OnlineServices.Proto.Party.UpdatePartyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateParty, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PartyServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PartyServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PartyServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateParty, serviceImpl.CreateParty)
          .AddMethod(__Method_GetPartyByPlayerId, serviceImpl.GetPartyByPlayerId)
          .AddMethod(__Method_DeleteParty, serviceImpl.DeleteParty)
          .AddMethod(__Method_JoinParty, serviceImpl.JoinParty)
          .AddMethod(__Method_LeaveParty, serviceImpl.LeaveParty)
          .AddMethod(__Method_KickOutPlayer, serviceImpl.KickOutPlayer)
          .AddMethod(__Method_UpdateParty, serviceImpl.UpdateParty).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PartyServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateParty, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Improbable.OnlineServices.Proto.Party.CreatePartyRequest, global::Improbable.OnlineServices.Proto.Party.CreatePartyResponse>(serviceImpl.CreateParty));
      serviceBinder.AddMethod(__Method_GetPartyByPlayerId, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdRequest, global::Improbable.OnlineServices.Proto.Party.GetPartyByPlayerIdResponse>(serviceImpl.GetPartyByPlayerId));
      serviceBinder.AddMethod(__Method_DeleteParty, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Improbable.OnlineServices.Proto.Party.DeletePartyRequest, global::Improbable.OnlineServices.Proto.Party.DeletePartyResponse>(serviceImpl.DeleteParty));
      serviceBinder.AddMethod(__Method_JoinParty, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Improbable.OnlineServices.Proto.Party.JoinPartyRequest, global::Improbable.OnlineServices.Proto.Party.JoinPartyResponse>(serviceImpl.JoinParty));
      serviceBinder.AddMethod(__Method_LeaveParty, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Improbable.OnlineServices.Proto.Party.LeavePartyRequest, global::Improbable.OnlineServices.Proto.Party.LeavePartyResponse>(serviceImpl.LeaveParty));
      serviceBinder.AddMethod(__Method_KickOutPlayer, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Improbable.OnlineServices.Proto.Party.KickOutPlayerRequest, global::Improbable.OnlineServices.Proto.Party.KickOutPlayerResponse>(serviceImpl.KickOutPlayer));
      serviceBinder.AddMethod(__Method_UpdateParty, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Improbable.OnlineServices.Proto.Party.UpdatePartyRequest, global::Improbable.OnlineServices.Proto.Party.UpdatePartyResponse>(serviceImpl.UpdateParty));
    }

  }
}
#endregion
