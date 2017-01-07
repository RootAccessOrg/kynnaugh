// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/api/servicecontrol/v1/distribution.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api.Servicecontrol.V1 {

  /// <summary>Holder for reflection information generated from google/api/servicecontrol/v1/distribution.proto</summary>
  public static partial class DistributionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/api/servicecontrol/v1/distribution.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DistributionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvYXBpL3NlcnZpY2Vjb250cm9sL3YxL2Rpc3RyaWJ1dGlvbi5w",
            "cm90bxIcZ29vZ2xlLmFwaS5zZXJ2aWNlY29udHJvbC52MSLoBAoMRGlzdHJp",
            "YnV0aW9uEg0KBWNvdW50GAEgASgDEgwKBG1lYW4YAiABKAESDwoHbWluaW11",
            "bRgDIAEoARIPCgdtYXhpbXVtGAQgASgBEiAKGHN1bV9vZl9zcXVhcmVkX2Rl",
            "dmlhdGlvbhgFIAEoARIVCg1idWNrZXRfY291bnRzGAYgAygDElIKDmxpbmVh",
            "cl9idWNrZXRzGAcgASgLMjguZ29vZ2xlLmFwaS5zZXJ2aWNlY29udHJvbC52",
            "MS5EaXN0cmlidXRpb24uTGluZWFyQnVja2V0c0gAElwKE2V4cG9uZW50aWFs",
            "X2J1Y2tldHMYCCABKAsyPS5nb29nbGUuYXBpLnNlcnZpY2Vjb250cm9sLnYx",
            "LkRpc3RyaWJ1dGlvbi5FeHBvbmVudGlhbEJ1Y2tldHNIABJWChBleHBsaWNp",
            "dF9idWNrZXRzGAkgASgLMjouZ29vZ2xlLmFwaS5zZXJ2aWNlY29udHJvbC52",
            "MS5EaXN0cmlidXRpb24uRXhwbGljaXRCdWNrZXRzSAAaSgoNTGluZWFyQnVj",
            "a2V0cxIaChJudW1fZmluaXRlX2J1Y2tldHMYASABKAUSDQoFd2lkdGgYAiAB",
            "KAESDgoGb2Zmc2V0GAMgASgBGlYKEkV4cG9uZW50aWFsQnVja2V0cxIaChJu",
            "dW1fZmluaXRlX2J1Y2tldHMYASABKAUSFQoNZ3Jvd3RoX2ZhY3RvchgCIAEo",
            "ARINCgVzY2FsZRgDIAEoARohCg9FeHBsaWNpdEJ1Y2tldHMSDgoGYm91bmRz",
            "GAEgAygBQg8KDWJ1Y2tldF9vcHRpb25ChgEKIGNvbS5nb29nbGUuYXBpLnNl",
            "cnZpY2Vjb250cm9sLnYxQhFEaXN0cmlidXRpb25Qcm90b1ABWkpnb29nbGUu",
            "Z29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2FwaS9zZXJ2aWNlY29u",
            "dHJvbC92MTtzZXJ2aWNlY29udHJvbPgBAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Servicecontrol.V1.Distribution), global::Google.Api.Servicecontrol.V1.Distribution.Parser, new[]{ "Count", "Mean", "Minimum", "Maximum", "SumOfSquaredDeviation", "BucketCounts", "LinearBuckets", "ExponentialBuckets", "ExplicitBuckets" }, new[]{ "BucketOption" }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Servicecontrol.V1.Distribution.Types.LinearBuckets), global::Google.Api.Servicecontrol.V1.Distribution.Types.LinearBuckets.Parser, new[]{ "NumFiniteBuckets", "Width", "Offset" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Servicecontrol.V1.Distribution.Types.ExponentialBuckets), global::Google.Api.Servicecontrol.V1.Distribution.Types.ExponentialBuckets.Parser, new[]{ "NumFiniteBuckets", "GrowthFactor", "Scale" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Servicecontrol.V1.Distribution.Types.ExplicitBuckets), global::Google.Api.Servicecontrol.V1.Distribution.Types.ExplicitBuckets.Parser, new[]{ "Bounds" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Distribution represents a frequency distribution of double-valued sample
  ///  points. It contains the size of the population of sample points plus
  ///  additional optional information:
  ///
  ///    - the arithmetic mean of the samples
  ///    - the minimum and maximum of the samples
  ///    - the sum-squared-deviation of the samples, used to compute variance
  ///    - a histogram of the values of the sample points
  /// </summary>
  public sealed partial class Distribution : pb::IMessage<Distribution> {
    private static readonly pb::MessageParser<Distribution> _parser = new pb::MessageParser<Distribution>(() => new Distribution());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Distribution> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.Servicecontrol.V1.DistributionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Distribution() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Distribution(Distribution other) : this() {
      count_ = other.count_;
      mean_ = other.mean_;
      minimum_ = other.minimum_;
      maximum_ = other.maximum_;
      sumOfSquaredDeviation_ = other.sumOfSquaredDeviation_;
      bucketCounts_ = other.bucketCounts_.Clone();
      switch (other.BucketOptionCase) {
        case BucketOptionOneofCase.LinearBuckets:
          LinearBuckets = other.LinearBuckets.Clone();
          break;
        case BucketOptionOneofCase.ExponentialBuckets:
          ExponentialBuckets = other.ExponentialBuckets.Clone();
          break;
        case BucketOptionOneofCase.ExplicitBuckets:
          ExplicitBuckets = other.ExplicitBuckets.Clone();
          break;
      }

    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Distribution Clone() {
      return new Distribution(this);
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 1;
    private long count_;
    /// <summary>
    ///  The total number of samples in the distribution. Must be >= 0.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "mean" field.</summary>
    public const int MeanFieldNumber = 2;
    private double mean_;
    /// <summary>
    ///  The arithmetic mean of the samples in the distribution. If `count` is
    ///  zero then this field must be zero.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Mean {
      get { return mean_; }
      set {
        mean_ = value;
      }
    }

    /// <summary>Field number for the "minimum" field.</summary>
    public const int MinimumFieldNumber = 3;
    private double minimum_;
    /// <summary>
    ///  The minimum of the population of values. Ignored if `count` is zero.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Minimum {
      get { return minimum_; }
      set {
        minimum_ = value;
      }
    }

    /// <summary>Field number for the "maximum" field.</summary>
    public const int MaximumFieldNumber = 4;
    private double maximum_;
    /// <summary>
    ///  The maximum of the population of values. Ignored if `count` is zero.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Maximum {
      get { return maximum_; }
      set {
        maximum_ = value;
      }
    }

    /// <summary>Field number for the "sum_of_squared_deviation" field.</summary>
    public const int SumOfSquaredDeviationFieldNumber = 5;
    private double sumOfSquaredDeviation_;
    /// <summary>
    ///  The sum of squared deviations from the mean:
    ///    Sum[i=1..count]((x_i - mean)^2)
    ///  where each x_i is a sample values. If `count` is zero then this field
    ///  must be zero, otherwise validation of the request fails.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double SumOfSquaredDeviation {
      get { return sumOfSquaredDeviation_; }
      set {
        sumOfSquaredDeviation_ = value;
      }
    }

    /// <summary>Field number for the "bucket_counts" field.</summary>
    public const int BucketCountsFieldNumber = 6;
    private static readonly pb::FieldCodec<long> _repeated_bucketCounts_codec
        = pb::FieldCodec.ForInt64(50);
    private readonly pbc::RepeatedField<long> bucketCounts_ = new pbc::RepeatedField<long>();
    /// <summary>
    ///  The number of samples in each histogram bucket. `bucket_counts` are
    ///  optional. If present, they must sum to the `count` value.
    ///
    ///  The buckets are defined below in `bucket_option`. There are N buckets.
    ///  `bucket_counts[0]` is the number of samples in the underflow bucket.
    ///  `bucket_counts[1]` to `bucket_counts[N-1]` are the numbers of samples
    ///  in each of the finite buckets. And `bucket_counts[N] is the number
    ///  of samples in the overflow bucket. See the comments of `bucket_option`
    ///  below for more details.
    ///
    ///  Any suffix of trailing zeros may be omitted.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<long> BucketCounts {
      get { return bucketCounts_; }
    }

    /// <summary>Field number for the "linear_buckets" field.</summary>
    public const int LinearBucketsFieldNumber = 7;
    /// <summary>
    ///  Buckets with constant width.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.Servicecontrol.V1.Distribution.Types.LinearBuckets LinearBuckets {
      get { return bucketOptionCase_ == BucketOptionOneofCase.LinearBuckets ? (global::Google.Api.Servicecontrol.V1.Distribution.Types.LinearBuckets) bucketOption_ : null; }
      set {
        bucketOption_ = value;
        bucketOptionCase_ = value == null ? BucketOptionOneofCase.None : BucketOptionOneofCase.LinearBuckets;
      }
    }

    /// <summary>Field number for the "exponential_buckets" field.</summary>
    public const int ExponentialBucketsFieldNumber = 8;
    /// <summary>
    ///  Buckets with exponentially growing width.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.Servicecontrol.V1.Distribution.Types.ExponentialBuckets ExponentialBuckets {
      get { return bucketOptionCase_ == BucketOptionOneofCase.ExponentialBuckets ? (global::Google.Api.Servicecontrol.V1.Distribution.Types.ExponentialBuckets) bucketOption_ : null; }
      set {
        bucketOption_ = value;
        bucketOptionCase_ = value == null ? BucketOptionOneofCase.None : BucketOptionOneofCase.ExponentialBuckets;
      }
    }

    /// <summary>Field number for the "explicit_buckets" field.</summary>
    public const int ExplicitBucketsFieldNumber = 9;
    /// <summary>
    ///  Buckets with arbitrary user-provided width.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.Servicecontrol.V1.Distribution.Types.ExplicitBuckets ExplicitBuckets {
      get { return bucketOptionCase_ == BucketOptionOneofCase.ExplicitBuckets ? (global::Google.Api.Servicecontrol.V1.Distribution.Types.ExplicitBuckets) bucketOption_ : null; }
      set {
        bucketOption_ = value;
        bucketOptionCase_ = value == null ? BucketOptionOneofCase.None : BucketOptionOneofCase.ExplicitBuckets;
      }
    }

    private object bucketOption_;
    /// <summary>Enum of possible cases for the "bucket_option" oneof.</summary>
    public enum BucketOptionOneofCase {
      None = 0,
      LinearBuckets = 7,
      ExponentialBuckets = 8,
      ExplicitBuckets = 9,
    }
    private BucketOptionOneofCase bucketOptionCase_ = BucketOptionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BucketOptionOneofCase BucketOptionCase {
      get { return bucketOptionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearBucketOption() {
      bucketOptionCase_ = BucketOptionOneofCase.None;
      bucketOption_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Distribution);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Distribution other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Count != other.Count) return false;
      if (Mean != other.Mean) return false;
      if (Minimum != other.Minimum) return false;
      if (Maximum != other.Maximum) return false;
      if (SumOfSquaredDeviation != other.SumOfSquaredDeviation) return false;
      if(!bucketCounts_.Equals(other.bucketCounts_)) return false;
      if (!object.Equals(LinearBuckets, other.LinearBuckets)) return false;
      if (!object.Equals(ExponentialBuckets, other.ExponentialBuckets)) return false;
      if (!object.Equals(ExplicitBuckets, other.ExplicitBuckets)) return false;
      if (BucketOptionCase != other.BucketOptionCase) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Count != 0L) hash ^= Count.GetHashCode();
      if (Mean != 0D) hash ^= Mean.GetHashCode();
      if (Minimum != 0D) hash ^= Minimum.GetHashCode();
      if (Maximum != 0D) hash ^= Maximum.GetHashCode();
      if (SumOfSquaredDeviation != 0D) hash ^= SumOfSquaredDeviation.GetHashCode();
      hash ^= bucketCounts_.GetHashCode();
      if (bucketOptionCase_ == BucketOptionOneofCase.LinearBuckets) hash ^= LinearBuckets.GetHashCode();
      if (bucketOptionCase_ == BucketOptionOneofCase.ExponentialBuckets) hash ^= ExponentialBuckets.GetHashCode();
      if (bucketOptionCase_ == BucketOptionOneofCase.ExplicitBuckets) hash ^= ExplicitBuckets.GetHashCode();
      hash ^= (int) bucketOptionCase_;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Count != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Count);
      }
      if (Mean != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Mean);
      }
      if (Minimum != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Minimum);
      }
      if (Maximum != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Maximum);
      }
      if (SumOfSquaredDeviation != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(SumOfSquaredDeviation);
      }
      bucketCounts_.WriteTo(output, _repeated_bucketCounts_codec);
      if (bucketOptionCase_ == BucketOptionOneofCase.LinearBuckets) {
        output.WriteRawTag(58);
        output.WriteMessage(LinearBuckets);
      }
      if (bucketOptionCase_ == BucketOptionOneofCase.ExponentialBuckets) {
        output.WriteRawTag(66);
        output.WriteMessage(ExponentialBuckets);
      }
      if (bucketOptionCase_ == BucketOptionOneofCase.ExplicitBuckets) {
        output.WriteRawTag(74);
        output.WriteMessage(ExplicitBuckets);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Count != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Count);
      }
      if (Mean != 0D) {
        size += 1 + 8;
      }
      if (Minimum != 0D) {
        size += 1 + 8;
      }
      if (Maximum != 0D) {
        size += 1 + 8;
      }
      if (SumOfSquaredDeviation != 0D) {
        size += 1 + 8;
      }
      size += bucketCounts_.CalculateSize(_repeated_bucketCounts_codec);
      if (bucketOptionCase_ == BucketOptionOneofCase.LinearBuckets) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LinearBuckets);
      }
      if (bucketOptionCase_ == BucketOptionOneofCase.ExponentialBuckets) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExponentialBuckets);
      }
      if (bucketOptionCase_ == BucketOptionOneofCase.ExplicitBuckets) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExplicitBuckets);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Distribution other) {
      if (other == null) {
        return;
      }
      if (other.Count != 0L) {
        Count = other.Count;
      }
      if (other.Mean != 0D) {
        Mean = other.Mean;
      }
      if (other.Minimum != 0D) {
        Minimum = other.Minimum;
      }
      if (other.Maximum != 0D) {
        Maximum = other.Maximum;
      }
      if (other.SumOfSquaredDeviation != 0D) {
        SumOfSquaredDeviation = other.SumOfSquaredDeviation;
      }
      bucketCounts_.Add(other.bucketCounts_);
      switch (other.BucketOptionCase) {
        case BucketOptionOneofCase.LinearBuckets:
          LinearBuckets = other.LinearBuckets;
          break;
        case BucketOptionOneofCase.ExponentialBuckets:
          ExponentialBuckets = other.ExponentialBuckets;
          break;
        case BucketOptionOneofCase.ExplicitBuckets:
          ExplicitBuckets = other.ExplicitBuckets;
          break;
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
            Count = input.ReadInt64();
            break;
          }
          case 17: {
            Mean = input.ReadDouble();
            break;
          }
          case 25: {
            Minimum = input.ReadDouble();
            break;
          }
          case 33: {
            Maximum = input.ReadDouble();
            break;
          }
          case 41: {
            SumOfSquaredDeviation = input.ReadDouble();
            break;
          }
          case 50:
          case 48: {
            bucketCounts_.AddEntriesFrom(input, _repeated_bucketCounts_codec);
            break;
          }
          case 58: {
            global::Google.Api.Servicecontrol.V1.Distribution.Types.LinearBuckets subBuilder = new global::Google.Api.Servicecontrol.V1.Distribution.Types.LinearBuckets();
            if (bucketOptionCase_ == BucketOptionOneofCase.LinearBuckets) {
              subBuilder.MergeFrom(LinearBuckets);
            }
            input.ReadMessage(subBuilder);
            LinearBuckets = subBuilder;
            break;
          }
          case 66: {
            global::Google.Api.Servicecontrol.V1.Distribution.Types.ExponentialBuckets subBuilder = new global::Google.Api.Servicecontrol.V1.Distribution.Types.ExponentialBuckets();
            if (bucketOptionCase_ == BucketOptionOneofCase.ExponentialBuckets) {
              subBuilder.MergeFrom(ExponentialBuckets);
            }
            input.ReadMessage(subBuilder);
            ExponentialBuckets = subBuilder;
            break;
          }
          case 74: {
            global::Google.Api.Servicecontrol.V1.Distribution.Types.ExplicitBuckets subBuilder = new global::Google.Api.Servicecontrol.V1.Distribution.Types.ExplicitBuckets();
            if (bucketOptionCase_ == BucketOptionOneofCase.ExplicitBuckets) {
              subBuilder.MergeFrom(ExplicitBuckets);
            }
            input.ReadMessage(subBuilder);
            ExplicitBuckets = subBuilder;
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Distribution message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      ///  Describing buckets with constant width.
      /// </summary>
      public sealed partial class LinearBuckets : pb::IMessage<LinearBuckets> {
        private static readonly pb::MessageParser<LinearBuckets> _parser = new pb::MessageParser<LinearBuckets>(() => new LinearBuckets());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<LinearBuckets> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Api.Servicecontrol.V1.Distribution.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public LinearBuckets() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public LinearBuckets(LinearBuckets other) : this() {
          numFiniteBuckets_ = other.numFiniteBuckets_;
          width_ = other.width_;
          offset_ = other.offset_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public LinearBuckets Clone() {
          return new LinearBuckets(this);
        }

        /// <summary>Field number for the "num_finite_buckets" field.</summary>
        public const int NumFiniteBucketsFieldNumber = 1;
        private int numFiniteBuckets_;
        /// <summary>
        ///  The number of finite buckets. With the underflow and overflow buckets,
        ///  the total number of buckets is `num_finite_buckets` + 2.
        ///  See comments on `bucket_options` for details.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int NumFiniteBuckets {
          get { return numFiniteBuckets_; }
          set {
            numFiniteBuckets_ = value;
          }
        }

        /// <summary>Field number for the "width" field.</summary>
        public const int WidthFieldNumber = 2;
        private double width_;
        /// <summary>
        ///  The i'th linear bucket covers the interval
        ///    [offset + (i-1) * width, offset + i * width)
        ///  where i ranges from 1 to num_finite_buckets, inclusive.
        ///  Must be strictly positive.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public double Width {
          get { return width_; }
          set {
            width_ = value;
          }
        }

        /// <summary>Field number for the "offset" field.</summary>
        public const int OffsetFieldNumber = 3;
        private double offset_;
        /// <summary>
        ///  The i'th linear bucket covers the interval
        ///    [offset + (i-1) * width, offset + i * width)
        ///  where i ranges from 1 to num_finite_buckets, inclusive.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public double Offset {
          get { return offset_; }
          set {
            offset_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as LinearBuckets);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(LinearBuckets other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (NumFiniteBuckets != other.NumFiniteBuckets) return false;
          if (Width != other.Width) return false;
          if (Offset != other.Offset) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (NumFiniteBuckets != 0) hash ^= NumFiniteBuckets.GetHashCode();
          if (Width != 0D) hash ^= Width.GetHashCode();
          if (Offset != 0D) hash ^= Offset.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (NumFiniteBuckets != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(NumFiniteBuckets);
          }
          if (Width != 0D) {
            output.WriteRawTag(17);
            output.WriteDouble(Width);
          }
          if (Offset != 0D) {
            output.WriteRawTag(25);
            output.WriteDouble(Offset);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (NumFiniteBuckets != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumFiniteBuckets);
          }
          if (Width != 0D) {
            size += 1 + 8;
          }
          if (Offset != 0D) {
            size += 1 + 8;
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(LinearBuckets other) {
          if (other == null) {
            return;
          }
          if (other.NumFiniteBuckets != 0) {
            NumFiniteBuckets = other.NumFiniteBuckets;
          }
          if (other.Width != 0D) {
            Width = other.Width;
          }
          if (other.Offset != 0D) {
            Offset = other.Offset;
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
                NumFiniteBuckets = input.ReadInt32();
                break;
              }
              case 17: {
                Width = input.ReadDouble();
                break;
              }
              case 25: {
                Offset = input.ReadDouble();
                break;
              }
            }
          }
        }

      }

      /// <summary>
      ///  Describing buckets with exponentially growing width.
      /// </summary>
      public sealed partial class ExponentialBuckets : pb::IMessage<ExponentialBuckets> {
        private static readonly pb::MessageParser<ExponentialBuckets> _parser = new pb::MessageParser<ExponentialBuckets>(() => new ExponentialBuckets());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<ExponentialBuckets> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Api.Servicecontrol.V1.Distribution.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ExponentialBuckets() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ExponentialBuckets(ExponentialBuckets other) : this() {
          numFiniteBuckets_ = other.numFiniteBuckets_;
          growthFactor_ = other.growthFactor_;
          scale_ = other.scale_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ExponentialBuckets Clone() {
          return new ExponentialBuckets(this);
        }

        /// <summary>Field number for the "num_finite_buckets" field.</summary>
        public const int NumFiniteBucketsFieldNumber = 1;
        private int numFiniteBuckets_;
        /// <summary>
        ///  The number of finite buckets. With the underflow and overflow buckets,
        ///  the total number of buckets is `num_finite_buckets` + 2.
        ///  See comments on `bucket_options` for details.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int NumFiniteBuckets {
          get { return numFiniteBuckets_; }
          set {
            numFiniteBuckets_ = value;
          }
        }

        /// <summary>Field number for the "growth_factor" field.</summary>
        public const int GrowthFactorFieldNumber = 2;
        private double growthFactor_;
        /// <summary>
        ///  The i'th exponential bucket covers the interval
        ///    [scale * growth_factor^(i-1), scale * growth_factor^i)
        ///  where i ranges from 1 to num_finite_buckets inclusive.
        ///  Must be larger than 1.0.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public double GrowthFactor {
          get { return growthFactor_; }
          set {
            growthFactor_ = value;
          }
        }

        /// <summary>Field number for the "scale" field.</summary>
        public const int ScaleFieldNumber = 3;
        private double scale_;
        /// <summary>
        ///  The i'th exponential bucket covers the interval
        ///    [scale * growth_factor^(i-1), scale * growth_factor^i)
        ///  where i ranges from 1 to num_finite_buckets inclusive.
        ///  Must be > 0.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public double Scale {
          get { return scale_; }
          set {
            scale_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as ExponentialBuckets);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(ExponentialBuckets other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (NumFiniteBuckets != other.NumFiniteBuckets) return false;
          if (GrowthFactor != other.GrowthFactor) return false;
          if (Scale != other.Scale) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (NumFiniteBuckets != 0) hash ^= NumFiniteBuckets.GetHashCode();
          if (GrowthFactor != 0D) hash ^= GrowthFactor.GetHashCode();
          if (Scale != 0D) hash ^= Scale.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (NumFiniteBuckets != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(NumFiniteBuckets);
          }
          if (GrowthFactor != 0D) {
            output.WriteRawTag(17);
            output.WriteDouble(GrowthFactor);
          }
          if (Scale != 0D) {
            output.WriteRawTag(25);
            output.WriteDouble(Scale);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (NumFiniteBuckets != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumFiniteBuckets);
          }
          if (GrowthFactor != 0D) {
            size += 1 + 8;
          }
          if (Scale != 0D) {
            size += 1 + 8;
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(ExponentialBuckets other) {
          if (other == null) {
            return;
          }
          if (other.NumFiniteBuckets != 0) {
            NumFiniteBuckets = other.NumFiniteBuckets;
          }
          if (other.GrowthFactor != 0D) {
            GrowthFactor = other.GrowthFactor;
          }
          if (other.Scale != 0D) {
            Scale = other.Scale;
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
                NumFiniteBuckets = input.ReadInt32();
                break;
              }
              case 17: {
                GrowthFactor = input.ReadDouble();
                break;
              }
              case 25: {
                Scale = input.ReadDouble();
                break;
              }
            }
          }
        }

      }

      /// <summary>
      ///  Describing buckets with arbitrary user-provided width.
      /// </summary>
      public sealed partial class ExplicitBuckets : pb::IMessage<ExplicitBuckets> {
        private static readonly pb::MessageParser<ExplicitBuckets> _parser = new pb::MessageParser<ExplicitBuckets>(() => new ExplicitBuckets());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<ExplicitBuckets> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Api.Servicecontrol.V1.Distribution.Descriptor.NestedTypes[2]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ExplicitBuckets() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ExplicitBuckets(ExplicitBuckets other) : this() {
          bounds_ = other.bounds_.Clone();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ExplicitBuckets Clone() {
          return new ExplicitBuckets(this);
        }

        /// <summary>Field number for the "bounds" field.</summary>
        public const int BoundsFieldNumber = 1;
        private static readonly pb::FieldCodec<double> _repeated_bounds_codec
            = pb::FieldCodec.ForDouble(10);
        private readonly pbc::RepeatedField<double> bounds_ = new pbc::RepeatedField<double>();
        /// <summary>
        ///  'bound' is a list of strictly increasing boundaries between
        ///  buckets. Note that a list of length N-1 defines N buckets because
        ///  of fenceposting. See comments on `bucket_options` for details.
        ///
        ///  The i'th finite bucket covers the interval
        ///    [bound[i-1], bound[i])
        ///  where i ranges from 1 to bound_size() - 1. Note that there are no
        ///  finite buckets at all if 'bound' only contains a single element; in
        ///  that special case the single bound defines the boundary between the
        ///  underflow and overflow buckets.
        ///
        ///  bucket number                   lower bound    upper bound
        ///   i == 0 (underflow)              -inf           bound[i]
        ///   0 &lt; i &lt; bound_size()            bound[i-1]     bound[i]
        ///   i == bound_size() (overflow)    bound[i-1]     +inf
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<double> Bounds {
          get { return bounds_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as ExplicitBuckets);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(ExplicitBuckets other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!bounds_.Equals(other.bounds_)) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= bounds_.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          bounds_.WriteTo(output, _repeated_bounds_codec);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          size += bounds_.CalculateSize(_repeated_bounds_codec);
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(ExplicitBuckets other) {
          if (other == null) {
            return;
          }
          bounds_.Add(other.bounds_);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 10:
              case 9: {
                bounds_.AddEntriesFrom(input, _repeated_bounds_codec);
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