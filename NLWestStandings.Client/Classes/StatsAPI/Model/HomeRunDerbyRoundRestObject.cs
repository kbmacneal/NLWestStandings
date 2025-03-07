using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class HomeRunDerbyRoundRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Round
        /// </summary>
        [DataMember(Name = "round", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "round")]
        public int? Round { get; set; }

        /// <summary>
        /// Gets or Sets NumBatters
        /// </summary>
        [DataMember(Name = "numBatters", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numBatters")]
        public int? NumBatters { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets RoundTime
        /// </summary>
        [DataMember(Name = "roundTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "roundTime")]
        public int? RoundTime { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfPitches
        /// </summary>
        [DataMember(Name = "numberOfPitches", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numberOfPitches")]
        public int? NumberOfPitches { get; set; }

        /// <summary>
        /// Gets or Sets Matchups
        /// </summary>
        [DataMember(Name = "matchups", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "matchups")]
        public List<HomeRunDerbyMatchupRestObject> Matchups { get; set; }

        /// <summary>
        /// Gets or Sets Batters
        /// </summary>
        [DataMember(Name = "batters", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batters")]
        public List<HomeRunDerbyRoundBatterRestObject> Batters { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HomeRunDerbyRoundRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Round: ").Append(Round).Append("\n");
            sb.Append("  NumBatters: ").Append(NumBatters).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RoundTime: ").Append(RoundTime).Append("\n");
            sb.Append("  NumberOfPitches: ").Append(NumberOfPitches).Append("\n");
            sb.Append("  Matchups: ").Append(Matchups).Append("\n");
            sb.Append("  Batters: ").Append(Batters).Append("\n");
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