using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Media
    {
        /// <summary>
        /// Gets or Sets Epg
        /// </summary>
        [DataMember(Name = "epg", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "epg")]
        public JsonNode Epg { get; set; }

        /// <summary>
        /// Gets or Sets EpgAlternate
        /// </summary>
        [DataMember(Name = "epgAlternate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "epgAlternate")]
        public JsonNode EpgAlternate { get; set; }

        /// <summary>
        /// Gets or Sets Milestones
        /// </summary>
        [DataMember(Name = "milestones", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestones")]
        public JsonNode Milestones { get; set; }

        /// <summary>
        /// Gets or Sets FeaturedMedia
        /// </summary>
        [DataMember(Name = "featuredMedia", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "featuredMedia")]
        public JsonNode FeaturedMedia { get; set; }

        /// <summary>
        /// Gets or Sets PreviewStory
        /// </summary>
        [DataMember(Name = "previewStory", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "previewStory")]
        public JsonNode PreviewStory { get; set; }

        /// <summary>
        /// Gets or Sets GameStory
        /// </summary>
        [DataMember(Name = "gameStory", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameStory")]
        public JsonNode GameStory { get; set; }

        /// <summary>
        /// Gets or Sets FreeGame
        /// </summary>
        [DataMember(Name = "freeGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "freeGame")]
        public bool? FreeGame { get; set; }

        /// <summary>
        /// Gets or Sets EnhancedGame
        /// </summary>
        [DataMember(Name = "enhancedGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "enhancedGame")]
        public bool? EnhancedGame { get; set; }

        /// <summary>
        /// Gets or Sets Broadcasts
        /// </summary>
        [DataMember(Name = "broadcasts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcasts")]
        public List<GameDateBroadcast> Broadcasts { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Media {\n");
            sb.Append("  Epg: ").Append(Epg).Append("\n");
            sb.Append("  EpgAlternate: ").Append(EpgAlternate).Append("\n");
            sb.Append("  Milestones: ").Append(Milestones).Append("\n");
            sb.Append("  FeaturedMedia: ").Append(FeaturedMedia).Append("\n");
            sb.Append("  PreviewStory: ").Append(PreviewStory).Append("\n");
            sb.Append("  GameStory: ").Append(GameStory).Append("\n");
            sb.Append("  FreeGame: ").Append(FreeGame).Append("\n");
            sb.Append("  EnhancedGame: ").Append(EnhancedGame).Append("\n");
            sb.Append("  Broadcasts: ").Append(Broadcasts).Append("\n");
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