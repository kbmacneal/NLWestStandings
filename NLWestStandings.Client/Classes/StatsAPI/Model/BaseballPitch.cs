using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballPitch
    {
        /// <summary>
        /// Gets or Sets BallColor
        /// </summary>
        [DataMember(Name = "ballColor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ballColor")]
        public string BallColor { get; set; }

        /// <summary>
        /// Gets or Sets TrailColor
        /// </summary>
        [DataMember(Name = "trailColor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trailColor")]
        public string TrailColor { get; set; }

        /// <summary>
        /// Gets or Sets StartSpeed
        /// </summary>
        [DataMember(Name = "startSpeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startSpeed")]
        public double? StartSpeed { get; set; }

        /// <summary>
        /// Gets or Sets EndSpeed
        /// </summary>
        [DataMember(Name = "endSpeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endSpeed")]
        public double? EndSpeed { get; set; }

        /// <summary>
        /// Gets or Sets NastyFactor
        /// </summary>
        [DataMember(Name = "nastyFactor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nastyFactor")]
        public double? NastyFactor { get; set; }

        /// <summary>
        /// Gets or Sets StrikeZoneTop
        /// </summary>
        [DataMember(Name = "strikeZoneTop", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikeZoneTop")]
        public double? StrikeZoneTop { get; set; }

        /// <summary>
        /// Gets or Sets StrikeZoneBottom
        /// </summary>
        [DataMember(Name = "strikeZoneBottom", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikeZoneBottom")]
        public double? StrikeZoneBottom { get; set; }

        /// <summary>
        /// Gets or Sets StrikeZoneWidth
        /// </summary>
        [DataMember(Name = "strikeZoneWidth", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikeZoneWidth")]
        public double? StrikeZoneWidth { get; set; }

        /// <summary>
        /// Gets or Sets StrikeZoneDepth
        /// </summary>
        [DataMember(Name = "strikeZoneDepth", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikeZoneDepth")]
        public double? StrikeZoneDepth { get; set; }

        /// <summary>
        /// Gets or Sets GetaX
        /// </summary>
        [DataMember(Name = "getaX", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "getaX")]
        public double? GetaX { get; set; }

        /// <summary>
        /// Gets or Sets GetaY
        /// </summary>
        [DataMember(Name = "getaY", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "getaY")]
        public double? GetaY { get; set; }

        /// <summary>
        /// Gets or Sets GetaZ
        /// </summary>
        [DataMember(Name = "getaZ", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "getaZ")]
        public double? GetaZ { get; set; }

        /// <summary>
        /// Gets or Sets PfxX
        /// </summary>
        [DataMember(Name = "pfxX", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pfxX")]
        public double? PfxX { get; set; }

        /// <summary>
        /// Gets or Sets PfxZ
        /// </summary>
        [DataMember(Name = "pfxZ", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pfxZ")]
        public double? PfxZ { get; set; }

        /// <summary>
        /// Gets or Sets GetpX
        /// </summary>
        [DataMember(Name = "getpX", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "getpX")]
        public double? GetpX { get; set; }

        /// <summary>
        /// Gets or Sets GetpZ
        /// </summary>
        [DataMember(Name = "getpZ", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "getpZ")]
        public double? GetpZ { get; set; }

        /// <summary>
        /// Gets or Sets GetvX0
        /// </summary>
        [DataMember(Name = "getvX0", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "getvX0")]
        public double? GetvX0 { get; set; }

        /// <summary>
        /// Gets or Sets GetvY0
        /// </summary>
        [DataMember(Name = "getvY0", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "getvY0")]
        public double? GetvY0 { get; set; }

        /// <summary>
        /// Gets or Sets GetvZ0
        /// </summary>
        [DataMember(Name = "getvZ0", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "getvZ0")]
        public double? GetvZ0 { get; set; }

        /// <summary>
        /// Gets or Sets X
        /// </summary>
        [DataMember(Name = "x", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "x")]
        public double? X { get; set; }

        /// <summary>
        /// Gets or Sets Y
        /// </summary>
        [DataMember(Name = "y", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "y")]
        public double? Y { get; set; }

        /// <summary>
        /// Gets or Sets Z0
        /// </summary>
        [DataMember(Name = "z0", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "z0")]
        public double? Z0 { get; set; }

        /// <summary>
        /// Gets or Sets Y0
        /// </summary>
        [DataMember(Name = "y0", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "y0")]
        public double? Y0 { get; set; }

        /// <summary>
        /// Gets or Sets X0
        /// </summary>
        [DataMember(Name = "x0", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "x0")]
        public double? X0 { get; set; }

        /// <summary>
        /// Gets or Sets BreakHorizontal
        /// </summary>
        [DataMember(Name = "breakHorizontal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breakHorizontal")]
        public double? BreakHorizontal { get; set; }

        /// <summary>
        /// Gets or Sets BreakVertical
        /// </summary>
        [DataMember(Name = "breakVertical", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breakVertical")]
        public double? BreakVertical { get; set; }

        /// <summary>
        /// Gets or Sets BreakVerticalInduced
        /// </summary>
        [DataMember(Name = "breakVerticalInduced", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breakVerticalInduced")]
        public double? BreakVerticalInduced { get; set; }

        /// <summary>
        /// Gets or Sets BreakAngle
        /// </summary>
        [DataMember(Name = "breakAngle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breakAngle")]
        public double? BreakAngle { get; set; }

        /// <summary>
        /// Gets or Sets BreakLength
        /// </summary>
        [DataMember(Name = "breakLength", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breakLength")]
        public double? BreakLength { get; set; }

        /// <summary>
        /// Gets or Sets BreakX
        /// </summary>
        [DataMember(Name = "breakX", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breakX")]
        public double? BreakX { get; set; }

        /// <summary>
        /// Gets or Sets BreakY
        /// </summary>
        [DataMember(Name = "breakY", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breakY")]
        public double? BreakY { get; set; }

        /// <summary>
        /// Gets or Sets BreakZ
        /// </summary>
        [DataMember(Name = "breakZ", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breakZ")]
        public double? BreakZ { get; set; }

        /// <summary>
        /// Gets or Sets Zone
        /// </summary>
        [DataMember(Name = "zone", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "zone")]
        public int? Zone { get; set; }

        /// <summary>
        /// Gets or Sets SpinRate
        /// </summary>
        [DataMember(Name = "spinRate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "spinRate")]
        public int? SpinRate { get; set; }

        /// <summary>
        /// Gets or Sets SpinDirection
        /// </summary>
        [DataMember(Name = "spinDirection", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "spinDirection")]
        public int? SpinDirection { get; set; }

        /// <summary>
        /// Gets or Sets TypeConfidence
        /// </summary>
        [DataMember(Name = "typeConfidence", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "typeConfidence")]
        public double? TypeConfidence { get; set; }

        /// <summary>
        /// Gets or Sets PlateTime
        /// </summary>
        [DataMember(Name = "plateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "plateTime")]
        public double? PlateTime { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name = "extension", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "extension")]
        public double? Extension { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballPitch {\n");
            sb.Append("  BallColor: ").Append(BallColor).Append("\n");
            sb.Append("  TrailColor: ").Append(TrailColor).Append("\n");
            sb.Append("  StartSpeed: ").Append(StartSpeed).Append("\n");
            sb.Append("  EndSpeed: ").Append(EndSpeed).Append("\n");
            sb.Append("  NastyFactor: ").Append(NastyFactor).Append("\n");
            sb.Append("  StrikeZoneTop: ").Append(StrikeZoneTop).Append("\n");
            sb.Append("  StrikeZoneBottom: ").Append(StrikeZoneBottom).Append("\n");
            sb.Append("  StrikeZoneWidth: ").Append(StrikeZoneWidth).Append("\n");
            sb.Append("  StrikeZoneDepth: ").Append(StrikeZoneDepth).Append("\n");
            sb.Append("  GetaX: ").Append(GetaX).Append("\n");
            sb.Append("  GetaY: ").Append(GetaY).Append("\n");
            sb.Append("  GetaZ: ").Append(GetaZ).Append("\n");
            sb.Append("  PfxX: ").Append(PfxX).Append("\n");
            sb.Append("  PfxZ: ").Append(PfxZ).Append("\n");
            sb.Append("  GetpX: ").Append(GetpX).Append("\n");
            sb.Append("  GetpZ: ").Append(GetpZ).Append("\n");
            sb.Append("  GetvX0: ").Append(GetvX0).Append("\n");
            sb.Append("  GetvY0: ").Append(GetvY0).Append("\n");
            sb.Append("  GetvZ0: ").Append(GetvZ0).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Z0: ").Append(Z0).Append("\n");
            sb.Append("  Y0: ").Append(Y0).Append("\n");
            sb.Append("  X0: ").Append(X0).Append("\n");
            sb.Append("  BreakHorizontal: ").Append(BreakHorizontal).Append("\n");
            sb.Append("  BreakVertical: ").Append(BreakVertical).Append("\n");
            sb.Append("  BreakVerticalInduced: ").Append(BreakVerticalInduced).Append("\n");
            sb.Append("  BreakAngle: ").Append(BreakAngle).Append("\n");
            sb.Append("  BreakLength: ").Append(BreakLength).Append("\n");
            sb.Append("  BreakX: ").Append(BreakX).Append("\n");
            sb.Append("  BreakY: ").Append(BreakY).Append("\n");
            sb.Append("  BreakZ: ").Append(BreakZ).Append("\n");
            sb.Append("  Zone: ").Append(Zone).Append("\n");
            sb.Append("  SpinRate: ").Append(SpinRate).Append("\n");
            sb.Append("  SpinDirection: ").Append(SpinDirection).Append("\n");
            sb.Append("  TypeConfidence: ").Append(TypeConfidence).Append("\n");
            sb.Append("  PlateTime: ").Append(PlateTime).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
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