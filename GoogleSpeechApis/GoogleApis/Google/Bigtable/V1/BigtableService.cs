// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/bigtable/v1/bigtable_service.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Bigtable.V1 {

  /// <summary>Holder for reflection information generated from google/bigtable/v1/bigtable_service.proto</summary>
  public static partial class BigtableServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/bigtable/v1/bigtable_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BigtableServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilnb29nbGUvYmlndGFibGUvdjEvYmlndGFibGVfc2VydmljZS5wcm90bxIS",
            "Z29vZ2xlLmJpZ3RhYmxlLnYxGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnBy",
            "b3RvGiZnb29nbGUvYmlndGFibGUvdjEvYmlndGFibGVfZGF0YS5wcm90bxoy",
            "Z29vZ2xlL2JpZ3RhYmxlL3YxL2JpZ3RhYmxlX3NlcnZpY2VfbWVzc2FnZXMu",
            "cHJvdG8aG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90bzLdCAoPQmlndGFi",
            "bGVTZXJ2aWNlEqUBCghSZWFkUm93cxIjLmdvb2dsZS5iaWd0YWJsZS52MS5S",
            "ZWFkUm93c1JlcXVlc3QaJC5nb29nbGUuYmlndGFibGUudjEuUmVhZFJvd3NS",
            "ZXNwb25zZSJMgtPkkwJGIkEvdjEve3RhYmxlX25hbWU9cHJvamVjdHMvKi96",
            "b25lcy8qL2NsdXN0ZXJzLyovdGFibGVzLyp9L3Jvd3M6cmVhZDoBKjABErcB",
            "Cg1TYW1wbGVSb3dLZXlzEiguZ29vZ2xlLmJpZ3RhYmxlLnYxLlNhbXBsZVJv",
            "d0tleXNSZXF1ZXN0GikuZ29vZ2xlLmJpZ3RhYmxlLnYxLlNhbXBsZVJvd0tl",
            "eXNSZXNwb25zZSJPgtPkkwJJEkcvdjEve3RhYmxlX25hbWU9cHJvamVjdHMv",
            "Ki96b25lcy8qL2NsdXN0ZXJzLyovdGFibGVzLyp9L3Jvd3M6c2FtcGxlS2V5",
            "czABEqMBCglNdXRhdGVSb3cSJC5nb29nbGUuYmlndGFibGUudjEuTXV0YXRl",
            "Um93UmVxdWVzdBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eSJYgtPkkwJSIk0v",
            "djEve3RhYmxlX25hbWU9cHJvamVjdHMvKi96b25lcy8qL2NsdXN0ZXJzLyov",
            "dGFibGVzLyp9L3Jvd3Mve3Jvd19rZXl9Om11dGF0ZToBKhKqAQoKTXV0YXRl",
            "Um93cxIlLmdvb2dsZS5iaWd0YWJsZS52MS5NdXRhdGVSb3dzUmVxdWVzdBom",
            "Lmdvb2dsZS5iaWd0YWJsZS52MS5NdXRhdGVSb3dzUmVzcG9uc2UiTYLT5JMC",
            "RyJCL3YxL3t0YWJsZV9uYW1lPXByb2plY3RzLyovem9uZXMvKi9jbHVzdGVy",
            "cy8qL3RhYmxlcy8qfTptdXRhdGVSb3dzOgEqEtIBChFDaGVja0FuZE11dGF0",
            "ZVJvdxIsLmdvb2dsZS5iaWd0YWJsZS52MS5DaGVja0FuZE11dGF0ZVJvd1Jl",
            "cXVlc3QaLS5nb29nbGUuYmlndGFibGUudjEuQ2hlY2tBbmRNdXRhdGVSb3dS",
            "ZXNwb25zZSJggtPkkwJaIlUvdjEve3RhYmxlX25hbWU9cHJvamVjdHMvKi96",
            "b25lcy8qL2NsdXN0ZXJzLyovdGFibGVzLyp9L3Jvd3Mve3Jvd19rZXl9OmNo",
            "ZWNrQW5kTXV0YXRlOgEqEr8BChJSZWFkTW9kaWZ5V3JpdGVSb3cSLS5nb29n",
            "bGUuYmlndGFibGUudjEuUmVhZE1vZGlmeVdyaXRlUm93UmVxdWVzdBoXLmdv",
            "b2dsZS5iaWd0YWJsZS52MS5Sb3ciYYLT5JMCWyJWL3YxL3t0YWJsZV9uYW1l",
            "PXByb2plY3RzLyovem9uZXMvKi9jbHVzdGVycy8qL3RhYmxlcy8qfS9yb3dz",
            "L3tyb3dfa2V5fTpyZWFkTW9kaWZ5V3JpdGU6ASpCcAoWY29tLmdvb2dsZS5i",
            "aWd0YWJsZS52MUIVQmlndGFibGVTZXJ2aWNlc1Byb3RvUAFaOmdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYmlndGFibGUvdjE7Ymln",
            "dGFibGWIAQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Bigtable.V1.BigtableDataReflection.Descriptor, global::Google.Bigtable.V1.BigtableServiceMessagesReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null));
    }
    #endregion

  }
}

#endregion Designer generated code