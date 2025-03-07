using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class InningRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Num
        /// </summary>
        [DataMember(Name = "num", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "num")]
        public int? Num { get; set; }

        /// <summary>
        /// Gets or Sets OrdinalNum
        /// </summary>
        [DataMember(Name = "ordinalNum", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ordinalNum")]
        public string OrdinalNum { get; set; }

        /// <summary>
        /// Gets or Sets Home
        /// </summary>
        [DataMember(Name = "home", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "home")]
        public InningTeamInfoRestObject Home { get; set; }

        /// <summary>
        /// Gets or Sets Away
        /// </summary>
        [DataMember(Name = "away", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "away")]
        public InningTeamInfoRestObject Away { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InningRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Num: ").Append(Num).Append("\n");
            sb.Append("  OrdinalNum: ").Append(OrdinalNum).Append("\n");
            sb.Append("  Home: ").Append(Home).Append("\n");
            sb.Append("  Away: ").Append(Away).Append("\n");
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