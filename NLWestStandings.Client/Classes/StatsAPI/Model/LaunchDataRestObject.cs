using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class LaunchDataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Speed
        /// </summary>
        [DataMember(Name = "speed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "speed")]
        public double? Speed { get; set; }

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
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "direction")]
        public double? Direction { get; set; }

        /// <summary>
        /// Gets or Sets SpinRate
        /// </summary>
        [DataMember(Name = "spinRate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "spinRate")]
        public double? SpinRate { get; set; }

        /// <summary>
        /// Gets or Sets ContactPosition
        /// </summary>
        [DataMember(Name = "contactPosition", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "contactPosition")]
        public PositionRestObject ContactPosition { get; set; }

        /// <summary>
        /// Gets or Sets ReducedConfidence
        /// </summary>
        [DataMember(Name = "reducedConfidence", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reducedConfidence")]
        public List<string> ReducedConfidence { get; set; }

        /// <summary>
        /// Gets or Sets SpinVector
        /// </summary>
        [DataMember(Name = "spinVector", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "spinVector")]
        public CoordinatesRestObject SpinVector { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LaunchDataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Speed: ").Append(Speed).Append("\n");
            sb.Append("  Angle: ").Append(Angle).Append("\n");
            sb.Append("  SpinAxis: ").Append(SpinAxis).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  SpinRate: ").Append(SpinRate).Append("\n");
            sb.Append("  ContactPosition: ").Append(ContactPosition).Append("\n");
            sb.Append("  ReducedConfidence: ").Append(ReducedConfidence).Append("\n");
            sb.Append("  SpinVector: ").Append(SpinVector).Append("\n");
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