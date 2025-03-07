using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class XrefIdRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets XrefId
        /// </summary>
        [DataMember(Name = "xrefId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "xrefId")]
        public string XrefId { get; set; }

        /// <summary>
        /// Gets or Sets XrefType
        /// </summary>
        [DataMember(Name = "xrefType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "xrefType")]
        public string XrefType { get; set; }

        /// <summary>
        /// Gets or Sets XrefIdTwo
        /// </summary>
        [DataMember(Name = "xrefIdTwo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "xrefIdTwo")]
        public string XrefIdTwo { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XrefIdRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  XrefId: ").Append(XrefId).Append("\n");
            sb.Append("  XrefType: ").Append(XrefType).Append("\n");
            sb.Append("  XrefIdTwo: ").Append(XrefIdTwo).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
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