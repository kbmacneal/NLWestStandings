using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class ProspectListRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets TotalSize
        /// </summary>
        [DataMember(Name = "totalSize", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Gets or Sets QueriedSize
        /// </summary>
        [DataMember(Name = "queriedSize", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "queriedSize")]
        public int? QueriedSize { get; set; }

        /// <summary>
        /// Gets or Sets ReturnedSize
        /// </summary>
        [DataMember(Name = "returnedSize", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "returnedSize")]
        public int? ReturnedSize { get; set; }

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Gets or Sets Prospects
        /// </summary>
        [DataMember(Name = "prospects", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "prospects")]
        public List<BaseballDraftProspectRestObject> Prospects { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProspectListRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  TotalSize: ").Append(TotalSize).Append("\n");
            sb.Append("  QueriedSize: ").Append(QueriedSize).Append("\n");
            sb.Append("  ReturnedSize: ").Append(ReturnedSize).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Prospects: ").Append(Prospects).Append("\n");
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