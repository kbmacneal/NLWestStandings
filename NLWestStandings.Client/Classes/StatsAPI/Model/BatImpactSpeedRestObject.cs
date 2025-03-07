using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BatImpactSpeedRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Speed of impact point right before contact.
        /// </summary>
        /// <value>Speed of impact point right before contact.</value>
        [DataMember(Name = "before", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "before")]
        public double? Before { get; set; }

        /// <summary>
        /// Speed of impact point right after contact.
        /// </summary>
        /// <value>Speed of impact point right after contact.</value>
        [DataMember(Name = "after", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "after")]
        public double? After { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatImpactSpeedRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Before: ").Append(Before).Append("\n");
            sb.Append("  After: ").Append(After).Append("\n");
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