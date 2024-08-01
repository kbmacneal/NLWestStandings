namespace NLWestStandings.Client.Classes
{

    public class Logos
    {
        public Sport[] sports { get; set; }
    }

    public class Sport
    {
        public string id { get; set; }
        public string uid { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public League[] leagues { get; set; }
    }

    public class League
    {
        public string id { get; set; }
        public string uid { get; set; }
        public string name { get; set; }
        public string abbreviation { get; set; }
        public string shortName { get; set; }
        public string slug { get; set; }
        public Team[] teams { get; set; }
        public int year { get; set; }
        public Season season { get; set; }
    }

    public class Season
    {
        public int year { get; set; }
        public string displayName { get; set; }
    }

    public class Team
    {
        public Team1 team { get; set; }
    }

    public class Team1
    {
        public string id { get; set; }
        public string uid { get; set; }
        public string slug { get; set; }
        public string abbreviation { get; set; }
        public string displayName { get; set; }
        public string shortDisplayName { get; set; }
        public string name { get; set; }
        public string nickname { get; set; }
        public string location { get; set; }
        public string color { get; set; }
        public string alternateColor { get; set; }
        public bool isActive { get; set; }
        public bool isAllStar { get; set; }
        public Logo[] logos { get; set; }
        public Link[] links { get; set; }
    }

    public class Logo
    {
        public string href { get; set; }
        public string alt { get; set; }
        public string[] rel { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Link
    {
        public string language { get; set; }
        public string[] rel { get; set; }
        public string href { get; set; }
        public string text { get; set; }
        public string shortText { get; set; }
        public bool isExternal { get; set; }
        public bool isPremium { get; set; }
        public bool isHidden { get; set; }
    }

}
