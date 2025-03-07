using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class TimeZoneRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Gets or Sets OffsetAtGameTime
        /// </summary>
        [DataMember(Name = "offsetAtGameTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offsetAtGameTime")]
        public int? OffsetAtGameTime { get; set; }

        /// <summary>
        /// Gets or Sets Tz
        /// </summary>
        [DataMember(Name = "tz", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tz")]
        public string Tz { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeZoneRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  OffsetAtGameTime: ").Append(OffsetAtGameTime).Append("\n");
            sb.Append("  Tz: ").Append(Tz).Append("\n");
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