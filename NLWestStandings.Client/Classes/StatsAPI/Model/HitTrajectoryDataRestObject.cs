using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class HitTrajectoryDataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Polynomial describing x position of the ball's hit trajectory.
        /// </summary>
        /// <value>Polynomial describing x position of the ball's hit trajectory.</value>
        [DataMember(Name = "trajectoryPolynomialX", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trajectoryPolynomialX")]
        public List<double?> TrajectoryPolynomialX { get; set; }

        /// <summary>
        /// Polynomial describing y position of the ball's hit trajectory.
        /// </summary>
        /// <value>Polynomial describing y position of the ball's hit trajectory.</value>
        [DataMember(Name = "trajectoryPolynomialY", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trajectoryPolynomialY")]
        public List<double?> TrajectoryPolynomialY { get; set; }

        /// <summary>
        /// Polynomial describing z position of the ball's hit trajectory.
        /// </summary>
        /// <value>Polynomial describing z position of the ball's hit trajectory.</value>
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
        public CoordinatesRestObject MaxHeightPosition { get; set; }

        /// <summary>
        /// Gets or Sets HitPositionAt110Feet
        /// </summary>
        [DataMember(Name = "hitPositionAt110Feet", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitPositionAt110Feet")]
        public CoordinatesRestObject HitPositionAt110Feet { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HitTrajectoryDataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
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