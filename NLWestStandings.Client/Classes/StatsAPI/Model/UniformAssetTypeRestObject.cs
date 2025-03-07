using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class UniformAssetTypeRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets UniformAssetTypeDesc
        /// </summary>
        [DataMember(Name = "uniformAssetTypeDesc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "uniformAssetTypeDesc")]
        public string UniformAssetTypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets UniformAssetTypeCode
        /// </summary>
        [DataMember(Name = "uniformAssetTypeCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "uniformAssetTypeCode")]
        public string UniformAssetTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets UniformAssetTypeText
        /// </summary>
        [DataMember(Name = "uniformAssetTypeText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "uniformAssetTypeText")]
        public string UniformAssetTypeText { get; set; }

        /// <summary>
        /// Gets or Sets UniformAssetTypeId
        /// </summary>
        [DataMember(Name = "uniformAssetTypeId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "uniformAssetTypeId")]
        public int? UniformAssetTypeId { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UniformAssetTypeRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  UniformAssetTypeDesc: ").Append(UniformAssetTypeDesc).Append("\n");
            sb.Append("  UniformAssetTypeCode: ").Append(UniformAssetTypeCode).Append("\n");
            sb.Append("  UniformAssetTypeText: ").Append(UniformAssetTypeText).Append("\n");
            sb.Append("  UniformAssetTypeId: ").Append(UniformAssetTypeId).Append("\n");
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