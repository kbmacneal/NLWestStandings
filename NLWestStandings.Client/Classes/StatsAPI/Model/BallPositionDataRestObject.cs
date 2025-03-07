using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BallPositionDataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Velocity
        /// </summary>
        [DataMember(Name = "velocity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "velocity")]
        public CoordinatesRestObject Velocity { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "position")]
        public CoordinatesRestObject Position { get; set; }

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
        /// Gets or Sets TimeCode
        /// </summary>
        [DataMember(Name = "timeCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeCode")]
        public long? TimeCode { get; set; }

        /// <summary>
        /// Gets or Sets TimeCodeOffset
        /// </summary>
        [DataMember(Name = "timeCodeOffset", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeCodeOffset")]
        public double? TimeCodeOffset { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BallPositionDataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Velocity: ").Append(Velocity).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  TimeCode: ").Append(TimeCode).Append("\n");
            sb.Append("  TimeCodeOffset: ").Append(TimeCodeOffset).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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