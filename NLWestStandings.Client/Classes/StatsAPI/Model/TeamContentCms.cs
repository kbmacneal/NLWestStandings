using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class TeamContentCms
    {
        /// <summary>
        /// Gets or Sets Home
        /// </summary>
        [DataMember(Name = "home", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "home")]
        public JsonNode Home { get; set; }

        /// <summary>
        /// Gets or Sets Sections
        /// </summary>
        [DataMember(Name = "sections", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sections")]
        public JsonNode Sections { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamContentCms {\n");
            sb.Append("  Home: ").Append(Home).Append("\n");
            sb.Append("  Sections: ").Append(Sections).Append("\n");
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