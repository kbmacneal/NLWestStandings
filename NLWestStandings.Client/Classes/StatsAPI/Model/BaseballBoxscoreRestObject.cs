using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballBoxscoreRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teams")]
        public Dictionary<string, BaseballTeamBoxscore> Teams { get; set; }

        /// <summary>
        /// Gets or Sets Officials
        /// </summary>
        [DataMember(Name = "officials", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "officials")]
        public List<OfficialRestObject> Officials { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name = "info", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "info")]
        public List<BaseballBoxscoreNoteRestObject> Info { get; set; }

        /// <summary>
        /// Gets or Sets PitchingNotes
        /// </summary>
        [DataMember(Name = "pitchingNotes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchingNotes")]
        public List<string> PitchingNotes { get; set; }

        /// <summary>
        /// Gets or Sets TopPerformers
        /// </summary>
        [DataMember(Name = "topPerformers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "topPerformers")]
        public List<BaseballPlayerGameScoreRestObject> TopPerformers { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballBoxscoreRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
            sb.Append("  Officials: ").Append(Officials).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  PitchingNotes: ").Append(PitchingNotes).Append("\n");
            sb.Append("  TopPerformers: ").Append(TopPerformers).Append("\n");
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