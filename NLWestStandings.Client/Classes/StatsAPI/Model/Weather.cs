using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Weather
    {
        /// <summary>
        /// Gets or Sets WeatherCondition
        /// </summary>
        [DataMember(Name = "weatherCondition", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "weatherCondition")]
        public string WeatherCondition { get; set; }

        /// <summary>
        /// Gets or Sets Temperature
        /// </summary>
        [DataMember(Name = "temperature", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "temperature")]
        public string Temperature { get; set; }

        /// <summary>
        /// Gets or Sets Wind
        /// </summary>
        [DataMember(Name = "wind", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wind")]
        public string Wind { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Weather {\n");
            sb.Append("  WeatherCondition: ").Append(WeatherCondition).Append("\n");
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