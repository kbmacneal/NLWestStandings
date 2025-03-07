using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class ReleaseDataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name = "extension", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "extension")]
        public double? Extension { get; set; }

        /// <summary>
        /// Gets or Sets Angle
        /// </summary>
        [DataMember(Name = "angle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "angle")]
        public double? Angle { get; set; }

        /// <summary>
        /// Gets or Sets SpinAxis
        /// </summary>
        [DataMember(Name = "spinAxis", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "spinAxis")]
        public double? SpinAxis { get; set; }

        /// <summary>
        /// Gets or Sets SpinRate
        /// </summary>
        [DataMember(Name = "spinRate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "spinRate")]
        public double? SpinRate { get; set; }

        /// <summary>
        /// Gets or Sets SpinFitError
        /// </summary>
        [DataMember(Name = "spinFitError", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "spinFitError")]
        public double? SpinFitError { get; set; }

        /// <summary>
        /// Gets or Sets ReleaseSpeed
        /// </summary>
        [DataMember(Name = "releaseSpeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "releaseSpeed")]
        public double? ReleaseSpeed { get; set; }

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "direction")]
        public double? Direction { get; set; }

        /// <summary>
        /// Gets or Sets ReleasePosition
        /// </summary>
        [DataMember(Name = "releasePosition", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "releasePosition")]
        public CoordinatesRestObject ReleasePosition { get; set; }

        /// <summary>
        /// Gets or Sets SpinVector
        /// </summary>
        [DataMember(Name = "spinVector", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "spinVector")]
        public CoordinatesRestObject SpinVector { get; set; }

        /// <summary>
        /// Gets or Sets SeamOrientation
        /// </summary>
        [DataMember(Name = "seamOrientation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seamOrientation")]
        public SeamOrientationRestObject SeamOrientation { get; set; }

        /// <summary>
        /// Gets or Sets ReducedConfidence
        /// </summary>
        [DataMember(Name = "reducedConfidence", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reducedConfidence")]
        public List<string> ReducedConfidence { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReleaseDataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Angle: ").Append(Angle).Append("\n");
            sb.Append("  SpinAxis: ").Append(SpinAxis).Append("\n");
            sb.Append("  SpinRate: ").Append(SpinRate).Append("\n");
            sb.Append("  SpinFitError: ").Append(SpinFitError).Append("\n");
            sb.Append("  ReleaseSpeed: ").Append(ReleaseSpeed).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  ReleasePosition: ").Append(ReleasePosition).Append("\n");
            sb.Append("  SpinVector: ").Append(SpinVector).Append("\n");
            sb.Append("  SeamOrientation: ").Append(SeamOrientation).Append("\n");
            sb.Append("  ReducedConfidence: ").Append(ReducedConfidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}