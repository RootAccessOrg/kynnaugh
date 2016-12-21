// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/genomics/v1/readgroup.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Genomics.V1 {

  /// <summary>Holder for reflection information generated from google/genomics/v1/readgroup.proto</summary>
  public static partial class ReadgroupReflection {

    #region Descriptor
    /// <summary>File descriptor for google/genomics/v1/readgroup.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReadgroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJnb29nbGUvZ2Vub21pY3MvdjEvcmVhZGdyb3VwLnByb3RvEhJnb29nbGUu",
            "Z2Vub21pY3MudjEaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aHGdv",
            "b2dsZS9wcm90b2J1Zi9zdHJ1Y3QucHJvdG8i5AQKCVJlYWRHcm91cBIKCgJp",
            "ZBgBIAEoCRISCgpkYXRhc2V0X2lkGAIgASgJEgwKBG5hbWUYAyABKAkSEwoL",
            "ZGVzY3JpcHRpb24YBCABKAkSEQoJc2FtcGxlX2lkGAUgASgJEjwKCmV4cGVy",
            "aW1lbnQYBiABKAsyKC5nb29nbGUuZ2Vub21pY3MudjEuUmVhZEdyb3VwLkV4",
            "cGVyaW1lbnQSHQoVcHJlZGljdGVkX2luc2VydF9zaXplGAcgASgFEjcKCHBy",
            "b2dyYW1zGAogAygLMiUuZ29vZ2xlLmdlbm9taWNzLnYxLlJlYWRHcm91cC5Q",
            "cm9ncmFtEhgKEHJlZmVyZW5jZV9zZXRfaWQYCyABKAkSNQoEaW5mbxgMIAMo",
            "CzInLmdvb2dsZS5nZW5vbWljcy52MS5SZWFkR3JvdXAuSW5mb0VudHJ5GmwK",
            "CkV4cGVyaW1lbnQSEgoKbGlicmFyeV9pZBgBIAEoCRIVCg1wbGF0Zm9ybV91",
            "bml0GAIgASgJEhkKEXNlcXVlbmNpbmdfY2VudGVyGAMgASgJEhgKEGluc3Ry",
            "dW1lbnRfbW9kZWwYBCABKAkaYwoHUHJvZ3JhbRIUCgxjb21tYW5kX2xpbmUY",
            "ASABKAkSCgoCaWQYAiABKAkSDAoEbmFtZRgDIAEoCRIXCg9wcmV2X3Byb2dy",
            "YW1faWQYBCABKAkSDwoHdmVyc2lvbhgFIAEoCRpHCglJbmZvRW50cnkSCwoD",
            "a2V5GAEgASgJEikKBXZhbHVlGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLkxp",
            "c3RWYWx1ZToCOAFCaQoWY29tLmdvb2dsZS5nZW5vbWljcy52MUIOUmVhZEdy",
            "b3VwUHJvdG9QAVo6Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9nZW5vbWljcy92MTtnZW5vbWljc/gBAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Genomics.V1.ReadGroup), global::Google.Genomics.V1.ReadGroup.Parser, new[]{ "Id", "DatasetId", "Name", "Description", "SampleId", "Experiment", "PredictedInsertSize", "Programs", "ReferenceSetId", "Info" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Genomics.V1.ReadGroup.Types.Experiment), global::Google.Genomics.V1.ReadGroup.Types.Experiment.Parser, new[]{ "LibraryId", "PlatformUnit", "SequencingCenter", "InstrumentModel" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Genomics.V1.ReadGroup.Types.Program), global::Google.Genomics.V1.ReadGroup.Types.Program.Parser, new[]{ "CommandLine", "Id", "Name", "PrevProgramId", "Version" }, null, null, null),
            null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  A read group is all the data that's processed the same way by the sequencer.
  /// </summary>
  public sealed partial class ReadGroup : pb::IMessage<ReadGroup> {
    private static readonly pb::MessageParser<ReadGroup> _parser = new pb::MessageParser<ReadGroup>(() => new ReadGroup());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReadGroup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Genomics.V1.ReadgroupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReadGroup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReadGroup(ReadGroup other) : this() {
      id_ = other.id_;
      datasetId_ = other.datasetId_;
      name_ = other.name_;
      description_ = other.description_;
      sampleId_ = other.sampleId_;
      Experiment = other.experiment_ != null ? other.Experiment.Clone() : null;
      predictedInsertSize_ = other.predictedInsertSize_;
      programs_ = other.programs_.Clone();
      referenceSetId_ = other.referenceSetId_;
      info_ = other.info_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReadGroup Clone() {
      return new ReadGroup(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    ///  The server-generated read group ID, unique for all read groups.
    ///  Note: This is different than the @RG ID field in the SAM spec. For that
    ///  value, see [name][google.genomics.v1.ReadGroup.name].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "dataset_id" field.</summary>
    public const int DatasetIdFieldNumber = 2;
    private string datasetId_ = "";
    /// <summary>
    ///  The dataset to which this read group belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DatasetId {
      get { return datasetId_; }
      set {
        datasetId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    /// <summary>
    ///  The read group name. This corresponds to the @RG ID field in the SAM spec.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 4;
    private string description_ = "";
    /// <summary>
    ///  A free-form text description of this read group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sample_id" field.</summary>
    public const int SampleIdFieldNumber = 5;
    private string sampleId_ = "";
    /// <summary>
    ///  A client-supplied sample identifier for the reads in this read group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SampleId {
      get { return sampleId_; }
      set {
        sampleId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "experiment" field.</summary>
    public const int ExperimentFieldNumber = 6;
    private global::Google.Genomics.V1.ReadGroup.Types.Experiment experiment_;
    /// <summary>
    ///  The experiment used to generate this read group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Genomics.V1.ReadGroup.Types.Experiment Experiment {
      get { return experiment_; }
      set {
        experiment_ = value;
      }
    }

    /// <summary>Field number for the "predicted_insert_size" field.</summary>
    public const int PredictedInsertSizeFieldNumber = 7;
    private int predictedInsertSize_;
    /// <summary>
    ///  The predicted insert size of this read group. The insert size is the length
    ///  the sequenced DNA fragment from end-to-end, not including the adapters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PredictedInsertSize {
      get { return predictedInsertSize_; }
      set {
        predictedInsertSize_ = value;
      }
    }

    /// <summary>Field number for the "programs" field.</summary>
    public const int ProgramsFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Google.Genomics.V1.ReadGroup.Types.Program> _repeated_programs_codec
        = pb::FieldCodec.ForMessage(82, global::Google.Genomics.V1.ReadGroup.Types.Program.Parser);
    private readonly pbc::RepeatedField<global::Google.Genomics.V1.ReadGroup.Types.Program> programs_ = new pbc::RepeatedField<global::Google.Genomics.V1.ReadGroup.Types.Program>();
    /// <summary>
    ///  The programs used to generate this read group. Programs are always
    ///  identical for all read groups within a read group set. For this reason,
    ///  only the first read group in a returned set will have this field
    ///  populated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Genomics.V1.ReadGroup.Types.Program> Programs {
      get { return programs_; }
    }

    /// <summary>Field number for the "reference_set_id" field.</summary>
    public const int ReferenceSetIdFieldNumber = 11;
    private string referenceSetId_ = "";
    /// <summary>
    ///  The reference set the reads in this read group are aligned to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ReferenceSetId {
      get { return referenceSetId_; }
      set {
        referenceSetId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "info" field.</summary>
    public const int InfoFieldNumber = 12;
    private static readonly pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.ListValue>.Codec _map_info_codec
        = new pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.ListValue>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::Google.Protobuf.WellKnownTypes.ListValue.Parser), 98);
    private readonly pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.ListValue> info_ = new pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.ListValue>();
    /// <summary>
    ///  A map of additional read group information. This must be of the form
    ///  map&lt;string, string[]> (string key mapping to a list of string values).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.ListValue> Info {
      get { return info_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReadGroup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReadGroup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (DatasetId != other.DatasetId) return false;
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (SampleId != other.SampleId) return false;
      if (!object.Equals(Experiment, other.Experiment)) return false;
      if (PredictedInsertSize != other.PredictedInsertSize) return false;
      if(!programs_.Equals(other.programs_)) return false;
      if (ReferenceSetId != other.ReferenceSetId) return false;
      if (!Info.Equals(other.Info)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (DatasetId.Length != 0) hash ^= DatasetId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (SampleId.Length != 0) hash ^= SampleId.GetHashCode();
      if (experiment_ != null) hash ^= Experiment.GetHashCode();
      if (PredictedInsertSize != 0) hash ^= PredictedInsertSize.GetHashCode();
      hash ^= programs_.GetHashCode();
      if (ReferenceSetId.Length != 0) hash ^= ReferenceSetId.GetHashCode();
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
      if (DatasetId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DatasetId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Description);
      }
      if (SampleId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(SampleId);
      }
      if (experiment_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Experiment);
      }
      if (PredictedInsertSize != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(PredictedInsertSize);
      }
      programs_.WriteTo(output, _repeated_programs_codec);
      if (ReferenceSetId.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(ReferenceSetId);
      }
      info_.WriteTo(output, _map_info_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (DatasetId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DatasetId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (SampleId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SampleId);
      }
      if (experiment_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Experiment);
      }
      if (PredictedInsertSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PredictedInsertSize);
      }
      size += programs_.CalculateSize(_repeated_programs_codec);
      if (ReferenceSetId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReferenceSetId);
      }
      size += info_.CalculateSize(_map_info_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReadGroup other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.DatasetId.Length != 0) {
        DatasetId = other.DatasetId;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.SampleId.Length != 0) {
        SampleId = other.SampleId;
      }
      if (other.experiment_ != null) {
        if (experiment_ == null) {
          experiment_ = new global::Google.Genomics.V1.ReadGroup.Types.Experiment();
        }
        Experiment.MergeFrom(other.Experiment);
      }
      if (other.PredictedInsertSize != 0) {
        PredictedInsertSize = other.PredictedInsertSize;
      }
      programs_.Add(other.programs_);
      if (other.ReferenceSetId.Length != 0) {
        ReferenceSetId = other.ReferenceSetId;
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
            DatasetId = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            Description = input.ReadString();
            break;
          }
          case 42: {
            SampleId = input.ReadString();
            break;
          }
          case 50: {
            if (experiment_ == null) {
              experiment_ = new global::Google.Genomics.V1.ReadGroup.Types.Experiment();
            }
            input.ReadMessage(experiment_);
            break;
          }
          case 56: {
            PredictedInsertSize = input.ReadInt32();
            break;
          }
          case 82: {
            programs_.AddEntriesFrom(input, _repeated_programs_codec);
            break;
          }
          case 90: {
            ReferenceSetId = input.ReadString();
            break;
          }
          case 98: {
            info_.AddEntriesFrom(input, _map_info_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ReadGroup message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class Experiment : pb::IMessage<Experiment> {
        private static readonly pb::MessageParser<Experiment> _parser = new pb::MessageParser<Experiment>(() => new Experiment());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Experiment> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Genomics.V1.ReadGroup.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Experiment() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Experiment(Experiment other) : this() {
          libraryId_ = other.libraryId_;
          platformUnit_ = other.platformUnit_;
          sequencingCenter_ = other.sequencingCenter_;
          instrumentModel_ = other.instrumentModel_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Experiment Clone() {
          return new Experiment(this);
        }

        /// <summary>Field number for the "library_id" field.</summary>
        public const int LibraryIdFieldNumber = 1;
        private string libraryId_ = "";
        /// <summary>
        ///  A client-supplied library identifier; a library is a collection of DNA
        ///  fragments which have been prepared for sequencing from a sample. This
        ///  field is important for quality control as error or bias can be introduced
        ///  during sample preparation.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string LibraryId {
          get { return libraryId_; }
          set {
            libraryId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "platform_unit" field.</summary>
        public const int PlatformUnitFieldNumber = 2;
        private string platformUnit_ = "";
        /// <summary>
        ///  The platform unit used as part of this experiment, for example
        ///  flowcell-barcode.lane for Illumina or slide for SOLiD. Corresponds to the
        ///  @RG PU field in the SAM spec.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string PlatformUnit {
          get { return platformUnit_; }
          set {
            platformUnit_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "sequencing_center" field.</summary>
        public const int SequencingCenterFieldNumber = 3;
        private string sequencingCenter_ = "";
        /// <summary>
        ///  The sequencing center used as part of this experiment.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string SequencingCenter {
          get { return sequencingCenter_; }
          set {
            sequencingCenter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "instrument_model" field.</summary>
        public const int InstrumentModelFieldNumber = 4;
        private string instrumentModel_ = "";
        /// <summary>
        ///  The instrument model used as part of this experiment. This maps to
        ///  sequencing technology in the SAM spec.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string InstrumentModel {
          get { return instrumentModel_; }
          set {
            instrumentModel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Experiment);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Experiment other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (LibraryId != other.LibraryId) return false;
          if (PlatformUnit != other.PlatformUnit) return false;
          if (SequencingCenter != other.SequencingCenter) return false;
          if (InstrumentModel != other.InstrumentModel) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (LibraryId.Length != 0) hash ^= LibraryId.GetHashCode();
          if (PlatformUnit.Length != 0) hash ^= PlatformUnit.GetHashCode();
          if (SequencingCenter.Length != 0) hash ^= SequencingCenter.GetHashCode();
          if (InstrumentModel.Length != 0) hash ^= InstrumentModel.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (LibraryId.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(LibraryId);
          }
          if (PlatformUnit.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(PlatformUnit);
          }
          if (SequencingCenter.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(SequencingCenter);
          }
          if (InstrumentModel.Length != 0) {
            output.WriteRawTag(34);
            output.WriteString(InstrumentModel);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (LibraryId.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(LibraryId);
          }
          if (PlatformUnit.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(PlatformUnit);
          }
          if (SequencingCenter.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(SequencingCenter);
          }
          if (InstrumentModel.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(InstrumentModel);
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Experiment other) {
          if (other == null) {
            return;
          }
          if (other.LibraryId.Length != 0) {
            LibraryId = other.LibraryId;
          }
          if (other.PlatformUnit.Length != 0) {
            PlatformUnit = other.PlatformUnit;
          }
          if (other.SequencingCenter.Length != 0) {
            SequencingCenter = other.SequencingCenter;
          }
          if (other.InstrumentModel.Length != 0) {
            InstrumentModel = other.InstrumentModel;
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
                LibraryId = input.ReadString();
                break;
              }
              case 18: {
                PlatformUnit = input.ReadString();
                break;
              }
              case 26: {
                SequencingCenter = input.ReadString();
                break;
              }
              case 34: {
                InstrumentModel = input.ReadString();
                break;
              }
            }
          }
        }

      }

      public sealed partial class Program : pb::IMessage<Program> {
        private static readonly pb::MessageParser<Program> _parser = new pb::MessageParser<Program>(() => new Program());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Program> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Genomics.V1.ReadGroup.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Program() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Program(Program other) : this() {
          commandLine_ = other.commandLine_;
          id_ = other.id_;
          name_ = other.name_;
          prevProgramId_ = other.prevProgramId_;
          version_ = other.version_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Program Clone() {
          return new Program(this);
        }

        /// <summary>Field number for the "command_line" field.</summary>
        public const int CommandLineFieldNumber = 1;
        private string commandLine_ = "";
        /// <summary>
        ///  The command line used to run this program.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string CommandLine {
          get { return commandLine_; }
          set {
            commandLine_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "id" field.</summary>
        public const int IdFieldNumber = 2;
        private string id_ = "";
        /// <summary>
        ///  The user specified locally unique ID of the program. Used along with
        ///  `prevProgramId` to define an ordering between programs.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Id {
          get { return id_; }
          set {
            id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 3;
        private string name_ = "";
        /// <summary>
        ///  The display name of the program. This is typically the colloquial name of
        ///  the tool used, for example 'bwa' or 'picard'.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Name {
          get { return name_; }
          set {
            name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "prev_program_id" field.</summary>
        public const int PrevProgramIdFieldNumber = 4;
        private string prevProgramId_ = "";
        /// <summary>
        ///  The ID of the program run before this one.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string PrevProgramId {
          get { return prevProgramId_; }
          set {
            prevProgramId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "version" field.</summary>
        public const int VersionFieldNumber = 5;
        private string version_ = "";
        /// <summary>
        ///  The version of the program run.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Version {
          get { return version_; }
          set {
            version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Program);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Program other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (CommandLine != other.CommandLine) return false;
          if (Id != other.Id) return false;
          if (Name != other.Name) return false;
          if (PrevProgramId != other.PrevProgramId) return false;
          if (Version != other.Version) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (CommandLine.Length != 0) hash ^= CommandLine.GetHashCode();
          if (Id.Length != 0) hash ^= Id.GetHashCode();
          if (Name.Length != 0) hash ^= Name.GetHashCode();
          if (PrevProgramId.Length != 0) hash ^= PrevProgramId.GetHashCode();
          if (Version.Length != 0) hash ^= Version.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (CommandLine.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(CommandLine);
          }
          if (Id.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Id);
          }
          if (Name.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(Name);
          }
          if (PrevProgramId.Length != 0) {
            output.WriteRawTag(34);
            output.WriteString(PrevProgramId);
          }
          if (Version.Length != 0) {
            output.WriteRawTag(42);
            output.WriteString(Version);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (CommandLine.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(CommandLine);
          }
          if (Id.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
          }
          if (Name.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
          }
          if (PrevProgramId.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(PrevProgramId);
          }
          if (Version.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Program other) {
          if (other == null) {
            return;
          }
          if (other.CommandLine.Length != 0) {
            CommandLine = other.CommandLine;
          }
          if (other.Id.Length != 0) {
            Id = other.Id;
          }
          if (other.Name.Length != 0) {
            Name = other.Name;
          }
          if (other.PrevProgramId.Length != 0) {
            PrevProgramId = other.PrevProgramId;
          }
          if (other.Version.Length != 0) {
            Version = other.Version;
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
                CommandLine = input.ReadString();
                break;
              }
              case 18: {
                Id = input.ReadString();
                break;
              }
              case 26: {
                Name = input.ReadString();
                break;
              }
              case 34: {
                PrevProgramId = input.ReadString();
                break;
              }
              case 42: {
                Version = input.ReadString();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code