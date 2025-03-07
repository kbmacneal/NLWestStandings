using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SegmentRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets SegmentType
        /// </summary>
        [DataMember(Name = "segmentType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "segmentType")]
        public string SegmentType { get; set; }

        /// <summary>
        /// Gets or Sets EndData
        /// </summary>
        [DataMember(Name = "endData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endData")]
        public StartEndDataRestObject EndData { get; set; }

        /// <summary>
        /// Gets or Sets LastMeasuredData
        /// </summary>
        [DataMember(Name = "lastMeasuredData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastMeasuredData")]
        public MeasuredDataRestObject LastMeasuredData { get; set; }

        /// <summary>
        /// Gets or Sets FirstMeasuredData
        /// </summary>
        [DataMember(Name = "firstMeasuredData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstMeasuredData")]
        public MeasuredDataRestObject FirstMeasuredData { get; set; }

        /// <summary>
        /// Gets or Sets LandingData
        /// </summary>
        [DataMember(Name = "landingData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "landingData")]
        public MeasuredDataRestObject LandingData { get; set; }

        /// <summary>
        /// Gets or Sets ReducedConfidence
        /// </summary>
        [DataMember(Name = "reducedConfidence", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reducedConfidence")]
        public List<string> ReducedConfidence { get; set; }

        /// <summary>
        /// Gets or Sets StartData
        /// </summary>
        [DataMember(Name = "startData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startData")]
        public StartEndDataRestObject StartData { get; set; }

        /// <summary>
        /// Gets or Sets TrajectoryPolynomialX
        /// </summary>
        [DataMember(Name = "trajectoryPolynomialX", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trajectoryPolynomialX")]
        public List<double?> TrajectoryPolynomialX { get; set; }

        /// <summary>
        /// Gets or Sets TrajectoryPolynomialY
        /// </summary>
        [DataMember(Name = "trajectoryPolynomialY", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trajectoryPolynomialY")]
        public List<double?> TrajectoryPolynomialY { get; set; }

        /// <summary>
        /// Gets or Sets TrajectoryPolynomialZ
        /// </summary>
        [DataMember(Name = "trajectoryPolynomialZ", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trajectoryPolynomialZ")]
        public List<double?> TrajectoryPolynomialZ { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SegmentRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  SegmentType: ").Append(SegmentType).Append("\n");
            sb.Append("  EndData: ").Append(EndData).Append("\n");
            sb.Append("  LastMeasuredData: ").Append(LastMeasuredData).Append("\n");
            sb.Append("  FirstMeasuredData: ").Append(FirstMeasuredData).Append("\n");
            sb.Append("  LandingData: ").Append(LandingData).Append("\n");
            sb.Append("  ReducedConfidence: ").Append(ReducedConfidence).Append("\n");
            sb.Append("  StartData: ").Append(StartData).Append("\n");
            sb.Append("  TrajectoryPolynomialX: ").Append(TrajectoryPolynomialX).Append("\n");
            sb.Append("  TrajectoryPolynomialY: ").Append(TrajectoryPolynomialY).Append("\n");
            sb.Append("  TrajectoryPolynomialZ: ").Append(TrajectoryPolynomialZ).Append("\n");
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