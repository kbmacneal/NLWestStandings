using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class FreeGameType
    {
        /// <summary>
        /// Gets or Sets FreeGameTypeEnum
        /// </summary>
        [DataMember(Name = "freeGameTypeEnum", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "freeGameTypeEnum")]
        public FreeGameTypeEnum FreeGameTypeEnum { get; set; }

        /// <summary>
        /// Gets or Sets OnStatus
        /// </summary>
        [DataMember(Name = "onStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "onStatus")]
        public bool? OnStatus { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FreeGameType {\n");
            sb.Append("  FreeGameTypeEnum: ").Append(FreeGameTypeEnum).Append("\n");
            sb.Append("  OnStatus: ").Append(OnStatus).Append("\n");
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