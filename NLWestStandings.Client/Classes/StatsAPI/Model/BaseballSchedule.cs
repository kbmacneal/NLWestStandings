using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballSchedule
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

        /// <summary>
        /// Gets or Sets Games
        /// </summary>
        [DataMember(Name = "games", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "games")]
        public List<BaseballScheduleItem> Games { get; set; }

        /// <summary>
        /// Gets or Sets RefreshInterval
        /// </summary>
        [DataMember(Name = "refreshInterval", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "refreshInterval")]
        public int? RefreshInterval { get; set; }

        /// <summary>
        /// Gets or Sets IncludeSiteBroadcasts
        /// </summary>
        [DataMember(Name = "includeSiteBroadcasts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "includeSiteBroadcasts")]
        public bool? IncludeSiteBroadcasts { get; set; }

        /// <summary>
        /// Gets or Sets IncludeEventTickets
        /// </summary>
        [DataMember(Name = "includeEventTickets", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "includeEventTickets")]
        public bool? IncludeEventTickets { get; set; }

        /// <summary>
        /// Gets or Sets GameTypes
        /// </summary>
        [DataMember(Name = "gameTypes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameTypes")]
        public List<GameTypeEnum> GameTypes { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleEvents
        /// </summary>
        [DataMember(Name = "scheduleEvents", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scheduleEvents")]
        public List<ScheduleEvent> ScheduleEvents { get; set; }

        /// <summary>
        /// Gets or Sets Abschallenges
        /// </summary>
        [DataMember(Name = "abschallenges", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "abschallenges")]
        public Dictionary<string, Object> Abschallenges { get; set; }

        /// <summary>
        /// Gets or Sets Challenges
        /// </summary>
        [DataMember(Name = "challenges", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "challenges")]
        public Dictionary<string, Object> Challenges { get; set; }

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "flags")]
        public Dictionary<string, Object> Flags { get; set; }

        /// <summary>
        /// Gets or Sets TeamsWithGames
        /// </summary>
        [DataMember(Name = "teamsWithGames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamsWithGames")]
        public List<int?> TeamsWithGames { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleItems
        /// </summary>
        [DataMember(Name = "scheduleItems", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scheduleItems")]
        public List<BaseballScheduleItem> ScheduleItems { get; set; }

        /// <summary>
        /// Gets or Sets HomeRuns
        /// </summary>
        [DataMember(Name = "homeRuns", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeRuns")]
        public Dictionary<string, Object> HomeRuns { get; set; }

        /// <summary>
        /// Gets or Sets Alerts
        /// </summary>
        [DataMember(Name = "alerts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "alerts")]
        public Dictionary<string, Object> Alerts { get; set; }

        /// <summary>
        /// Gets or Sets _BaseballSchedule
        /// </summary>
        [DataMember(Name = "baseballSchedule", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "baseballSchedule")]
        public List<BaseballScheduleItem> _BaseballSchedule { get; set; }

        /// <summary>
        /// Gets or Sets HydratedStats
        /// </summary>
        [DataMember(Name = "hydratedStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedStats")]
        public Dictionary<string, Object> HydratedStats { get; set; }

        /// <summary>
        /// Gets or Sets HydratedPeople
        /// </summary>
        [DataMember(Name = "hydratedPeople", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedPeople")]
        public Dictionary<string, Object> HydratedPeople { get; set; }

        /// <summary>
        /// Gets or Sets PreviousPlay
        /// </summary>
        [DataMember(Name = "previousPlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "previousPlay")]
        public Dictionary<string, Object> PreviousPlay { get; set; }

        /// <summary>
        /// Gets or Sets HydratedTeamLeadersInPreview
        /// </summary>
        [DataMember(Name = "hydratedTeamLeadersInPreview", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedTeamLeadersInPreview")]
        public Dictionary<string, Object> HydratedTeamLeadersInPreview { get; set; }

        /// <summary>
        /// Gets or Sets HydratedTeamLeaders
        /// </summary>
        [DataMember(Name = "hydratedTeamLeaders", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedTeamLeaders")]
        public Dictionary<string, Object> HydratedTeamLeaders { get; set; }

        /// <summary>
        /// Gets or Sets ProbablePitchersNotes
        /// </summary>
        [DataMember(Name = "probablePitchersNotes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "probablePitchersNotes")]
        public Dictionary<string, Object> ProbablePitchersNotes { get; set; }

        /// <summary>
        /// Gets or Sets HydratedProbablePitchers
        /// </summary>
        [DataMember(Name = "hydratedProbablePitchers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedProbablePitchers")]
        public Dictionary<string, Object> HydratedProbablePitchers { get; set; }

        /// <summary>
        /// Gets or Sets LiveLookins
        /// </summary>
        [DataMember(Name = "liveLookins", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "liveLookins")]
        public Dictionary<string, Object> LiveLookins { get; set; }

        /// <summary>
        /// Gets or Sets BaseballLineups
        /// </summary>
        [DataMember(Name = "baseballLineups", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "baseballLineups")]
        public Dictionary<string, Object> BaseballLineups { get; set; }

        /// <summary>
        /// Gets or Sets ProbableOfficials
        /// </summary>
        [DataMember(Name = "probableOfficials", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "probableOfficials")]
        public Dictionary<string, Object> ProbableOfficials { get; set; }

        /// <summary>
        /// Gets or Sets HydratedTeamsAsString
        /// </summary>
        [DataMember(Name = "hydratedTeamsAsString", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedTeamsAsString")]
        public Dictionary<string, Object> HydratedTeamsAsString { get; set; }

        /// <summary>
        /// Gets or Sets HydratedVenuesAsString
        /// </summary>
        [DataMember(Name = "hydratedVenuesAsString", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedVenuesAsString")]
        public Dictionary<string, Object> HydratedVenuesAsString { get; set; }

        /// <summary>
        /// Gets or Sets HydratedEventVenuesAsString
        /// </summary>
        [DataMember(Name = "hydratedEventVenuesAsString", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedEventVenuesAsString")]
        public Dictionary<string, Object> HydratedEventVenuesAsString { get; set; }

        /// <summary>
        /// Gets or Sets HydratedEventDivisionsAsString
        /// </summary>
        [DataMember(Name = "hydratedEventDivisionsAsString", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedEventDivisionsAsString")]
        public Dictionary<string, Object> HydratedEventDivisionsAsString { get; set; }

        /// <summary>
        /// Gets or Sets HydratedEventLeaguesAsString
        /// </summary>
        [DataMember(Name = "hydratedEventLeaguesAsString", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedEventLeaguesAsString")]
        public Dictionary<string, Object> HydratedEventLeaguesAsString { get; set; }

        /// <summary>
        /// Gets or Sets HydratedEventSportsAsString
        /// </summary>
        [DataMember(Name = "hydratedEventSportsAsString", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedEventSportsAsString")]
        public Dictionary<string, Object> HydratedEventSportsAsString { get; set; }

        /// <summary>
        /// Gets or Sets GamePreviewStoryLegacy
        /// </summary>
        [DataMember(Name = "gamePreviewStoryLegacy", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamePreviewStoryLegacy")]
        public BaseballScheduleItem GamePreviewStoryLegacy { get; set; }

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
            sb.Append("class BaseballSchedule {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  Games: ").Append(Games).Append("\n");
            sb.Append("  RefreshInterval: ").Append(RefreshInterval).Append("\n");
            sb.Append("  IncludeSiteBroadcasts: ").Append(IncludeSiteBroadcasts).Append("\n");
            sb.Append("  IncludeEventTickets: ").Append(IncludeEventTickets).Append("\n");
            sb.Append("  GameTypes: ").Append(GameTypes).Append("\n");
            sb.Append("  ScheduleEvents: ").Append(ScheduleEvents).Append("\n");
            sb.Append("  Abschallenges: ").Append(Abschallenges).Append("\n");
            sb.Append("  Challenges: ").Append(Challenges).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  TeamsWithGames: ").Append(TeamsWithGames).Append("\n");
            sb.Append("  ScheduleItems: ").Append(ScheduleItems).Append("\n");
            sb.Append("  HomeRuns: ").Append(HomeRuns).Append("\n");
            sb.Append("  Alerts: ").Append(Alerts).Append("\n");
            sb.Append("  _BaseballSchedule: ").Append(_BaseballSchedule).Append("\n");
            sb.Append("  HydratedStats: ").Append(HydratedStats).Append("\n");
            sb.Append("  HydratedPeople: ").Append(HydratedPeople).Append("\n");
            sb.Append("  PreviousPlay: ").Append(PreviousPlay).Append("\n");
            sb.Append("  HydratedTeamLeadersInPreview: ").Append(HydratedTeamLeadersInPreview).Append("\n");
            sb.Append("  HydratedTeamLeaders: ").Append(HydratedTeamLeaders).Append("\n");
            sb.Append("  ProbablePitchersNotes: ").Append(ProbablePitchersNotes).Append("\n");
            sb.Append("  HydratedProbablePitchers: ").Append(HydratedProbablePitchers).Append("\n");
            sb.Append("  LiveLookins: ").Append(LiveLookins).Append("\n");
            sb.Append("  BaseballLineups: ").Append(BaseballLineups).Append("\n");
            sb.Append("  ProbableOfficials: ").Append(ProbableOfficials).Append("\n");
            sb.Append("  HydratedTeamsAsString: ").Append(HydratedTeamsAsString).Append("\n");
            sb.Append("  HydratedVenuesAsString: ").Append(HydratedVenuesAsString).Append("\n");
            sb.Append("  HydratedEventVenuesAsString: ").Append(HydratedEventVenuesAsString).Append("\n");
            sb.Append("  HydratedEventDivisionsAsString: ").Append(HydratedEventDivisionsAsString).Append("\n");
            sb.Append("  HydratedEventLeaguesAsString: ").Append(HydratedEventLeaguesAsString).Append("\n");
            sb.Append("  HydratedEventSportsAsString: ").Append(HydratedEventSportsAsString).Append("\n");
            sb.Append("  GamePreviewStoryLegacy: ").Append(GamePreviewStoryLegacy).Append("\n");
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