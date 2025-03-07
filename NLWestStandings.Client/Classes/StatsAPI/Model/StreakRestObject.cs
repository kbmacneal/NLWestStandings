using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class StreakRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets StreakType
        /// </summary>
        [DataMember(Name = "streakType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "streakType")]
        public string StreakType { get; set; }

        /// <summary>
        /// Gets or Sets StreakNumber
        /// </summary>
        [DataMember(Name = "streakNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "streakNumber")]
        public int? StreakNumber { get; set; }

        /// <summary>
        /// Gets or Sets StreakCode
        /// </summary>
        [DataMember(Name = "streakCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "streakCode")]
        public string StreakCode { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StreakRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  StreakType: ").Append(StreakType).Append("\n");
            sb.Append("  StreakNumber: ").Append(StreakNumber).Append("\n");
            sb.Append("  StreakCode: ").Append(StreakCode).Append("\n");
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