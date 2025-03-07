using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballScheduleItemTeamRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets LeagueRecord
        /// </summary>
        [DataMember(Name = "leagueRecord", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leagueRecord")]
        public WinLossRecordRestObject LeagueRecord { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "score")]
        public int? Score { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeamRestObject Team { get; set; }

        /// <summary>
        /// Gets or Sets IsWinner
        /// </summary>
        [DataMember(Name = "isWinner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isWinner")]
        public bool? IsWinner { get; set; }

        /// <summary>
        /// Gets or Sets ProbablePitcher
        /// </summary>
        [DataMember(Name = "probablePitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "probablePitcher")]
        public BaseballPersonRestObject ProbablePitcher { get; set; }

        /// <summary>
        /// Gets or Sets SplitSquad
        /// </summary>
        [DataMember(Name = "splitSquad", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "splitSquad")]
        public bool? SplitSquad { get; set; }

        /// <summary>
        /// Gets or Sets SeriesNumber
        /// </summary>
        [DataMember(Name = "seriesNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seriesNumber")]
        public int? SeriesNumber { get; set; }

        /// <summary>
        /// Gets or Sets SeedNumber
        /// </summary>
        [DataMember(Name = "seedNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seedNumber")]
        public int? SeedNumber { get; set; }

        /// <summary>
        /// Gets or Sets SpringLeague
        /// </summary>
        [DataMember(Name = "springLeague", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "springLeague")]
        public LeagueRestObject SpringLeague { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballScheduleItemTeamRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  LeagueRecord: ").Append(LeagueRecord).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  IsWinner: ").Append(IsWinner).Append("\n");
            sb.Append("  ProbablePitcher: ").Append(ProbablePitcher).Append("\n");
            sb.Append("  SplitSquad: ").Append(SplitSquad).Append("\n");
            sb.Append("  SeriesNumber: ").Append(SeriesNumber).Append("\n");
            sb.Append("  SeedNumber: ").Append(SeedNumber).Append("\n");
            sb.Append("  SpringLeague: ").Append(SpringLeague).Append("\n");
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