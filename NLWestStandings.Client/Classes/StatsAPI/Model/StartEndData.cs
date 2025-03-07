using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class StartEndData
    {
        /// <summary>
        /// Gets or Sets Velocity
        /// </summary>
        [DataMember(Name = "velocity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "velocity")]
        public Coordinates Velocity { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "position")]
        public Coordinates Position { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "time")]
        public double? Time { get; set; }

        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name = "confidence", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "confidence")]
        public string Confidence { get; set; }

        /// <summary>
        /// Gets or Sets Speed
        /// </summary>
        [DataMember(Name = "speed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Gets or Sets Bearing
        /// </summary>
        [DataMember(Name = "bearing", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bearing")]
        public double? Bearing { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name = "distance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "distance")]
        public double? Distance { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartEndData {\n");
            sb.Append("  Velocity: ").Append(Velocity).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  Speed: ").Append(Speed).Append("\n");
            sb.Append("  Bearing: ").Append(Bearing).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
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