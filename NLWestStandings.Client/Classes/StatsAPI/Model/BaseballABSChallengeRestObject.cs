using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballABSChallengeRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets HasChallenges
        /// </summary>
        [DataMember(Name = "hasChallenges", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasChallenges")]
        public bool? HasChallenges { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Away
        /// </summary>
        [DataMember(Name = "away", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "away")]
        public BaseballTeamReview Away { get; set; }

        /// <summary>
        /// Gets or Sets Home
        /// </summary>
        [DataMember(Name = "home", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "home")]
        public BaseballTeamReview Home { get; set; }

        /// <summary>
        /// Gets or Sets ChallengingTeam
        /// </summary>
        [DataMember(Name = "challengingTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "challengingTeam")]
        public BaseballTeamRestObject ChallengingTeam { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballABSChallengeRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  HasChallenges: ").Append(HasChallenges).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Away: ").Append(Away).Append("\n");
            sb.Append("  Home: ").Append(Home).Append("\n");
            sb.Append("  ChallengingTeam: ").Append(ChallengingTeam).Append("\n");
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