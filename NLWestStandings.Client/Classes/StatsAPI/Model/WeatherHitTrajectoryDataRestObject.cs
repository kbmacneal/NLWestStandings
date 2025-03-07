using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class WeatherHitTrajectoryDataRestObject : HitTrajectoryDataRestObject
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
        /// Gets or Sets WindSpeed
        /// </summary>
        [DataMember(Name = "windSpeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "windSpeed")]
        public WindSpeedRestObject WindSpeed { get; set; }

        /// <summary>
        /// Gets or Sets Apex
        /// </summary>
        [DataMember(Name = "apex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "apex")]
        public double? Apex { get; set; }

        /// <summary>
        /// Gets or Sets TrajectoryConfidence
        /// </summary>
        [DataMember(Name = "trajectoryConfidence", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trajectoryConfidence")]
        public WeatherTrajectoryConfidenceTypeRestObject TrajectoryConfidence { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeatherHitTrajectoryDataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  TrajectoryPolynomialX: ").Append(TrajectoryPolynomialX).Append("\n");
            sb.Append("  TrajectoryPolynomialY: ").Append(TrajectoryPolynomialY).Append("\n");
            sb.Append("  TrajectoryPolynomialZ: ").Append(TrajectoryPolynomialZ).Append("\n");
            sb.Append("  WindSpeed: ").Append(WindSpeed).Append("\n");
            sb.Append("  Apex: ").Append(Apex).Append("\n");
            sb.Append("  TrajectoryConfidence: ").Append(TrajectoryConfidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}