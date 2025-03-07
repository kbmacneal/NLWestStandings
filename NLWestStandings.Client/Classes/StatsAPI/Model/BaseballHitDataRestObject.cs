using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballHitDataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets LaunchSpeed
        /// </summary>
        [DataMember(Name = "launchSpeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "launchSpeed")]
        public double? LaunchSpeed { get; set; }

        /// <summary>
        /// Gets or Sets LaunchAngle
        /// </summary>
        [DataMember(Name = "launchAngle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "launchAngle")]
        public double? LaunchAngle { get; set; }

        /// <summary>
        /// Gets or Sets TotalDistance
        /// </summary>
        [DataMember(Name = "totalDistance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalDistance")]
        public double? TotalDistance { get; set; }

        /// <summary>
        /// Gets or Sets Trajectory
        /// </summary>
        [DataMember(Name = "trajectory", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trajectory")]
        public string Trajectory { get; set; }

        /// <summary>
        /// Gets or Sets Hardness
        /// </summary>
        [DataMember(Name = "hardness", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hardness")]
        public string Hardness { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets Coordinates
        /// </summary>
        [DataMember(Name = "coordinates", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "coordinates")]
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Gets or Sets IsBarrel
        /// </summary>
        [DataMember(Name = "isBarrel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isBarrel")]
        public bool? IsBarrel { get; set; }

        /// <summary>
        /// Gets or Sets HitProbability
        /// </summary>
        [DataMember(Name = "hitProbability", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitProbability")]
        public double? HitProbability { get; set; }

        /// <summary>
        /// Gets or Sets BatSpeed
        /// </summary>
        [DataMember(Name = "batSpeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batSpeed")]
        public double? BatSpeed { get; set; }

        /// <summary>
        /// Gets or Sets IsSwordSwing
        /// </summary>
        [DataMember(Name = "isSwordSwing", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isSwordSwing")]
        public bool? IsSwordSwing { get; set; }

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
            sb.Append("class BaseballHitDataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  LaunchSpeed: ").Append(LaunchSpeed).Append("\n");
            sb.Append("  LaunchAngle: ").Append(LaunchAngle).Append("\n");
            sb.Append("  TotalDistance: ").Append(TotalDistance).Append("\n");
            sb.Append("  Trajectory: ").Append(Trajectory).Append("\n");
            sb.Append("  Hardness: ").Append(Hardness).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
            sb.Append("  IsBarrel: ").Append(IsBarrel).Append("\n");
            sb.Append("  HitProbability: ").Append(HitProbability).Append("\n");
            sb.Append("  BatSpeed: ").Append(BatSpeed).Append("\n");
            sb.Append("  IsSwordSwing: ").Append(IsSwordSwing).Append("\n");
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