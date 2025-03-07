using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PlayCredit
    {
        /// <summary>
        /// Gets or Sets Person
        /// </summary>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "person")]
        public BaseballPerson Person { get; set; }

        /// <summary>
        /// Gets or Sets Credit
        /// </summary>
        [DataMember(Name = "credit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "credit")]
        public string Credit { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "position")]
        public BaseballPosition Position { get; set; }

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "detail")]
        public GameEventDetailTO Detail { get; set; }

        /// <summary>
        /// Gets or Sets FielderStat
        /// </summary>
        [DataMember(Name = "fielderStat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fielderStat")]
        public FielderDetailType FielderStat { get; set; }

        /// <summary>
        /// Gets or Sets BatterStat
        /// </summary>
        [DataMember(Name = "batterStat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batterStat")]
        public BatterDetailType BatterStat { get; set; }

        /// <summary>
        /// Gets or Sets PitcherStat
        /// </summary>
        [DataMember(Name = "pitcherStat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitcherStat")]
        public PitcherDetailType PitcherStat { get; set; }

        /// <summary>
        /// Gets or Sets RunnerStat
        /// </summary>
        [DataMember(Name = "runnerStat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerStat")]
        public RunnerDetailType RunnerStat { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayCredit {\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  FielderStat: ").Append(FielderStat).Append("\n");
            sb.Append("  BatterStat: ").Append(BatterStat).Append("\n");
            sb.Append("  PitcherStat: ").Append(PitcherStat).Append("\n");
            sb.Append("  RunnerStat: ").Append(RunnerStat).Append("\n");
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