using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballStats
    {
        /// <summary>
        /// Gets or Sets AllStats
        /// </summary>
        [DataMember(Name = "allStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "allStats")]
        public List<StatContainer> AllStats { get; set; }

        /// <summary>
        /// Gets or Sets BattingStats
        /// </summary>
        [DataMember(Name = "battingStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "battingStats")]
        public BattingData BattingStats { get; set; }

        /// <summary>
        /// Gets or Sets PitchingStats
        /// </summary>
        [DataMember(Name = "pitchingStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchingStats")]
        public PitchingData PitchingStats { get; set; }

        /// <summary>
        /// Gets or Sets FieldingStats
        /// </summary>
        [DataMember(Name = "fieldingStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fieldingStats")]
        public FieldingData FieldingStats { get; set; }

        /// <summary>
        /// Gets or Sets GameStats
        /// </summary>
        [DataMember(Name = "gameStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameStats")]
        public GameStatData GameStats { get; set; }

        /// <summary>
        /// Gets or Sets TeamStats
        /// </summary>
        [DataMember(Name = "teamStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamStats")]
        public TeamStatData TeamStats { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballStats {\n");
            sb.Append("  AllStats: ").Append(AllStats).Append("\n");
            sb.Append("  BattingStats: ").Append(BattingStats).Append("\n");
            sb.Append("  PitchingStats: ").Append(PitchingStats).Append("\n");
            sb.Append("  FieldingStats: ").Append(FieldingStats).Append("\n");
            sb.Append("  GameStats: ").Append(GameStats).Append("\n");
            sb.Append("  TeamStats: ").Append(TeamStats).Append("\n");
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