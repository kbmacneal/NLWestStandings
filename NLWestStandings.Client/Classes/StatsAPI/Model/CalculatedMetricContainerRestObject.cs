using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class CalculatedMetricContainerRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [DataMember(Name = "metrics", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "metrics")]
        public List<CalculatedMetricRestObject> Metrics { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name = "warnings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "warnings")]
        public List<MetricWarningRestObject> Warnings { get; set; }

        /// <summary>
        /// Gets or Sets InvalidMetrics
        /// </summary>
        [DataMember(Name = "invalidMetrics", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "invalidMetrics")]
        public List<CalculatedMetricRestObject> InvalidMetrics { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalculatedMetricContainerRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  InvalidMetrics: ").Append(InvalidMetrics).Append("\n");
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