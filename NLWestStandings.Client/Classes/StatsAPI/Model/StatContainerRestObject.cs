using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class StatContainerRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Disclaimers
        /// </summary>
        [DataMember(Name = "disclaimers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "disclaimers")]
        public List<string> Disclaimers { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parameters")]
        public Dictionary<string, Object> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public StatType Type { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "group")]
        public StatGroup Group { get; set; }

        /// <summary>
        /// Gets or Sets TotalSplits
        /// </summary>
        [DataMember(Name = "totalSplits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalSplits")]
        public int? TotalSplits { get; set; }

        /// <summary>
        /// Gets or Sets Exemptions
        /// </summary>
        [DataMember(Name = "exemptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "exemptions")]
        public List<StatExemptionRestObject> Exemptions { get; set; }

        /// <summary>
        /// Gets or Sets Splits
        /// </summary>
        [DataMember(Name = "splits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "splits")]
        public List<StatSplitsRestObject> Splits { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name = "stats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stats")]
        public StatDataRestObject Stats { get; set; }

        /// <summary>
        /// Gets or Sets SplitsTiedWithOffset
        /// </summary>
        [DataMember(Name = "splitsTiedWithOffset", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "splitsTiedWithOffset")]
        public List<StatSplitsRestObject> SplitsTiedWithOffset { get; set; }

        /// <summary>
        /// Gets or Sets SplitsTiedWithLimit
        /// </summary>
        [DataMember(Name = "splitsTiedWithLimit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "splitsTiedWithLimit")]
        public List<StatSplitsRestObject> SplitsTiedWithLimit { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "player")]
        public BaseballPersonRestObject Player { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeamRestObject Team { get; set; }

        /// <summary>
        /// Gets or Sets Sport
        /// </summary>
        [DataMember(Name = "sport", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sport")]
        public SportRestObject Sport { get; set; }

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
        /// Gets or Sets PlayerPool
        /// </summary>
        [DataMember(Name = "playerPool", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playerPool")]
        public PlayerPoolEnum PlayerPool { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatContainerRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Disclaimers: ").Append(Disclaimers).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  TotalSplits: ").Append(TotalSplits).Append("\n");
            sb.Append("  Exemptions: ").Append(Exemptions).Append("\n");
            sb.Append("  Splits: ").Append(Splits).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  SplitsTiedWithOffset: ").Append(SplitsTiedWithOffset).Append("\n");
            sb.Append("  SplitsTiedWithLimit: ").Append(SplitsTiedWithLimit).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Sport: ").Append(Sport).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  GameType: ").Append(GameType).Append("\n");
            sb.Append("  PlayerPool: ").Append(PlayerPool).Append("\n");
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