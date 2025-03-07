using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class StatSplits
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or Sets Stat
        /// </summary>
        [DataMember(Name = "stat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stat")]
        public StatData Stat { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name = "stats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stats")]
        public GroupedStatData Stats { get; set; }

        /// <summary>
        /// Gets or Sets GameType
        /// </summary>
        [DataMember(Name = "gameType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameType")]
        public GameTypeEnum GameType { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeam Team { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "player")]
        public BaseballPerson Player { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeam
        /// </summary>
        [DataMember(Name = "homeTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeTeam")]
        public BaseballTeam HomeTeam { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeam
        /// </summary>
        [DataMember(Name = "awayTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayTeam")]
        public BaseballTeam AwayTeam { get; set; }

        /// <summary>
        /// Gets or Sets NumTeams
        /// </summary>
        [DataMember(Name = "numTeams", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numTeams")]
        public int? NumTeams { get; set; }

        /// <summary>
        /// Gets or Sets NumOccurrences
        /// </summary>
        [DataMember(Name = "numOccurrences", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numOccurrences")]
        public int? NumOccurrences { get; set; }

        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// Gets or Sets League
        /// </summary>
        [DataMember(Name = "league", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "league")]
        public League League { get; set; }

        /// <summary>
        /// Gets or Sets Sport
        /// </summary>
        [DataMember(Name = "sport", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sport")]
        public Sport Sport { get; set; }

        /// <summary>
        /// Gets or Sets Opponent
        /// </summary>
        [DataMember(Name = "opponent", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "opponent")]
        public BaseballTeam Opponent { get; set; }

        /// <summary>
        /// Gets or Sets Venue
        /// </summary>
        [DataMember(Name = "venue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "venue")]
        public Venue Venue { get; set; }

        /// <summary>
        /// Gets or Sets Game
        /// </summary>
        [DataMember(Name = "game", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "game")]
        public BaseballScheduleItem Game { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets LastDatePlayed
        /// </summary>
        [DataMember(Name = "lastDatePlayed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastDatePlayed")]
        public DateTime? LastDatePlayed { get; set; }

        /// <summary>
        /// Gets or Sets GameNumber
        /// </summary>
        [DataMember(Name = "gameNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameNumber")]
        public int? GameNumber { get; set; }

        /// <summary>
        /// Gets or Sets Split
        /// </summary>
        [DataMember(Name = "split", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "split")]
        public DynamicLookupEnum Split { get; set; }

        /// <summary>
        /// Gets or Sets GamePk
        /// </summary>
        [DataMember(Name = "gamePk", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamePk")]
        public int? GamePk { get; set; }

        /// <summary>
        /// Gets or Sets DayOfTheWeek
        /// </summary>
        [DataMember(Name = "dayOfTheWeek", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dayOfTheWeek")]
        public int? DayOfTheWeek { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name = "month", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "month")]
        public int? Month { get; set; }

        /// <summary>
        /// Gets or Sets OpposingDivision
        /// </summary>
        [DataMember(Name = "opposingDivision", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "opposingDivision")]
        public Division OpposingDivision { get; set; }

        /// <summary>
        /// Gets or Sets OpposingConference
        /// </summary>
        [DataMember(Name = "opposingConference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "opposingConference")]
        public Conference OpposingConference { get; set; }

        /// <summary>
        /// Gets or Sets IsHome
        /// </summary>
        [DataMember(Name = "isHome", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isHome")]
        public bool? IsHome { get; set; }

        /// <summary>
        /// Gets or Sets IsWin
        /// </summary>
        [DataMember(Name = "isWin", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isWin")]
        public bool? IsWin { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public StatType Type { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "group")]
        public StatGroup Group { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "position")]
        public BaseballPosition Position { get; set; }

        /// <summary>
        /// Gets or Sets GameInnings
        /// </summary>
        [DataMember(Name = "gameInnings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameInnings")]
        public int? GameInnings { get; set; }

        /// <summary>
        /// Gets or Sets Exemption
        /// </summary>
        [DataMember(Name = "exemption", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "exemption")]
        public PlayerListPerson Exemption { get; set; }

        /// <summary>
        /// Gets or Sets NumLeagues
        /// </summary>
        [DataMember(Name = "numLeagues", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numLeagues")]
        public int? NumLeagues { get; set; }

        /// <summary>
        /// Gets or Sets UserPrivileges
        /// </summary>
        [DataMember(Name = "userPrivileges", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "userPrivileges")]
        public List<Privilege> UserPrivileges { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatSplits {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Stat: ").Append(Stat).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  GameType: ").Append(GameType).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  NumTeams: ").Append(NumTeams).Append("\n");
            sb.Append("  NumOccurrences: ").Append(NumOccurrences).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  League: ").Append(League).Append("\n");
            sb.Append("  Sport: ").Append(Sport).Append("\n");
            sb.Append("  Opponent: ").Append(Opponent).Append("\n");
            sb.Append("  Venue: ").Append(Venue).Append("\n");
            sb.Append("  Game: ").Append(Game).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  LastDatePlayed: ").Append(LastDatePlayed).Append("\n");
            sb.Append("  GameNumber: ").Append(GameNumber).Append("\n");
            sb.Append("  Split: ").Append(Split).Append("\n");
            sb.Append("  GamePk: ").Append(GamePk).Append("\n");
            sb.Append("  DayOfTheWeek: ").Append(DayOfTheWeek).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  OpposingDivision: ").Append(OpposingDivision).Append("\n");
            sb.Append("  OpposingConference: ").Append(OpposingConference).Append("\n");
            sb.Append("  IsHome: ").Append(IsHome).Append("\n");
            sb.Append("  IsWin: ").Append(IsWin).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  GameInnings: ").Append(GameInnings).Append("\n");
            sb.Append("  Exemption: ").Append(Exemption).Append("\n");
            sb.Append("  NumLeagues: ").Append(NumLeagues).Append("\n");
            sb.Append("  UserPrivileges: ").Append(UserPrivileges).Append("\n");
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