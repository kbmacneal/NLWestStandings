using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Division
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
        /// Gets or Sets ConferenceId
        /// </summary>
        [DataMember(Name = "conferenceId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "conferenceId")]
        public int? ConferenceId { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [DataMember(Name = "conference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "conference")]
        public Conference Conference { get; set; }

        /// <summary>
        /// Gets or Sets League
        /// </summary>
        [DataMember(Name = "league", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "league")]
        public League League { get; set; }

        /// <summary>
        /// Gets or Sets SportCode
        /// </summary>
        [DataMember(Name = "sportCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sportCode")]
        public string SportCode { get; set; }

        /// <summary>
        /// Gets or Sets Sport
        /// </summary>
        [DataMember(Name = "sport", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sport")]
        public Sport Sport { get; set; }

        /// <summary>
        /// Gets or Sets Abbreviation
        /// </summary>
        [DataMember(Name = "abbreviation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or Sets HasWildcard
        /// </summary>
        [DataMember(Name = "hasWildcard", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasWildcard")]
        public bool? HasWildcard { get; set; }

        /// <summary>
        /// Gets or Sets NumPlayoffTeams
        /// </summary>
        [DataMember(Name = "numPlayoffTeams", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numPlayoffTeams")]
        public int? NumPlayoffTeams { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

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
        /// Gets or Sets HydratedConferences
        /// </summary>
        [DataMember(Name = "hydratedConferences", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedConferences")]
        public Dictionary<string, Object> HydratedConferences { get; set; }

        /// <summary>
        /// Gets or Sets HydratedLeagues
        /// </summary>
        [DataMember(Name = "hydratedLeagues", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedLeagues")]
        public Dictionary<string, Object> HydratedLeagues { get; set; }

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
            sb.Append("class Division {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameShort: ").Append(NameShort).Append("\n");
            sb.Append("  ConferenceId: ").Append(ConferenceId).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  League: ").Append(League).Append("\n");
            sb.Append("  SportCode: ").Append(SportCode).Append("\n");
            sb.Append("  Sport: ").Append(Sport).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
            sb.Append("  HasWildcard: ").Append(HasWildcard).Append("\n");
            sb.Append("  NumPlayoffTeams: ").Append(NumPlayoffTeams).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  HydratedConferences: ").Append(HydratedConferences).Append("\n");
            sb.Append("  HydratedLeagues: ").Append(HydratedLeagues).Append("\n");
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