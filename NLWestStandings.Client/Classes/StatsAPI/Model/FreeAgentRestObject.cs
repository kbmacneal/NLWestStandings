using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class FreeAgentRestObject
    {
        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "player")]
        public BaseballPersonRestObject Player { get; set; }

        /// <summary>
        /// Gets or Sets OriginalTeam
        /// </summary>
        [DataMember(Name = "originalTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "originalTeam")]
        public BaseballTeamRestObject OriginalTeam { get; set; }

        /// <summary>
        /// Gets or Sets NewTeam
        /// </summary>
        [DataMember(Name = "newTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "newTeam")]
        public BaseballTeamRestObject NewTeam { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets DateSigned
        /// </summary>
        [DataMember(Name = "dateSigned", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dateSigned")]
        public DateTime? DateSigned { get; set; }

        /// <summary>
        /// Gets or Sets DateDeclared
        /// </summary>
        [DataMember(Name = "dateDeclared", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dateDeclared")]
        public DateTime? DateDeclared { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "position")]
        public PositionRestObject Position { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FreeAgentRestObject {\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  OriginalTeam: ").Append(OriginalTeam).Append("\n");
            sb.Append("  NewTeam: ").Append(NewTeam).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  DateSigned: ").Append(DateSigned).Append("\n");
            sb.Append("  DateDeclared: ").Append(DateDeclared).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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