using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Venue
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

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
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "location")]
        public Location Location { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeZone")]
        public TimeZone TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets FieldInfo
        /// </summary>
        [DataMember(Name = "fieldInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fieldInfo")]
        public FieldInfo FieldInfo { get; set; }

        /// <summary>
        /// Gets or Sets SportType
        /// </summary>
        [DataMember(Name = "sportType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sportType")]
        public SportTypeEnum SportType { get; set; }

        /// <summary>
        /// Gets or Sets RelatedVenues
        /// </summary>
        [DataMember(Name = "relatedVenues", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "relatedVenues")]
        public List<Venue> RelatedVenues { get; set; }

        /// <summary>
        /// Gets or Sets ParentVenues
        /// </summary>
        [DataMember(Name = "parentVenues", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parentVenues")]
        public List<Venue> ParentVenues { get; set; }

        /// <summary>
        /// Gets or Sets ResidentVenues
        /// </summary>
        [DataMember(Name = "residentVenues", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "residentVenues")]
        public List<Venue> ResidentVenues { get; set; }

        /// <summary>
        /// Gets or Sets RelatedApplications
        /// </summary>
        [DataMember(Name = "relatedApplications", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "relatedApplications")]
        public List<RelatedApplication> RelatedApplications { get; set; }

        /// <summary>
        /// Gets or Sets RelatedImages
        /// </summary>
        [DataMember(Name = "relatedImages", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "relatedImages")]
        public List<Image> RelatedImages { get; set; }

        /// <summary>
        /// Gets or Sets SocialMediaInfo
        /// </summary>
        [DataMember(Name = "socialMediaInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "socialMediaInfo")]
        public SocialMediaInfo SocialMediaInfo { get; set; }

        /// <summary>
        /// Gets or Sets Menu
        /// </summary>
        [DataMember(Name = "menu", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "menu")]
        public VenueCms Menu { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "metadata")]
        public VenueMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "schedule")]
        public BaseballSchedule Schedule { get; set; }

        /// <summary>
        /// Gets or Sets NextSchedule
        /// </summary>
        [DataMember(Name = "nextSchedule", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nextSchedule")]
        public BaseballSchedule NextSchedule { get; set; }

        /// <summary>
        /// Gets or Sets PreviousSchedule
        /// </summary>
        [DataMember(Name = "previousSchedule", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "previousSchedule")]
        public BaseballSchedule PreviousSchedule { get; set; }

        /// <summary>
        /// Gets or Sets XrefIds
        /// </summary>
        [DataMember(Name = "xrefIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "xrefIds")]
        public List<XrefId> XrefIds { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

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
        /// Gets or Sets AppEnabled
        /// </summary>
        [DataMember(Name = "appEnabled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "appEnabled")]
        public bool? AppEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets TimeZoneId
        /// </summary>
        [DataMember(Name = "timeZoneId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeZoneId")]
        public string TimeZoneId { get; set; }

        /// <summary>
        /// Gets or Sets UserPrivileges
        /// </summary>
        [DataMember(Name = "userPrivileges", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "userPrivileges")]
        public List<Privilege> UserPrivileges { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Venue {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  FieldInfo: ").Append(FieldInfo).Append("\n");
            sb.Append("  SportType: ").Append(SportType).Append("\n");
            sb.Append("  RelatedVenues: ").Append(RelatedVenues).Append("\n");
            sb.Append("  ParentVenues: ").Append(ParentVenues).Append("\n");
            sb.Append("  ResidentVenues: ").Append(ResidentVenues).Append("\n");
            sb.Append("  RelatedApplications: ").Append(RelatedApplications).Append("\n");
            sb.Append("  RelatedImages: ").Append(RelatedImages).Append("\n");
            sb.Append("  SocialMediaInfo: ").Append(SocialMediaInfo).Append("\n");
            sb.Append("  Menu: ").Append(Menu).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  NextSchedule: ").Append(NextSchedule).Append("\n");
            sb.Append("  PreviousSchedule: ").Append(PreviousSchedule).Append("\n");
            sb.Append("  XrefIds: ").Append(XrefIds).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  TrackingVersion: ").Append(TrackingVersion).Append("\n");
            sb.Append("  TrackingSystemOwner: ").Append(TrackingSystemOwner).Append("\n");
            sb.Append("  CoachingVideo: ").Append(CoachingVideo).Append("\n");
            sb.Append("  AppEnabled: ").Append(AppEnabled).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
            sb.Append("  UserPrivileges: ").Append(UserPrivileges).Append("\n");
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