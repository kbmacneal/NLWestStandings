using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class HitSegmentRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets LaunchData
        /// </summary>
        [DataMember(Name = "launchData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "launchData")]
        public LaunchDataRestObject LaunchData { get; set; }

        /// <summary>
        /// Gets or Sets TrajectoryData
        /// </summary>
        [DataMember(Name = "trajectoryData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trajectoryData")]
        public HitTrajectoryDataRestObject TrajectoryData { get; set; }

        /// <summary>
        /// Gets or Sets LandingData
        /// </summary>
        [DataMember(Name = "landingData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "landingData")]
        public StartEndDataRestObject LandingData { get; set; }

        /// <summary>
        /// Gets or Sets LastMeasuredData
        /// </summary>
        [DataMember(Name = "lastMeasuredData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastMeasuredData")]
        public StartEndDataRestObject LastMeasuredData { get; set; }

        /// <summary>
        /// Gets or Sets ReducedConfidence
        /// </summary>
        [DataMember(Name = "reducedConfidence", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reducedConfidence")]
        public List<string> ReducedConfidence { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HitSegmentRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  LaunchData: ").Append(LaunchData).Append("\n");
            sb.Append("  TrajectoryData: ").Append(TrajectoryData).Append("\n");
            sb.Append("  LandingData: ").Append(LandingData).Append("\n");
            sb.Append("  LastMeasuredData: ").Append(LastMeasuredData).Append("\n");
            sb.Append("  ReducedConfidence: ").Append(ReducedConfidence).Append("\n");
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