using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballDefenseRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Pitcher
        /// </summary>
        [DataMember(Name = "pitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitcher")]
        public BaseballPersonRestObject Pitcher { get; set; }

        /// <summary>
        /// Gets or Sets Catcher
        /// </summary>
        [DataMember(Name = "catcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "catcher")]
        public BaseballPersonRestObject Catcher { get; set; }

        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name = "first", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "first")]
        public BaseballPersonRestObject First { get; set; }

        /// <summary>
        /// Gets or Sets Second
        /// </summary>
        [DataMember(Name = "second", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "second")]
        public BaseballPersonRestObject Second { get; set; }

        /// <summary>
        /// Gets or Sets Third
        /// </summary>
        [DataMember(Name = "third", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "third")]
        public BaseballPersonRestObject Third { get; set; }

        /// <summary>
        /// Gets or Sets Shortstop
        /// </summary>
        [DataMember(Name = "shortstop", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shortstop")]
        public BaseballPersonRestObject Shortstop { get; set; }

        /// <summary>
        /// Gets or Sets Left
        /// </summary>
        [DataMember(Name = "left", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "left")]
        public BaseballPersonRestObject Left { get; set; }

        /// <summary>
        /// Gets or Sets Center
        /// </summary>
        [DataMember(Name = "center", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "center")]
        public BaseballPersonRestObject Center { get; set; }

        /// <summary>
        /// Gets or Sets Right
        /// </summary>
        [DataMember(Name = "right", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "right")]
        public BaseballPersonRestObject Right { get; set; }

        /// <summary>
        /// Gets or Sets Batter
        /// </summary>
        [DataMember(Name = "batter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batter")]
        public BaseballPersonRestObject Batter { get; set; }

        /// <summary>
        /// Gets or Sets OnDeck
        /// </summary>
        [DataMember(Name = "onDeck", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "onDeck")]
        public BaseballPersonRestObject OnDeck { get; set; }

        /// <summary>
        /// Gets or Sets InHole
        /// </summary>
        [DataMember(Name = "inHole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inHole")]
        public BaseballPersonRestObject InHole { get; set; }

        /// <summary>
        /// Gets or Sets BattingOrder
        /// </summary>
        [DataMember(Name = "battingOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "battingOrder")]
        public int? BattingOrder { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeamRestObject Team { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballDefenseRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Pitcher: ").Append(Pitcher).Append("\n");
            sb.Append("  Catcher: ").Append(Catcher).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Second: ").Append(Second).Append("\n");
            sb.Append("  Third: ").Append(Third).Append("\n");
            sb.Append("  Shortstop: ").Append(Shortstop).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Center: ").Append(Center).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  Batter: ").Append(Batter).Append("\n");
            sb.Append("  OnDeck: ").Append(OnDeck).Append("\n");
            sb.Append("  InHole: ").Append(InHole).Append("\n");
            sb.Append("  BattingOrder: ").Append(BattingOrder).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
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