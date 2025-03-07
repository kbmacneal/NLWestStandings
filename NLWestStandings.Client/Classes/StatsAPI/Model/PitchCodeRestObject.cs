using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PitchCodeRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets SwingStatus
        /// </summary>
        [DataMember(Name = "swingStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "swingStatus")]
        public bool? SwingStatus { get; set; }

        /// <summary>
        /// Gets or Sets SwingMissStatus
        /// </summary>
        [DataMember(Name = "swingMissStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "swingMissStatus")]
        public bool? SwingMissStatus { get; set; }

        /// <summary>
        /// Gets or Sets SwingContactStatus
        /// </summary>
        [DataMember(Name = "swingContactStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "swingContactStatus")]
        public bool? SwingContactStatus { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets StrikeStatus
        /// </summary>
        [DataMember(Name = "strikeStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikeStatus")]
        public bool? StrikeStatus { get; set; }

        /// <summary>
        /// Gets or Sets BallStatus
        /// </summary>
        [DataMember(Name = "ballStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ballStatus")]
        public bool? BallStatus { get; set; }

        /// <summary>
        /// Gets or Sets PitchStatus
        /// </summary>
        [DataMember(Name = "pitchStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchStatus")]
        public bool? PitchStatus { get; set; }

        /// <summary>
        /// Gets or Sets PitchResultText
        /// </summary>
        [DataMember(Name = "pitchResultText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchResultText")]
        public string PitchResultText { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PitchCodeRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SwingStatus: ").Append(SwingStatus).Append("\n");
            sb.Append("  SwingMissStatus: ").Append(SwingMissStatus).Append("\n");
            sb.Append("  SwingContactStatus: ").Append(SwingContactStatus).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  StrikeStatus: ").Append(StrikeStatus).Append("\n");
            sb.Append("  BallStatus: ").Append(BallStatus).Append("\n");
            sb.Append("  PitchStatus: ").Append(PitchStatus).Append("\n");
            sb.Append("  PitchResultText: ").Append(PitchResultText).Append("\n");
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