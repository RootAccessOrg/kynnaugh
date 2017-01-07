// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/genomics/v1/range.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Genomics.V1 {

  /// <summary>Holder for reflection information generated from google/genomics/v1/range.proto</summary>
  public static partial class RangeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/genomics/v1/range.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RangeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5nb29nbGUvZ2Vub21pY3MvdjEvcmFuZ2UucHJvdG8SEmdvb2dsZS5nZW5v",
            "bWljcy52MRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byI7CgVSYW5n",
            "ZRIWCg5yZWZlcmVuY2VfbmFtZRgBIAEoCRINCgVzdGFydBgCIAEoAxILCgNl",
            "bmQYAyABKANCZQoWY29tLmdvb2dsZS5nZW5vbWljcy52MUIKUmFuZ2VQcm90",
            "b1ABWjpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2dl",
            "bm9taWNzL3YxO2dlbm9taWNz+AEBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Genomics.V1.Range), global::Google.Genomics.V1.Range.Parser, new[]{ "ReferenceName", "Start", "End" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  A 0-based half-open genomic coordinate range for search requests.
  /// </summary>
  public sealed partial class Range : pb::IMessage<Range> {
    private static readonly pb::MessageParser<Range> _parser = new pb::MessageParser<Range>(() => new Range());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Range> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Genomics.V1.RangeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Range() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Range(Range other) : this() {
      referenceName_ = other.referenceName_;
      start_ = other.start_;
      end_ = other.end_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Range Clone() {
      return new Range(this);
    }

    /// <summary>Field number for the "reference_name" field.</summary>
    public const int ReferenceNameFieldNumber = 1;
    private string referenceName_ = "";
    /// <summary>
    ///  The reference sequence name, for example `chr1`,
    ///  `1`, or `chrX`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ReferenceName {
      get { return referenceName_; }
      set {
        referenceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "start" field.</summary>
    public const int StartFieldNumber = 2;
    private long start_;
    /// <summary>
    ///  The start position of the range on the reference, 0-based inclusive.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Start {
      get { return start_; }
      set {
        start_ = value;
      }
    }

    /// <summary>Field number for the "end" field.</summary>
    public const int EndFieldNumber = 3;
    private long end_;
    /// <summary>
    ///  The end position of the range on the reference, 0-based exclusive.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long End {
      get { return end_; }
      set {
        end_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Range);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Range other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ReferenceName != other.ReferenceName) return false;
      if (Start != other.Start) return false;
      if (End != other.End) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ReferenceName.Length != 0) hash ^= ReferenceName.GetHashCode();
      if (Start != 0L) hash ^= Start.GetHashCode();
      if (End != 0L) hash ^= End.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ReferenceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ReferenceName);
      }
      if (Start != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Start);
      }
      if (End != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(End);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ReferenceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReferenceName);
      }
      if (Start != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Start);
      }
      if (End != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(End);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Range other) {
      if (other == null) {
        return;
      }
      if (other.ReferenceName.Length != 0) {
        ReferenceName = other.ReferenceName;
      }
      if (other.Start != 0L) {
        Start = other.Start;
      }
      if (other.End != 0L) {
        End = other.End;
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
            ReferenceName = input.ReadString();
            break;
          }
          case 16: {
            Start = input.ReadInt64();
            break;
          }
          case 24: {
            End = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
