using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class AnalyticsGameMetadataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets GamePk
        /// </summary>
        [DataMember(Name = "gamePk", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamePk")]
        public string GamePk { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "updatedAt")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets AuditUpdatedAt
        /// </summary>
        [DataMember(Name = "auditUpdatedAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "auditUpdatedAt")]
        public string AuditUpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets MetricsUpdatedAt
        /// </summary>
        [DataMember(Name = "metricsUpdatedAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "metricsUpdatedAt")]
        public string MetricsUpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets VideoUpdatedAt
        /// </summary>
        [DataMember(Name = "videoUpdatedAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "videoUpdatedAt")]
        public string VideoUpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsGameMetadataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  GamePk: ").Append(GamePk).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  AuditUpdatedAt: ").Append(AuditUpdatedAt).Append("\n");
            sb.Append("  MetricsUpdatedAt: ").Append(MetricsUpdatedAt).Append("\n");
            sb.Append("  VideoUpdatedAt: ").Append(VideoUpdatedAt).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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