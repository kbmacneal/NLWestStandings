using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class AnalyticsPlayMetadataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Hydrations
        /// </summary>
        [DataMember(Name = "hydrations", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydrations")]
        public List<string> Hydrations { get; set; }

        /// <summary>
        /// Gets or Sets GamePk
        /// </summary>
        [DataMember(Name = "gamePk", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamePk")]
        public string GamePk { get; set; }

        /// <summary>
        /// Gets or Sets GameDate
        /// </summary>
        [DataMember(Name = "gameDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameDate")]
        public string GameDate { get; set; }

        /// <summary>
        /// Gets or Sets TimeCode
        /// </summary>
        [DataMember(Name = "timeCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeCode")]
        public string TimeCode { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name = "guid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "guid")]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets AtBatNumber
        /// </summary>
        [DataMember(Name = "atBatNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "atBatNumber")]
        public int? AtBatNumber { get; set; }

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
        /// Gets or Sets GameMode
        /// </summary>
        [DataMember(Name = "gameMode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameMode")]
        public GameModeTO GameMode { get; set; }

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
        /// Gets or Sets IsPitch
        /// </summary>
        [DataMember(Name = "isPitch", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPitch")]
        public bool? IsPitch { get; set; }

        /// <summary>
        /// Gets or Sets IsPickoff
        /// </summary>
        [DataMember(Name = "isPickoff", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPickoff")]
        public bool? IsPickoff { get; set; }

        /// <summary>
        /// Gets or Sets IsHit
        /// </summary>
        [DataMember(Name = "isHit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isHit")]
        public bool? IsHit { get; set; }

        /// <summary>
        /// Gets or Sets IsManual
        /// </summary>
        [DataMember(Name = "isManual", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isManual")]
        public bool? IsManual { get; set; }

        /// <summary>
        /// Gets or Sets RawFile
        /// </summary>
        [DataMember(Name = "rawFile", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rawFile")]
        public string RawFile { get; set; }

        /// <summary>
        /// Gets or Sets ParsedFile
        /// </summary>
        [DataMember(Name = "parsedFile", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parsedFile")]
        public string ParsedFile { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "endTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or Sets PitchTime
        /// </summary>
        [DataMember(Name = "pitchTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchTime")]
        public string PitchTime { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "createdAt")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "updatedAt")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets AuditUpdatedAt
        /// </summary>
        [DataMember(Name = "auditUpdatedAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "auditUpdatedAt")]
        public string AuditUpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets MetricsUpdatedAt
        /// </summary>
        [DataMember(Name = "metricsUpdatedAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "metricsUpdatedAt")]
        public string MetricsUpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets HasUpdates
        /// </summary>
        [DataMember(Name = "hasUpdates", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasUpdates")]
        public bool? HasUpdates { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfMetricErrors
        /// </summary>
        [DataMember(Name = "numberOfMetricErrors", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numberOfMetricErrors")]
        public int? NumberOfMetricErrors { get; set; }

        /// <summary>
        /// Gets or Sets TimeCodeOffset
        /// </summary>
        [DataMember(Name = "timeCodeOffset", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeCodeOffset")]
        public string TimeCodeOffset { get; set; }

        /// <summary>
        /// Gets or Sets IsScrubbed
        /// </summary>
        [DataMember(Name = "isScrubbed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isScrubbed")]
        public bool? IsScrubbed { get; set; }

        /// <summary>
        /// Gets or Sets VideoUpdatedAt
        /// </summary>
        [DataMember(Name = "videoUpdatedAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "videoUpdatedAt")]
        public string VideoUpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets StrikeZoneInfo
        /// </summary>
        [DataMember(Name = "strikeZoneInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikeZoneInfo")]
        public JsonNode StrikeZoneInfo { get; set; }

        /// <summary>
        /// Gets or Sets PitchSegment
        /// </summary>
        [DataMember(Name = "pitchSegment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchSegment")]
        public PitchSegmentRestObject PitchSegment { get; set; }

        /// <summary>
        /// Gets or Sets HitSegment
        /// </summary>
        [DataMember(Name = "hitSegment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitSegment")]
        public HitSegmentRestObject HitSegment { get; set; }

        /// <summary>
        /// Gets or Sets ContextMetrics
        /// </summary>
        [DataMember(Name = "contextMetrics", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "contextMetrics")]
        public List<CalculatedMetricRestObject> ContextMetrics { get; set; }

        /// <summary>
        /// Gets or Sets ContextAverages
        /// </summary>
        [DataMember(Name = "contextAverages", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "contextAverages")]
        public List<CalculatedMetricRestObject> ContextAverages { get; set; }

        /// <summary>
        /// Gets or Sets CalculatedMetrics
        /// </summary>
        [DataMember(Name = "calculatedMetrics", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "calculatedMetrics")]
        public List<CalculatedMetricRestObject> CalculatedMetrics { get; set; }

        /// <summary>
        /// Gets or Sets InvalidTracks
        /// </summary>
        [DataMember(Name = "invalidTracks", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "invalidTracks")]
        public List<CalculatedMetricRestObject> InvalidTracks { get; set; }

        /// <summary>
        /// Gets or Sets Video
        /// </summary>
        [DataMember(Name = "video", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "video")]
        public IFeedRestObject Video { get; set; }

        /// <summary>
        /// Gets or Sets MetaData
        /// </summary>
        [DataMember(Name = "metaData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "metaData")]
        public StatSplitsRestObject MetaData { get; set; }

        /// <summary>
        /// Gets or Sets PlayResult
        /// </summary>
        [DataMember(Name = "playResult", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playResult")]
        public PlayResultRestObject PlayResult { get; set; }

        /// <summary>
        /// Gets or Sets PlayByPlay
        /// </summary>
        [DataMember(Name = "playByPlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playByPlay")]
        public BaseballPlayRestObject PlayByPlay { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsPlayMetadataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Hydrations: ").Append(Hydrations).Append("\n");
            sb.Append("  GamePk: ").Append(GamePk).Append("\n");
            sb.Append("  GameDate: ").Append(GameDate).Append("\n");
            sb.Append("  TimeCode: ").Append(TimeCode).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  AtBatNumber: ").Append(AtBatNumber).Append("\n");
            sb.Append("  PitchNumber: ").Append(PitchNumber).Append("\n");
            sb.Append("  PickoffNumber: ").Append(PickoffNumber).Append("\n");
            sb.Append("  GameMode: ").Append(GameMode).Append("\n");
            sb.Append("  Inning: ").Append(Inning).Append("\n");
            sb.Append("  IsTopInning: ").Append(IsTopInning).Append("\n");
            sb.Append("  IsPitch: ").Append(IsPitch).Append("\n");
            sb.Append("  IsPickoff: ").Append(IsPickoff).Append("\n");
            sb.Append("  IsHit: ").Append(IsHit).Append("\n");
            sb.Append("  IsManual: ").Append(IsManual).Append("\n");
            sb.Append("  RawFile: ").Append(RawFile).Append("\n");
            sb.Append("  ParsedFile: ").Append(ParsedFile).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  PitchTime: ").Append(PitchTime).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  AuditUpdatedAt: ").Append(AuditUpdatedAt).Append("\n");
            sb.Append("  MetricsUpdatedAt: ").Append(MetricsUpdatedAt).Append("\n");
            sb.Append("  HasUpdates: ").Append(HasUpdates).Append("\n");
            sb.Append("  NumberOfMetricErrors: ").Append(NumberOfMetricErrors).Append("\n");
            sb.Append("  TimeCodeOffset: ").Append(TimeCodeOffset).Append("\n");
            sb.Append("  IsScrubbed: ").Append(IsScrubbed).Append("\n");
            sb.Append("  VideoUpdatedAt: ").Append(VideoUpdatedAt).Append("\n");
            sb.Append("  StrikeZoneInfo: ").Append(StrikeZoneInfo).Append("\n");
            sb.Append("  PitchSegment: ").Append(PitchSegment).Append("\n");
            sb.Append("  HitSegment: ").Append(HitSegment).Append("\n");
            sb.Append("  ContextMetrics: ").Append(ContextMetrics).Append("\n");
            sb.Append("  ContextAverages: ").Append(ContextAverages).Append("\n");
            sb.Append("  CalculatedMetrics: ").Append(CalculatedMetrics).Append("\n");
            sb.Append("  InvalidTracks: ").Append(InvalidTracks).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  PlayResult: ").Append(PlayResult).Append("\n");
            sb.Append("  PlayByPlay: ").Append(PlayByPlay).Append("\n");
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