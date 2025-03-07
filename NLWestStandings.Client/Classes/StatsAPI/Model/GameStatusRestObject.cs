using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class GameStatusRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets IsCurrentBatter
        /// </summary>
        [DataMember(Name = "isCurrentBatter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isCurrentBatter")]
        public bool? IsCurrentBatter { get; set; }

        /// <summary>
        /// Gets or Sets IsCurrentPitcher
        /// </summary>
        [DataMember(Name = "isCurrentPitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isCurrentPitcher")]
        public bool? IsCurrentPitcher { get; set; }

        /// <summary>
        /// Gets or Sets IsOnBench
        /// </summary>
        [DataMember(Name = "isOnBench", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isOnBench")]
        public bool? IsOnBench { get; set; }

        /// <summary>
        /// Gets or Sets IsSubstitute
        /// </summary>
        [DataMember(Name = "isSubstitute", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isSubstitute")]
        public bool? IsSubstitute { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameStatusRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  IsCurrentBatter: ").Append(IsCurrentBatter).Append("\n");
            sb.Append("  IsCurrentPitcher: ").Append(IsCurrentPitcher).Append("\n");
            sb.Append("  IsOnBench: ").Append(IsOnBench).Append("\n");
            sb.Append("  IsSubstitute: ").Append(IsSubstitute).Append("\n");
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