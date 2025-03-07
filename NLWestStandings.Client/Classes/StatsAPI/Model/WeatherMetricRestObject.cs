using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class WeatherMetricRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// UTC timestamp for atmospheric condition measurements.
        /// </summary>
        /// <value>UTC timestamp for atmospheric condition measurements.</value>
        [DataMember(Name = "timeStamp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeStamp")]
        public string TimeStamp { get; set; }

        /// <summary>
        /// Atmospheric pressure in venue in mm Hg, as measured above the venue.
        /// </summary>
        /// <value>Atmospheric pressure in venue in mm Hg, as measured above the venue.</value>
        [DataMember(Name = "pressure", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pressure")]
        public double? Pressure { get; set; }

        /// <summary>
        /// Relative humidity in venue in %, as measured above the venue.
        /// </summary>
        /// <value>Relative humidity in venue in %, as measured above the venue.</value>
        [DataMember(Name = "relativeHumidity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "relativeHumidity")]
        public double? RelativeHumidity { get; set; }

        /// <summary>
        /// Venue temperature in degrees Fahrenheit.
        /// </summary>
        /// <value>Venue temperature in degrees Fahrenheit.</value>
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
            sb.Append("class WeatherMetricRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  TimeStamp: ").Append(TimeStamp).Append("\n");
            sb.Append("  Pressure: ").Append(Pressure).Append("\n");
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