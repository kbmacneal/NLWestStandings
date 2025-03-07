using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class WeatherConditionsRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// The atmospheric temperature below which dew will form.
        /// </summary>
        /// <value>The atmospheric temperature below which dew will form.</value>
        [DataMember(Name = "dewPoint", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dewPoint")]
        public double? DewPoint { get; set; }

        /// <summary>
        /// Gets or Sets AnalysedTimeStamp
        /// </summary>
        [DataMember(Name = "analysedTimeStamp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "analysedTimeStamp")]
        public string AnalysedTimeStamp { get; set; }

        /// <summary>
        /// Atmospheric pressure as measured in venue in mm of Hg.
        /// </summary>
        /// <value>Atmospheric pressure as measured in venue in mm of Hg.</value>
        [DataMember(Name = "pressure", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pressure")]
        public double? Pressure { get; set; }

        /// <summary>
        /// Gets or Sets ObservedTimeStamp
        /// </summary>
        [DataMember(Name = "observedTimeStamp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "observedTimeStamp")]
        public string ObservedTimeStamp { get; set; }

        /// <summary>
        /// Humidity as measured in venue in % relative humidity
        /// </summary>
        /// <value>Humidity as measured in venue in % relative humidity</value>
        [DataMember(Name = "relativeHumidity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "relativeHumidity")]
        public double? RelativeHumidity { get; set; }

        /// <summary>
        /// Gets or Sets Temperature
        /// </summary>
        [DataMember(Name = "temperature", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Gets or Sets Wind
        /// </summary>
        [DataMember(Name = "wind", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wind")]
        public WeatherWindRestObject Wind { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeatherConditionsRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  DewPoint: ").Append(DewPoint).Append("\n");
            sb.Append("  AnalysedTimeStamp: ").Append(AnalysedTimeStamp).Append("\n");
            sb.Append("  Pressure: ").Append(Pressure).Append("\n");
            sb.Append("  ObservedTimeStamp: ").Append(ObservedTimeStamp).Append("\n");
            sb.Append("  RelativeHumidity: ").Append(RelativeHumidity).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  Wind: ").Append(Wind).Append("\n");
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