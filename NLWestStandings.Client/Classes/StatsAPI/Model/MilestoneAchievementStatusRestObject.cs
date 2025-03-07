using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class MilestoneAchievementStatusRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets AchievementStatusId
        /// </summary>
        [DataMember(Name = "achievementStatusId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "achievementStatusId")]
        public int? AchievementStatusId { get; set; }

        /// <summary>
        /// Gets or Sets AchievementStatusCode
        /// </summary>
        [DataMember(Name = "achievementStatusCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "achievementStatusCode")]
        public string AchievementStatusCode { get; set; }

        /// <summary>
        /// Gets or Sets AchievementStatusDesc
        /// </summary>
        [DataMember(Name = "achievementStatusDesc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "achievementStatusDesc")]
        public string AchievementStatusDesc { get; set; }

        /// <summary>
        /// Gets or Sets AchievementStatusText
        /// </summary>
        [DataMember(Name = "achievementStatusText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "achievementStatusText")]
        public string AchievementStatusText { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MilestoneAchievementStatusRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  AchievementStatusId: ").Append(AchievementStatusId).Append("\n");
            sb.Append("  AchievementStatusCode: ").Append(AchievementStatusCode).Append("\n");
            sb.Append("  AchievementStatusDesc: ").Append(AchievementStatusDesc).Append("\n");
            sb.Append("  AchievementStatusText: ").Append(AchievementStatusText).Append("\n");
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