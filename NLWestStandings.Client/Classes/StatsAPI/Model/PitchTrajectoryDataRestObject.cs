using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PitchTrajectoryDataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Polynomial describing x position of the ball's pitch trajectory.
        /// </summary>
        /// <value>Polynomial describing x position of the ball's pitch trajectory.</value>
        [DataMember(Name = "trajectoryPolynomialX", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trajectoryPolynomialX")]
        public List<double?> TrajectoryPolynomialX { get; set; }

        /// <summary>
        /// Polynomial describing y position of the ball's pitch trajectory.
        /// </summary>
        /// <value>Polynomial describing y position of the ball's pitch trajectory.</value>
        [DataMember(Name = "trajectoryPolynomialY", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trajectoryPolynomialY")]
        public List<double?> TrajectoryPolynomialY { get; set; }

        /// <summary>
        /// Polynomial describing z position of the ball's pitch trajectory.
        /// </summary>
        /// <value>Polynomial describing z position of the ball's pitch trajectory.</value>
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
        /// Gets or Sets HorizontalBreak
        /// </summary>
        [DataMember(Name = "horizontalBreak", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "horizontalBreak")]
        public double? HorizontalBreak { get; set; }

        /// <summary>
        /// Gets or Sets VerticalBreakInduced
        /// </summary>
        [DataMember(Name = "verticalBreakInduced", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "verticalBreakInduced")]
        public double? VerticalBreakInduced { get; set; }

        /// <summary>
        /// Gets or Sets ZoneSpeed
        /// </summary>
        [DataMember(Name = "zoneSpeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "zoneSpeed")]
        public double? ZoneSpeed { get; set; }

        /// <summary>
        /// Gets or Sets ZoneTime
        /// </summary>
        [DataMember(Name = "zoneTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "zoneTime")]
        public double? ZoneTime { get; set; }

        /// <summary>
        /// Gets or Sets VerticalApproachAngle
        /// </summary>
        [DataMember(Name = "verticalApproachAngle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "verticalApproachAngle")]
        public double? VerticalApproachAngle { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveVelocity
        /// </summary>
        [DataMember(Name = "effectiveVelocity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "effectiveVelocity")]
        public double? EffectiveVelocity { get; set; }

        /// <summary>
        /// Gets or Sets HorizontalApproachAngle
        /// </summary>
        [DataMember(Name = "horizontalApproachAngle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "horizontalApproachAngle")]
        public double? HorizontalApproachAngle { get; set; }

        /// <summary>
        /// Gets or Sets VerticalBreak
        /// </summary>
        [DataMember(Name = "verticalBreak", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "verticalBreak")]
        public double? VerticalBreak { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "location")]
        public CoordinatesRestObject Location { get; set; }

        /// <summary>
        /// Gets or Sets PfxData
        /// </summary>
        [DataMember(Name = "pfxData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pfxData")]
        public PitchFxDataRestObject PfxData { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PitchTrajectoryDataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  TrajectoryPolynomialX: ").Append(TrajectoryPolynomialX).Append("\n");
            sb.Append("  TrajectoryPolynomialY: ").Append(TrajectoryPolynomialY).Append("\n");
            sb.Append("  TrajectoryPolynomialZ: ").Append(TrajectoryPolynomialZ).Append("\n");
            sb.Append("  ValidTimeInterval: ").Append(ValidTimeInterval).Append("\n");
            sb.Append("  MeasuredTimeInterval: ").Append(MeasuredTimeInterval).Append("\n");
            sb.Append("  ReducedConfidence: ").Append(ReducedConfidence).Append("\n");
            sb.Append("  HorizontalBreak: ").Append(HorizontalBreak).Append("\n");
            sb.Append("  VerticalBreakInduced: ").Append(VerticalBreakInduced).Append("\n");
            sb.Append("  ZoneSpeed: ").Append(ZoneSpeed).Append("\n");
            sb.Append("  ZoneTime: ").Append(ZoneTime).Append("\n");
            sb.Append("  VerticalApproachAngle: ").Append(VerticalApproachAngle).Append("\n");
            sb.Append("  EffectiveVelocity: ").Append(EffectiveVelocity).Append("\n");
            sb.Append("  HorizontalApproachAngle: ").Append(HorizontalApproachAngle).Append("\n");
            sb.Append("  VerticalBreak: ").Append(VerticalBreak).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  PfxData: ").Append(PfxData).Append("\n");
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