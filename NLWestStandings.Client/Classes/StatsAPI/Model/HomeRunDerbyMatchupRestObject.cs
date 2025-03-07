using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class HomeRunDerbyMatchupRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets TopSeed
        /// </summary>
        [DataMember(Name = "topSeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "topSeed")]
        public HomeRunDerbyRoundBatterRestObject TopSeed { get; set; }

        /// <summary>
        /// Gets or Sets BottomSeed
        /// </summary>
        [DataMember(Name = "bottomSeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bottomSeed")]
        public HomeRunDerbyRoundBatterRestObject BottomSeed { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HomeRunDerbyMatchupRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  TopSeed: ").Append(TopSeed).Append("\n");
            sb.Append("  BottomSeed: ").Append(BottomSeed).Append("\n");
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