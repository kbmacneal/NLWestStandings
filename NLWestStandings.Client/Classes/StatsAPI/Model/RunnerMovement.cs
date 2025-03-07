using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class RunnerMovement
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Movement
        /// </summary>
        [DataMember(Name = "movement", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "movement")]
        public Movement Movement { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "details")]
        public Details Details { get; set; }

        /// <summary>
        /// Gets or Sets Credits
        /// </summary>
        [DataMember(Name = "credits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "credits")]
        public List<PlayCreditRestObject> Credits { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunnerMovement {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Movement: ").Append(Movement).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
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