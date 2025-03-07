using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SacFlyProbability
    {
        /// <summary>
        /// Gets or Sets InnerDistance
        /// </summary>
        [DataMember(Name = "innerDistance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "innerDistance")]
        public int? InnerDistance { get; set; }

        /// <summary>
        /// Gets or Sets OuterDistance
        /// </summary>
        [DataMember(Name = "outerDistance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outerDistance")]
        public int? OuterDistance { get; set; }

        /// <summary>
        /// Gets or Sets Fielder
        /// </summary>
        [DataMember(Name = "fielder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fielder")]
        public BaseballPersonRestObject Fielder { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SacFlyProbability {\n");
            sb.Append("  InnerDistance: ").Append(InnerDistance).Append("\n");
            sb.Append("  OuterDistance: ").Append(OuterDistance).Append("\n");
            sb.Append("  Fielder: ").Append(Fielder).Append("\n");
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