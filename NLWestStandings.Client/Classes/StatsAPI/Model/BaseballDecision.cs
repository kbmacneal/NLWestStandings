using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballDecision
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

        /// <summary>
        /// Gets or Sets Winner
        /// </summary>
        [DataMember(Name = "winner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "winner")]
        public BaseballPerson Winner { get; set; }

        /// <summary>
        /// Gets or Sets Loser
        /// </summary>
        [DataMember(Name = "loser", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "loser")]
        public BaseballPerson Loser { get; set; }

        /// <summary>
        /// Gets or Sets Save
        /// </summary>
        [DataMember(Name = "save", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "save")]
        public BaseballPerson Save { get; set; }

        /// <summary>
        /// Gets or Sets Empty
        /// </summary>
        [DataMember(Name = "empty", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "empty")]
        public bool? Empty { get; set; }

        /// <summary>
        /// Gets or Sets NotEmpty
        /// </summary>
        [DataMember(Name = "notEmpty", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "notEmpty")]
        public bool? NotEmpty { get; set; }

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
            sb.Append("class BaseballDecision {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  Winner: ").Append(Winner).Append("\n");
            sb.Append("  Loser: ").Append(Loser).Append("\n");
            sb.Append("  Save: ").Append(Save).Append("\n");
            sb.Append("  Empty: ").Append(Empty).Append("\n");
            sb.Append("  NotEmpty: ").Append(NotEmpty).Append("\n");
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