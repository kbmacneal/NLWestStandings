using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballRunnerMovement
    {
        /// <summary>
        /// Gets or Sets StartBase
        /// </summary>
        [DataMember(Name = "startBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startBase")]
        public string StartBase { get; set; }

        /// <summary>
        /// Gets or Sets EndBase
        /// </summary>
        [DataMember(Name = "endBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endBase")]
        public string EndBase { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventType")]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or Sets EventTypeEnum
        /// </summary>
        [DataMember(Name = "eventTypeEnum", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventTypeEnum")]
        public EventType EventTypeEnum { get; set; }

        /// <summary>
        /// Gets or Sets Runner
        /// </summary>
        [DataMember(Name = "runner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runner")]
        public BaseballPerson Runner { get; set; }

        /// <summary>
        /// Gets or Sets ResponsiblePitcher
        /// </summary>
        [DataMember(Name = "responsiblePitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "responsiblePitcher")]
        public BaseballPerson ResponsiblePitcher { get; set; }

        /// <summary>
        /// Gets or Sets IsScoringEvent
        /// </summary>
        [DataMember(Name = "isScoringEvent", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isScoringEvent")]
        public bool? IsScoringEvent { get; set; }

        /// <summary>
        /// Gets or Sets IsRbi
        /// </summary>
        [DataMember(Name = "isRbi", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isRbi")]
        public bool? IsRbi { get; set; }

        /// <summary>
        /// Gets or Sets IsEarned
        /// </summary>
        [DataMember(Name = "isEarned", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isEarned")]
        public bool? IsEarned { get; set; }

        /// <summary>
        /// Gets or Sets PlayIndex
        /// </summary>
        [DataMember(Name = "playIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playIndex")]
        public int? PlayIndex { get; set; }

        /// <summary>
        /// Gets or Sets Sequence
        /// </summary>
        [DataMember(Name = "sequence", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sequence")]
        public int? Sequence { get; set; }

        /// <summary>
        /// Gets or Sets OutNumber
        /// </summary>
        [DataMember(Name = "outNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outNumber")]
        public int? OutNumber { get; set; }

        /// <summary>
        /// Gets or Sets OutBase
        /// </summary>
        [DataMember(Name = "outBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outBase")]
        public string OutBase { get; set; }

        /// <summary>
        /// Gets or Sets MovementReason
        /// </summary>
        [DataMember(Name = "movementReason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "movementReason")]
        public string MovementReason { get; set; }

        /// <summary>
        /// Gets or Sets MovementReasonEnum
        /// </summary>
        [DataMember(Name = "movementReasonEnum", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "movementReasonEnum")]
        public RunnerDetailType MovementReasonEnum { get; set; }

        /// <summary>
        /// Gets or Sets Credits
        /// </summary>
        [DataMember(Name = "credits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "credits")]
        public List<PlayCredit> Credits { get; set; }

        /// <summary>
        /// Gets or Sets OriginBase
        /// </summary>
        [DataMember(Name = "originBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "originBase")]
        public int? OriginBase { get; set; }

        /// <summary>
        /// Gets or Sets StartBaseInt
        /// </summary>
        [DataMember(Name = "startBaseInt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startBaseInt")]
        public int? StartBaseInt { get; set; }

        /// <summary>
        /// Gets or Sets EndBaseInt
        /// </summary>
        [DataMember(Name = "endBaseInt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endBaseInt")]
        public int? EndBaseInt { get; set; }

        /// <summary>
        /// Gets or Sets _Out
        /// </summary>
        [DataMember(Name = "out", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "out")]
        public bool? _Out { get; set; }

        /// <summary>
        /// Gets or Sets ScoringEvent
        /// </summary>
        [DataMember(Name = "scoringEvent", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scoringEvent")]
        public bool? ScoringEvent { get; set; }

        /// <summary>
        /// Gets or Sets TeamUnearned
        /// </summary>
        [DataMember(Name = "teamUnearned", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamUnearned")]
        public bool? TeamUnearned { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "events")]
        public Dictionary<string, string> Events { get; set; }

        /// <summary>
        /// Gets or Sets Rbi
        /// </summary>
        [DataMember(Name = "rbi", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rbi")]
        public bool? Rbi { get; set; }

        /// <summary>
        /// Gets or Sets Earned
        /// </summary>
        [DataMember(Name = "earned", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "earned")]
        public bool? Earned { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballRunnerMovement {\n");
            sb.Append("  StartBase: ").Append(StartBase).Append("\n");
            sb.Append("  EndBase: ").Append(EndBase).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventTypeEnum: ").Append(EventTypeEnum).Append("\n");
            sb.Append("  Runner: ").Append(Runner).Append("\n");
            sb.Append("  ResponsiblePitcher: ").Append(ResponsiblePitcher).Append("\n");
            sb.Append("  IsScoringEvent: ").Append(IsScoringEvent).Append("\n");
            sb.Append("  IsRbi: ").Append(IsRbi).Append("\n");
            sb.Append("  IsEarned: ").Append(IsEarned).Append("\n");
            sb.Append("  PlayIndex: ").Append(PlayIndex).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  OutNumber: ").Append(OutNumber).Append("\n");
            sb.Append("  OutBase: ").Append(OutBase).Append("\n");
            sb.Append("  MovementReason: ").Append(MovementReason).Append("\n");
            sb.Append("  MovementReasonEnum: ").Append(MovementReasonEnum).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
            sb.Append("  OriginBase: ").Append(OriginBase).Append("\n");
            sb.Append("  StartBaseInt: ").Append(StartBaseInt).Append("\n");
            sb.Append("  EndBaseInt: ").Append(EndBaseInt).Append("\n");
            sb.Append("  _Out: ").Append(_Out).Append("\n");
            sb.Append("  ScoringEvent: ").Append(ScoringEvent).Append("\n");
            sb.Append("  TeamUnearned: ").Append(TeamUnearned).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Rbi: ").Append(Rbi).Append("\n");
            sb.Append("  Earned: ").Append(Earned).Append("\n");
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