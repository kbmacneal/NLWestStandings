using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballGameMetaDataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Wait
        /// </summary>
        [DataMember(Name = "wait", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// Gets or Sets TimeStamp
        /// </summary>
        [DataMember(Name = "timeStamp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeStamp")]
        public string TimeStamp { get; set; }

        /// <summary>
        /// Gets or Sets GameEvents
        /// </summary>
        [DataMember(Name = "gameEvents", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameEvents")]
        public List<string> GameEvents { get; set; }

        /// <summary>
        /// Gets or Sets LogicalEvents
        /// </summary>
        [DataMember(Name = "logicalEvents", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "logicalEvents")]
        public List<string> LogicalEvents { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballGameMetaDataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Wait: ").Append(Wait).Append("\n");
            sb.Append("  TimeStamp: ").Append(TimeStamp).Append("\n");
            sb.Append("  GameEvents: ").Append(GameEvents).Append("\n");
            sb.Append("  LogicalEvents: ").Append(LogicalEvents).Append("\n");
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