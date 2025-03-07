using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class GameTypeDates
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name = "shortName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or Sets RoundRobin
        /// </summary>
        [DataMember(Name = "roundRobin", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "roundRobin")]
        public bool? RoundRobin { get; set; }

        /// <summary>
        /// Gets or Sets Playoffs
        /// </summary>
        [DataMember(Name = "playoffs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playoffs")]
        public bool? Playoffs { get; set; }

        /// <summary>
        /// Gets or Sets PlayoffRound
        /// </summary>
        [DataMember(Name = "playoffRound", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playoffRound")]
        public int? PlayoffRound { get; set; }

        /// <summary>
        /// Gets or Sets League
        /// </summary>
        [DataMember(Name = "league", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "league")]
        public League League { get; set; }

        /// <summary>
        /// Gets or Sets Sport
        /// </summary>
        [DataMember(Name = "sport", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sport")]
        public Sport Sport { get; set; }

        /// <summary>
        /// Gets or Sets GameType
        /// </summary>
        [DataMember(Name = "gameType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameType")]
        public GameTypeEnum GameType { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameTypeDates {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  RoundRobin: ").Append(RoundRobin).Append("\n");
            sb.Append("  Playoffs: ").Append(Playoffs).Append("\n");
            sb.Append("  PlayoffRound: ").Append(PlayoffRound).Append("\n");
            sb.Append("  League: ").Append(League).Append("\n");
            sb.Append("  Sport: ").Append(Sport).Append("\n");
            sb.Append("  GameType: ").Append(GameType).Append("\n");
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