using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class MilestoneRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneAchievementId
        /// </summary>
        [DataMember(Name = "milestoneAchievementId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestoneAchievementId")]
        public int? MilestoneAchievementId { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneProjectionId
        /// </summary>
        [DataMember(Name = "milestoneProjectionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestoneProjectionId")]
        public int? MilestoneProjectionId { get; set; }

        /// <summary>
        /// Gets or Sets ProjectionValue
        /// </summary>
        [DataMember(Name = "projectionValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "projectionValue")]
        public int? ProjectionValue { get; set; }

        /// <summary>
        /// Gets or Sets ProjectionRank
        /// </summary>
        [DataMember(Name = "projectionRank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "projectionRank")]
        public int? ProjectionRank { get; set; }

        /// <summary>
        /// Gets or Sets CurrentValue
        /// </summary>
        [DataMember(Name = "currentValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentValue")]
        public int? CurrentValue { get; set; }

        /// <summary>
        /// Gets or Sets AchievementValue
        /// </summary>
        [DataMember(Name = "achievementValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "achievementValue")]
        public int? AchievementValue { get; set; }

        /// <summary>
        /// Gets or Sets AchievementRank
        /// </summary>
        [DataMember(Name = "achievementRank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "achievementRank")]
        public int? AchievementRank { get; set; }

        /// <summary>
        /// Gets or Sets AchievementDate
        /// </summary>
        [DataMember(Name = "achievementDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "achievementDate")]
        public DateTime? AchievementDate { get; set; }

        /// <summary>
        /// Gets or Sets IsLastAchievementStatus
        /// </summary>
        [DataMember(Name = "isLastAchievementStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isLastAchievementStatus")]
        public bool? IsLastAchievementStatus { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name = "gameId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameId")]
        public int? GameId { get; set; }

        /// <summary>
        /// Gets or Sets PlayId
        /// </summary>
        [DataMember(Name = "playId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playId")]
        public string PlayId { get; set; }

        /// <summary>
        /// Gets or Sets AtBatNumber
        /// </summary>
        [DataMember(Name = "atBatNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "atBatNumber")]
        public int? AtBatNumber { get; set; }

        /// <summary>
        /// Gets or Sets PitchNumber
        /// </summary>
        [DataMember(Name = "pitchNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchNumber")]
        public int? PitchNumber { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "player")]
        public BaseballPersonRestObject Player { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeamRestObject Team { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "organizationId")]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets AchievementStatus
        /// </summary>
        [DataMember(Name = "achievementStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "achievementStatus")]
        public MilestoneAchievementStatusRestObject AchievementStatus { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneRule
        /// </summary>
        [DataMember(Name = "milestoneRule", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestoneRule")]
        public MilestoneRuleRestObject MilestoneRule { get; set; }

        /// <summary>
        /// Gets or Sets RuleCount
        /// </summary>
        [DataMember(Name = "ruleCount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ruleCount")]
        public int? RuleCount { get; set; }

        /// <summary>
        /// Gets or Sets StatDifference
        /// </summary>
        [DataMember(Name = "statDifference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statDifference")]
        public int? StatDifference { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MilestoneRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  MilestoneAchievementId: ").Append(MilestoneAchievementId).Append("\n");
            sb.Append("  MilestoneProjectionId: ").Append(MilestoneProjectionId).Append("\n");
            sb.Append("  ProjectionValue: ").Append(ProjectionValue).Append("\n");
            sb.Append("  ProjectionRank: ").Append(ProjectionRank).Append("\n");
            sb.Append("  CurrentValue: ").Append(CurrentValue).Append("\n");
            sb.Append("  AchievementValue: ").Append(AchievementValue).Append("\n");
            sb.Append("  AchievementRank: ").Append(AchievementRank).Append("\n");
            sb.Append("  AchievementDate: ").Append(AchievementDate).Append("\n");
            sb.Append("  IsLastAchievementStatus: ").Append(IsLastAchievementStatus).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  PlayId: ").Append(PlayId).Append("\n");
            sb.Append("  AtBatNumber: ").Append(AtBatNumber).Append("\n");
            sb.Append("  PitchNumber: ").Append(PitchNumber).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  AchievementStatus: ").Append(AchievementStatus).Append("\n");
            sb.Append("  MilestoneRule: ").Append(MilestoneRule).Append("\n");
            sb.Append("  RuleCount: ").Append(RuleCount).Append("\n");
            sb.Append("  StatDifference: ").Append(StatDifference).Append("\n");
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