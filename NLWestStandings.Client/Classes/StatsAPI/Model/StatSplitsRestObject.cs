using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class StatSplitsRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

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
        public StatDataRestObject Stat { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name = "stats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stats")]
        public GroupedStatDataRestObject Stats { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeamRestObject Team { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "player")]
        public BaseballPersonRestObject Player { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeam
        /// </summary>
        [DataMember(Name = "homeTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeTeam")]
        public BaseballTeamRestObject HomeTeam { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeam
        /// </summary>
        [DataMember(Name = "awayTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayTeam")]
        public BaseballTeamRestObject AwayTeam { get; set; }

        /// <summary>
        /// Gets or Sets Venue
        /// </summary>
        [DataMember(Name = "venue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "venue")]
        public VenueRestObject Venue { get; set; }

        /// <summary>
        /// Gets or Sets League
        /// </summary>
        [DataMember(Name = "league", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "league")]
        public LeagueRestObject League { get; set; }

        /// <summary>
        /// Gets or Sets Sport
        /// </summary>
        [DataMember(Name = "sport", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sport")]
        public SportRestObject Sport { get; set; }

        /// <summary>
        /// Gets or Sets Opponent
        /// </summary>
        [DataMember(Name = "opponent", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "opponent")]
        public BaseballTeamRestObject Opponent { get; set; }

        /// <summary>
        /// Gets or Sets OpponentDivision
        /// </summary>
        [DataMember(Name = "opponentDivision", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "opponentDivision")]
        public DivisionRestObject OpponentDivision { get; set; }

        /// <summary>
        /// Gets or Sets OpponentConference
        /// </summary>
        [DataMember(Name = "opponentConference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "opponentConference")]
        public ConferenceRestObject OpponentConference { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets GameType
        /// </summary>
        [DataMember(Name = "gameType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameType")]
        public string GameType { get; set; }

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
        /// Gets or Sets DayOfWeek
        /// </summary>
        [DataMember(Name = "dayOfWeek", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dayOfWeek")]
        public int? DayOfWeek { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name = "month", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "month")]
        public int? Month { get; set; }

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
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// Gets or Sets Split
        /// </summary>
        [DataMember(Name = "split", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "split")]
        public DynamicEnumRestObject Split { get; set; }

        /// <summary>
        /// Gets or Sets Exemption
        /// </summary>
        [DataMember(Name = "exemption", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "exemption")]
        public StatExemptionRestObject Exemption { get; set; }

        /// <summary>
        /// Gets or Sets NumLeagues
        /// </summary>
        [DataMember(Name = "numLeagues", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numLeagues")]
        public int? NumLeagues { get; set; }

        /// <summary>
        /// Gets or Sets Game
        /// </summary>
        [DataMember(Name = "game", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "game")]
        public BaseballScheduleItemRestObject Game { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatSplitsRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Stat: ").Append(Stat).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  Venue: ").Append(Venue).Append("\n");
            sb.Append("  League: ").Append(League).Append("\n");
            sb.Append("  Sport: ").Append(Sport).Append("\n");
            sb.Append("  Opponent: ").Append(Opponent).Append("\n");
            sb.Append("  OpponentDivision: ").Append(OpponentDivision).Append("\n");
            sb.Append("  OpponentConference: ").Append(OpponentConference).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  GameType: ").Append(GameType).Append("\n");
            sb.Append("  IsHome: ").Append(IsHome).Append("\n");
            sb.Append("  IsWin: ").Append(IsWin).Append("\n");
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  NumTeams: ").Append(NumTeams).Append("\n");
            sb.Append("  NumOccurrences: ").Append(NumOccurrences).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Split: ").Append(Split).Append("\n");
            sb.Append("  Exemption: ").Append(Exemption).Append("\n");
            sb.Append("  NumLeagues: ").Append(NumLeagues).Append("\n");
            sb.Append("  Game: ").Append(Game).Append("\n");
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