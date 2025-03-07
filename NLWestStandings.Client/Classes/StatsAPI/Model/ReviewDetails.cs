using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class ReviewDetails
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets IsOverturned
        /// </summary>
        [DataMember(Name = "isOverturned", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isOverturned")]
        public bool? IsOverturned { get; set; }

        /// <summary>
        /// Gets or Sets InProgress
        /// </summary>
        [DataMember(Name = "inProgress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inProgress")]
        public bool? InProgress { get; set; }

        /// <summary>
        /// Gets or Sets ReviewType
        /// </summary>
        [DataMember(Name = "reviewType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reviewType")]
        public string ReviewType { get; set; }

        /// <summary>
        /// Gets or Sets ChallengeTeamId
        /// </summary>
        [DataMember(Name = "challengeTeamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "challengeTeamId")]
        public int? ChallengeTeamId { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalReviews
        /// </summary>
        [DataMember(Name = "additionalReviews", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalReviews")]
        public List<ReviewDetails> AdditionalReviews { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReviewDetails {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  IsOverturned: ").Append(IsOverturned).Append("\n");
            sb.Append("  InProgress: ").Append(InProgress).Append("\n");
            sb.Append("  ReviewType: ").Append(ReviewType).Append("\n");
            sb.Append("  ChallengeTeamId: ").Append(ChallengeTeamId).Append("\n");
            sb.Append("  AdditionalReviews: ").Append(AdditionalReviews).Append("\n");
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