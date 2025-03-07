using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballGameLiveDataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Plays
        /// </summary>
        [DataMember(Name = "plays", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "plays")]
        public BaseballPlayByPlayRestObject Plays { get; set; }

        /// <summary>
        /// Gets or Sets Linescore
        /// </summary>
        [DataMember(Name = "linescore", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "linescore")]
        public BaseballLinescoreRestObject Linescore { get; set; }

        /// <summary>
        /// Gets or Sets Boxscore
        /// </summary>
        [DataMember(Name = "boxscore", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "boxscore")]
        public BaseballBoxscoreRestObject Boxscore { get; set; }

        /// <summary>
        /// Gets or Sets Decisions
        /// </summary>
        [DataMember(Name = "decisions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "decisions")]
        public BaseballDecisionRestObject Decisions { get; set; }

        /// <summary>
        /// Gets or Sets Leaders
        /// </summary>
        [DataMember(Name = "leaders", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leaders")]
        public BaseballGameLeadersRestObject Leaders { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballGameLiveDataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Plays: ").Append(Plays).Append("\n");
            sb.Append("  Linescore: ").Append(Linescore).Append("\n");
            sb.Append("  Boxscore: ").Append(Boxscore).Append("\n");
            sb.Append("  Decisions: ").Append(Decisions).Append("\n");
            sb.Append("  Leaders: ").Append(Leaders).Append("\n");
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