using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class CalibrationRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets CalibrationId
        /// </summary>
        [DataMember(Name = "calibrationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "calibrationId")]
        public string CalibrationId { get; set; }

        /// <summary>
        /// Gets or Sets CalibrationTime
        /// </summary>
        [DataMember(Name = "calibrationTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "calibrationTime")]
        public DateTime? CalibrationTime { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalibrationRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  CalibrationId: ").Append(CalibrationId).Append("\n");
            sb.Append("  CalibrationTime: ").Append(CalibrationTime).Append("\n");
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