using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballScheduleItem
    {
        /// <summary>
        /// Gets or Sets CalendarEventId
        /// </summary>
        [DataMember(Name = "calendarEventId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "calendarEventId")]
        public string CalendarEventId { get; set; }

        /// <summary>
        /// Gets or Sets GamePk
        /// </summary>
        [DataMember(Name = "gamePk", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamePk")]
        public int? GamePk { get; set; }

        /// <summary>
        /// Gets or Sets GameType
        /// </summary>
        [DataMember(Name = "gameType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameType")]
        public GameTypeEnum GameType { get; set; }

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
        /// Gets or Sets CalendarDate
        /// </summary>
        [DataMember(Name = "calendarDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "calendarDate")]
        public DateTime? CalendarDate { get; set; }

        /// <summary>
        /// Gets or Sets UnmodifiedCalendarDate
        /// </summary>
        [DataMember(Name = "unmodifiedCalendarDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "unmodifiedCalendarDate")]
        public DateTime? UnmodifiedCalendarDate { get; set; }

        /// <summary>
        /// Gets or Sets ResumeGameDate
        /// </summary>
        [DataMember(Name = "resumeGameDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resumeGameDate")]
        public DateTime? ResumeGameDate { get; set; }

        /// <summary>
        /// Gets or Sets ResumeDate
        /// </summary>
        [DataMember(Name = "resumeDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resumeDate")]
        public DateTime? ResumeDate { get; set; }

        /// <summary>
        /// Gets or Sets ResumedFromDate
        /// </summary>
        [DataMember(Name = "resumedFromDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resumedFromDate")]
        public DateTime? ResumedFromDate { get; set; }

        /// <summary>
        /// Gets or Sets ResumedFrom
        /// </summary>
        [DataMember(Name = "resumedFrom", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resumedFrom")]
        public DateTime? ResumedFrom { get; set; }

        /// <summary>
        /// Gets or Sets RescheduleGameDate
        /// </summary>
        [DataMember(Name = "rescheduleGameDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rescheduleGameDate")]
        public DateTime? RescheduleGameDate { get; set; }

        /// <summary>
        /// Gets or Sets RescheduleDate
        /// </summary>
        [DataMember(Name = "rescheduleDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rescheduleDate")]
        public DateTime? RescheduleDate { get; set; }

        /// <summary>
        /// Gets or Sets RescheduledFromDate
        /// </summary>
        [DataMember(Name = "rescheduledFromDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rescheduledFromDate")]
        public DateTime? RescheduledFromDate { get; set; }

        /// <summary>
        /// Gets or Sets RescheduledFrom
        /// </summary>
        [DataMember(Name = "rescheduledFrom", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rescheduledFrom")]
        public DateTime? RescheduledFrom { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or Sets StatusInd
        /// </summary>
        [DataMember(Name = "statusInd", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statusInd")]
        public string StatusInd { get; set; }

        /// <summary>
        /// Gets or Sets GameNumber
        /// </summary>
        [DataMember(Name = "gameNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameNumber")]
        public int? GameNumber { get; set; }

        /// <summary>
        /// Gets or Sets GameStatus
        /// </summary>
        [DataMember(Name = "gameStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameStatus")]
        public IGameStatus GameStatus { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeam
        /// </summary>
        [DataMember(Name = "awayTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayTeam")]
        public BaseballTeam AwayTeam { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeam
        /// </summary>
        [DataMember(Name = "homeTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeTeam")]
        public BaseballTeam HomeTeam { get; set; }

        /// <summary>
        /// Gets or Sets Venue
        /// </summary>
        [DataMember(Name = "venue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "venue")]
        public Venue Venue { get; set; }

        /// <summary>
        /// Gets or Sets ResumeVenue
        /// </summary>
        [DataMember(Name = "resumeVenue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resumeVenue")]
        public Venue ResumeVenue { get; set; }

        /// <summary>
        /// Gets or Sets ResumedFromVenue
        /// </summary>
        [DataMember(Name = "resumedFromVenue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resumedFromVenue")]
        public Venue ResumedFromVenue { get; set; }

        /// <summary>
        /// Gets or Sets Cms
        /// </summary>
        [DataMember(Name = "cms", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cms")]
        public GameCms Cms { get; set; }

        /// <summary>
        /// Gets or Sets AwayScore
        /// </summary>
        [DataMember(Name = "awayScore", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayScore")]
        public int? AwayScore { get; set; }

        /// <summary>
        /// Gets or Sets HomeScore
        /// </summary>
        [DataMember(Name = "homeScore", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeScore")]
        public int? HomeScore { get; set; }

        /// <summary>
        /// Gets or Sets AwayWins
        /// </summary>
        [DataMember(Name = "awayWins", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayWins")]
        public int? AwayWins { get; set; }

        /// <summary>
        /// Gets or Sets AwayLosses
        /// </summary>
        [DataMember(Name = "awayLosses", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayLosses")]
        public int? AwayLosses { get; set; }

        /// <summary>
        /// Gets or Sets AwayOvertimeLosses
        /// </summary>
        [DataMember(Name = "awayOvertimeLosses", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayOvertimeLosses")]
        public int? AwayOvertimeLosses { get; set; }

        /// <summary>
        /// Gets or Sets AwayTies
        /// </summary>
        [DataMember(Name = "awayTies", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayTies")]
        public int? AwayTies { get; set; }

        /// <summary>
        /// Gets or Sets AwayIsWinner
        /// </summary>
        [DataMember(Name = "awayIsWinner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayIsWinner")]
        public bool? AwayIsWinner { get; set; }

        /// <summary>
        /// Gets or Sets HomeWins
        /// </summary>
        [DataMember(Name = "homeWins", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeWins")]
        public int? HomeWins { get; set; }

        /// <summary>
        /// Gets or Sets HomeLosses
        /// </summary>
        [DataMember(Name = "homeLosses", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeLosses")]
        public int? HomeLosses { get; set; }

        /// <summary>
        /// Gets or Sets PostseasonSeries
        /// </summary>
        [DataMember(Name = "postseasonSeries", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postseasonSeries")]
        public PostseasonSeries PostseasonSeries { get; set; }

        /// <summary>
        /// Gets or Sets HomeOvertimeLosses
        /// </summary>
        [DataMember(Name = "homeOvertimeLosses", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeOvertimeLosses")]
        public int? HomeOvertimeLosses { get; set; }

        /// <summary>
        /// Gets or Sets HomeTies
        /// </summary>
        [DataMember(Name = "homeTies", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeTies")]
        public int? HomeTies { get; set; }

        /// <summary>
        /// Gets or Sets HomeIsWinner
        /// </summary>
        [DataMember(Name = "homeIsWinner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeIsWinner")]
        public bool? HomeIsWinner { get; set; }

        /// <summary>
        /// Gets or Sets IsTie
        /// </summary>
        [DataMember(Name = "isTie", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isTie")]
        public bool? IsTie { get; set; }

        /// <summary>
        /// Gets or Sets Linescore
        /// </summary>
        [DataMember(Name = "linescore", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "linescore")]
        public BaseballLinescore Linescore { get; set; }

        /// <summary>
        /// Gets or Sets Decisions
        /// </summary>
        [DataMember(Name = "decisions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "decisions")]
        public BaseballDecision Decisions { get; set; }

        /// <summary>
        /// Gets or Sets ScoringPlays
        /// </summary>
        [DataMember(Name = "scoringPlays", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scoringPlays")]
        public List<BaseballPlay> ScoringPlays { get; set; }

        /// <summary>
        /// Gets or Sets Broadcasts
        /// </summary>
        [DataMember(Name = "broadcasts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "broadcasts")]
        public List<GameDateBroadcast> Broadcasts { get; set; }

        /// <summary>
        /// Gets or Sets RadioBroadcasts
        /// </summary>
        [DataMember(Name = "radioBroadcasts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "radioBroadcasts")]
        public List<GameDateBroadcast> RadioBroadcasts { get; set; }

        /// <summary>
        /// Gets or Sets EndDateTime
        /// </summary>
        [DataMember(Name = "endDateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endDateTime")]
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Gets or Sets IsDefaultGame
        /// </summary>
        [DataMember(Name = "isDefaultGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isDefaultGame")]
        public bool? IsDefaultGame { get; set; }

        /// <summary>
        /// Gets or Sets Promotions
        /// </summary>
        [DataMember(Name = "promotions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "promotions")]
        public List<Promotion> Promotions { get; set; }

        /// <summary>
        /// Gets or Sets AtBatPromotions
        /// </summary>
        [DataMember(Name = "atBatPromotions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "atBatPromotions")]
        public List<Promotion> AtBatPromotions { get; set; }

        /// <summary>
        /// Gets or Sets Sponsorships
        /// </summary>
        [DataMember(Name = "sponsorships", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sponsorships")]
        public List<Promotion> Sponsorships { get; set; }

        /// <summary>
        /// Gets or Sets Officials
        /// </summary>
        [DataMember(Name = "officials", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "officials")]
        public List<Official> Officials { get; set; }

        /// <summary>
        /// Gets or Sets PregameOfficials
        /// </summary>
        [DataMember(Name = "pregameOfficials", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pregameOfficials")]
        public List<Official> PregameOfficials { get; set; }

        /// <summary>
        /// Gets or Sets Weather
        /// </summary>
        [DataMember(Name = "weather", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "weather")]
        public Weather Weather { get; set; }

        /// <summary>
        /// Gets or Sets GameInfo
        /// </summary>
        [DataMember(Name = "gameInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameInfo")]
        public GameTO GameInfo { get; set; }

        /// <summary>
        /// Gets or Sets PublicFacing
        /// </summary>
        [DataMember(Name = "publicFacing", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "publicFacing")]
        public PublicFacingEnum PublicFacing { get; set; }

        /// <summary>
        /// Gets or Sets Story
        /// </summary>
        [DataMember(Name = "story", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "story")]
        public GameStory Story { get; set; }

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
        /// Gets or Sets AtBatTicketLinks
        /// </summary>
        [DataMember(Name = "atBatTicketLinks", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "atBatTicketLinks")]
        public List<BaseballTicket> AtBatTicketLinks { get; set; }

        /// <summary>
        /// Gets or Sets SeriesStatus
        /// </summary>
        [DataMember(Name = "seriesStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seriesStatus")]
        public SeriesStatus SeriesStatus { get; set; }

        /// <summary>
        /// Gets or Sets SortNumber
        /// </summary>
        [DataMember(Name = "sortNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortNumber")]
        public int? SortNumber { get; set; }

        /// <summary>
        /// Gets or Sets IsFeaturedGame
        /// </summary>
        [DataMember(Name = "isFeaturedGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isFeaturedGame")]
        public bool? IsFeaturedGame { get; set; }

        /// <summary>
        /// Gets or Sets XrefIds
        /// </summary>
        [DataMember(Name = "xrefIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "xrefIds")]
        public List<XrefId> XrefIds { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name = "gameId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameId")]
        public string GameId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets SeriesDescription
        /// </summary>
        [DataMember(Name = "seriesDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seriesDescription")]
        public string SeriesDescription { get; set; }

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
        /// Gets or Sets ScheduledInnings
        /// </summary>
        [DataMember(Name = "scheduledInnings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scheduledInnings")]
        public int? ScheduledInnings { get; set; }

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
        /// Gets or Sets EditorialGameType
        /// </summary>
        [DataMember(Name = "editorialGameType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "editorialGameType")]
        public string EditorialGameType { get; set; }

        /// <summary>
        /// Gets or Sets EditorialSeason
        /// </summary>
        [DataMember(Name = "editorialSeason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "editorialSeason")]
        public string EditorialSeason { get; set; }

        /// <summary>
        /// Gets or Sets LocalTime
        /// </summary>
        [DataMember(Name = "localTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "localTime")]
        public string LocalTime { get; set; }

        /// <summary>
        /// Gets or Sets LocalAmPm
        /// </summary>
        [DataMember(Name = "localAmPm", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "localAmPm")]
        public string LocalAmPm { get; set; }

        /// <summary>
        /// Gets or Sets LocalDate
        /// </summary>
        [DataMember(Name = "localDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "localDate")]
        public DateTime? LocalDate { get; set; }

        /// <summary>
        /// Gets or Sets AwayGamesBack
        /// </summary>
        [DataMember(Name = "awayGamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayGamesBack")]
        public string AwayGamesBack { get; set; }

        /// <summary>
        /// Gets or Sets AwayWildCardGamesBack
        /// </summary>
        [DataMember(Name = "awayWildCardGamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayWildCardGamesBack")]
        public string AwayWildCardGamesBack { get; set; }

        /// <summary>
        /// Gets or Sets AwaySplitSquad
        /// </summary>
        [DataMember(Name = "awaySplitSquad", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awaySplitSquad")]
        public bool? AwaySplitSquad { get; set; }

        /// <summary>
        /// Gets or Sets AwaySeriesNumber
        /// </summary>
        [DataMember(Name = "awaySeriesNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awaySeriesNumber")]
        public int? AwaySeriesNumber { get; set; }

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
        /// Gets or Sets HomeGamesBack
        /// </summary>
        [DataMember(Name = "homeGamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeGamesBack")]
        public string HomeGamesBack { get; set; }

        /// <summary>
        /// Gets or Sets HomeWildCardGamesBack
        /// </summary>
        [DataMember(Name = "homeWildCardGamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeWildCardGamesBack")]
        public string HomeWildCardGamesBack { get; set; }

        /// <summary>
        /// Gets or Sets HomeSplitSquad
        /// </summary>
        [DataMember(Name = "homeSplitSquad", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeSplitSquad")]
        public bool? HomeSplitSquad { get; set; }

        /// <summary>
        /// Gets or Sets HomeSeriesNumber
        /// </summary>
        [DataMember(Name = "homeSeriesNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeSeriesNumber")]
        public int? HomeSeriesNumber { get; set; }

        /// <summary>
        /// Gets or Sets IsNightGame
        /// </summary>
        [DataMember(Name = "isNightGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isNightGame")]
        public bool? IsNightGame { get; set; }

        /// <summary>
        /// Gets or Sets AwayProbable
        /// </summary>
        [DataMember(Name = "awayProbable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayProbable")]
        public BaseballPerson AwayProbable { get; set; }

        /// <summary>
        /// Gets or Sets HomeProbable
        /// </summary>
        [DataMember(Name = "homeProbable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeProbable")]
        public BaseballPerson HomeProbable { get; set; }

        /// <summary>
        /// Gets or Sets Challenge
        /// </summary>
        [DataMember(Name = "challenge", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "challenge")]
        public BaseballChallenge Challenge { get; set; }

        /// <summary>
        /// Gets or Sets AbsChallenge
        /// </summary>
        [DataMember(Name = "absChallenge", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "absChallenge")]
        public BaseballABSChallenge AbsChallenge { get; set; }

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "flags")]
        public BaseballGameFlag Flags { get; set; }

        /// <summary>
        /// Gets or Sets Alerts
        /// </summary>
        [DataMember(Name = "alerts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "alerts")]
        public List<BaseballGameAlert> Alerts { get; set; }

        /// <summary>
        /// Gets or Sets LiveLookin
        /// </summary>
        [DataMember(Name = "liveLookin", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "liveLookin")]
        public LiveLookin LiveLookin { get; set; }

        /// <summary>
        /// Gets or Sets SortTime
        /// </summary>
        [DataMember(Name = "sortTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortTime")]
        public string SortTime { get; set; }

        /// <summary>
        /// Gets or Sets SortTeam
        /// </summary>
        [DataMember(Name = "sortTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortTeam")]
        public string SortTeam { get; set; }

        /// <summary>
        /// Gets or Sets SortGameId
        /// </summary>
        [DataMember(Name = "sortGameId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortGameId")]
        public string SortGameId { get; set; }

        /// <summary>
        /// Gets or Sets SortGameNo
        /// </summary>
        [DataMember(Name = "sortGameNo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortGameNo")]
        public string SortGameNo { get; set; }

        /// <summary>
        /// Gets or Sets PreviousPlay
        /// </summary>
        [DataMember(Name = "previousPlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "previousPlay")]
        public BaseballPlay PreviousPlay { get; set; }

        /// <summary>
        /// Gets or Sets HomeRuns
        /// </summary>
        [DataMember(Name = "homeRuns", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeRuns")]
        public List<BaseballPlay> HomeRuns { get; set; }

        /// <summary>
        /// Gets or Sets Tickets
        /// </summary>
        [DataMember(Name = "tickets", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tickets")]
        public List<BaseballTicket> Tickets { get; set; }

        /// <summary>
        /// Gets or Sets AtBatTickets
        /// </summary>
        [DataMember(Name = "atBatTickets", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "atBatTickets")]
        public List<BaseballTicket> AtBatTickets { get; set; }

        /// <summary>
        /// Gets or Sets SportId
        /// </summary>
        [DataMember(Name = "sportId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sportId")]
        public int? SportId { get; set; }

        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name = "day", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "day")]
        public string Day { get; set; }

        /// <summary>
        /// Gets or Sets HomeLeagueId
        /// </summary>
        [DataMember(Name = "homeLeagueId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeLeagueId")]
        public int? HomeLeagueId { get; set; }

        /// <summary>
        /// Gets or Sets AwayLeagueId
        /// </summary>
        [DataMember(Name = "awayLeagueId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayLeagueId")]
        public int? AwayLeagueId { get; set; }

        /// <summary>
        /// Gets or Sets BaseballLineup
        /// </summary>
        [DataMember(Name = "baseballLineup", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "baseballLineup")]
        public BaseballLineup BaseballLineup { get; set; }

        /// <summary>
        /// Gets or Sets DoubleHeaderGameOneTime
        /// </summary>
        [DataMember(Name = "doubleHeaderGameOneTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "doubleHeaderGameOneTime")]
        public DateTime? DoubleHeaderGameOneTime { get; set; }

        /// <summary>
        /// Gets or Sets ReverseHomeAwayStatus
        /// </summary>
        [DataMember(Name = "reverseHomeAwayStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reverseHomeAwayStatus")]
        public bool? ReverseHomeAwayStatus { get; set; }

        /// <summary>
        /// Gets or Sets IsDoNotSortAsDH
        /// </summary>
        [DataMember(Name = "isDoNotSortAsDH", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isDoNotSortAsDH")]
        public bool? IsDoNotSortAsDH { get; set; }

        /// <summary>
        /// Gets or Sets StatusFlags
        /// </summary>
        [DataMember(Name = "statusFlags", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statusFlags")]
        public StatusFlags StatusFlags { get; set; }

        /// <summary>
        /// Gets or Sets GameGuid
        /// </summary>
        [DataMember(Name = "gameGuid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameGuid")]
        public string GameGuid { get; set; }

        /// <summary>
        /// Gets or Sets VendorWeatherForecast
        /// </summary>
        [DataMember(Name = "vendorWeatherForecast", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vendorWeatherForecast")]
        public VendorWeatherForecast VendorWeatherForecast { get; set; }

        /// <summary>
        /// Gets or Sets CacheKey
        /// </summary>
        [DataMember(Name = "cacheKey", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cacheKey")]
        public string CacheKey { get; set; }

        /// <summary>
        /// Gets or Sets LinescoreOverrides
        /// </summary>
        [DataMember(Name = "linescoreOverrides", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "linescoreOverrides")]
        public BaseballLinescore LinescoreOverrides { get; set; }

        /// <summary>
        /// Gets or Sets PostseasonSeriesId
        /// </summary>
        [DataMember(Name = "postseasonSeriesId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postseasonSeriesId")]
        public string PostseasonSeriesId { get; set; }

        /// <summary>
        /// Gets or Sets WinningTeam
        /// </summary>
        [DataMember(Name = "winningTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "winningTeam")]
        public BaseballTeam WinningTeam { get; set; }

        /// <summary>
        /// Gets or Sets Tie
        /// </summary>
        [DataMember(Name = "tie", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tie")]
        public bool? Tie { get; set; }

        /// <summary>
        /// Gets or Sets Hydratable
        /// </summary>
        [DataMember(Name = "hydratable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratable")]
        public bool? Hydratable { get; set; }

        /// <summary>
        /// Gets or Sets NightGame
        /// </summary>
        [DataMember(Name = "nightGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nightGame")]
        public bool? NightGame { get; set; }

        /// <summary>
        /// Gets or Sets LosingTeam
        /// </summary>
        [DataMember(Name = "losingTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "losingTeam")]
        public BaseballTeam LosingTeam { get; set; }

        /// <summary>
        /// Gets or Sets SortDate
        /// </summary>
        [DataMember(Name = "sortDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortDate")]
        public DateTime? SortDate { get; set; }

        /// <summary>
        /// Gets or Sets DoubleHeaderTeamPairKey
        /// </summary>
        [DataMember(Name = "doubleHeaderTeamPairKey", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "doubleHeaderTeamPairKey")]
        public string DoubleHeaderTeamPairKey { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballScheduleItem {\n");
            sb.Append("  CalendarEventId: ").Append(CalendarEventId).Append("\n");
            sb.Append("  GamePk: ").Append(GamePk).Append("\n");
            sb.Append("  GameType: ").Append(GameType).Append("\n");
            sb.Append("  GameDate: ").Append(GameDate).Append("\n");
            sb.Append("  OfficialDate: ").Append(OfficialDate).Append("\n");
            sb.Append("  CalendarDate: ").Append(CalendarDate).Append("\n");
            sb.Append("  UnmodifiedCalendarDate: ").Append(UnmodifiedCalendarDate).Append("\n");
            sb.Append("  ResumeGameDate: ").Append(ResumeGameDate).Append("\n");
            sb.Append("  ResumeDate: ").Append(ResumeDate).Append("\n");
            sb.Append("  ResumedFromDate: ").Append(ResumedFromDate).Append("\n");
            sb.Append("  ResumedFrom: ").Append(ResumedFrom).Append("\n");
            sb.Append("  RescheduleGameDate: ").Append(RescheduleGameDate).Append("\n");
            sb.Append("  RescheduleDate: ").Append(RescheduleDate).Append("\n");
            sb.Append("  RescheduledFromDate: ").Append(RescheduledFromDate).Append("\n");
            sb.Append("  RescheduledFrom: ").Append(RescheduledFrom).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  StatusInd: ").Append(StatusInd).Append("\n");
            sb.Append("  GameNumber: ").Append(GameNumber).Append("\n");
            sb.Append("  GameStatus: ").Append(GameStatus).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
            sb.Append("  Venue: ").Append(Venue).Append("\n");
            sb.Append("  ResumeVenue: ").Append(ResumeVenue).Append("\n");
            sb.Append("  ResumedFromVenue: ").Append(ResumedFromVenue).Append("\n");
            sb.Append("  Cms: ").Append(Cms).Append("\n");
            sb.Append("  AwayScore: ").Append(AwayScore).Append("\n");
            sb.Append("  HomeScore: ").Append(HomeScore).Append("\n");
            sb.Append("  AwayWins: ").Append(AwayWins).Append("\n");
            sb.Append("  AwayLosses: ").Append(AwayLosses).Append("\n");
            sb.Append("  AwayOvertimeLosses: ").Append(AwayOvertimeLosses).Append("\n");
            sb.Append("  AwayTies: ").Append(AwayTies).Append("\n");
            sb.Append("  AwayIsWinner: ").Append(AwayIsWinner).Append("\n");
            sb.Append("  HomeWins: ").Append(HomeWins).Append("\n");
            sb.Append("  HomeLosses: ").Append(HomeLosses).Append("\n");
            sb.Append("  PostseasonSeries: ").Append(PostseasonSeries).Append("\n");
            sb.Append("  HomeOvertimeLosses: ").Append(HomeOvertimeLosses).Append("\n");
            sb.Append("  HomeTies: ").Append(HomeTies).Append("\n");
            sb.Append("  HomeIsWinner: ").Append(HomeIsWinner).Append("\n");
            sb.Append("  IsTie: ").Append(IsTie).Append("\n");
            sb.Append("  Linescore: ").Append(Linescore).Append("\n");
            sb.Append("  Decisions: ").Append(Decisions).Append("\n");
            sb.Append("  ScoringPlays: ").Append(ScoringPlays).Append("\n");
            sb.Append("  Broadcasts: ").Append(Broadcasts).Append("\n");
            sb.Append("  RadioBroadcasts: ").Append(RadioBroadcasts).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  IsDefaultGame: ").Append(IsDefaultGame).Append("\n");
            sb.Append("  Promotions: ").Append(Promotions).Append("\n");
            sb.Append("  AtBatPromotions: ").Append(AtBatPromotions).Append("\n");
            sb.Append("  Sponsorships: ").Append(Sponsorships).Append("\n");
            sb.Append("  Officials: ").Append(Officials).Append("\n");
            sb.Append("  PregameOfficials: ").Append(PregameOfficials).Append("\n");
            sb.Append("  Weather: ").Append(Weather).Append("\n");
            sb.Append("  GameInfo: ").Append(GameInfo).Append("\n");
            sb.Append("  PublicFacing: ").Append(PublicFacing).Append("\n");
            sb.Append("  Story: ").Append(Story).Append("\n");
            sb.Append("  TrackingVersion: ").Append(TrackingVersion).Append("\n");
            sb.Append("  TrackingSystemOwner: ").Append(TrackingSystemOwner).Append("\n");
            sb.Append("  CoachingVideo: ").Append(CoachingVideo).Append("\n");
            sb.Append("  AtBatTicketLinks: ").Append(AtBatTicketLinks).Append("\n");
            sb.Append("  SeriesStatus: ").Append(SeriesStatus).Append("\n");
            sb.Append("  SortNumber: ").Append(SortNumber).Append("\n");
            sb.Append("  IsFeaturedGame: ").Append(IsFeaturedGame).Append("\n");
            sb.Append("  XrefIds: ").Append(XrefIds).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SeriesDescription: ").Append(SeriesDescription).Append("\n");
            sb.Append("  DoubleHeader: ").Append(DoubleHeader).Append("\n");
            sb.Append("  GamedayType: ").Append(GamedayType).Append("\n");
            sb.Append("  Tiebreaker: ").Append(Tiebreaker).Append("\n");
            sb.Append("  ScheduledInnings: ").Append(ScheduledInnings).Append("\n");
            sb.Append("  InningBreakLength: ").Append(InningBreakLength).Append("\n");
            sb.Append("  GamesInSeries: ").Append(GamesInSeries).Append("\n");
            sb.Append("  SeriesGameNumber: ").Append(SeriesGameNumber).Append("\n");
            sb.Append("  EditorialGameType: ").Append(EditorialGameType).Append("\n");
            sb.Append("  EditorialSeason: ").Append(EditorialSeason).Append("\n");
            sb.Append("  LocalTime: ").Append(LocalTime).Append("\n");
            sb.Append("  LocalAmPm: ").Append(LocalAmPm).Append("\n");
            sb.Append("  LocalDate: ").Append(LocalDate).Append("\n");
            sb.Append("  AwayGamesBack: ").Append(AwayGamesBack).Append("\n");
            sb.Append("  AwayWildCardGamesBack: ").Append(AwayWildCardGamesBack).Append("\n");
            sb.Append("  AwaySplitSquad: ").Append(AwaySplitSquad).Append("\n");
            sb.Append("  AwaySeriesNumber: ").Append(AwaySeriesNumber).Append("\n");
            sb.Append("  RecordSource: ").Append(RecordSource).Append("\n");
            sb.Append("  IfNecessary: ").Append(IfNecessary).Append("\n");
            sb.Append("  IfNecessaryDescription: ").Append(IfNecessaryDescription).Append("\n");
            sb.Append("  HomeGamesBack: ").Append(HomeGamesBack).Append("\n");
            sb.Append("  HomeWildCardGamesBack: ").Append(HomeWildCardGamesBack).Append("\n");
            sb.Append("  HomeSplitSquad: ").Append(HomeSplitSquad).Append("\n");
            sb.Append("  HomeSeriesNumber: ").Append(HomeSeriesNumber).Append("\n");
            sb.Append("  IsNightGame: ").Append(IsNightGame).Append("\n");
            sb.Append("  AwayProbable: ").Append(AwayProbable).Append("\n");
            sb.Append("  HomeProbable: ").Append(HomeProbable).Append("\n");
            sb.Append("  Challenge: ").Append(Challenge).Append("\n");
            sb.Append("  AbsChallenge: ").Append(AbsChallenge).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Alerts: ").Append(Alerts).Append("\n");
            sb.Append("  LiveLookin: ").Append(LiveLookin).Append("\n");
            sb.Append("  SortTime: ").Append(SortTime).Append("\n");
            sb.Append("  SortTeam: ").Append(SortTeam).Append("\n");
            sb.Append("  SortGameId: ").Append(SortGameId).Append("\n");
            sb.Append("  SortGameNo: ").Append(SortGameNo).Append("\n");
            sb.Append("  PreviousPlay: ").Append(PreviousPlay).Append("\n");
            sb.Append("  HomeRuns: ").Append(HomeRuns).Append("\n");
            sb.Append("  Tickets: ").Append(Tickets).Append("\n");
            sb.Append("  AtBatTickets: ").Append(AtBatTickets).Append("\n");
            sb.Append("  SportId: ").Append(SportId).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  HomeLeagueId: ").Append(HomeLeagueId).Append("\n");
            sb.Append("  AwayLeagueId: ").Append(AwayLeagueId).Append("\n");
            sb.Append("  BaseballLineup: ").Append(BaseballLineup).Append("\n");
            sb.Append("  DoubleHeaderGameOneTime: ").Append(DoubleHeaderGameOneTime).Append("\n");
            sb.Append("  ReverseHomeAwayStatus: ").Append(ReverseHomeAwayStatus).Append("\n");
            sb.Append("  IsDoNotSortAsDH: ").Append(IsDoNotSortAsDH).Append("\n");
            sb.Append("  StatusFlags: ").Append(StatusFlags).Append("\n");
            sb.Append("  GameGuid: ").Append(GameGuid).Append("\n");
            sb.Append("  VendorWeatherForecast: ").Append(VendorWeatherForecast).Append("\n");
            sb.Append("  CacheKey: ").Append(CacheKey).Append("\n");
            sb.Append("  LinescoreOverrides: ").Append(LinescoreOverrides).Append("\n");
            sb.Append("  PostseasonSeriesId: ").Append(PostseasonSeriesId).Append("\n");
            sb.Append("  WinningTeam: ").Append(WinningTeam).Append("\n");
            sb.Append("  Tie: ").Append(Tie).Append("\n");
            sb.Append("  Hydratable: ").Append(Hydratable).Append("\n");
            sb.Append("  NightGame: ").Append(NightGame).Append("\n");
            sb.Append("  LosingTeam: ").Append(LosingTeam).Append("\n");
            sb.Append("  SortDate: ").Append(SortDate).Append("\n");
            sb.Append("  DoubleHeaderTeamPairKey: ").Append(DoubleHeaderTeamPairKey).Append("\n");
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