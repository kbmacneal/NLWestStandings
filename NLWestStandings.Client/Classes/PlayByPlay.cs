namespace NLWestStandings.Client.Classes.PlayByPlay
{

    public class PlayByPlay
    {
        public string copyright { get; set; }
        public int gamePk { get; set; }
        public string link { get; set; }
        public Metadata metaData { get; set; }
        public Gamedata gameData { get; set; }
        public Livedata liveData { get; set; }
    }

    public class Metadata
    {
        public int wait { get; set; }
        public string timeStamp { get; set; }
        public string[] gameEvents { get; set; }
        public string[] logicalEvents { get; set; }
    }

    public class Gamedata
    {
        public Game game { get; set; }
        public Datetime datetime { get; set; }
        public Status status { get; set; }
        public Teams teams { get; set; }
        public Players players { get; set; }
        public Venue2 venue { get; set; }
        public Officialvenue officialVenue { get; set; }
        public Weather weather { get; set; }
        public Gameinfo gameInfo { get; set; }
        public Review review { get; set; }
        public Flags flags { get; set; }
        public object[] alerts { get; set; }
        public Probablepitchers probablePitchers { get; set; }
        public Officialscorer officialScorer { get; set; }
        public Primarydatacaster primaryDatacaster { get; set; }
        public Moundvisits moundVisits { get; set; }
    }

    public class Game
    {
        public int pk { get; set; }
        public string type { get; set; }
        public string doubleHeader { get; set; }
        public string id { get; set; }
        public string gamedayType { get; set; }
        public string tiebreaker { get; set; }
        public int gameNumber { get; set; }
        public string calendarEventID { get; set; }
        public string season { get; set; }
        public string seasonDisplay { get; set; }
    }

    public class Datetime
    {
        public DateTime dateTime { get; set; }
        public string originalDate { get; set; }
        public string officialDate { get; set; }
        public string dayNight { get; set; }
        public string time { get; set; }
        public string ampm { get; set; }
    }

    public class Status
    {
        public string abstractGameState { get; set; }
        public string codedGameState { get; set; }
        public string detailedState { get; set; }
        public string statusCode { get; set; }
        public bool startTimeTBD { get; set; }
        public string abstractGameCode { get; set; }
    }

    public class Teams
    {
        public Away away { get; set; }
        public Home home { get; set; }
    }

    public class Away
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
        public League league { get; set; }
        public Division division { get; set; }
        public Sport sport { get; set; }
        public string shortName { get; set; }
        public Record record { get; set; }
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

    public class League
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

    public class Sport
    {
        public int id { get; set; }
        public string link { get; set; }
        public string name { get; set; }
    }

    public class Record
    {
        public int gamesPlayed { get; set; }
        public string wildCardGamesBack { get; set; }
        public string leagueGamesBack { get; set; }
        public string springLeagueGamesBack { get; set; }
        public string sportGamesBack { get; set; }
        public string divisionGamesBack { get; set; }
        public string conferenceGamesBack { get; set; }
        public Leaguerecord leagueRecord { get; set; }
        public Records records { get; set; }
        public bool divisionLeader { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public string winningPercentage { get; set; }
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
    }

    public class Home
    {
        public Springleague1 springLeague { get; set; }
        public string allStarStatus { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public int season { get; set; }
        public Venue1 venue { get; set; }
        public Springvenue1 springVenue { get; set; }
        public string teamCode { get; set; }
        public string fileCode { get; set; }
        public string abbreviation { get; set; }
        public string teamName { get; set; }
        public string locationName { get; set; }
        public string firstYearOfPlay { get; set; }
        public League1 league { get; set; }
        public Division1 division { get; set; }
        public Sport1 sport { get; set; }
        public string shortName { get; set; }
        public Record1 record { get; set; }
        public string franchiseName { get; set; }
        public string clubName { get; set; }
        public bool active { get; set; }
    }

    public class Springleague1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string abbreviation { get; set; }
    }

    public class Venue1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Springvenue1
    {
        public int id { get; set; }
        public string link { get; set; }
    }

    public class League1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Division1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Sport1
    {
        public int id { get; set; }
        public string link { get; set; }
        public string name { get; set; }
    }

    public class Record1
    {
        public int gamesPlayed { get; set; }
        public string wildCardGamesBack { get; set; }
        public string leagueGamesBack { get; set; }
        public string springLeagueGamesBack { get; set; }
        public string sportGamesBack { get; set; }
        public string divisionGamesBack { get; set; }
        public string conferenceGamesBack { get; set; }
        public Leaguerecord1 leagueRecord { get; set; }
        public Records1 records { get; set; }
        public bool divisionLeader { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public string winningPercentage { get; set; }
    }

    public class Leaguerecord1
    {
        public int wins { get; set; }
        public int losses { get; set; }
        public int ties { get; set; }
        public string pct { get; set; }
    }

    public class Records1
    {
    }

    public class Players
    {
        public ID669257 ID669257 { get; set; }
        public ID671732 ID671732 { get; set; }
        public ID543339 ID543339 { get; set; }
        public ID689981 ID689981 { get; set; }
        public ID667670 ID667670 { get; set; }
        public ID687765 ID687765 { get; set; }
        public ID571771 ID571771 { get; set; }
        public ID607455 ID607455 { get; set; }
        public ID605113 ID605113 { get; set; }
        public ID613534 ID613534 { get; set; }
        public ID674370 ID674370 { get; set; }
        public ID664913 ID664913 { get; set; }
        public ID656427 ID656427 { get; set; }
        public ID609280 ID609280 { get; set; }
        public ID687231 ID687231 { get; set; }
        public ID656629 ID656629 { get; set; }
        public ID694361 ID694361 { get; set; }
        public ID683155 ID683155 { get; set; }
        public ID623465 ID623465 { get; set; }
        public ID666158 ID666158 { get; set; }
        public ID477132 ID477132 { get; set; }
        public ID641703 ID641703 { get; set; }
        public ID676664 ID676664 { get; set; }
        public ID622103 ID622103 { get; set; }
        public ID680869 ID680869 { get; set; }
        public ID607192 ID607192 { get; set; }
        public ID666205 ID666205 { get; set; }
        public ID681911 ID681911 { get; set; }
        public ID518397 ID518397 { get; set; }
        public ID519008 ID519008 { get; set; }
        public ID621053 ID621053 { get; set; }
        public ID605131 ID605131 { get; set; }
        public ID680474 ID680474 { get; set; }
        public ID642708 ID642708 { get; set; }
        public ID518792 ID518792 { get; set; }
        public ID663527 ID663527 { get; set; }
        public ID595281 ID595281 { get; set; }
        public ID671305 ID671305 { get; set; }
        public ID660271 ID660271 { get; set; }
        public ID624415 ID624415 { get; set; }
        public ID647351 ID647351 { get; set; }
        public ID606192 ID606192 { get; set; }
        public ID681624 ID681624 { get; set; }
        public ID681546 ID681546 { get; set; }
        public ID668832 ID668832 { get; set; }
        public ID669127 ID669127 { get; set; }
        public ID663662 ID663662 { get; set; }
        public ID548389 ID548389 { get; set; }
        public ID668709 ID668709 { get; set; }
        public ID595014 ID595014 { get; set; }
        public ID523260 ID523260 { get; set; }
        public ID694813 ID694813 { get; set; }
    }

    public class ID669257
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
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

    public class ID671732
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition1 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside1 batSide { get; set; }
        public Pitchhand1 pitchHand { get; set; }
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

    public class Primaryposition1
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside1
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand1
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID543339
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition2 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside2 batSide { get; set; }
        public Pitchhand2 pitchHand { get; set; }
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

    public class Primaryposition2
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside2
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand2
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID689981
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition3 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside3 batSide { get; set; }
        public Pitchhand3 pitchHand { get; set; }
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

    public class Primaryposition3
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside3
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand3
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID667670
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition4 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside4 batSide { get; set; }
        public Pitchhand4 pitchHand { get; set; }
        public string nameFirstLast { get; set; }
        public string nameTitle { get; set; }
        public string nameSuffix { get; set; }
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

    public class Primaryposition4
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside4
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand4
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID687765
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition5 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside5 batSide { get; set; }
        public Pitchhand5 pitchHand { get; set; }
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

    public class Primaryposition5
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside5
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand5
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID571771
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
        public Primaryposition6 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside6 batSide { get; set; }
        public Pitchhand6 pitchHand { get; set; }
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

    public class Primaryposition6
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside6
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand6
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID607455
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition7 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside7 batSide { get; set; }
        public Pitchhand7 pitchHand { get; set; }
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

    public class Primaryposition7
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside7
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand7
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID605113
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition8 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside8 batSide { get; set; }
        public Pitchhand8 pitchHand { get; set; }
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

    public class Primaryposition8
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside8
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand8
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID613534
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition9 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside9 batSide { get; set; }
        public Pitchhand9 pitchHand { get; set; }
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

    public class Primaryposition9
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside9
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand9
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID674370
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
        public Primaryposition10 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public string nameMatrilineal { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside10 batSide { get; set; }
        public Pitchhand10 pitchHand { get; set; }
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

    public class Primaryposition10
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside10
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand10
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID664913
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition11 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside11 batSide { get; set; }
        public Pitchhand11 pitchHand { get; set; }
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

    public class Primaryposition11
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside11
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand11
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID656427
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition12 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside12 batSide { get; set; }
        public Pitchhand12 pitchHand { get; set; }
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

    public class Primaryposition12
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside12
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand12
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID609280
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
        public Primaryposition13 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside13 batSide { get; set; }
        public Pitchhand13 pitchHand { get; set; }
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

    public class Primaryposition13
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside13
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand13
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID687231
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
        public Primaryposition14 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public string nameMatrilineal { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside14 batSide { get; set; }
        public Pitchhand14 pitchHand { get; set; }
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

    public class Primaryposition14
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside14
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand14
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID656629
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition15 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside15 batSide { get; set; }
        public Pitchhand15 pitchHand { get; set; }
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

    public class Primaryposition15
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside15
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand15
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID694361
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition16 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside16 batSide { get; set; }
        public Pitchhand16 pitchHand { get; set; }
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

    public class Primaryposition16
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside16
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand16
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID683155
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition17 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside17 batSide { get; set; }
        public Pitchhand17 pitchHand { get; set; }
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

    public class Primaryposition17
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside17
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand17
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID623465
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition18 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside18 batSide { get; set; }
        public Pitchhand18 pitchHand { get; set; }
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

    public class Primaryposition18
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside18
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand18
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID666158
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition19 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside19 batSide { get; set; }
        public Pitchhand19 pitchHand { get; set; }
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

    public class Primaryposition19
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside19
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand19
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID477132
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition20 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside20 batSide { get; set; }
        public Pitchhand20 pitchHand { get; set; }
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

    public class Primaryposition20
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside20
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand20
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID641703
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition21 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside21 batSide { get; set; }
        public Pitchhand21 pitchHand { get; set; }
        public string nameFirstLast { get; set; }
        public string nameTitle { get; set; }
        public string nameSuffix { get; set; }
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

    public class Primaryposition21
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside21
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand21
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID676664
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition22 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside22 batSide { get; set; }
        public Pitchhand22 pitchHand { get; set; }
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

    public class Primaryposition22
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside22
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand22
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID622103
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition23 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public string nameMatrilineal { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside23 batSide { get; set; }
        public Pitchhand23 pitchHand { get; set; }
        public string nameFirstLast { get; set; }
        public string nameTitle { get; set; }
        public string nameSuffix { get; set; }
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

    public class Primaryposition23
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside23
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand23
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID680869
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition24 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside24 batSide { get; set; }
        public Pitchhand24 pitchHand { get; set; }
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

    public class Primaryposition24
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside24
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand24
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID607192
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition25 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside25 batSide { get; set; }
        public Pitchhand25 pitchHand { get; set; }
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

    public class Primaryposition25
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside25
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand25
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID666205
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition26 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside26 batSide { get; set; }
        public Pitchhand26 pitchHand { get; set; }
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

    public class Primaryposition26
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside26
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand26
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID681911
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition27 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside27 batSide { get; set; }
        public Pitchhand27 pitchHand { get; set; }
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

    public class Primaryposition27
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside27
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand27
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID518397
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition28 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside28 batSide { get; set; }
        public Pitchhand28 pitchHand { get; set; }
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

    public class Primaryposition28
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside28
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand28
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID519008
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition29 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside29 batSide { get; set; }
        public Pitchhand29 pitchHand { get; set; }
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

    public class Primaryposition29
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside29
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand29
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID621053
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition30 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside30 batSide { get; set; }
        public Pitchhand30 pitchHand { get; set; }
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

    public class Primaryposition30
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside30
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand30
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID605131
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition31 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside31 batSide { get; set; }
        public Pitchhand31 pitchHand { get; set; }
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

    public class Primaryposition31
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside31
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand31
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID680474
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition32 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside32 batSide { get; set; }
        public Pitchhand32 pitchHand { get; set; }
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

    public class Primaryposition32
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside32
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand32
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID642708
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
        public Primaryposition33 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public string nameMatrilineal { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside33 batSide { get; set; }
        public Pitchhand33 pitchHand { get; set; }
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

    public class Primaryposition33
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside33
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand33
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID518792
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition34 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside34 batSide { get; set; }
        public Pitchhand34 pitchHand { get; set; }
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

    public class Primaryposition34
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside34
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand34
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID663527
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition35 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside35 batSide { get; set; }
        public Pitchhand35 pitchHand { get; set; }
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

    public class Primaryposition35
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside35
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand35
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID595281
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition36 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside36 batSide { get; set; }
        public Pitchhand36 pitchHand { get; set; }
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

    public class Primaryposition36
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside36
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand36
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID671305
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
        public Primaryposition37 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public string nameMatrilineal { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside37 batSide { get; set; }
        public Pitchhand37 pitchHand { get; set; }
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

    public class Primaryposition37
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside37
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand37
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID660271
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
        public Primaryposition38 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside38 batSide { get; set; }
        public Pitchhand38 pitchHand { get; set; }
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

    public class Primaryposition38
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside38
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand38
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID624415
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition39 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside39 batSide { get; set; }
        public Pitchhand39 pitchHand { get; set; }
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

    public class Primaryposition39
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside39
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand39
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID647351
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition40 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public string nameMatrilineal { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside40 batSide { get; set; }
        public Pitchhand40 pitchHand { get; set; }
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

    public class Primaryposition40
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside40
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand40
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID606192
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
        public Primaryposition41 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside41 batSide { get; set; }
        public Pitchhand41 pitchHand { get; set; }
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

    public class Primaryposition41
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside41
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand41
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID681624
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
        public Primaryposition42 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public string nameMatrilineal { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside42 batSide { get; set; }
        public Pitchhand42 pitchHand { get; set; }
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

    public class Primaryposition42
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside42
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand42
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID681546
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition43 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside43 batSide { get; set; }
        public Pitchhand43 pitchHand { get; set; }
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

    public class Primaryposition43
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside43
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand43
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID668832
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition44 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside44 batSide { get; set; }
        public Pitchhand44 pitchHand { get; set; }
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

    public class Primaryposition44
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside44
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand44
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID669127
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition45 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside45 batSide { get; set; }
        public Pitchhand45 pitchHand { get; set; }
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

    public class Primaryposition45
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside45
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand45
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID663662
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition46 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside46 batSide { get; set; }
        public Pitchhand46 pitchHand { get; set; }
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

    public class Primaryposition46
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside46
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand46
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID548389
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition47 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside47 batSide { get; set; }
        public Pitchhand47 pitchHand { get; set; }
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

    public class Primaryposition47
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside47
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand47
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID668709
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition48 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside48 batSide { get; set; }
        public Pitchhand48 pitchHand { get; set; }
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

    public class Primaryposition48
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside48
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand48
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID595014
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition49 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string pronunciation { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside49 batSide { get; set; }
        public Pitchhand49 pitchHand { get; set; }
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

    public class Primaryposition49
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside49
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand49
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID523260
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition50 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string nickName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside50 batSide { get; set; }
        public Pitchhand50 pitchHand { get; set; }
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

    public class Primaryposition50
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside50
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand50
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class ID694813
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
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public int weight { get; set; }
        public bool active { get; set; }
        public Primaryposition51 primaryPosition { get; set; }
        public string useName { get; set; }
        public string useLastName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public string mlbDebutDate { get; set; }
        public Batside51 batSide { get; set; }
        public Pitchhand51 pitchHand { get; set; }
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

    public class Primaryposition51
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Batside51
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitchhand51
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Venue2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public Location location { get; set; }
        public Timezone timeZone { get; set; }
        public Fieldinfo fieldInfo { get; set; }
        public bool active { get; set; }
        public string season { get; set; }
    }

    public class Location
    {
        public string address1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string stateAbbrev { get; set; }
        public string postalCode { get; set; }
        public Defaultcoordinates defaultCoordinates { get; set; }
        public float azimuthAngle { get; set; }
        public int elevation { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
    }

    public class Defaultcoordinates
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
    }

    public class Timezone
    {
        public string id { get; set; }
        public int offset { get; set; }
        public int offsetAtGameTime { get; set; }
        public string tz { get; set; }
    }

    public class Fieldinfo
    {
        public int capacity { get; set; }
        public string turfType { get; set; }
        public string roofType { get; set; }
        public int leftLine { get; set; }
        public int left { get; set; }
        public int leftCenter { get; set; }
        public int center { get; set; }
        public int rightCenter { get; set; }
        public int right { get; set; }
        public int rightLine { get; set; }
    }

    public class Officialvenue
    {
        public int id { get; set; }
        public string link { get; set; }
    }

    public class Weather
    {
        public string condition { get; set; }
        public string temp { get; set; }
        public string wind { get; set; }
    }

    public class Gameinfo
    {
        public int attendance { get; set; }
        public DateTime firstPitch { get; set; }
        public int gameDurationMinutes { get; set; }
    }

    public class Review
    {
        public bool hasChallenges { get; set; }
        public Away1 away { get; set; }
        public Home1 home { get; set; }
    }

    public class Away1
    {
        public int used { get; set; }
        public int remaining { get; set; }
    }

    public class Home1
    {
        public int used { get; set; }
        public int remaining { get; set; }
    }

    public class Flags
    {
        public bool noHitter { get; set; }
        public bool perfectGame { get; set; }
        public bool awayTeamNoHitter { get; set; }
        public bool awayTeamPerfectGame { get; set; }
        public bool homeTeamNoHitter { get; set; }
        public bool homeTeamPerfectGame { get; set; }
    }

    public class Probablepitchers
    {
        public Away2 away { get; set; }
        public Home2 home { get; set; }
    }

    public class Away2
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Home2
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Officialscorer
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Primarydatacaster
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Moundvisits
    {
        public Away3 away { get; set; }
        public Home3 home { get; set; }
    }

    public class Away3
    {
        public int used { get; set; }
        public int remaining { get; set; }
    }

    public class Home3
    {
        public int used { get; set; }
        public int remaining { get; set; }
    }

    public class Livedata
    {
        public Plays plays { get; set; }
        public Linescore linescore { get; set; }
        public Boxscore boxscore { get; set; }
        public Decisions decisions { get; set; }
        public Leaders leaders { get; set; }
    }

    public class Plays
    {
        public Allplay[] allPlays { get; set; }
        public Currentplay currentPlay { get; set; }
        public int[] scoringPlays { get; set; }
        public Playsbyinning[] playsByInning { get; set; }
    }

    public class Currentplay
    {
        public Result result { get; set; }
        public About about { get; set; }
        public Count count { get; set; }
        public Matchup matchup { get; set; }
        public int[] pitchIndex { get; set; }
        public object[] actionIndex { get; set; }
        public int[] runnerIndex { get; set; }
        public Runner[] runners { get; set; }
        public Playevent[] playEvents { get; set; }
        public DateTime playEndTime { get; set; }
        public int atBatIndex { get; set; }
    }

    public class Result
    {
        public string type { get; set; }
        public string _event { get; set; }
        public string eventType { get; set; }
        public string description { get; set; }
        public int rbi { get; set; }
        public int awayScore { get; set; }
        public int homeScore { get; set; }
        public bool isOut { get; set; }
    }

    public class About
    {
        public int atBatIndex { get; set; }
        public string halfInning { get; set; }
        public bool isTopInning { get; set; }
        public int inning { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public bool isComplete { get; set; }
        public bool isScoringPlay { get; set; }
        public bool hasReview { get; set; }
        public bool hasOut { get; set; }
        public int captivatingIndex { get; set; }
    }

    public class Count
    {
        public int balls { get; set; }
        public int strikes { get; set; }
        public int outs { get; set; }
    }

    public class Matchup
    {
        public Batter batter { get; set; }
        public Batside52 batSide { get; set; }
        public Pitcher pitcher { get; set; }
        public Pitchhand52 pitchHand { get; set; }
        public Batterhotcoldzonestats batterHotColdZoneStats { get; set; }
        public Pitcherhotcoldzonestats pitcherHotColdZoneStats { get; set; }
        public Batterhotcoldzone[] batterHotColdZones { get; set; }
        public Pitcherhotcoldzone[] pitcherHotColdZones { get; set; }
        public Splits splits { get; set; }
    }

    public class Batter
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Batside52
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitcher
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Pitchhand52
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Batterhotcoldzonestats
    {
        public Stat[] stats { get; set; }
    }

    public class Stat
    {
        public Type type { get; set; }
        public Group group { get; set; }
        public object[] exemptions { get; set; }
        public Split[] splits { get; set; }
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
    }

    public class Stat1
    {
        public string name { get; set; }
        public Zone[] zones { get; set; }
    }

    public class Zone
    {
        public string zone { get; set; }
        public string color { get; set; }
        public string temp { get; set; }
        public string value { get; set; }
    }

    public class Pitcherhotcoldzonestats
    {
        public Stat2[] stats { get; set; }
    }

    public class Stat2
    {
        public Type1 type { get; set; }
        public Group1 group { get; set; }
        public object[] exemptions { get; set; }
        public Split1[] splits { get; set; }
    }

    public class Type1
    {
        public string displayName { get; set; }
    }

    public class Group1
    {
        public string displayName { get; set; }
    }

    public class Split1
    {
        public Stat3 stat { get; set; }
    }

    public class Stat3
    {
        public string name { get; set; }
        public Zone1[] zones { get; set; }
    }

    public class Zone1
    {
        public string zone { get; set; }
        public string color { get; set; }
        public string temp { get; set; }
        public string value { get; set; }
    }

    public class Splits
    {
        public string batter { get; set; }
        public string pitcher { get; set; }
        public string menOnBase { get; set; }
    }

    public class Batterhotcoldzone
    {
        public string zone { get; set; }
        public string color { get; set; }
        public string temp { get; set; }
        public string value { get; set; }
    }

    public class Pitcherhotcoldzone
    {
        public string zone { get; set; }
        public string color { get; set; }
        public string temp { get; set; }
        public string value { get; set; }
    }

    public class Runner
    {
        public Movement movement { get; set; }
        public Details details { get; set; }
        public Credit[] credits { get; set; }
    }

    public class Movement
    {
        public object originBase { get; set; }
        public object start { get; set; }
        public object end { get; set; }
        public string outBase { get; set; }
        public bool isOut { get; set; }
        public int outNumber { get; set; }
    }

    public class Details
    {
        public string _event { get; set; }
        public string eventType { get; set; }
        public object movementReason { get; set; }
        public Runner1 runner { get; set; }
        public object responsiblePitcher { get; set; }
        public bool isScoringEvent { get; set; }
        public bool rbi { get; set; }
        public bool earned { get; set; }
        public bool teamUnearned { get; set; }
        public int playIndex { get; set; }
    }

    public class Runner1
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Credit
    {
        public Player player { get; set; }
        public Position position { get; set; }
        public string credit { get; set; }
    }

    public class Player
    {
        public int id { get; set; }
        public string link { get; set; }
    }

    public class Position
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Playevent
    {
        public Details1 details { get; set; }
        public Count1 count { get; set; }
        public Pitchdata pitchData { get; set; }
        public int index { get; set; }
        public string playId { get; set; }
        public int pitchNumber { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public bool isPitch { get; set; }
        public string type { get; set; }
        public Hitdata hitData { get; set; }
    }

    public class Details1
    {
        public Call call { get; set; }
        public string description { get; set; }
        public string code { get; set; }
        public string ballColor { get; set; }
        public string trailColor { get; set; }
        public bool isInPlay { get; set; }
        public bool isStrike { get; set; }
        public bool isBall { get; set; }
        public Type2 type { get; set; }
        public bool isOut { get; set; }
        public bool hasReview { get; set; }
    }

    public class Call
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Type2
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Count1
    {
        public int balls { get; set; }
        public int strikes { get; set; }
        public int outs { get; set; }
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

    public class Allplay
    {
        public Result1 result { get; set; }
        public About1 about { get; set; }
        public Count2 count { get; set; }
        public Matchup1 matchup { get; set; }
        public int[] pitchIndex { get; set; }
        public int?[] actionIndex { get; set; }
        public int[] runnerIndex { get; set; }
        public Runner2[] runners { get; set; }
        public Playevent1[] playEvents { get; set; }
        public DateTime playEndTime { get; set; }
        public int atBatIndex { get; set; }
        public Reviewdetails reviewDetails { get; set; }
    }

    public class Result1
    {
        public string type { get; set; }
        public string _event { get; set; }
        public string eventType { get; set; }
        public string description { get; set; }
        public int rbi { get; set; }
        public int awayScore { get; set; }
        public int homeScore { get; set; }
        public bool isOut { get; set; }
    }

    public class About1
    {
        public int atBatIndex { get; set; }
        public string halfInning { get; set; }
        public bool isTopInning { get; set; }
        public int inning { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public bool isComplete { get; set; }
        public bool isScoringPlay { get; set; }
        public bool hasReview { get; set; }
        public bool hasOut { get; set; }
        public int captivatingIndex { get; set; }
    }

    public class Count2
    {
        public int balls { get; set; }
        public int strikes { get; set; }
        public int outs { get; set; }
    }

    public class Matchup1
    {
        public Batter1 batter { get; set; }
        public Batside53 batSide { get; set; }
        public Pitcher1 pitcher { get; set; }
        public Pitchhand53 pitchHand { get; set; }
        public Postonfirst postOnFirst { get; set; }
        public Batterhotcoldzone1[] batterHotColdZones { get; set; }
        public Pitcherhotcoldzone1[] pitcherHotColdZones { get; set; }
        public Splits1 splits { get; set; }
        public Postonthird postOnThird { get; set; }
        public Postonsecond postOnSecond { get; set; }
        public Batterhotcoldzonestats1 batterHotColdZoneStats { get; set; }
        public Pitcherhotcoldzonestats1 pitcherHotColdZoneStats { get; set; }
    }

    public class Batter1
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Batside53
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Pitcher1
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Pitchhand53
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Postonfirst
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Splits1
    {
        public string batter { get; set; }
        public string pitcher { get; set; }
        public string menOnBase { get; set; }
    }

    public class Postonthird
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Postonsecond
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Batterhotcoldzonestats1
    {
        public Stat4[] stats { get; set; }
    }

    public class Stat4
    {
        public Type3 type { get; set; }
        public Group2 group { get; set; }
        public object[] exemptions { get; set; }
        public Split2[] splits { get; set; }
    }

    public class Type3
    {
        public string displayName { get; set; }
    }

    public class Group2
    {
        public string displayName { get; set; }
    }

    public class Split2
    {
        public Stat5 stat { get; set; }
    }

    public class Stat5
    {
        public string name { get; set; }
        public Zone2[] zones { get; set; }
    }

    public class Zone2
    {
        public string zone { get; set; }
        public string color { get; set; }
        public string temp { get; set; }
        public string value { get; set; }
    }

    public class Pitcherhotcoldzonestats1
    {
        public Stat6[] stats { get; set; }
    }

    public class Stat6
    {
        public Type4 type { get; set; }
        public Group3 group { get; set; }
        public object[] exemptions { get; set; }
        public Split3[] splits { get; set; }
    }

    public class Type4
    {
        public string displayName { get; set; }
    }

    public class Group3
    {
        public string displayName { get; set; }
    }

    public class Split3
    {
        public Stat7 stat { get; set; }
    }

    public class Stat7
    {
        public string name { get; set; }
        public Zone3[] zones { get; set; }
    }

    public class Zone3
    {
        public string zone { get; set; }
        public string color { get; set; }
        public string temp { get; set; }
        public string value { get; set; }
    }

    public class Batterhotcoldzone1
    {
        public string zone { get; set; }
        public string color { get; set; }
        public string temp { get; set; }
        public string value { get; set; }
    }

    public class Pitcherhotcoldzone1
    {
        public string zone { get; set; }
        public string color { get; set; }
        public string temp { get; set; }
        public string value { get; set; }
    }

    public class Reviewdetails
    {
        public bool isOverturned { get; set; }
        public bool inProgress { get; set; }
        public string reviewType { get; set; }
        public int challengeTeamId { get; set; }
    }

    public class Runner2
    {
        public Movement1 movement { get; set; }
        public Details2 details { get; set; }
        public Credit1[] credits { get; set; }
    }

    public class Movement1
    {
        public string originBase { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string outBase { get; set; }
        public bool isOut { get; set; }
        public int? outNumber { get; set; }
    }

    public class Details2
    {
        public string _event { get; set; }
        public string eventType { get; set; }
        public string movementReason { get; set; }
        public Runner3 runner { get; set; }
        public Responsiblepitcher responsiblePitcher { get; set; }
        public bool isScoringEvent { get; set; }
        public bool rbi { get; set; }
        public bool earned { get; set; }
        public bool teamUnearned { get; set; }
        public int playIndex { get; set; }
    }

    public class Runner3
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Responsiblepitcher
    {
        public int id { get; set; }
        public string link { get; set; }
    }

    public class Credit1
    {
        public Player1 player { get; set; }
        public Position1 position { get; set; }
        public string credit { get; set; }
    }

    public class Player1
    {
        public int id { get; set; }
        public string link { get; set; }
    }

    public class Position1
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Playevent1
    {
        public Details3 details { get; set; }
        public Count3 count { get; set; }
        public int index { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public bool isPitch { get; set; }
        public string type { get; set; }
        public Player2 player { get; set; }
        public Pitchdata1 pitchData { get; set; }
        public string playId { get; set; }
        public int pitchNumber { get; set; }
        public string actionPlayId { get; set; }
        public bool isBaseRunningPlay { get; set; }
        public Hitdata1 hitData { get; set; }
        public bool isSubstitution { get; set; }
        public Position2 position { get; set; }
        public string battingOrder { get; set; }
        public Replacedplayer replacedPlayer { get; set; }
    }

    public class Details3
    {
        public string description { get; set; }
        public string _event { get; set; }
        public string eventType { get; set; }
        public int awayScore { get; set; }
        public int homeScore { get; set; }
        public bool isScoringPlay { get; set; }
        public bool isOut { get; set; }
        public bool hasReview { get; set; }
        public Call1 call { get; set; }
        public string code { get; set; }
        public string ballColor { get; set; }
        public string trailColor { get; set; }
        public bool isInPlay { get; set; }
        public bool isStrike { get; set; }
        public bool isBall { get; set; }
        public Type5 type { get; set; }
        public bool runnerGoing { get; set; }
        public bool fromCatcher { get; set; }
        public int disengagementNum { get; set; }
    }

    public class Call1
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Type5
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Count3
    {
        public int balls { get; set; }
        public int strikes { get; set; }
        public int outs { get; set; }
    }

    public class Player2
    {
        public int id { get; set; }
        public string link { get; set; }
    }

    public class Pitchdata1
    {
        public float startSpeed { get; set; }
        public float endSpeed { get; set; }
        public float strikeZoneTop { get; set; }
        public float strikeZoneBottom { get; set; }
        public Coordinates2 coordinates { get; set; }
        public Breaks1 breaks { get; set; }
        public int zone { get; set; }
        public float typeConfidence { get; set; }
        public float plateTime { get; set; }
        public float extension { get; set; }
    }

    public class Coordinates2
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

    public class Breaks1
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

    public class Hitdata1
    {
        public float launchSpeed { get; set; }
        public float launchAngle { get; set; }
        public float totalDistance { get; set; }
        public string trajectory { get; set; }
        public string hardness { get; set; }
        public string location { get; set; }
        public Coordinates3 coordinates { get; set; }
    }

    public class Coordinates3
    {
        public float coordX { get; set; }
        public float coordY { get; set; }
    }

    public class Position2
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Replacedplayer
    {
        public int id { get; set; }
        public string link { get; set; }
    }

    public class Playsbyinning
    {
        public int startIndex { get; set; }
        public int endIndex { get; set; }
        public int[] top { get; set; }
        public int[] bottom { get; set; }
        public Hits hits { get; set; }
    }

    public class Hits
    {
        public Away4[] away { get; set; }
        public Home4[] home { get; set; }
    }

    public class Away4
    {
        public Team team { get; set; }
        public int inning { get; set; }
        public Pitcher2 pitcher { get; set; }
        public Batter2 batter { get; set; }
        public Coordinates4 coordinates { get; set; }
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Team
    {
        public Springleague2 springLeague { get; set; }
        public string allStarStatus { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Springleague2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string abbreviation { get; set; }
    }

    public class Pitcher2
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Batter2
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Coordinates4
    {
        public float x { get; set; }
        public float y { get; set; }
    }

    public class Home4
    {
        public Team1 team { get; set; }
        public int inning { get; set; }
        public Pitcher3 pitcher { get; set; }
        public Batter3 batter { get; set; }
        public Coordinates5 coordinates { get; set; }
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Team1
    {
        public Springleague3 springLeague { get; set; }
        public string allStarStatus { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Springleague3
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string abbreviation { get; set; }
    }

    public class Pitcher3
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Batter3
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Coordinates5
    {
        public float x { get; set; }
        public float y { get; set; }
    }

    public class Linescore
    {
        public int currentInning { get; set; }
        public string currentInningOrdinal { get; set; }
        public string inningState { get; set; }
        public string inningHalf { get; set; }
        public bool isTopInning { get; set; }
        public int scheduledInnings { get; set; }
        public Innings[] innings { get; set; }
        public Teams1 teams { get; set; }
        public Defense defense { get; set; }
        public Offense offense { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public int outs { get; set; }
    }

    public class Teams1
    {
        public Home5 home { get; set; }
        public Away5 away { get; set; }
    }

    public class Home5
    {
        public int runs { get; set; }
        public int hits { get; set; }
        public int errors { get; set; }
        public int leftOnBase { get; set; }
    }

    public class Away5
    {
        public int runs { get; set; }
        public int hits { get; set; }
        public int errors { get; set; }
        public int leftOnBase { get; set; }
    }

    public class Defense
    {
        public Pitcher4 pitcher { get; set; }
        public Catcher catcher { get; set; }
        public First first { get; set; }
        public Second second { get; set; }
        public Third third { get; set; }
        public Shortstop shortstop { get; set; }
        public Left left { get; set; }
        public Center center { get; set; }
        public Right right { get; set; }
        public Batter4 batter { get; set; }
        public Ondeck onDeck { get; set; }
        public Inhole inHole { get; set; }
        public int battingOrder { get; set; }
        public Team2 team { get; set; }
    }

    public class Pitcher4
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

    public class Batter4
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

    public class Team2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Offense
    {
        public Batter5 batter { get; set; }
        public Ondeck1 onDeck { get; set; }
        public Inhole1 inHole { get; set; }
        public Pitcher5 pitcher { get; set; }
        public int battingOrder { get; set; }
        public Team3 team { get; set; }
    }

    public class Batter5
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

    public class Pitcher5
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Team3
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Innings
    {
        public int num { get; set; }
        public string ordinalNum { get; set; }
        public Home6 home { get; set; }
        public Away6 away { get; set; }
    }

    public class Home6
    {
        public int runs { get; set; }
        public int hits { get; set; }
        public int errors { get; set; }
        public int leftOnBase { get; set; }
    }

    public class Away6
    {
        public int runs { get; set; }
        public int hits { get; set; }
        public int errors { get; set; }
        public int leftOnBase { get; set; }
    }

    public class Boxscore
    {
        public Teams2 teams { get; set; }
        public Official[] officials { get; set; }
        public Info2[] info { get; set; }
        public object[] pitchingNotes { get; set; }
        public Topperformer[] topPerformers { get; set; }
    }

    public class Teams2
    {
        public Away7 away { get; set; }
        public Home7 home { get; set; }
    }

    public class Away7
    {
        public Team4 team { get; set; }
        public Teamstats teamStats { get; set; }
        public Players1 players { get; set; }
        public int[] batters { get; set; }
        public int[] pitchers { get; set; }
        public int[] bench { get; set; }
        public int[] bullpen { get; set; }
        public int[] battingOrder { get; set; }
        public Info[] info { get; set; }
        public Note[] note { get; set; }
    }

    public class Team4
    {
        public Springleague4 springLeague { get; set; }
        public string allStarStatus { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Springleague4
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string abbreviation { get; set; }
    }

    public class Teamstats
    {
        public Batting batting { get; set; }
        public Pitching pitching { get; set; }
        public Fielding fielding { get; set; }
    }

    public class Batting
    {
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching
    {
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int saveOpportunities { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string pitchesPerInning { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding
    {
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int assists { get; set; }
        public int putOuts { get; set; }
        public int errors { get; set; }
        public int chances { get; set; }
        public int passedBall { get; set; }
        public int pickoffs { get; set; }
    }

    public class Players1
    {
        public ID6692571 ID669257 { get; set; }
        public ID5433391 ID543339 { get; set; }
        public ID6899811 ID689981 { get; set; }
        public ID6071921 ID607192 { get; set; }
        public ID6819111 ID681911 { get; set; }
        public ID6051311 ID605131 { get; set; }
        public ID5717711 ID571771 { get; set; }
        public ID6427081 ID642708 { get; set; }
        public ID6051131 ID605113 { get; set; }
        public ID6074551 ID607455 { get; set; }
        public ID5187921 ID518792 { get; set; }
        public ID6564271 ID656427 { get; set; }
        public ID5952811 ID595281 { get; set; }
        public ID6602711 ID660271 { get; set; }
        public ID6566291 ID656629 { get; set; }
        public ID6244151 ID624415 { get; set; }
        public ID6061921 ID606192 { get; set; }
        public ID6816241 ID681624 { get; set; }
        public ID6661581 ID666158 { get; set; }
        public ID6815461 ID681546 { get; set; }
        public ID6234651 ID623465 { get; set; }
        public ID4771321 ID477132 { get; set; }
        public ID6417031 ID641703 { get; set; }
        public ID5232601 ID523260 { get; set; }
        public ID5950141 ID595014 { get; set; }
        public ID6948131 ID694813 { get; set; }
    }

    public class ID6692571
    {
        public Person person { get; set; }
        public string jerseyNumber { get; set; }
        public Position3 position { get; set; }
        public Status1 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats stats { get; set; }
        public Seasonstats seasonStats { get; set; }
        public Gamestatus gameStatus { get; set; }
        public Allposition[] allPositions { get; set; }
    }

    public class Person
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position3
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status1
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats
    {
        public Batting1 batting { get; set; }
        public Pitching1 pitching { get; set; }
        public Fielding1 fielding { get; set; }
    }

    public class Batting1
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching1
    {
    }

    public class Fielding1
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats
    {
        public Batting2 batting { get; set; }
        public Pitching2 pitching { get; set; }
        public Fielding2 fielding { get; set; }
    }

    public class Batting2
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching2
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding2
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID5433391
    {
        public Person1 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position4 position { get; set; }
        public Status2 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats1 stats { get; set; }
        public Seasonstats1 seasonStats { get; set; }
        public Gamestatus1 gameStatus { get; set; }
    }

    public class Person1
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position4
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status2
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats1
    {
        public Batting3 batting { get; set; }
        public Pitching3 pitching { get; set; }
        public Fielding3 fielding { get; set; }
    }

    public class Batting3
    {
    }

    public class Pitching3
    {
    }

    public class Fielding3
    {
    }

    public class Seasonstats1
    {
        public Batting4 batting { get; set; }
        public Pitching4 pitching { get; set; }
        public Fielding4 fielding { get; set; }
    }

    public class Batting4
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching4
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding4
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
    }

    public class Gamestatus1
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6899811
    {
        public Person2 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position5 position { get; set; }
        public Status3 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats2 stats { get; set; }
        public Seasonstats2 seasonStats { get; set; }
        public Gamestatus2 gameStatus { get; set; }
    }

    public class Person2
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position5
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status3
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats2
    {
        public Batting5 batting { get; set; }
        public Pitching5 pitching { get; set; }
        public Fielding5 fielding { get; set; }
    }

    public class Batting5
    {
    }

    public class Pitching5
    {
    }

    public class Fielding5
    {
    }

    public class Seasonstats2
    {
        public Batting6 batting { get; set; }
        public Pitching6 pitching { get; set; }
        public Fielding6 fielding { get; set; }
    }

    public class Batting6
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching6
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding6
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
    }

    public class Gamestatus2
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6071921
    {
        public Person3 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position6 position { get; set; }
        public Status4 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats3 stats { get; set; }
        public Seasonstats3 seasonStats { get; set; }
        public Gamestatus3 gameStatus { get; set; }
    }

    public class Person3
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position6
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status4
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats3
    {
        public Batting7 batting { get; set; }
        public Pitching7 pitching { get; set; }
        public Fielding7 fielding { get; set; }
    }

    public class Batting7
    {
    }

    public class Pitching7
    {
    }

    public class Fielding7
    {
    }

    public class Seasonstats3
    {
        public Batting8 batting { get; set; }
        public Pitching8 pitching { get; set; }
        public Fielding8 fielding { get; set; }
    }

    public class Batting8
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching8
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding8
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
    }

    public class Gamestatus3
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6819111
    {
        public Person4 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position7 position { get; set; }
        public Status5 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats4 stats { get; set; }
        public Seasonstats4 seasonStats { get; set; }
        public Gamestatus4 gameStatus { get; set; }
    }

    public class Person4
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position7
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status5
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats4
    {
        public Batting9 batting { get; set; }
        public Pitching9 pitching { get; set; }
        public Fielding9 fielding { get; set; }
    }

    public class Batting9
    {
    }

    public class Pitching9
    {
    }

    public class Fielding9
    {
    }

    public class Seasonstats4
    {
        public Batting10 batting { get; set; }
        public Pitching10 pitching { get; set; }
        public Fielding10 fielding { get; set; }
    }

    public class Batting10
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching10
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding10
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
    }

    public class Gamestatus4
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6051311
    {
        public Person5 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position8 position { get; set; }
        public Status6 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats5 stats { get; set; }
        public Seasonstats5 seasonStats { get; set; }
        public Gamestatus5 gameStatus { get; set; }
        public Allposition1[] allPositions { get; set; }
    }

    public class Person5
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position8
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status6
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats5
    {
        public Batting11 batting { get; set; }
        public Pitching11 pitching { get; set; }
        public Fielding11 fielding { get; set; }
    }

    public class Batting11
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching11
    {
    }

    public class Fielding11
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
    }

    public class Seasonstats5
    {
        public Batting12 batting { get; set; }
        public Pitching12 pitching { get; set; }
        public Fielding12 fielding { get; set; }
    }

    public class Batting12
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching12
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding12
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
    }

    public class Gamestatus5
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition1
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID5717711
    {
        public Person6 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position9 position { get; set; }
        public Status7 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats6 stats { get; set; }
        public Seasonstats6 seasonStats { get; set; }
        public Gamestatus6 gameStatus { get; set; }
        public Allposition2[] allPositions { get; set; }
    }

    public class Person6
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position9
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status7
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats6
    {
        public Batting13 batting { get; set; }
        public Pitching13 pitching { get; set; }
        public Fielding13 fielding { get; set; }
    }

    public class Batting13
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching13
    {
        public string summary { get; set; }
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public int rbi { get; set; }
        public int gamesFinished { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding13
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats6
    {
        public Batting14 batting { get; set; }
        public Pitching14 pitching { get; set; }
        public Fielding14 fielding { get; set; }
    }

    public class Batting14
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching14
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding14
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus6
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition2
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6427081
    {
        public Person7 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position10 position { get; set; }
        public Status8 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats7 stats { get; set; }
        public Seasonstats7 seasonStats { get; set; }
        public Gamestatus7 gameStatus { get; set; }
        public Allposition3[] allPositions { get; set; }
    }

    public class Person7
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position10
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status8
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats7
    {
        public Batting15 batting { get; set; }
        public Pitching15 pitching { get; set; }
        public Fielding15 fielding { get; set; }
    }

    public class Batting15
    {
        public string note { get; set; }
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching15
    {
    }

    public class Fielding15
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
    }

    public class Seasonstats7
    {
        public Batting16 batting { get; set; }
        public Pitching16 pitching { get; set; }
        public Fielding16 fielding { get; set; }
    }

    public class Batting16
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching16
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding16
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
    }

    public class Gamestatus7
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition3
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6051131
    {
        public Person8 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position11 position { get; set; }
        public Status9 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats8 stats { get; set; }
        public Seasonstats8 seasonStats { get; set; }
        public Gamestatus8 gameStatus { get; set; }
        public Allposition4[] allPositions { get; set; }
    }

    public class Person8
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position11
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status9
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats8
    {
        public Batting17 batting { get; set; }
        public Pitching17 pitching { get; set; }
        public Fielding17 fielding { get; set; }
    }

    public class Batting17
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching17
    {
    }

    public class Fielding17
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats8
    {
        public Batting18 batting { get; set; }
        public Pitching18 pitching { get; set; }
        public Fielding18 fielding { get; set; }
    }

    public class Batting18
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching18
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding18
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus8
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition4
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6074551
    {
        public Person9 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position12 position { get; set; }
        public Status10 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats9 stats { get; set; }
        public Seasonstats9 seasonStats { get; set; }
        public Gamestatus9 gameStatus { get; set; }
    }

    public class Person9
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position12
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status10
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats9
    {
        public Batting19 batting { get; set; }
        public Pitching19 pitching { get; set; }
        public Fielding19 fielding { get; set; }
    }

    public class Batting19
    {
    }

    public class Pitching19
    {
    }

    public class Fielding19
    {
    }

    public class Seasonstats9
    {
        public Batting20 batting { get; set; }
        public Pitching20 pitching { get; set; }
        public Fielding20 fielding { get; set; }
    }

    public class Batting20
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching20
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding20
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
    }

    public class Gamestatus9
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID5187921
    {
        public Person10 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position13 position { get; set; }
        public Status11 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats10 stats { get; set; }
        public Seasonstats10 seasonStats { get; set; }
        public Gamestatus10 gameStatus { get; set; }
        public Allposition5[] allPositions { get; set; }
    }

    public class Person10
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position13
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status11
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats10
    {
        public Batting21 batting { get; set; }
        public Pitching21 pitching { get; set; }
        public Fielding21 fielding { get; set; }
    }

    public class Batting21
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching21
    {
    }

    public class Fielding21
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats10
    {
        public Batting22 batting { get; set; }
        public Pitching22 pitching { get; set; }
        public Fielding22 fielding { get; set; }
    }

    public class Batting22
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching22
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding22
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus10
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition5
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6564271
    {
        public Person11 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position14 position { get; set; }
        public Status12 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats11 stats { get; set; }
        public Seasonstats11 seasonStats { get; set; }
        public Gamestatus11 gameStatus { get; set; }
        public Allposition6[] allPositions { get; set; }
    }

    public class Person11
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position14
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status12
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats11
    {
        public Batting23 batting { get; set; }
        public Pitching23 pitching { get; set; }
        public Fielding23 fielding { get; set; }
    }

    public class Batting23
    {
    }

    public class Pitching23
    {
        public string note { get; set; }
        public string summary { get; set; }
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public int rbi { get; set; }
        public int gamesFinished { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding23
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats11
    {
        public Batting24 batting { get; set; }
        public Pitching24 pitching { get; set; }
        public Fielding24 fielding { get; set; }
    }

    public class Batting24
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching24
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding24
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus11
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition6
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID5952811
    {
        public Person12 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position15 position { get; set; }
        public Status13 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats12 stats { get; set; }
        public Seasonstats12 seasonStats { get; set; }
        public Gamestatus12 gameStatus { get; set; }
    }

    public class Person12
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position15
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status13
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats12
    {
        public Batting25 batting { get; set; }
        public Pitching25 pitching { get; set; }
        public Fielding25 fielding { get; set; }
    }

    public class Batting25
    {
    }

    public class Pitching25
    {
    }

    public class Fielding25
    {
    }

    public class Seasonstats12
    {
        public Batting26 batting { get; set; }
        public Pitching26 pitching { get; set; }
        public Fielding26 fielding { get; set; }
    }

    public class Batting26
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching26
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding26
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
    }

    public class Gamestatus12
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6602711
    {
        public Person13 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position16 position { get; set; }
        public Status14 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats13 stats { get; set; }
        public Seasonstats13 seasonStats { get; set; }
        public Gamestatus13 gameStatus { get; set; }
        public Allposition7[] allPositions { get; set; }
    }

    public class Person13
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position16
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status14
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats13
    {
        public Batting27 batting { get; set; }
        public Pitching27 pitching { get; set; }
        public Fielding27 fielding { get; set; }
    }

    public class Batting27
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching27
    {
    }

    public class Fielding27
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
    }

    public class Seasonstats13
    {
        public Batting28 batting { get; set; }
        public Pitching28 pitching { get; set; }
        public Fielding28 fielding { get; set; }
    }

    public class Batting28
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching28
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding28
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
    }

    public class Gamestatus13
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition7
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6566291
    {
        public Person14 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position17 position { get; set; }
        public Status15 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats14 stats { get; set; }
        public Seasonstats14 seasonStats { get; set; }
        public Gamestatus14 gameStatus { get; set; }
        public Allposition8[] allPositions { get; set; }
    }

    public class Person14
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position17
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status15
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats14
    {
        public Batting29 batting { get; set; }
        public Pitching29 pitching { get; set; }
        public Fielding29 fielding { get; set; }
    }

    public class Batting29
    {
    }

    public class Pitching29
    {
        public string note { get; set; }
        public string summary { get; set; }
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public int rbi { get; set; }
        public int gamesFinished { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding29
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
    }

    public class Seasonstats14
    {
        public Batting30 batting { get; set; }
        public Pitching30 pitching { get; set; }
        public Fielding30 fielding { get; set; }
    }

    public class Batting30
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching30
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding30
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
    }

    public class Gamestatus14
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition8
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6244151
    {
        public Person15 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position18 position { get; set; }
        public Status16 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats15 stats { get; set; }
        public Seasonstats15 seasonStats { get; set; }
        public Gamestatus15 gameStatus { get; set; }
        public Allposition9[] allPositions { get; set; }
    }

    public class Person15
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position18
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status16
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats15
    {
        public Batting31 batting { get; set; }
        public Pitching31 pitching { get; set; }
        public Fielding31 fielding { get; set; }
    }

    public class Batting31
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching31
    {
    }

    public class Fielding31
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats15
    {
        public Batting32 batting { get; set; }
        public Pitching32 pitching { get; set; }
        public Fielding32 fielding { get; set; }
    }

    public class Batting32
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching32
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding32
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus15
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition9
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6061921
    {
        public Person16 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position19 position { get; set; }
        public Status17 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats16 stats { get; set; }
        public Seasonstats16 seasonStats { get; set; }
        public Gamestatus16 gameStatus { get; set; }
        public Allposition10[] allPositions { get; set; }
    }

    public class Person16
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position19
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status17
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats16
    {
        public Batting33 batting { get; set; }
        public Pitching33 pitching { get; set; }
        public Fielding33 fielding { get; set; }
    }

    public class Batting33
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching33
    {
    }

    public class Fielding33
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats16
    {
        public Batting34 batting { get; set; }
        public Pitching34 pitching { get; set; }
        public Fielding34 fielding { get; set; }
    }

    public class Batting34
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching34
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding34
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus16
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition10
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6816241
    {
        public Person17 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position20 position { get; set; }
        public Status18 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats17 stats { get; set; }
        public Seasonstats17 seasonStats { get; set; }
        public Gamestatus17 gameStatus { get; set; }
        public Allposition11[] allPositions { get; set; }
    }

    public class Person17
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position20
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status18
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats17
    {
        public Batting35 batting { get; set; }
        public Pitching35 pitching { get; set; }
        public Fielding35 fielding { get; set; }
    }

    public class Batting35
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching35
    {
    }

    public class Fielding35
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats17
    {
        public Batting36 batting { get; set; }
        public Pitching36 pitching { get; set; }
        public Fielding36 fielding { get; set; }
    }

    public class Batting36
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching36
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding36
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus17
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition11
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6661581
    {
        public Person18 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position21 position { get; set; }
        public Status19 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats18 stats { get; set; }
        public Seasonstats18 seasonStats { get; set; }
        public Gamestatus18 gameStatus { get; set; }
        public Allposition12[] allPositions { get; set; }
    }

    public class Person18
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position21
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status19
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats18
    {
        public Batting37 batting { get; set; }
        public Pitching37 pitching { get; set; }
        public Fielding37 fielding { get; set; }
    }

    public class Batting37
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching37
    {
    }

    public class Fielding37
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats18
    {
        public Batting38 batting { get; set; }
        public Pitching38 pitching { get; set; }
        public Fielding38 fielding { get; set; }
    }

    public class Batting38
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching38
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding38
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus18
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition12
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6815461
    {
        public Person19 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position22 position { get; set; }
        public Status20 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats19 stats { get; set; }
        public Seasonstats19 seasonStats { get; set; }
        public Gamestatus19 gameStatus { get; set; }
    }

    public class Person19
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position22
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status20
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats19
    {
        public Batting39 batting { get; set; }
        public Pitching39 pitching { get; set; }
        public Fielding39 fielding { get; set; }
    }

    public class Batting39
    {
    }

    public class Pitching39
    {
    }

    public class Fielding39
    {
    }

    public class Seasonstats19
    {
        public Batting40 batting { get; set; }
        public Pitching40 pitching { get; set; }
        public Fielding40 fielding { get; set; }
    }

    public class Batting40
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching40
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding40
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
    }

    public class Gamestatus19
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6234651
    {
        public Person20 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position23 position { get; set; }
        public Status21 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats20 stats { get; set; }
        public Seasonstats20 seasonStats { get; set; }
        public Gamestatus20 gameStatus { get; set; }
    }

    public class Person20
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position23
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status21
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats20
    {
        public Batting41 batting { get; set; }
        public Pitching41 pitching { get; set; }
        public Fielding41 fielding { get; set; }
    }

    public class Batting41
    {
    }

    public class Pitching41
    {
    }

    public class Fielding41
    {
    }

    public class Seasonstats20
    {
        public Batting42 batting { get; set; }
        public Pitching42 pitching { get; set; }
        public Fielding42 fielding { get; set; }
    }

    public class Batting42
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching42
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding42
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
    }

    public class Gamestatus20
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID4771321
    {
        public Person21 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position24 position { get; set; }
        public Status22 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats21 stats { get; set; }
        public Seasonstats21 seasonStats { get; set; }
        public Gamestatus21 gameStatus { get; set; }
    }

    public class Person21
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position24
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status22
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats21
    {
        public Batting43 batting { get; set; }
        public Pitching43 pitching { get; set; }
        public Fielding43 fielding { get; set; }
    }

    public class Batting43
    {
    }

    public class Pitching43
    {
    }

    public class Fielding43
    {
    }

    public class Seasonstats21
    {
        public Batting44 batting { get; set; }
        public Pitching44 pitching { get; set; }
        public Fielding44 fielding { get; set; }
    }

    public class Batting44
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching44
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding44
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
    }

    public class Gamestatus21
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6417031
    {
        public Person22 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position25 position { get; set; }
        public Status23 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats22 stats { get; set; }
        public Seasonstats22 seasonStats { get; set; }
        public Gamestatus22 gameStatus { get; set; }
    }

    public class Person22
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position25
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status23
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats22
    {
        public Batting45 batting { get; set; }
        public Pitching45 pitching { get; set; }
        public Fielding45 fielding { get; set; }
    }

    public class Batting45
    {
    }

    public class Pitching45
    {
    }

    public class Fielding45
    {
    }

    public class Seasonstats22
    {
        public Batting46 batting { get; set; }
        public Pitching46 pitching { get; set; }
        public Fielding46 fielding { get; set; }
    }

    public class Batting46
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching46
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding46
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
    }

    public class Gamestatus22
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID5232601
    {
        public Person23 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position26 position { get; set; }
        public Status24 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats23 stats { get; set; }
        public Seasonstats23 seasonStats { get; set; }
        public Gamestatus23 gameStatus { get; set; }
    }

    public class Person23
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position26
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status24
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats23
    {
        public Batting47 batting { get; set; }
        public Pitching47 pitching { get; set; }
        public Fielding47 fielding { get; set; }
    }

    public class Batting47
    {
    }

    public class Pitching47
    {
    }

    public class Fielding47
    {
    }

    public class Seasonstats23
    {
        public Batting48 batting { get; set; }
        public Pitching48 pitching { get; set; }
        public Fielding48 fielding { get; set; }
    }

    public class Batting48
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching48
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding48
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
    }

    public class Gamestatus23
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID5950141
    {
        public Person24 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position27 position { get; set; }
        public Status25 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats24 stats { get; set; }
        public Seasonstats24 seasonStats { get; set; }
        public Gamestatus24 gameStatus { get; set; }
        public Allposition13[] allPositions { get; set; }
    }

    public class Person24
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position27
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status25
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats24
    {
        public Batting49 batting { get; set; }
        public Pitching49 pitching { get; set; }
        public Fielding49 fielding { get; set; }
    }

    public class Batting49
    {
    }

    public class Pitching49
    {
        public string summary { get; set; }
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public int rbi { get; set; }
        public int gamesFinished { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding49
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
    }

    public class Seasonstats24
    {
        public Batting50 batting { get; set; }
        public Pitching50 pitching { get; set; }
        public Fielding50 fielding { get; set; }
    }

    public class Batting50
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching50
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding50
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
    }

    public class Gamestatus24
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition13
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6948131
    {
        public Person25 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position28 position { get; set; }
        public Status26 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats25 stats { get; set; }
        public Seasonstats25 seasonStats { get; set; }
        public Gamestatus25 gameStatus { get; set; }
    }

    public class Person25
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position28
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status26
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats25
    {
        public Batting51 batting { get; set; }
        public Pitching51 pitching { get; set; }
        public Fielding51 fielding { get; set; }
    }

    public class Batting51
    {
    }

    public class Pitching51
    {
    }

    public class Fielding51
    {
    }

    public class Seasonstats25
    {
        public Batting52 batting { get; set; }
        public Pitching52 pitching { get; set; }
        public Fielding52 fielding { get; set; }
    }

    public class Batting52
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching52
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding52
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
    }

    public class Gamestatus25
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Info
    {
        public string title { get; set; }
        public Fieldlist[] fieldList { get; set; }
    }

    public class Fieldlist
    {
        public string label { get; set; }
        public string value { get; set; }
    }

    public class Note
    {
        public string label { get; set; }
        public string value { get; set; }
    }

    public class Home7
    {
        public Team5 team { get; set; }
        public Teamstats1 teamStats { get; set; }
        public Players2 players { get; set; }
        public int[] batters { get; set; }
        public int[] pitchers { get; set; }
        public int[] bench { get; set; }
        public int[] bullpen { get; set; }
        public int[] battingOrder { get; set; }
        public Info1[] info { get; set; }
        public object[] note { get; set; }
    }

    public class Team5
    {
        public Springleague5 springLeague { get; set; }
        public string allStarStatus { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Springleague5
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string abbreviation { get; set; }
    }

    public class Teamstats1
    {
        public Batting53 batting { get; set; }
        public Pitching53 pitching { get; set; }
        public Fielding53 fielding { get; set; }
    }

    public class Batting53
    {
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching53
    {
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int saveOpportunities { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string pitchesPerInning { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding53
    {
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int assists { get; set; }
        public int putOuts { get; set; }
        public int errors { get; set; }
        public int chances { get; set; }
        public int passedBall { get; set; }
        public int pickoffs { get; set; }
    }

    public class Players2
    {
        public ID6717321 ID671732 { get; set; }
        public ID6221031 ID622103 { get; set; }
        public ID6676701 ID667670 { get; set; }
        public ID6808691 ID680869 { get; set; }
        public ID6662051 ID666205 { get; set; }
        public ID5183971 ID518397 { get; set; }
        public ID5190081 ID519008 { get; set; }
        public ID6210531 ID621053 { get; set; }
        public ID6877651 ID687765 { get; set; }
        public ID6804741 ID680474 { get; set; }
        public ID6135341 ID613534 { get; set; }
        public ID6743701 ID674370 { get; set; }
        public ID6649131 ID664913 { get; set; }
        public ID6635271 ID663527 { get; set; }
        public ID6713051 ID671305 { get; set; }
        public ID6092801 ID609280 { get; set; }
        public ID6872311 ID687231 { get; set; }
        public ID6943611 ID694361 { get; set; }
        public ID6473511 ID647351 { get; set; }
        public ID6831551 ID683155 { get; set; }
        public ID6688321 ID668832 { get; set; }
        public ID6636621 ID663662 { get; set; }
        public ID6691271 ID669127 { get; set; }
        public ID5483891 ID548389 { get; set; }
        public ID6687091 ID668709 { get; set; }
        public ID6766641 ID676664 { get; set; }
    }

    public class ID6717321
    {
        public Person26 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position29 position { get; set; }
        public Status27 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats26 stats { get; set; }
        public Seasonstats26 seasonStats { get; set; }
        public Gamestatus26 gameStatus { get; set; }
        public Allposition14[] allPositions { get; set; }
    }

    public class Person26
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position29
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status27
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats26
    {
        public Batting54 batting { get; set; }
        public Pitching54 pitching { get; set; }
        public Fielding54 fielding { get; set; }
    }

    public class Batting54
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching54
    {
    }

    public class Fielding54
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats26
    {
        public Batting55 batting { get; set; }
        public Pitching55 pitching { get; set; }
        public Fielding55 fielding { get; set; }
    }

    public class Batting55
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching55
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding55
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus26
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition14
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6221031
    {
        public Person27 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position30 position { get; set; }
        public Status28 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats27 stats { get; set; }
        public Seasonstats27 seasonStats { get; set; }
        public Gamestatus27 gameStatus { get; set; }
        public Allposition15[] allPositions { get; set; }
    }

    public class Person27
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position30
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status28
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats27
    {
        public Batting56 batting { get; set; }
        public Pitching56 pitching { get; set; }
        public Fielding56 fielding { get; set; }
    }

    public class Batting56
    {
    }

    public class Pitching56
    {
        public string summary { get; set; }
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public int rbi { get; set; }
        public int gamesFinished { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding56
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
    }

    public class Seasonstats27
    {
        public Batting57 batting { get; set; }
        public Pitching57 pitching { get; set; }
        public Fielding57 fielding { get; set; }
    }

    public class Batting57
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching57
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding57
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
    }

    public class Gamestatus27
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition15
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6676701
    {
        public Person28 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position31 position { get; set; }
        public Status29 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats28 stats { get; set; }
        public Seasonstats28 seasonStats { get; set; }
        public Gamestatus28 gameStatus { get; set; }
        public Allposition16[] allPositions { get; set; }
    }

    public class Person28
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position31
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status29
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats28
    {
        public Batting58 batting { get; set; }
        public Pitching58 pitching { get; set; }
        public Fielding58 fielding { get; set; }
    }

    public class Batting58
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching58
    {
    }

    public class Fielding58
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
    }

    public class Seasonstats28
    {
        public Batting59 batting { get; set; }
        public Pitching59 pitching { get; set; }
        public Fielding59 fielding { get; set; }
    }

    public class Batting59
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching59
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding59
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
    }

    public class Gamestatus28
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition16
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6808691
    {
        public Person29 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position32 position { get; set; }
        public Status30 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats29 stats { get; set; }
        public Seasonstats29 seasonStats { get; set; }
        public Gamestatus29 gameStatus { get; set; }
    }

    public class Person29
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position32
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status30
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats29
    {
        public Batting60 batting { get; set; }
        public Pitching60 pitching { get; set; }
        public Fielding60 fielding { get; set; }
    }

    public class Batting60
    {
    }

    public class Pitching60
    {
    }

    public class Fielding60
    {
    }

    public class Seasonstats29
    {
        public Batting61 batting { get; set; }
        public Pitching61 pitching { get; set; }
        public Fielding61 fielding { get; set; }
    }

    public class Batting61
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching61
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding61
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
    }

    public class Gamestatus29
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6662051
    {
        public Person30 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position33 position { get; set; }
        public Status31 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats30 stats { get; set; }
        public Seasonstats30 seasonStats { get; set; }
        public Gamestatus30 gameStatus { get; set; }
        public Allposition17[] allPositions { get; set; }
    }

    public class Person30
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position33
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status31
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats30
    {
        public Batting62 batting { get; set; }
        public Pitching62 pitching { get; set; }
        public Fielding62 fielding { get; set; }
    }

    public class Batting62
    {
    }

    public class Pitching62
    {
        public string summary { get; set; }
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public int rbi { get; set; }
        public int gamesFinished { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding62
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
    }

    public class Seasonstats30
    {
        public Batting63 batting { get; set; }
        public Pitching63 pitching { get; set; }
        public Fielding63 fielding { get; set; }
    }

    public class Batting63
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching63
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding63
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
    }

    public class Gamestatus30
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition17
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID5183971
    {
        public Person31 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position34 position { get; set; }
        public Status32 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats31 stats { get; set; }
        public Seasonstats31 seasonStats { get; set; }
        public Gamestatus31 gameStatus { get; set; }
        public Allposition18[] allPositions { get; set; }
    }

    public class Person31
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position34
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status32
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats31
    {
        public Batting64 batting { get; set; }
        public Pitching64 pitching { get; set; }
        public Fielding64 fielding { get; set; }
    }

    public class Batting64
    {
    }

    public class Pitching64
    {
        public string summary { get; set; }
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public int rbi { get; set; }
        public int gamesFinished { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding64
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
    }

    public class Seasonstats31
    {
        public Batting65 batting { get; set; }
        public Pitching65 pitching { get; set; }
        public Fielding65 fielding { get; set; }
    }

    public class Batting65
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching65
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding65
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
    }

    public class Gamestatus31
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition18
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID5190081
    {
        public Person32 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position35 position { get; set; }
        public Status33 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats32 stats { get; set; }
        public Seasonstats32 seasonStats { get; set; }
        public Gamestatus32 gameStatus { get; set; }
    }

    public class Person32
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position35
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status33
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats32
    {
        public Batting66 batting { get; set; }
        public Pitching66 pitching { get; set; }
        public Fielding66 fielding { get; set; }
    }

    public class Batting66
    {
    }

    public class Pitching66
    {
    }

    public class Fielding66
    {
    }

    public class Seasonstats32
    {
        public Batting67 batting { get; set; }
        public Pitching67 pitching { get; set; }
        public Fielding67 fielding { get; set; }
    }

    public class Batting67
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching67
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding67
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
    }

    public class Gamestatus32
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6210531
    {
        public Person33 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position36 position { get; set; }
        public Status34 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats33 stats { get; set; }
        public Seasonstats33 seasonStats { get; set; }
        public Gamestatus33 gameStatus { get; set; }
    }

    public class Person33
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position36
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status34
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats33
    {
        public Batting68 batting { get; set; }
        public Pitching68 pitching { get; set; }
        public Fielding68 fielding { get; set; }
    }

    public class Batting68
    {
    }

    public class Pitching68
    {
    }

    public class Fielding68
    {
    }

    public class Seasonstats33
    {
        public Batting69 batting { get; set; }
        public Pitching69 pitching { get; set; }
        public Fielding69 fielding { get; set; }
    }

    public class Batting69
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching69
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding69
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
    }

    public class Gamestatus33
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6877651
    {
        public Person34 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position37 position { get; set; }
        public Status35 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats34 stats { get; set; }
        public Seasonstats34 seasonStats { get; set; }
        public Gamestatus34 gameStatus { get; set; }
        public Allposition19[] allPositions { get; set; }
    }

    public class Person34
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position37
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status35
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats34
    {
        public Batting70 batting { get; set; }
        public Pitching70 pitching { get; set; }
        public Fielding70 fielding { get; set; }
    }

    public class Batting70
    {
    }

    public class Pitching70
    {
        public string note { get; set; }
        public string summary { get; set; }
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public int rbi { get; set; }
        public int gamesFinished { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding70
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats34
    {
        public Batting71 batting { get; set; }
        public Pitching71 pitching { get; set; }
        public Fielding71 fielding { get; set; }
    }

    public class Batting71
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching71
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding71
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus34
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition19
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6804741
    {
        public Person35 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position38 position { get; set; }
        public Status36 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats35 stats { get; set; }
        public Seasonstats35 seasonStats { get; set; }
        public Gamestatus35 gameStatus { get; set; }
        public Allposition20[] allPositions { get; set; }
    }

    public class Person35
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position38
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status36
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats35
    {
        public Batting72 batting { get; set; }
        public Pitching72 pitching { get; set; }
        public Fielding72 fielding { get; set; }
    }

    public class Batting72
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching72
    {
    }

    public class Fielding72
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats35
    {
        public Batting73 batting { get; set; }
        public Pitching73 pitching { get; set; }
        public Fielding73 fielding { get; set; }
    }

    public class Batting73
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching73
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding73
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus35
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition20
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6135341
    {
        public Person36 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position39 position { get; set; }
        public Status37 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats36 stats { get; set; }
        public Seasonstats36 seasonStats { get; set; }
        public Gamestatus36 gameStatus { get; set; }
    }

    public class Person36
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position39
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status37
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats36
    {
        public Batting74 batting { get; set; }
        public Pitching74 pitching { get; set; }
        public Fielding74 fielding { get; set; }
    }

    public class Batting74
    {
    }

    public class Pitching74
    {
    }

    public class Fielding74
    {
    }

    public class Seasonstats36
    {
        public Batting75 batting { get; set; }
        public Pitching75 pitching { get; set; }
        public Fielding75 fielding { get; set; }
    }

    public class Batting75
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching75
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding75
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
    }

    public class Gamestatus36
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6743701
    {
        public Person37 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position40 position { get; set; }
        public Status38 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats37 stats { get; set; }
        public Seasonstats37 seasonStats { get; set; }
        public Gamestatus37 gameStatus { get; set; }
    }

    public class Person37
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position40
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status38
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats37
    {
        public Batting76 batting { get; set; }
        public Pitching76 pitching { get; set; }
        public Fielding76 fielding { get; set; }
    }

    public class Batting76
    {
    }

    public class Pitching76
    {
    }

    public class Fielding76
    {
    }

    public class Seasonstats37
    {
        public Batting77 batting { get; set; }
        public Pitching77 pitching { get; set; }
        public Fielding77 fielding { get; set; }
    }

    public class Batting77
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching77
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding77
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
    }

    public class Gamestatus37
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6649131
    {
        public Person38 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position41 position { get; set; }
        public Status39 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats38 stats { get; set; }
        public Seasonstats38 seasonStats { get; set; }
        public Gamestatus38 gameStatus { get; set; }
        public Allposition21[] allPositions { get; set; }
    }

    public class Person38
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position41
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status39
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats38
    {
        public Batting78 batting { get; set; }
        public Pitching78 pitching { get; set; }
        public Fielding78 fielding { get; set; }
    }

    public class Batting78
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching78
    {
    }

    public class Fielding78
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats38
    {
        public Batting79 batting { get; set; }
        public Pitching79 pitching { get; set; }
        public Fielding79 fielding { get; set; }
    }

    public class Batting79
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching79
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding79
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus38
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition21
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6635271
    {
        public Person39 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position42 position { get; set; }
        public Status40 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats39 stats { get; set; }
        public Seasonstats39 seasonStats { get; set; }
        public Gamestatus39 gameStatus { get; set; }
    }

    public class Person39
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position42
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status40
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats39
    {
        public Batting80 batting { get; set; }
        public Pitching80 pitching { get; set; }
        public Fielding80 fielding { get; set; }
    }

    public class Batting80
    {
    }

    public class Pitching80
    {
    }

    public class Fielding80
    {
    }

    public class Seasonstats39
    {
        public Batting81 batting { get; set; }
        public Pitching81 pitching { get; set; }
        public Fielding81 fielding { get; set; }
    }

    public class Batting81
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching81
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding81
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
    }

    public class Gamestatus39
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6713051
    {
        public Person40 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position43 position { get; set; }
        public Status41 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats40 stats { get; set; }
        public Seasonstats40 seasonStats { get; set; }
        public Gamestatus40 gameStatus { get; set; }
    }

    public class Person40
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position43
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status41
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats40
    {
        public Batting82 batting { get; set; }
        public Pitching82 pitching { get; set; }
        public Fielding82 fielding { get; set; }
    }

    public class Batting82
    {
    }

    public class Pitching82
    {
    }

    public class Fielding82
    {
    }

    public class Seasonstats40
    {
        public Batting83 batting { get; set; }
        public Pitching83 pitching { get; set; }
        public Fielding83 fielding { get; set; }
    }

    public class Batting83
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching83
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding83
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
    }

    public class Gamestatus40
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6092801
    {
        public Person41 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position44 position { get; set; }
        public Status42 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats41 stats { get; set; }
        public Seasonstats41 seasonStats { get; set; }
        public Gamestatus41 gameStatus { get; set; }
        public Allposition22[] allPositions { get; set; }
    }

    public class Person41
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position44
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status42
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats41
    {
        public Batting84 batting { get; set; }
        public Pitching84 pitching { get; set; }
        public Fielding84 fielding { get; set; }
    }

    public class Batting84
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching84
    {
    }

    public class Fielding84
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats41
    {
        public Batting85 batting { get; set; }
        public Pitching85 pitching { get; set; }
        public Fielding85 fielding { get; set; }
    }

    public class Batting85
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching85
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding85
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus41
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition22
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6872311
    {
        public Person42 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position45 position { get; set; }
        public Status43 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats42 stats { get; set; }
        public Seasonstats42 seasonStats { get; set; }
        public Gamestatus42 gameStatus { get; set; }
        public Allposition23[] allPositions { get; set; }
    }

    public class Person42
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position45
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status43
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats42
    {
        public Batting86 batting { get; set; }
        public Pitching86 pitching { get; set; }
        public Fielding86 fielding { get; set; }
    }

    public class Batting86
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching86
    {
    }

    public class Fielding86
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats42
    {
        public Batting87 batting { get; set; }
        public Pitching87 pitching { get; set; }
        public Fielding87 fielding { get; set; }
    }

    public class Batting87
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching87
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding87
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus42
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition23
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6943611
    {
        public Person43 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position46 position { get; set; }
        public Status44 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats43 stats { get; set; }
        public Seasonstats43 seasonStats { get; set; }
        public Gamestatus43 gameStatus { get; set; }
        public Allposition24[] allPositions { get; set; }
    }

    public class Person43
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position46
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status44
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats43
    {
        public Batting88 batting { get; set; }
        public Pitching88 pitching { get; set; }
        public Fielding88 fielding { get; set; }
    }

    public class Batting88
    {
    }

    public class Pitching88
    {
        public string summary { get; set; }
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public int rbi { get; set; }
        public int gamesFinished { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding88
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
    }

    public class Seasonstats43
    {
        public Batting89 batting { get; set; }
        public Pitching89 pitching { get; set; }
        public Fielding89 fielding { get; set; }
    }

    public class Batting89
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching89
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding89
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
    }

    public class Gamestatus43
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition24
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6473511
    {
        public Person44 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position47 position { get; set; }
        public Status45 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats44 stats { get; set; }
        public Seasonstats44 seasonStats { get; set; }
        public Gamestatus44 gameStatus { get; set; }
        public Allposition25[] allPositions { get; set; }
    }

    public class Person44
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position47
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status45
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats44
    {
        public Batting90 batting { get; set; }
        public Pitching90 pitching { get; set; }
        public Fielding90 fielding { get; set; }
    }

    public class Batting90
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching90
    {
    }

    public class Fielding90
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats44
    {
        public Batting91 batting { get; set; }
        public Pitching91 pitching { get; set; }
        public Fielding91 fielding { get; set; }
    }

    public class Batting91
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching91
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding91
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus44
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition25
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6831551
    {
        public Person45 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position48 position { get; set; }
        public Status46 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats45 stats { get; set; }
        public Seasonstats45 seasonStats { get; set; }
        public Gamestatus45 gameStatus { get; set; }
    }

    public class Person45
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position48
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status46
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats45
    {
        public Batting92 batting { get; set; }
        public Pitching92 pitching { get; set; }
        public Fielding92 fielding { get; set; }
    }

    public class Batting92
    {
    }

    public class Pitching92
    {
    }

    public class Fielding92
    {
    }

    public class Seasonstats45
    {
        public Batting93 batting { get; set; }
        public Pitching93 pitching { get; set; }
        public Fielding93 fielding { get; set; }
    }

    public class Batting93
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching93
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding93
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
    }

    public class Gamestatus45
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6688321
    {
        public Person46 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position49 position { get; set; }
        public Status47 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats46 stats { get; set; }
        public Seasonstats46 seasonStats { get; set; }
        public Gamestatus46 gameStatus { get; set; }
    }

    public class Person46
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position49
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status47
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats46
    {
        public Batting94 batting { get; set; }
        public Pitching94 pitching { get; set; }
        public Fielding94 fielding { get; set; }
    }

    public class Batting94
    {
    }

    public class Pitching94
    {
    }

    public class Fielding94
    {
    }

    public class Seasonstats46
    {
        public Batting95 batting { get; set; }
        public Pitching95 pitching { get; set; }
        public Fielding95 fielding { get; set; }
    }

    public class Batting95
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching95
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding95
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
    }

    public class Gamestatus46
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6636621
    {
        public Person47 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position50 position { get; set; }
        public Status48 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats47 stats { get; set; }
        public Seasonstats47 seasonStats { get; set; }
        public Gamestatus47 gameStatus { get; set; }
    }

    public class Person47
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position50
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status48
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats47
    {
        public Batting96 batting { get; set; }
        public Pitching96 pitching { get; set; }
        public Fielding96 fielding { get; set; }
    }

    public class Batting96
    {
    }

    public class Pitching96
    {
    }

    public class Fielding96
    {
    }

    public class Seasonstats47
    {
        public Batting97 batting { get; set; }
        public Pitching97 pitching { get; set; }
        public Fielding97 fielding { get; set; }
    }

    public class Batting97
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching97
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding97
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
    }

    public class Gamestatus47
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6691271
    {
        public Person48 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position51 position { get; set; }
        public Status49 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats48 stats { get; set; }
        public Seasonstats48 seasonStats { get; set; }
        public Gamestatus48 gameStatus { get; set; }
        public Allposition26[] allPositions { get; set; }
    }

    public class Person48
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position51
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status49
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats48
    {
        public Batting98 batting { get; set; }
        public Pitching98 pitching { get; set; }
        public Fielding98 fielding { get; set; }
    }

    public class Batting98
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching98
    {
    }

    public class Fielding98
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats48
    {
        public Batting99 batting { get; set; }
        public Pitching99 pitching { get; set; }
        public Fielding99 fielding { get; set; }
    }

    public class Batting99
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching99
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding99
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus48
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition26
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID5483891
    {
        public Person49 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position52 position { get; set; }
        public Status50 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats49 stats { get; set; }
        public Seasonstats49 seasonStats { get; set; }
        public Gamestatus49 gameStatus { get; set; }
    }

    public class Person49
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position52
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status50
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats49
    {
        public Batting100 batting { get; set; }
        public Pitching100 pitching { get; set; }
        public Fielding100 fielding { get; set; }
    }

    public class Batting100
    {
    }

    public class Pitching100
    {
    }

    public class Fielding100
    {
    }

    public class Seasonstats49
    {
        public Batting101 batting { get; set; }
        public Pitching101 pitching { get; set; }
        public Fielding101 fielding { get; set; }
    }

    public class Batting101
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching101
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding101
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
    }

    public class Gamestatus49
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class ID6687091
    {
        public Person50 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position53 position { get; set; }
        public Status51 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats50 stats { get; set; }
        public Seasonstats50 seasonStats { get; set; }
        public Gamestatus50 gameStatus { get; set; }
        public Allposition27[] allPositions { get; set; }
    }

    public class Person50
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position53
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status51
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats50
    {
        public Batting102 batting { get; set; }
        public Pitching102 pitching { get; set; }
        public Fielding102 fielding { get; set; }
    }

    public class Batting102
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching102
    {
    }

    public class Fielding102
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats50
    {
        public Batting103 batting { get; set; }
        public Pitching103 pitching { get; set; }
        public Fielding103 fielding { get; set; }
    }

    public class Batting103
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching103
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding103
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus50
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition27
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class ID6766641
    {
        public Person51 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position54 position { get; set; }
        public Status52 status { get; set; }
        public int parentTeamId { get; set; }
        public Stats51 stats { get; set; }
        public Seasonstats51 seasonStats { get; set; }
        public Gamestatus51 gameStatus { get; set; }
    }

    public class Person51
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position54
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status52
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats51
    {
        public Batting104 batting { get; set; }
        public Pitching104 pitching { get; set; }
        public Fielding104 fielding { get; set; }
    }

    public class Batting104
    {
    }

    public class Pitching104
    {
    }

    public class Fielding104
    {
    }

    public class Seasonstats51
    {
        public Batting105 batting { get; set; }
        public Pitching105 pitching { get; set; }
        public Fielding105 fielding { get; set; }
    }

    public class Batting105
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching105
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding105
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
    }

    public class Gamestatus51
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Info1
    {
        public string title { get; set; }
        public Fieldlist1[] fieldList { get; set; }
    }

    public class Fieldlist1
    {
        public string label { get; set; }
        public string value { get; set; }
    }

    public class Official
    {
        public Official1 official { get; set; }
        public string officialType { get; set; }
    }

    public class Official1
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Info2
    {
        public string label { get; set; }
        public string value { get; set; }
    }

    public class Topperformer
    {
        public Player3 player { get; set; }
        public string type { get; set; }
        public int gameScore { get; set; }
        public int pitchingGameScore { get; set; }
        public int hittingGameScore { get; set; }
    }

    public class Player3
    {
        public Person52 person { get; set; }
        public string jerseyNumber { get; set; }
        public Position55 position { get; set; }
        public Status53 status { get; set; }
        public int parentTeamId { get; set; }
        public string battingOrder { get; set; }
        public Stats52 stats { get; set; }
        public Seasonstats52 seasonStats { get; set; }
        public Gamestatus52 gameStatus { get; set; }
        public Allposition28[] allPositions { get; set; }
    }

    public class Person52
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position55
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Status53
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats52
    {
        public Batting106 batting { get; set; }
        public Pitching106 pitching { get; set; }
        public Fielding106 fielding { get; set; }
    }

    public class Batting106
    {
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int groundIntoDoublePlay { get; set; }
        public int groundIntoTriplePlay { get; set; }
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching106
    {
        public string summary { get; set; }
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public int rbi { get; set; }
        public int gamesFinished { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
        public string note { get; set; }
    }

    public class Fielding106
    {
        public int gamesStarted { get; set; }
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
    }

    public class Seasonstats52
    {
        public Batting107 batting { get; set; }
        public Pitching107 pitching { get; set; }
        public Fielding107 fielding { get; set; }
    }

    public class Batting107
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
        public int plateAppearances { get; set; }
        public int totalBases { get; set; }
        public int rbi { get; set; }
        public int leftOnBase { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public string babip { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int catchersInterference { get; set; }
        public int pickoffs { get; set; }
        public string atBatsPerHomeRun { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Pitching107
    {
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
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
        public string obp { get; set; }
        public int caughtStealing { get; set; }
        public int stolenBases { get; set; }
        public string stolenBasePercentage { get; set; }
        public int numberOfPitches { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public int holds { get; set; }
        public int blownSaves { get; set; }
        public int earnedRuns { get; set; }
        public string whip { get; set; }
        public int battersFaced { get; set; }
        public int outs { get; set; }
        public int gamesPitched { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int pitchesThrown { get; set; }
        public int balls { get; set; }
        public int strikes { get; set; }
        public string strikePercentage { get; set; }
        public int hitBatsmen { get; set; }
        public int balks { get; set; }
        public int wildPitches { get; set; }
        public int pickoffs { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int rbi { get; set; }
        public string winPercentage { get; set; }
        public string pitchesPerInning { get; set; }
        public int gamesFinished { get; set; }
        public string strikeoutWalkRatio { get; set; }
        public string strikeoutsPer9Inn { get; set; }
        public string walksPer9Inn { get; set; }
        public string hitsPer9Inn { get; set; }
        public string runsScoredPer9 { get; set; }
        public string homeRunsPer9 { get; set; }
        public int inheritedRunners { get; set; }
        public int inheritedRunnersScored { get; set; }
        public int catchersInterference { get; set; }
        public int sacBunts { get; set; }
        public int sacFlies { get; set; }
        public int passedBall { get; set; }
        public int popOuts { get; set; }
        public int lineOuts { get; set; }
    }

    public class Fielding107
    {
        public int gamesStarted { get; set; }
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
    }

    public class Gamestatus52
    {
        public bool isCurrentBatter { get; set; }
        public bool isCurrentPitcher { get; set; }
        public bool isOnBench { get; set; }
        public bool isSubstitute { get; set; }
    }

    public class Allposition28
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Decisions
    {
        public Winner winner { get; set; }
        public Loser loser { get; set; }
    }

    public class Winner
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Loser
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Leaders
    {
        public Hitdistance hitDistance { get; set; }
        public Hitspeed hitSpeed { get; set; }
        public Pitchspeed pitchSpeed { get; set; }
    }

    public class Hitdistance
    {
    }

    public class Hitspeed
    {
    }

    public class Pitchspeed
    {
    }

}
