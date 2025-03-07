using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class HitTrajectoryData
    {
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
        /// Gets or Sets ValidTimeInterval
        /// </summary>
        [DataMember(Name = "validTimeInterval", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "validTimeInterval")]
        public List<double?> ValidTimeInterval { get; set; }

        /// <summary>
        /// Gets or Sets MeasuredTimeInterval
        /// </summary>
        [DataMember(Name = "measuredTimeInterval", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "measuredTimeInterval")]
        public List<double?> MeasuredTimeInterval { get; set; }

        /// <summary>
        /// Gets or Sets ReducedConfidence
        /// </summary>
        [DataMember(Name = "reducedConfidence", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reducedConfidence")]
        public List<string> ReducedConfidence { get; set; }

        /// <summary>
        /// Gets or Sets MaxHeightPosition
        /// </summary>
        [DataMember(Name = "maxHeightPosition", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "maxHeightPosition")]
        public Coordinates MaxHeightPosition { get; set; }

        /// <summary>
        /// Gets or Sets HitPositionAt110Feet
        /// </summary>
        [DataMember(Name = "hitPositionAt110Feet", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitPositionAt110Feet")]
        public Coordinates HitPositionAt110Feet { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HitTrajectoryData {\n");
            sb.Append("  TrajectoryPolynomialX: ").Append(TrajectoryPolynomialX).Append("\n");
            sb.Append("  TrajectoryPolynomialY: ").Append(TrajectoryPolynomialY).Append("\n");
            sb.Append("  TrajectoryPolynomialZ: ").Append(TrajectoryPolynomialZ).Append("\n");
            sb.Append("  ValidTimeInterval: ").Append(ValidTimeInterval).Append("\n");
            sb.Append("  MeasuredTimeInterval: ").Append(MeasuredTimeInterval).Append("\n");
            sb.Append("  ReducedConfidence: ").Append(ReducedConfidence).Append("\n");
            sb.Append("  MaxHeightPosition: ").Append(MaxHeightPosition).Append("\n");
            sb.Append("  HitPositionAt110Feet: ").Append(HitPositionAt110Feet).Append("\n");
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