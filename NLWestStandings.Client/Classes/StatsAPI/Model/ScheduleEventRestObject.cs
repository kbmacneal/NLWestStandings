using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class ScheduleEventRestObject
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
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets NonGameGuid
        /// </summary>
        [DataMember(Name = "nonGameGuid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nonGameGuid")]
        public string NonGameGuid { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventType")]
        public ScheduleEventTypeRestObject EventType { get; set; }

        /// <summary>
        /// Gets or Sets EventDate
        /// </summary>
        [DataMember(Name = "eventDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventDate")]
        public DateTime? EventDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDateTime
        /// </summary>
        [DataMember(Name = "endDateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endDateTime")]
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "images")]
        public List<ImageRestObject> Images { get; set; }

        /// <summary>
        /// Gets or Sets Venue
        /// </summary>
        [DataMember(Name = "venue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "venue")]
        public VenueRestObject Venue { get; set; }

        /// <summary>
        /// Gets or Sets Sports
        /// </summary>
        [DataMember(Name = "sports", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sports")]
        public List<SportRestObject> Sports { get; set; }

        /// <summary>
        /// Gets or Sets Leagues
        /// </summary>
        [DataMember(Name = "leagues", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leagues")]
        public List<LeagueRestObject> Leagues { get; set; }

        /// <summary>
        /// Gets or Sets Divisions
        /// </summary>
        [DataMember(Name = "divisions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "divisions")]
        public List<DivisionRestObject> Divisions { get; set; }

        /// <summary>
        /// Gets or Sets Game
        /// </summary>
        [DataMember(Name = "game", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "game")]
        public BaseballScheduleItemRestObject Game { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "content")]
        public ScheduleEventCms Content { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeZone")]
        public TimeZoneRestObject TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets Designations
        /// </summary>
        [DataMember(Name = "designations", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "designations")]
        public List<DesignationRestObject> Designations { get; set; }

        /// <summary>
        /// Gets or Sets Tickets
        /// </summary>
        [DataMember(Name = "tickets", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tickets")]
        public List<BaseballTicketRestObject> Tickets { get; set; }

        /// <summary>
        /// Gets or Sets Promotions
        /// </summary>
        [DataMember(Name = "promotions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "promotions")]
        public List<BaseballTicketRestObject> Promotions { get; set; }

        /// <summary>
        /// Gets or Sets EventStatus
        /// </summary>
        [DataMember(Name = "eventStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventStatus")]
        public GameStatusRestObject EventStatus { get; set; }

        /// <summary>
        /// Gets or Sets IsMultiDay
        /// </summary>
        [DataMember(Name = "isMultiDay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isMultiDay")]
        public bool? IsMultiDay { get; set; }

        /// <summary>
        /// Gets or Sets IsPrimaryCalendar
        /// </summary>
        [DataMember(Name = "isPrimaryCalendar", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPrimaryCalendar")]
        public bool? IsPrimaryCalendar { get; set; }

        /// <summary>
        /// Gets or Sets FileCode
        /// </summary>
        [DataMember(Name = "fileCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fileCode")]
        public string FileCode { get; set; }

        /// <summary>
        /// Gets or Sets EventNumber
        /// </summary>
        [DataMember(Name = "eventNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventNumber")]
        public int? EventNumber { get; set; }

        /// <summary>
        /// Gets or Sets PublicFacing
        /// </summary>
        [DataMember(Name = "publicFacing", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "publicFacing")]
        public bool? PublicFacing { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teams")]
        public List<BaseballTeamRestObject> Teams { get; set; }

        /// <summary>
        /// Gets or Sets TrackingVersion
        /// </summary>
        [DataMember(Name = "trackingVersion", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trackingVersion")]
        public TrackingVersionRestObject TrackingVersion { get; set; }

        /// <summary>
        /// Gets or Sets CoachingVideo
        /// </summary>
        [DataMember(Name = "coachingVideo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "coachingVideo")]
        public List<MediaSourceType> CoachingVideo { get; set; }

        /// <summary>
        /// Gets or Sets RuleSettings
        /// </summary>
        [DataMember(Name = "ruleSettings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ruleSettings")]
        public List<RuleSettingsRestObject> RuleSettings { get; set; }

        /// <summary>
        /// Gets or Sets Broadcasts
        /// </summary>
        [DataMember(Name = "broadcasts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcasts")]
        public List<NonGameBroadcastRestObject> Broadcasts { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleEventRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NonGameGuid: ").Append(NonGameGuid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Venue: ").Append(Venue).Append("\n");
            sb.Append("  Sports: ").Append(Sports).Append("\n");
            sb.Append("  Leagues: ").Append(Leagues).Append("\n");
            sb.Append("  Divisions: ").Append(Divisions).Append("\n");
            sb.Append("  Game: ").Append(Game).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Designations: ").Append(Designations).Append("\n");
            sb.Append("  Tickets: ").Append(Tickets).Append("\n");
            sb.Append("  Promotions: ").Append(Promotions).Append("\n");
            sb.Append("  EventStatus: ").Append(EventStatus).Append("\n");
            sb.Append("  IsMultiDay: ").Append(IsMultiDay).Append("\n");
            sb.Append("  IsPrimaryCalendar: ").Append(IsPrimaryCalendar).Append("\n");
            sb.Append("  FileCode: ").Append(FileCode).Append("\n");
            sb.Append("  EventNumber: ").Append(EventNumber).Append("\n");
            sb.Append("  PublicFacing: ").Append(PublicFacing).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
            sb.Append("  TrackingVersion: ").Append(TrackingVersion).Append("\n");
            sb.Append("  CoachingVideo: ").Append(CoachingVideo).Append("\n");
            sb.Append("  RuleSettings: ").Append(RuleSettings).Append("\n");
            sb.Append("  Broadcasts: ").Append(Broadcasts).Append("\n");
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