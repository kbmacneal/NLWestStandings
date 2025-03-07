using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class CalibrationContainerRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Radar
        /// </summary>
        [DataMember(Name = "radar", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "radar")]
        public CalibrationRestObject Radar { get; set; }

        /// <summary>
        /// Gets or Sets Optical
        /// </summary>
        [DataMember(Name = "optical", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "optical")]
        public CalibrationRestObject Optical { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalibrationContainerRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Radar: ").Append(Radar).Append("\n");
            sb.Append("  Optical: ").Append(Optical).Append("\n");
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