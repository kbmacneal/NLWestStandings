using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class LeadersRestObject
    {
        /// <summary>
        /// Gets or Sets LeaderCategory
        /// </summary>
        [DataMember(Name = "leaderCategory", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leaderCategory")]
        public string LeaderCategory { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or Sets GameType
        /// </summary>
        [DataMember(Name = "gameType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameType")]
        public GameTypeEnum GameType { get; set; }

        /// <summary>
        /// Gets or Sets Limits
        /// </summary>
        [DataMember(Name = "limits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "limits")]
        public LeaderLimits Limits { get; set; }

        /// <summary>
        /// Gets or Sets LimitMetadata
        /// </summary>
        [DataMember(Name = "limitMetadata", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "limitMetadata")]
        public LimitMetadataRestObject LimitMetadata { get; set; }

        /// <summary>
        /// Gets or Sets Leaders
        /// </summary>
        [DataMember(Name = "leaders", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leaders")]
        public List<PlayerLeaderRestObject> Leaders { get; set; }

        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Hydrations
        /// </summary>
        [DataMember(Name = "hydrations", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydrations")]
        public List<string> Hydrations { get; set; }

        /// <summary>
        /// Gets or Sets StatGroup
        /// </summary>
        [DataMember(Name = "statGroup", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statGroup")]
        public string StatGroup { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeamRestObject Team { get; set; }

        /// <summary>
        /// Gets or Sets League
        /// </summary>
        [DataMember(Name = "league", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "league")]
        public LeagueRestObject League { get; set; }

        /// <summary>
        /// Gets or Sets TotalSplits
        /// </summary>
        [DataMember(Name = "totalSplits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalSplits")]
        public int? TotalSplits { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeadersRestObject {\n");
            sb.Append("  LeaderCategory: ").Append(LeaderCategory).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  GameType: ").Append(GameType).Append("\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
            sb.Append("  LimitMetadata: ").Append(LimitMetadata).Append("\n");
            sb.Append("  Leaders: ").Append(Leaders).Append("\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Hydrations: ").Append(Hydrations).Append("\n");
            sb.Append("  StatGroup: ").Append(StatGroup).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  League: ").Append(League).Append("\n");
            sb.Append("  TotalSplits: ").Append(TotalSplits).Append("\n");
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