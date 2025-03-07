using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class LiveLookin
    {
        /// <summary>
        /// Gets or Sets GamePk
        /// </summary>
        [DataMember(Name = "gamePk", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamePk")]
        public int? GamePk { get; set; }

        /// <summary>
        /// Gets or Sets MediaPlaybackId
        /// </summary>
        [DataMember(Name = "mediaPlaybackId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mediaPlaybackId")]
        public long? MediaPlaybackId { get; set; }

        /// <summary>
        /// Gets or Sets Kicker
        /// </summary>
        [DataMember(Name = "kicker", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "kicker")]
        public string Kicker { get; set; }

        /// <summary>
        /// Gets or Sets Headline
        /// </summary>
        [DataMember(Name = "headline", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "headline")]
        public string Headline { get; set; }

        /// <summary>
        /// Gets or Sets Playbacks
        /// </summary>
        [DataMember(Name = "playbacks", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playbacks")]
        public List<LiveLookinPlayback> Playbacks { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveLookin {\n");
            sb.Append("  GamePk: ").Append(GamePk).Append("\n");
            sb.Append("  MediaPlaybackId: ").Append(MediaPlaybackId).Append("\n");
            sb.Append("  Kicker: ").Append(Kicker).Append("\n");
            sb.Append("  Headline: ").Append(Headline).Append("\n");
            sb.Append("  Playbacks: ").Append(Playbacks).Append("\n");
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