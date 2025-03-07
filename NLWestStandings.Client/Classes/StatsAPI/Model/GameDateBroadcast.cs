using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class GameDateBroadcast
    {
        /// <summary>
        /// Gets or Sets Broadcaster
        /// </summary>
        [DataMember(Name = "broadcaster", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcaster")]
        public Broadcaster Broadcaster { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "language")]
        public Language Language { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name = "teamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamId")]
        public int? TeamId { get; set; }

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
        /// Gets or Sets VideoResolution
        /// </summary>
        [DataMember(Name = "videoResolution", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "videoResolution")]
        public VideoResolution VideoResolution { get; set; }

        /// <summary>
        /// Gets or Sets BroadcastAvailability
        /// </summary>
        [DataMember(Name = "broadcastAvailability", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcastAvailability")]
        public BroadcastAvailability BroadcastAvailability { get; set; }

        /// <summary>
        /// Gets or Sets BroadcastComment
        /// </summary>
        [DataMember(Name = "broadcastComment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcastComment")]
        public string BroadcastComment { get; set; }

        /// <summary>
        /// Gets or Sets BroadcastUrl
        /// </summary>
        [DataMember(Name = "broadcastUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcastUrl")]
        public string BroadcastUrl { get; set; }

        /// <summary>
        /// Gets or Sets Xrefs
        /// </summary>
        [DataMember(Name = "xrefs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "xrefs")]
        public List<BroadcasterXrefId> Xrefs { get; set; }

        /// <summary>
        /// Gets or Sets MediaState
        /// </summary>
        [DataMember(Name = "mediaState", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mediaState")]
        public MediaState MediaState { get; set; }

        /// <summary>
        /// Gets or Sets Site
        /// </summary>
        [DataMember(Name = "site", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "site")]
        public Site Site { get; set; }

        /// <summary>
        /// Gets or Sets BroadcastDate
        /// </summary>
        [DataMember(Name = "broadcastDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcastDate")]
        public DateTime? BroadcastDate { get; set; }

        /// <summary>
        /// Gets or Sets GameDateBroadcastGuid
        /// </summary>
        [DataMember(Name = "gameDateBroadcastGuid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameDateBroadcastGuid")]
        public Guid? GameDateBroadcastGuid { get; set; }

        /// <summary>
        /// Gets or Sets GamePk
        /// </summary>
        [DataMember(Name = "gamePk", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamePk")]
        public int? GamePk { get; set; }

        /// <summary>
        /// Gets or Sets HomeAway
        /// </summary>
        [DataMember(Name = "homeAway", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeAway")]
        public TeamDesignationEnum HomeAway { get; set; }

        /// <summary>
        /// Gets or Sets PregameShowTs
        /// </summary>
        [DataMember(Name = "pregameShowTs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pregameShowTs")]
        public DateTime? PregameShowTs { get; set; }

        /// <summary>
        /// Gets or Sets PostgameShowStatus
        /// </summary>
        [DataMember(Name = "postgameShowStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postgameShowStatus")]
        public bool? PostgameShowStatus { get; set; }

        /// <summary>
        /// Gets or Sets StreamingAvailabilityStatus
        /// </summary>
        [DataMember(Name = "streamingAvailabilityStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "streamingAvailabilityStatus")]
        public bool? StreamingAvailabilityStatus { get; set; }

        /// <summary>
        /// Gets or Sets FreeGameStatus
        /// </summary>
        [DataMember(Name = "freeGameStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "freeGameStatus")]
        public bool? FreeGameStatus { get; set; }

        /// <summary>
        /// Gets or Sets MvpdAuthBroadcastStatus
        /// </summary>
        [DataMember(Name = "mvpdAuthBroadcastStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mvpdAuthBroadcastStatus")]
        public bool? MvpdAuthBroadcastStatus { get; set; }

        /// <summary>
        /// Gets or Sets FreeGameOverallStatus
        /// </summary>
        [DataMember(Name = "freeGameOverallStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "freeGameOverallStatus")]
        public bool? FreeGameOverallStatus { get; set; }

        /// <summary>
        /// Gets or Sets FreeGameTypes
        /// </summary>
        [DataMember(Name = "freeGameTypes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "freeGameTypes")]
        public List<FreeGameType> FreeGameTypes { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameDateBroadcast {\n");
            sb.Append("  Broadcaster: ").Append(Broadcaster).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  IsNationalStatus: ").Append(IsNationalStatus).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  VideoResolution: ").Append(VideoResolution).Append("\n");
            sb.Append("  BroadcastAvailability: ").Append(BroadcastAvailability).Append("\n");
            sb.Append("  BroadcastComment: ").Append(BroadcastComment).Append("\n");
            sb.Append("  BroadcastUrl: ").Append(BroadcastUrl).Append("\n");
            sb.Append("  Xrefs: ").Append(Xrefs).Append("\n");
            sb.Append("  MediaState: ").Append(MediaState).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  BroadcastDate: ").Append(BroadcastDate).Append("\n");
            sb.Append("  GameDateBroadcastGuid: ").Append(GameDateBroadcastGuid).Append("\n");
            sb.Append("  GamePk: ").Append(GamePk).Append("\n");
            sb.Append("  HomeAway: ").Append(HomeAway).Append("\n");
            sb.Append("  PregameShowTs: ").Append(PregameShowTs).Append("\n");
            sb.Append("  PostgameShowStatus: ").Append(PostgameShowStatus).Append("\n");
            sb.Append("  StreamingAvailabilityStatus: ").Append(StreamingAvailabilityStatus).Append("\n");
            sb.Append("  FreeGameStatus: ").Append(FreeGameStatus).Append("\n");
            sb.Append("  MvpdAuthBroadcastStatus: ").Append(MvpdAuthBroadcastStatus).Append("\n");
            sb.Append("  FreeGameOverallStatus: ").Append(FreeGameOverallStatus).Append("\n");
            sb.Append("  FreeGameTypes: ").Append(FreeGameTypes).Append("\n");
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