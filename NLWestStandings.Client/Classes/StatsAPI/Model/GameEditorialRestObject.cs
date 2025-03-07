using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class GameEditorialRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Preview
        /// </summary>
        [DataMember(Name = "preview", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "preview")]
        public JsonNode Preview { get; set; }

        /// <summary>
        /// Gets or Sets Articles
        /// </summary>
        [DataMember(Name = "articles", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "articles")]
        public JsonNode Articles { get; set; }

        /// <summary>
        /// Gets or Sets Recap
        /// </summary>
        [DataMember(Name = "recap", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recap")]
        public JsonNode Recap { get; set; }

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
            sb.Append("class GameEditorialRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
            sb.Append("  Articles: ").Append(Articles).Append("\n");
            sb.Append("  Recap: ").Append(Recap).Append("\n");
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