using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Details
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Call
        /// </summary>
        [DataMember(Name = "call", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "call")]
        public DynamicEnumRestObject Call { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets _Event
        /// </summary>
        [DataMember(Name = "event", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "event")]
        public string _Event { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventType")]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets BallColor
        /// </summary>
        [DataMember(Name = "ballColor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ballColor")]
        public string BallColor { get; set; }

        /// <summary>
        /// Gets or Sets TrailColor
        /// </summary>
        [DataMember(Name = "trailColor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trailColor")]
        public string TrailColor { get; set; }

        /// <summary>
        /// Gets or Sets IsInPlay
        /// </summary>
        [DataMember(Name = "isInPlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isInPlay")]
        public bool? IsInPlay { get; set; }

        /// <summary>
        /// Gets or Sets IsStrike
        /// </summary>
        [DataMember(Name = "isStrike", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isStrike")]
        public bool? IsStrike { get; set; }

        /// <summary>
        /// Gets or Sets IsBall
        /// </summary>
        [DataMember(Name = "isBall", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isBall")]
        public bool? IsBall { get; set; }

        /// <summary>
        /// Gets or Sets IsBaseHit
        /// </summary>
        [DataMember(Name = "isBaseHit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isBaseHit")]
        public bool? IsBaseHit { get; set; }

        /// <summary>
        /// Gets or Sets IsAtBat
        /// </summary>
        [DataMember(Name = "isAtBat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isAtBat")]
        public bool? IsAtBat { get; set; }

        /// <summary>
        /// Gets or Sets IsPlateAppearance
        /// </summary>
        [DataMember(Name = "isPlateAppearance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPlateAppearance")]
        public bool? IsPlateAppearance { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public DynamicEnumRestObject Type { get; set; }

        /// <summary>
        /// Gets or Sets AwayScore
        /// </summary>
        [DataMember(Name = "awayScore", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayScore")]
        public int? AwayScore { get; set; }

        /// <summary>
        /// Gets or Sets HomeScore
        /// </summary>
        [DataMember(Name = "homeScore", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeScore")]
        public int? HomeScore { get; set; }

        /// <summary>
        /// Gets or Sets IsScoringPlay
        /// </summary>
        [DataMember(Name = "isScoringPlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isScoringPlay")]
        public bool? IsScoringPlay { get; set; }

        /// <summary>
        /// Does the play event include an out?
        /// </summary>
        /// <value>Does the play event include an out?</value>
        [DataMember(Name = "isOut", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isOut")]
        public bool? IsOut { get; set; }

        /// <summary>
        /// Gets or Sets HasReview
        /// </summary>
        [DataMember(Name = "hasReview", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasReview")]
        public bool? HasReview { get; set; }

        /// <summary>
        /// Gets or Sets FromCatcher
        /// </summary>
        [DataMember(Name = "fromCatcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fromCatcher")]
        public bool? FromCatcher { get; set; }

        /// <summary>
        /// Gets or Sets RunnerGoing
        /// </summary>
        [DataMember(Name = "runnerGoing", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerGoing")]
        public bool? RunnerGoing { get; set; }

        /// <summary>
        /// Gets or Sets BatSide
        /// </summary>
        [DataMember(Name = "batSide", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batSide")]
        public DynamicEnumRestObject BatSide { get; set; }

        /// <summary>
        /// Gets or Sets PitchHand
        /// </summary>
        [DataMember(Name = "pitchHand", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchHand")]
        public DynamicEnumRestObject PitchHand { get; set; }

        /// <summary>
        /// Gets or Sets DisengagementNum
        /// </summary>
        [DataMember(Name = "disengagementNum", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "disengagementNum")]
        public int? DisengagementNum { get; set; }

        /// <summary>
        /// Gets or Sets Violation
        /// </summary>
        [DataMember(Name = "violation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "violation")]
        public ViolationRestObject Violation { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Details {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Call: ").Append(Call).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  _Event: ").Append(_Event).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  BallColor: ").Append(BallColor).Append("\n");
            sb.Append("  TrailColor: ").Append(TrailColor).Append("\n");
            sb.Append("  IsInPlay: ").Append(IsInPlay).Append("\n");
            sb.Append("  IsStrike: ").Append(IsStrike).Append("\n");
            sb.Append("  IsBall: ").Append(IsBall).Append("\n");
            sb.Append("  IsBaseHit: ").Append(IsBaseHit).Append("\n");
            sb.Append("  IsAtBat: ").Append(IsAtBat).Append("\n");
            sb.Append("  IsPlateAppearance: ").Append(IsPlateAppearance).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AwayScore: ").Append(AwayScore).Append("\n");
            sb.Append("  HomeScore: ").Append(HomeScore).Append("\n");
            sb.Append("  IsScoringPlay: ").Append(IsScoringPlay).Append("\n");
            sb.Append("  IsOut: ").Append(IsOut).Append("\n");
            sb.Append("  HasReview: ").Append(HasReview).Append("\n");
            sb.Append("  FromCatcher: ").Append(FromCatcher).Append("\n");
            sb.Append("  RunnerGoing: ").Append(RunnerGoing).Append("\n");
            sb.Append("  BatSide: ").Append(BatSide).Append("\n");
            sb.Append("  PitchHand: ").Append(PitchHand).Append("\n");
            sb.Append("  DisengagementNum: ").Append(DisengagementNum).Append("\n");
            sb.Append("  Violation: ").Append(Violation).Append("\n");
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