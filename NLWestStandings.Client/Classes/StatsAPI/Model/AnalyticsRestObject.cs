using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class AnalyticsRestObject
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
        /// Gets or Sets StrikeZoneInfo
        /// </summary>
        [DataMember(Name = "strikeZoneInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikeZoneInfo")]
        public JsonNode StrikeZoneInfo { get; set; }

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
        /// Gets or Sets TargetPositions
        /// </summary>
        [DataMember(Name = "targetPositions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "targetPositions")]
        public List<PositionalMapRestObject> TargetPositions { get; set; }

        /// <summary>
        /// Gets or Sets BallSegments
        /// </summary>
        [DataMember(Name = "ballSegments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ballSegments")]
        public BallPositionalDataRestObject BallSegments { get; set; }

        /// <summary>
        /// Gets or Sets TrackedEvents
        /// </summary>
        [DataMember(Name = "trackedEvents", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trackedEvents")]
        public List<PlayEventRestObject> TrackedEvents { get; set; }

        /// <summary>
        /// Gets or Sets CalculatedMetrics
        /// </summary>
        [DataMember(Name = "calculatedMetrics", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "calculatedMetrics")]
        public CalculatedMetricContainerRestObject CalculatedMetrics { get; set; }

        /// <summary>
        /// Gets or Sets PositionMap
        /// </summary>
        [DataMember(Name = "positionMap", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "positionMap")]
        public Dictionary<string, BaseballPersonRestObject> PositionMap { get; set; }

        /// <summary>
        /// Gets or Sets Diagram
        /// </summary>
        [DataMember(Name = "diagram", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "diagram")]
        public string Diagram { get; set; }

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
        /// Gets or Sets Video
        /// </summary>
        [DataMember(Name = "video", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "video")]
        public IFeedRestObject Video { get; set; }

        /// <summary>
        /// Gets or Sets CalibrationData
        /// </summary>
        [DataMember(Name = "calibrationData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "calibrationData")]
        public CalibrationContainerRestObject CalibrationData { get; set; }

        /// <summary>
        /// Gets or Sets Bat
        /// </summary>
        [DataMember(Name = "bat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bat")]
        public BatTrackingRestObject Bat { get; set; }

        /// <summary>
        /// Gets or Sets Weather
        /// </summary>
        [DataMember(Name = "weather", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "weather")]
        public WeatherWrapperRestObject Weather { get; set; }

        /// <summary>
        /// Gets or Sets SoftwareVersions
        /// </summary>
        [DataMember(Name = "softwareVersions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "softwareVersions")]
        public JsonNode SoftwareVersions { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Hydrations: ").Append(Hydrations).Append("\n");
            sb.Append("  StrikeZoneInfo: ").Append(StrikeZoneInfo).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  PlayResult: ").Append(PlayResult).Append("\n");
            sb.Append("  TargetPositions: ").Append(TargetPositions).Append("\n");
            sb.Append("  BallSegments: ").Append(BallSegments).Append("\n");
            sb.Append("  TrackedEvents: ").Append(TrackedEvents).Append("\n");
            sb.Append("  CalculatedMetrics: ").Append(CalculatedMetrics).Append("\n");
            sb.Append("  PositionMap: ").Append(PositionMap).Append("\n");
            sb.Append("  Diagram: ").Append(Diagram).Append("\n");
            sb.Append("  ContextMetrics: ").Append(ContextMetrics).Append("\n");
            sb.Append("  ContextAverages: ").Append(ContextAverages).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  CalibrationData: ").Append(CalibrationData).Append("\n");
            sb.Append("  Bat: ").Append(Bat).Append("\n");
            sb.Append("  Weather: ").Append(Weather).Append("\n");
            sb.Append("  SoftwareVersions: ").Append(SoftwareVersions).Append("\n");
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