using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Broadcaster
    {
        /// <summary>
        /// Gets or Sets BroadcasterId
        /// </summary>
        [DataMember(Name = "broadcasterId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcasterId")]
        public int? BroadcasterId { get; set; }

        /// <summary>
        /// Gets or Sets BroadcasterText
        /// </summary>
        [DataMember(Name = "broadcasterText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcasterText")]
        public string BroadcasterText { get; set; }

        /// <summary>
        /// Gets or Sets BroadcasterDesc
        /// </summary>
        [DataMember(Name = "broadcasterDesc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcasterDesc")]
        public string BroadcasterDesc { get; set; }

        /// <summary>
        /// Gets or Sets CallSign
        /// </summary>
        [DataMember(Name = "callSign", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "callSign")]
        public string CallSign { get; set; }

        /// <summary>
        /// Gets or Sets BroadcasterTypeId
        /// </summary>
        [DataMember(Name = "broadcasterTypeId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcasterTypeId")]
        public int? BroadcasterTypeId { get; set; }

        /// <summary>
        /// Gets or Sets BroadcasterTypeCode
        /// </summary>
        [DataMember(Name = "broadcasterTypeCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcasterTypeCode")]
        public string BroadcasterTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets BroadcasterTypeText
        /// </summary>
        [DataMember(Name = "broadcasterTypeText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcasterTypeText")]
        public string BroadcasterTypeText { get; set; }

        /// <summary>
        /// Gets or Sets BroadcasterTypeDesc
        /// </summary>
        [DataMember(Name = "broadcasterTypeDesc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcasterTypeDesc")]
        public string BroadcasterTypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets BroadcasterComment
        /// </summary>
        [DataMember(Name = "broadcasterComment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcasterComment")]
        public string BroadcasterComment { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryTeamId
        /// </summary>
        [DataMember(Name = "primaryTeamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "primaryTeamId")]
        public int? PrimaryTeamId { get; set; }

        /// <summary>
        /// Gets or Sets BroadcastAvailability
        /// </summary>
        [DataMember(Name = "broadcastAvailability", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcastAvailability")]
        public BroadcastAvailability BroadcastAvailability { get; set; }

        /// <summary>
        /// Gets or Sets ActiveStatus
        /// </summary>
        [DataMember(Name = "activeStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "activeStatus")]
        public bool? ActiveStatus { get; set; }

        /// <summary>
        /// Gets or Sets IsNationalStatus
        /// </summary>
        [DataMember(Name = "isNationalStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isNationalStatus")]
        public bool? IsNationalStatus { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets MvpdAuthBroadcast
        /// </summary>
        [DataMember(Name = "mvpdAuthBroadcast", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mvpdAuthBroadcast")]
        public bool? MvpdAuthBroadcast { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "language")]
        public Language Language { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Broadcaster {\n");
            sb.Append("  BroadcasterId: ").Append(BroadcasterId).Append("\n");
            sb.Append("  BroadcasterText: ").Append(BroadcasterText).Append("\n");
            sb.Append("  BroadcasterDesc: ").Append(BroadcasterDesc).Append("\n");
            sb.Append("  CallSign: ").Append(CallSign).Append("\n");
            sb.Append("  BroadcasterTypeId: ").Append(BroadcasterTypeId).Append("\n");
            sb.Append("  BroadcasterTypeCode: ").Append(BroadcasterTypeCode).Append("\n");
            sb.Append("  BroadcasterTypeText: ").Append(BroadcasterTypeText).Append("\n");
            sb.Append("  BroadcasterTypeDesc: ").Append(BroadcasterTypeDesc).Append("\n");
            sb.Append("  BroadcasterComment: ").Append(BroadcasterComment).Append("\n");
            sb.Append("  PrimaryTeamId: ").Append(PrimaryTeamId).Append("\n");
            sb.Append("  BroadcastAvailability: ").Append(BroadcastAvailability).Append("\n");
            sb.Append("  ActiveStatus: ").Append(ActiveStatus).Append("\n");
            sb.Append("  IsNationalStatus: ").Append(IsNationalStatus).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  MvpdAuthBroadcast: ").Append(MvpdAuthBroadcast).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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