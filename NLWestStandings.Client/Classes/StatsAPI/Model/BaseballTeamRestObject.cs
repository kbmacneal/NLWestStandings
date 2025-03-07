using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballTeamRestObject
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
        /// Gets or Sets SpringLeague
        /// </summary>
        [DataMember(Name = "springLeague", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "springLeague")]
        public LeagueRestObject SpringLeague { get; set; }

        /// <summary>
        /// Gets or Sets XrefIds
        /// </summary>
        [DataMember(Name = "xrefIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "xrefIds")]
        public List<XrefIdRestObject> XrefIds { get; set; }

        /// <summary>
        /// Gets or Sets AllStarStatus
        /// </summary>
        [DataMember(Name = "allStarStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "allStarStatus")]
        public AllStarEnum AllStarStatus { get; set; }

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
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public int? Season { get; set; }

        /// <summary>
        /// Gets or Sets Venue
        /// </summary>
        [DataMember(Name = "venue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "venue")]
        public VenueRestObject Venue { get; set; }

        /// <summary>
        /// Gets or Sets SpringVenue
        /// </summary>
        [DataMember(Name = "springVenue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "springVenue")]
        public VenueRestObject SpringVenue { get; set; }

        /// <summary>
        /// Gets or Sets TeamCode
        /// </summary>
        [DataMember(Name = "teamCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamCode")]
        public string TeamCode { get; set; }

        /// <summary>
        /// Gets or Sets FileCode
        /// </summary>
        [DataMember(Name = "fileCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fileCode")]
        public string FileCode { get; set; }

        /// <summary>
        /// Gets or Sets Abbreviation
        /// </summary>
        [DataMember(Name = "abbreviation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or Sets TriCode
        /// </summary>
        [DataMember(Name = "triCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "triCode")]
        public string TriCode { get; set; }

        /// <summary>
        /// Gets or Sets TeamName
        /// </summary>
        [DataMember(Name = "teamName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamName")]
        public string TeamName { get; set; }

        /// <summary>
        /// Gets or Sets LocationName
        /// </summary>
        [DataMember(Name = "locationName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "locationName")]
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or Sets FirstYearOfPlay
        /// </summary>
        [DataMember(Name = "firstYearOfPlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstYearOfPlay")]
        public string FirstYearOfPlay { get; set; }

        /// <summary>
        /// Gets or Sets League
        /// </summary>
        [DataMember(Name = "league", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "league")]
        public LeagueRestObject League { get; set; }

        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name = "division", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "division")]
        public DivisionRestObject Division { get; set; }

        /// <summary>
        /// Gets or Sets Sport
        /// </summary>
        [DataMember(Name = "sport", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sport")]
        public SportRestObject Sport { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [DataMember(Name = "conference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "conference")]
        public ConferenceRestObject Conference { get; set; }

        /// <summary>
        /// Gets or Sets Franchise
        /// </summary>
        [DataMember(Name = "franchise", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "franchise")]
        public FranchiseRestObject Franchise { get; set; }

        /// <summary>
        /// Gets or Sets TeamStats
        /// </summary>
        [DataMember(Name = "teamStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamStats")]
        public List<StatContainerRestObject> TeamStats { get; set; }

        /// <summary>
        /// Gets or Sets Roster
        /// </summary>
        [DataMember(Name = "roster", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "roster")]
        public RosterRestObject Roster { get; set; }

        /// <summary>
        /// Gets or Sets TeamLeaders
        /// </summary>
        [DataMember(Name = "teamLeaders", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamLeaders")]
        public List<LeadersRestObject> TeamLeaders { get; set; }

        /// <summary>
        /// Gets or Sets NextGameSchedule
        /// </summary>
        [DataMember(Name = "nextGameSchedule", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nextGameSchedule")]
        public ScheduleRestObject NextGameSchedule { get; set; }

        /// <summary>
        /// Gets or Sets PreviousGameSchedule
        /// </summary>
        [DataMember(Name = "previousGameSchedule", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "previousGameSchedule")]
        public ScheduleRestObject PreviousGameSchedule { get; set; }

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
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "content")]
        public TeamContentCms Content { get; set; }

        /// <summary>
        /// Gets or Sets DeviceProperties
        /// </summary>
        [DataMember(Name = "deviceProperties", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deviceProperties")]
        public JsonNode DeviceProperties { get; set; }

        /// <summary>
        /// Gets or Sets Social
        /// </summary>
        [DataMember(Name = "social", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "social")]
        public SocialMediaRestObject Social { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name = "shortName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or Sets Record
        /// </summary>
        [DataMember(Name = "record", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "record")]
        public TeamStandingsRecordRestObject Record { get; set; }

        /// <summary>
        /// Gets or Sets PlayoffInfo
        /// </summary>
        [DataMember(Name = "playoffInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playoffInfo")]
        public TeamPlayoffs PlayoffInfo { get; set; }

        /// <summary>
        /// Gets or Sets HomeAway
        /// </summary>
        [DataMember(Name = "homeAway", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeAway")]
        public string HomeAway { get; set; }

        /// <summary>
        /// Gets or Sets TeamDesignation
        /// </summary>
        [DataMember(Name = "teamDesignation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamDesignation")]
        public string TeamDesignation { get; set; }

        /// <summary>
        /// Gets or Sets ParentOrgName
        /// </summary>
        [DataMember(Name = "parentOrgName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parentOrgName")]
        public string ParentOrgName { get; set; }

        /// <summary>
        /// Gets or Sets ParentOrgId
        /// </summary>
        [DataMember(Name = "parentOrgId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parentOrgId")]
        public int? ParentOrgId { get; set; }

        /// <summary>
        /// Gets or Sets FranchiseName
        /// </summary>
        [DataMember(Name = "franchiseName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "franchiseName")]
        public string FranchiseName { get; set; }

        /// <summary>
        /// Gets or Sets ClubName
        /// </summary>
        [DataMember(Name = "clubName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "clubName")]
        public string ClubName { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "location")]
        public LocationRestObject Location { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets Placeholder
        /// </summary>
        [DataMember(Name = "placeholder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "placeholder")]
        public bool? Placeholder { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballTeamRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Hydrations: ").Append(Hydrations).Append("\n");
            sb.Append("  SpringLeague: ").Append(SpringLeague).Append("\n");
            sb.Append("  XrefIds: ").Append(XrefIds).Append("\n");
            sb.Append("  AllStarStatus: ").Append(AllStarStatus).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Venue: ").Append(Venue).Append("\n");
            sb.Append("  SpringVenue: ").Append(SpringVenue).Append("\n");
            sb.Append("  TeamCode: ").Append(TeamCode).Append("\n");
            sb.Append("  FileCode: ").Append(FileCode).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
            sb.Append("  TriCode: ").Append(TriCode).Append("\n");
            sb.Append("  TeamName: ").Append(TeamName).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  FirstYearOfPlay: ").Append(FirstYearOfPlay).Append("\n");
            sb.Append("  League: ").Append(League).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Sport: ").Append(Sport).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Franchise: ").Append(Franchise).Append("\n");
            sb.Append("  TeamStats: ").Append(TeamStats).Append("\n");
            sb.Append("  Roster: ").Append(Roster).Append("\n");
            sb.Append("  TeamLeaders: ").Append(TeamLeaders).Append("\n");
            sb.Append("  NextGameSchedule: ").Append(NextGameSchedule).Append("\n");
            sb.Append("  PreviousGameSchedule: ").Append(PreviousGameSchedule).Append("\n");
            sb.Append("  NextSchedule: ").Append(NextSchedule).Append("\n");
            sb.Append("  PreviousSchedule: ").Append(PreviousSchedule).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  DeviceProperties: ").Append(DeviceProperties).Append("\n");
            sb.Append("  Social: ").Append(Social).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Record: ").Append(Record).Append("\n");
            sb.Append("  PlayoffInfo: ").Append(PlayoffInfo).Append("\n");
            sb.Append("  HomeAway: ").Append(HomeAway).Append("\n");
            sb.Append("  TeamDesignation: ").Append(TeamDesignation).Append("\n");
            sb.Append("  ParentOrgName: ").Append(ParentOrgName).Append("\n");
            sb.Append("  ParentOrgId: ").Append(ParentOrgId).Append("\n");
            sb.Append("  FranchiseName: ").Append(FranchiseName).Append("\n");
            sb.Append("  ClubName: ").Append(ClubName).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Placeholder: ").Append(Placeholder).Append("\n");
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