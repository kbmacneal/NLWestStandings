using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class MediaStateRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets MediaStateId
        /// </summary>
        [DataMember(Name = "mediaStateId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mediaStateId")]
        public int? MediaStateId { get; set; }

        /// <summary>
        /// Gets or Sets MediaStateCode
        /// </summary>
        [DataMember(Name = "mediaStateCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mediaStateCode")]
        public string MediaStateCode { get; set; }

        /// <summary>
        /// Gets or Sets MediaStateText
        /// </summary>
        [DataMember(Name = "mediaStateText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mediaStateText")]
        public string MediaStateText { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaStateRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  MediaStateId: ").Append(MediaStateId).Append("\n");
            sb.Append("  MediaStateCode: ").Append(MediaStateCode).Append("\n");
            sb.Append("  MediaStateText: ").Append(MediaStateText).Append("\n");
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