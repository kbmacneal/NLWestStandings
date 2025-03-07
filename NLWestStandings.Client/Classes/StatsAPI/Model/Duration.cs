using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Duration
    {
        /// <summary>
        /// Gets or Sets StandardSeconds
        /// </summary>
        [DataMember(Name = "standardSeconds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "standardSeconds")]
        public long? StandardSeconds { get; set; }

        /// <summary>
        /// Gets or Sets StandardDays
        /// </summary>
        [DataMember(Name = "standardDays", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "standardDays")]
        public long? StandardDays { get; set; }

        /// <summary>
        /// Gets or Sets StandardHours
        /// </summary>
        [DataMember(Name = "standardHours", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "standardHours")]
        public long? StandardHours { get; set; }

        /// <summary>
        /// Gets or Sets StandardMinutes
        /// </summary>
        [DataMember(Name = "standardMinutes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "standardMinutes")]
        public long? StandardMinutes { get; set; }

        /// <summary>
        /// Gets or Sets Millis
        /// </summary>
        [DataMember(Name = "millis", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "millis")]
        public long? Millis { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Duration {\n");
            sb.Append("  StandardSeconds: ").Append(StandardSeconds).Append("\n");
            sb.Append("  StandardDays: ").Append(StandardDays).Append("\n");
            sb.Append("  StandardHours: ").Append(StandardHours).Append("\n");
            sb.Append("  StandardMinutes: ").Append(StandardMinutes).Append("\n");
            sb.Append("  Millis: ").Append(Millis).Append("\n");
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