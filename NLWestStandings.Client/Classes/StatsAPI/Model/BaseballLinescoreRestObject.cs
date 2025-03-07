using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballLinescoreRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets CurrentInning
        /// </summary>
        [DataMember(Name = "currentInning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentInning")]
        public int? CurrentInning { get; set; }

        /// <summary>
        /// Gets or Sets CurrentInningOrdinal
        /// </summary>
        [DataMember(Name = "currentInningOrdinal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentInningOrdinal")]
        public string CurrentInningOrdinal { get; set; }

        /// <summary>
        /// Gets or Sets InningState
        /// </summary>
        [DataMember(Name = "inningState", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inningState")]
        public string InningState { get; set; }

        /// <summary>
        /// Gets or Sets InningHalf
        /// </summary>
        [DataMember(Name = "inningHalf", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inningHalf")]
        public string InningHalf { get; set; }

        /// <summary>
        /// Gets or Sets IsTopInning
        /// </summary>
        [DataMember(Name = "isTopInning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isTopInning")]
        public bool? IsTopInning { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledInnings
        /// </summary>
        [DataMember(Name = "scheduledInnings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scheduledInnings")]
        public int? ScheduledInnings { get; set; }

        /// <summary>
        /// Gets or Sets Innings
        /// </summary>
        [DataMember(Name = "innings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "innings")]
        public List<InningRestObject> Innings { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teams")]
        public BaseballLinescoreTeamInfoRestObject Teams { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [DataMember(Name = "defense", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "defense")]
        public BaseballDefenseRestObject Defense { get; set; }

        /// <summary>
        /// Gets or Sets Offense
        /// </summary>
        [DataMember(Name = "offense", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offense")]
        public BaseballOffenseRestObject Offense { get; set; }

        /// <summary>
        /// Gets or Sets Balls
        /// </summary>
        [DataMember(Name = "balls", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "balls")]
        public int? Balls { get; set; }

        /// <summary>
        /// Gets or Sets Strikes
        /// </summary>
        [DataMember(Name = "strikes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikes")]
        public int? Strikes { get; set; }

        /// <summary>
        /// Gets or Sets Outs
        /// </summary>
        [DataMember(Name = "outs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outs")]
        public int? Outs { get; set; }

        /// <summary>
        /// Gets or Sets Tie
        /// </summary>
        [DataMember(Name = "tie", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tie")]
        public bool? Tie { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballLinescoreRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  CurrentInning: ").Append(CurrentInning).Append("\n");
            sb.Append("  CurrentInningOrdinal: ").Append(CurrentInningOrdinal).Append("\n");
            sb.Append("  InningState: ").Append(InningState).Append("\n");
            sb.Append("  InningHalf: ").Append(InningHalf).Append("\n");
            sb.Append("  IsTopInning: ").Append(IsTopInning).Append("\n");
            sb.Append("  ScheduledInnings: ").Append(ScheduledInnings).Append("\n");
            sb.Append("  Innings: ").Append(Innings).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
            sb.Append("  Defense: ").Append(Defense).Append("\n");
            sb.Append("  Offense: ").Append(Offense).Append("\n");
            sb.Append("  Balls: ").Append(Balls).Append("\n");
            sb.Append("  Strikes: ").Append(Strikes).Append("\n");
            sb.Append("  Outs: ").Append(Outs).Append("\n");
            sb.Append("  Tie: ").Append(Tie).Append("\n");
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