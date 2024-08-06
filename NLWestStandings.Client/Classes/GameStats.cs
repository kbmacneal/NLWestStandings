namespace NLWestStandings.Client.Classes.GameStats
{

    public class GameStats
    {
        public string copyright { get; set; }
        public Stat[] stats { get; set; }
    }

    public class Stat
    {
        public object[] exemptions { get; set; }
        public Split[] splits { get; set; }
        public Type type { get; set; }
        public Group group { get; set; }
        public int totalSplits { get; set; }
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
        public Stat1 stat { get; set; }
        public string type { get; set; }
        public string group { get; set; }
    }

    public class Stat1
    {
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int assists { get; set; }
        public int putOuts { get; set; }
        public int errors { get; set; }
        public int chances { get; set; }
        public string fielding { get; set; }
        public int passedBall { get; set; }
        public int pickoffs { get; set; }
        public string summary { get; set; }
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
        public int atBats { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public Play play { get; set; }
    }

    public class Play
    {
        public Details details { get; set; }
        public Count count { get; set; }
        public Pitchdata pitchData { get; set; }
        public Hitdata hitData { get; set; }
        public int index { get; set; }
        public string playId { get; set; }
        public int pitchNumber { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public bool isPitch { get; set; }
        public string type { get; set; }
    }

    public class Details
    {
        public Call call { get; set; }
        public string description { get; set; }
        public string code { get; set; }
        public string ballColor { get; set; }
        public string trailColor { get; set; }
        public bool isInPlay { get; set; }
        public bool isStrike { get; set; }
        public bool isBall { get; set; }
        public Type1 type { get; set; }
        public int awayScore { get; set; }
        public int homeScore { get; set; }
        public bool isOut { get; set; }
        public bool hasReview { get; set; }
    }

    public class Call
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Type1
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Count
    {
        public int balls { get; set; }
        public int strikes { get; set; }
        public int outs { get; set; }
        public int inning { get; set; }
    }

    public class Pitchdata
    {
        public float startSpeed { get; set; }
        public float endSpeed { get; set; }
        public float strikeZoneTop { get; set; }
        public float strikeZoneBottom { get; set; }
        public Coordinates coordinates { get; set; }
        public Breaks breaks { get; set; }
        public int zone { get; set; }
        public float typeConfidence { get; set; }
        public float plateTime { get; set; }
        public float extension { get; set; }
    }

    public class Coordinates
    {
        public float aY { get; set; }
        public float aZ { get; set; }
        public float pfxX { get; set; }
        public float pfxZ { get; set; }
        public float pX { get; set; }
        public float pZ { get; set; }
        public float vX0 { get; set; }
        public float vY0 { get; set; }
        public float vZ0 { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public float x0 { get; set; }
        public float y0 { get; set; }
        public float z0 { get; set; }
        public float aX { get; set; }
    }

    public class Breaks
    {
        public float breakAngle { get; set; }
        public float breakLength { get; set; }
        public float breakY { get; set; }
        public float breakVertical { get; set; }
        public float breakVerticalInduced { get; set; }
        public float breakHorizontal { get; set; }
        public int spinRate { get; set; }
        public int spinDirection { get; set; }
    }

    public class Hitdata
    {
        public float launchSpeed { get; set; }
        public float launchAngle { get; set; }
        public float totalDistance { get; set; }
        public string trajectory { get; set; }
        public string hardness { get; set; }
        public string location { get; set; }
        public Coordinates1 coordinates { get; set; }
    }

    public class Coordinates1
    {
        public float coordX { get; set; }
        public float coordY { get; set; }
    }

}
