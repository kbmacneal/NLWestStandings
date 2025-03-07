using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class WeatherPitchTypeRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets PitchType
        /// </summary>
        [DataMember(Name = "pitchType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchType")]
        public PitchTypeRestObject PitchType { get; set; }

        /// <summary>
        /// Gets or Sets PitchHands
        /// </summary>
        [DataMember(Name = "pitchHands", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchHands")]
        public List<WeatherPitchHandRestObject> PitchHands { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeatherPitchTypeRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  PitchType: ").Append(PitchType).Append("\n");
            sb.Append("  PitchHands: ").Append(PitchHands).Append("\n");
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