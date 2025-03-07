using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Leaders
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

        /// <summary>
        /// Gets or Sets LeaderCategory
        /// </summary>
        [DataMember(Name = "leaderCategory", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leaderCategory")]
        public PersonLeadersEnum LeaderCategory { get; set; }

        /// <summary>
        /// Gets or Sets StatGroup
        /// </summary>
        [DataMember(Name = "statGroup", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statGroup")]
        public StatGroup StatGroup { get; set; }

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
        /// Gets or Sets StatType
        /// </summary>
        [DataMember(Name = "statType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statType")]
        public StatType StatType { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeam Team { get; set; }

        /// <summary>
        /// Gets or Sets League
        /// </summary>
        [DataMember(Name = "league", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "league")]
        public League League { get; set; }

        /// <summary>
        /// Gets or Sets TotalSplits
        /// </summary>
        [DataMember(Name = "totalSplits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalSplits")]
        public int? TotalSplits { get; set; }

        /// <summary>
        /// Gets or Sets _Leaders
        /// </summary>
        [DataMember(Name = "leaders", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leaders")]
        public List<PlayerLeader> _Leaders { get; set; }

        /// <summary>
        /// Gets or Sets Limits
        /// </summary>
        [DataMember(Name = "limits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "limits")]
        public LeaderLimits Limits { get; set; }

        /// <summary>
        /// Gets or Sets LimitMetaData
        /// </summary>
        [DataMember(Name = "limitMetaData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "limitMetaData")]
        public LimitMetadata LimitMetaData { get; set; }

        /// <summary>
        /// Gets or Sets HydratedTeams
        /// </summary>
        [DataMember(Name = "hydratedTeams", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedTeams")]
        public Dictionary<string, Object> HydratedTeams { get; set; }

        /// <summary>
        /// Gets or Sets HydratedPeople
        /// </summary>
        [DataMember(Name = "hydratedPeople", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedPeople")]
        public Dictionary<string, Object> HydratedPeople { get; set; }

        /// <summary>
        /// Gets or Sets UserPrivileges
        /// </summary>
        [DataMember(Name = "userPrivileges", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "userPrivileges")]
        public List<Privilege> UserPrivileges { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Leaders {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  LeaderCategory: ").Append(LeaderCategory).Append("\n");
            sb.Append("  StatGroup: ").Append(StatGroup).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  GameType: ").Append(GameType).Append("\n");
            sb.Append("  StatType: ").Append(StatType).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  League: ").Append(League).Append("\n");
            sb.Append("  TotalSplits: ").Append(TotalSplits).Append("\n");
            sb.Append("  _Leaders: ").Append(_Leaders).Append("\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
            sb.Append("  LimitMetaData: ").Append(LimitMetaData).Append("\n");
            sb.Append("  HydratedTeams: ").Append(HydratedTeams).Append("\n");
            sb.Append("  HydratedPeople: ").Append(HydratedPeople).Append("\n");
            sb.Append("  UserPrivileges: ").Append(UserPrivileges).Append("\n");
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