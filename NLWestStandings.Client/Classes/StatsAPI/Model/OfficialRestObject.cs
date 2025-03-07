using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class OfficialRestObject
    {
        /// <summary>
        /// Gets or Sets Official
        /// </summary>
        [DataMember(Name = "official", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "official")]
        public BaseballPersonRestObject Official { get; set; }

        /// <summary>
        /// Gets or Sets OfficialType
        /// </summary>
        [DataMember(Name = "officialType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "officialType")]
        public string OfficialType { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfficialRestObject {\n");
            sb.Append("  Official: ").Append(Official).Append("\n");
            sb.Append("  OfficialType: ").Append(OfficialType).Append("\n");
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