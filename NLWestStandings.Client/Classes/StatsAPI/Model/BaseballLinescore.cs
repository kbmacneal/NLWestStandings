using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballLinescore
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets AwayScore
        /// </summary>
        [DataMember(Name = "awayScore", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayScore")]
        public int? AwayScore { get; set; }

        /// <summary>
        /// Gets or Sets HomeScore
        /// </summary>
        [DataMember(Name = "homeScore", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeScore")]
        public int? HomeScore { get; set; }

        /// <summary>
        /// Gets or Sets GameStatus
        /// </summary>
        [DataMember(Name = "gameStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameStatus")]
        public IGameStatus GameStatus { get; set; }

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
        /// Gets or Sets GamePk
        /// </summary>
        [DataMember(Name = "gamePk", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamePk")]
        public int? GamePk { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledInnings
        /// </summary>
        [DataMember(Name = "scheduledInnings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scheduledInnings")]
        public int? ScheduledInnings { get; set; }

        /// <summary>
        /// Gets or Sets CurrentInning
        /// </summary>
        [DataMember(Name = "currentInning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentInning")]
        public int? CurrentInning { get; set; }

        /// <summary>
        /// Gets or Sets CurrentInningOrdinal
        /// </summary>
        [DataMember(Name = "currentInningOrdinal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentInningOrdinal")]
        public string CurrentInningOrdinal { get; set; }

        /// <summary>
        /// Gets or Sets InningState
        /// </summary>
        [DataMember(Name = "inningState", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inningState")]
        public string InningState { get; set; }

        /// <summary>
        /// Gets or Sets InningHalf
        /// </summary>
        [DataMember(Name = "inningHalf", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inningHalf")]
        public string InningHalf { get; set; }

        /// <summary>
        /// Gets or Sets IsTopInning
        /// </summary>
        [DataMember(Name = "isTopInning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isTopInning")]
        public bool? IsTopInning { get; set; }

        /// <summary>
        /// Gets or Sets Innings
        /// </summary>
        [DataMember(Name = "innings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "innings")]
        public List<BaseballInning> Innings { get; set; }

        /// <summary>
        /// Gets or Sets RunsAway
        /// </summary>
        [DataMember(Name = "runsAway", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runsAway")]
        public int? RunsAway { get; set; }

        /// <summary>
        /// Gets or Sets RunsHome
        /// </summary>
        [DataMember(Name = "runsHome", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runsHome")]
        public int? RunsHome { get; set; }

        /// <summary>
        /// Gets or Sets AwayHits
        /// </summary>
        [DataMember(Name = "awayHits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayHits")]
        public int? AwayHits { get; set; }

        /// <summary>
        /// Gets or Sets HomeHits
        /// </summary>
        [DataMember(Name = "homeHits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeHits")]
        public int? HomeHits { get; set; }

        /// <summary>
        /// Gets or Sets AwayErrors
        /// </summary>
        [DataMember(Name = "awayErrors", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayErrors")]
        public int? AwayErrors { get; set; }

        /// <summary>
        /// Gets or Sets HomeErrors
        /// </summary>
        [DataMember(Name = "homeErrors", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeErrors")]
        public int? HomeErrors { get; set; }

        /// <summary>
        /// Gets or Sets AwayLeftOnBase
        /// </summary>
        [DataMember(Name = "awayLeftOnBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayLeftOnBase")]
        public int? AwayLeftOnBase { get; set; }

        /// <summary>
        /// Gets or Sets HomeLeftOnBase
        /// </summary>
        [DataMember(Name = "homeLeftOnBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeLeftOnBase")]
        public int? HomeLeftOnBase { get; set; }

        /// <summary>
        /// Gets or Sets AwayIsWinner
        /// </summary>
        [DataMember(Name = "awayIsWinner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayIsWinner")]
        public bool? AwayIsWinner { get; set; }

        /// <summary>
        /// Gets or Sets HomeIsWinner
        /// </summary>
        [DataMember(Name = "homeIsWinner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeIsWinner")]
        public bool? HomeIsWinner { get; set; }

        /// <summary>
        /// Gets or Sets Balls
        /// </summary>
        [DataMember(Name = "balls", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "balls")]
        public int? Balls { get; set; }

        /// <summary>
        /// Gets or Sets Strikes
        /// </summary>
        [DataMember(Name = "strikes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikes")]
        public int? Strikes { get; set; }

        /// <summary>
        /// Gets or Sets Outs
        /// </summary>
        [DataMember(Name = "outs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outs")]
        public int? Outs { get; set; }

        /// <summary>
        /// Gets or Sets BatTeam
        /// </summary>
        [DataMember(Name = "batTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batTeam")]
        public BaseballTeam BatTeam { get; set; }

        /// <summary>
        /// Gets or Sets BatTeamsLastPitcher
        /// </summary>
        [DataMember(Name = "batTeamsLastPitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batTeamsLastPitcher")]
        public BaseballPerson BatTeamsLastPitcher { get; set; }

        /// <summary>
        /// Gets or Sets BatterPosition
        /// </summary>
        [DataMember(Name = "batterPosition", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batterPosition")]
        public BaseballPosition BatterPosition { get; set; }

        /// <summary>
        /// Gets or Sets Batter
        /// </summary>
        [DataMember(Name = "batter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batter")]
        public BaseballPerson Batter { get; set; }

        /// <summary>
        /// Gets or Sets OnDeck
        /// </summary>
        [DataMember(Name = "onDeck", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "onDeck")]
        public BaseballPerson OnDeck { get; set; }

        /// <summary>
        /// Gets or Sets InHole
        /// </summary>
        [DataMember(Name = "inHole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inHole")]
        public BaseballPerson InHole { get; set; }

        /// <summary>
        /// Gets or Sets BattingOrder
        /// </summary>
        [DataMember(Name = "battingOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "battingOrder")]
        public int? BattingOrder { get; set; }

        /// <summary>
        /// Gets or Sets OnFirst
        /// </summary>
        [DataMember(Name = "onFirst", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "onFirst")]
        public BaseballPerson OnFirst { get; set; }

        /// <summary>
        /// Gets or Sets OnSecond
        /// </summary>
        [DataMember(Name = "onSecond", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "onSecond")]
        public BaseballPerson OnSecond { get; set; }

        /// <summary>
        /// Gets or Sets OnThird
        /// </summary>
        [DataMember(Name = "onThird", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "onThird")]
        public BaseballPerson OnThird { get; set; }

        /// <summary>
        /// Gets or Sets PostOnFirst
        /// </summary>
        [DataMember(Name = "postOnFirst", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postOnFirst")]
        public BaseballPerson PostOnFirst { get; set; }

        /// <summary>
        /// Gets or Sets PostOnSecond
        /// </summary>
        [DataMember(Name = "postOnSecond", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postOnSecond")]
        public BaseballPerson PostOnSecond { get; set; }

        /// <summary>
        /// Gets or Sets PostOnThird
        /// </summary>
        [DataMember(Name = "postOnThird", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postOnThird")]
        public BaseballPerson PostOnThird { get; set; }

        /// <summary>
        /// Gets or Sets FieldTeam
        /// </summary>
        [DataMember(Name = "fieldTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fieldTeam")]
        public BaseballTeam FieldTeam { get; set; }

        /// <summary>
        /// Gets or Sets Pitcher
        /// </summary>
        [DataMember(Name = "pitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitcher")]
        public BaseballPerson Pitcher { get; set; }

        /// <summary>
        /// Gets or Sets Catcher
        /// </summary>
        [DataMember(Name = "catcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "catcher")]
        public BaseballPerson Catcher { get; set; }

        /// <summary>
        /// Gets or Sets FirstBase
        /// </summary>
        [DataMember(Name = "firstBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstBase")]
        public BaseballPerson FirstBase { get; set; }

        /// <summary>
        /// Gets or Sets SecondBase
        /// </summary>
        [DataMember(Name = "secondBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "secondBase")]
        public BaseballPerson SecondBase { get; set; }

        /// <summary>
        /// Gets or Sets ThirdBase
        /// </summary>
        [DataMember(Name = "thirdBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "thirdBase")]
        public BaseballPerson ThirdBase { get; set; }

        /// <summary>
        /// Gets or Sets Shortstop
        /// </summary>
        [DataMember(Name = "shortstop", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shortstop")]
        public BaseballPerson Shortstop { get; set; }

        /// <summary>
        /// Gets or Sets LeftField
        /// </summary>
        [DataMember(Name = "leftField", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leftField")]
        public BaseballPerson LeftField { get; set; }

        /// <summary>
        /// Gets or Sets CenterField
        /// </summary>
        [DataMember(Name = "centerField", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "centerField")]
        public BaseballPerson CenterField { get; set; }

        /// <summary>
        /// Gets or Sets RightField
        /// </summary>
        [DataMember(Name = "rightField", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rightField")]
        public BaseballPerson RightField { get; set; }

        /// <summary>
        /// Gets or Sets FieldTeamsDueUpBatter
        /// </summary>
        [DataMember(Name = "fieldTeamsDueUpBatter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fieldTeamsDueUpBatter")]
        public BaseballPerson FieldTeamsDueUpBatter { get; set; }

        /// <summary>
        /// Gets or Sets FieldTeamsDueUpOnDeck
        /// </summary>
        [DataMember(Name = "fieldTeamsDueUpOnDeck", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fieldTeamsDueUpOnDeck")]
        public BaseballPerson FieldTeamsDueUpOnDeck { get; set; }

        /// <summary>
        /// Gets or Sets FieldTeamsDueUpInHole
        /// </summary>
        [DataMember(Name = "fieldTeamsDueUpInHole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fieldTeamsDueUpInHole")]
        public BaseballPerson FieldTeamsDueUpInHole { get; set; }

        /// <summary>
        /// Gets or Sets FieldTeamsBattingOrder
        /// </summary>
        [DataMember(Name = "fieldTeamsBattingOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fieldTeamsBattingOrder")]
        public int? FieldTeamsBattingOrder { get; set; }

        /// <summary>
        /// Gets or Sets PlayersNotInField
        /// </summary>
        [DataMember(Name = "playersNotInField", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playersNotInField")]
        public Dictionary<string, BaseballPosition> PlayersNotInField { get; set; }

        /// <summary>
        /// Gets or Sets Tie
        /// </summary>
        [DataMember(Name = "tie", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tie")]
        public bool? Tie { get; set; }

        /// <summary>
        /// Gets or Sets TopInning
        /// </summary>
        [DataMember(Name = "topInning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "topInning")]
        public bool? TopInning { get; set; }

        /// <summary>
        /// Gets or Sets HydratedStats
        /// </summary>
        [DataMember(Name = "hydratedStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedStats")]
        public Dictionary<string, Object> HydratedStats { get; set; }

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
            sb.Append("class BaseballLinescore {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  AwayScore: ").Append(AwayScore).Append("\n");
            sb.Append("  HomeScore: ").Append(HomeScore).Append("\n");
            sb.Append("  GameStatus: ").Append(GameStatus).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  GamePk: ").Append(GamePk).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  ScheduledInnings: ").Append(ScheduledInnings).Append("\n");
            sb.Append("  CurrentInning: ").Append(CurrentInning).Append("\n");
            sb.Append("  CurrentInningOrdinal: ").Append(CurrentInningOrdinal).Append("\n");
            sb.Append("  InningState: ").Append(InningState).Append("\n");
            sb.Append("  InningHalf: ").Append(InningHalf).Append("\n");
            sb.Append("  IsTopInning: ").Append(IsTopInning).Append("\n");
            sb.Append("  Innings: ").Append(Innings).Append("\n");
            sb.Append("  RunsAway: ").Append(RunsAway).Append("\n");
            sb.Append("  RunsHome: ").Append(RunsHome).Append("\n");
            sb.Append("  AwayHits: ").Append(AwayHits).Append("\n");
            sb.Append("  HomeHits: ").Append(HomeHits).Append("\n");
            sb.Append("  AwayErrors: ").Append(AwayErrors).Append("\n");
            sb.Append("  HomeErrors: ").Append(HomeErrors).Append("\n");
            sb.Append("  AwayLeftOnBase: ").Append(AwayLeftOnBase).Append("\n");
            sb.Append("  HomeLeftOnBase: ").Append(HomeLeftOnBase).Append("\n");
            sb.Append("  AwayIsWinner: ").Append(AwayIsWinner).Append("\n");
            sb.Append("  HomeIsWinner: ").Append(HomeIsWinner).Append("\n");
            sb.Append("  Balls: ").Append(Balls).Append("\n");
            sb.Append("  Strikes: ").Append(Strikes).Append("\n");
            sb.Append("  Outs: ").Append(Outs).Append("\n");
            sb.Append("  BatTeam: ").Append(BatTeam).Append("\n");
            sb.Append("  BatTeamsLastPitcher: ").Append(BatTeamsLastPitcher).Append("\n");
            sb.Append("  BatterPosition: ").Append(BatterPosition).Append("\n");
            sb.Append("  Batter: ").Append(Batter).Append("\n");
            sb.Append("  OnDeck: ").Append(OnDeck).Append("\n");
            sb.Append("  InHole: ").Append(InHole).Append("\n");
            sb.Append("  BattingOrder: ").Append(BattingOrder).Append("\n");
            sb.Append("  OnFirst: ").Append(OnFirst).Append("\n");
            sb.Append("  OnSecond: ").Append(OnSecond).Append("\n");
            sb.Append("  OnThird: ").Append(OnThird).Append("\n");
            sb.Append("  PostOnFirst: ").Append(PostOnFirst).Append("\n");
            sb.Append("  PostOnSecond: ").Append(PostOnSecond).Append("\n");
            sb.Append("  PostOnThird: ").Append(PostOnThird).Append("\n");
            sb.Append("  FieldTeam: ").Append(FieldTeam).Append("\n");
            sb.Append("  Pitcher: ").Append(Pitcher).Append("\n");
            sb.Append("  Catcher: ").Append(Catcher).Append("\n");
            sb.Append("  FirstBase: ").Append(FirstBase).Append("\n");
            sb.Append("  SecondBase: ").Append(SecondBase).Append("\n");
            sb.Append("  ThirdBase: ").Append(ThirdBase).Append("\n");
            sb.Append("  Shortstop: ").Append(Shortstop).Append("\n");
            sb.Append("  LeftField: ").Append(LeftField).Append("\n");
            sb.Append("  CenterField: ").Append(CenterField).Append("\n");
            sb.Append("  RightField: ").Append(RightField).Append("\n");
            sb.Append("  FieldTeamsDueUpBatter: ").Append(FieldTeamsDueUpBatter).Append("\n");
            sb.Append("  FieldTeamsDueUpOnDeck: ").Append(FieldTeamsDueUpOnDeck).Append("\n");
            sb.Append("  FieldTeamsDueUpInHole: ").Append(FieldTeamsDueUpInHole).Append("\n");
            sb.Append("  FieldTeamsBattingOrder: ").Append(FieldTeamsBattingOrder).Append("\n");
            sb.Append("  PlayersNotInField: ").Append(PlayersNotInField).Append("\n");
            sb.Append("  Tie: ").Append(Tie).Append("\n");
            sb.Append("  TopInning: ").Append(TopInning).Append("\n");
            sb.Append("  HydratedStats: ").Append(HydratedStats).Append("\n");
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