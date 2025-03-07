using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PersonStatGroupRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Person
        /// </summary>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "person")]
        public string Person { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryStatGroups
        /// </summary>
        [DataMember(Name = "primaryStatGroups", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "primaryStatGroups")]
        public StatSearchStatGroupRestObject PrimaryStatGroups { get; set; }

        /// <summary>
        /// Gets or Sets SupportedStatGroups
        /// </summary>
        [DataMember(Name = "supportedStatGroups", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "supportedStatGroups")]
        public StatSearchStatGroupRestObject SupportedStatGroups { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonStatGroupRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  PrimaryStatGroups: ").Append(PrimaryStatGroups).Append("\n");
            sb.Append("  SupportedStatGroups: ").Append(SupportedStatGroups).Append("\n");
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