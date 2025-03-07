using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class VenueRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Hydrations
        /// </summary>
        [DataMember(Name = "hydrations", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydrations")]
        public List<string> Hydrations { get; set; }

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
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "location")]
        public LocationRestObject Location { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeZone")]
        public TimeZoneRestObject TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets FieldInfo
        /// </summary>
        [DataMember(Name = "fieldInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fieldInfo")]
        public FieldInfoRestObject FieldInfo { get; set; }

        /// <summary>
        /// Gets or Sets RelatedApplications
        /// </summary>
        [DataMember(Name = "relatedApplications", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "relatedApplications")]
        public List<ApplicationRestObject> RelatedApplications { get; set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "images")]
        public Dictionary<string, ImageRestObject> Images { get; set; }

        /// <summary>
        /// Gets or Sets Social
        /// </summary>
        [DataMember(Name = "social", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "social")]
        public SocialMediaRestObject Social { get; set; }

        /// <summary>
        /// Gets or Sets Menu
        /// </summary>
        [DataMember(Name = "menu", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "menu")]
        public JsonNode Menu { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "schedule")]
        public ScheduleRestObject Schedule { get; set; }

        /// <summary>
        /// Gets or Sets NextSchedule
        /// </summary>
        [DataMember(Name = "nextSchedule", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nextSchedule")]
        public ScheduleRestObject NextSchedule { get; set; }

        /// <summary>
        /// Gets or Sets PreviousSchedule
        /// </summary>
        [DataMember(Name = "previousSchedule", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "previousSchedule")]
        public ScheduleRestObject PreviousSchedule { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "metadata")]
        public VenueMetadataRestObject Metadata { get; set; }

        /// <summary>
        /// Gets or Sets AppEnabled
        /// </summary>
        [DataMember(Name = "appEnabled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "appEnabled")]
        public bool? AppEnabled { get; set; }

        /// <summary>
        /// Gets or Sets XrefIds
        /// </summary>
        [DataMember(Name = "xrefIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "xrefIds")]
        public List<XrefIdRestObject> XrefIds { get; set; }

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
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VenueRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Hydrations: ").Append(Hydrations).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  FieldInfo: ").Append(FieldInfo).Append("\n");
            sb.Append("  RelatedApplications: ").Append(RelatedApplications).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Social: ").Append(Social).Append("\n");
            sb.Append("  Menu: ").Append(Menu).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  NextSchedule: ").Append(NextSchedule).Append("\n");
            sb.Append("  PreviousSchedule: ").Append(PreviousSchedule).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  AppEnabled: ").Append(AppEnabled).Append("\n");
            sb.Append("  XrefIds: ").Append(XrefIds).Append("\n");
            sb.Append("  TrackingVersion: ").Append(TrackingVersion).Append("\n");
            sb.Append("  CoachingVideo: ").Append(CoachingVideo).Append("\n");
            sb.Append("  RuleSettings: ").Append(RuleSettings).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
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