using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballPitchDataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

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
        /// Gets or Sets Coordinates
        /// </summary>
        [DataMember(Name = "coordinates", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "coordinates")]
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Gets or Sets Breaks
        /// </summary>
        [DataMember(Name = "breaks", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "breaks")]
        public Breaks Breaks { get; set; }

        /// <summary>
        /// Gets or Sets Zone
        /// </summary>
        [DataMember(Name = "zone", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "zone")]
        public int? Zone { get; set; }

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
            sb.Append("class BaseballPitchDataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  StartSpeed: ").Append(StartSpeed).Append("\n");
            sb.Append("  EndSpeed: ").Append(EndSpeed).Append("\n");
            sb.Append("  NastyFactor: ").Append(NastyFactor).Append("\n");
            sb.Append("  StrikeZoneTop: ").Append(StrikeZoneTop).Append("\n");
            sb.Append("  StrikeZoneBottom: ").Append(StrikeZoneBottom).Append("\n");
            sb.Append("  StrikeZoneWidth: ").Append(StrikeZoneWidth).Append("\n");
            sb.Append("  StrikeZoneDepth: ").Append(StrikeZoneDepth).Append("\n");
            sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
            sb.Append("  Breaks: ").Append(Breaks).Append("\n");
            sb.Append("  Zone: ").Append(Zone).Append("\n");
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