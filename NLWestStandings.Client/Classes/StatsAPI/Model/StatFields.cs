using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class StatFields
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Standard
        /// </summary>
        [DataMember(Name = "standard", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "standard")]
        public bool? Standard { get; set; }

        /// <summary>
        /// Gets or Sets Advanced
        /// </summary>
        [DataMember(Name = "advanced", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "advanced")]
        public bool? Advanced { get; set; }

        /// <summary>
        /// Gets or Sets Tracking
        /// </summary>
        [DataMember(Name = "tracking", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tracking")]
        public bool? Tracking { get; set; }

        /// <summary>
        /// Gets or Sets Expected
        /// </summary>
        [DataMember(Name = "expected", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expected")]
        public bool? Expected { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatFields {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Standard: ").Append(Standard).Append("\n");
            sb.Append("  Advanced: ").Append(Advanced).Append("\n");
            sb.Append("  Tracking: ").Append(Tracking).Append("\n");
            sb.Append("  Expected: ").Append(Expected).Append("\n");
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