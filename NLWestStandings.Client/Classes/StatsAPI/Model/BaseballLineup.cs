using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballLineup
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

        /// <summary>
        /// Gets or Sets AwayPlayers
        /// </summary>
        [DataMember(Name = "awayPlayers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayPlayers")]
        public List<BaseballPerson> AwayPlayers { get; set; }

        /// <summary>
        /// Gets or Sets HomePlayers
        /// </summary>
        [DataMember(Name = "homePlayers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homePlayers")]
        public List<BaseballPerson> HomePlayers { get; set; }

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
            sb.Append("class BaseballLineup {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  AwayPlayers: ").Append(AwayPlayers).Append("\n");
            sb.Append("  HomePlayers: ").Append(HomePlayers).Append("\n");
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