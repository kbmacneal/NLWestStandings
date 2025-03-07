using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Matchup
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Batter
        /// </summary>
        [DataMember(Name = "batter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batter")]
        public BaseballPersonRestObject Batter { get; set; }

        /// <summary>
        /// Gets or Sets BatSide
        /// </summary>
        [DataMember(Name = "batSide", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batSide")]
        public DynamicEnumRestObject BatSide { get; set; }

        /// <summary>
        /// Gets or Sets Pitcher
        /// </summary>
        [DataMember(Name = "pitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitcher")]
        public BaseballPersonRestObject Pitcher { get; set; }

        /// <summary>
        /// Gets or Sets PitchHand
        /// </summary>
        [DataMember(Name = "pitchHand", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchHand")]
        public DynamicEnumRestObject PitchHand { get; set; }

        /// <summary>
        /// Gets or Sets PostOnFirst
        /// </summary>
        [DataMember(Name = "postOnFirst", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postOnFirst")]
        public BaseballPersonRestObject PostOnFirst { get; set; }

        /// <summary>
        /// Gets or Sets PostOnSecond
        /// </summary>
        [DataMember(Name = "postOnSecond", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postOnSecond")]
        public BaseballPersonRestObject PostOnSecond { get; set; }

        /// <summary>
        /// Gets or Sets PostOnThird
        /// </summary>
        [DataMember(Name = "postOnThird", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postOnThird")]
        public BaseballPersonRestObject PostOnThird { get; set; }

        /// <summary>
        /// Gets or Sets BatterHotColdZoneStats
        /// </summary>
        [DataMember(Name = "batterHotColdZoneStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batterHotColdZoneStats")]
        public StatsRestObject BatterHotColdZoneStats { get; set; }

        /// <summary>
        /// Gets or Sets PitcherHotColdZoneStats
        /// </summary>
        [DataMember(Name = "pitcherHotColdZoneStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitcherHotColdZoneStats")]
        public StatsRestObject PitcherHotColdZoneStats { get; set; }

        /// <summary>
        /// Gets or Sets BatterHotColdZones
        /// </summary>
        [DataMember(Name = "batterHotColdZones", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batterHotColdZones")]
        public List<BaseballHotColdZoneRestObject> BatterHotColdZones { get; set; }

        /// <summary>
        /// Gets or Sets PitcherHotColdZones
        /// </summary>
        [DataMember(Name = "pitcherHotColdZones", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitcherHotColdZones")]
        public List<BaseballHotColdZoneRestObject> PitcherHotColdZones { get; set; }

        /// <summary>
        /// Gets or Sets Splits
        /// </summary>
        [DataMember(Name = "splits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "splits")]
        public Split Splits { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Matchup {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Batter: ").Append(Batter).Append("\n");
            sb.Append("  BatSide: ").Append(BatSide).Append("\n");
            sb.Append("  Pitcher: ").Append(Pitcher).Append("\n");
            sb.Append("  PitchHand: ").Append(PitchHand).Append("\n");
            sb.Append("  PostOnFirst: ").Append(PostOnFirst).Append("\n");
            sb.Append("  PostOnSecond: ").Append(PostOnSecond).Append("\n");
            sb.Append("  PostOnThird: ").Append(PostOnThird).Append("\n");
            sb.Append("  BatterHotColdZoneStats: ").Append(BatterHotColdZoneStats).Append("\n");
            sb.Append("  PitcherHotColdZoneStats: ").Append(PitcherHotColdZoneStats).Append("\n");
            sb.Append("  BatterHotColdZones: ").Append(BatterHotColdZones).Append("\n");
            sb.Append("  PitcherHotColdZones: ").Append(PitcherHotColdZones).Append("\n");
            sb.Append("  Splits: ").Append(Splits).Append("\n");
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