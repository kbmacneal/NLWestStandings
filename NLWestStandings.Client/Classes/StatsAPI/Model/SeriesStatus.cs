using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SeriesStatus
    {
        /// <summary>
        /// Gets or Sets GameNumber
        /// </summary>
        [DataMember(Name = "gameNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameNumber")]
        public int? GameNumber { get; set; }

        /// <summary>
        /// Gets or Sets TotalGames
        /// </summary>
        [DataMember(Name = "totalGames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalGames")]
        public int? TotalGames { get; set; }

        /// <summary>
        /// Gets or Sets WinningTeam
        /// </summary>
        [DataMember(Name = "winningTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "winningTeam")]
        public BaseballTeam WinningTeam { get; set; }

        /// <summary>
        /// Gets or Sets LosingTeam
        /// </summary>
        [DataMember(Name = "losingTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "losingTeam")]
        public BaseballTeam LosingTeam { get; set; }

        /// <summary>
        /// Gets or Sets IsTied
        /// </summary>
        [DataMember(Name = "isTied", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isTied")]
        public bool? IsTied { get; set; }

        /// <summary>
        /// Gets or Sets IsOver
        /// </summary>
        [DataMember(Name = "isOver", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isOver")]
        public bool? IsOver { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

        /// <summary>
        /// Gets or Sets Ties
        /// </summary>
        [DataMember(Name = "ties", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ties")]
        public int? Ties { get; set; }

        /// <summary>
        /// Gets or Sets Wins
        /// </summary>
        [DataMember(Name = "wins", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wins")]
        public int? Wins { get; set; }

        /// <summary>
        /// Gets or Sets Losses
        /// </summary>
        [DataMember(Name = "losses", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "losses")]
        public int? Losses { get; set; }

        /// <summary>
        /// Gets or Sets GameType
        /// </summary>
        [DataMember(Name = "gameType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameType")]
        public GameTypeEnum GameType { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ShortDescription
        /// </summary>
        [DataMember(Name = "shortDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shortDescription")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or Sets SeriesHomeNumber
        /// </summary>
        [DataMember(Name = "seriesHomeNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seriesHomeNumber")]
        public int? SeriesHomeNumber { get; set; }

        /// <summary>
        /// Gets or Sets SeriesAwayNumber
        /// </summary>
        [DataMember(Name = "seriesAwayNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seriesAwayNumber")]
        public int? SeriesAwayNumber { get; set; }

        /// <summary>
        /// Gets or Sets SeriesId
        /// </summary>
        [DataMember(Name = "seriesId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seriesId")]
        public string SeriesId { get; set; }

        /// <summary>
        /// Gets or Sets SeriesName
        /// </summary>
        [DataMember(Name = "seriesName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seriesName")]
        public string SeriesName { get; set; }

        /// <summary>
        /// Gets or Sets SeriesAbbreviation
        /// </summary>
        [DataMember(Name = "seriesAbbreviation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seriesAbbreviation")]
        public string SeriesAbbreviation { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SeriesStatus {\n");
            sb.Append("  GameNumber: ").Append(GameNumber).Append("\n");
            sb.Append("  TotalGames: ").Append(TotalGames).Append("\n");
            sb.Append("  WinningTeam: ").Append(WinningTeam).Append("\n");
            sb.Append("  LosingTeam: ").Append(LosingTeam).Append("\n");
            sb.Append("  IsTied: ").Append(IsTied).Append("\n");
            sb.Append("  IsOver: ").Append(IsOver).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Ties: ").Append(Ties).Append("\n");
            sb.Append("  Wins: ").Append(Wins).Append("\n");
            sb.Append("  Losses: ").Append(Losses).Append("\n");
            sb.Append("  GameType: ").Append(GameType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  SeriesHomeNumber: ").Append(SeriesHomeNumber).Append("\n");
            sb.Append("  SeriesAwayNumber: ").Append(SeriesAwayNumber).Append("\n");
            sb.Append("  SeriesId: ").Append(SeriesId).Append("\n");
            sb.Append("  SeriesName: ").Append(SeriesName).Append("\n");
            sb.Append("  SeriesAbbreviation: ").Append(SeriesAbbreviation).Append("\n");
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