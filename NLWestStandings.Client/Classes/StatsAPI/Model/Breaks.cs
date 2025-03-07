using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Breaks
    {
        /// <summary>
        /// Gets or Sets BreakAngle
        /// </summary>
        [DataMember(Name = "breakAngle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breakAngle")]
        public double? BreakAngle { get; set; }

        /// <summary>
        /// Gets or Sets BreakLength
        /// </summary>
        [DataMember(Name = "breakLength", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breakLength")]
        public double? BreakLength { get; set; }

        /// <summary>
        /// Gets or Sets BreakX
        /// </summary>
        [DataMember(Name = "breakX", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breakX")]
        public double? BreakX { get; set; }

        /// <summary>
        /// Gets or Sets BreakY
        /// </summary>
        [DataMember(Name = "breakY", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breakY")]
        public double? BreakY { get; set; }

        /// <summary>
        /// Gets or Sets BreakVertical
        /// </summary>
        [DataMember(Name = "breakVertical", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breakVertical")]
        public double? BreakVertical { get; set; }

        /// <summary>
        /// Gets or Sets BreakVerticalInduced
        /// </summary>
        [DataMember(Name = "breakVerticalInduced", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breakVerticalInduced")]
        public double? BreakVerticalInduced { get; set; }

        /// <summary>
        /// Gets or Sets BreakHorizontal
        /// </summary>
        [DataMember(Name = "breakHorizontal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breakHorizontal")]
        public double? BreakHorizontal { get; set; }

        /// <summary>
        /// Gets or Sets BreakZ
        /// </summary>
        [DataMember(Name = "breakZ", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breakZ")]
        public double? BreakZ { get; set; }

        /// <summary>
        /// Gets or Sets SpinRate
        /// </summary>
        [DataMember(Name = "spinRate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "spinRate")]
        public int? SpinRate { get; set; }

        /// <summary>
        /// Gets or Sets SpinDirection
        /// </summary>
        [DataMember(Name = "spinDirection", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "spinDirection")]
        public int? SpinDirection { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Breaks {\n");
            sb.Append("  BreakAngle: ").Append(BreakAngle).Append("\n");
            sb.Append("  BreakLength: ").Append(BreakLength).Append("\n");
            sb.Append("  BreakX: ").Append(BreakX).Append("\n");
            sb.Append("  BreakY: ").Append(BreakY).Append("\n");
            sb.Append("  BreakVertical: ").Append(BreakVertical).Append("\n");
            sb.Append("  BreakVerticalInduced: ").Append(BreakVerticalInduced).Append("\n");
            sb.Append("  BreakHorizontal: ").Append(BreakHorizontal).Append("\n");
            sb.Append("  BreakZ: ").Append(BreakZ).Append("\n");
            sb.Append("  SpinRate: ").Append(SpinRate).Append("\n");
            sb.Append("  SpinDirection: ").Append(SpinDirection).Append("\n");
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