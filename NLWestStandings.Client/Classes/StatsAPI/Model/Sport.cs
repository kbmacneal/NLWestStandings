using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Sport
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
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Abbreviation
        /// </summary>
        [DataMember(Name = "abbreviation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets DeviceProperties
        /// </summary>
        [DataMember(Name = "deviceProperties", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deviceProperties")]
        public JsonNode DeviceProperties { get; set; }

        /// <summary>
        /// Gets or Sets RuleSettings
        /// </summary>
        [DataMember(Name = "ruleSettings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ruleSettings")]
        public List<RuleSettings> RuleSettings { get; set; }

        /// <summary>
        /// Gets or Sets SeasonState
        /// </summary>
        [DataMember(Name = "seasonState", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seasonState")]
        public string SeasonState { get; set; }

        /// <summary>
        /// Gets or Sets SeasonDateInfo
        /// </summary>
        [DataMember(Name = "seasonDateInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seasonDateInfo")]
        public Season SeasonDateInfo { get; set; }

        /// <summary>
        /// Gets or Sets HydratedRuleSettings
        /// </summary>
        [DataMember(Name = "hydratedRuleSettings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedRuleSettings")]
        public Dictionary<string, Object> HydratedRuleSettings { get; set; }

        /// <summary>
        /// Gets or Sets HydratedSeason
        /// </summary>
        [DataMember(Name = "hydratedSeason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedSeason")]
        public Dictionary<string, Object> HydratedSeason { get; set; }

        /// <summary>
        /// Gets or Sets ActiveStatus
        /// </summary>
        [DataMember(Name = "activeStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "activeStatus")]
        public string ActiveStatus { get; set; }

        /// <summary>
        /// Gets or Sets Affiliated
        /// </summary>
        [DataMember(Name = "affiliated", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "affiliated")]
        public bool? Affiliated { get; set; }

        /// <summary>
        /// Gets or Sets SportActive
        /// </summary>
        [DataMember(Name = "sportActive", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sportActive")]
        public bool? SportActive { get; set; }

        /// <summary>
        /// Gets or Sets HydratedDeviceProperties
        /// </summary>
        [DataMember(Name = "hydratedDeviceProperties", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedDeviceProperties")]
        public Dictionary<string, Object> HydratedDeviceProperties { get; set; }

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
            sb.Append("class Sport {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  DeviceProperties: ").Append(DeviceProperties).Append("\n");
            sb.Append("  RuleSettings: ").Append(RuleSettings).Append("\n");
            sb.Append("  SeasonState: ").Append(SeasonState).Append("\n");
            sb.Append("  SeasonDateInfo: ").Append(SeasonDateInfo).Append("\n");
            sb.Append("  HydratedRuleSettings: ").Append(HydratedRuleSettings).Append("\n");
            sb.Append("  HydratedSeason: ").Append(HydratedSeason).Append("\n");
            sb.Append("  ActiveStatus: ").Append(ActiveStatus).Append("\n");
            sb.Append("  Affiliated: ").Append(Affiliated).Append("\n");
            sb.Append("  SportActive: ").Append(SportActive).Append("\n");
            sb.Append("  HydratedDeviceProperties: ").Append(HydratedDeviceProperties).Append("\n");
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