using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballPlay
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

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
        /// Gets or Sets Inning
        /// </summary>
        [DataMember(Name = "inning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inning")]
        public int? Inning { get; set; }

        /// <summary>
        /// Gets or Sets AtBatIndex
        /// </summary>
        [DataMember(Name = "atBatIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "atBatIndex")]
        public int? AtBatIndex { get; set; }

        /// <summary>
        /// Gets or Sets HalfInning
        /// </summary>
        [DataMember(Name = "halfInning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "halfInning")]
        public string HalfInning { get; set; }

        /// <summary>
        /// Gets or Sets HasOut
        /// </summary>
        [DataMember(Name = "hasOut", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasOut")]
        public bool? HasOut { get; set; }

        /// <summary>
        /// Gets or Sets Batter
        /// </summary>
        [DataMember(Name = "batter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batter")]
        public BaseballPerson Batter { get; set; }

        /// <summary>
        /// Gets or Sets Pitcher
        /// </summary>
        [DataMember(Name = "pitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitcher")]
        public BaseballPerson Pitcher { get; set; }

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
        /// Gets or Sets BatterHotColdZoneStats
        /// </summary>
        [DataMember(Name = "batterHotColdZoneStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batterHotColdZoneStats")]
        public Stats BatterHotColdZoneStats { get; set; }

        /// <summary>
        /// Gets or Sets PitcherHotColdZoneStats
        /// </summary>
        [DataMember(Name = "pitcherHotColdZoneStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitcherHotColdZoneStats")]
        public Stats PitcherHotColdZoneStats { get; set; }

        /// <summary>
        /// Gets or Sets BatterHotColdZones
        /// </summary>
        [DataMember(Name = "batterHotColdZones", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batterHotColdZones")]
        public List<BaseballHotColdZone> BatterHotColdZones { get; set; }

        /// <summary>
        /// Gets or Sets PitcherHotColdZones
        /// </summary>
        [DataMember(Name = "pitcherHotColdZones", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitcherHotColdZones")]
        public List<BaseballHotColdZone> PitcherHotColdZones { get; set; }

        /// <summary>
        /// Gets or Sets SplitsBatter
        /// </summary>
        [DataMember(Name = "splitsBatter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "splitsBatter")]
        public string SplitsBatter { get; set; }

        /// <summary>
        /// Gets or Sets SplitsPitcher
        /// </summary>
        [DataMember(Name = "splitsPitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "splitsPitcher")]
        public string SplitsPitcher { get; set; }

        /// <summary>
        /// Gets or Sets SplitsMenOnBase
        /// </summary>
        [DataMember(Name = "splitsMenOnBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "splitsMenOnBase")]
        public string SplitsMenOnBase { get; set; }

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
        /// Gets or Sets CaptivatingIndex
        /// </summary>
        [DataMember(Name = "captivatingIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "captivatingIndex")]
        public int? CaptivatingIndex { get; set; }

        /// <summary>
        /// Gets or Sets HitTrajectory
        /// </summary>
        [DataMember(Name = "hitTrajectory", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitTrajectory")]
        public HitTrajectory HitTrajectory { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventType")]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or Sets EventTypeEnum
        /// </summary>
        [DataMember(Name = "eventTypeEnum", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventTypeEnum")]
        public EventType EventTypeEnum { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

        /// <summary>
        /// Gets or Sets ResultMap
        /// </summary>
        [DataMember(Name = "resultMap", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resultMap")]
        public Dictionary<string, string> ResultMap { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets NumRbi
        /// </summary>
        [DataMember(Name = "numRbi", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numRbi")]
        public int? NumRbi { get; set; }

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
        /// Gets or Sets IsComplete
        /// </summary>
        [DataMember(Name = "isComplete", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isComplete")]
        public bool? IsComplete { get; set; }

        /// <summary>
        /// Gets or Sets IsScoringPlay
        /// </summary>
        [DataMember(Name = "isScoringPlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isScoringPlay")]
        public bool? IsScoringPlay { get; set; }

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
        /// Gets or Sets RunnerOn1b
        /// </summary>
        [DataMember(Name = "runnerOn1b", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerOn1b")]
        public BaseballPerson RunnerOn1b { get; set; }

        /// <summary>
        /// Gets or Sets RunnerOn2b
        /// </summary>
        [DataMember(Name = "runnerOn2b", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerOn2b")]
        public BaseballPerson RunnerOn2b { get; set; }

        /// <summary>
        /// Gets or Sets RunnerOn3b
        /// </summary>
        [DataMember(Name = "runnerOn3b", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerOn3b")]
        public BaseballPerson RunnerOn3b { get; set; }

        /// <summary>
        /// Gets or Sets PitchIndex
        /// </summary>
        [DataMember(Name = "pitchIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchIndex")]
        public List<int?> PitchIndex { get; set; }

        /// <summary>
        /// Gets or Sets ActionIndex
        /// </summary>
        [DataMember(Name = "actionIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "actionIndex")]
        public List<int?> ActionIndex { get; set; }

        /// <summary>
        /// Gets or Sets RunnerIndex
        /// </summary>
        [DataMember(Name = "runnerIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerIndex")]
        public List<Object> RunnerIndex { get; set; }

        /// <summary>
        /// Gets or Sets RunnerMovements
        /// </summary>
        [DataMember(Name = "runnerMovements", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerMovements")]
        public List<BaseballRunnerMovement> RunnerMovements { get; set; }

        /// <summary>
        /// Gets or Sets PlayEvents
        /// </summary>
        [DataMember(Name = "playEvents", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playEvents")]
        public List<BaseballPlayEvent> PlayEvents { get; set; }

        /// <summary>
        /// Gets or Sets Credits
        /// </summary>
        [DataMember(Name = "credits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "credits")]
        public List<PlayCredit> Credits { get; set; }

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "flags")]
        public List<PlayCredit> Flags { get; set; }

        /// <summary>
        /// Gets or Sets IsDoublePlay
        /// </summary>
        [DataMember(Name = "isDoublePlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isDoublePlay")]
        public bool? IsDoublePlay { get; set; }

        /// <summary>
        /// Gets or Sets IsGroundIntoDoublePlay
        /// </summary>
        [DataMember(Name = "isGroundIntoDoublePlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isGroundIntoDoublePlay")]
        public bool? IsGroundIntoDoublePlay { get; set; }

        /// <summary>
        /// Gets or Sets IsTriplePlay
        /// </summary>
        [DataMember(Name = "isTriplePlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isTriplePlay")]
        public bool? IsTriplePlay { get; set; }

        /// <summary>
        /// Gets or Sets IsGroundIntoTriplePlay
        /// </summary>
        [DataMember(Name = "isGroundIntoTriplePlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isGroundIntoTriplePlay")]
        public bool? IsGroundIntoTriplePlay { get; set; }

        /// <summary>
        /// Gets or Sets NumLeftOnBase
        /// </summary>
        [DataMember(Name = "numLeftOnBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numLeftOnBase")]
        public int? NumLeftOnBase { get; set; }

        /// <summary>
        /// Gets or Sets NumLeftOnBaseScoring
        /// </summary>
        [DataMember(Name = "numLeftOnBaseScoring", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numLeftOnBaseScoring")]
        public int? NumLeftOnBaseScoring { get; set; }

        /// <summary>
        /// Gets or Sets OffensiveAlignmentId
        /// </summary>
        [DataMember(Name = "offensiveAlignmentId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offensiveAlignmentId")]
        public string OffensiveAlignmentId { get; set; }

        /// <summary>
        /// Gets or Sets DefensiveAlignmentId
        /// </summary>
        [DataMember(Name = "defensiveAlignmentId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "defensiveAlignmentId")]
        public string DefensiveAlignmentId { get; set; }

        /// <summary>
        /// Gets or Sets Complete
        /// </summary>
        [DataMember(Name = "complete", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "complete")]
        public bool? Complete { get; set; }

        /// <summary>
        /// Gets or Sets ScoringPlay
        /// </summary>
        [DataMember(Name = "scoringPlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scoringPlay")]
        public bool? ScoringPlay { get; set; }

        /// <summary>
        /// Gets or Sets TopInning
        /// </summary>
        [DataMember(Name = "topInning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "topInning")]
        public bool? TopInning { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "results")]
        public Dictionary<string, string> Results { get; set; }

        /// <summary>
        /// Gets or Sets Descriptions
        /// </summary>
        [DataMember(Name = "descriptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "descriptions")]
        public Dictionary<string, string> Descriptions { get; set; }

        /// <summary>
        /// Gets or Sets PlateAppearance
        /// </summary>
        [DataMember(Name = "plateAppearance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "plateAppearance")]
        public bool? PlateAppearance { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "summary")]
        public BaseballPlay Summary { get; set; }

        /// <summary>
        /// Gets or Sets BatterResultEvent
        /// </summary>
        [DataMember(Name = "batterResultEvent", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batterResultEvent")]
        public EventType BatterResultEvent { get; set; }

        /// <summary>
        /// Gets or Sets ResponsibleBatter
        /// </summary>
        [DataMember(Name = "responsibleBatter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "responsibleBatter")]
        public BaseballPerson ResponsibleBatter { get; set; }

        /// <summary>
        /// Gets or Sets PayoffEvent
        /// </summary>
        [DataMember(Name = "payoffEvent", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payoffEvent")]
        public BaseballPlayEvent PayoffEvent { get; set; }

        /// <summary>
        /// Gets or Sets TeamNumLeftOnBase
        /// </summary>
        [DataMember(Name = "teamNumLeftOnBase", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamNumLeftOnBase")]
        public int? TeamNumLeftOnBase { get; set; }

        /// <summary>
        /// Gets or Sets NumLeftOnBaseScoringPosition
        /// </summary>
        [DataMember(Name = "numLeftOnBaseScoringPosition", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numLeftOnBaseScoringPosition")]
        public int? NumLeftOnBaseScoringPosition { get; set; }

        /// <summary>
        /// Gets or Sets Hit
        /// </summary>
        [DataMember(Name = "hit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hit")]
        public bool? Hit { get; set; }

        /// <summary>
        /// Gets or Sets AtBat
        /// </summary>
        [DataMember(Name = "atBat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "atBat")]
        public bool? AtBat { get; set; }

        /// <summary>
        /// Gets or Sets DoublePlay
        /// </summary>
        [DataMember(Name = "doublePlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "doublePlay")]
        public bool? DoublePlay { get; set; }

        /// <summary>
        /// Gets or Sets TriplePlay
        /// </summary>
        [DataMember(Name = "triplePlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "triplePlay")]
        public bool? TriplePlay { get; set; }

        /// <summary>
        /// Gets or Sets GroundIntoDoublePlay
        /// </summary>
        [DataMember(Name = "groundIntoDoublePlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "groundIntoDoublePlay")]
        public bool? GroundIntoDoublePlay { get; set; }

        /// <summary>
        /// Gets or Sets GroundIntoTriplePlay
        /// </summary>
        [DataMember(Name = "groundIntoTriplePlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "groundIntoTriplePlay")]
        public bool? GroundIntoTriplePlay { get; set; }

        /// <summary>
        /// Gets or Sets GroundOut
        /// </summary>
        [DataMember(Name = "groundOut", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "groundOut")]
        public bool? GroundOut { get; set; }

        /// <summary>
        /// Gets or Sets ResponsiblePitcher
        /// </summary>
        [DataMember(Name = "responsiblePitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "responsiblePitcher")]
        public BaseballPerson ResponsiblePitcher { get; set; }

        /// <summary>
        /// Gets or Sets InPlayEvent
        /// </summary>
        [DataMember(Name = "inPlayEvent", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inPlayEvent")]
        public BaseballPlayEvent InPlayEvent { get; set; }

        /// <summary>
        /// Gets or Sets NumErrors
        /// </summary>
        [DataMember(Name = "numErrors", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numErrors")]
        public int? NumErrors { get; set; }

        /// <summary>
        /// Gets or Sets NumRuns
        /// </summary>
        [DataMember(Name = "numRuns", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numRuns")]
        public int? NumRuns { get; set; }

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
            sb.Append("class BaseballPlay {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  Balls: ").Append(Balls).Append("\n");
            sb.Append("  Strikes: ").Append(Strikes).Append("\n");
            sb.Append("  Outs: ").Append(Outs).Append("\n");
            sb.Append("  Inning: ").Append(Inning).Append("\n");
            sb.Append("  AtBatIndex: ").Append(AtBatIndex).Append("\n");
            sb.Append("  HalfInning: ").Append(HalfInning).Append("\n");
            sb.Append("  HasOut: ").Append(HasOut).Append("\n");
            sb.Append("  Batter: ").Append(Batter).Append("\n");
            sb.Append("  Pitcher: ").Append(Pitcher).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  BatterHotColdZoneStats: ").Append(BatterHotColdZoneStats).Append("\n");
            sb.Append("  PitcherHotColdZoneStats: ").Append(PitcherHotColdZoneStats).Append("\n");
            sb.Append("  BatterHotColdZones: ").Append(BatterHotColdZones).Append("\n");
            sb.Append("  PitcherHotColdZones: ").Append(PitcherHotColdZones).Append("\n");
            sb.Append("  SplitsBatter: ").Append(SplitsBatter).Append("\n");
            sb.Append("  SplitsPitcher: ").Append(SplitsPitcher).Append("\n");
            sb.Append("  SplitsMenOnBase: ").Append(SplitsMenOnBase).Append("\n");
            sb.Append("  PitchHand: ").Append(PitchHand).Append("\n");
            sb.Append("  BatSide: ").Append(BatSide).Append("\n");
            sb.Append("  CaptivatingIndex: ").Append(CaptivatingIndex).Append("\n");
            sb.Append("  HitTrajectory: ").Append(HitTrajectory).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventTypeEnum: ").Append(EventTypeEnum).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  ResultMap: ").Append(ResultMap).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  NumRbi: ").Append(NumRbi).Append("\n");
            sb.Append("  AwayScore: ").Append(AwayScore).Append("\n");
            sb.Append("  HomeScore: ").Append(HomeScore).Append("\n");
            sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
            sb.Append("  IsScoringPlay: ").Append(IsScoringPlay).Append("\n");
            sb.Append("  HasReview: ").Append(HasReview).Append("\n");
            sb.Append("  ReviewType: ").Append(ReviewType).Append("\n");
            sb.Append("  ReviewOverturned: ").Append(ReviewOverturned).Append("\n");
            sb.Append("  ReviewInProgress: ").Append(ReviewInProgress).Append("\n");
            sb.Append("  ChallengeTeamId: ").Append(ChallengeTeamId).Append("\n");
            sb.Append("  Reviews: ").Append(Reviews).Append("\n");
            sb.Append("  RunnerOn1b: ").Append(RunnerOn1b).Append("\n");
            sb.Append("  RunnerOn2b: ").Append(RunnerOn2b).Append("\n");
            sb.Append("  RunnerOn3b: ").Append(RunnerOn3b).Append("\n");
            sb.Append("  PitchIndex: ").Append(PitchIndex).Append("\n");
            sb.Append("  ActionIndex: ").Append(ActionIndex).Append("\n");
            sb.Append("  RunnerIndex: ").Append(RunnerIndex).Append("\n");
            sb.Append("  RunnerMovements: ").Append(RunnerMovements).Append("\n");
            sb.Append("  PlayEvents: ").Append(PlayEvents).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  IsDoublePlay: ").Append(IsDoublePlay).Append("\n");
            sb.Append("  IsGroundIntoDoublePlay: ").Append(IsGroundIntoDoublePlay).Append("\n");
            sb.Append("  IsTriplePlay: ").Append(IsTriplePlay).Append("\n");
            sb.Append("  IsGroundIntoTriplePlay: ").Append(IsGroundIntoTriplePlay).Append("\n");
            sb.Append("  NumLeftOnBase: ").Append(NumLeftOnBase).Append("\n");
            sb.Append("  NumLeftOnBaseScoring: ").Append(NumLeftOnBaseScoring).Append("\n");
            sb.Append("  OffensiveAlignmentId: ").Append(OffensiveAlignmentId).Append("\n");
            sb.Append("  DefensiveAlignmentId: ").Append(DefensiveAlignmentId).Append("\n");
            sb.Append("  Complete: ").Append(Complete).Append("\n");
            sb.Append("  ScoringPlay: ").Append(ScoringPlay).Append("\n");
            sb.Append("  TopInning: ").Append(TopInning).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Descriptions: ").Append(Descriptions).Append("\n");
            sb.Append("  PlateAppearance: ").Append(PlateAppearance).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  BatterResultEvent: ").Append(BatterResultEvent).Append("\n");
            sb.Append("  ResponsibleBatter: ").Append(ResponsibleBatter).Append("\n");
            sb.Append("  PayoffEvent: ").Append(PayoffEvent).Append("\n");
            sb.Append("  TeamNumLeftOnBase: ").Append(TeamNumLeftOnBase).Append("\n");
            sb.Append("  NumLeftOnBaseScoringPosition: ").Append(NumLeftOnBaseScoringPosition).Append("\n");
            sb.Append("  Hit: ").Append(Hit).Append("\n");
            sb.Append("  AtBat: ").Append(AtBat).Append("\n");
            sb.Append("  DoublePlay: ").Append(DoublePlay).Append("\n");
            sb.Append("  TriplePlay: ").Append(TriplePlay).Append("\n");
            sb.Append("  GroundIntoDoublePlay: ").Append(GroundIntoDoublePlay).Append("\n");
            sb.Append("  GroundIntoTriplePlay: ").Append(GroundIntoTriplePlay).Append("\n");
            sb.Append("  GroundOut: ").Append(GroundOut).Append("\n");
            sb.Append("  ResponsiblePitcher: ").Append(ResponsiblePitcher).Append("\n");
            sb.Append("  InPlayEvent: ").Append(InPlayEvent).Append("\n");
            sb.Append("  NumErrors: ").Append(NumErrors).Append("\n");
            sb.Append("  NumRuns: ").Append(NumRuns).Append("\n");
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