using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class HomeRunDerbyBatterHitRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets BonusTime
        /// </summary>
        [DataMember(Name = "bonusTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bonusTime")]
        public bool? BonusTime { get; set; }

        /// <summary>
        /// Gets or Sets TieBreaker
        /// </summary>
        [DataMember(Name = "tieBreaker", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tieBreaker")]
        public bool? TieBreaker { get; set; }

        /// <summary>
        /// Gets or Sets HomeRun
        /// </summary>
        [DataMember(Name = "homeRun", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeRun")]
        public bool? HomeRun { get; set; }

        /// <summary>
        /// Gets or Sets HitData
        /// </summary>
        [DataMember(Name = "hitData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitData")]
        public HitSegmentRestObject HitData { get; set; }

        /// <summary>
        /// Gets or Sets IsHomeRun
        /// </summary>
        [DataMember(Name = "isHomeRun", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isHomeRun")]
        public bool? IsHomeRun { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "time")]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Gets or Sets PlayId
        /// </summary>
        [DataMember(Name = "playId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playId")]
        public string PlayId { get; set; }

        /// <summary>
        /// Gets or Sets TimeRemaining
        /// </summary>
        [DataMember(Name = "timeRemaining", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeRemaining")]
        public string TimeRemaining { get; set; }

        /// <summary>
        /// Gets or Sets TimeRemainingSeconds
        /// </summary>
        [DataMember(Name = "timeRemainingSeconds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeRemainingSeconds")]
        public int? TimeRemainingSeconds { get; set; }

        /// <summary>
        /// Gets or Sets IsBonusTime
        /// </summary>
        [DataMember(Name = "isBonusTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isBonusTime")]
        public bool? IsBonusTime { get; set; }

        /// <summary>
        /// Gets or Sets BonusOutsCurrent
        /// </summary>
        [DataMember(Name = "bonusOutsCurrent", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bonusOutsCurrent")]
        public int? BonusOutsCurrent { get; set; }

        /// <summary>
        /// Gets or Sets BonusOutsTotal
        /// </summary>
        [DataMember(Name = "bonusOutsTotal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bonusOutsTotal")]
        public int? BonusOutsTotal { get; set; }

        /// <summary>
        /// Gets or Sets IsTieBreaker
        /// </summary>
        [DataMember(Name = "isTieBreaker", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isTieBreaker")]
        public bool? IsTieBreaker { get; set; }

        /// <summary>
        /// Gets or Sets TieBreakerNum
        /// </summary>
        [DataMember(Name = "tieBreakerNum", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tieBreakerNum")]
        public int? TieBreakerNum { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HomeRunDerbyBatterHitRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  BonusTime: ").Append(BonusTime).Append("\n");
            sb.Append("  TieBreaker: ").Append(TieBreaker).Append("\n");
            sb.Append("  HomeRun: ").Append(HomeRun).Append("\n");
            sb.Append("  HitData: ").Append(HitData).Append("\n");
            sb.Append("  IsHomeRun: ").Append(IsHomeRun).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  PlayId: ").Append(PlayId).Append("\n");
            sb.Append("  TimeRemaining: ").Append(TimeRemaining).Append("\n");
            sb.Append("  TimeRemainingSeconds: ").Append(TimeRemainingSeconds).Append("\n");
            sb.Append("  IsBonusTime: ").Append(IsBonusTime).Append("\n");
            sb.Append("  BonusOutsCurrent: ").Append(BonusOutsCurrent).Append("\n");
            sb.Append("  BonusOutsTotal: ").Append(BonusOutsTotal).Append("\n");
            sb.Append("  IsTieBreaker: ").Append(IsTieBreaker).Append("\n");
            sb.Append("  TieBreakerNum: ").Append(TieBreakerNum).Append("\n");
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