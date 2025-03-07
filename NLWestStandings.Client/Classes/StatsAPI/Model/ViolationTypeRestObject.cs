using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class ViolationTypeRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets ViolationTypeDesc
        /// </summary>
        [DataMember(Name = "violation_type_desc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "violation_type_desc")]
        public string ViolationTypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets ViolationTypeDesc
        /// </summary>
        //[DataMember(Name = "violationTypeDesc", EmitDefaultValue = false)]
        //[JsonProperty(PropertyName = "violationTypeDesc")]
        //public string ViolationTypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets ViolationTypeCode
        /// </summary>
        [DataMember(Name = "violationTypeCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "violationTypeCode")]
        public string ViolationTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventType")]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or Sets EventTypeCode
        /// </summary>
        [DataMember(Name = "eventTypeCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventTypeCode")]
        public string EventTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name = "parentId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parentId")]
        public int? ParentId { get; set; }

        /// <summary>
        /// Gets or Sets ViolatorCode
        /// </summary>
        [DataMember(Name = "violatorCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "violatorCode")]
        public string ViolatorCode { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViolationTypeRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  ViolationTypeDesc: ").Append(ViolationTypeDesc).Append("\n");
            sb.Append("  ViolationTypeDesc: ").Append(ViolationTypeDesc).Append("\n");
            sb.Append("  ViolationTypeCode: ").Append(ViolationTypeCode).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventTypeCode: ").Append(EventTypeCode).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  ViolatorCode: ").Append(ViolatorCode).Append("\n");
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