using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class GameContentRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets Editorial
        /// </summary>
        [DataMember(Name = "editorial", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "editorial")]
        public GameEditorialRestObject Editorial { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name = "media", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "media")]
        public GameMediaRestObject Media { get; set; }

        /// <summary>
        /// Gets or Sets Highlights
        /// </summary>
        [DataMember(Name = "highlights", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "highlights")]
        public GameHighlightsRestObject Highlights { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "summary")]
        public GameContentSummaryRestObject Summary { get; set; }

        /// <summary>
        /// Gets or Sets GameNotes
        /// </summary>
        [DataMember(Name = "gameNotes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameNotes")]
        public GameNotesRestObject GameNotes { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameContentRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Editorial: ").Append(Editorial).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Highlights: ").Append(Highlights).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  GameNotes: ").Append(GameNotes).Append("\n");
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