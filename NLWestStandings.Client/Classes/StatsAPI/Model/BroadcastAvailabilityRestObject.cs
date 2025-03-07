using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BroadcastAvailabilityRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets AvailabilityId
        /// </summary>
        [DataMember(Name = "availabilityId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "availabilityId")]
        public int? AvailabilityId { get; set; }

        /// <summary>
        /// Gets or Sets AvailabilityCode
        /// </summary>
        [DataMember(Name = "availabilityCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "availabilityCode")]
        public string AvailabilityCode { get; set; }

        /// <summary>
        /// Gets or Sets AvailabilityText
        /// </summary>
        [DataMember(Name = "availabilityText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "availabilityText")]
        public string AvailabilityText { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BroadcastAvailabilityRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  AvailabilityId: ").Append(AvailabilityId).Append("\n");
            sb.Append("  AvailabilityCode: ").Append(AvailabilityCode).Append("\n");
            sb.Append("  AvailabilityText: ").Append(AvailabilityText).Append("\n");
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