using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class WeatherPlayRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets HitSegmentActual
        /// </summary>
        [DataMember(Name = "hitSegmentActual", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitSegmentActual")]
        public WeatherHitSegmentActual HitSegmentActual { get; set; }

        /// <summary>
        /// Gets or Sets HitSegmentCalm
        /// </summary>
        [DataMember(Name = "hitSegmentCalm", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitSegmentCalm")]
        public WeatherHitSegmentCalm HitSegmentCalm { get; set; }

        /// <summary>
        /// Gets or Sets HitSegmentIndoor
        /// </summary>
        [DataMember(Name = "hitSegmentIndoor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitSegmentIndoor")]
        public WeatherHitSegmentRestObject HitSegmentIndoor { get; set; }

        /// <summary>
        /// Gets or Sets PitchSegmentActual
        /// </summary>
        [DataMember(Name = "pitchSegmentActual", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchSegmentActual")]
        public WeatherPitchSegmentActual PitchSegmentActual { get; set; }

        /// <summary>
        /// Gets or Sets PitchSegmentCalm
        /// </summary>
        [DataMember(Name = "pitchSegmentCalm", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchSegmentCalm")]
        public WeatherPitchSegmentCalm PitchSegmentCalm { get; set; }

        /// <summary>
        /// Gets or Sets PitchSegmentIndoor
        /// </summary>
        [DataMember(Name = "pitchSegmentIndoor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchSegmentIndoor")]
        public WeatherPitchSegmentRestObject PitchSegmentIndoor { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeatherPlayRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  HitSegmentActual: ").Append(HitSegmentActual).Append("\n");
            sb.Append("  HitSegmentCalm: ").Append(HitSegmentCalm).Append("\n");
            sb.Append("  HitSegmentIndoor: ").Append(HitSegmentIndoor).Append("\n");
            sb.Append("  PitchSegmentActual: ").Append(PitchSegmentActual).Append("\n");
            sb.Append("  PitchSegmentCalm: ").Append(PitchSegmentCalm).Append("\n");
            sb.Append("  PitchSegmentIndoor: ").Append(PitchSegmentIndoor).Append("\n");
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