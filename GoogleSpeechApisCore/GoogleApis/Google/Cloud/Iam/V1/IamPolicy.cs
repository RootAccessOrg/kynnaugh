// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/iam/v1/iam_policy.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Iam.V1 {

  /// <summary>Holder for reflection information generated from google/iam/v1/iam_policy.proto</summary>
  public static partial class IamPolicyReflection {

    #region Descriptor
    /// <summary>File descriptor for google/iam/v1/iam_policy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IamPolicyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5nb29nbGUvaWFtL3YxL2lhbV9wb2xpY3kucHJvdG8SDWdvb2dsZS5pYW0u",
            "djEaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aGmdvb2dsZS9pYW0v",
            "djEvcG9saWN5LnByb3RvIk4KE1NldElhbVBvbGljeVJlcXVlc3QSEAoIcmVz",
            "b3VyY2UYASABKAkSJQoGcG9saWN5GAIgASgLMhUuZ29vZ2xlLmlhbS52MS5Q",
            "b2xpY3kiJwoTR2V0SWFtUG9saWN5UmVxdWVzdBIQCghyZXNvdXJjZRgBIAEo",
            "CSJCChlUZXN0SWFtUGVybWlzc2lvbnNSZXF1ZXN0EhAKCHJlc291cmNlGAEg",
            "ASgJEhMKC3Blcm1pc3Npb25zGAIgAygJIjEKGlRlc3RJYW1QZXJtaXNzaW9u",
            "c1Jlc3BvbnNlEhMKC3Blcm1pc3Npb25zGAEgAygJMpQDCglJQU1Qb2xpY3kS",
            "dAoMU2V0SWFtUG9saWN5EiIuZ29vZ2xlLmlhbS52MS5TZXRJYW1Qb2xpY3lS",
            "ZXF1ZXN0GhUuZ29vZ2xlLmlhbS52MS5Qb2xpY3kiKYLT5JMCIyIeL3YxL3ty",
            "ZXNvdXJjZT0qKn06c2V0SWFtUG9saWN5OgEqEnQKDEdldElhbVBvbGljeRIi",
            "Lmdvb2dsZS5pYW0udjEuR2V0SWFtUG9saWN5UmVxdWVzdBoVLmdvb2dsZS5p",
            "YW0udjEuUG9saWN5IimC0+STAiMiHi92MS97cmVzb3VyY2U9Kip9OmdldElh",
            "bVBvbGljeToBKhKaAQoSVGVzdElhbVBlcm1pc3Npb25zEiguZ29vZ2xlLmlh",
            "bS52MS5UZXN0SWFtUGVybWlzc2lvbnNSZXF1ZXN0GikuZ29vZ2xlLmlhbS52",
            "MS5UZXN0SWFtUGVybWlzc2lvbnNSZXNwb25zZSIvgtPkkwIpIiQvdjEve3Jl",
            "c291cmNlPSoqfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpCcAoRY29tLmdvb2ds",
            "ZS5pYW0udjFCDklhbVBvbGljeVByb3RvUAFaMGdvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvaWFtL3YxO2lhbfgBAaoCE0dvb2dsZS5D",
            "bG91ZC5JYW0uVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Cloud.Iam.V1.PolicyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Iam.V1.SetIamPolicyRequest), global::Google.Cloud.Iam.V1.SetIamPolicyRequest.Parser, new[]{ "Resource", "Policy" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Iam.V1.GetIamPolicyRequest), global::Google.Cloud.Iam.V1.GetIamPolicyRequest.Parser, new[]{ "Resource" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Iam.V1.TestIamPermissionsRequest), global::Google.Cloud.Iam.V1.TestIamPermissionsRequest.Parser, new[]{ "Resource", "Permissions" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Iam.V1.TestIamPermissionsResponse), global::Google.Cloud.Iam.V1.TestIamPermissionsResponse.Parser, new[]{ "Permissions" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Request message for `SetIamPolicy` method.
  /// </summary>
  public sealed partial class SetIamPolicyRequest : pb::IMessage<SetIamPolicyRequest> {
    private static readonly pb::MessageParser<SetIamPolicyRequest> _parser = new pb::MessageParser<SetIamPolicyRequest>(() => new SetIamPolicyRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetIamPolicyRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Iam.V1.IamPolicyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetIamPolicyRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetIamPolicyRequest(SetIamPolicyRequest other) : this() {
      resource_ = other.resource_;
      Policy = other.policy_ != null ? other.Policy.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetIamPolicyRequest Clone() {
      return new SetIamPolicyRequest(this);
    }

    /// <summary>Field number for the "resource" field.</summary>
    public const int ResourceFieldNumber = 1;
    private string resource_ = "";
    /// <summary>
    ///  REQUIRED: The resource for which the policy is being specified.
    ///  `resource` is usually specified as a path. For example, a Project
    ///  resource is specified as `projects/{project}`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Resource {
      get { return resource_; }
      set {
        resource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "policy" field.</summary>
    public const int PolicyFieldNumber = 2;
    private global::Google.Cloud.Iam.V1.Policy policy_;
    /// <summary>
    ///  REQUIRED: The complete policy to be applied to the `resource`. The size of
    ///  the policy is limited to a few 10s of KB. An empty policy is a
    ///  valid policy but certain Cloud Platform services (such as Projects)
    ///  might reject them.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Iam.V1.Policy Policy {
      get { return policy_; }
      set {
        policy_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetIamPolicyRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetIamPolicyRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Resource != other.Resource) return false;
      if (!object.Equals(Policy, other.Policy)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Resource.Length != 0) hash ^= Resource.GetHashCode();
      if (policy_ != null) hash ^= Policy.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Resource.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Resource);
      }
      if (policy_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Policy);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Resource.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Resource);
      }
      if (policy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Policy);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetIamPolicyRequest other) {
      if (other == null) {
        return;
      }
      if (other.Resource.Length != 0) {
        Resource = other.Resource;
      }
      if (other.policy_ != null) {
        if (policy_ == null) {
          policy_ = new global::Google.Cloud.Iam.V1.Policy();
        }
        Policy.MergeFrom(other.Policy);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Resource = input.ReadString();
            break;
          }
          case 18: {
            if (policy_ == null) {
              policy_ = new global::Google.Cloud.Iam.V1.Policy();
            }
            input.ReadMessage(policy_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Request message for `GetIamPolicy` method.
  /// </summary>
  public sealed partial class GetIamPolicyRequest : pb::IMessage<GetIamPolicyRequest> {
    private static readonly pb::MessageParser<GetIamPolicyRequest> _parser = new pb::MessageParser<GetIamPolicyRequest>(() => new GetIamPolicyRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetIamPolicyRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Iam.V1.IamPolicyReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetIamPolicyRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetIamPolicyRequest(GetIamPolicyRequest other) : this() {
      resource_ = other.resource_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetIamPolicyRequest Clone() {
      return new GetIamPolicyRequest(this);
    }

    /// <summary>Field number for the "resource" field.</summary>
    public const int ResourceFieldNumber = 1;
    private string resource_ = "";
    /// <summary>
    ///  REQUIRED: The resource for which the policy is being requested.
    ///  `resource` is usually specified as a path. For example, a Project
    ///  resource is specified as `projects/{project}`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Resource {
      get { return resource_; }
      set {
        resource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetIamPolicyRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetIamPolicyRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Resource != other.Resource) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Resource.Length != 0) hash ^= Resource.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Resource.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Resource);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Resource.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Resource);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetIamPolicyRequest other) {
      if (other == null) {
        return;
      }
      if (other.Resource.Length != 0) {
        Resource = other.Resource;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Resource = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Request message for `TestIamPermissions` method.
  /// </summary>
  public sealed partial class TestIamPermissionsRequest : pb::IMessage<TestIamPermissionsRequest> {
    private static readonly pb::MessageParser<TestIamPermissionsRequest> _parser = new pb::MessageParser<TestIamPermissionsRequest>(() => new TestIamPermissionsRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TestIamPermissionsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Iam.V1.IamPolicyReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TestIamPermissionsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TestIamPermissionsRequest(TestIamPermissionsRequest other) : this() {
      resource_ = other.resource_;
      permissions_ = other.permissions_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TestIamPermissionsRequest Clone() {
      return new TestIamPermissionsRequest(this);
    }

    /// <summary>Field number for the "resource" field.</summary>
    public const int ResourceFieldNumber = 1;
    private string resource_ = "";
    /// <summary>
    ///  REQUIRED: The resource for which the policy detail is being requested.
    ///  `resource` is usually specified as a path. For example, a Project
    ///  resource is specified as `projects/{project}`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Resource {
      get { return resource_; }
      set {
        resource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "permissions" field.</summary>
    public const int PermissionsFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_permissions_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> permissions_ = new pbc::RepeatedField<string>();
    /// <summary>
    ///  The set of permissions to check for the `resource`. Permissions with
    ///  wildcards (such as '*' or 'storage.*') are not allowed. For more
    ///  information see
    ///  [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Permissions {
      get { return permissions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TestIamPermissionsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TestIamPermissionsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Resource != other.Resource) return false;
      if(!permissions_.Equals(other.permissions_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Resource.Length != 0) hash ^= Resource.GetHashCode();
      hash ^= permissions_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Resource.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Resource);
      }
      permissions_.WriteTo(output, _repeated_permissions_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Resource.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Resource);
      }
      size += permissions_.CalculateSize(_repeated_permissions_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TestIamPermissionsRequest other) {
      if (other == null) {
        return;
      }
      if (other.Resource.Length != 0) {
        Resource = other.Resource;
      }
      permissions_.Add(other.permissions_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Resource = input.ReadString();
            break;
          }
          case 18: {
            permissions_.AddEntriesFrom(input, _repeated_permissions_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Response message for `TestIamPermissions` method.
  /// </summary>
  public sealed partial class TestIamPermissionsResponse : pb::IMessage<TestIamPermissionsResponse> {
    private static readonly pb::MessageParser<TestIamPermissionsResponse> _parser = new pb::MessageParser<TestIamPermissionsResponse>(() => new TestIamPermissionsResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TestIamPermissionsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Iam.V1.IamPolicyReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TestIamPermissionsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TestIamPermissionsResponse(TestIamPermissionsResponse other) : this() {
      permissions_ = other.permissions_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TestIamPermissionsResponse Clone() {
      return new TestIamPermissionsResponse(this);
    }

    /// <summary>Field number for the "permissions" field.</summary>
    public const int PermissionsFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_permissions_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> permissions_ = new pbc::RepeatedField<string>();
    /// <summary>
    ///  A subset of `TestPermissionsRequest.permissions` that the caller is
    ///  allowed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Permissions {
      get { return permissions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TestIamPermissionsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TestIamPermissionsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!permissions_.Equals(other.permissions_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= permissions_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      permissions_.WriteTo(output, _repeated_permissions_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += permissions_.CalculateSize(_repeated_permissions_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TestIamPermissionsResponse other) {
      if (other == null) {
        return;
      }
      permissions_.Add(other.permissions_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            permissions_.AddEntriesFrom(input, _repeated_permissions_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
