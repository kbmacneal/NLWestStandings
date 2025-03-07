using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SocialMediaInfo
    {
        /// <summary>
        /// Gets or Sets Twitter
        /// </summary>
        [DataMember(Name = "twitter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "twitter")]
        public List<string> Twitter { get; set; }

        /// <summary>
        /// Gets or Sets Facebook
        /// </summary>
        [DataMember(Name = "facebook", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "facebook")]
        public List<string> Facebook { get; set; }

        /// <summary>
        /// Gets or Sets Instagram
        /// </summary>
        [DataMember(Name = "instagram", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "instagram")]
        public List<string> Instagram { get; set; }

        /// <summary>
        /// Gets or Sets Vine
        /// </summary>
        [DataMember(Name = "vine", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vine")]
        public List<string> Vine { get; set; }

        /// <summary>
        /// Gets or Sets Periscope
        /// </summary>
        [DataMember(Name = "periscope", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "periscope")]
        public List<string> Periscope { get; set; }

        /// <summary>
        /// Gets or Sets Tumblr
        /// </summary>
        [DataMember(Name = "tumblr", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tumblr")]
        public List<string> Tumblr { get; set; }

        /// <summary>
        /// Gets or Sets Youtube
        /// </summary>
        [DataMember(Name = "youtube", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "youtube")]
        public List<string> Youtube { get; set; }

        /// <summary>
        /// Gets or Sets Pinterest
        /// </summary>
        [DataMember(Name = "pinterest", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pinterest")]
        public List<string> Pinterest { get; set; }

        /// <summary>
        /// Gets or Sets Googleplus
        /// </summary>
        [DataMember(Name = "googleplus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "googleplus")]
        public List<string> Googleplus { get; set; }

        /// <summary>
        /// Gets or Sets Snapchat
        /// </summary>
        [DataMember(Name = "snapchat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "snapchat")]
        public List<string> Snapchat { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name = "website", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "website")]
        public List<string> Website { get; set; }

        /// <summary>
        /// Gets or Sets Hashtags
        /// </summary>
        [DataMember(Name = "hashtags", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hashtags")]
        public List<string> Hashtags { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocialMediaInfo {\n");
            sb.Append("  Twitter: ").Append(Twitter).Append("\n");
            sb.Append("  Facebook: ").Append(Facebook).Append("\n");
            sb.Append("  Instagram: ").Append(Instagram).Append("\n");
            sb.Append("  Vine: ").Append(Vine).Append("\n");
            sb.Append("  Periscope: ").Append(Periscope).Append("\n");
            sb.Append("  Tumblr: ").Append(Tumblr).Append("\n");
            sb.Append("  Youtube: ").Append(Youtube).Append("\n");
            sb.Append("  Pinterest: ").Append(Pinterest).Append("\n");
            sb.Append("  Googleplus: ").Append(Googleplus).Append("\n");
            sb.Append("  Snapchat: ").Append(Snapchat).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Hashtags: ").Append(Hashtags).Append("\n");
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