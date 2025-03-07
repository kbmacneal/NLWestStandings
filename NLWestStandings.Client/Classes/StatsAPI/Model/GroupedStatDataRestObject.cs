using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class GroupedStatDataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Standard
        /// </summary>
        [DataMember(Name = "standard", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "standard")]
        public StatDataRestObject Standard { get; set; }

        /// <summary>
        /// Gets or Sets Advanced
        /// </summary>
        [DataMember(Name = "advanced", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "advanced")]
        public StatDataRestObject Advanced { get; set; }

        /// <summary>
        /// Gets or Sets Expected
        /// </summary>
        [DataMember(Name = "expected", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expected")]
        public StatDataRestObject Expected { get; set; }

        /// <summary>
        /// Gets or Sets Projected
        /// </summary>
        [DataMember(Name = "projected", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "projected")]
        public StatDataRestObject Projected { get; set; }

        /// <summary>
        /// Gets or Sets Tracking
        /// </summary>
        [DataMember(Name = "tracking", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tracking")]
        public StatDataRestObject Tracking { get; set; }

        /// <summary>
        /// Gets or Sets Pitching
        /// </summary>
        [DataMember(Name = "pitching", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitching")]
        public GroupedStatDataRestObject Pitching { get; set; }

        /// <summary>
        /// Gets or Sets Hitting
        /// </summary>
        [DataMember(Name = "hitting", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitting")]
        public GroupedStatDataRestObject Hitting { get; set; }

        /// <summary>
        /// Gets or Sets Fielding
        /// </summary>
        [DataMember(Name = "fielding", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fielding")]
        public GroupedStatDataRestObject Fielding { get; set; }

        /// <summary>
        /// Gets or Sets Running
        /// </summary>
        [DataMember(Name = "running", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "running")]
        public GroupedStatDataRestObject Running { get; set; }

        /// <summary>
        /// Gets or Sets Catching
        /// </summary>
        [DataMember(Name = "catching", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "catching")]
        public GroupedStatDataRestObject Catching { get; set; }

        /// <summary>
        /// Gets or Sets Rankings
        /// </summary>
        [DataMember(Name = "rankings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rankings")]
        public GroupedStatDataRestObject Rankings { get; set; }

        /// <summary>
        /// Gets or Sets Percentiles
        /// </summary>
        [DataMember(Name = "percentiles", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "percentiles")]
        public GroupedStatDataRestObject Percentiles { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupedStatDataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Standard: ").Append(Standard).Append("\n");
            sb.Append("  Advanced: ").Append(Advanced).Append("\n");
            sb.Append("  Expected: ").Append(Expected).Append("\n");
            sb.Append("  Projected: ").Append(Projected).Append("\n");
            sb.Append("  Tracking: ").Append(Tracking).Append("\n");
            sb.Append("  Pitching: ").Append(Pitching).Append("\n");
            sb.Append("  Hitting: ").Append(Hitting).Append("\n");
            sb.Append("  Fielding: ").Append(Fielding).Append("\n");
            sb.Append("  Running: ").Append(Running).Append("\n");
            sb.Append("  Catching: ").Append(Catching).Append("\n");
            sb.Append("  Rankings: ").Append(Rankings).Append("\n");
            sb.Append("  Percentiles: ").Append(Percentiles).Append("\n");
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