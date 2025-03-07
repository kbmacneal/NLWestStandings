using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class HomeRunDerbyStatusRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets RegulationRoundLenth
        /// </summary>
        [DataMember(Name = "regulationRoundLenth", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "regulationRoundLenth")]
        public string RegulationRoundLenth { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets CurrentRound
        /// </summary>
        [DataMember(Name = "currentRound", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentRound")]
        public int? CurrentRound { get; set; }

        /// <summary>
        /// Gets or Sets CurrentRoundInProgress
        /// </summary>
        [DataMember(Name = "currentRoundInProgress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentRoundInProgress")]
        public bool? CurrentRoundInProgress { get; set; }

        /// <summary>
        /// Gets or Sets CurrentRoundTimeLeft
        /// </summary>
        [DataMember(Name = "currentRoundTimeLeft", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentRoundTimeLeft")]
        public string CurrentRoundTimeLeft { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledRounds
        /// </summary>
        [DataMember(Name = "scheduledRounds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scheduledRounds")]
        public int? ScheduledRounds { get; set; }

        /// <summary>
        /// Gets or Sets InTieBreaker
        /// </summary>
        [DataMember(Name = "inTieBreaker", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inTieBreaker")]
        public bool? InTieBreaker { get; set; }

        /// <summary>
        /// Gets or Sets TieBreakerNum
        /// </summary>
        [DataMember(Name = "tieBreakerNum", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tieBreakerNum")]
        public int? TieBreakerNum { get; set; }

        /// <summary>
        /// Gets or Sets CurrentBatter
        /// </summary>
        [DataMember(Name = "currentBatter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentBatter")]
        public BaseballPersonRestObject CurrentBatter { get; set; }

        /// <summary>
        /// Gets or Sets ClockStopped
        /// </summary>
        [DataMember(Name = "clockStopped", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "clockStopped")]
        public bool? ClockStopped { get; set; }

        /// <summary>
        /// Gets or Sets BonusTime
        /// </summary>
        [DataMember(Name = "bonusTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bonusTime")]
        public bool? BonusTime { get; set; }

        /// <summary>
        /// Gets or Sets RegulationRoundLength
        /// </summary>
        [DataMember(Name = "regulationRoundLength", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "regulationRoundLength")]
        public string RegulationRoundLength { get; set; }

        /// <summary>
        /// Gets or Sets BonusDistanceNeededPerRound
        /// </summary>
        [DataMember(Name = "bonusDistanceNeededPerRound", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bonusDistanceNeededPerRound")]
        public int? BonusDistanceNeededPerRound { get; set; }

        /// <summary>
        /// Gets or Sets BonusCountNeededPerRound
        /// </summary>
        [DataMember(Name = "bonusCountNeededPerRound", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bonusCountNeededPerRound")]
        public int? BonusCountNeededPerRound { get; set; }

        /// <summary>
        /// Gets or Sets PitchesInRound
        /// </summary>
        [DataMember(Name = "pitchesInRound", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchesInRound")]
        public int? PitchesInRound { get; set; }

        /// <summary>
        /// Gets or Sets PitchesRemaining
        /// </summary>
        [DataMember(Name = "pitchesRemaining", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchesRemaining")]
        public int? PitchesRemaining { get; set; }

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
        /// Gets or Sets BonusTypeOuts
        /// </summary>
        [DataMember(Name = "bonusTypeOuts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bonusTypeOuts")]
        public bool? BonusTypeOuts { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HomeRunDerbyStatusRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  RegulationRoundLenth: ").Append(RegulationRoundLenth).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CurrentRound: ").Append(CurrentRound).Append("\n");
            sb.Append("  CurrentRoundInProgress: ").Append(CurrentRoundInProgress).Append("\n");
            sb.Append("  CurrentRoundTimeLeft: ").Append(CurrentRoundTimeLeft).Append("\n");
            sb.Append("  ScheduledRounds: ").Append(ScheduledRounds).Append("\n");
            sb.Append("  InTieBreaker: ").Append(InTieBreaker).Append("\n");
            sb.Append("  TieBreakerNum: ").Append(TieBreakerNum).Append("\n");
            sb.Append("  CurrentBatter: ").Append(CurrentBatter).Append("\n");
            sb.Append("  ClockStopped: ").Append(ClockStopped).Append("\n");
            sb.Append("  BonusTime: ").Append(BonusTime).Append("\n");
            sb.Append("  RegulationRoundLength: ").Append(RegulationRoundLength).Append("\n");
            sb.Append("  BonusDistanceNeededPerRound: ").Append(BonusDistanceNeededPerRound).Append("\n");
            sb.Append("  BonusCountNeededPerRound: ").Append(BonusCountNeededPerRound).Append("\n");
            sb.Append("  PitchesInRound: ").Append(PitchesInRound).Append("\n");
            sb.Append("  PitchesRemaining: ").Append(PitchesRemaining).Append("\n");
            sb.Append("  BonusOutsCurrent: ").Append(BonusOutsCurrent).Append("\n");
            sb.Append("  BonusOutsTotal: ").Append(BonusOutsTotal).Append("\n");
            sb.Append("  BonusTypeOuts: ").Append(BonusTypeOuts).Append("\n");
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