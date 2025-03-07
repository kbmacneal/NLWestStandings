using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballDraftRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets DraftYear
        /// </summary>
        [DataMember(Name = "draftYear", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "draftYear")]
        public int? DraftYear { get; set; }

        /// <summary>
        /// Gets or Sets Rounds
        /// </summary>
        [DataMember(Name = "rounds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rounds")]
        public List<BaseballDraftRoundRestObject> Rounds { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballDraftRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  DraftYear: ").Append(DraftYear).Append("\n");
            sb.Append("  Rounds: ").Append(Rounds).Append("\n");
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