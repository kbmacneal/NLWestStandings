using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballPlayRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Hydrations
        /// </summary>
        [DataMember(Name = "hydrations", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydrations")]
        public List<string> Hydrations { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "result")]
        public Result Result { get; set; }

        /// <summary>
        /// Gets or Sets About
        /// </summary>
        [DataMember(Name = "about", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "about")]
        public About About { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "count")]
        public Count Count { get; set; }

        /// <summary>
        /// Gets or Sets Matchup
        /// </summary>
        [DataMember(Name = "matchup", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "matchup")]
        public Matchup Matchup { get; set; }

        /// <summary>
        /// Gets or Sets PitchIndex
        /// </summary>
        [DataMember(Name = "pitchIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchIndex")]
        public List<int?> PitchIndex { get; set; }

        /// <summary>
        /// Gets or Sets ActionIndex
        /// </summary>
        [DataMember(Name = "actionIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "actionIndex")]
        public List<int?> ActionIndex { get; set; }

        /// <summary>
        /// Gets or Sets RunnerIndex
        /// </summary>
        [DataMember(Name = "runnerIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerIndex")]
        public List<int?> RunnerIndex { get; set; }

        /// <summary>
        /// Gets or Sets Runners
        /// </summary>
        [DataMember(Name = "runners", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runners")]
        public List<RunnerMovement> Runners { get; set; }

        /// <summary>
        /// Gets or Sets PlayEvents
        /// </summary>
        [DataMember(Name = "playEvents", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playEvents")]
        public List<BaseballPlayEventRestObject> PlayEvents { get; set; }

        /// <summary>
        /// Gets or Sets Credits
        /// </summary>
        [DataMember(Name = "credits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "credits")]
        public List<PlayCreditRestObject> Credits { get; set; }

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "flags")]
        public List<PlayCreditRestObject> Flags { get; set; }

        /// <summary>
        /// Gets or Sets ReviewDetails
        /// </summary>
        [DataMember(Name = "reviewDetails", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reviewDetails")]
        public ReviewDetails ReviewDetails { get; set; }

        /// <summary>
        /// Gets or Sets PlayEndTime
        /// </summary>
        [DataMember(Name = "playEndTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playEndTime")]
        public DateTime? PlayEndTime { get; set; }

        /// <summary>
        /// Gets or Sets AtBatIndex
        /// </summary>
        [DataMember(Name = "atBatIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "atBatIndex")]
        public int? AtBatIndex { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballPlayRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Hydrations: ").Append(Hydrations).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  About: ").Append(About).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Matchup: ").Append(Matchup).Append("\n");
            sb.Append("  PitchIndex: ").Append(PitchIndex).Append("\n");
            sb.Append("  ActionIndex: ").Append(ActionIndex).Append("\n");
            sb.Append("  RunnerIndex: ").Append(RunnerIndex).Append("\n");
            sb.Append("  Runners: ").Append(Runners).Append("\n");
            sb.Append("  PlayEvents: ").Append(PlayEvents).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  ReviewDetails: ").Append(ReviewDetails).Append("\n");
            sb.Append("  PlayEndTime: ").Append(PlayEndTime).Append("\n");
            sb.Append("  AtBatIndex: ").Append(AtBatIndex).Append("\n");
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