using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class AwardWinner
    {
        /// <summary>
        /// Gets or Sets AwardId
        /// </summary>
        [DataMember(Name = "awardId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awardId")]
        public int? AwardId { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name = "teamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamId")]
        public int? TeamId { get; set; }

        /// <summary>
        /// Gets or Sets CoachId
        /// </summary>
        [DataMember(Name = "coachId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "coachId")]
        public int? CoachId { get; set; }

        /// <summary>
        /// Gets or Sets PlayerId
        /// </summary>
        [DataMember(Name = "playerId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playerId")]
        public int? PlayerId { get; set; }

        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rank")]
        public string Rank { get; set; }

        /// <summary>
        /// Gets or Sets Person
        /// </summary>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "person")]
        public BaseballPerson Person { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "player")]
        public BaseballPerson Player { get; set; }

        /// <summary>
        /// Gets or Sets Coach
        /// </summary>
        [DataMember(Name = "coach", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "coach")]
        public BaseballPerson Coach { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeam Team { get; set; }

        /// <summary>
        /// Gets or Sets AwardDate
        /// </summary>
        [DataMember(Name = "awardDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awardDate")]
        public DateTime? AwardDate { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or Sets Empty
        /// </summary>
        [DataMember(Name = "empty", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "empty")]
        public bool? Empty { get; set; }

        /// <summary>
        /// Gets or Sets NotEmpty
        /// </summary>
        [DataMember(Name = "notEmpty", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "notEmpty")]
        public bool? NotEmpty { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AwardWinner {\n");
            sb.Append("  AwardId: ").Append(AwardId).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  CoachId: ").Append(CoachId).Append("\n");
            sb.Append("  PlayerId: ").Append(PlayerId).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Coach: ").Append(Coach).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  AwardDate: ").Append(AwardDate).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Empty: ").Append(Empty).Append("\n");
            sb.Append("  NotEmpty: ").Append(NotEmpty).Append("\n");
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