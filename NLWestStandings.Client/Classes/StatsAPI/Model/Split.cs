using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Split
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Batter
        /// </summary>
        [DataMember(Name = "batter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batter")]
        public string Batter { get; set; }

        /// <summary>
        /// Gets or Sets Pitcher
        /// </summary>
        [DataMember(Name = "pitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitcher")]
        public string Pitcher { get; set; }

        /// <summary>
        /// Gets or Sets MenOnBase
        /// </summary>
        [DataMember(Name = "menOnBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "menOnBase")]
        public string MenOnBase { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Split {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Batter: ").Append(Batter).Append("\n");
            sb.Append("  Pitcher: ").Append(Pitcher).Append("\n");
            sb.Append("  MenOnBase: ").Append(MenOnBase).Append("\n");
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