using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class GamePacePRPortalRestObject
    {
        /// <summary>
        /// Gets or Sets Total7InnGames
        /// </summary>
        [DataMember(Name = "total7InnGames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total7InnGames")]
        public int? Total7InnGames { get; set; }

        /// <summary>
        /// Gets or Sets Total9InnGames
        /// </summary>
        [DataMember(Name = "total9InnGames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total9InnGames")]
        public int? Total9InnGames { get; set; }

        /// <summary>
        /// Gets or Sets TotalExtraInnGames
        /// </summary>
        [DataMember(Name = "totalExtraInnGames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalExtraInnGames")]
        public int? TotalExtraInnGames { get; set; }

        /// <summary>
        /// Gets or Sets TimePer7InnGame
        /// </summary>
        [DataMember(Name = "timePer7InnGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timePer7InnGame")]
        public Duration TimePer7InnGame { get; set; }

        /// <summary>
        /// Gets or Sets TimePer9InnGame
        /// </summary>
        [DataMember(Name = "timePer9InnGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timePer9InnGame")]
        public Duration TimePer9InnGame { get; set; }

        /// <summary>
        /// Gets or Sets TimePerExtraInnGame
        /// </summary>
        [DataMember(Name = "timePerExtraInnGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timePerExtraInnGame")]
        public Duration TimePerExtraInnGame { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GamePacePRPortalRestObject {\n");
            sb.Append("  Total7InnGames: ").Append(Total7InnGames).Append("\n");
            sb.Append("  Total9InnGames: ").Append(Total9InnGames).Append("\n");
            sb.Append("  TotalExtraInnGames: ").Append(TotalExtraInnGames).Append("\n");
            sb.Append("  TimePer7InnGame: ").Append(TimePer7InnGame).Append("\n");
            sb.Append("  TimePer9InnGame: ").Append(TimePer9InnGame).Append("\n");
            sb.Append("  TimePerExtraInnGame: ").Append(TimePerExtraInnGame).Append("\n");
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