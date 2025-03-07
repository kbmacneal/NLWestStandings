using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class VideoResolutionEnumRestObject
    {
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets ResolutionShort
        /// </summary>
        [DataMember(Name = "resolutionShort", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resolutionShort")]
        public string ResolutionShort { get; set; }

        /// <summary>
        /// Gets or Sets ResolutionFull
        /// </summary>
        [DataMember(Name = "resolutionFull", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resolutionFull")]
        public string ResolutionFull { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoResolutionEnumRestObject {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ResolutionShort: ").Append(ResolutionShort).Append("\n");
            sb.Append("  ResolutionFull: ").Append(ResolutionFull).Append("\n");
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