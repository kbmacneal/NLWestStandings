using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class FieldInfo
    {
        /// <summary>
        /// Gets or Sets Capacity
        /// </summary>
        [DataMember(Name = "capacity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// Gets or Sets TurfType
        /// </summary>
        [DataMember(Name = "turfType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "turfType")]
        public string TurfType { get; set; }

        /// <summary>
        /// Gets or Sets RoofType
        /// </summary>
        [DataMember(Name = "roofType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "roofType")]
        public string RoofType { get; set; }

        /// <summary>
        /// Gets or Sets LeftLine
        /// </summary>
        [DataMember(Name = "leftLine", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leftLine")]
        public int? LeftLine { get; set; }

        /// <summary>
        /// Gets or Sets Left
        /// </summary>
        [DataMember(Name = "left", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "left")]
        public int? Left { get; set; }

        /// <summary>
        /// Gets or Sets LeftCenter
        /// </summary>
        [DataMember(Name = "leftCenter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leftCenter")]
        public int? LeftCenter { get; set; }

        /// <summary>
        /// Gets or Sets Center
        /// </summary>
        [DataMember(Name = "center", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "center")]
        public int? Center { get; set; }

        /// <summary>
        /// Gets or Sets RightCenter
        /// </summary>
        [DataMember(Name = "rightCenter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rightCenter")]
        public int? RightCenter { get; set; }

        /// <summary>
        /// Gets or Sets Right
        /// </summary>
        [DataMember(Name = "right", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "right")]
        public int? Right { get; set; }

        /// <summary>
        /// Gets or Sets RightLine
        /// </summary>
        [DataMember(Name = "rightLine", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rightLine")]
        public int? RightLine { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldInfo {\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  TurfType: ").Append(TurfType).Append("\n");
            sb.Append("  RoofType: ").Append(RoofType).Append("\n");
            sb.Append("  LeftLine: ").Append(LeftLine).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  LeftCenter: ").Append(LeftCenter).Append("\n");
            sb.Append("  Center: ").Append(Center).Append("\n");
            sb.Append("  RightCenter: ").Append(RightCenter).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  RightLine: ").Append(RightLine).Append("\n");
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