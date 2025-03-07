using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballScheduleItemRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets GamePk
        /// </summary>
        [DataMember(Name = "gamePk", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamePk")]
        public int? GamePk { get; set; }

        /// <summary>
        /// Gets or Sets GameGuid
        /// </summary>
        [DataMember(Name = "gameGuid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameGuid")]
        public string GameGuid { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets GameType
        /// </summary>
        [DataMember(Name = "gameType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameType")]
        public string GameType { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or Sets GameDate
        /// </summary>
        [DataMember(Name = "gameDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameDate")]
        public DateTime? GameDate { get; set; }

        /// <summary>
        /// Gets or Sets OfficialDate
        /// </summary>
        [DataMember(Name = "officialDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "officialDate")]
        public DateTime? OfficialDate { get; set; }

        /// <summary>
        /// Gets or Sets ResumeDate
        /// </summary>
        [DataMember(Name = "resumeDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resumeDate")]
        public DateTime? ResumeDate { get; set; }

        /// <summary>
        /// Gets or Sets ResumeGameDate
        /// </summary>
        [DataMember(Name = "resumeGameDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resumeGameDate")]
        public DateTime? ResumeGameDate { get; set; }

        /// <summary>
        /// Gets or Sets ResumedFrom
        /// </summary>
        [DataMember(Name = "resumedFrom", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resumedFrom")]
        public DateTime? ResumedFrom { get; set; }

        /// <summary>
        /// Gets or Sets ResumedFromDate
        /// </summary>
        [DataMember(Name = "resumedFromDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resumedFromDate")]
        public DateTime? ResumedFromDate { get; set; }

        /// <summary>
        /// Gets or Sets RescheduleDate
        /// </summary>
        [DataMember(Name = "rescheduleDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rescheduleDate")]
        public DateTime? RescheduleDate { get; set; }

        /// <summary>
        /// Gets or Sets RescheduleGameDate
        /// </summary>
        [DataMember(Name = "rescheduleGameDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rescheduleGameDate")]
        public DateTime? RescheduleGameDate { get; set; }

        /// <summary>
        /// Gets or Sets RescheduledFrom
        /// </summary>
        [DataMember(Name = "rescheduledFrom", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rescheduledFrom")]
        public DateTime? RescheduledFrom { get; set; }

        /// <summary>
        /// Gets or Sets RescheduledFromDate
        /// </summary>
        [DataMember(Name = "rescheduledFromDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rescheduledFromDate")]
        public DateTime? RescheduledFromDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDateTime
        /// </summary>
        [DataMember(Name = "endDateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endDateTime")]
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public GameStatusRestObject Status { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teams")]
        public Dictionary<string, BaseballScheduleItemTeamRestObject> Teams { get; set; }

        /// <summary>
        /// Gets or Sets Linescore
        /// </summary>
        [DataMember(Name = "linescore", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "linescore")]
        public BaseballLinescoreRestObject Linescore { get; set; }

        /// <summary>
        /// Gets or Sets Decisions
        /// </summary>
        [DataMember(Name = "decisions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "decisions")]
        public BaseballDecisionRestObject Decisions { get; set; }

        /// <summary>
        /// Gets or Sets ScoringPlays
        /// </summary>
        [DataMember(Name = "scoringPlays", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scoringPlays")]
        public List<BaseballPlayRestObject> ScoringPlays { get; set; }

        /// <summary>
        /// Gets or Sets Venue
        /// </summary>
        [DataMember(Name = "venue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "venue")]
        public VenueRestObject Venue { get; set; }

        /// <summary>
        /// Gets or Sets Tickets
        /// </summary>
        [DataMember(Name = "tickets", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tickets")]
        public List<BaseballTicketRestObject> Tickets { get; set; }

        /// <summary>
        /// Gets or Sets AtBatTickets
        /// </summary>
        [DataMember(Name = "atBatTickets", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "atBatTickets")]
        public List<BaseballTicketRestObject> AtBatTickets { get; set; }

        /// <summary>
        /// Gets or Sets Promotions
        /// </summary>
        [DataMember(Name = "promotions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "promotions")]
        public List<PromotionRestObject> Promotions { get; set; }

        /// <summary>
        /// Gets or Sets AtBatPromotions
        /// </summary>
        [DataMember(Name = "atBatPromotions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "atBatPromotions")]
        public List<PromotionRestObject> AtBatPromotions { get; set; }

        /// <summary>
        /// Gets or Sets Sponsorships
        /// </summary>
        [DataMember(Name = "sponsorships", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sponsorships")]
        public List<PromotionRestObject> Sponsorships { get; set; }

        /// <summary>
        /// Gets or Sets Broadcasts
        /// </summary>
        [DataMember(Name = "broadcasts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcasts")]
        public List<GameDateBroadcastRestObject> Broadcasts { get; set; }

        /// <summary>
        /// Gets or Sets RadioBroadcasts
        /// </summary>
        [DataMember(Name = "radioBroadcasts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "radioBroadcasts")]
        public List<GameDateBroadcastRestObject> RadioBroadcasts { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "content")]
        public GameContentRestObject Content { get; set; }

        /// <summary>
        /// Gets or Sets SeriesStatus
        /// </summary>
        [DataMember(Name = "seriesStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seriesStatus")]
        public SeriesStatusRestObject SeriesStatus { get; set; }

        /// <summary>
        /// Gets or Sets IsDefaultGame
        /// </summary>
        [DataMember(Name = "isDefaultGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isDefaultGame")]
        public bool? IsDefaultGame { get; set; }

        /// <summary>
        /// Gets or Sets SortNumber
        /// </summary>
        [DataMember(Name = "sortNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortNumber")]
        public int? SortNumber { get; set; }

        /// <summary>
        /// Gets or Sets IsTie
        /// </summary>
        [DataMember(Name = "isTie", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isTie")]
        public bool? IsTie { get; set; }

        /// <summary>
        /// Gets or Sets IsFeaturedGame
        /// </summary>
        [DataMember(Name = "isFeaturedGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isFeaturedGame")]
        public bool? IsFeaturedGame { get; set; }

        /// <summary>
        /// Gets or Sets Officials
        /// </summary>
        [DataMember(Name = "officials", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "officials")]
        public List<OfficialRestObject> Officials { get; set; }

        /// <summary>
        /// Gets or Sets PregameOfficials
        /// </summary>
        [DataMember(Name = "pregameOfficials", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pregameOfficials")]
        public List<OfficialRestObject> PregameOfficials { get; set; }

        /// <summary>
        /// Gets or Sets Weather
        /// </summary>
        [DataMember(Name = "weather", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "weather")]
        public WeatherRestObject Weather { get; set; }

        /// <summary>
        /// Gets or Sets XrefIds
        /// </summary>
        [DataMember(Name = "xrefIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "xrefIds")]
        public List<XrefIdRestObject> XrefIds { get; set; }

        /// <summary>
        /// Gets or Sets GameInfo
        /// </summary>
        [DataMember(Name = "gameInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameInfo")]
        public GameInfoRestObject GameInfo { get; set; }

        /// <summary>
        /// Gets or Sets GameNumber
        /// </summary>
        [DataMember(Name = "gameNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameNumber")]
        public int? GameNumber { get; set; }

        /// <summary>
        /// Gets or Sets PublicFacing
        /// </summary>
        [DataMember(Name = "publicFacing", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "publicFacing")]
        public bool? PublicFacing { get; set; }

        /// <summary>
        /// Gets or Sets Story
        /// </summary>
        [DataMember(Name = "story", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "story")]
        public GameStoryRestObject Story { get; set; }

        /// <summary>
        /// Gets or Sets WeatherForecast
        /// </summary>
        [DataMember(Name = "weatherForecast", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "weatherForecast")]
        public VendorWeatherForecastRestObject WeatherForecast { get; set; }

        /// <summary>
        /// Gets or Sets RuleSettings
        /// </summary>
        [DataMember(Name = "ruleSettings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ruleSettings")]
        public List<RuleSettingsRestObject> RuleSettings { get; set; }

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
        public List<string> CoachingVideo { get; set; }

        /// <summary>
        /// Gets or Sets DoubleHeader
        /// </summary>
        [DataMember(Name = "doubleHeader", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "doubleHeader")]
        public string DoubleHeader { get; set; }

        /// <summary>
        /// Gets or Sets GamedayType
        /// </summary>
        [DataMember(Name = "gamedayType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamedayType")]
        public string GamedayType { get; set; }

        /// <summary>
        /// Gets or Sets Tiebreaker
        /// </summary>
        [DataMember(Name = "tiebreaker", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tiebreaker")]
        public string Tiebreaker { get; set; }

        /// <summary>
        /// Gets or Sets CalendarEventID
        /// </summary>
        [DataMember(Name = "calendarEventID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "calendarEventID")]
        public string CalendarEventID { get; set; }

        /// <summary>
        /// Gets or Sets SeasonDisplay
        /// </summary>
        [DataMember(Name = "seasonDisplay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seasonDisplay")]
        public string SeasonDisplay { get; set; }

        /// <summary>
        /// Gets or Sets DayNight
        /// </summary>
        [DataMember(Name = "dayNight", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dayNight")]
        public string DayNight { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledInnings
        /// </summary>
        [DataMember(Name = "scheduledInnings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scheduledInnings")]
        public int? ScheduledInnings { get; set; }

        /// <summary>
        /// Gets or Sets ReverseHomeAwayStatus
        /// </summary>
        [DataMember(Name = "reverseHomeAwayStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reverseHomeAwayStatus")]
        public bool? ReverseHomeAwayStatus { get; set; }

        /// <summary>
        /// Gets or Sets InningBreakLength
        /// </summary>
        [DataMember(Name = "inningBreakLength", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inningBreakLength")]
        public int? InningBreakLength { get; set; }

        /// <summary>
        /// Gets or Sets GamesInSeries
        /// </summary>
        [DataMember(Name = "gamesInSeries", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamesInSeries")]
        public int? GamesInSeries { get; set; }

        /// <summary>
        /// Gets or Sets SeriesGameNumber
        /// </summary>
        [DataMember(Name = "seriesGameNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seriesGameNumber")]
        public int? SeriesGameNumber { get; set; }

        /// <summary>
        /// Gets or Sets SeriesDescription
        /// </summary>
        [DataMember(Name = "seriesDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seriesDescription")]
        public string SeriesDescription { get; set; }

        /// <summary>
        /// Gets or Sets Review
        /// </summary>
        [DataMember(Name = "review", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "review")]
        public BaseballReviewRestObject Review { get; set; }

        /// <summary>
        /// Gets or Sets AbsChallenge
        /// </summary>
        [DataMember(Name = "absChallenge", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "absChallenge")]
        public BaseballABSChallengeRestObject AbsChallenge { get; set; }

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "flags")]
        public BaseballGameFlagRestObject Flags { get; set; }

        /// <summary>
        /// Gets or Sets StatusFlags
        /// </summary>
        [DataMember(Name = "statusFlags", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statusFlags")]
        public StatusFlagsRestObject StatusFlags { get; set; }

        /// <summary>
        /// Gets or Sets Alerts
        /// </summary>
        [DataMember(Name = "alerts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "alerts")]
        public List<BaseballGameAlertRestObject> Alerts { get; set; }

        /// <summary>
        /// Gets or Sets LiveLookin
        /// </summary>
        [DataMember(Name = "liveLookin", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "liveLookin")]
        public BaseballGameLiveLookinRestObject LiveLookin { get; set; }

        /// <summary>
        /// Gets or Sets PreviousPlay
        /// </summary>
        [DataMember(Name = "previousPlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "previousPlay")]
        public BaseballPlayRestObject PreviousPlay { get; set; }

        /// <summary>
        /// Gets or Sets HomeRuns
        /// </summary>
        [DataMember(Name = "homeRuns", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeRuns")]
        public List<BaseballPlayRestObject> HomeRuns { get; set; }

        /// <summary>
        /// Gets or Sets RecordSource
        /// </summary>
        [DataMember(Name = "recordSource", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recordSource")]
        public string RecordSource { get; set; }

        /// <summary>
        /// Gets or Sets IfNecessary
        /// </summary>
        [DataMember(Name = "ifNecessary", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ifNecessary")]
        public string IfNecessary { get; set; }

        /// <summary>
        /// Gets or Sets IfNecessaryDescription
        /// </summary>
        [DataMember(Name = "ifNecessaryDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ifNecessaryDescription")]
        public string IfNecessaryDescription { get; set; }

        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name = "day", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "day")]
        public string Day { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name = "gameId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameId")]
        public string GameId { get; set; }

        /// <summary>
        /// Gets or Sets Lineups
        /// </summary>
        [DataMember(Name = "lineups", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lineups")]
        public BaseballLineupRestObject Lineups { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballScheduleItemRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  GamePk: ").Append(GamePk).Append("\n");
            sb.Append("  GameGuid: ").Append(GameGuid).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  GameType: ").Append(GameType).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  GameDate: ").Append(GameDate).Append("\n");
            sb.Append("  OfficialDate: ").Append(OfficialDate).Append("\n");
            sb.Append("  ResumeDate: ").Append(ResumeDate).Append("\n");
            sb.Append("  ResumeGameDate: ").Append(ResumeGameDate).Append("\n");
            sb.Append("  ResumedFrom: ").Append(ResumedFrom).Append("\n");
            sb.Append("  ResumedFromDate: ").Append(ResumedFromDate).Append("\n");
            sb.Append("  RescheduleDate: ").Append(RescheduleDate).Append("\n");
            sb.Append("  RescheduleGameDate: ").Append(RescheduleGameDate).Append("\n");
            sb.Append("  RescheduledFrom: ").Append(RescheduledFrom).Append("\n");
            sb.Append("  RescheduledFromDate: ").Append(RescheduledFromDate).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
            sb.Append("  Linescore: ").Append(Linescore).Append("\n");
            sb.Append("  Decisions: ").Append(Decisions).Append("\n");
            sb.Append("  ScoringPlays: ").Append(ScoringPlays).Append("\n");
            sb.Append("  Venue: ").Append(Venue).Append("\n");
            sb.Append("  Tickets: ").Append(Tickets).Append("\n");
            sb.Append("  AtBatTickets: ").Append(AtBatTickets).Append("\n");
            sb.Append("  Promotions: ").Append(Promotions).Append("\n");
            sb.Append("  AtBatPromotions: ").Append(AtBatPromotions).Append("\n");
            sb.Append("  Sponsorships: ").Append(Sponsorships).Append("\n");
            sb.Append("  Broadcasts: ").Append(Broadcasts).Append("\n");
            sb.Append("  RadioBroadcasts: ").Append(RadioBroadcasts).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  SeriesStatus: ").Append(SeriesStatus).Append("\n");
            sb.Append("  IsDefaultGame: ").Append(IsDefaultGame).Append("\n");
            sb.Append("  SortNumber: ").Append(SortNumber).Append("\n");
            sb.Append("  IsTie: ").Append(IsTie).Append("\n");
            sb.Append("  IsFeaturedGame: ").Append(IsFeaturedGame).Append("\n");
            sb.Append("  Officials: ").Append(Officials).Append("\n");
            sb.Append("  PregameOfficials: ").Append(PregameOfficials).Append("\n");
            sb.Append("  Weather: ").Append(Weather).Append("\n");
            sb.Append("  XrefIds: ").Append(XrefIds).Append("\n");
            sb.Append("  GameInfo: ").Append(GameInfo).Append("\n");
            sb.Append("  GameNumber: ").Append(GameNumber).Append("\n");
            sb.Append("  PublicFacing: ").Append(PublicFacing).Append("\n");
            sb.Append("  Story: ").Append(Story).Append("\n");
            sb.Append("  WeatherForecast: ").Append(WeatherForecast).Append("\n");
            sb.Append("  RuleSettings: ").Append(RuleSettings).Append("\n");
            sb.Append("  TrackingVersion: ").Append(TrackingVersion).Append("\n");
            sb.Append("  CoachingVideo: ").Append(CoachingVideo).Append("\n");
            sb.Append("  DoubleHeader: ").Append(DoubleHeader).Append("\n");
            sb.Append("  GamedayType: ").Append(GamedayType).Append("\n");
            sb.Append("  Tiebreaker: ").Append(Tiebreaker).Append("\n");
            sb.Append("  CalendarEventID: ").Append(CalendarEventID).Append("\n");
            sb.Append("  SeasonDisplay: ").Append(SeasonDisplay).Append("\n");
            sb.Append("  DayNight: ").Append(DayNight).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ScheduledInnings: ").Append(ScheduledInnings).Append("\n");
            sb.Append("  ReverseHomeAwayStatus: ").Append(ReverseHomeAwayStatus).Append("\n");
            sb.Append("  InningBreakLength: ").Append(InningBreakLength).Append("\n");
            sb.Append("  GamesInSeries: ").Append(GamesInSeries).Append("\n");
            sb.Append("  SeriesGameNumber: ").Append(SeriesGameNumber).Append("\n");
            sb.Append("  SeriesDescription: ").Append(SeriesDescription).Append("\n");
            sb.Append("  Review: ").Append(Review).Append("\n");
            sb.Append("  AbsChallenge: ").Append(AbsChallenge).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  StatusFlags: ").Append(StatusFlags).Append("\n");
            sb.Append("  Alerts: ").Append(Alerts).Append("\n");
            sb.Append("  LiveLookin: ").Append(LiveLookin).Append("\n");
            sb.Append("  PreviousPlay: ").Append(PreviousPlay).Append("\n");
            sb.Append("  HomeRuns: ").Append(HomeRuns).Append("\n");
            sb.Append("  RecordSource: ").Append(RecordSource).Append("\n");
            sb.Append("  IfNecessary: ").Append(IfNecessary).Append("\n");
            sb.Append("  IfNecessaryDescription: ").Append(IfNecessaryDescription).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Lineups: ").Append(Lineups).Append("\n");
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