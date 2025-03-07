using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PlayerDraftInfoRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "year")]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or Sets Round
        /// </summary>
        [DataMember(Name = "round", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "round")]
        public string Round { get; set; }

        /// <summary>
        /// Gets or Sets PickOverall
        /// </summary>
        [DataMember(Name = "pickOverall", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pickOverall")]
        public int? PickOverall { get; set; }

        /// <summary>
        /// Gets or Sets PickInRound
        /// </summary>
        [DataMember(Name = "pickInRound", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pickInRound")]
        public int? PickInRound { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeamRestObject Team { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayerDraftInfoRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Round: ").Append(Round).Append("\n");
            sb.Append("  PickOverall: ").Append(PickOverall).Append("\n");
            sb.Append("  PickInRound: ").Append(PickInRound).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
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