using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class FilterLevels
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Pitch
        /// </summary>
        [DataMember(Name = "pitch", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitch")]
        public bool? Pitch { get; set; }

        /// <summary>
        /// Gets or Sets AtBat
        /// </summary>
        [DataMember(Name = "atBat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "atBat")]
        public bool? AtBat { get; set; }

        /// <summary>
        /// Gets or Sets Inning
        /// </summary>
        [DataMember(Name = "inning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inning")]
        public bool? Inning { get; set; }

        /// <summary>
        /// Gets or Sets Game
        /// </summary>
        [DataMember(Name = "game", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "game")]
        public bool? Game { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public bool? Season { get; set; }

        /// <summary>
        /// Gets or Sets Career
        /// </summary>
        [DataMember(Name = "career", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "career")]
        public bool? Career { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterLevels {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Pitch: ").Append(Pitch).Append("\n");
            sb.Append("  AtBat: ").Append(AtBat).Append("\n");
            sb.Append("  Inning: ").Append(Inning).Append("\n");
            sb.Append("  Game: ").Append(Game).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Career: ").Append(Career).Append("\n");
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