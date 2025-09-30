namespace NLWestStandings.Client.Classes.Calendar
{

    public class TeamCalendar
    {
        public string copyright { get; set; }
        public int totalItems { get; set; }
        public int totalEvents { get; set; }
        public int totalGames { get; set; }
        public int totalGamesInProgress { get; set; }
        public Date[] dates { get; set; }
    }

    public class Date
    {
        public string date { get; set; }
        public int totalItems { get; set; }
        public int totalEvents { get; set; }
        public int totalGames { get; set; }
        public int totalGamesInProgress { get; set; }
        public Game[] games { get; set; }
        public object[] events { get; set; }
    }

    public class Game
    {
        public int gamePk { get; set; }
        public string gameGuid { get; set; }
        public string link { get; set; }
        public string gameType { get; set; }
        public string season { get; set; }
        public DateTime gameDate { get; set; }
        public string officialDate { get; set; }
        public Status status { get; set; }
        public Teams teams { get; set; }
        public Venue2 venue { get; set; }
        public Broadcast[] broadcasts { get; set; }
        public Content content { get; set; }
        public bool isTie { get; set; }
        public Gameinfo gameInfo { get; set; }
        public int gameNumber { get; set; }
        public bool publicFacing { get; set; }
        public string doubleHeader { get; set; }
        public string gamedayType { get; set; }
        public string tiebreaker { get; set; }
        public string calendarEventID { get; set; }
        public string seasonDisplay { get; set; }
        public string dayNight { get; set; }
        public int scheduledInnings { get; set; }
        public bool reverseHomeAwayStatus { get; set; }
        public int inningBreakLength { get; set; }
        public int gamesInSeries { get; set; }
        public int seriesGameNumber { get; set; }
        public string seriesDescription { get; set; }
        public Flags flags { get; set; }
        public string recordSource { get; set; }
        public string ifNecessary { get; set; }
        public string ifNecessaryDescription { get; set; }
        public string description { get; set; }
        public DateTime rescheduleDate { get; set; }
        public string rescheduleGameDate { get; set; }
        public DateTime rescheduledFrom { get; set; }
        public string rescheduledFromDate { get; set; }
        public DateTime resumeDate { get; set; }
        public string resumeGameDate { get; set; }
        public DateTime resumedFrom { get; set; }
        public string resumedFromDate { get; set; }
    }

    public class Status
    {
        public string abstractGameState { get; set; }
        public string codedGameState { get; set; }
        public string detailedState { get; set; }
        public string statusCode { get; set; }
        public bool startTimeTBD { get; set; }
        public string abstractGameCode { get; set; }
        public string reason { get; set; }
    }

    public class Teams
    {
        public Away away { get; set; }
        public Home home { get; set; }
    }

    public class Away
    {
        public Leaguerecord leagueRecord { get; set; }
        public int score { get; set; }
        public Team team { get; set; }
        public bool isWinner { get; set; }
        public bool splitSquad { get; set; }
        public int seriesNumber { get; set; }
        public Springleague1 springLeague { get; set; }
    }

    public class Leaguerecord
    {
        public int wins { get; set; }
        public int losses { get; set; }
        public string pct { get; set; }
    }

    public class Team
    {
        public Springleague springLeague { get; set; }
        public string allStarStatus { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public int season { get; set; }
        public Venue venue { get; set; }
        public Springvenue springVenue { get; set; }
        public string teamCode { get; set; }
        public string fileCode { get; set; }
        public string abbreviation { get; set; }
        public string teamName { get; set; }
        public string locationName { get; set; }
        public string firstYearOfPlay { get; set; }
        public League league { get; set; }
        public Division division { get; set; }
        public Sport sport { get; set; }
        public string shortName { get; set; }
        public string franchiseName { get; set; }
        public string clubName { get; set; }
        public bool active { get; set; }
        public string parentOrgName { get; set; }
        public int parentOrgId { get; set; }
        public bool placeholder { get; set; }
    }

    public class Springleague
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string abbreviation { get; set; }
    }

    public class Venue
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Springvenue
    {
        public int id { get; set; }
        public string link { get; set; }
    }

    public class League
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Division
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Sport
    {
        public int id { get; set; }
        public string link { get; set; }
        public string name { get; set; }
    }

    public class Springleague1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string abbreviation { get; set; }
    }

    public class Home
    {
        public Leaguerecord1 leagueRecord { get; set; }
        public int score { get; set; }
        public Team1 team { get; set; }
        public bool isWinner { get; set; }
        public bool splitSquad { get; set; }
        public int seriesNumber { get; set; }
        public Springleague3 springLeague { get; set; }
    }

    public class Leaguerecord1
    {
        public int wins { get; set; }
        public int losses { get; set; }
        public string pct { get; set; }
    }

    public class Team1
    {
        public Springleague2 springLeague { get; set; }
        public string allStarStatus { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public int season { get; set; }
        public Venue1 venue { get; set; }
        public Springvenue1 springVenue { get; set; }
        public string teamCode { get; set; }
        public string fileCode { get; set; }
        public string abbreviation { get; set; }
        public string teamName { get; set; }
        public string locationName { get; set; }
        public string firstYearOfPlay { get; set; }
        public League1 league { get; set; }
        public Division1 division { get; set; }
        public Sport1 sport { get; set; }
        public string shortName { get; set; }
        public string franchiseName { get; set; }
        public string clubName { get; set; }
        public bool active { get; set; }
        public string parentOrgName { get; set; }
        public int parentOrgId { get; set; }
        public bool placeholder { get; set; }
    }

    public class Springleague2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string abbreviation { get; set; }
    }

    public class Venue1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Springvenue1
    {
        public int id { get; set; }
        public string link { get; set; }
    }

    public class League1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Division1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Sport1
    {
        public int id { get; set; }
        public string link { get; set; }
        public string name { get; set; }
    }

    public class Springleague3
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string abbreviation { get; set; }
    }

    public class Venue2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Content
    {
        public string link { get; set; }
    }

    public class Gameinfo
    {
        public int attendance { get; set; }
        public DateTime firstPitch { get; set; }
        public int gameDurationMinutes { get; set; }
        public int delayDurationMinutes { get; set; }
    }

    public class Flags
    {
        public bool noHitter { get; set; }
        public bool perfectGame { get; set; }
        public bool awayTeamNoHitter { get; set; }
        public bool awayTeamPerfectGame { get; set; }
        public bool homeTeamNoHitter { get; set; }
        public bool homeTeamPerfectGame { get; set; }
    }

    public class Broadcast
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string language { get; set; }
        public bool isNational { get; set; }
        public string callSign { get; set; }
        public Availability availability { get; set; }
        public Mediastate mediaState { get; set; }
        public string broadcastDate { get; set; }
        public string mediaId { get; set; }
        public string gameDateBroadcastGuid { get; set; }
        public string homeAway { get; set; }
        public bool freeGame { get; set; }
        public bool availableForStreaming { get; set; }
        public bool postGameShow { get; set; }
        public bool mvpdAuthRequired { get; set; }
        public bool freeGameStatus { get; set; }
        public Freegametype[] freeGameTypes { get; set; }
        public DateTime preGameShow { get; set; }
        public string sourceUrl { get; set; }
        public Videoresolution videoResolution { get; set; }
        public string sourceComment { get; set; }
        public Colorspace colorSpace { get; set; }
    }

    public class Availability
    {
        public int availabilityId { get; set; }
        public string availabilityCode { get; set; }
        public string availabilityText { get; set; }
    }

    public class Mediastate
    {
        public int mediaStateId { get; set; }
        public string mediaStateCode { get; set; }
        public string mediaStateText { get; set; }
    }

    public class Videoresolution
    {
        public string code { get; set; }
        public string resolutionShort { get; set; }
        public string resolutionFull { get; set; }
    }

    public class Colorspace
    {
        public string code { get; set; }
        public string colorSpaceFull { get; set; }
    }

    public class Freegametype
    {
        public Freegametype1 freeGameType { get; set; }
        public bool status { get; set; }
    }

    public class Freegametype1
    {
        public string freeGameTypeCode { get; set; }
        public string freeGameTypeText { get; set; }
        public string freeGameTypeDesc { get; set; }
        public int freeGameTypeId { get; set; }
    }

}