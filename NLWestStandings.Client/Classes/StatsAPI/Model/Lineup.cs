using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Lineup
    {
        /// <summary>
        /// Gets or Sets HomePlayers
        /// </summary>
        [DataMember(Name = "homePlayers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homePlayers")]
        public JsonNode HomePlayers { get; set; }

        /// <summary>
        /// Gets or Sets AwayPlayers
        /// </summary>
        [DataMember(Name = "awayPlayers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayPlayers")]
        public JsonNode AwayPlayers { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Lineup {\n");
            sb.Append("  HomePlayers: ").Append(HomePlayers).Append("\n");
            sb.Append("  AwayPlayers: ").Append(AwayPlayers).Append("\n");
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