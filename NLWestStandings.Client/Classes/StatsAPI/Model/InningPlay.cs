using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class InningPlay
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets StartIndex
        /// </summary>
        [DataMember(Name = "startIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startIndex")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// Gets or Sets EndIndex
        /// </summary>
        [DataMember(Name = "endIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endIndex")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Gets or Sets Top
        /// </summary>
        [DataMember(Name = "top", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "top")]
        public List<int?> Top { get; set; }

        /// <summary>
        /// Gets or Sets Bottom
        /// </summary>
        [DataMember(Name = "bottom", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bottom")]
        public List<int?> Bottom { get; set; }

        /// <summary>
        /// Gets or Sets Hits
        /// </summary>
        [DataMember(Name = "hits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hits")]
        public InningHitWrap Hits { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InningPlay {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  EndIndex: ").Append(EndIndex).Append("\n");
            sb.Append("  Top: ").Append(Top).Append("\n");
            sb.Append("  Bottom: ").Append(Bottom).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
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