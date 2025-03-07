using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class GroupedStatData
    {
        /// <summary>
        /// Gets or Sets Standard
        /// </summary>
        [DataMember(Name = "standard", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "standard")]
        public StatData Standard { get; set; }

        /// <summary>
        /// Gets or Sets Advanced
        /// </summary>
        [DataMember(Name = "advanced", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "advanced")]
        public StatData Advanced { get; set; }

        /// <summary>
        /// Gets or Sets Expected
        /// </summary>
        [DataMember(Name = "expected", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expected")]
        public StatData Expected { get; set; }

        /// <summary>
        /// Gets or Sets Projected
        /// </summary>
        [DataMember(Name = "projected", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "projected")]
        public StatData Projected { get; set; }

        /// <summary>
        /// Gets or Sets Tracking
        /// </summary>
        [DataMember(Name = "tracking", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tracking")]
        public StatData Tracking { get; set; }

        /// <summary>
        /// Gets or Sets Pitching
        /// </summary>
        [DataMember(Name = "pitching", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitching")]
        public GroupedStatData Pitching { get; set; }

        /// <summary>
        /// Gets or Sets Hitting
        /// </summary>
        [DataMember(Name = "hitting", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitting")]
        public GroupedStatData Hitting { get; set; }

        /// <summary>
        /// Gets or Sets Fielding
        /// </summary>
        [DataMember(Name = "fielding", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fielding")]
        public GroupedStatData Fielding { get; set; }

        /// <summary>
        /// Gets or Sets Running
        /// </summary>
        [DataMember(Name = "running", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "running")]
        public GroupedStatData Running { get; set; }

        /// <summary>
        /// Gets or Sets Catching
        /// </summary>
        [DataMember(Name = "catching", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "catching")]
        public GroupedStatData Catching { get; set; }

        /// <summary>
        /// Gets or Sets Rankings
        /// </summary>
        [DataMember(Name = "rankings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rankings")]
        public GroupedStatData Rankings { get; set; }

        /// <summary>
        /// Gets or Sets Percentiles
        /// </summary>
        [DataMember(Name = "percentiles", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "percentiles")]
        public GroupedStatData Percentiles { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupedStatData {\n");
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