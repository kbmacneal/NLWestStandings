using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class League
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NameShort
        /// </summary>
        [DataMember(Name = "nameShort", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nameShort")]
        public string NameShort { get; set; }

        /// <summary>
        /// Gets or Sets NameAbbreviation
        /// </summary>
        [DataMember(Name = "nameAbbreviation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nameAbbreviation")]
        public string NameAbbreviation { get; set; }

        /// <summary>
        /// Gets or Sets OrgCode
        /// </summary>
        [DataMember(Name = "orgCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orgCode")]
        public string OrgCode { get; set; }

        /// <summary>
        /// Gets or Sets Sport
        /// </summary>
        [DataMember(Name = "sport", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sport")]
        public Sport Sport { get; set; }

        /// <summary>
        /// Gets or Sets SeasonState
        /// </summary>
        [DataMember(Name = "seasonState", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seasonState")]
        public string SeasonState { get; set; }

        /// <summary>
        /// Gets or Sets HasWildcard
        /// </summary>
        [DataMember(Name = "hasWildcard", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasWildcard")]
        public bool? HasWildcard { get; set; }

        /// <summary>
        /// Gets or Sets HasSplitSeason
        /// </summary>
        [DataMember(Name = "hasSplitSeason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasSplitSeason")]
        public bool? HasSplitSeason { get; set; }

        /// <summary>
        /// Gets or Sets SeasonDateInfo
        /// </summary>
        [DataMember(Name = "seasonDateInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seasonDateInfo")]
        public Season SeasonDateInfo { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or Sets LeagueTimeZone
        /// </summary>
        [DataMember(Name = "leagueTimeZone", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leagueTimeZone")]
        public TimeZone LeagueTimeZone { get; set; }

        /// <summary>
        /// Gets or Sets Games
        /// </summary>
        [DataMember(Name = "games", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "games")]
        public int? Games { get; set; }

        /// <summary>
        /// Gets or Sets HasPlayoffPoints
        /// </summary>
        [DataMember(Name = "hasPlayoffPoints", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasPlayoffPoints")]
        public bool? HasPlayoffPoints { get; set; }

        /// <summary>
        /// Gets or Sets TotalTeams
        /// </summary>
        [DataMember(Name = "totalTeams", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalTeams")]
        public int? TotalTeams { get; set; }

        /// <summary>
        /// Gets or Sets TotalWildcardTeams
        /// </summary>
        [DataMember(Name = "totalWildcardTeams", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalWildcardTeams")]
        public int? TotalWildcardTeams { get; set; }

        /// <summary>
        /// Gets or Sets HasDivisions
        /// </summary>
        [DataMember(Name = "hasDivisions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasDivisions")]
        public bool? HasDivisions { get; set; }

        /// <summary>
        /// Gets or Sets HasConferences
        /// </summary>
        [DataMember(Name = "hasConferences", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasConferences")]
        public bool? HasConferences { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeZone")]
        public TimeZone TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets DefaultVenueId
        /// </summary>
        [DataMember(Name = "defaultVenueId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "defaultVenueId")]
        public int? DefaultVenueId { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets RuleSettings
        /// </summary>
        [DataMember(Name = "ruleSettings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ruleSettings")]
        public List<RuleSettings> RuleSettings { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets Affiliated
        /// </summary>
        [DataMember(Name = "affiliated", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "affiliated")]
        public bool? Affiliated { get; set; }

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
            sb.Append("class League {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameShort: ").Append(NameShort).Append("\n");
            sb.Append("  NameAbbreviation: ").Append(NameAbbreviation).Append("\n");
            sb.Append("  OrgCode: ").Append(OrgCode).Append("\n");
            sb.Append("  Sport: ").Append(Sport).Append("\n");
            sb.Append("  SeasonState: ").Append(SeasonState).Append("\n");
            sb.Append("  HasWildcard: ").Append(HasWildcard).Append("\n");
            sb.Append("  HasSplitSeason: ").Append(HasSplitSeason).Append("\n");
            sb.Append("  SeasonDateInfo: ").Append(SeasonDateInfo).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  LeagueTimeZone: ").Append(LeagueTimeZone).Append("\n");
            sb.Append("  Games: ").Append(Games).Append("\n");
            sb.Append("  HasPlayoffPoints: ").Append(HasPlayoffPoints).Append("\n");
            sb.Append("  TotalTeams: ").Append(TotalTeams).Append("\n");
            sb.Append("  TotalWildcardTeams: ").Append(TotalWildcardTeams).Append("\n");
            sb.Append("  HasDivisions: ").Append(HasDivisions).Append("\n");
            sb.Append("  HasConferences: ").Append(HasConferences).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  DefaultVenueId: ").Append(DefaultVenueId).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  RuleSettings: ").Append(RuleSettings).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Affiliated: ").Append(Affiliated).Append("\n");
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