using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Editorial
    {
        /// <summary>
        /// Gets or Sets Probables
        /// </summary>
        [DataMember(Name = "probables", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "probables")]
        public JsonNode Probables { get; set; }

        /// <summary>
        /// Gets or Sets Preview
        /// </summary>
        [DataMember(Name = "preview", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "preview")]
        public JsonNode Preview { get; set; }

        /// <summary>
        /// Gets or Sets Recap
        /// </summary>
        [DataMember(Name = "recap", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recap")]
        public JsonNode Recap { get; set; }

        /// <summary>
        /// Gets or Sets Articles
        /// </summary>
        [DataMember(Name = "articles", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "articles")]
        public JsonNode Articles { get; set; }

        /// <summary>
        /// Gets or Sets Wrap
        /// </summary>
        [DataMember(Name = "wrap", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wrap")]
        public JsonNode Wrap { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Editorial {\n");
            sb.Append("  Probables: ").Append(Probables).Append("\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
            sb.Append("  Recap: ").Append(Recap).Append("\n");
            sb.Append("  Articles: ").Append(Articles).Append("\n");
            sb.Append("  Wrap: ").Append(Wrap).Append("\n");
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