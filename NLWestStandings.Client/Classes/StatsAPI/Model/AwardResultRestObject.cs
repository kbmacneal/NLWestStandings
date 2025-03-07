using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class AwardResultRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Hydrations
        /// </summary>
        [DataMember(Name = "hydrations", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydrations")]
        public List<string> Hydrations { get; set; }

        /// <summary>
        /// Gets or Sets SeasonId
        /// </summary>
        [DataMember(Name = "seasonId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seasonId")]
        public int? SeasonId { get; set; }

        /// <summary>
        /// Gets or Sets Winners
        /// </summary>
        [DataMember(Name = "winners", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "winners")]
        public List<AwardWinnerRestObject> Winners { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AwardResultRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Hydrations: ").Append(Hydrations).Append("\n");
            sb.Append("  SeasonId: ").Append(SeasonId).Append("\n");
            sb.Append("  Winners: ").Append(Winners).Append("\n");
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