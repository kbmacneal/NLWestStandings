namespace NLWestStandings.Client.Classes.Person
{
    public class PersonRecord
    {
        public string copyright { get; set; }
        public Person[] people { get; set; }
    }

    public class Person
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string primaryNumber { get; set; }
        public string birthDate { get; set; }
        public int currentAge { get; set; }
        public string birthCity { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside batSide { get; set; }
        public Pitchhand pitchHand { get; set; }
        public string nameFirstLast { get; set; }
        public string nameSlug { get; set; }
        public string firstLastName { get; set; }
        public string lastFirstName { get; set; }
        public string lastInitName { get; set; }
        public string initLastName { get; set; }
        public string fullFMLName { get; set; }
        public string fullLFMName { get; set; }
        public float strikeZoneTop { get; set; }
        public float strikeZoneBottom { get; set; }
    }

    public class Primaryposition
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand
    {
        public string code { get; set; }
        public string description { get; set; }
    }
}