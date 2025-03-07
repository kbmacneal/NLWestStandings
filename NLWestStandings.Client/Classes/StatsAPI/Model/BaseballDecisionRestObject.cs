using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballDecisionRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Hydrations
        /// </summary>
        [DataMember(Name = "hydrations", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydrations")]
        public List<string> Hydrations { get; set; }

        /// <summary>
        /// Gets or Sets Winner
        /// </summary>
        [DataMember(Name = "winner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "winner")]
        public BaseballPersonRestObject Winner { get; set; }

        /// <summary>
        /// Gets or Sets Loser
        /// </summary>
        [DataMember(Name = "loser", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "loser")]
        public BaseballPersonRestObject Loser { get; set; }

        /// <summary>
        /// Gets or Sets Save
        /// </summary>
        [DataMember(Name = "save", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "save")]
        public BaseballPersonRestObject Save { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballDecisionRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Hydrations: ").Append(Hydrations).Append("\n");
            sb.Append("  Winner: ").Append(Winner).Append("\n");
            sb.Append("  Loser: ").Append(Loser).Append("\n");
            sb.Append("  Save: ").Append(Save).Append("\n");
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