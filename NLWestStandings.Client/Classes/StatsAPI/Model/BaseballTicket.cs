using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballTicket
    {
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
        /// Gets or Sets ScheduleId
        /// </summary>
        [DataMember(Name = "scheduleId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scheduleId")]
        public int? ScheduleId { get; set; }

        /// <summary>
        /// Gets or Sets OnSaleEndDate
        /// </summary>
        [DataMember(Name = "onSaleEndDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "onSaleEndDate")]
        public DateTime? OnSaleEndDate { get; set; }

        /// <summary>
        /// Gets or Sets HomeTicketLink
        /// </summary>
        [DataMember(Name = "homeTicketLink", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeTicketLink")]
        public string HomeTicketLink { get; set; }

        /// <summary>
        /// Gets or Sets AwayTicketLink
        /// </summary>
        [DataMember(Name = "awayTicketLink", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayTicketLink")]
        public string AwayTicketLink { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballTicket {\n");
            sb.Append("  TicketType: ").Append(TicketType).Append("\n");
            sb.Append("  TicketLink: ").Append(TicketLink).Append("\n");
            sb.Append("  ScheduleId: ").Append(ScheduleId).Append("\n");
            sb.Append("  OnSaleEndDate: ").Append(OnSaleEndDate).Append("\n");
            sb.Append("  HomeTicketLink: ").Append(HomeTicketLink).Append("\n");
            sb.Append("  AwayTicketLink: ").Append(AwayTicketLink).Append("\n");
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