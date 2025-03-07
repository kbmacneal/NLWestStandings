using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballTeamReview
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets UsedSuccessful
        /// </summary>
        [DataMember(Name = "usedSuccessful", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "usedSuccessful")]
        public int? UsedSuccessful { get; set; }

        /// <summary>
        /// Gets or Sets UsedFailed
        /// </summary>
        [DataMember(Name = "usedFailed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "usedFailed")]
        public int? UsedFailed { get; set; }

        /// <summary>
        /// Gets or Sets Remaining
        /// </summary>
        [DataMember(Name = "remaining", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "remaining")]
        public int? Remaining { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballTeamReview {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  UsedSuccessful: ").Append(UsedSuccessful).Append("\n");
            sb.Append("  UsedFailed: ").Append(UsedFailed).Append("\n");
            sb.Append("  Remaining: ").Append(Remaining).Append("\n");
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