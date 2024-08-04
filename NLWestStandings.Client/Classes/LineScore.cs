namespace NLWestStandings.Client.Classes.LineScore
{

    public class LineScoreData
    {
        public string copyright { get; set; }
        public int currentInning { get; set; }
        public string currentInningOrdinal { get; set; }
        public string inningState { get; set; }
        public string inningHalf { get; set; }
        public bool isTopInning { get; set; }
        public int scheduledInnings { get; set; }
        public Innings[] innings { get; set; }
        public Teams teams { get; set; }
        public Defense defense { get; set; }
        public Offense offense { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public int outs { get; set; }
    }

    public class Teams
    {
        public Home home { get; set; }
        public Away away { get; set; }
    }

    public class Home
    {
        public int runs { get; set; }
        public int hits { get; set; }
        public int errors { get; set; }
        public int leftOnBase { get; set; }
    }

    public class Away
    {
        public int runs { get; set; }
        public int hits { get; set; }
        public int errors { get; set; }
        public int leftOnBase { get; set; }
    }

    public class Defense
    {
        public Pitcher pitcher { get; set; }
        public Catcher catcher { get; set; }
        public First first { get; set; }
        public Second second { get; set; }
        public Third third { get; set; }
        public Shortstop shortstop { get; set; }
        public Left left { get; set; }
        public Center center { get; set; }
        public Right right { get; set; }
        public Batter batter { get; set; }
        public Ondeck onDeck { get; set; }
        public Inhole inHole { get; set; }
        public int battingOrder { get; set; }
        public Team team { get; set; }
    }

    public class Pitcher
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Catcher
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class First
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Second
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Third
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Shortstop
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Left
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Center
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Right
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Batter
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Ondeck
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Inhole
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Offense
    {
        public Batter1 batter { get; set; }
        public Ondeck1 onDeck { get; set; }
        public Inhole1 inHole { get; set; }
        public Pitcher1 pitcher { get; set; }
        public int battingOrder { get; set; }
        public Team1 team { get; set; }
    }

    public class Batter1
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Ondeck1
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Inhole1
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Pitcher1
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Team1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Innings
    {
        public int num { get; set; }
        public string ordinalNum { get; set; }
        public Home1 home { get; set; }
        public Away1 away { get; set; }
    }

    public class Home1
    {
        public int runs { get; set; }
        public int hits { get; set; }
        public int errors { get; set; }
        public int leftOnBase { get; set; }
    }

    public class Away1
    {
        public int runs { get; set; }
        public int hits { get; set; }
        public int errors { get; set; }
        public int leftOnBase { get; set; }
    }


}
