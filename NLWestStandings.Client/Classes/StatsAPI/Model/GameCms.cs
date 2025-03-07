using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class GameCms
    {
        /// <summary>
        /// Gets or Sets Editorial
        /// </summary>
        [DataMember(Name = "editorial", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "editorial")]
        public Editorial Editorial { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name = "media", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "media")]
        public Media Media { get; set; }

        /// <summary>
        /// Gets or Sets Highlights
        /// </summary>
        [DataMember(Name = "highlights", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "highlights")]
        public Highlights Highlights { get; set; }

        /// <summary>
        /// Gets or Sets GameNotes
        /// </summary>
        [DataMember(Name = "gameNotes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameNotes")]
        public GameNotes GameNotes { get; set; }

        /// <summary>
        /// Gets or Sets ContentSummary
        /// </summary>
        [DataMember(Name = "contentSummary", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "contentSummary")]
        public ContentSummary ContentSummary { get; set; }

        /// <summary>
        /// Gets or Sets Lineup
        /// </summary>
        [DataMember(Name = "lineup", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lineup")]
        public Lineup Lineup { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameCms {\n");
            sb.Append("  Editorial: ").Append(Editorial).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Highlights: ").Append(Highlights).Append("\n");
            sb.Append("  GameNotes: ").Append(GameNotes).Append("\n");
            sb.Append("  ContentSummary: ").Append(ContentSummary).Append("\n");
            sb.Append("  Lineup: ").Append(Lineup).Append("\n");
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