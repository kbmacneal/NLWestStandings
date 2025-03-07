using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class FreeGameTypeRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets FreeGameTypeCode
        /// </summary>
        [DataMember(Name = "freeGameTypeCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "freeGameTypeCode")]
        public string FreeGameTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets FreeGameTypeText
        /// </summary>
        [DataMember(Name = "freeGameTypeText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "freeGameTypeText")]
        public string FreeGameTypeText { get; set; }

        /// <summary>
        /// Gets or Sets FreeGameTypeDesc
        /// </summary>
        [DataMember(Name = "freeGameTypeDesc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "freeGameTypeDesc")]
        public string FreeGameTypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets FreeGameTypeId
        /// </summary>
        [DataMember(Name = "freeGameTypeId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "freeGameTypeId")]
        public int? FreeGameTypeId { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FreeGameTypeRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  FreeGameTypeCode: ").Append(FreeGameTypeCode).Append("\n");
            sb.Append("  FreeGameTypeText: ").Append(FreeGameTypeText).Append("\n");
            sb.Append("  FreeGameTypeDesc: ").Append(FreeGameTypeDesc).Append("\n");
            sb.Append("  FreeGameTypeId: ").Append(FreeGameTypeId).Append("\n");
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