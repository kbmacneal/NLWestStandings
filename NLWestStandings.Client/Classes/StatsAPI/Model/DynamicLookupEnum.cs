using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class DynamicLookupEnum
    {
        /// <summary>
        /// Gets or Sets LookupType
        /// </summary>
        [DataMember(Name = "lookupType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lookupType")]
        public string LookupType { get; set; }

        /// <summary>
        /// Gets or Sets LookupKey
        /// </summary>
        [DataMember(Name = "lookupKey", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lookupKey")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DynamicLookupEnum {\n");
            sb.Append("  LookupType: ").Append(LookupType).Append("\n");
            sb.Append("  LookupKey: ").Append(LookupKey).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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