using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class StandingsOdds
    {
        /// <summary>
        /// Gets or Sets WildcardOdds
        /// </summary>
        [DataMember(Name = "wildcardOdds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wildcardOdds")]
        public double? WildcardOdds { get; set; }

        /// <summary>
        /// Gets or Sets DivisionOdds
        /// </summary>
        [DataMember(Name = "divisionOdds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "divisionOdds")]
        public double? DivisionOdds { get; set; }

        /// <summary>
        /// Gets or Sets PlayoffOdds
        /// </summary>
        [DataMember(Name = "playoffOdds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playoffOdds")]
        public double? PlayoffOdds { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StandingsOdds {\n");
            sb.Append("  WildcardOdds: ").Append(WildcardOdds).Append("\n");
            sb.Append("  DivisionOdds: ").Append(DivisionOdds).Append("\n");
            sb.Append("  PlayoffOdds: ").Append(PlayoffOdds).Append("\n");
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