using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballGameFlagRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets NoHitter
        /// </summary>
        [DataMember(Name = "noHitter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "noHitter")]
        public bool? NoHitter { get; set; }

        /// <summary>
        /// Gets or Sets PerfectGame
        /// </summary>
        [DataMember(Name = "perfectGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "perfectGame")]
        public bool? PerfectGame { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeamNoHitter
        /// </summary>
        [DataMember(Name = "awayTeamNoHitter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayTeamNoHitter")]
        public bool? AwayTeamNoHitter { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeamPerfectGame
        /// </summary>
        [DataMember(Name = "awayTeamPerfectGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayTeamPerfectGame")]
        public bool? AwayTeamPerfectGame { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeamNoHitter
        /// </summary>
        [DataMember(Name = "homeTeamNoHitter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeTeamNoHitter")]
        public bool? HomeTeamNoHitter { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeamPerfectGame
        /// </summary>
        [DataMember(Name = "homeTeamPerfectGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeTeamPerfectGame")]
        public bool? HomeTeamPerfectGame { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballGameFlagRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  NoHitter: ").Append(NoHitter).Append("\n");
            sb.Append("  PerfectGame: ").Append(PerfectGame).Append("\n");
            sb.Append("  AwayTeamNoHitter: ").Append(AwayTeamNoHitter).Append("\n");
            sb.Append("  AwayTeamPerfectGame: ").Append(AwayTeamPerfectGame).Append("\n");
            sb.Append("  HomeTeamNoHitter: ").Append(HomeTeamNoHitter).Append("\n");
            sb.Append("  HomeTeamPerfectGame: ").Append(HomeTeamPerfectGame).Append("\n");
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