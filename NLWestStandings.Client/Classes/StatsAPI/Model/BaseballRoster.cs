using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballRoster
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

        /// <summary>
        /// Gets or Sets RosterType
        /// </summary>
        [DataMember(Name = "rosterType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rosterType")]
        public RosterType RosterType { get; set; }

        /// <summary>
        /// Gets or Sets Roster
        /// </summary>
        [DataMember(Name = "roster", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "roster")]
        public List<BaseballRosterEntry> Roster { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name = "teamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamId")]
        public int? TeamId { get; set; }

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
            sb.Append("class BaseballRoster {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  RosterType: ").Append(RosterType).Append("\n");
            sb.Append("  Roster: ").Append(Roster).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
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