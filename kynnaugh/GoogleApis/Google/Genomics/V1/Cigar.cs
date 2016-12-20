// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/genomics/v1/cigar.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Genomics.V1 {

  /// <summary>Holder for reflection information generated from google/genomics/v1/cigar.proto</summary>
  public static partial class CigarReflection {

    #region Descriptor
    /// <summary>File descriptor for google/genomics/v1/cigar.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CigarReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5nb29nbGUvZ2Vub21pY3MvdjEvY2lnYXIucHJvdG8SEmdvb2dsZS5nZW5v",
            "bWljcy52MRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKvAgoJQ2ln",
            "YXJVbml0EjoKCW9wZXJhdGlvbhgBIAEoDjInLmdvb2dsZS5nZW5vbWljcy52",
            "MS5DaWdhclVuaXQuT3BlcmF0aW9uEhgKEG9wZXJhdGlvbl9sZW5ndGgYAiAB",
            "KAMSGgoScmVmZXJlbmNlX3NlcXVlbmNlGAMgASgJIq8BCglPcGVyYXRpb24S",
            "GQoVT1BFUkFUSU9OX1VOU1BFQ0lGSUVEEAASEwoPQUxJR05NRU5UX01BVENI",
            "EAESCgoGSU5TRVJUEAISCgoGREVMRVRFEAMSCAoEU0tJUBAEEg0KCUNMSVBf",
            "U09GVBAFEg0KCUNMSVBfSEFSRBAGEgcKA1BBRBAHEhIKDlNFUVVFTkNFX01B",
            "VENIEAgSFQoRU0VRVUVOQ0VfTUlTTUFUQ0gQCUJlChZjb20uZ29vZ2xlLmdl",
            "bm9taWNzLnYxQgpDaWdhclByb3RvUAFaOmdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvZ2Vub21pY3MvdjE7Z2Vub21pY3P4AQFiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Genomics.V1.CigarUnit), global::Google.Genomics.V1.CigarUnit.Parser, new[]{ "Operation", "OperationLength", "ReferenceSequence" }, null, new[]{ typeof(global::Google.Genomics.V1.CigarUnit.Types.Operation) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  A single CIGAR operation.
  /// </summary>
  public sealed partial class CigarUnit : pb::IMessage<CigarUnit> {
    private static readonly pb::MessageParser<CigarUnit> _parser = new pb::MessageParser<CigarUnit>(() => new CigarUnit());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CigarUnit> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Genomics.V1.CigarReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CigarUnit() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CigarUnit(CigarUnit other) : this() {
      operation_ = other.operation_;
      operationLength_ = other.operationLength_;
      referenceSequence_ = other.referenceSequence_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CigarUnit Clone() {
      return new CigarUnit(this);
    }

    /// <summary>Field number for the "operation" field.</summary>
    public const int OperationFieldNumber = 1;
    private global::Google.Genomics.V1.CigarUnit.Types.Operation operation_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Genomics.V1.CigarUnit.Types.Operation Operation {
      get { return operation_; }
      set {
        operation_ = value;
      }
    }

    /// <summary>Field number for the "operation_length" field.</summary>
    public const int OperationLengthFieldNumber = 2;
    private long operationLength_;
    /// <summary>
    ///  The number of genomic bases that the operation runs for. Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long OperationLength {
      get { return operationLength_; }
      set {
        operationLength_ = value;
      }
    }

    /// <summary>Field number for the "reference_sequence" field.</summary>
    public const int ReferenceSequenceFieldNumber = 3;
    private string referenceSequence_ = "";
    /// <summary>
    ///  `referenceSequence` is only used at mismatches
    ///  (`SEQUENCE_MISMATCH`) and deletions (`DELETE`).
    ///  Filling this field replaces SAM's MD tag. If the relevant information is
    ///  not available, this field is unset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ReferenceSequence {
      get { return referenceSequence_; }
      set {
        referenceSequence_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CigarUnit);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CigarUnit other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Operation != other.Operation) return false;
      if (OperationLength != other.OperationLength) return false;
      if (ReferenceSequence != other.ReferenceSequence) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Operation != 0) hash ^= Operation.GetHashCode();
      if (OperationLength != 0L) hash ^= OperationLength.GetHashCode();
      if (ReferenceSequence.Length != 0) hash ^= ReferenceSequence.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Operation != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Operation);
      }
      if (OperationLength != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(OperationLength);
      }
      if (ReferenceSequence.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ReferenceSequence);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Operation != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Operation);
      }
      if (OperationLength != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(OperationLength);
      }
      if (ReferenceSequence.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReferenceSequence);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CigarUnit other) {
      if (other == null) {
        return;
      }
      if (other.Operation != 0) {
        Operation = other.Operation;
      }
      if (other.OperationLength != 0L) {
        OperationLength = other.OperationLength;
      }
      if (other.ReferenceSequence.Length != 0) {
        ReferenceSequence = other.ReferenceSequence;
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
          case 8: {
            operation_ = (global::Google.Genomics.V1.CigarUnit.Types.Operation) input.ReadEnum();
            break;
          }
          case 16: {
            OperationLength = input.ReadInt64();
            break;
          }
          case 26: {
            ReferenceSequence = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CigarUnit message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      ///  Describes the different types of CIGAR alignment operations that exist.
      ///  Used wherever CIGAR alignments are used.
      /// </summary>
      public enum Operation {
        [pbr::OriginalName("OPERATION_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        ///  An alignment match indicates that a sequence can be aligned to the
        ///  reference without evidence of an INDEL. Unlike the
        ///  `SEQUENCE_MATCH` and `SEQUENCE_MISMATCH` operators,
        ///  the `ALIGNMENT_MATCH` operator does not indicate whether the
        ///  reference and read sequences are an exact match. This operator is
        ///  equivalent to SAM's `M`.
        /// </summary>
        [pbr::OriginalName("ALIGNMENT_MATCH")] AlignmentMatch = 1,
        /// <summary>
        ///  The insert operator indicates that the read contains evidence of bases
        ///  being inserted into the reference. This operator is equivalent to SAM's
        ///  `I`.
        /// </summary>
        [pbr::OriginalName("INSERT")] Insert = 2,
        /// <summary>
        ///  The delete operator indicates that the read contains evidence of bases
        ///  being deleted from the reference. This operator is equivalent to SAM's
        ///  `D`.
        /// </summary>
        [pbr::OriginalName("DELETE")] Delete = 3,
        /// <summary>
        ///  The skip operator indicates that this read skips a long segment of the
        ///  reference, but the bases have not been deleted. This operator is commonly
        ///  used when working with RNA-seq data, where reads may skip long segments
        ///  of the reference between exons. This operator is equivalent to SAM's
        ///  `N`.
        /// </summary>
        [pbr::OriginalName("SKIP")] Skip = 4,
        /// <summary>
        ///  The soft clip operator indicates that bases at the start/end of a read
        ///  have not been considered during alignment. This may occur if the majority
        ///  of a read maps, except for low quality bases at the start/end of a read.
        ///  This operator is equivalent to SAM's `S`. Bases that are soft
        ///  clipped will still be stored in the read.
        /// </summary>
        [pbr::OriginalName("CLIP_SOFT")] ClipSoft = 5,
        /// <summary>
        ///  The hard clip operator indicates that bases at the start/end of a read
        ///  have been omitted from this alignment. This may occur if this linear
        ///  alignment is part of a chimeric alignment, or if the read has been
        ///  trimmed (for example, during error correction or to trim poly-A tails for
        ///  RNA-seq). This operator is equivalent to SAM's `H`.
        /// </summary>
        [pbr::OriginalName("CLIP_HARD")] ClipHard = 6,
        /// <summary>
        ///  The pad operator indicates that there is padding in an alignment. This
        ///  operator is equivalent to SAM's `P`.
        /// </summary>
        [pbr::OriginalName("PAD")] Pad = 7,
        /// <summary>
        ///  This operator indicates that this portion of the aligned sequence exactly
        ///  matches the reference. This operator is equivalent to SAM's `=`.
        /// </summary>
        [pbr::OriginalName("SEQUENCE_MATCH")] SequenceMatch = 8,
        /// <summary>
        ///  This operator indicates that this portion of the aligned sequence is an
        ///  alignment match to the reference, but a sequence mismatch. This can
        ///  indicate a SNP or a read error. This operator is equivalent to SAM's
        ///  `X`.
        /// </summary>
        [pbr::OriginalName("SEQUENCE_MISMATCH")] SequenceMismatch = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
