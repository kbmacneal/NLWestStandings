using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballViolation
    {
        /// <summary>
        /// Gets or Sets ViolationType
        /// </summary>
        [DataMember(Name = "violationType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "violationType")]
        public string ViolationType { get; set; }

        /// <summary>
        /// Gets or Sets ViolationSubType
        /// </summary>
        [DataMember(Name = "violationSubType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "violationSubType")]
        public string ViolationSubType { get; set; }

        /// <summary>
        /// Gets or Sets ViolationDescription
        /// </summary>
        [DataMember(Name = "violationDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "violationDescription")]
        public string ViolationDescription { get; set; }

        /// <summary>
        /// Gets or Sets ViolationPlayer
        /// </summary>
        [DataMember(Name = "violationPlayer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "violationPlayer")]
        public BaseballPerson ViolationPlayer { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballViolation {\n");
            sb.Append("  ViolationType: ").Append(ViolationType).Append("\n");
            sb.Append("  ViolationSubType: ").Append(ViolationSubType).Append("\n");
            sb.Append("  ViolationDescription: ").Append(ViolationDescription).Append("\n");
            sb.Append("  ViolationPlayer: ").Append(ViolationPlayer).Append("\n");
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