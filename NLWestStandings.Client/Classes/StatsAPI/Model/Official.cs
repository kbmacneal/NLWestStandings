using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Official
    {
        /// <summary>
        /// Gets or Sets Person
        /// </summary>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "person")]
        public BaseballPerson Person { get; set; }

        /// <summary>
        /// Gets or Sets JerseyNumber
        /// </summary>
        [DataMember(Name = "jerseyNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "jerseyNumber")]
        public string JerseyNumber { get; set; }

        /// <summary>
        /// Gets or Sets OfficialType
        /// </summary>
        [DataMember(Name = "officialType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "officialType")]
        public IOfficialType OfficialType { get; set; }

        /// <summary>
        /// Gets or Sets GameDate
        /// </summary>
        [DataMember(Name = "gameDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameDate")]
        public DateTime? GameDate { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Official {\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  JerseyNumber: ").Append(JerseyNumber).Append("\n");
            sb.Append("  OfficialType: ").Append(OfficialType).Append("\n");
            sb.Append("  GameDate: ").Append(GameDate).Append("\n");
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