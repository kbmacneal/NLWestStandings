using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Hit segment data for the calm scenario. Wind speed is fixed at 0.
    /// </summary>
    [DataContract]
    public class WeatherHitSegmentCalm
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets TrajectoryData
        /// </summary>
        [DataMember(Name = "trajectoryData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trajectoryData")]
        public WeatherHitTrajectoryDataRestObject TrajectoryData { get; set; }

        /// <summary>
        /// Gets or Sets LandingData
        /// </summary>
        [DataMember(Name = "landingData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "landingData")]
        public LandingDataRestObject LandingData { get; set; }

        /// <summary>
        /// Gets or Sets Conditions
        /// </summary>
        [DataMember(Name = "conditions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "conditions")]
        public WeatherMetricRestObject Conditions { get; set; }

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "flags")]
        public WeatherConditionFlagRestObject Flags { get; set; }

        /// <summary>
        /// Gets or Sets Deviations
        /// </summary>
        [DataMember(Name = "deviations", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deviations")]
        public WeatherDeviationRestObject Deviations { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeatherHitSegmentCalm {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  TrajectoryData: ").Append(TrajectoryData).Append("\n");
            sb.Append("  LandingData: ").Append(LandingData).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Deviations: ").Append(Deviations).Append("\n");
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