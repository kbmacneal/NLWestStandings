using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class TeamInfo
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeamRestObject Team { get; set; }

        /// <summary>
        /// Gets or Sets Runs
        /// </summary>
        [DataMember(Name = "runs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runs")]
        public int? Runs { get; set; }

        /// <summary>
        /// Gets or Sets Hits
        /// </summary>
        [DataMember(Name = "hits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hits")]
        public int? Hits { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errors")]
        public int? Errors { get; set; }

        /// <summary>
        /// Gets or Sets LeftOnBase
        /// </summary>
        [DataMember(Name = "leftOnBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leftOnBase")]
        public int? LeftOnBase { get; set; }

        /// <summary>
        /// Gets or Sets IsWinner
        /// </summary>
        [DataMember(Name = "isWinner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isWinner")]
        public bool? IsWinner { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamInfo {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Runs: ").Append(Runs).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  LeftOnBase: ").Append(LeftOnBase).Append("\n");
            sb.Append("  IsWinner: ").Append(IsWinner).Append("\n");
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