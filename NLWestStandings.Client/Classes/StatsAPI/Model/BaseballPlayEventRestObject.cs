using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballPlayEventRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "details")]
        public Details Details { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "count")]
        public Count Count { get; set; }

        /// <summary>
        /// Gets or Sets PostCount
        /// </summary>
        [DataMember(Name = "postCount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postCount")]
        public Count PostCount { get; set; }

        /// <summary>
        /// Gets or Sets PreCount
        /// </summary>
        [DataMember(Name = "preCount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "preCount")]
        public Count PreCount { get; set; }

        /// <summary>
        /// Gets or Sets PitchData
        /// </summary>
        [DataMember(Name = "pitchData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchData")]
        public BaseballPitchDataRestObject PitchData { get; set; }

        /// <summary>
        /// Gets or Sets HitData
        /// </summary>
        [DataMember(Name = "hitData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitData")]
        public BaseballHitDataRestObject HitData { get; set; }

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
        /// Gets or Sets IsPitch
        /// </summary>
        [DataMember(Name = "isPitch", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPitch")]
        public bool? IsPitch { get; set; }

        /// <summary>
        /// Gets or Sets IsBaseRunningPlay
        /// </summary>
        [DataMember(Name = "isBaseRunningPlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isBaseRunningPlay")]
        public bool? IsBaseRunningPlay { get; set; }

        /// <summary>
        /// Gets or Sets IsSubstitution
        /// </summary>
        [DataMember(Name = "isSubstitution", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isSubstitution")]
        public bool? IsSubstitution { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "player")]
        public BaseballPersonRestObject Player { get; set; }

        /// <summary>
        /// Gets or Sets Umpire
        /// </summary>
        [DataMember(Name = "umpire", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "umpire")]
        public BaseballPersonRestObject Umpire { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "position")]
        public PositionRestObject Position { get; set; }

        /// <summary>
        /// Gets or Sets BattingOrder
        /// </summary>
        [DataMember(Name = "battingOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "battingOrder")]
        public string BattingOrder { get; set; }

        /// <summary>
        /// Gets or Sets ReplacedPlayer
        /// </summary>
        [DataMember(Name = "replacedPlayer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "replacedPlayer")]
        public BaseballPersonRestObject ReplacedPlayer { get; set; }

        /// <summary>
        /// Gets or Sets _Base
        /// </summary>
        [DataMember(Name = "base", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "base")]
        public int? _Base { get; set; }

        /// <summary>
        /// Gets or Sets InjuryType
        /// </summary>
        [DataMember(Name = "injuryType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "injuryType")]
        public string InjuryType { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [DataMember(Name = "defense", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "defense")]
        public BaseballDefenseRestObject Defense { get; set; }

        /// <summary>
        /// Gets or Sets Offense
        /// </summary>
        [DataMember(Name = "offense", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offense")]
        public BaseballOffenseRestObject Offense { get; set; }

        /// <summary>
        /// Gets or Sets Credits
        /// </summary>
        [DataMember(Name = "credits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "credits")]
        public List<PlayCreditRestObject> Credits { get; set; }

        /// <summary>
        /// Gets or Sets Officials
        /// </summary>
        [DataMember(Name = "officials", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "officials")]
        public List<OfficialRestObject> Officials { get; set; }

        /// <summary>
        /// Gets or Sets ReviewDetails
        /// </summary>
        [DataMember(Name = "reviewDetails", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reviewDetails")]
        public ReviewDetails ReviewDetails { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballPlayEventRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  PostCount: ").Append(PostCount).Append("\n");
            sb.Append("  PreCount: ").Append(PreCount).Append("\n");
            sb.Append("  PitchData: ").Append(PitchData).Append("\n");
            sb.Append("  HitData: ").Append(HitData).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  PfxId: ").Append(PfxId).Append("\n");
            sb.Append("  PlayId: ").Append(PlayId).Append("\n");
            sb.Append("  ActionPlayId: ").Append(ActionPlayId).Append("\n");
            sb.Append("  PitchNumber: ").Append(PitchNumber).Append("\n");
            sb.Append("  PickoffNumber: ").Append(PickoffNumber).Append("\n");
            sb.Append("  AtBatNumber: ").Append(AtBatNumber).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  IsPitch: ").Append(IsPitch).Append("\n");
            sb.Append("  IsBaseRunningPlay: ").Append(IsBaseRunningPlay).Append("\n");
            sb.Append("  IsSubstitution: ").Append(IsSubstitution).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Umpire: ").Append(Umpire).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  BattingOrder: ").Append(BattingOrder).Append("\n");
            sb.Append("  ReplacedPlayer: ").Append(ReplacedPlayer).Append("\n");
            sb.Append("  _Base: ").Append(_Base).Append("\n");
            sb.Append("  InjuryType: ").Append(InjuryType).Append("\n");
            sb.Append("  Defense: ").Append(Defense).Append("\n");
            sb.Append("  Offense: ").Append(Offense).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
            sb.Append("  Officials: ").Append(Officials).Append("\n");
            sb.Append("  ReviewDetails: ").Append(ReviewDetails).Append("\n");
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