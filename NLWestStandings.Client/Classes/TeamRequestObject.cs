namespace NLWestStandings.Client.Classes
{

    public class TeamRequestObject
    {
        public string copyright { get; set; }
        public Team2[] teams { get; set; }
    }

    public class Team2
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
        public League2 league { get; set; }
        public Division division { get; set; }
        public Sport2 sport { get; set; }
        public string shortName { get; set; }
        public string franchiseName { get; set; }
        public string clubName { get; set; }
        public bool active { get; set; }
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

    public class League2
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

    public class Sport2
    {
        public int id { get; set; }
        public string link { get; set; }
        public string name { get; set; }
    }

}
