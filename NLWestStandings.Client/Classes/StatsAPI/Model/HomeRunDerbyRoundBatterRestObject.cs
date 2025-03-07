using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class HomeRunDerbyRoundBatterRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Started
        /// </summary>
        [DataMember(Name = "started", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "started")]
        public bool? Started { get; set; }

        /// <summary>
        /// Gets or Sets Complete
        /// </summary>
        [DataMember(Name = "complete", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "complete")]
        public bool? Complete { get; set; }

        /// <summary>
        /// Gets or Sets Winner
        /// </summary>
        [DataMember(Name = "winner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "winner")]
        public bool? Winner { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "player")]
        public BaseballPersonRestObject Player { get; set; }

        /// <summary>
        /// Gets or Sets TopDerbyHitData
        /// </summary>
        [DataMember(Name = "topDerbyHitData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "topDerbyHitData")]
        public BaseballHitDataRestObject TopDerbyHitData { get; set; }

        /// <summary>
        /// Gets or Sets Hits
        /// </summary>
        [DataMember(Name = "hits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hits")]
        public List<HomeRunDerbyBatterHitRestObject> Hits { get; set; }

        /// <summary>
        /// Gets or Sets Seed
        /// </summary>
        [DataMember(Name = "seed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "order")]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or Sets IsWinner
        /// </summary>
        [DataMember(Name = "isWinner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isWinner")]
        public bool? IsWinner { get; set; }

        /// <summary>
        /// Gets or Sets IsComplete
        /// </summary>
        [DataMember(Name = "isComplete", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isComplete")]
        public bool? IsComplete { get; set; }

        /// <summary>
        /// Gets or Sets IsStarted
        /// </summary>
        [DataMember(Name = "isStarted", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isStarted")]
        public bool? IsStarted { get; set; }

        /// <summary>
        /// Gets or Sets NumHomeRuns
        /// </summary>
        [DataMember(Name = "numHomeRuns", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numHomeRuns")]
        public int? NumHomeRuns { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HomeRunDerbyRoundBatterRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Started: ").Append(Started).Append("\n");
            sb.Append("  Complete: ").Append(Complete).Append("\n");
            sb.Append("  Winner: ").Append(Winner).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  TopDerbyHitData: ").Append(TopDerbyHitData).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
            sb.Append("  Seed: ").Append(Seed).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  IsWinner: ").Append(IsWinner).Append("\n");
            sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
            sb.Append("  IsStarted: ").Append(IsStarted).Append("\n");
            sb.Append("  NumHomeRuns: ").Append(NumHomeRuns).Append("\n");
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