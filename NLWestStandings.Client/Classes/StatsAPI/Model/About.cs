using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class About
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets AtBatIndex
        /// </summary>
        [DataMember(Name = "atBatIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "atBatIndex")]
        public int? AtBatIndex { get; set; }

        /// <summary>
        /// Gets or Sets HalfInning
        /// </summary>
        [DataMember(Name = "halfInning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "halfInning")]
        public string HalfInning { get; set; }

        /// <summary>
        /// Gets or Sets IsTopInning
        /// </summary>
        [DataMember(Name = "isTopInning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isTopInning")]
        public bool? IsTopInning { get; set; }

        /// <summary>
        /// Gets or Sets Inning
        /// </summary>
        [DataMember(Name = "inning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inning")]
        public int? Inning { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startTime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "endTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endTime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or Sets IsComplete
        /// </summary>
        [DataMember(Name = "isComplete", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isComplete")]
        public bool? IsComplete { get; set; }

        /// <summary>
        /// Gets or Sets IsScoringPlay
        /// </summary>
        [DataMember(Name = "isScoringPlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isScoringPlay")]
        public bool? IsScoringPlay { get; set; }

        /// <summary>
        /// Gets or Sets HasReview
        /// </summary>
        [DataMember(Name = "hasReview", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasReview")]
        public bool? HasReview { get; set; }

        /// <summary>
        /// Does the play include an out?
        /// </summary>
        /// <value>Does the play include an out?</value>
        [DataMember(Name = "hasOut", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasOut")]
        public bool? HasOut { get; set; }

        /// <summary>
        /// Gets or Sets CaptivatingIndex
        /// </summary>
        [DataMember(Name = "captivatingIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "captivatingIndex")]
        public int? CaptivatingIndex { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class About {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  AtBatIndex: ").Append(AtBatIndex).Append("\n");
            sb.Append("  HalfInning: ").Append(HalfInning).Append("\n");
            sb.Append("  IsTopInning: ").Append(IsTopInning).Append("\n");
            sb.Append("  Inning: ").Append(Inning).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
            sb.Append("  IsScoringPlay: ").Append(IsScoringPlay).Append("\n");
            sb.Append("  HasReview: ").Append(HasReview).Append("\n");
            sb.Append("  HasOut: ").Append(HasOut).Append("\n");
            sb.Append("  CaptivatingIndex: ").Append(CaptivatingIndex).Append("\n");
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