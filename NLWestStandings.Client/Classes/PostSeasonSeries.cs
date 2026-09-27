namespace NLWestStandings.Client.Classes.PostSeasonSeries
{
    /// <summary>
    /// Minimal model for https://statsapi.mlb.com/api/v1/schedule/postseason/series
    /// This is the same feed MLB.com uses to drive its live postseason bracket graphic.
    /// </summary>
    public class SeriesResponse
    {
        public SeriesEntry[] series { get; set; } = [];
    }

    public class SeriesEntry
    {
        public SeriesInfo series { get; set; } = new();
        public SeriesGame[] games { get; set; } = [];
    }

    public class SeriesInfo
    {
        public string id { get; set; } = string.Empty;
        public int sortNumber { get; set; }
        public string gameType { get; set; } = string.Empty;
    }

    public class SeriesGame
    {
        public int gamePk { get; set; }
        public int seriesGameNumber { get; set; }
        public SeriesTeams teams { get; set; } = new();
        public SeriesStatus? seriesStatus { get; set; }
    }

    public class SeriesTeams
    {
        public SeriesTeamSide away { get; set; } = new();
        public SeriesTeamSide home { get; set; } = new();
    }

    public class SeriesTeamSide
    {
        public SeriesTeam team { get; set; } = new();
        public bool isWinner { get; set; }
    }

    public class SeriesTeam
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public string abbreviation { get; set; } = string.Empty;
        public SeriesLeague? league { get; set; }
    }

    public class SeriesLeague
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
    }

    public class SeriesStatus
    {
        public bool isTied { get; set; }
        public bool isOver { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public SeriesTeam? winningTeam { get; set; }
        public SeriesTeam? losingTeam { get; set; }
        public string? shortName { get; set; }
        public string? result { get; set; }
    }
}
