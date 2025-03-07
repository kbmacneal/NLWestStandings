using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballGameFlag
    {
        /// <summary>
        /// Gets or Sets IsNoHitter
        /// </summary>
        [DataMember(Name = "isNoHitter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isNoHitter")]
        public bool? IsNoHitter { get; set; }

        /// <summary>
        /// Gets or Sets IsPerfectGame
        /// </summary>
        [DataMember(Name = "isPerfectGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPerfectGame")]
        public bool? IsPerfectGame { get; set; }

        /// <summary>
        /// Gets or Sets IsAwayTeamNoHitter
        /// </summary>
        [DataMember(Name = "isAwayTeamNoHitter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isAwayTeamNoHitter")]
        public bool? IsAwayTeamNoHitter { get; set; }

        /// <summary>
        /// Gets or Sets IsAwayTeamPerfectGame
        /// </summary>
        [DataMember(Name = "isAwayTeamPerfectGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isAwayTeamPerfectGame")]
        public bool? IsAwayTeamPerfectGame { get; set; }

        /// <summary>
        /// Gets or Sets IsHomeTeamNoHitter
        /// </summary>
        [DataMember(Name = "isHomeTeamNoHitter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isHomeTeamNoHitter")]
        public bool? IsHomeTeamNoHitter { get; set; }

        /// <summary>
        /// Gets or Sets IsHomeTeamPerfectGame
        /// </summary>
        [DataMember(Name = "isHomeTeamPerfectGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isHomeTeamPerfectGame")]
        public bool? IsHomeTeamPerfectGame { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeamNoHitter
        /// </summary>
        [DataMember(Name = "awayTeamNoHitter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayTeamNoHitter")]
        public bool? AwayTeamNoHitter { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeamNoHitter
        /// </summary>
        [DataMember(Name = "homeTeamNoHitter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeTeamNoHitter")]
        public bool? HomeTeamNoHitter { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeamPerfectGame
        /// </summary>
        [DataMember(Name = "awayTeamPerfectGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayTeamPerfectGame")]
        public bool? AwayTeamPerfectGame { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeamPerfectGame
        /// </summary>
        [DataMember(Name = "homeTeamPerfectGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeTeamPerfectGame")]
        public bool? HomeTeamPerfectGame { get; set; }

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
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballGameFlag {\n");
            sb.Append("  IsNoHitter: ").Append(IsNoHitter).Append("\n");
            sb.Append("  IsPerfectGame: ").Append(IsPerfectGame).Append("\n");
            sb.Append("  IsAwayTeamNoHitter: ").Append(IsAwayTeamNoHitter).Append("\n");
            sb.Append("  IsAwayTeamPerfectGame: ").Append(IsAwayTeamPerfectGame).Append("\n");
            sb.Append("  IsHomeTeamNoHitter: ").Append(IsHomeTeamNoHitter).Append("\n");
            sb.Append("  IsHomeTeamPerfectGame: ").Append(IsHomeTeamPerfectGame).Append("\n");
            sb.Append("  AwayTeamNoHitter: ").Append(AwayTeamNoHitter).Append("\n");
            sb.Append("  HomeTeamNoHitter: ").Append(HomeTeamNoHitter).Append("\n");
            sb.Append("  AwayTeamPerfectGame: ").Append(AwayTeamPerfectGame).Append("\n");
            sb.Append("  HomeTeamPerfectGame: ").Append(HomeTeamPerfectGame).Append("\n");
            sb.Append("  NoHitter: ").Append(NoHitter).Append("\n");
            sb.Append("  PerfectGame: ").Append(PerfectGame).Append("\n");
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