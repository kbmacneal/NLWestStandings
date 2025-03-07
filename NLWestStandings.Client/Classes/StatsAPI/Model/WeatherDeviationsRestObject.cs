using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class WeatherDeviationsRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Hit
        /// </summary>
        [DataMember(Name = "hit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hit")]
        public WeatherHitRestObject Hit { get; set; }

        /// <summary>
        /// Gets or Sets Pitch
        /// </summary>
        [DataMember(Name = "pitch", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitch")]
        public WeatherPitchRestObject Pitch { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeatherDeviationsRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Hit: ").Append(Hit).Append("\n");
            sb.Append("  Pitch: ").Append(Pitch).Append("\n");
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