using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Franchise
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

        /// <summary>
        /// Gets or Sets FranchiseId
        /// </summary>
        [DataMember(Name = "franchiseId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "franchiseId")]
        public int? FranchiseId { get; set; }

        /// <summary>
        /// Gets or Sets FirstSeasonId
        /// </summary>
        [DataMember(Name = "firstSeasonId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstSeasonId")]
        public int? FirstSeasonId { get; set; }

        /// <summary>
        /// Gets or Sets LastSeasonId
        /// </summary>
        [DataMember(Name = "lastSeasonId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastSeasonId")]
        public int? LastSeasonId { get; set; }

        /// <summary>
        /// Gets or Sets MostRecentTeamId
        /// </summary>
        [DataMember(Name = "mostRecentTeamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mostRecentTeamId")]
        public int? MostRecentTeamId { get; set; }

        /// <summary>
        /// Gets or Sets TeamName
        /// </summary>
        [DataMember(Name = "teamName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamName")]
        public string TeamName { get; set; }

        /// <summary>
        /// Gets or Sets LocationName
        /// </summary>
        [DataMember(Name = "locationName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "locationName")]
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or Sets TeamIds
        /// </summary>
        [DataMember(Name = "teamIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamIds")]
        public List<int?> TeamIds { get; set; }

        /// <summary>
        /// Gets or Sets Roster
        /// </summary>
        [DataMember(Name = "roster", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "roster")]
        public BaseballRoster Roster { get; set; }

        /// <summary>
        /// Gets or Sets HydratedRosters
        /// </summary>
        [DataMember(Name = "hydratedRosters", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedRosters")]
        public Dictionary<string, Object> HydratedRosters { get; set; }

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
            sb.Append("class Franchise {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  FranchiseId: ").Append(FranchiseId).Append("\n");
            sb.Append("  FirstSeasonId: ").Append(FirstSeasonId).Append("\n");
            sb.Append("  LastSeasonId: ").Append(LastSeasonId).Append("\n");
            sb.Append("  MostRecentTeamId: ").Append(MostRecentTeamId).Append("\n");
            sb.Append("  TeamName: ").Append(TeamName).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  TeamIds: ").Append(TeamIds).Append("\n");
            sb.Append("  Roster: ").Append(Roster).Append("\n");
            sb.Append("  HydratedRosters: ").Append(HydratedRosters).Append("\n");
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