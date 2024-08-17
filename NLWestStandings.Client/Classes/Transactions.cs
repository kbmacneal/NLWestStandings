namespace NLWestStandings.Client.Classes.Transactions
{

    public class Transactions
    {
        public string copyright { get; set; }
        public Transaction[] transactions { get; set; }
    }

    public class Transaction
    {
        public int id { get; set; }
        public Person person { get; set; }
        public Toteam toTeam { get; set; }
        public string date { get; set; }
        public string effectiveDate { get; set; }
        public string resolutionDate { get; set; }
        public string typeCode { get; set; }
        public string typeDesc { get; set; }
        public string description { get; set; }
        public Fromteam fromTeam { get; set; }
    }

    public class Person
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Toteam
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Fromteam
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

}
