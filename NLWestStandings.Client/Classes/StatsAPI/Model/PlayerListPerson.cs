using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PlayerListPerson
    {
        /// <summary>
        /// Gets or Sets PlayerListId
        /// </summary>
        [DataMember(Name = "playerListId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playerListId")]
        public string PlayerListId { get; set; }

        /// <summary>
        /// Gets or Sets PlayerListName
        /// </summary>
        [DataMember(Name = "playerListName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playerListName")]
        public string PlayerListName { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "player")]
        public BaseballPerson Player { get; set; }

        /// <summary>
        /// Gets or Sets League
        /// </summary>
        [DataMember(Name = "league", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "league")]
        public League League { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeam Team { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "position")]
        public BaseballPosition Position { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayerListPerson {\n");
            sb.Append("  PlayerListId: ").Append(PlayerListId).Append("\n");
            sb.Append("  PlayerListName: ").Append(PlayerListName).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  League: ").Append(League).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
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