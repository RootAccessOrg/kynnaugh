// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/genomics/v1/references.proto
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

namespace Google.Genomics.V1 {
  public static class ReferenceServiceV1
  {
    static readonly string __ServiceName = "google.genomics.v1.ReferenceServiceV1";

    static readonly Marshaller<global::Google.Genomics.V1.SearchReferenceSetsRequest> __Marshaller_SearchReferenceSetsRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Genomics.V1.SearchReferenceSetsRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Genomics.V1.SearchReferenceSetsResponse> __Marshaller_SearchReferenceSetsResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Genomics.V1.SearchReferenceSetsResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Genomics.V1.GetReferenceSetRequest> __Marshaller_GetReferenceSetRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Genomics.V1.GetReferenceSetRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Genomics.V1.ReferenceSet> __Marshaller_ReferenceSet = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Genomics.V1.ReferenceSet.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Genomics.V1.SearchReferencesRequest> __Marshaller_SearchReferencesRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Genomics.V1.SearchReferencesRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Genomics.V1.SearchReferencesResponse> __Marshaller_SearchReferencesResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Genomics.V1.SearchReferencesResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Genomics.V1.GetReferenceRequest> __Marshaller_GetReferenceRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Genomics.V1.GetReferenceRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Genomics.V1.Reference> __Marshaller_Reference = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Genomics.V1.Reference.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Genomics.V1.ListBasesRequest> __Marshaller_ListBasesRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Genomics.V1.ListBasesRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Genomics.V1.ListBasesResponse> __Marshaller_ListBasesResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Genomics.V1.ListBasesResponse.Parser.ParseFrom);

    static readonly Method<global::Google.Genomics.V1.SearchReferenceSetsRequest, global::Google.Genomics.V1.SearchReferenceSetsResponse> __Method_SearchReferenceSets = new Method<global::Google.Genomics.V1.SearchReferenceSetsRequest, global::Google.Genomics.V1.SearchReferenceSetsResponse>(
        MethodType.Unary,
        __ServiceName,
        "SearchReferenceSets",
        __Marshaller_SearchReferenceSetsRequest,
        __Marshaller_SearchReferenceSetsResponse);

    static readonly Method<global::Google.Genomics.V1.GetReferenceSetRequest, global::Google.Genomics.V1.ReferenceSet> __Method_GetReferenceSet = new Method<global::Google.Genomics.V1.GetReferenceSetRequest, global::Google.Genomics.V1.ReferenceSet>(
        MethodType.Unary,
        __ServiceName,
        "GetReferenceSet",
        __Marshaller_GetReferenceSetRequest,
        __Marshaller_ReferenceSet);

    static readonly Method<global::Google.Genomics.V1.SearchReferencesRequest, global::Google.Genomics.V1.SearchReferencesResponse> __Method_SearchReferences = new Method<global::Google.Genomics.V1.SearchReferencesRequest, global::Google.Genomics.V1.SearchReferencesResponse>(
        MethodType.Unary,
        __ServiceName,
        "SearchReferences",
        __Marshaller_SearchReferencesRequest,
        __Marshaller_SearchReferencesResponse);

    static readonly Method<global::Google.Genomics.V1.GetReferenceRequest, global::Google.Genomics.V1.Reference> __Method_GetReference = new Method<global::Google.Genomics.V1.GetReferenceRequest, global::Google.Genomics.V1.Reference>(
        MethodType.Unary,
        __ServiceName,
        "GetReference",
        __Marshaller_GetReferenceRequest,
        __Marshaller_Reference);

