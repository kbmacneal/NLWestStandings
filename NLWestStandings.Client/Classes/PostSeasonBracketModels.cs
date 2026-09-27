namespace NLWestStandings.Client.Classes.PostSeasonSeries
{
    /// <summary>
    /// View models consumed by <c>PostSeasonBracket.razor</c>. These are derived from the raw
    /// <see cref="SeriesResponse"/> payload so the bracket UI doesn't need to know about the API's
    /// away/home/winningTeam/losingTeam shape.
    /// </summary>
    public class BracketMatchup
    {
        public string TeamAName { get; set; } = string.Empty;
        public int TeamAId { get; set; }
        public int TeamAWins { get; set; }
        public bool TeamAIsSeriesWinner { get; set; }

        public string TeamBName { get; set; } = string.Empty;
        public int TeamBId { get; set; }
        public int TeamBWins { get; set; }
        public bool TeamBIsSeriesWinner { get; set; }

        public string StatusText { get; set; } = string.Empty;
        public int SortNumber { get; set; }
    }

    public class BracketRound
    {
        public string Title { get; set; } = string.Empty;
        public int Order { get; set; }
        public bool IsWorldSeries { get; set; }
        public List<BracketMatchup> AlMatchups { get; set; } = [];
        public List<BracketMatchup> NlMatchups { get; set; } = [];
        public List<BracketMatchup> AllMatchups { get; set; } = [];
    }
}
