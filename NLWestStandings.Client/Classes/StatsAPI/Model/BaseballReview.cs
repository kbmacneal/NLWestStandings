using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballReview
    {
        /// <summary>
        /// Gets or Sets ReviewType
        /// </summary>
        [DataMember(Name = "reviewType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reviewType")]
        public string ReviewType { get; set; }

        /// <summary>
        /// Gets or Sets ReviewOverturned
        /// </summary>
        [DataMember(Name = "reviewOverturned", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reviewOverturned")]
        public bool? ReviewOverturned { get; set; }

        /// <summary>
        /// Gets or Sets ChallengeTeamId
        /// </summary>
        [DataMember(Name = "challengeTeamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "challengeTeamId")]
        public int? ChallengeTeamId { get; set; }

        /// <summary>
        /// Gets or Sets ReviewInProgress
        /// </summary>
        [DataMember(Name = "reviewInProgress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reviewInProgress")]
        public bool? ReviewInProgress { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballReview {\n");
            sb.Append("  ReviewType: ").Append(ReviewType).Append("\n");
            sb.Append("  ReviewOverturned: ").Append(ReviewOverturned).Append("\n");
            sb.Append("  ChallengeTeamId: ").Append(ChallengeTeamId).Append("\n");
            sb.Append("  ReviewInProgress: ").Append(ReviewInProgress).Append("\n");
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