    static readonly Method<global::Google.Genomics.V1.ListBasesRequest, global::Google.Genomics.V1.ListBasesResponse> __Method_ListBases = new Method<global::Google.Genomics.V1.ListBasesRequest, global::Google.Genomics.V1.ListBasesResponse>(
        MethodType.Unary,
        __ServiceName,
        "ListBases",
        __Marshaller_ListBasesRequest,
        __Marshaller_ListBasesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Genomics.V1.ReferencesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ReferenceServiceV1</summary>
    public abstract class ReferenceServiceV1Base
    {
      /// <summary>
      ///  Searches for reference sets which match the given criteria.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.searchReferenceSets](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L71)
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Genomics.V1.SearchReferenceSetsResponse> SearchReferenceSets(global::Google.Genomics.V1.SearchReferenceSetsRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Gets a reference set.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.getReferenceSet](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L83).
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Genomics.V1.ReferenceSet> GetReferenceSet(global::Google.Genomics.V1.GetReferenceSetRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Searches for references which match the given criteria.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.searchReferences](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L146).
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Genomics.V1.SearchReferencesResponse> SearchReferences(global::Google.Genomics.V1.SearchReferencesRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Gets a reference.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.getReference](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L158).
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Genomics.V1.Reference> GetReference(global::Google.Genomics.V1.GetReferenceRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Lists the bases in a reference, optionally restricted to a range.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.getReferenceBases](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L221).
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Genomics.V1.ListBasesResponse> ListBases(global::Google.Genomics.V1.ListBasesRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ReferenceServiceV1</summary>
    public class ReferenceServiceV1Client : ClientBase<ReferenceServiceV1Client>
    {
      /// <summary>Creates a new client for ReferenceServiceV1</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ReferenceServiceV1Client(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ReferenceServiceV1 that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ReferenceServiceV1Client(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ReferenceServiceV1Client() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ReferenceServiceV1Client(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Searches for reference sets which match the given criteria.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.searchReferenceSets](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L71)
      /// </summary>
      public virtual global::Google.Genomics.V1.SearchReferenceSetsResponse SearchReferenceSets(global::Google.Genomics.V1.SearchReferenceSetsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SearchReferenceSets(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Searches for reference sets which match the given criteria.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.searchReferenceSets](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L71)
      /// </summary>
      public virtual global::Google.Genomics.V1.SearchReferenceSetsResponse SearchReferenceSets(global::Google.Genomics.V1.SearchReferenceSetsRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchReferenceSets, null, options, request);
      }
      /// <summary>
      ///  Searches for reference sets which match the given criteria.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.searchReferenceSets](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L71)
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Genomics.V1.SearchReferenceSetsResponse> SearchReferenceSetsAsync(global::Google.Genomics.V1.SearchReferenceSetsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SearchReferenceSetsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Searches for reference sets which match the given criteria.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.searchReferenceSets](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L71)
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Genomics.V1.SearchReferenceSetsResponse> SearchReferenceSetsAsync(global::Google.Genomics.V1.SearchReferenceSetsRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchReferenceSets, null, options, request);
      }
      /// <summary>
      ///  Gets a reference set.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.getReferenceSet](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L83).
      /// </summary>
      public virtual global::Google.Genomics.V1.ReferenceSet GetReferenceSet(global::Google.Genomics.V1.GetReferenceSetRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReferenceSet(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets a reference set.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.getReferenceSet](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L83).
      /// </summary>
      public virtual global::Google.Genomics.V1.ReferenceSet GetReferenceSet(global::Google.Genomics.V1.GetReferenceSetRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReferenceSet, null, options, request);
      }
      /// <summary>
      ///  Gets a reference set.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.getReferenceSet](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L83).
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Genomics.V1.ReferenceSet> GetReferenceSetAsync(global::Google.Genomics.V1.GetReferenceSetRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReferenceSetAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets a reference set.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.getReferenceSet](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L83).
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Genomics.V1.ReferenceSet> GetReferenceSetAsync(global::Google.Genomics.V1.GetReferenceSetRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReferenceSet, null, options, request);
      }
      /// <summary>
      ///  Searches for references which match the given criteria.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.searchReferences](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L146).
      /// </summary>
      public virtual global::Google.Genomics.V1.SearchReferencesResponse SearchReferences(global::Google.Genomics.V1.SearchReferencesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SearchReferences(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Searches for references which match the given criteria.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.searchReferences](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L146).
      /// </summary>
      public virtual global::Google.Genomics.V1.SearchReferencesResponse SearchReferences(global::Google.Genomics.V1.SearchReferencesRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchReferences, null, options, request);
      }
      /// <summary>
      ///  Searches for references which match the given criteria.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.searchReferences](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L146).
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Genomics.V1.SearchReferencesResponse> SearchReferencesAsync(global::Google.Genomics.V1.SearchReferencesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SearchReferencesAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Searches for references which match the given criteria.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.searchReferences](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L146).
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Genomics.V1.SearchReferencesResponse> SearchReferencesAsync(global::Google.Genomics.V1.SearchReferencesRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchReferences, null, options, request);
      }
      /// <summary>
      ///  Gets a reference.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.getReference](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L158).
      /// </summary>
      public virtual global::Google.Genomics.V1.Reference GetReference(global::Google.Genomics.V1.GetReferenceRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReference(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets a reference.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.getReference](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L158).
      /// </summary>
      public virtual global::Google.Genomics.V1.Reference GetReference(global::Google.Genomics.V1.GetReferenceRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReference, null, options, request);
      }
      /// <summary>
      ///  Gets a reference.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.getReference](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L158).
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Genomics.V1.Reference> GetReferenceAsync(global::Google.Genomics.V1.GetReferenceRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReferenceAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets a reference.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.getReference](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L158).
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Genomics.V1.Reference> GetReferenceAsync(global::Google.Genomics.V1.GetReferenceRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReference, null, options, request);
      }
      /// <summary>
      ///  Lists the bases in a reference, optionally restricted to a range.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.getReferenceBases](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L221).
      /// </summary>
      public virtual global::Google.Genomics.V1.ListBasesResponse ListBases(global::Google.Genomics.V1.ListBasesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListBases(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Lists the bases in a reference, optionally restricted to a range.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.getReferenceBases](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L221).
      /// </summary>
      public virtual global::Google.Genomics.V1.ListBasesResponse ListBases(global::Google.Genomics.V1.ListBasesRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListBases, null, options, request);
      }
      /// <summary>
      ///  Lists the bases in a reference, optionally restricted to a range.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.getReferenceBases](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L221).
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Genomics.V1.ListBasesResponse> ListBasesAsync(global::Google.Genomics.V1.ListBasesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListBasesAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Lists the bases in a reference, optionally restricted to a range.
      ///
      ///  For the definitions of references and other genomics resources, see
      ///  [Fundamentals of Google
      ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
      ///
      ///  Implements
      ///  [GlobalAllianceApi.getReferenceBases](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/referencemethods.avdl#L221).
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Genomics.V1.ListBasesResponse> ListBasesAsync(global::Google.Genomics.V1.ListBasesRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListBases, null, options, request);
      }
      protected override ReferenceServiceV1Client NewInstance(ClientBaseConfiguration configuration)
      {
        return new ReferenceServiceV1Client(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(ReferenceServiceV1Base serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SearchReferenceSets, serviceImpl.SearchReferenceSets)
          .AddMethod(__Method_GetReferenceSet, serviceImpl.GetReferenceSet)
          .AddMethod(__Method_SearchReferences, serviceImpl.SearchReferences)
          .AddMethod(__Method_GetReference, serviceImpl.GetReference)
          .AddMethod(__Method_ListBases, serviceImpl.ListBases).Build();
    }

  }
}
#endregion
