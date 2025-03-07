using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class MilestoneAchievementType
    {
        /// <summary>
        /// Gets or Sets AchievementTypeId
        /// </summary>
        [DataMember(Name = "achievementTypeId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "achievementTypeId")]
        public int? AchievementTypeId { get; set; }

        /// <summary>
        /// Gets or Sets AchievementTypeCode
        /// </summary>
        [DataMember(Name = "achievementTypeCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "achievementTypeCode")]
        public string AchievementTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets AchievementTypeDesc
        /// </summary>
        [DataMember(Name = "achievementTypeDesc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "achievementTypeDesc")]
        public string AchievementTypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets AchievementTypeText
        /// </summary>
        [DataMember(Name = "achievementTypeText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "achievementTypeText")]
        public string AchievementTypeText { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MilestoneAchievementType {\n");
            sb.Append("  AchievementTypeId: ").Append(AchievementTypeId).Append("\n");
            sb.Append("  AchievementTypeCode: ").Append(AchievementTypeCode).Append("\n");
            sb.Append("  AchievementTypeDesc: ").Append(AchievementTypeDesc).Append("\n");
            sb.Append("  AchievementTypeText: ").Append(AchievementTypeText).Append("\n");
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