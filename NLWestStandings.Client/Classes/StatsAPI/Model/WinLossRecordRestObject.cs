using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class WinLossRecordRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Wins
        /// </summary>
        [DataMember(Name = "wins", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wins")]
        public int? Wins { get; set; }

        /// <summary>
        /// Gets or Sets Losses
        /// </summary>
        [DataMember(Name = "losses", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "losses")]
        public int? Losses { get; set; }

        /// <summary>
        /// Gets or Sets Ties
        /// </summary>
        [DataMember(Name = "ties", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ties")]
        public int? Ties { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Pct
        /// </summary>
        [DataMember(Name = "pct", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pct")]
        public string Pct { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WinLossRecordRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Wins: ").Append(Wins).Append("\n");
            sb.Append("  Losses: ").Append(Losses).Append("\n");
            sb.Append("  Ties: ").Append(Ties).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Pct: ").Append(Pct).Append("\n");
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