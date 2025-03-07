using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class TeamStandingsRecordContainerRestObject
    {
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
        /// Gets or Sets StandingsType
        /// </summary>
        [DataMember(Name = "standingsType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "standingsType")]
        public string StandingsType { get; set; }

        /// <summary>
        /// Gets or Sets League
        /// </summary>
        [DataMember(Name = "league", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "league")]
        public LeagueRestObject League { get; set; }

        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name = "division", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "division")]
        public DivisionRestObject Division { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [DataMember(Name = "conference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "conference")]
        public ConferenceRestObject Conference { get; set; }

        /// <summary>
        /// Gets or Sets Sport
        /// </summary>
        [DataMember(Name = "sport", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sport")]
        public SportRestObject Sport { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name = "organization", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "organization")]
        public BaseballTeamRestObject Organization { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastUpdated")]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets AggregateRecord
        /// </summary>
        [DataMember(Name = "aggregateRecord", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "aggregateRecord")]
        public TeamStandingsRecordRestObject AggregateRecord { get; set; }

        /// <summary>
        /// Gets or Sets TeamRecords
        /// </summary>
        [DataMember(Name = "teamRecords", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamRecords")]
        public List<TeamStandingsRecordRestObject> TeamRecords { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamStandingsRecordContainerRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Hydrations: ").Append(Hydrations).Append("\n");
            sb.Append("  StandingsType: ").Append(StandingsType).Append("\n");
            sb.Append("  League: ").Append(League).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Sport: ").Append(Sport).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  AggregateRecord: ").Append(AggregateRecord).Append("\n");
            sb.Append("  TeamRecords: ").Append(TeamRecords).Append("\n");
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