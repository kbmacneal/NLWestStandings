using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class MilestoneRuleRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneRuleId
        /// </summary>
        [DataMember(Name = "milestoneRuleId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestoneRuleId")]
        public int? MilestoneRuleId { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneValue
        /// </summary>
        [DataMember(Name = "milestoneValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestoneValue")]
        public int? MilestoneValue { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneRank
        /// </summary>
        [DataMember(Name = "milestoneRank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestoneRank")]
        public int? MilestoneRank { get; set; }

        /// <summary>
        /// Gets or Sets GameTypeCode
        /// </summary>
        [DataMember(Name = "gameTypeCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameTypeCode")]
        public string GameTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets OrgType
        /// </summary>
        [DataMember(Name = "orgType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orgType")]
        public OrganizationTypeRestObject OrgType { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneType
        /// </summary>
        [DataMember(Name = "milestoneType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestoneType")]
        public MilestoneTypeRestObject MilestoneType { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneDuration
        /// </summary>
        [DataMember(Name = "milestoneDuration", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestoneDuration")]
        public MilestoneDurationRestObject MilestoneDuration { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneStatistic
        /// </summary>
        [DataMember(Name = "milestoneStatistic", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestoneStatistic")]
        public MilestoneStatisticRestObject MilestoneStatistic { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MilestoneRuleRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  MilestoneRuleId: ").Append(MilestoneRuleId).Append("\n");
            sb.Append("  MilestoneValue: ").Append(MilestoneValue).Append("\n");
            sb.Append("  MilestoneRank: ").Append(MilestoneRank).Append("\n");
            sb.Append("  GameTypeCode: ").Append(GameTypeCode).Append("\n");
            sb.Append("  OrgType: ").Append(OrgType).Append("\n");
            sb.Append("  MilestoneType: ").Append(MilestoneType).Append("\n");
            sb.Append("  MilestoneDuration: ").Append(MilestoneDuration).Append("\n");
            sb.Append("  MilestoneStatistic: ").Append(MilestoneStatistic).Append("\n");
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