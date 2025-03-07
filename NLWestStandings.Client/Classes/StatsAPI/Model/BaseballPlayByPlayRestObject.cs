using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballPlayByPlayRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets AllPlays
        /// </summary>
        [DataMember(Name = "allPlays", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "allPlays")]
        public List<BaseballPlayRestObject> AllPlays { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPlay
        /// </summary>
        [DataMember(Name = "currentPlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentPlay")]
        public BaseballPlayRestObject CurrentPlay { get; set; }

        /// <summary>
        /// Gets or Sets ScoringPlays
        /// </summary>
        [DataMember(Name = "scoringPlays", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scoringPlays")]
        public List<int?> ScoringPlays { get; set; }

        /// <summary>
        /// Gets or Sets PlaysByInning
        /// </summary>
        [DataMember(Name = "playsByInning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playsByInning")]
        public List<InningPlay> PlaysByInning { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballPlayByPlayRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  AllPlays: ").Append(AllPlays).Append("\n");
            sb.Append("  CurrentPlay: ").Append(CurrentPlay).Append("\n");
            sb.Append("  ScoringPlays: ").Append(ScoringPlays).Append("\n");
            sb.Append("  PlaysByInning: ").Append(PlaysByInning).Append("\n");
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