using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class RunnerSequenceRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets PositionId
        /// </summary>
        [DataMember(Name = "positionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "positionId")]
        public int? PositionId { get; set; }

        /// <summary>
        /// Gets or Sets StartBase
        /// </summary>
        [DataMember(Name = "startBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startBase")]
        public int? StartBase { get; set; }

        /// <summary>
        /// Gets or Sets EndBase
        /// </summary>
        [DataMember(Name = "endBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endBase")]
        public int? EndBase { get; set; }

        /// <summary>
        /// Gets or Sets IsOut
        /// </summary>
        [DataMember(Name = "isOut", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isOut")]
        public bool? IsOut { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunnerSequenceRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  PositionId: ").Append(PositionId).Append("\n");
            sb.Append("  StartBase: ").Append(StartBase).Append("\n");
            sb.Append("  EndBase: ").Append(EndBase).Append("\n");
            sb.Append("  IsOut: ").Append(IsOut).Append("\n");
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