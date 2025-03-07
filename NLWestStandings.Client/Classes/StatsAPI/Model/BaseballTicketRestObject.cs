using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballTicketRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets TicketType
        /// </summary>
        [DataMember(Name = "ticketType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ticketType")]
        public string TicketType { get; set; }

        /// <summary>
        /// Gets or Sets TicketLink
        /// </summary>
        [DataMember(Name = "ticketLink", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ticketLink")]
        public string TicketLink { get; set; }

        /// <summary>
        /// Gets or Sets TicketLinks
        /// </summary>
        [DataMember(Name = "ticketLinks", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ticketLinks")]
        public Dictionary<string, string> TicketLinks { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballTicketRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  TicketType: ").Append(TicketType).Append("\n");
            sb.Append("  TicketLink: ").Append(TicketLink).Append("\n");
            sb.Append("  TicketLinks: ").Append(TicketLinks).Append("\n");
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