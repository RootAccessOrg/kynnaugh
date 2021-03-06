// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/bigtable/v1/bigtable_service.proto
// Original file comments:
// Copyright 2016 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Google.Bigtable.V1 {
  /// <summary>
  ///  Service for reading from and writing to existing Bigtables.
  /// </summary>
  public static class BigtableService
  {
    static readonly string __ServiceName = "google.bigtable.v1.BigtableService";

    static readonly Marshaller<global::Google.Bigtable.V1.ReadRowsRequest> __Marshaller_ReadRowsRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Bigtable.V1.ReadRowsRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Bigtable.V1.ReadRowsResponse> __Marshaller_ReadRowsResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Bigtable.V1.ReadRowsResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Bigtable.V1.SampleRowKeysRequest> __Marshaller_SampleRowKeysRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Bigtable.V1.SampleRowKeysRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Bigtable.V1.SampleRowKeysResponse> __Marshaller_SampleRowKeysResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Bigtable.V1.SampleRowKeysResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Bigtable.V1.MutateRowRequest> __Marshaller_MutateRowRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Bigtable.V1.MutateRowRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Bigtable.V1.MutateRowsRequest> __Marshaller_MutateRowsRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Bigtable.V1.MutateRowsRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Bigtable.V1.MutateRowsResponse> __Marshaller_MutateRowsResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Bigtable.V1.MutateRowsResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Bigtable.V1.CheckAndMutateRowRequest> __Marshaller_CheckAndMutateRowRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Bigtable.V1.CheckAndMutateRowRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Bigtable.V1.CheckAndMutateRowResponse> __Marshaller_CheckAndMutateRowResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Bigtable.V1.CheckAndMutateRowResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Bigtable.V1.ReadModifyWriteRowRequest> __Marshaller_ReadModifyWriteRowRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Bigtable.V1.ReadModifyWriteRowRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Bigtable.V1.Row> __Marshaller_Row = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Bigtable.V1.Row.Parser.ParseFrom);

    static readonly Method<global::Google.Bigtable.V1.ReadRowsRequest, global::Google.Bigtable.V1.ReadRowsResponse> __Method_ReadRows = new Method<global::Google.Bigtable.V1.ReadRowsRequest, global::Google.Bigtable.V1.ReadRowsResponse>(
        MethodType.ServerStreaming,
        __ServiceName,
        "ReadRows",
        __Marshaller_ReadRowsRequest,
        __Marshaller_ReadRowsResponse);

    static readonly Method<global::Google.Bigtable.V1.SampleRowKeysRequest, global::Google.Bigtable.V1.SampleRowKeysResponse> __Method_SampleRowKeys = new Method<global::Google.Bigtable.V1.SampleRowKeysRequest, global::Google.Bigtable.V1.SampleRowKeysResponse>(
        MethodType.ServerStreaming,
        __ServiceName,
        "SampleRowKeys",
        __Marshaller_SampleRowKeysRequest,
        __Marshaller_SampleRowKeysResponse);

    static readonly Method<global::Google.Bigtable.V1.MutateRowRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_MutateRow = new Method<global::Google.Bigtable.V1.MutateRowRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "MutateRow",
        __Marshaller_MutateRowRequest,
        __Marshaller_Empty);

    static readonly Method<global::Google.Bigtable.V1.MutateRowsRequest, global::Google.Bigtable.V1.MutateRowsResponse> __Method_MutateRows = new Method<global::Google.Bigtable.V1.MutateRowsRequest, global::Google.Bigtable.V1.MutateRowsResponse>(
        MethodType.Unary,
        __ServiceName,
        "MutateRows",
        __Marshaller_MutateRowsRequest,
        __Marshaller_MutateRowsResponse);

    static readonly Method<global::Google.Bigtable.V1.CheckAndMutateRowRequest, global::Google.Bigtable.V1.CheckAndMutateRowResponse> __Method_CheckAndMutateRow = new Method<global::Google.Bigtable.V1.CheckAndMutateRowRequest, global::Google.Bigtable.V1.CheckAndMutateRowResponse>(
        MethodType.Unary,
        __ServiceName,
        "CheckAndMutateRow",
        __Marshaller_CheckAndMutateRowRequest,
        __Marshaller_CheckAndMutateRowResponse);

    static readonly Method<global::Google.Bigtable.V1.ReadModifyWriteRowRequest, global::Google.Bigtable.V1.Row> __Method_ReadModifyWriteRow = new Method<global::Google.Bigtable.V1.ReadModifyWriteRowRequest, global::Google.Bigtable.V1.Row>(
        MethodType.Unary,
        __ServiceName,
        "ReadModifyWriteRow",
        __Marshaller_ReadModifyWriteRowRequest,
        __Marshaller_Row);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Bigtable.V1.BigtableServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of BigtableService</summary>
    public abstract class BigtableServiceBase
    {
      /// <summary>
      ///  Streams back the contents of all requested rows, optionally applying
      ///  the same Reader filter to each. Depending on their size, rows may be
      ///  broken up across multiple responses, but atomicity of each row will still
      ///  be preserved.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task ReadRows(global::Google.Bigtable.V1.ReadRowsRequest request, IServerStreamWriter<global::Google.Bigtable.V1.ReadRowsResponse> responseStream, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Returns a sample of row keys in the table. The returned row keys will
      ///  delimit contiguous sections of the table of approximately equal size,
      ///  which can be used to break up the data for distributed tasks like
      ///  mapreduces.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task SampleRowKeys(global::Google.Bigtable.V1.SampleRowKeysRequest request, IServerStreamWriter<global::Google.Bigtable.V1.SampleRowKeysResponse> responseStream, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Mutates a row atomically. Cells already present in the row are left
      ///  unchanged unless explicitly changed by 'mutation'.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> MutateRow(global::Google.Bigtable.V1.MutateRowRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Mutates multiple rows in a batch. Each individual row is mutated
      ///  atomically as in MutateRow, but the entire batch is not executed
      ///  atomically.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Bigtable.V1.MutateRowsResponse> MutateRows(global::Google.Bigtable.V1.MutateRowsRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Mutates a row atomically based on the output of a predicate Reader filter.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Bigtable.V1.CheckAndMutateRowResponse> CheckAndMutateRow(global::Google.Bigtable.V1.CheckAndMutateRowRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Modifies a row atomically, reading the latest existing timestamp/value from
      ///  the specified columns and writing a new value at
      ///  max(existing timestamp, current server time) based on pre-defined
      ///  read/modify/write rules. Returns the new contents of all modified cells.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Bigtable.V1.Row> ReadModifyWriteRow(global::Google.Bigtable.V1.ReadModifyWriteRowRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for BigtableService</summary>
    public class BigtableServiceClient : ClientBase<BigtableServiceClient>
    {
      /// <summary>Creates a new client for BigtableService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public BigtableServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for BigtableService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public BigtableServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected BigtableServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected BigtableServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Streams back the contents of all requested rows, optionally applying
      ///  the same Reader filter to each. Depending on their size, rows may be
      ///  broken up across multiple responses, but atomicity of each row will still
      ///  be preserved.
      /// </summary>
      public virtual AsyncServerStreamingCall<global::Google.Bigtable.V1.ReadRowsResponse> ReadRows(global::Google.Bigtable.V1.ReadRowsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ReadRows(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Streams back the contents of all requested rows, optionally applying
      ///  the same Reader filter to each. Depending on their size, rows may be
      ///  broken up across multiple responses, but atomicity of each row will still
      ///  be preserved.
      /// </summary>
      public virtual AsyncServerStreamingCall<global::Google.Bigtable.V1.ReadRowsResponse> ReadRows(global::Google.Bigtable.V1.ReadRowsRequest request, CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ReadRows, null, options, request);
      }
      /// <summary>
      ///  Returns a sample of row keys in the table. The returned row keys will
      ///  delimit contiguous sections of the table of approximately equal size,
      ///  which can be used to break up the data for distributed tasks like
      ///  mapreduces.
      /// </summary>
      public virtual AsyncServerStreamingCall<global::Google.Bigtable.V1.SampleRowKeysResponse> SampleRowKeys(global::Google.Bigtable.V1.SampleRowKeysRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SampleRowKeys(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Returns a sample of row keys in the table. The returned row keys will
      ///  delimit contiguous sections of the table of approximately equal size,
      ///  which can be used to break up the data for distributed tasks like
      ///  mapreduces.
      /// </summary>
      public virtual AsyncServerStreamingCall<global::Google.Bigtable.V1.SampleRowKeysResponse> SampleRowKeys(global::Google.Bigtable.V1.SampleRowKeysRequest request, CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_SampleRowKeys, null, options, request);
      }
      /// <summary>
      ///  Mutates a row atomically. Cells already present in the row are left
      ///  unchanged unless explicitly changed by 'mutation'.
      /// </summary>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty MutateRow(global::Google.Bigtable.V1.MutateRowRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MutateRow(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Mutates a row atomically. Cells already present in the row are left
      ///  unchanged unless explicitly changed by 'mutation'.
      /// </summary>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty MutateRow(global::Google.Bigtable.V1.MutateRowRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateRow, null, options, request);
      }
      /// <summary>
      ///  Mutates a row atomically. Cells already present in the row are left
      ///  unchanged unless explicitly changed by 'mutation'.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> MutateRowAsync(global::Google.Bigtable.V1.MutateRowRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MutateRowAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Mutates a row atomically. Cells already present in the row are left
      ///  unchanged unless explicitly changed by 'mutation'.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> MutateRowAsync(global::Google.Bigtable.V1.MutateRowRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateRow, null, options, request);
      }
      /// <summary>
      ///  Mutates multiple rows in a batch. Each individual row is mutated
      ///  atomically as in MutateRow, but the entire batch is not executed
      ///  atomically.
      /// </summary>
      public virtual global::Google.Bigtable.V1.MutateRowsResponse MutateRows(global::Google.Bigtable.V1.MutateRowsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MutateRows(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Mutates multiple rows in a batch. Each individual row is mutated
      ///  atomically as in MutateRow, but the entire batch is not executed
      ///  atomically.
      /// </summary>
      public virtual global::Google.Bigtable.V1.MutateRowsResponse MutateRows(global::Google.Bigtable.V1.MutateRowsRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateRows, null, options, request);
      }
      /// <summary>
      ///  Mutates multiple rows in a batch. Each individual row is mutated
      ///  atomically as in MutateRow, but the entire batch is not executed
      ///  atomically.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Bigtable.V1.MutateRowsResponse> MutateRowsAsync(global::Google.Bigtable.V1.MutateRowsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MutateRowsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Mutates multiple rows in a batch. Each individual row is mutated
      ///  atomically as in MutateRow, but the entire batch is not executed
      ///  atomically.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Bigtable.V1.MutateRowsResponse> MutateRowsAsync(global::Google.Bigtable.V1.MutateRowsRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateRows, null, options, request);
      }
      /// <summary>
      ///  Mutates a row atomically based on the output of a predicate Reader filter.
      /// </summary>
      public virtual global::Google.Bigtable.V1.CheckAndMutateRowResponse CheckAndMutateRow(global::Google.Bigtable.V1.CheckAndMutateRowRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CheckAndMutateRow(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Mutates a row atomically based on the output of a predicate Reader filter.
      /// </summary>
      public virtual global::Google.Bigtable.V1.CheckAndMutateRowResponse CheckAndMutateRow(global::Google.Bigtable.V1.CheckAndMutateRowRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CheckAndMutateRow, null, options, request);
      }
      /// <summary>
      ///  Mutates a row atomically based on the output of a predicate Reader filter.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Bigtable.V1.CheckAndMutateRowResponse> CheckAndMutateRowAsync(global::Google.Bigtable.V1.CheckAndMutateRowRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CheckAndMutateRowAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Mutates a row atomically based on the output of a predicate Reader filter.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Bigtable.V1.CheckAndMutateRowResponse> CheckAndMutateRowAsync(global::Google.Bigtable.V1.CheckAndMutateRowRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CheckAndMutateRow, null, options, request);
      }
      /// <summary>
      ///  Modifies a row atomically, reading the latest existing timestamp/value from
      ///  the specified columns and writing a new value at
      ///  max(existing timestamp, current server time) based on pre-defined
      ///  read/modify/write rules. Returns the new contents of all modified cells.
      /// </summary>
      public virtual global::Google.Bigtable.V1.Row ReadModifyWriteRow(global::Google.Bigtable.V1.ReadModifyWriteRowRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ReadModifyWriteRow(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Modifies a row atomically, reading the latest existing timestamp/value from
      ///  the specified columns and writing a new value at
      ///  max(existing timestamp, current server time) based on pre-defined
      ///  read/modify/write rules. Returns the new contents of all modified cells.
      /// </summary>
      public virtual global::Google.Bigtable.V1.Row ReadModifyWriteRow(global::Google.Bigtable.V1.ReadModifyWriteRowRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReadModifyWriteRow, null, options, request);
      }
      /// <summary>
      ///  Modifies a row atomically, reading the latest existing timestamp/value from
      ///  the specified columns and writing a new value at
      ///  max(existing timestamp, current server time) based on pre-defined
      ///  read/modify/write rules. Returns the new contents of all modified cells.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Bigtable.V1.Row> ReadModifyWriteRowAsync(global::Google.Bigtable.V1.ReadModifyWriteRowRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ReadModifyWriteRowAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Modifies a row atomically, reading the latest existing timestamp/value from
      ///  the specified columns and writing a new value at
      ///  max(existing timestamp, current server time) based on pre-defined
      ///  read/modify/write rules. Returns the new contents of all modified cells.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Bigtable.V1.Row> ReadModifyWriteRowAsync(global::Google.Bigtable.V1.ReadModifyWriteRowRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReadModifyWriteRow, null, options, request);
      }
      protected override BigtableServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BigtableServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(BigtableServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ReadRows, serviceImpl.ReadRows)
          .AddMethod(__Method_SampleRowKeys, serviceImpl.SampleRowKeys)
          .AddMethod(__Method_MutateRow, serviceImpl.MutateRow)
          .AddMethod(__Method_MutateRows, serviceImpl.MutateRows)
          .AddMethod(__Method_CheckAndMutateRow, serviceImpl.CheckAndMutateRow)
          .AddMethod(__Method_ReadModifyWriteRow, serviceImpl.ReadModifyWriteRow).Build();
    }

  }
}
#endregion
