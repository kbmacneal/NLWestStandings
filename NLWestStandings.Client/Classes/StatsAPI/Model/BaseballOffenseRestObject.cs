using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballOffenseRestObject
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
        /// Gets or Sets Pitcher
        /// </summary>
        [DataMember(Name = "pitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitcher")]
        public BaseballPersonRestObject Pitcher { get; set; }

        /// <summary>
        /// Gets or Sets BatterPosition
        /// </summary>
        [DataMember(Name = "batterPosition", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batterPosition")]
        public PositionRestObject BatterPosition { get; set; }

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
            sb.Append("class BaseballOffenseRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Batter: ").Append(Batter).Append("\n");
            sb.Append("  OnDeck: ").Append(OnDeck).Append("\n");
            sb.Append("  InHole: ").Append(InHole).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Second: ").Append(Second).Append("\n");
            sb.Append("  Third: ").Append(Third).Append("\n");
            sb.Append("  PostOnFirst: ").Append(PostOnFirst).Append("\n");
            sb.Append("  PostOnSecond: ").Append(PostOnSecond).Append("\n");
            sb.Append("  PostOnThird: ").Append(PostOnThird).Append("\n");
            sb.Append("  Pitcher: ").Append(Pitcher).Append("\n");
            sb.Append("  BatterPosition: ").Append(BatterPosition).Append("\n");
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