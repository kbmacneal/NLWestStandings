using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballGameContextRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Game
        /// </summary>
        [DataMember(Name = "game", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "game")]
        public BaseballScheduleItemRestObject Game { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedStatisticsData
        /// </summary>
        [DataMember(Name = "expectedStatisticsData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expectedStatisticsData")]
        public StatDataRestObject ExpectedStatisticsData { get; set; }

        /// <summary>
        /// Gets or Sets RunnerOnThird
        /// </summary>
        [DataMember(Name = "runnerOnThird", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerOnThird")]
        public BaseballPersonRestObject RunnerOnThird { get; set; }

        /// <summary>
        /// Gets or Sets LeftFieldSacFlyProbability
        /// </summary>
        [DataMember(Name = "leftFieldSacFlyProbability", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leftFieldSacFlyProbability")]
        public SacFlyProbability LeftFieldSacFlyProbability { get; set; }

        /// <summary>
        /// Gets or Sets CenterFieldSacFlyProbability
        /// </summary>
        [DataMember(Name = "centerFieldSacFlyProbability", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "centerFieldSacFlyProbability")]
        public SacFlyProbability CenterFieldSacFlyProbability { get; set; }

        /// <summary>
        /// Gets or Sets RightFieldSacFlyProbability
        /// </summary>
        [DataMember(Name = "rightFieldSacFlyProbability", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rightFieldSacFlyProbability")]
        public SacFlyProbability RightFieldSacFlyProbability { get; set; }

        /// <summary>
        /// Gets or Sets AwayWinProbability
        /// </summary>
        [DataMember(Name = "awayWinProbability", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayWinProbability")]
        public double? AwayWinProbability { get; set; }

        /// <summary>
        /// Gets or Sets HomeWinProbability
        /// </summary>
        [DataMember(Name = "homeWinProbability", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeWinProbability")]
        public double? HomeWinProbability { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballGameContextRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Game: ").Append(Game).Append("\n");
            sb.Append("  ExpectedStatisticsData: ").Append(ExpectedStatisticsData).Append("\n");
            sb.Append("  RunnerOnThird: ").Append(RunnerOnThird).Append("\n");
            sb.Append("  LeftFieldSacFlyProbability: ").Append(LeftFieldSacFlyProbability).Append("\n");
            sb.Append("  CenterFieldSacFlyProbability: ").Append(CenterFieldSacFlyProbability).Append("\n");
            sb.Append("  RightFieldSacFlyProbability: ").Append(RightFieldSacFlyProbability).Append("\n");
            sb.Append("  AwayWinProbability: ").Append(AwayWinProbability).Append("\n");
            sb.Append("  HomeWinProbability: ").Append(HomeWinProbability).Append("\n");
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