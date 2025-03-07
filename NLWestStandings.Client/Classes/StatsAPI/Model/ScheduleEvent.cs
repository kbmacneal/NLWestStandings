using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class ScheduleEvent
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
        public ScheduleEventTypes EventType { get; set; }

        /// <summary>
        /// Gets or Sets EventDate
        /// </summary>
        [DataMember(Name = "eventDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventDate")]
        public DateTime? EventDate { get; set; }

        /// <summary>
        /// Gets or Sets CalendarDate
        /// </summary>
        [DataMember(Name = "calendarDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "calendarDate")]
        public DateTime? CalendarDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endDate")]
        public DateTime? EndDate { get; set; }

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
        public List<Image> Images { get; set; }

        /// <summary>
        /// Gets or Sets Venue
        /// </summary>
        [DataMember(Name = "venue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "venue")]
        public Venue Venue { get; set; }

        /// <summary>
        /// Gets or Sets Sports
        /// </summary>
        [DataMember(Name = "sports", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sports")]
        public List<Sport> Sports { get; set; }

        /// <summary>
        /// Gets or Sets Leagues
        /// </summary>
        [DataMember(Name = "leagues", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leagues")]
        public List<League> Leagues { get; set; }

        /// <summary>
        /// Gets or Sets Divisions
        /// </summary>
        [DataMember(Name = "divisions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "divisions")]
        public List<Division> Divisions { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationIds
        /// </summary>
        [DataMember(Name = "organizationIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "organizationIds")]
        public List<int?> OrganizationIds { get; set; }

        /// <summary>
        /// Gets or Sets Game
        /// </summary>
        [DataMember(Name = "game", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "game")]
        public BaseballScheduleItem Game { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "content")]
        public ScheduleEventCms Content { get; set; }

        /// <summary>
        /// Gets or Sets EventDesignations
        /// </summary>
        [DataMember(Name = "eventDesignations", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventDesignations")]
        public List<Designation> EventDesignations { get; set; }

        /// <summary>
        /// Gets or Sets Tickets
        /// </summary>
        [DataMember(Name = "tickets", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tickets")]
        public List<BaseballTicket> Tickets { get; set; }

        /// <summary>
        /// Gets or Sets PromotionTickets
        /// </summary>
        [DataMember(Name = "promotionTickets", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "promotionTickets")]
        public List<BaseballTicket> PromotionTickets { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeZone")]
        public TimeZone TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets EventStatus
        /// </summary>
        [DataMember(Name = "eventStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventStatus")]
        public EventStatus EventStatus { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name = "teamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamId")]
        public int? TeamId { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "organizationId")]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationType
        /// </summary>
        [DataMember(Name = "organizationType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "organizationType")]
        public string OrganizationType { get; set; }

        /// <summary>
        /// Gets or Sets CalendarType
        /// </summary>
        [DataMember(Name = "calendarType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "calendarType")]
        public CalendarTypes CalendarType { get; set; }

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
        public PublicFacingEnum PublicFacing { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teams")]
        public List<BaseballTeam> Teams { get; set; }

        /// <summary>
        /// Gets or Sets TrackingVersion
        /// </summary>
        [DataMember(Name = "trackingVersion", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trackingVersion")]
        public TrackingVersion TrackingVersion { get; set; }

        /// <summary>
        /// Gets or Sets TrackingSystemOwner
        /// </summary>
        [DataMember(Name = "trackingSystemOwner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trackingSystemOwner")]
        public TrackingSystemOwner TrackingSystemOwner { get; set; }

        /// <summary>
        /// Gets or Sets CoachingVideo
        /// </summary>
        [DataMember(Name = "coachingVideo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "coachingVideo")]
        public List<MediaSourceType> CoachingVideo { get; set; }

        /// <summary>
        /// Gets or Sets Broadcasts
        /// </summary>
        [DataMember(Name = "broadcasts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcasts")]
        public List<NonGameDateBroadcast> Broadcasts { get; set; }

        /// <summary>
        /// Gets or Sets NonGameGuid
        /// </summary>
        [DataMember(Name = "nonGameGuid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nonGameGuid")]
        public string NonGameGuid { get; set; }

        /// <summary>
        /// Gets or Sets MultiDay
        /// </summary>
        [DataMember(Name = "multiDay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "multiDay")]
        public bool? MultiDay { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryCalendar
        /// </summary>
        [DataMember(Name = "primaryCalendar", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "primaryCalendar")]
        public bool? PrimaryCalendar { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  CalendarDate: ").Append(CalendarDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Venue: ").Append(Venue).Append("\n");
            sb.Append("  Sports: ").Append(Sports).Append("\n");
            sb.Append("  Leagues: ").Append(Leagues).Append("\n");
            sb.Append("  Divisions: ").Append(Divisions).Append("\n");
            sb.Append("  OrganizationIds: ").Append(OrganizationIds).Append("\n");
            sb.Append("  Game: ").Append(Game).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  EventDesignations: ").Append(EventDesignations).Append("\n");
            sb.Append("  Tickets: ").Append(Tickets).Append("\n");
            sb.Append("  PromotionTickets: ").Append(PromotionTickets).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  EventStatus: ").Append(EventStatus).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  OrganizationType: ").Append(OrganizationType).Append("\n");
            sb.Append("  CalendarType: ").Append(CalendarType).Append("\n");
            sb.Append("  FileCode: ").Append(FileCode).Append("\n");
            sb.Append("  EventNumber: ").Append(EventNumber).Append("\n");
            sb.Append("  PublicFacing: ").Append(PublicFacing).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
            sb.Append("  TrackingVersion: ").Append(TrackingVersion).Append("\n");
            sb.Append("  TrackingSystemOwner: ").Append(TrackingSystemOwner).Append("\n");
            sb.Append("  CoachingVideo: ").Append(CoachingVideo).Append("\n");
            sb.Append("  Broadcasts: ").Append(Broadcasts).Append("\n");
            sb.Append("  NonGameGuid: ").Append(NonGameGuid).Append("\n");
            sb.Append("  MultiDay: ").Append(MultiDay).Append("\n");
            sb.Append("  PrimaryCalendar: ").Append(PrimaryCalendar).Append("\n");
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