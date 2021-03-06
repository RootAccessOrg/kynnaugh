// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/genomics/v1/readalignment.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Genomics.V1 {

  /// <summary>Holder for reflection information generated from google/genomics/v1/readalignment.proto</summary>
  public static partial class ReadalignmentReflection {

    #region Descriptor
    /// <summary>File descriptor for google/genomics/v1/readalignment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReadalignmentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZnb29nbGUvZ2Vub21pY3MvdjEvcmVhZGFsaWdubWVudC5wcm90bxISZ29v",
            "Z2xlLmdlbm9taWNzLnYxGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3Rv",
            "Gh5nb29nbGUvZ2Vub21pY3MvdjEvY2lnYXIucHJvdG8aIWdvb2dsZS9nZW5v",
            "bWljcy92MS9wb3NpdGlvbi5wcm90bxocZ29vZ2xlL3Byb3RvYnVmL3N0cnVj",
            "dC5wcm90byKIAQoPTGluZWFyQWxpZ25tZW50Ei4KCHBvc2l0aW9uGAEgASgL",
            "MhwuZ29vZ2xlLmdlbm9taWNzLnYxLlBvc2l0aW9uEhcKD21hcHBpbmdfcXVh",
            "bGl0eRgCIAEoBRIsCgVjaWdhchgDIAMoCzIdLmdvb2dsZS5nZW5vbWljcy52",
            "MS5DaWdhclVuaXQi2QQKBFJlYWQSCgoCaWQYASABKAkSFQoNcmVhZF9ncm91",
            "cF9pZBgCIAEoCRIZChFyZWFkX2dyb3VwX3NldF9pZBgDIAEoCRIVCg1mcmFn",
            "bWVudF9uYW1lGAQgASgJEhgKEHByb3Blcl9wbGFjZW1lbnQYBSABKAgSGgoS",
            "ZHVwbGljYXRlX2ZyYWdtZW50GAYgASgIEhcKD2ZyYWdtZW50X2xlbmd0aBgH",
            "IAEoBRITCgtyZWFkX251bWJlchgIIAEoBRIUCgxudW1iZXJfcmVhZHMYCSAB",
            "KAUSJAocZmFpbGVkX3ZlbmRvcl9xdWFsaXR5X2NoZWNrcxgKIAEoCBI2Cglh",
            "bGlnbm1lbnQYCyABKAsyIy5nb29nbGUuZ2Vub21pY3MudjEuTGluZWFyQWxp",
            "Z25tZW50EhsKE3NlY29uZGFyeV9hbGlnbm1lbnQYDCABKAgSHwoXc3VwcGxl",
            "bWVudGFyeV9hbGlnbm1lbnQYDSABKAgSGAoQYWxpZ25lZF9zZXF1ZW5jZRgO",
            "IAEoCRIXCg9hbGlnbmVkX3F1YWxpdHkYDyADKAUSOAoSbmV4dF9tYXRlX3Bv",
            "c2l0aW9uGBAgASgLMhwuZ29vZ2xlLmdlbm9taWNzLnYxLlBvc2l0aW9uEjAK",
            "BGluZm8YESADKAsyIi5nb29nbGUuZ2Vub21pY3MudjEuUmVhZC5JbmZvRW50",
            "cnkaRwoJSW5mb0VudHJ5EgsKA2tleRgBIAEoCRIpCgV2YWx1ZRgCIAEoCzIa",
            "Lmdvb2dsZS5wcm90b2J1Zi5MaXN0VmFsdWU6AjgBQm0KFmNvbS5nb29nbGUu",
            "Z2Vub21pY3MudjFCElJlYWRBbGlnbm1lbnRQcm90b1ABWjpnb29nbGUuZ29s",
            "YW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2dlbm9taWNzL3YxO2dlbm9t",
            "aWNz+AEBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Genomics.V1.CigarReflection.Descriptor, global::Google.Genomics.V1.PositionReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Genomics.V1.LinearAlignment), global::Google.Genomics.V1.LinearAlignment.Parser, new[]{ "Position", "MappingQuality", "Cigar" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Genomics.V1.Read), global::Google.Genomics.V1.Read.Parser, new[]{ "Id", "ReadGroupId", "ReadGroupSetId", "FragmentName", "ProperPlacement", "DuplicateFragment", "FragmentLength", "ReadNumber", "NumberReads", "FailedVendorQualityChecks", "Alignment", "SecondaryAlignment", "SupplementaryAlignment", "AlignedSequence", "AlignedQuality", "NextMatePosition", "Info" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  A linear alignment can be represented by one CIGAR string. Describes the
  ///  mapped position and local alignment of the read to the reference.
  /// </summary>
  public sealed partial class LinearAlignment : pb::IMessage<LinearAlignment> {
    private static readonly pb::MessageParser<LinearAlignment> _parser = new pb::MessageParser<LinearAlignment>(() => new LinearAlignment());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LinearAlignment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Genomics.V1.ReadalignmentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LinearAlignment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LinearAlignment(LinearAlignment other) : this() {
      Position = other.position_ != null ? other.Position.Clone() : null;
      mappingQuality_ = other.mappingQuality_;
      cigar_ = other.cigar_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LinearAlignment Clone() {
      return new LinearAlignment(this);
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 1;
    private global::Google.Genomics.V1.Position position_;
    /// <summary>
    ///  The position of this alignment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Genomics.V1.Position Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    /// <summary>Field number for the "mapping_quality" field.</summary>
    public const int MappingQualityFieldNumber = 2;
    private int mappingQuality_;
    /// <summary>
    ///  The mapping quality of this alignment. Represents how likely
    ///  the read maps to this position as opposed to other locations.
    ///
    ///  Specifically, this is -10 log10 Pr(mapping position is wrong), rounded to
    ///  the nearest integer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MappingQuality {
      get { return mappingQuality_; }
      set {
        mappingQuality_ = value;
      }
    }

    /// <summary>Field number for the "cigar" field.</summary>
    public const int CigarFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Genomics.V1.CigarUnit> _repeated_cigar_codec
        = pb::FieldCodec.ForMessage(26, global::Google.Genomics.V1.CigarUnit.Parser);
    private readonly pbc::RepeatedField<global::Google.Genomics.V1.CigarUnit> cigar_ = new pbc::RepeatedField<global::Google.Genomics.V1.CigarUnit>();
    /// <summary>
    ///  Represents the local alignment of this sequence (alignment matches, indels,
    ///  etc) against the reference.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Genomics.V1.CigarUnit> Cigar {
      get { return cigar_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LinearAlignment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LinearAlignment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Position, other.Position)) return false;
      if (MappingQuality != other.MappingQuality) return false;
      if(!cigar_.Equals(other.cigar_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (position_ != null) hash ^= Position.GetHashCode();
      if (MappingQuality != 0) hash ^= MappingQuality.GetHashCode();
      hash ^= cigar_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (position_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Position);
      }
      if (MappingQuality != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MappingQuality);
      }
      cigar_.WriteTo(output, _repeated_cigar_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      if (MappingQuality != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MappingQuality);
      }
      size += cigar_.CalculateSize(_repeated_cigar_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LinearAlignment other) {
      if (other == null) {
        return;
      }
      if (other.position_ != null) {
        if (position_ == null) {
          position_ = new global::Google.Genomics.V1.Position();
        }
        Position.MergeFrom(other.Position);
      }
      if (other.MappingQuality != 0) {
        MappingQuality = other.MappingQuality;
      }
      cigar_.Add(other.cigar_);
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
            if (position_ == null) {
              position_ = new global::Google.Genomics.V1.Position();
            }
            input.ReadMessage(position_);
            break;
          }
          case 16: {
            MappingQuality = input.ReadInt32();
            break;
          }
          case 26: {
            cigar_.AddEntriesFrom(input, _repeated_cigar_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  A read alignment describes a linear alignment of a string of DNA to a
  ///  [reference sequence][google.genomics.v1.Reference], in addition to metadata
  ///  about the fragment (the molecule of DNA sequenced) and the read (the bases
  ///  which were read by the sequencer). A read is equivalent to a line in a SAM
  ///  file. A read belongs to exactly one read group and exactly one
  ///  [read group set][google.genomics.v1.ReadGroupSet].
  ///
  ///  For more genomics resource definitions, see [Fundamentals of Google
  ///  Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)
  ///
  ///  ### Reverse-stranded reads
  ///
  ///  Mapped reads (reads having a non-null `alignment`) can be aligned to either
  ///  the forward or the reverse strand of their associated reference. Strandedness
  ///  of a mapped read is encoded by `alignment.position.reverseStrand`.
  ///
  ///  If we consider the reference to be a forward-stranded coordinate space of
  ///  `[0, reference.length)` with `0` as the left-most position and
  ///  `reference.length` as the right-most position, reads are always aligned left
  ///  to right. That is, `alignment.position.position` always refers to the
  ///  left-most reference coordinate and `alignment.cigar` describes the alignment
  ///  of this read to the reference from left to right. All per-base fields such as
  ///  `alignedSequence` and `alignedQuality` share this same left-to-right
  ///  orientation; this is true of reads which are aligned to either strand. For
  ///  reverse-stranded reads, this means that `alignedSequence` is the reverse
  ///  complement of the bases that were originally reported by the sequencing
  ///  machine.
  ///
  ///  ### Generating a reference-aligned sequence string
  ///
  ///  When interacting with mapped reads, it's often useful to produce a string
  ///  representing the local alignment of the read to reference. The following
  ///  pseudocode demonstrates one way of doing this:
  ///
  ///      out = ""
  ///      offset = 0
  ///      for c in read.alignment.cigar {
  ///        switch c.operation {
  ///        case "ALIGNMENT_MATCH", "SEQUENCE_MATCH", "SEQUENCE_MISMATCH":
  ///          out += read.alignedSequence[offset:offset+c.operationLength]
  ///          offset += c.operationLength
  ///          break
  ///        case "CLIP_SOFT", "INSERT":
  ///          offset += c.operationLength
  ///          break
  ///        case "PAD":
  ///          out += repeat("*", c.operationLength)
  ///          break
  ///        case "DELETE":
  ///          out += repeat("-", c.operationLength)
  ///          break
  ///        case "SKIP":
  ///          out += repeat(" ", c.operationLength)
  ///          break
  ///        case "CLIP_HARD":
  ///          break
  ///        }
  ///      }
  ///      return out
  ///
  ///  ### Converting to SAM's CIGAR string
  ///
  ///  The following pseudocode generates a SAM CIGAR string from the
  ///  `cigar` field. Note that this is a lossy conversion
  ///  (`cigar.referenceSequence` is lost).
  ///
  ///      cigarMap = {
  ///        "ALIGNMENT_MATCH": "M",
  ///        "INSERT": "I",
  ///        "DELETE": "D",
  ///        "SKIP": "N",
  ///        "CLIP_SOFT": "S",
  ///        "CLIP_HARD": "H",
  ///        "PAD": "P",
  ///        "SEQUENCE_MATCH": "=",
  ///        "SEQUENCE_MISMATCH": "X",
  ///      }
  ///      cigarStr = ""
  ///      for c in read.alignment.cigar {
  ///        cigarStr += c.operationLength + cigarMap[c.operation]
  ///      }
  ///      return cigarStr
  /// </summary>
  public sealed partial class Read : pb::IMessage<Read> {
    private static readonly pb::MessageParser<Read> _parser = new pb::MessageParser<Read>(() => new Read());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Read> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Genomics.V1.ReadalignmentReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Read() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Read(Read other) : this() {
      id_ = other.id_;
      readGroupId_ = other.readGroupId_;
      readGroupSetId_ = other.readGroupSetId_;
      fragmentName_ = other.fragmentName_;
      properPlacement_ = other.properPlacement_;
      duplicateFragment_ = other.duplicateFragment_;
      fragmentLength_ = other.fragmentLength_;
      readNumber_ = other.readNumber_;
      numberReads_ = other.numberReads_;
      failedVendorQualityChecks_ = other.failedVendorQualityChecks_;
      Alignment = other.alignment_ != null ? other.Alignment.Clone() : null;
      secondaryAlignment_ = other.secondaryAlignment_;
      supplementaryAlignment_ = other.supplementaryAlignment_;
      alignedSequence_ = other.alignedSequence_;
      alignedQuality_ = other.alignedQuality_.Clone();
      NextMatePosition = other.nextMatePosition_ != null ? other.NextMatePosition.Clone() : null;
      info_ = other.info_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Read Clone() {
      return new Read(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    ///  The server-generated read ID, unique across all reads. This is different
    ///  from the `fragmentName`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "read_group_id" field.</summary>
    public const int ReadGroupIdFieldNumber = 2;
    private string readGroupId_ = "";
    /// <summary>
    ///  The ID of the read group this read belongs to. A read belongs to exactly
    ///  one read group. This is a server-generated ID which is distinct from SAM's
    ///  RG tag (for that value, see
    ///  [ReadGroup.name][google.genomics.v1.ReadGroup.name]).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ReadGroupId {
      get { return readGroupId_; }
      set {
        readGroupId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "read_group_set_id" field.</summary>
    public const int ReadGroupSetIdFieldNumber = 3;
    private string readGroupSetId_ = "";
    /// <summary>
    ///  The ID of the read group set this read belongs to. A read belongs to
    ///  exactly one read group set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ReadGroupSetId {
      get { return readGroupSetId_; }
      set {
        readGroupSetId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fragment_name" field.</summary>
    public const int FragmentNameFieldNumber = 4;
    private string fragmentName_ = "";
    /// <summary>
    ///  The fragment name. Equivalent to QNAME (query template name) in SAM.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FragmentName {
      get { return fragmentName_; }
      set {
        fragmentName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "proper_placement" field.</summary>
    public const int ProperPlacementFieldNumber = 5;
    private bool properPlacement_;
    /// <summary>
    ///  The orientation and the distance between reads from the fragment are
    ///  consistent with the sequencing protocol (SAM flag 0x2).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ProperPlacement {
      get { return properPlacement_; }
      set {
        properPlacement_ = value;
      }
    }

    /// <summary>Field number for the "duplicate_fragment" field.</summary>
    public const int DuplicateFragmentFieldNumber = 6;
    private bool duplicateFragment_;
    /// <summary>
    ///  The fragment is a PCR or optical duplicate (SAM flag 0x400).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DuplicateFragment {
      get { return duplicateFragment_; }
      set {
        duplicateFragment_ = value;
      }
    }

    /// <summary>Field number for the "fragment_length" field.</summary>
    public const int FragmentLengthFieldNumber = 7;
    private int fragmentLength_;
    /// <summary>
    ///  The observed length of the fragment, equivalent to TLEN in SAM.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FragmentLength {
      get { return fragmentLength_; }
      set {
        fragmentLength_ = value;
      }
    }

    /// <summary>Field number for the "read_number" field.</summary>
    public const int ReadNumberFieldNumber = 8;
    private int readNumber_;
    /// <summary>
    ///  The read number in sequencing. 0-based and less than numberReads. This
    ///  field replaces SAM flag 0x40 and 0x80.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ReadNumber {
      get { return readNumber_; }
      set {
        readNumber_ = value;
      }
    }

    /// <summary>Field number for the "number_reads" field.</summary>
    public const int NumberReadsFieldNumber = 9;
    private int numberReads_;
    /// <summary>
    ///  The number of reads in the fragment (extension to SAM flag 0x1).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NumberReads {
      get { return numberReads_; }
      set {
        numberReads_ = value;
      }
    }

    /// <summary>Field number for the "failed_vendor_quality_checks" field.</summary>
    public const int FailedVendorQualityChecksFieldNumber = 10;
    private bool failedVendorQualityChecks_;
    /// <summary>
    ///  Whether this read did not pass filters, such as platform or vendor quality
    ///  controls (SAM flag 0x200).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool FailedVendorQualityChecks {
      get { return failedVendorQualityChecks_; }
      set {
        failedVendorQualityChecks_ = value;
      }
    }

    /// <summary>Field number for the "alignment" field.</summary>
    public const int AlignmentFieldNumber = 11;
    private global::Google.Genomics.V1.LinearAlignment alignment_;
    /// <summary>
    ///  The linear alignment for this alignment record. This field is null for
    ///  unmapped reads.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Genomics.V1.LinearAlignment Alignment {
      get { return alignment_; }
      set {
        alignment_ = value;
      }
    }

    /// <summary>Field number for the "secondary_alignment" field.</summary>
    public const int SecondaryAlignmentFieldNumber = 12;
    private bool secondaryAlignment_;
    /// <summary>
    ///  Whether this alignment is secondary. Equivalent to SAM flag 0x100.
    ///  A secondary alignment represents an alternative to the primary alignment
    ///  for this read. Aligners may return secondary alignments if a read can map
    ///  ambiguously to multiple coordinates in the genome. By convention, each read
    ///  has one and only one alignment where both `secondaryAlignment`
    ///  and `supplementaryAlignment` are false.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool SecondaryAlignment {
      get { return secondaryAlignment_; }
      set {
        secondaryAlignment_ = value;
      }
    }

    /// <summary>Field number for the "supplementary_alignment" field.</summary>
    public const int SupplementaryAlignmentFieldNumber = 13;
    private bool supplementaryAlignment_;
    /// <summary>
    ///  Whether this alignment is supplementary. Equivalent to SAM flag 0x800.
    ///  Supplementary alignments are used in the representation of a chimeric
    ///  alignment. In a chimeric alignment, a read is split into multiple
    ///  linear alignments that map to different reference contigs. The first
    ///  linear alignment in the read will be designated as the representative
    ///  alignment; the remaining linear alignments will be designated as
    ///  supplementary alignments. These alignments may have different mapping
    ///  quality scores. In each linear alignment in a chimeric alignment, the read
    ///  will be hard clipped. The `alignedSequence` and
    ///  `alignedQuality` fields in the alignment record will only
    ///  represent the bases for its respective linear alignment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool SupplementaryAlignment {
      get { return supplementaryAlignment_; }
      set {
        supplementaryAlignment_ = value;
      }
    }

    /// <summary>Field number for the "aligned_sequence" field.</summary>
    public const int AlignedSequenceFieldNumber = 14;
    private string alignedSequence_ = "";
    /// <summary>
    ///  The bases of the read sequence contained in this alignment record,
    ///  **without CIGAR operations applied** (equivalent to SEQ in SAM).
    ///  `alignedSequence` and `alignedQuality` may be
    ///  shorter than the full read sequence and quality. This will occur if the
    ///  alignment is part of a chimeric alignment, or if the read was trimmed. When
    ///  this occurs, the CIGAR for this read will begin/end with a hard clip
    ///  operator that will indicate the length of the excised sequence.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AlignedSequence {
      get { return alignedSequence_; }
      set {
        alignedSequence_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "aligned_quality" field.</summary>
    public const int AlignedQualityFieldNumber = 15;
    private static readonly pb::FieldCodec<int> _repeated_alignedQuality_codec
        = pb::FieldCodec.ForInt32(122);
    private readonly pbc::RepeatedField<int> alignedQuality_ = new pbc::RepeatedField<int>();
    /// <summary>
    ///  The quality of the read sequence contained in this alignment record
    ///  (equivalent to QUAL in SAM).
    ///  `alignedSequence` and `alignedQuality` may be shorter than the full read
    ///  sequence and quality. This will occur if the alignment is part of a
    ///  chimeric alignment, or if the read was trimmed. When this occurs, the CIGAR
    ///  for this read will begin/end with a hard clip operator that will indicate
    ///  the length of the excised sequence.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> AlignedQuality {
      get { return alignedQuality_; }
    }

    /// <summary>Field number for the "next_mate_position" field.</summary>
    public const int NextMatePositionFieldNumber = 16;
    private global::Google.Genomics.V1.Position nextMatePosition_;
    /// <summary>
    ///  The mapping of the primary alignment of the
    ///  `(readNumber+1)%numberReads` read in the fragment. It replaces
    ///  mate position and mate strand in SAM.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Genomics.V1.Position NextMatePosition {
      get { return nextMatePosition_; }
      set {
        nextMatePosition_ = value;
      }
    }

    /// <summary>Field number for the "info" field.</summary>
    public const int InfoFieldNumber = 17;
    private static readonly pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.ListValue>.Codec _map_info_codec
        = new pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.ListValue>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::Google.Protobuf.WellKnownTypes.ListValue.Parser), 138);
    private readonly pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.ListValue> info_ = new pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.ListValue>();
    /// <summary>
    ///  A map of additional read alignment information. This must be of the form
    ///  map&lt;string, string[]> (string key mapping to a list of string values).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.ListValue> Info {
      get { return info_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Read);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Read other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (ReadGroupId != other.ReadGroupId) return false;
      if (ReadGroupSetId != other.ReadGroupSetId) return false;
      if (FragmentName != other.FragmentName) return false;
      if (ProperPlacement != other.ProperPlacement) return false;
      if (DuplicateFragment != other.DuplicateFragment) return false;
      if (FragmentLength != other.FragmentLength) return false;
      if (ReadNumber != other.ReadNumber) return false;
      if (NumberReads != other.NumberReads) return false;
      if (FailedVendorQualityChecks != other.FailedVendorQualityChecks) return false;
      if (!object.Equals(Alignment, other.Alignment)) return false;
      if (SecondaryAlignment != other.SecondaryAlignment) return false;
      if (SupplementaryAlignment != other.SupplementaryAlignment) return false;
      if (AlignedSequence != other.AlignedSequence) return false;
      if(!alignedQuality_.Equals(other.alignedQuality_)) return false;
      if (!object.Equals(NextMatePosition, other.NextMatePosition)) return false;
      if (!Info.Equals(other.Info)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (ReadGroupId.Length != 0) hash ^= ReadGroupId.GetHashCode();
      if (ReadGroupSetId.Length != 0) hash ^= ReadGroupSetId.GetHashCode();
      if (FragmentName.Length != 0) hash ^= FragmentName.GetHashCode();
      if (ProperPlacement != false) hash ^= ProperPlacement.GetHashCode();
      if (DuplicateFragment != false) hash ^= DuplicateFragment.GetHashCode();
      if (FragmentLength != 0) hash ^= FragmentLength.GetHashCode();
      if (ReadNumber != 0) hash ^= ReadNumber.GetHashCode();
      if (NumberReads != 0) hash ^= NumberReads.GetHashCode();
      if (FailedVendorQualityChecks != false) hash ^= FailedVendorQualityChecks.GetHashCode();
      if (alignment_ != null) hash ^= Alignment.GetHashCode();
      if (SecondaryAlignment != false) hash ^= SecondaryAlignment.GetHashCode();
      if (SupplementaryAlignment != false) hash ^= SupplementaryAlignment.GetHashCode();
      if (AlignedSequence.Length != 0) hash ^= AlignedSequence.GetHashCode();
      hash ^= alignedQuality_.GetHashCode();
      if (nextMatePosition_ != null) hash ^= NextMatePosition.GetHashCode();
      hash ^= Info.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (ReadGroupId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ReadGroupId);
      }
      if (ReadGroupSetId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ReadGroupSetId);
      }
      if (FragmentName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(FragmentName);
      }
      if (ProperPlacement != false) {
        output.WriteRawTag(40);
        output.WriteBool(ProperPlacement);
      }
      if (DuplicateFragment != false) {
        output.WriteRawTag(48);
        output.WriteBool(DuplicateFragment);
      }
      if (FragmentLength != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(FragmentLength);
      }
      if (ReadNumber != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(ReadNumber);
      }
      if (NumberReads != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(NumberReads);
      }
      if (FailedVendorQualityChecks != false) {
        output.WriteRawTag(80);
        output.WriteBool(FailedVendorQualityChecks);
      }
      if (alignment_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Alignment);
      }
      if (SecondaryAlignment != false) {
        output.WriteRawTag(96);
        output.WriteBool(SecondaryAlignment);
      }
      if (SupplementaryAlignment != false) {
        output.WriteRawTag(104);
        output.WriteBool(SupplementaryAlignment);
      }
      if (AlignedSequence.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(AlignedSequence);
      }
      alignedQuality_.WriteTo(output, _repeated_alignedQuality_codec);
      if (nextMatePosition_ != null) {
        output.WriteRawTag(130, 1);
        output.WriteMessage(NextMatePosition);
      }
      info_.WriteTo(output, _map_info_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (ReadGroupId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReadGroupId);
      }
      if (ReadGroupSetId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReadGroupSetId);
      }
      if (FragmentName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FragmentName);
      }
      if (ProperPlacement != false) {
        size += 1 + 1;
      }
      if (DuplicateFragment != false) {
        size += 1 + 1;
      }
      if (FragmentLength != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FragmentLength);
      }
      if (ReadNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ReadNumber);
      }
      if (NumberReads != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumberReads);
      }
      if (FailedVendorQualityChecks != false) {
        size += 1 + 1;
      }
      if (alignment_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Alignment);
      }
      if (SecondaryAlignment != false) {
        size += 1 + 1;
      }
      if (SupplementaryAlignment != false) {
        size += 1 + 1;
      }
      if (AlignedSequence.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AlignedSequence);
      }
      size += alignedQuality_.CalculateSize(_repeated_alignedQuality_codec);
      if (nextMatePosition_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(NextMatePosition);
      }
      size += info_.CalculateSize(_map_info_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Read other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.ReadGroupId.Length != 0) {
        ReadGroupId = other.ReadGroupId;
      }
      if (other.ReadGroupSetId.Length != 0) {
        ReadGroupSetId = other.ReadGroupSetId;
      }
      if (other.FragmentName.Length != 0) {
        FragmentName = other.FragmentName;
      }
      if (other.ProperPlacement != false) {
        ProperPlacement = other.ProperPlacement;
      }
      if (other.DuplicateFragment != false) {
        DuplicateFragment = other.DuplicateFragment;
      }
      if (other.FragmentLength != 0) {
        FragmentLength = other.FragmentLength;
      }
      if (other.ReadNumber != 0) {
        ReadNumber = other.ReadNumber;
      }
      if (other.NumberReads != 0) {
        NumberReads = other.NumberReads;
      }
      if (other.FailedVendorQualityChecks != false) {
        FailedVendorQualityChecks = other.FailedVendorQualityChecks;
      }
      if (other.alignment_ != null) {
        if (alignment_ == null) {
          alignment_ = new global::Google.Genomics.V1.LinearAlignment();
        }
        Alignment.MergeFrom(other.Alignment);
      }
      if (other.SecondaryAlignment != false) {
        SecondaryAlignment = other.SecondaryAlignment;
      }
      if (other.SupplementaryAlignment != false) {
        SupplementaryAlignment = other.SupplementaryAlignment;
      }
      if (other.AlignedSequence.Length != 0) {
        AlignedSequence = other.AlignedSequence;
      }
      alignedQuality_.Add(other.alignedQuality_);
      if (other.nextMatePosition_ != null) {
        if (nextMatePosition_ == null) {
          nextMatePosition_ = new global::Google.Genomics.V1.Position();
        }
        NextMatePosition.MergeFrom(other.NextMatePosition);
      }
      info_.Add(other.info_);
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            ReadGroupId = input.ReadString();
            break;
          }
          case 26: {
            ReadGroupSetId = input.ReadString();
            break;
          }
          case 34: {
            FragmentName = input.ReadString();
            break;
          }
          case 40: {
            ProperPlacement = input.ReadBool();
            break;
          }
          case 48: {
            DuplicateFragment = input.ReadBool();
            break;
          }
          case 56: {
            FragmentLength = input.ReadInt32();
            break;
          }
          case 64: {
            ReadNumber = input.ReadInt32();
            break;
          }
          case 72: {
            NumberReads = input.ReadInt32();
            break;
          }
          case 80: {
            FailedVendorQualityChecks = input.ReadBool();
            break;
          }
          case 90: {
            if (alignment_ == null) {
              alignment_ = new global::Google.Genomics.V1.LinearAlignment();
            }
            input.ReadMessage(alignment_);
            break;
          }
          case 96: {
            SecondaryAlignment = input.ReadBool();
            break;
          }
          case 104: {
            SupplementaryAlignment = input.ReadBool();
            break;
          }
          case 114: {
            AlignedSequence = input.ReadString();
            break;
          }
          case 122:
          case 120: {
            alignedQuality_.AddEntriesFrom(input, _repeated_alignedQuality_codec);
            break;
          }
          case 130: {
            if (nextMatePosition_ == null) {
              nextMatePosition_ = new global::Google.Genomics.V1.Position();
            }
            input.ReadMessage(nextMatePosition_);
            break;
          }
          case 138: {
            info_.AddEntriesFrom(input, _map_info_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
