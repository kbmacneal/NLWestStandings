﻿namespace NLWestStandings.Client.Classes.Last10GamesHitting
{
    public class Last10GamesHitting
    {
        public string copyright { get; set; }
        public Stat[] stats { get; set; }
    }

    public class Stat
    {
        public Type type { get; set; }
        public Group group { get; set; }
        public int totalSplits { get; set; }
        public object[] exemptions { get; set; }
        public Split[] splits { get; set; }
        public object[] splitsTiedWithOffset { get; set; }
        public object[] splitsTiedWithLimit { get; set; }
        public string playerPool { get; set; }
    }

    public class Type
    {
        public string displayName { get; set; }
    }

    public class Group
    {
        public string displayName { get; set; }
    }

    public class Split
    {
        public string season { get; set; }
        public Stat1 stat { get; set; }
        public Team team { get; set; }
        public Player player { get; set; }
        public League league { get; set; }
        public Sport sport { get; set; }
        public int rank { get; set; }
        public Position position { get; set; }
    }

    public class Stat1
    {
        public int gamesPlayed { get; set; }
        public int flyOuts { get; set; }
        public int groundOuts { get; set; }
        public int airOuts { get; set; }
        public int runs { get; set; }
        public int doubles { get; set; }
        public int triples { get; set; }
        public int homeRuns { get; set; }
        public int strikeOuts { get; set; }
        public int baseOnBalls { get; set; }
        public int intentionalWalks { get; set; }
        public int hits { get; set; }
        public int hitByPitch { get; set; }
        public string avg { get; set; }
        public int atBats { get; set; }
        public string obp { get; set; }
        public string slg { get; set; }
        public string ops { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int numberOfPitches { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public string atBatsPerHomeRun { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Player
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class League
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Sport
    {
        public int id { get; set; }
        public string link { get; set; }
        public string abbreviation { get; set; }
    }

    public class Position
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }
}