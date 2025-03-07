using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class WeatherPitchHandRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets PitchHand
        /// </summary>
        [DataMember(Name = "pitchHand", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchHand")]
        public PitchHandTypeRestObject PitchHand { get; set; }

        /// <summary>
        /// Gets or Sets Calm
        /// </summary>
        [DataMember(Name = "calm", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "calm")]
        public WeatherDeviationRestObject Calm { get; set; }

        /// <summary>
        /// Gets or Sets Indoor
        /// </summary>
        [DataMember(Name = "indoor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "indoor")]
        public WeatherDeviationRestObject Indoor { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeatherPitchHandRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  PitchHand: ").Append(PitchHand).Append("\n");
            sb.Append("  Calm: ").Append(Calm).Append("\n");
            sb.Append("  Indoor: ").Append(Indoor).Append("\n");
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