using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballPlayerGameScoreRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "player")]
        public BaseballRosterEntryRestObject Player { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets GameScore
        /// </summary>
        [DataMember(Name = "gameScore", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameScore")]
        public int? GameScore { get; set; }

        /// <summary>
        /// Gets or Sets PitchingGameScore
        /// </summary>
        [DataMember(Name = "pitchingGameScore", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchingGameScore")]
        public int? PitchingGameScore { get; set; }

        /// <summary>
        /// Gets or Sets HittingGameScore
        /// </summary>
        [DataMember(Name = "hittingGameScore", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hittingGameScore")]
        public int? HittingGameScore { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballPlayerGameScoreRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  GameScore: ").Append(GameScore).Append("\n");
            sb.Append("  PitchingGameScore: ").Append(PitchingGameScore).Append("\n");
            sb.Append("  HittingGameScore: ").Append(HittingGameScore).Append("\n");
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