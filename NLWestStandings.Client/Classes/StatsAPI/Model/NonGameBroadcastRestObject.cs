using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class NonGameBroadcastRestObject
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Site
        /// </summary>
        [DataMember(Name = "site", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "site")]
        public string Site { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets IsNational
        /// </summary>
        [DataMember(Name = "isNational", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isNational")]
        public bool? IsNational { get; set; }

        /// <summary>
        /// Gets or Sets SourceUrl
        /// </summary>
        [DataMember(Name = "sourceUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sourceUrl")]
        public string SourceUrl { get; set; }

        /// <summary>
        /// Gets or Sets CallSign
        /// </summary>
        [DataMember(Name = "callSign", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "callSign")]
        public string CallSign { get; set; }

        /// <summary>
        /// Gets or Sets VideoResolution
        /// </summary>
        [DataMember(Name = "videoResolution", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "videoResolution")]
        public VideoResolutionEnumRestObject VideoResolution { get; set; }

        /// <summary>
        /// Gets or Sets Availability
        /// </summary>
        [DataMember(Name = "availability", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "availability")]
        public BroadcastAvailabilityRestObject Availability { get; set; }

        /// <summary>
        /// Gets or Sets XrefIds
        /// </summary>
        [DataMember(Name = "xrefIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "xrefIds")]
        public List<XrefIdRestObject> XrefIds { get; set; }

        /// <summary>
        /// Gets or Sets SourceComment
        /// </summary>
        [DataMember(Name = "sourceComment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sourceComment")]
        public string SourceComment { get; set; }

        /// <summary>
        /// Gets or Sets MediaState
        /// </summary>
        [DataMember(Name = "mediaState", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mediaState")]
        public MediaStateRestObject MediaState { get; set; }

        /// <summary>
        /// Gets or Sets BroadcastDate
        /// </summary>
        [DataMember(Name = "broadcastDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcastDate")]
        public DateTime? BroadcastDate { get; set; }

        /// <summary>
        /// Gets or Sets MediaId
        /// </summary>
        [DataMember(Name = "mediaId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mediaId")]
        public string MediaId { get; set; }

        /// <summary>
        /// Gets or Sets NonGameDateBroadcastGuid
        /// </summary>
        [DataMember(Name = "nonGameDateBroadcastGuid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nonGameDateBroadcastGuid")]
        public string NonGameDateBroadcastGuid { get; set; }

        /// <summary>
        /// Gets or Sets AvailableForStreaming
        /// </summary>
        [DataMember(Name = "availableForStreaming", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "availableForStreaming")]
        public bool? AvailableForStreaming { get; set; }

        /// <summary>
        /// Gets or Sets MvpdAuthRequired
        /// </summary>
        [DataMember(Name = "mvpdAuthRequired", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mvpdAuthRequired")]
        public bool? MvpdAuthRequired { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NonGameBroadcastRestObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  IsNational: ").Append(IsNational).Append("\n");
            sb.Append("  SourceUrl: ").Append(SourceUrl).Append("\n");
            sb.Append("  CallSign: ").Append(CallSign).Append("\n");
            sb.Append("  VideoResolution: ").Append(VideoResolution).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  XrefIds: ").Append(XrefIds).Append("\n");
            sb.Append("  SourceComment: ").Append(SourceComment).Append("\n");
            sb.Append("  MediaState: ").Append(MediaState).Append("\n");
            sb.Append("  BroadcastDate: ").Append(BroadcastDate).Append("\n");
            sb.Append("  MediaId: ").Append(MediaId).Append("\n");
            sb.Append("  NonGameDateBroadcastGuid: ").Append(NonGameDateBroadcastGuid).Append("\n");
            sb.Append("  AvailableForStreaming: ").Append(AvailableForStreaming).Append("\n");
            sb.Append("  MvpdAuthRequired: ").Append(MvpdAuthRequired).Append("\n");
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