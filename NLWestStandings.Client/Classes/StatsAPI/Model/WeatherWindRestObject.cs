using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class WeatherWindRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Azimuth direction in degrees from North, of the prevailing wind. wind.direction increases clockwise from North.
        /// </summary>
        /// <value>Azimuth direction in degrees from North, of the prevailing wind. wind.direction increases clockwise from North.</value>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "direction")]
        public double? Direction { get; set; }

        /// <summary>
        /// Peak transient wind speed in mph.
        /// </summary>
        /// <value>Peak transient wind speed in mph.</value>
        [DataMember(Name = "gust", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gust")]
        public double? Gust { get; set; }

        /// <summary>
        /// Prevailing wind speed in mph.
        /// </summary>
        /// <value>Prevailing wind speed in mph.</value>
        [DataMember(Name = "speed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeatherWindRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Gust: ").Append(Gust).Append("\n");
            sb.Append("  Speed: ").Append(Speed).Append("\n");
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