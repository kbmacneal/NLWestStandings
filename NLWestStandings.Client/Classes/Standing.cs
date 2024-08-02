using Flurl;
using Flurl.Http;
using NLWestStandings.Client.Classes;
using System.Text.Json.Serialization;
using static MudBlazor.Colors;

namespace NLWestStandings.MLB
{
    public class Standing
    {
        public string copyright { get; set; }
        public Record[] records { get; set; }
    }

    public class Record
    {
        public string standingsType { get; set; }
        public League league { get; set; }
        public Division division { get; set; }
        public Sport sport { get; set; }
        public DateTime lastUpdated { get; set; }
        public Teamrecord[] teamRecords { get; set; }
    }

    public class League
    {
        public int id { get; set; }
        public string link { get; set; }
    }

    public class Division
    {
        public int id { get; set; }
        public string link { get; set; }
    }

    public class Sport
    {
        public int id { get; set; }
        public string link { get; set; }
    }

    public class Teamrecord
    {
        public string division_name { get; set; }
        public Team team { get; set; }
        public string season { get; set; }
        public Streak streak { get; set; }
        public string divisionRank { get; set; }
        public string leagueRank { get; set; }
        public string sportRank { get; set; }
        public int gamesPlayed { get; set; }
        public string gamesBack { get; set; }
        public string wildCardGamesBack { get; set; }
        public string leagueGamesBack { get; set; }
        public string springLeagueGamesBack { get; set; }
        public string sportGamesBack { get; set; }
        public string divisionGamesBack { get; set; }
        public string conferenceGamesBack { get; set; }
        public Leaguerecord leagueRecord { get; set; }
        public DateTime lastUpdated { get; set; }
        public Records records { get; set; }
        public int runsAllowed { get; set; }
        public int runsScored { get; set; }
        public bool divisionChamp { get; set; }
        public bool divisionLeader { get; set; }
        public bool hasWildcard { get; set; }
        public bool clinched { get; set; }
        public string eliminationNumber { get; set; }
        public string eliminationNumberSport { get; set; }
        public string eliminationNumberLeague { get; set; }
        public string eliminationNumberDivision { get; set; }
        public string eliminationNumberConference { get; set; }
        public string wildCardEliminationNumber { get; set; }
        public string magicNumber { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int runDifferential { get; set; }
        public string winningPercentage { get; set; }
        public string wildCardRank { get; set; }
        public bool wildCardLeader { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }

        [JsonIgnore]
        public string logo_href { get; set; }
    }

    public class Streak
    {
        public string streakType { get; set; }
        public int streakNumber { get; set; }
        public string streakCode { get; set; }
    }

    public class Leaguerecord
    {
        public int wins { get; set; }
        public int losses { get; set; }
        public int ties { get; set; }
        public string pct { get; set; }
    }

    public class Records
    {
        public Splitrecord[] splitRecords { get; set; }
        public Divisionrecord[] divisionRecords { get; set; }
        public Overallrecord[] overallRecords { get; set; }
        public Leaguerecord1[] leagueRecords { get; set; }
        public Expectedrecord[] expectedRecords { get; set; }
    }

    public class Splitrecord
    {
        public int wins { get; set; }
        public int losses { get; set; }
        public string type { get; set; }
        public string pct { get; set; }
    }

    public class Divisionrecord
    {
        public int wins { get; set; }
        public int losses { get; set; }
        public string pct { get; set; }
        public Division1 division { get; set; }
    }

    public class Division1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Overallrecord
    {
        public int wins { get; set; }
        public int losses { get; set; }
        public string type { get; set; }
        public string pct { get; set; }
    }

    public class Leaguerecord1
    {
        public int wins { get; set; }
        public int losses { get; set; }
        public string pct { get; set; }
        public League1 league { get; set; }
    }

    public class League1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Expectedrecord
    {
        public int wins { get; set; }
        public int losses { get; set; }
        public string type { get; set; }
        public string pct { get; set; }
    }
}