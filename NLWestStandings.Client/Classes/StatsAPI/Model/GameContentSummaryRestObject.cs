using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class GameContentSummaryRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets HasPreviewArticle
        /// </summary>
        [DataMember(Name = "hasPreviewArticle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasPreviewArticle")]
        public bool? HasPreviewArticle { get; set; }

        /// <summary>
        /// Gets or Sets HasRecapArticle
        /// </summary>
        [DataMember(Name = "hasRecapArticle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasRecapArticle")]
        public bool? HasRecapArticle { get; set; }

        /// <summary>
        /// Gets or Sets HasWrapArticle
        /// </summary>
        [DataMember(Name = "hasWrapArticle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasWrapArticle")]
        public bool? HasWrapArticle { get; set; }

        /// <summary>
        /// Gets or Sets HasHighlightsVideo
        /// </summary>
        [DataMember(Name = "hasHighlightsVideo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasHighlightsVideo")]
        public bool? HasHighlightsVideo { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameContentSummaryRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  HasPreviewArticle: ").Append(HasPreviewArticle).Append("\n");
            sb.Append("  HasRecapArticle: ").Append(HasRecapArticle).Append("\n");
            sb.Append("  HasWrapArticle: ").Append(HasWrapArticle).Append("\n");
            sb.Append("  HasHighlightsVideo: ").Append(HasHighlightsVideo).Append("\n");
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