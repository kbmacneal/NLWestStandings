using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballPlayEvent
    {
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
        /// Gets or Sets RunnerOn1b
        /// </summary>
        [DataMember(Name = "runnerOn1b", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerOn1b")]
        public bool? RunnerOn1b { get; set; }

        /// <summary>
        /// Gets or Sets RunnerOn2b
        /// </summary>
        [DataMember(Name = "runnerOn2b", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerOn2b")]
        public bool? RunnerOn2b { get; set; }

        /// <summary>
        /// Gets or Sets RunnerOn3b
        /// </summary>
        [DataMember(Name = "runnerOn3b", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerOn3b")]
        public bool? RunnerOn3b { get; set; }

        /// <summary>
        /// Gets or Sets Inning
        /// </summary>
        [DataMember(Name = "inning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inning")]
        public int? Inning { get; set; }

        /// <summary>
        /// Gets or Sets IsTopInning
        /// </summary>
        [DataMember(Name = "isTopInning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isTopInning")]
        public bool? IsTopInning { get; set; }

        /// <summary>
        /// Gets or Sets PreBalls
        /// </summary>
        [DataMember(Name = "preBalls", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "preBalls")]
        public int? PreBalls { get; set; }

        /// <summary>
        /// Gets or Sets PreStrikes
        /// </summary>
        [DataMember(Name = "preStrikes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "preStrikes")]
        public int? PreStrikes { get; set; }

        /// <summary>
        /// Gets or Sets PreOuts
        /// </summary>
        [DataMember(Name = "preOuts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "preOuts")]
        public int? PreOuts { get; set; }

        /// <summary>
        /// Gets or Sets PostBalls
        /// </summary>
        [DataMember(Name = "postBalls", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postBalls")]
        public int? PostBalls { get; set; }

        /// <summary>
        /// Gets or Sets PostStrikes
        /// </summary>
        [DataMember(Name = "postStrikes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postStrikes")]
        public int? PostStrikes { get; set; }

        /// <summary>
        /// Gets or Sets PostOuts
        /// </summary>
        [DataMember(Name = "postOuts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postOuts")]
        public int? PostOuts { get; set; }

        /// <summary>
        /// Gets or Sets PostRunnerOn1b
        /// </summary>
        [DataMember(Name = "postRunnerOn1b", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postRunnerOn1b")]
        public bool? PostRunnerOn1b { get; set; }

        /// <summary>
        /// Gets or Sets PostRunnerOn2b
        /// </summary>
        [DataMember(Name = "postRunnerOn2b", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postRunnerOn2b")]
        public bool? PostRunnerOn2b { get; set; }

        /// <summary>
        /// Gets or Sets PostRunnerOn3b
        /// </summary>
        [DataMember(Name = "postRunnerOn3b", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postRunnerOn3b")]
        public bool? PostRunnerOn3b { get; set; }

        /// <summary>
        /// Gets or Sets PitchNumber
        /// </summary>
        [DataMember(Name = "pitchNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchNumber")]
        public int? PitchNumber { get; set; }

        /// <summary>
        /// Gets or Sets PickoffNumber
        /// </summary>
        [DataMember(Name = "pickoffNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pickoffNumber")]
        public int? PickoffNumber { get; set; }

        /// <summary>
        /// Gets or Sets AtBatNumber
        /// </summary>
        [DataMember(Name = "atBatNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "atBatNumber")]
        public int? AtBatNumber { get; set; }

        /// <summary>
        /// Gets or Sets EventTypeEnum
        /// </summary>
        [DataMember(Name = "eventTypeEnum", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventTypeEnum")]
        public EventType EventTypeEnum { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DescriptionMap
        /// </summary>
        [DataMember(Name = "descriptionMap", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "descriptionMap")]
        public Dictionary<string, string> DescriptionMap { get; set; }

        /// <summary>
        /// Gets or Sets PitchCall
        /// </summary>
        [DataMember(Name = "pitchCall", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchCall")]
        public DynamicLookupEnum PitchCall { get; set; }

        /// <summary>
        /// Gets or Sets PitchType
        /// </summary>
        [DataMember(Name = "pitchType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchType")]
        public DynamicLookupEnum PitchType { get; set; }

        /// <summary>
        /// Gets or Sets Pitch
        /// </summary>
        [DataMember(Name = "pitch", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitch")]
        public BaseballPitch Pitch { get; set; }

        /// <summary>
        /// Gets or Sets Hit
        /// </summary>
        [DataMember(Name = "hit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hit")]
        public BaseballHit Hit { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "index")]
        public int? Index { get; set; }

        /// <summary>
        /// Gets or Sets PfxId
        /// </summary>
        [DataMember(Name = "pfxId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pfxId")]
        public string PfxId { get; set; }

        /// <summary>
        /// Gets or Sets PlayId
        /// </summary>
        [DataMember(Name = "playId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playId")]
        public string PlayId { get; set; }

        /// <summary>
        /// Gets or Sets ActionPlayId
        /// </summary>
        [DataMember(Name = "actionPlayId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "actionPlayId")]
        public string ActionPlayId { get; set; }

        /// <summary>
        /// Gets or Sets IsPitch
        /// </summary>
        [DataMember(Name = "isPitch", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPitch")]
        public bool? IsPitch { get; set; }

        /// <summary>
        /// Gets or Sets IsInPlay
        /// </summary>
        [DataMember(Name = "isInPlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isInPlay")]
        public bool? IsInPlay { get; set; }

        /// <summary>
        /// Gets or Sets IsStrike
        /// </summary>
        [DataMember(Name = "isStrike", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isStrike")]
        public bool? IsStrike { get; set; }

        /// <summary>
        /// Gets or Sets IsBall
        /// </summary>
        [DataMember(Name = "isBall", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isBall")]
        public bool? IsBall { get; set; }

        /// <summary>
        /// Gets or Sets _Event
        /// </summary>
        [DataMember(Name = "event", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "event")]
        public string _Event { get; set; }

        /// <summary>
        /// Gets or Sets EventMap
        /// </summary>
        [DataMember(Name = "eventMap", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventMap")]
        public Dictionary<string, string> EventMap { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startTime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "endTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endTime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "player")]
        public BaseballPerson Player { get; set; }

        /// <summary>
        /// Gets or Sets Umpire
        /// </summary>
        [DataMember(Name = "umpire", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "umpire")]
        public BaseballPerson Umpire { get; set; }

        /// <summary>
        /// Gets or Sets ReplacedPlayer
        /// </summary>
        [DataMember(Name = "replacedPlayer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "replacedPlayer")]
        public BaseballPerson ReplacedPlayer { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "position")]
        public BaseballPosition Position { get; set; }

        /// <summary>
        /// Gets or Sets BattingOrder
        /// </summary>
        [DataMember(Name = "battingOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "battingOrder")]
        public string BattingOrder { get; set; }

        /// <summary>
        /// Gets or Sets Scored
        /// </summary>
        [DataMember(Name = "scored", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scored")]
        public bool? Scored { get; set; }

        /// <summary>
        /// Gets or Sets IsOut
        /// </summary>
        [DataMember(Name = "isOut", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isOut")]
        public bool? IsOut { get; set; }

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
        /// Gets or Sets IsAtBat
        /// </summary>
        [DataMember(Name = "isAtBat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isAtBat")]
        public bool? IsAtBat { get; set; }

        /// <summary>
        /// Gets or Sets IsPlateAppearance
        /// </summary>
        [DataMember(Name = "isPlateAppearance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPlateAppearance")]
        public bool? IsPlateAppearance { get; set; }

        /// <summary>
        /// Gets or Sets IsBaseHit
        /// </summary>
        [DataMember(Name = "isBaseHit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isBaseHit")]
        public bool? IsBaseHit { get; set; }

        /// <summary>
        /// Gets or Sets PitchHand
        /// </summary>
        [DataMember(Name = "pitchHand", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchHand")]
        public DynamicLookupEnum PitchHand { get; set; }

        /// <summary>
        /// Gets or Sets BatSide
        /// </summary>
        [DataMember(Name = "batSide", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batSide")]
        public DynamicLookupEnum BatSide { get; set; }

        /// <summary>
        /// Gets or Sets HasReview
        /// </summary>
        [DataMember(Name = "hasReview", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasReview")]
        public bool? HasReview { get; set; }

        /// <summary>
        /// Gets or Sets ReviewType
        /// </summary>
        [DataMember(Name = "reviewType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reviewType")]
        public string ReviewType { get; set; }

        /// <summary>
        /// Gets or Sets ReviewOverturned
        /// </summary>
        [DataMember(Name = "reviewOverturned", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reviewOverturned")]
        public bool? ReviewOverturned { get; set; }

        /// <summary>
        /// Gets or Sets ReviewInProgress
        /// </summary>
        [DataMember(Name = "reviewInProgress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reviewInProgress")]
        public bool? ReviewInProgress { get; set; }

        /// <summary>
        /// Gets or Sets ChallengeTeamId
        /// </summary>
        [DataMember(Name = "challengeTeamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "challengeTeamId")]
        public int? ChallengeTeamId { get; set; }

        /// <summary>
        /// Gets or Sets Reviews
        /// </summary>
        [DataMember(Name = "reviews", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reviews")]
        public List<BaseballReview> Reviews { get; set; }

        /// <summary>
        /// Gets or Sets FromCatcher
        /// </summary>
        [DataMember(Name = "fromCatcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fromCatcher")]
        public bool? FromCatcher { get; set; }

        /// <summary>
        /// Gets or Sets InjuryType
        /// </summary>
        [DataMember(Name = "injuryType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "injuryType")]
        public string InjuryType { get; set; }

        /// <summary>
        /// Gets or Sets Players
        /// </summary>
        [DataMember(Name = "players", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "players")]
        public BaseballLinescore Players { get; set; }

        /// <summary>
        /// Gets or Sets DefensiveAlignmentId
        /// </summary>
        [DataMember(Name = "defensiveAlignmentId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "defensiveAlignmentId")]
        public string DefensiveAlignmentId { get; set; }

        /// <summary>
        /// Gets or Sets OffensiveAlignmentId
        /// </summary>
        [DataMember(Name = "offensiveAlignmentId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offensiveAlignmentId")]
        public string OffensiveAlignmentId { get; set; }

        /// <summary>
        /// Gets or Sets OffensiveLineupId
        /// </summary>
        [DataMember(Name = "offensiveLineupId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offensiveLineupId")]
        public string OffensiveLineupId { get; set; }

        /// <summary>
        /// Gets or Sets DefensiveLineupId
        /// </summary>
        [DataMember(Name = "defensiveLineupId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "defensiveLineupId")]
        public string DefensiveLineupId { get; set; }

        /// <summary>
        /// Gets or Sets Umpires
        /// </summary>
        [DataMember(Name = "umpires", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "umpires")]
        public List<Official> Umpires { get; set; }

        /// <summary>
        /// Gets or Sets Credits
        /// </summary>
        [DataMember(Name = "credits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "credits")]
        public List<PlayCredit> Credits { get; set; }

        /// <summary>
        /// Gets or Sets _Base
        /// </summary>
        [DataMember(Name = "base", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "base")]
        public int? _Base { get; set; }

        /// <summary>
        /// Gets or Sets IsDoublePlay
        /// </summary>
        [DataMember(Name = "isDoublePlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isDoublePlay")]
        public bool? IsDoublePlay { get; set; }

        /// <summary>
        /// Gets or Sets NumInheritedRunners
        /// </summary>
        [DataMember(Name = "numInheritedRunners", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numInheritedRunners")]
        public int? NumInheritedRunners { get; set; }

        /// <summary>
        /// Gets or Sets DisengagementNum
        /// </summary>
        [DataMember(Name = "disengagementNum", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "disengagementNum")]
        public int? DisengagementNum { get; set; }

        /// <summary>
        /// Gets or Sets Violation
        /// </summary>
        [DataMember(Name = "violation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "violation")]
        public BaseballViolation Violation { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfPeopleOnBaseScoringPosition
        /// </summary>
        [DataMember(Name = "numberOfPeopleOnBaseScoringPosition", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numberOfPeopleOnBaseScoringPosition")]
        public int? NumberOfPeopleOnBaseScoringPosition { get; set; }

        /// <summary>
        /// Gets or Sets Descriptions
        /// </summary>
        [DataMember(Name = "descriptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "descriptions")]
        public Dictionary<string, string> Descriptions { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "events")]
        public Dictionary<string, string> Events { get; set; }

        /// <summary>
        /// Gets or Sets RunnerGoing
        /// </summary>
        [DataMember(Name = "runnerGoing", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerGoing")]
        public bool? RunnerGoing { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "summary")]
        public BaseballPlayEvent Summary { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfPeopleOnBase
        /// </summary>
        [DataMember(Name = "numberOfPeopleOnBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numberOfPeopleOnBase")]
        public int? NumberOfPeopleOnBase { get; set; }

        /// <summary>
        /// Gets or Sets DoublePlay
        /// </summary>
        [DataMember(Name = "doublePlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "doublePlay")]
        public bool? DoublePlay { get; set; }

        /// <summary>
        /// Gets or Sets BaseRunningPlay
        /// </summary>
        [DataMember(Name = "baseRunningPlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "baseRunningPlay")]
        public bool? BaseRunningPlay { get; set; }

        /// <summary>
        /// Gets or Sets Substitution
        /// </summary>
        [DataMember(Name = "substitution", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "substitution")]
        public bool? Substitution { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballPlayEvent {\n");
            sb.Append("  Balls: ").Append(Balls).Append("\n");
            sb.Append("  Strikes: ").Append(Strikes).Append("\n");
            sb.Append("  Outs: ").Append(Outs).Append("\n");
            sb.Append("  RunnerOn1b: ").Append(RunnerOn1b).Append("\n");
            sb.Append("  RunnerOn2b: ").Append(RunnerOn2b).Append("\n");
            sb.Append("  RunnerOn3b: ").Append(RunnerOn3b).Append("\n");
            sb.Append("  Inning: ").Append(Inning).Append("\n");
            sb.Append("  IsTopInning: ").Append(IsTopInning).Append("\n");
            sb.Append("  PreBalls: ").Append(PreBalls).Append("\n");
            sb.Append("  PreStrikes: ").Append(PreStrikes).Append("\n");
            sb.Append("  PreOuts: ").Append(PreOuts).Append("\n");
            sb.Append("  PostBalls: ").Append(PostBalls).Append("\n");
            sb.Append("  PostStrikes: ").Append(PostStrikes).Append("\n");
            sb.Append("  PostOuts: ").Append(PostOuts).Append("\n");
            sb.Append("  PostRunnerOn1b: ").Append(PostRunnerOn1b).Append("\n");
            sb.Append("  PostRunnerOn2b: ").Append(PostRunnerOn2b).Append("\n");
            sb.Append("  PostRunnerOn3b: ").Append(PostRunnerOn3b).Append("\n");
            sb.Append("  PitchNumber: ").Append(PitchNumber).Append("\n");
            sb.Append("  PickoffNumber: ").Append(PickoffNumber).Append("\n");
            sb.Append("  AtBatNumber: ").Append(AtBatNumber).Append("\n");
            sb.Append("  EventTypeEnum: ").Append(EventTypeEnum).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DescriptionMap: ").Append(DescriptionMap).Append("\n");
            sb.Append("  PitchCall: ").Append(PitchCall).Append("\n");
            sb.Append("  PitchType: ").Append(PitchType).Append("\n");
            sb.Append("  Pitch: ").Append(Pitch).Append("\n");
            sb.Append("  Hit: ").Append(Hit).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  PfxId: ").Append(PfxId).Append("\n");
            sb.Append("  PlayId: ").Append(PlayId).Append("\n");
            sb.Append("  ActionPlayId: ").Append(ActionPlayId).Append("\n");
            sb.Append("  IsPitch: ").Append(IsPitch).Append("\n");
            sb.Append("  IsInPlay: ").Append(IsInPlay).Append("\n");
            sb.Append("  IsStrike: ").Append(IsStrike).Append("\n");
            sb.Append("  IsBall: ").Append(IsBall).Append("\n");
            sb.Append("  _Event: ").Append(_Event).Append("\n");
            sb.Append("  EventMap: ").Append(EventMap).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Umpire: ").Append(Umpire).Append("\n");
            sb.Append("  ReplacedPlayer: ").Append(ReplacedPlayer).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  BattingOrder: ").Append(BattingOrder).Append("\n");
            sb.Append("  Scored: ").Append(Scored).Append("\n");
            sb.Append("  IsOut: ").Append(IsOut).Append("\n");
            sb.Append("  AwayScore: ").Append(AwayScore).Append("\n");
            sb.Append("  HomeScore: ").Append(HomeScore).Append("\n");
            sb.Append("  IsAtBat: ").Append(IsAtBat).Append("\n");
            sb.Append("  IsPlateAppearance: ").Append(IsPlateAppearance).Append("\n");
            sb.Append("  IsBaseHit: ").Append(IsBaseHit).Append("\n");
            sb.Append("  PitchHand: ").Append(PitchHand).Append("\n");
            sb.Append("  BatSide: ").Append(BatSide).Append("\n");
            sb.Append("  HasReview: ").Append(HasReview).Append("\n");
            sb.Append("  ReviewType: ").Append(ReviewType).Append("\n");
            sb.Append("  ReviewOverturned: ").Append(ReviewOverturned).Append("\n");
            sb.Append("  ReviewInProgress: ").Append(ReviewInProgress).Append("\n");
            sb.Append("  ChallengeTeamId: ").Append(ChallengeTeamId).Append("\n");
            sb.Append("  Reviews: ").Append(Reviews).Append("\n");
            sb.Append("  FromCatcher: ").Append(FromCatcher).Append("\n");
            sb.Append("  InjuryType: ").Append(InjuryType).Append("\n");
            sb.Append("  Players: ").Append(Players).Append("\n");
            sb.Append("  DefensiveAlignmentId: ").Append(DefensiveAlignmentId).Append("\n");
            sb.Append("  OffensiveAlignmentId: ").Append(OffensiveAlignmentId).Append("\n");
            sb.Append("  OffensiveLineupId: ").Append(OffensiveLineupId).Append("\n");
            sb.Append("  DefensiveLineupId: ").Append(DefensiveLineupId).Append("\n");
            sb.Append("  Umpires: ").Append(Umpires).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
            sb.Append("  _Base: ").Append(_Base).Append("\n");
            sb.Append("  IsDoublePlay: ").Append(IsDoublePlay).Append("\n");
            sb.Append("  NumInheritedRunners: ").Append(NumInheritedRunners).Append("\n");
            sb.Append("  DisengagementNum: ").Append(DisengagementNum).Append("\n");
            sb.Append("  Violation: ").Append(Violation).Append("\n");
            sb.Append("  NumberOfPeopleOnBaseScoringPosition: ").Append(NumberOfPeopleOnBaseScoringPosition).Append("\n");
            sb.Append("  Descriptions: ").Append(Descriptions).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  RunnerGoing: ").Append(RunnerGoing).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  NumberOfPeopleOnBase: ").Append(NumberOfPeopleOnBase).Append("\n");
            sb.Append("  DoublePlay: ").Append(DoublePlay).Append("\n");
            sb.Append("  BaseRunningPlay: ").Append(BaseRunningPlay).Append("\n");
            sb.Append("  Substitution: ").Append(Substitution).Append("\n");
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