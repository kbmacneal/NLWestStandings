using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class StatSearchParamRestObject
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
        /// Gets or Sets FilterLevel
        /// </summary>
        [DataMember(Name = "filterLevel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "filterLevel")]
        public string FilterLevel { get; set; }

        /// <summary>
        /// Gets or Sets Hitting
        /// </summary>
        [DataMember(Name = "hitting", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitting")]
        public bool? Hitting { get; set; }

        /// <summary>
        /// Gets or Sets Pitching
        /// </summary>
        [DataMember(Name = "pitching", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitching")]
        public bool? Pitching { get; set; }

        /// <summary>
        /// Gets or Sets Fielding
        /// </summary>
        [DataMember(Name = "fielding", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fielding")]
        public bool? Fielding { get; set; }

        /// <summary>
        /// Gets or Sets Catching
        /// </summary>
        [DataMember(Name = "catching", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "catching")]
        public bool? Catching { get; set; }

        /// <summary>
        /// Gets or Sets Running
        /// </summary>
        [DataMember(Name = "running", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "running")]
        public bool? Running { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatSearchParamRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  FilterLevel: ").Append(FilterLevel).Append("\n");
            sb.Append("  Hitting: ").Append(Hitting).Append("\n");
            sb.Append("  Pitching: ").Append(Pitching).Append("\n");
            sb.Append("  Fielding: ").Append(Fielding).Append("\n");
            sb.Append("  Catching: ").Append(Catching).Append("\n");
            sb.Append("  Running: ").Append(Running).Append("\n");
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