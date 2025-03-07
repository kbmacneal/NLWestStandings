using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballStatsTypeRestObject
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LookupParam
        /// </summary>
        [DataMember(Name = "lookupParam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lookupParam")]
        public string LookupParam { get; set; }

        /// <summary>
        /// Gets or Sets IsCounting
        /// </summary>
        [DataMember(Name = "isCounting", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isCounting")]
        public bool? IsCounting { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets StatGroups
        /// </summary>
        [DataMember(Name = "statGroups", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statGroups")]
        public List<StatGroup> StatGroups { get; set; }

        /// <summary>
        /// Gets or Sets OrgTypes
        /// </summary>
        [DataMember(Name = "orgTypes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orgTypes")]
        public List<OrganizationType> OrgTypes { get; set; }

        /// <summary>
        /// Gets or Sets HighLowTypes
        /// </summary>
        [DataMember(Name = "highLowTypes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "highLowTypes")]
        public List<HighLowTypeEnum> HighLowTypes { get; set; }

        /// <summary>
        /// Gets or Sets StreakLevels
        /// </summary>
        [DataMember(Name = "streakLevels", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "streakLevels")]
        public List<StreakLevelEnum> StreakLevels { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballStatsTypeRestObject {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LookupParam: ").Append(LookupParam).Append("\n");
            sb.Append("  IsCounting: ").Append(IsCounting).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  StatGroups: ").Append(StatGroups).Append("\n");
            sb.Append("  OrgTypes: ").Append(OrgTypes).Append("\n");
            sb.Append("  HighLowTypes: ").Append(HighLowTypes).Append("\n");
            sb.Append("  StreakLevels: ").Append(StreakLevels).Append("\n");
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