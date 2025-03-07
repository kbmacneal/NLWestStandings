using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Count
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

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
        /// Gets or Sets Inning
        /// </summary>
        [DataMember(Name = "inning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inning")]
        public int? Inning { get; set; }

        /// <summary>
        /// Gets or Sets IsTopInning
        /// </summary>
        [DataMember(Name = "isTopInning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isTopInning")]
        public bool? IsTopInning { get; set; }

        /// <summary>
        /// Gets or Sets RunnerOn1b
        /// </summary>
        [DataMember(Name = "runnerOn1b", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerOn1b")]
        public bool? RunnerOn1b { get; set; }

        /// <summary>
        /// Gets or Sets RunnerOn2b
        /// </summary>
        [DataMember(Name = "runnerOn2b", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerOn2b")]
        public bool? RunnerOn2b { get; set; }

        /// <summary>
        /// Gets or Sets RunnerOn3b
        /// </summary>
        [DataMember(Name = "runnerOn3b", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerOn3b")]
        public bool? RunnerOn3b { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Count {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Balls: ").Append(Balls).Append("\n");
            sb.Append("  Strikes: ").Append(Strikes).Append("\n");
            sb.Append("  Outs: ").Append(Outs).Append("\n");
            sb.Append("  Inning: ").Append(Inning).Append("\n");
            sb.Append("  IsTopInning: ").Append(IsTopInning).Append("\n");
            sb.Append("  RunnerOn1b: ").Append(RunnerOn1b).Append("\n");
            sb.Append("  RunnerOn2b: ").Append(RunnerOn2b).Append("\n");
            sb.Append("  RunnerOn3b: ").Append(RunnerOn3b).Append("\n");
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