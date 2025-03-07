using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballChallenge
    {
        /// <summary>
        /// Gets or Sets HasChallenges
        /// </summary>
        [DataMember(Name = "hasChallenges", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasChallenges")]
        public bool? HasChallenges { get; set; }

        /// <summary>
        /// Gets or Sets AwayChallengesUsed
        /// </summary>
        [DataMember(Name = "awayChallengesUsed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayChallengesUsed")]
        public int? AwayChallengesUsed { get; set; }

        /// <summary>
        /// Gets or Sets AwayChallengesRemaining
        /// </summary>
        [DataMember(Name = "awayChallengesRemaining", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayChallengesRemaining")]
        public int? AwayChallengesRemaining { get; set; }

        /// <summary>
        /// Gets or Sets HomeChallengesUsed
        /// </summary>
        [DataMember(Name = "homeChallengesUsed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeChallengesUsed")]
        public int? HomeChallengesUsed { get; set; }

        /// <summary>
        /// Gets or Sets HomeChallengesRemaining
        /// </summary>
        [DataMember(Name = "homeChallengesRemaining", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeChallengesRemaining")]
        public int? HomeChallengesRemaining { get; set; }

        /// <summary>
        /// Gets or Sets ChallengingTeam
        /// </summary>
        [DataMember(Name = "challengingTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "challengingTeam")]
        public BaseballTeam ChallengingTeam { get; set; }

        /// <summary>
        /// Gets or Sets ReviewReason
        /// </summary>
        [DataMember(Name = "reviewReason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reviewReason")]
        public string ReviewReason { get; set; }

        /// <summary>
        /// Gets or Sets Limit9thInning
        /// </summary>
        [DataMember(Name = "limit9thInning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "limit9thInning")]
        public int? Limit9thInning { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballChallenge {\n");
            sb.Append("  HasChallenges: ").Append(HasChallenges).Append("\n");
            sb.Append("  AwayChallengesUsed: ").Append(AwayChallengesUsed).Append("\n");
            sb.Append("  AwayChallengesRemaining: ").Append(AwayChallengesRemaining).Append("\n");
            sb.Append("  HomeChallengesUsed: ").Append(HomeChallengesUsed).Append("\n");
            sb.Append("  HomeChallengesRemaining: ").Append(HomeChallengesRemaining).Append("\n");
            sb.Append("  ChallengingTeam: ").Append(ChallengingTeam).Append("\n");
            sb.Append("  ReviewReason: ").Append(ReviewReason).Append("\n");
            sb.Append("  Limit9thInning: ").Append(Limit9thInning).Append("\n");
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