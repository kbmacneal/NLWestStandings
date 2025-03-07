using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Video
    {
        /// <summary>
        /// Gets or Sets PlayId
        /// </summary>
        [DataMember(Name = "playId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playId")]
        public string PlayId { get; set; }

        /// <summary>
        /// Gets or Sets PlaybackGroups
        /// </summary>
        [DataMember(Name = "playbackGroups", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playbackGroups")]
        public JsonNode PlaybackGroups { get; set; }

        /// <summary>
        /// Gets or Sets AtBatNumber
        /// </summary>
        [DataMember(Name = "atBatNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "atBatNumber")]
        public int? AtBatNumber { get; set; }

        /// <summary>
        /// Gets or Sets PitchNumber
        /// </summary>
        [DataMember(Name = "pitchNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchNumber")]
        public int? PitchNumber { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Video {\n");
            sb.Append("  PlayId: ").Append(PlayId).Append("\n");
            sb.Append("  PlaybackGroups: ").Append(PlaybackGroups).Append("\n");
            sb.Append("  AtBatNumber: ").Append(AtBatNumber).Append("\n");
            sb.Append("  PitchNumber: ").Append(PitchNumber).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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