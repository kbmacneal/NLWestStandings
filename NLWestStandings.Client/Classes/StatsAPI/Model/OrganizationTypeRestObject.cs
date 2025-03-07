using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class OrganizationTypeRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets OrgTypeId
        /// </summary>
        [DataMember(Name = "orgTypeId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orgTypeId")]
        public int? OrgTypeId { get; set; }

        /// <summary>
        /// Gets or Sets OrgTypeCode
        /// </summary>
        [DataMember(Name = "orgTypeCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orgTypeCode")]
        public string OrgTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets OrgTypeText
        /// </summary>
        [DataMember(Name = "orgTypeText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orgTypeText")]
        public string OrgTypeText { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationTypeRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  OrgTypeId: ").Append(OrgTypeId).Append("\n");
            sb.Append("  OrgTypeCode: ").Append(OrgTypeCode).Append("\n");
            sb.Append("  OrgTypeText: ").Append(OrgTypeText).Append("\n");
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