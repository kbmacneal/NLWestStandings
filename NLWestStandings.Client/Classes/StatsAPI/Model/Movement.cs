using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Movement
    {
        /// <summary>
        /// Gets or Sets OriginBase
        /// </summary>
        [DataMember(Name = "originBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "originBase")]
        public string OriginBase { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name = "start", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "start")]
        public string Start { get; set; }

        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name = "end", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "end")]
        public string End { get; set; }

        /// <summary>
        /// Gets or Sets OutBase
        /// </summary>
        [DataMember(Name = "outBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outBase")]
        public string OutBase { get; set; }

        /// <summary>
        /// Gets or Sets IsOut
        /// </summary>
        [DataMember(Name = "isOut", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isOut")]
        public bool? IsOut { get; set; }

        /// <summary>
        /// Gets or Sets OutNumber
        /// </summary>
        [DataMember(Name = "outNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outNumber")]
        public int? OutNumber { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Movement {\n");
            sb.Append("  OriginBase: ").Append(OriginBase).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  OutBase: ").Append(OutBase).Append("\n");
            sb.Append("  IsOut: ").Append(IsOut).Append("\n");
            sb.Append("  OutNumber: ").Append(OutNumber).Append("\n");
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