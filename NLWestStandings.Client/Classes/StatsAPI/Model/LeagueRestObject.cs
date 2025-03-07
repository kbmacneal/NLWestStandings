using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class LeagueRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

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
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets Abbreviation
        /// </summary>
        [DataMember(Name = "abbreviation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or Sets NameShort
        /// </summary>
        [DataMember(Name = "nameShort", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nameShort")]
        public string NameShort { get; set; }

        /// <summary>
        /// Gets or Sets SeasonState
        /// </summary>
        [DataMember(Name = "seasonState", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seasonState")]
        public string SeasonState { get; set; }

        /// <summary>
        /// Gets or Sets HasWildCard
        /// </summary>
        [DataMember(Name = "hasWildCard", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasWildCard")]
        public bool? HasWildCard { get; set; }

        /// <summary>
        /// Gets or Sets HasSplitSeason
        /// </summary>
        [DataMember(Name = "hasSplitSeason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasSplitSeason")]
        public bool? HasSplitSeason { get; set; }

        /// <summary>
        /// Gets or Sets NumGames
        /// </summary>
        [DataMember(Name = "numGames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numGames")]
        public int? NumGames { get; set; }

        /// <summary>
        /// Gets or Sets HasPlayoffPoints
        /// </summary>
        [DataMember(Name = "hasPlayoffPoints", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasPlayoffPoints")]
        public bool? HasPlayoffPoints { get; set; }

        /// <summary>
        /// Gets or Sets NumTeams
        /// </summary>
        [DataMember(Name = "numTeams", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numTeams")]
        public int? NumTeams { get; set; }

        /// <summary>
        /// Gets or Sets NumWildcardTeams
        /// </summary>
        [DataMember(Name = "numWildcardTeams", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numWildcardTeams")]
        public int? NumWildcardTeams { get; set; }

        /// <summary>
        /// Gets or Sets SeasonDateInfo
        /// </summary>
        [DataMember(Name = "seasonDateInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seasonDateInfo")]
        public SeasonRestObject SeasonDateInfo { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or Sets OrgCode
        /// </summary>
        [DataMember(Name = "orgCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orgCode")]
        public string OrgCode { get; set; }

        /// <summary>
        /// Gets or Sets ConferencesInUse
        /// </summary>
        [DataMember(Name = "conferencesInUse", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "conferencesInUse")]
        public bool? ConferencesInUse { get; set; }

        /// <summary>
        /// Gets or Sets DivisionsInUse
        /// </summary>
        [DataMember(Name = "divisionsInUse", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "divisionsInUse")]
        public bool? DivisionsInUse { get; set; }

        /// <summary>
        /// Gets or Sets Sport
        /// </summary>
        [DataMember(Name = "sport", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sport")]
        public SportRestObject Sport { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeZone")]
        public TimeZoneRestObject TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets IsAffiliated
        /// </summary>
        [DataMember(Name = "isAffiliated", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isAffiliated")]
        public bool? IsAffiliated { get; set; }

        /// <summary>
        /// Gets or Sets RuleSettings
        /// </summary>
        [DataMember(Name = "ruleSettings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ruleSettings")]
        public List<RuleSettingsRestObject> RuleSettings { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeagueRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
            sb.Append("  NameShort: ").Append(NameShort).Append("\n");
            sb.Append("  SeasonState: ").Append(SeasonState).Append("\n");
            sb.Append("  HasWildCard: ").Append(HasWildCard).Append("\n");
            sb.Append("  HasSplitSeason: ").Append(HasSplitSeason).Append("\n");
            sb.Append("  NumGames: ").Append(NumGames).Append("\n");
            sb.Append("  HasPlayoffPoints: ").Append(HasPlayoffPoints).Append("\n");
            sb.Append("  NumTeams: ").Append(NumTeams).Append("\n");
            sb.Append("  NumWildcardTeams: ").Append(NumWildcardTeams).Append("\n");
            sb.Append("  SeasonDateInfo: ").Append(SeasonDateInfo).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  OrgCode: ").Append(OrgCode).Append("\n");
            sb.Append("  ConferencesInUse: ").Append(ConferencesInUse).Append("\n");
            sb.Append("  DivisionsInUse: ").Append(DivisionsInUse).Append("\n");
            sb.Append("  Sport: ").Append(Sport).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  IsAffiliated: ").Append(IsAffiliated).Append("\n");
            sb.Append("  RuleSettings: ").Append(RuleSettings).Append("\n");
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