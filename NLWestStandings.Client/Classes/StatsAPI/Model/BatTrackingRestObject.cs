using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BatTrackingRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Units
        /// </summary>
        [DataMember(Name = "units", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "units")]
        public JsonNode Units { get; set; }

        /// <summary>
        /// Unique game identifier.
        /// </summary>
        /// <value>Unique game identifier.</value>
        [DataMember(Name = "gamePk", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamePk")]
        public int? GamePk { get; set; }

        /// <summary>
        /// Unique play identifier (per game).
        /// </summary>
        /// <value>Unique play identifier (per game).</value>
        [DataMember(Name = "playId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playId")]
        public string PlayId { get; set; }

        /// <summary>
        /// Gets or Sets Impact
        /// </summary>
        [DataMember(Name = "impact", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "impact")]
        public BatImpactRestObject Impact { get; set; }

        /// <summary>
        /// Gets or Sets SweetSpot
        /// </summary>
        [DataMember(Name = "sweetSpot", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sweetSpot")]
        public BatSweetSpotRestObject SweetSpot { get; set; }

        /// <summary>
        /// Gets or Sets BatPositions
        /// </summary>
        [DataMember(Name = "batPositions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batPositions")]
        public List<BatPositionRestObject> BatPositions { get; set; }

        /// <summary>
        /// Gets or Sets System
        /// </summary>
        [DataMember(Name = "system", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "system")]
        public BatTrackingSystemRestObject System { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatTrackingRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  GamePk: ").Append(GamePk).Append("\n");
            sb.Append("  PlayId: ").Append(PlayId).Append("\n");
            sb.Append("  Impact: ").Append(Impact).Append("\n");
            sb.Append("  SweetSpot: ").Append(SweetSpot).Append("\n");
            sb.Append("  BatPositions: ").Append(BatPositions).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
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