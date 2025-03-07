using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballHit
    {
        /// <summary>
        /// Gets or Sets LaunchData
        /// </summary>
        [DataMember(Name = "launchData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "launchData")]
        public LaunchData LaunchData { get; set; }

        /// <summary>
        /// Gets or Sets TrajectoryData
        /// </summary>
        [DataMember(Name = "trajectoryData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trajectoryData")]
        public HitTrajectoryData TrajectoryData { get; set; }

        /// <summary>
        /// Gets or Sets LandingData
        /// </summary>
        [DataMember(Name = "landingData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "landingData")]
        public StartEndData LandingData { get; set; }

        /// <summary>
        /// Gets or Sets LastMeasuredData
        /// </summary>
        [DataMember(Name = "lastMeasuredData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastMeasuredData")]
        public StartEndData LastMeasuredData { get; set; }

        /// <summary>
        /// Gets or Sets ReducedConfidence
        /// </summary>
        [DataMember(Name = "reducedConfidence", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reducedConfidence")]
        public List<string> ReducedConfidence { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeam Team { get; set; }

        /// <summary>
        /// Gets or Sets Inning
        /// </summary>
        [DataMember(Name = "inning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inning")]
        public int? Inning { get; set; }

        /// <summary>
        /// Gets or Sets Pitcher
        /// </summary>
        [DataMember(Name = "pitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitcher")]
        public BaseballPerson Pitcher { get; set; }

        /// <summary>
        /// Gets or Sets Batter
        /// </summary>
        [DataMember(Name = "batter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batter")]
        public BaseballPerson Batter { get; set; }

        /// <summary>
        /// Gets or Sets CoordX
        /// </summary>
        [DataMember(Name = "coordX", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "coordX")]
        public double? CoordX { get; set; }

        /// <summary>
        /// Gets or Sets CoordY
        /// </summary>
        [DataMember(Name = "coordY", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "coordY")]
        public double? CoordY { get; set; }

        /// <summary>
        /// Gets or Sets LandingPosX
        /// </summary>
        [DataMember(Name = "landingPosX", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "landingPosX")]
        public double? LandingPosX { get; set; }

        /// <summary>
        /// Gets or Sets LandingPosY
        /// </summary>
        [DataMember(Name = "landingPosY", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "landingPosY")]
        public double? LandingPosY { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets LaunchSpeed
        /// </summary>
        [DataMember(Name = "launchSpeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "launchSpeed")]
        public double? LaunchSpeed { get; set; }

        /// <summary>
        /// Gets or Sets TotalDistance
        /// </summary>
        [DataMember(Name = "totalDistance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalDistance")]
        public double? TotalDistance { get; set; }

        /// <summary>
        /// Gets or Sets LaunchAngle
        /// </summary>
        [DataMember(Name = "launchAngle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "launchAngle")]
        public double? LaunchAngle { get; set; }

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
        /// Gets or Sets Descriptions
        /// </summary>
        [DataMember(Name = "descriptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "descriptions")]
        public Dictionary<string, string> Descriptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballHit {\n");
            sb.Append("  LaunchData: ").Append(LaunchData).Append("\n");
            sb.Append("  TrajectoryData: ").Append(TrajectoryData).Append("\n");
            sb.Append("  LandingData: ").Append(LandingData).Append("\n");
            sb.Append("  LastMeasuredData: ").Append(LastMeasuredData).Append("\n");
            sb.Append("  ReducedConfidence: ").Append(ReducedConfidence).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Inning: ").Append(Inning).Append("\n");
            sb.Append("  Pitcher: ").Append(Pitcher).Append("\n");
            sb.Append("  Batter: ").Append(Batter).Append("\n");
            sb.Append("  CoordX: ").Append(CoordX).Append("\n");
            sb.Append("  CoordY: ").Append(CoordY).Append("\n");
            sb.Append("  LandingPosX: ").Append(LandingPosX).Append("\n");
            sb.Append("  LandingPosY: ").Append(LandingPosY).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LaunchSpeed: ").Append(LaunchSpeed).Append("\n");
            sb.Append("  TotalDistance: ").Append(TotalDistance).Append("\n");
            sb.Append("  LaunchAngle: ").Append(LaunchAngle).Append("\n");
            sb.Append("  Trajectory: ").Append(Trajectory).Append("\n");
            sb.Append("  Hardness: ").Append(Hardness).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  IsBarrel: ").Append(IsBarrel).Append("\n");
            sb.Append("  HitProbability: ").Append(HitProbability).Append("\n");
            sb.Append("  BatSpeed: ").Append(BatSpeed).Append("\n");
            sb.Append("  IsSwordSwing: ").Append(IsSwordSwing).Append("\n");
            sb.Append("  Descriptions: ").Append(Descriptions).Append("\n");
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