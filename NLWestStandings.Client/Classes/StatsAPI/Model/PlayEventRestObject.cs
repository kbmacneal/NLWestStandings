using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PlayEventRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets IsScrubbed
        /// </summary>
        [DataMember(Name = "isScrubbed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isScrubbed")]
        public bool? IsScrubbed { get; set; }

        /// <summary>
        /// Gets or Sets TimeStamp
        /// </summary>
        [DataMember(Name = "timeStamp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeStamp")]
        public string TimeStamp { get; set; }

        /// <summary>
        /// Gets or Sets PlayEventType
        /// </summary>
        [DataMember(Name = "playEventType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playEventType")]
        public int? PlayEventType { get; set; }

        /// <summary>
        /// Gets or Sets PlayEventId
        /// </summary>
        [DataMember(Name = "playEventId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playEventId")]
        public string PlayEventId { get; set; }

        /// <summary>
        /// Gets or Sets PositionId
        /// </summary>
        [DataMember(Name = "positionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "positionId")]
        public int? PositionId { get; set; }

        /// <summary>
        /// Gets or Sets TimeCode
        /// </summary>
        [DataMember(Name = "timeCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeCode")]
        public long? TimeCode { get; set; }

        /// <summary>
        /// Gets or Sets PlayEvent
        /// </summary>
        [DataMember(Name = "playEvent", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playEvent")]
        public string PlayEvent { get; set; }

        /// <summary>
        /// Gets or Sets X
        /// </summary>
        [DataMember(Name = "x", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "x")]
        public double? X { get; set; }

        /// <summary>
        /// Gets or Sets Y
        /// </summary>
        [DataMember(Name = "y", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "y")]
        public double? Y { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayEventRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  IsScrubbed: ").Append(IsScrubbed).Append("\n");
            sb.Append("  TimeStamp: ").Append(TimeStamp).Append("\n");
            sb.Append("  PlayEventType: ").Append(PlayEventType).Append("\n");
            sb.Append("  PlayEventId: ").Append(PlayEventId).Append("\n");
            sb.Append("  PositionId: ").Append(PositionId).Append("\n");
            sb.Append("  TimeCode: ").Append(TimeCode).Append("\n");
            sb.Append("  PlayEvent: ").Append(PlayEvent).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
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