using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Highlights
    {
        /// <summary>
        /// Gets or Sets Scoreboard
        /// </summary>
        [DataMember(Name = "scoreboard", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scoreboard")]
        public JsonNode Scoreboard { get; set; }

        /// <summary>
        /// Gets or Sets GameCenter
        /// </summary>
        [DataMember(Name = "gameCenter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameCenter")]
        public JsonNode GameCenter { get; set; }

        /// <summary>
        /// Gets or Sets Milestone
        /// </summary>
        [DataMember(Name = "milestone", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestone")]
        public JsonNode Milestone { get; set; }

        /// <summary>
        /// Gets or Sets _Highlights
        /// </summary>
        [DataMember(Name = "highlights", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "highlights")]
        public JsonNode _Highlights { get; set; }

        /// <summary>
        /// Gets or Sets LiveHighlights
        /// </summary>
        [DataMember(Name = "liveHighlights", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "liveHighlights")]
        public JsonNode LiveHighlights { get; set; }

        /// <summary>
        /// Gets or Sets ScoreboardPreview
        /// </summary>
        [DataMember(Name = "scoreboardPreview", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scoreboardPreview")]
        public JsonNode ScoreboardPreview { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Highlights {\n");
            sb.Append("  Scoreboard: ").Append(Scoreboard).Append("\n");
            sb.Append("  GameCenter: ").Append(GameCenter).Append("\n");
            sb.Append("  Milestone: ").Append(Milestone).Append("\n");
            sb.Append("  _Highlights: ").Append(_Highlights).Append("\n");
            sb.Append("  LiveHighlights: ").Append(LiveHighlights).Append("\n");
            sb.Append("  ScoreboardPreview: ").Append(ScoreboardPreview).Append("\n");
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