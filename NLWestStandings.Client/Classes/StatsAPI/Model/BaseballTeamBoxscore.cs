using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballTeamBoxscore
    {
        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeamRestObject Team { get; set; }

        /// <summary>
        /// Gets or Sets TeamStats
        /// </summary>
        [DataMember(Name = "teamStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamStats")]
        public StatsRestObject TeamStats { get; set; }

        /// <summary>
        /// Gets or Sets Players
        /// </summary>
        [DataMember(Name = "players", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "players")]
        public Dictionary<string, BaseballRosterEntryRestObject> Players { get; set; }

        /// <summary>
        /// Gets or Sets Batters
        /// </summary>
        [DataMember(Name = "batters", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batters")]
        public List<int?> Batters { get; set; }

        /// <summary>
        /// Gets or Sets Pitchers
        /// </summary>
        [DataMember(Name = "pitchers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchers")]
        public List<int?> Pitchers { get; set; }

        /// <summary>
        /// Gets or Sets Bench
        /// </summary>
        [DataMember(Name = "bench", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bench")]
        public List<int?> Bench { get; set; }

        /// <summary>
        /// Gets or Sets Bullpen
        /// </summary>
        [DataMember(Name = "bullpen", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bullpen")]
        public List<int?> Bullpen { get; set; }

        /// <summary>
        /// Gets or Sets BattingOrder
        /// </summary>
        [DataMember(Name = "battingOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "battingOrder")]
        public List<int?> BattingOrder { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name = "info", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "info")]
        public List<BaseballBoxscoreNoteWrapRestObject> Info { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "note")]
        public List<BaseballBoxscoreNoteRestObject> Note { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballTeamBoxscore {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  TeamStats: ").Append(TeamStats).Append("\n");
            sb.Append("  Players: ").Append(Players).Append("\n");
            sb.Append("  Batters: ").Append(Batters).Append("\n");
            sb.Append("  Pitchers: ").Append(Pitchers).Append("\n");
            sb.Append("  Bench: ").Append(Bench).Append("\n");
            sb.Append("  Bullpen: ").Append(Bullpen).Append("\n");
            sb.Append("  BattingOrder: ").Append(BattingOrder).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
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