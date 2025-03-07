using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballTeamStandingsRecord
    {
        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeam Team { get; set; }

        /// <summary>
        /// Gets or Sets Wins
        /// </summary>
        [DataMember(Name = "wins", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wins")]
        public int? Wins { get; set; }

        /// <summary>
        /// Gets or Sets Losses
        /// </summary>
        [DataMember(Name = "losses", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "losses")]
        public int? Losses { get; set; }

        /// <summary>
        /// Gets or Sets Ties
        /// </summary>
        [DataMember(Name = "ties", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ties")]
        public int? Ties { get; set; }

        /// <summary>
        /// Gets or Sets GamesBack
        /// </summary>
        [DataMember(Name = "gamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamesBack")]
        public string GamesBack { get; set; }

        /// <summary>
        /// Gets or Sets WildCardGamesBack
        /// </summary>
        [DataMember(Name = "wildCardGamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wildCardGamesBack")]
        public string WildCardGamesBack { get; set; }

        /// <summary>
        /// Gets or Sets LeagueGamesBack
        /// </summary>
        [DataMember(Name = "leagueGamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leagueGamesBack")]
        public string LeagueGamesBack { get; set; }

        /// <summary>
        /// Gets or Sets SpringLeagueGamesBack
        /// </summary>
        [DataMember(Name = "springLeagueGamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "springLeagueGamesBack")]
        public string SpringLeagueGamesBack { get; set; }

        /// <summary>
        /// Gets or Sets SportGamesBack
        /// </summary>
        [DataMember(Name = "sportGamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sportGamesBack")]
        public string SportGamesBack { get; set; }

        /// <summary>
        /// Gets or Sets DivisionGamesBack
        /// </summary>
        [DataMember(Name = "divisionGamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "divisionGamesBack")]
        public string DivisionGamesBack { get; set; }

        /// <summary>
        /// Gets or Sets ConferenceGamesBack
        /// </summary>
        [DataMember(Name = "conferenceGamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "conferenceGamesBack")]
        public string ConferenceGamesBack { get; set; }

        /// <summary>
        /// Gets or Sets DivisionChamp
        /// </summary>
        [DataMember(Name = "divisionChamp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "divisionChamp")]
        public bool? DivisionChamp { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or Sets Streak
        /// </summary>
        [DataMember(Name = "streak", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "streak")]
        public string Streak { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastUpdated")]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets Home
        /// </summary>
        [DataMember(Name = "home", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "home")]
        public string Home { get; set; }

        /// <summary>
        /// Gets or Sets Away
        /// </summary>
        [DataMember(Name = "away", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "away")]
        public string Away { get; set; }

        /// <summary>
        /// Gets or Sets LastTen
        /// </summary>
        [DataMember(Name = "lastTen", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastTen")]
        public string LastTen { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name = "points", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "points")]
        public int? Points { get; set; }

        /// <summary>
        /// Gets or Sets ClinchIndicator
        /// </summary>
        [DataMember(Name = "clinchIndicator", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "clinchIndicator")]
        public string ClinchIndicator { get; set; }

        /// <summary>
        /// Gets or Sets DivisionRank
        /// </summary>
        [DataMember(Name = "divisionRank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "divisionRank")]
        public string DivisionRank { get; set; }

        /// <summary>
        /// Gets or Sets ConferenceRank
        /// </summary>
        [DataMember(Name = "conferenceRank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "conferenceRank")]
        public string ConferenceRank { get; set; }

        /// <summary>
        /// Gets or Sets SpringLeagueRank
        /// </summary>
        [DataMember(Name = "springLeagueRank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "springLeagueRank")]
        public string SpringLeagueRank { get; set; }

        /// <summary>
        /// Gets or Sets LeagueRank
        /// </summary>
        [DataMember(Name = "leagueRank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leagueRank")]
        public string LeagueRank { get; set; }

        /// <summary>
        /// Gets or Sets SportRank
        /// </summary>
        [DataMember(Name = "sportRank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sportRank")]
        public string SportRank { get; set; }

        /// <summary>
        /// Gets or Sets WildCardRank
        /// </summary>
        [DataMember(Name = "wildCardRank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wildCardRank")]
        public string WildCardRank { get; set; }

        /// <summary>
        /// Gets or Sets GamesPlayed
        /// </summary>
        [DataMember(Name = "gamesPlayed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamesPlayed")]
        public int? GamesPlayed { get; set; }

        /// <summary>
        /// Gets or Sets Place
        /// </summary>
        [DataMember(Name = "place", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "place")]
        public int? Place { get; set; }

        /// <summary>
        /// Gets or Sets WildcardPlace
        /// </summary>
        [DataMember(Name = "wildcardPlace", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wildcardPlace")]
        public int? WildcardPlace { get; set; }

        /// <summary>
        /// Gets or Sets WildcardOdds
        /// </summary>
        [DataMember(Name = "wildcardOdds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wildcardOdds")]
        public double? WildcardOdds { get; set; }

        /// <summary>
        /// Gets or Sets DivisionOdds
        /// </summary>
        [DataMember(Name = "divisionOdds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "divisionOdds")]
        public double? DivisionOdds { get; set; }

        /// <summary>
        /// Gets or Sets PlayoffOdds
        /// </summary>
        [DataMember(Name = "playoffOdds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playoffOdds")]
        public double? PlayoffOdds { get; set; }

        /// <summary>
        /// Gets or Sets RunsAllowed
        /// </summary>
        [DataMember(Name = "runsAllowed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runsAllowed")]
        public int? RunsAllowed { get; set; }

        /// <summary>
        /// Gets or Sets RunsScored
        /// </summary>
        [DataMember(Name = "runsScored", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runsScored")]
        public int? RunsScored { get; set; }

        /// <summary>
        /// Gets or Sets HasWildcard
        /// </summary>
        [DataMember(Name = "hasWildcard", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasWildcard")]
        public bool? HasWildcard { get; set; }

        /// <summary>
        /// Gets or Sets Clinched
        /// </summary>
        [DataMember(Name = "clinched", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "clinched")]
        public bool? Clinched { get; set; }

        /// <summary>
        /// Gets or Sets EliminationNumber
        /// </summary>
        [DataMember(Name = "eliminationNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eliminationNumber")]
        public string EliminationNumber { get; set; }

        /// <summary>
        /// Gets or Sets EliminationNumberSport
        /// </summary>
        [DataMember(Name = "eliminationNumberSport", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eliminationNumberSport")]
        public string EliminationNumberSport { get; set; }

        /// <summary>
        /// Gets or Sets EliminationNumberLeague
        /// </summary>
        [DataMember(Name = "eliminationNumberLeague", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eliminationNumberLeague")]
        public string EliminationNumberLeague { get; set; }

        /// <summary>
        /// Gets or Sets EliminationNumberDivision
        /// </summary>
        [DataMember(Name = "eliminationNumberDivision", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eliminationNumberDivision")]
        public string EliminationNumberDivision { get; set; }

        /// <summary>
        /// Gets or Sets EliminationNumberConference
        /// </summary>
        [DataMember(Name = "eliminationNumberConference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eliminationNumberConference")]
        public string EliminationNumberConference { get; set; }

        /// <summary>
        /// Gets or Sets EliminationNumberWildcard
        /// </summary>
        [DataMember(Name = "eliminationNumberWildcard", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eliminationNumberWildcard")]
        public string EliminationNumberWildcard { get; set; }

        /// <summary>
        /// Gets or Sets MagicNumber
        /// </summary>
        [DataMember(Name = "magicNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "magicNumber")]
        public string MagicNumber { get; set; }

        /// <summary>
        /// Gets or Sets HasPlayoffPoints
        /// </summary>
        [DataMember(Name = "hasPlayoffPoints", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasPlayoffPoints")]
        public bool? HasPlayoffPoints { get; set; }

        /// <summary>
        /// Gets or Sets VsWest
        /// </summary>
        [DataMember(Name = "vsWest", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vsWest")]
        public string VsWest { get; set; }

        /// <summary>
        /// Gets or Sets VsCentral
        /// </summary>
        [DataMember(Name = "vsCentral", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vsCentral")]
        public string VsCentral { get; set; }

        /// <summary>
        /// Gets or Sets VsEast
        /// </summary>
        [DataMember(Name = "vsEast", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vsEast")]
        public string VsEast { get; set; }

        /// <summary>
        /// Gets or Sets VsInterleague
        /// </summary>
        [DataMember(Name = "vsInterleague", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vsInterleague")]
        public string VsInterleague { get; set; }

        /// <summary>
        /// Gets or Sets VsRight
        /// </summary>
        [DataMember(Name = "vsRight", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vsRight")]
        public string VsRight { get; set; }

        /// <summary>
        /// Gets or Sets VsRightHomeWin
        /// </summary>
        [DataMember(Name = "vsRightHomeWin", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vsRightHomeWin")]
        public string VsRightHomeWin { get; set; }

        /// <summary>
        /// Gets or Sets VsRightHomeLoss
        /// </summary>
        [DataMember(Name = "vsRightHomeLoss", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vsRightHomeLoss")]
        public string VsRightHomeLoss { get; set; }

        /// <summary>
        /// Gets or Sets VsRightAwayWin
        /// </summary>
        [DataMember(Name = "vsRightAwayWin", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vsRightAwayWin")]
        public string VsRightAwayWin { get; set; }

        /// <summary>
        /// Gets or Sets VsRightAwayLoss
        /// </summary>
        [DataMember(Name = "vsRightAwayLoss", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vsRightAwayLoss")]
        public string VsRightAwayLoss { get; set; }

        /// <summary>
        /// Gets or Sets VsLeft
        /// </summary>
        [DataMember(Name = "vsLeft", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vsLeft")]
        public string VsLeft { get; set; }

        /// <summary>
        /// Gets or Sets VsLeftHomeWin
        /// </summary>
        [DataMember(Name = "vsLeftHomeWin", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vsLeftHomeWin")]
        public string VsLeftHomeWin { get; set; }

        /// <summary>
        /// Gets or Sets VsLeftHomeLoss
        /// </summary>
        [DataMember(Name = "vsLeftHomeLoss", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vsLeftHomeLoss")]
        public string VsLeftHomeLoss { get; set; }

        /// <summary>
        /// Gets or Sets VsLeftAwayWin
        /// </summary>
        [DataMember(Name = "vsLeftAwayWin", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vsLeftAwayWin")]
        public string VsLeftAwayWin { get; set; }

        /// <summary>
        /// Gets or Sets VsLeftAwayLoss
        /// </summary>
        [DataMember(Name = "vsLeftAwayLoss", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vsLeftAwayLoss")]
        public string VsLeftAwayLoss { get; set; }

        /// <summary>
        /// Gets or Sets VsWinners
        /// </summary>
        [DataMember(Name = "vsWinners", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vsWinners")]
        public string VsWinners { get; set; }

        /// <summary>
        /// Gets or Sets ExtraInnings
        /// </summary>
        [DataMember(Name = "extraInnings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "extraInnings")]
        public string ExtraInnings { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedWinLoss
        /// </summary>
        [DataMember(Name = "expectedWinLoss", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expectedWinLoss")]
        public string ExpectedWinLoss { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedWinLossSeason
        /// </summary>
        [DataMember(Name = "expectedWinLossSeason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expectedWinLossSeason")]
        public string ExpectedWinLossSeason { get; set; }

        /// <summary>
        /// Gets or Sets OneRunGames
        /// </summary>
        [DataMember(Name = "oneRunGames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "oneRunGames")]
        public string OneRunGames { get; set; }

        /// <summary>
        /// Gets or Sets Turf
        /// </summary>
        [DataMember(Name = "turf", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "turf")]
        public string Turf { get; set; }

        /// <summary>
        /// Gets or Sets Grass
        /// </summary>
        [DataMember(Name = "grass", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "grass")]
        public string Grass { get; set; }

        /// <summary>
        /// Gets or Sets Night
        /// </summary>
        [DataMember(Name = "night", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "night")]
        public string Night { get; set; }

        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name = "day", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "day")]
        public string Day { get; set; }

        /// <summary>
        /// Gets or Sets IsWildCardTeam
        /// </summary>
        [DataMember(Name = "isWildCardTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isWildCardTeam")]
        public bool? IsWildCardTeam { get; set; }

        /// <summary>
        /// Gets or Sets IsDivisionLeader
        /// </summary>
        [DataMember(Name = "isDivisionLeader", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isDivisionLeader")]
        public bool? IsDivisionLeader { get; set; }

        /// <summary>
        /// Gets or Sets DivisionRecords
        /// </summary>
        [DataMember(Name = "divisionRecords", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "divisionRecords")]
        public List<WinLossRecord> DivisionRecords { get; set; }

        /// <summary>
        /// Gets or Sets ConferenceRecords
        /// </summary>
        [DataMember(Name = "conferenceRecords", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "conferenceRecords")]
        public List<WinLossRecord> ConferenceRecords { get; set; }

        /// <summary>
        /// Gets or Sets LeagueRecords
        /// </summary>
        [DataMember(Name = "leagueRecords", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leagueRecords")]
        public List<WinLossRecord> LeagueRecords { get; set; }

        /// <summary>
        /// Gets or Sets SplitRecords
        /// </summary>
        [DataMember(Name = "splitRecords", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "splitRecords")]
        public List<WinLossRecord> SplitRecords { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedRecords
        /// </summary>
        [DataMember(Name = "expectedRecords", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expectedRecords")]
        public List<WinLossRecord> ExpectedRecords { get; set; }

        /// <summary>
        /// Gets or Sets OverallRecords
        /// </summary>
        [DataMember(Name = "overallRecords", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "overallRecords")]
        public List<WinLossRecord> OverallRecords { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [DataMember(Name = "conference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "conference")]
        public Conference Conference { get; set; }

        /// <summary>
        /// Gets or Sets RunDifferental
        /// </summary>
        [DataMember(Name = "runDifferental", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runDifferental")]
        public int? RunDifferental { get; set; }

        /// <summary>
        /// Gets or Sets WildCardLeader
        /// </summary>
        [DataMember(Name = "wildCardLeader", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wildCardLeader")]
        public bool? WildCardLeader { get; set; }

        /// <summary>
        /// Gets or Sets WinningPercentage
        /// </summary>
        [DataMember(Name = "winningPercentage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "winningPercentage")]
        public double? WinningPercentage { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballTeamStandingsRecord {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Wins: ").Append(Wins).Append("\n");
            sb.Append("  Losses: ").Append(Losses).Append("\n");
            sb.Append("  Ties: ").Append(Ties).Append("\n");
            sb.Append("  GamesBack: ").Append(GamesBack).Append("\n");
            sb.Append("  WildCardGamesBack: ").Append(WildCardGamesBack).Append("\n");
            sb.Append("  LeagueGamesBack: ").Append(LeagueGamesBack).Append("\n");
            sb.Append("  SpringLeagueGamesBack: ").Append(SpringLeagueGamesBack).Append("\n");
            sb.Append("  SportGamesBack: ").Append(SportGamesBack).Append("\n");
            sb.Append("  DivisionGamesBack: ").Append(DivisionGamesBack).Append("\n");
            sb.Append("  ConferenceGamesBack: ").Append(ConferenceGamesBack).Append("\n");
            sb.Append("  DivisionChamp: ").Append(DivisionChamp).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Streak: ").Append(Streak).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Home: ").Append(Home).Append("\n");
            sb.Append("  Away: ").Append(Away).Append("\n");
            sb.Append("  LastTen: ").Append(LastTen).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  ClinchIndicator: ").Append(ClinchIndicator).Append("\n");
            sb.Append("  DivisionRank: ").Append(DivisionRank).Append("\n");
            sb.Append("  ConferenceRank: ").Append(ConferenceRank).Append("\n");
            sb.Append("  SpringLeagueRank: ").Append(SpringLeagueRank).Append("\n");
            sb.Append("  LeagueRank: ").Append(LeagueRank).Append("\n");
            sb.Append("  SportRank: ").Append(SportRank).Append("\n");
            sb.Append("  WildCardRank: ").Append(WildCardRank).Append("\n");
            sb.Append("  GamesPlayed: ").Append(GamesPlayed).Append("\n");
            sb.Append("  Place: ").Append(Place).Append("\n");
            sb.Append("  WildcardPlace: ").Append(WildcardPlace).Append("\n");
            sb.Append("  WildcardOdds: ").Append(WildcardOdds).Append("\n");
            sb.Append("  DivisionOdds: ").Append(DivisionOdds).Append("\n");
            sb.Append("  PlayoffOdds: ").Append(PlayoffOdds).Append("\n");
            sb.Append("  RunsAllowed: ").Append(RunsAllowed).Append("\n");
            sb.Append("  RunsScored: ").Append(RunsScored).Append("\n");
            sb.Append("  HasWildcard: ").Append(HasWildcard).Append("\n");
            sb.Append("  Clinched: ").Append(Clinched).Append("\n");
            sb.Append("  EliminationNumber: ").Append(EliminationNumber).Append("\n");
            sb.Append("  EliminationNumberSport: ").Append(EliminationNumberSport).Append("\n");
            sb.Append("  EliminationNumberLeague: ").Append(EliminationNumberLeague).Append("\n");
            sb.Append("  EliminationNumberDivision: ").Append(EliminationNumberDivision).Append("\n");
            sb.Append("  EliminationNumberConference: ").Append(EliminationNumberConference).Append("\n");
            sb.Append("  EliminationNumberWildcard: ").Append(EliminationNumberWildcard).Append("\n");
            sb.Append("  MagicNumber: ").Append(MagicNumber).Append("\n");
            sb.Append("  HasPlayoffPoints: ").Append(HasPlayoffPoints).Append("\n");
            sb.Append("  VsWest: ").Append(VsWest).Append("\n");
            sb.Append("  VsCentral: ").Append(VsCentral).Append("\n");
            sb.Append("  VsEast: ").Append(VsEast).Append("\n");
            sb.Append("  VsInterleague: ").Append(VsInterleague).Append("\n");
            sb.Append("  VsRight: ").Append(VsRight).Append("\n");
            sb.Append("  VsRightHomeWin: ").Append(VsRightHomeWin).Append("\n");
            sb.Append("  VsRightHomeLoss: ").Append(VsRightHomeLoss).Append("\n");
            sb.Append("  VsRightAwayWin: ").Append(VsRightAwayWin).Append("\n");
            sb.Append("  VsRightAwayLoss: ").Append(VsRightAwayLoss).Append("\n");
            sb.Append("  VsLeft: ").Append(VsLeft).Append("\n");
            sb.Append("  VsLeftHomeWin: ").Append(VsLeftHomeWin).Append("\n");
            sb.Append("  VsLeftHomeLoss: ").Append(VsLeftHomeLoss).Append("\n");
            sb.Append("  VsLeftAwayWin: ").Append(VsLeftAwayWin).Append("\n");
            sb.Append("  VsLeftAwayLoss: ").Append(VsLeftAwayLoss).Append("\n");
            sb.Append("  VsWinners: ").Append(VsWinners).Append("\n");
            sb.Append("  ExtraInnings: ").Append(ExtraInnings).Append("\n");
            sb.Append("  ExpectedWinLoss: ").Append(ExpectedWinLoss).Append("\n");
            sb.Append("  ExpectedWinLossSeason: ").Append(ExpectedWinLossSeason).Append("\n");
            sb.Append("  OneRunGames: ").Append(OneRunGames).Append("\n");
            sb.Append("  Turf: ").Append(Turf).Append("\n");
            sb.Append("  Grass: ").Append(Grass).Append("\n");
            sb.Append("  Night: ").Append(Night).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  IsWildCardTeam: ").Append(IsWildCardTeam).Append("\n");
            sb.Append("  IsDivisionLeader: ").Append(IsDivisionLeader).Append("\n");
            sb.Append("  DivisionRecords: ").Append(DivisionRecords).Append("\n");
            sb.Append("  ConferenceRecords: ").Append(ConferenceRecords).Append("\n");
            sb.Append("  LeagueRecords: ").Append(LeagueRecords).Append("\n");
            sb.Append("  SplitRecords: ").Append(SplitRecords).Append("\n");
            sb.Append("  ExpectedRecords: ").Append(ExpectedRecords).Append("\n");
            sb.Append("  OverallRecords: ").Append(OverallRecords).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  RunDifferental: ").Append(RunDifferental).Append("\n");
            sb.Append("  WildCardLeader: ").Append(WildCardLeader).Append("\n");
            sb.Append("  WinningPercentage: ").Append(WinningPercentage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}