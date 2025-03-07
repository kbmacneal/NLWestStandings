using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class CalculatedMetricRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Estimated
        /// </summary>
        [DataMember(Name = "estimated", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "estimated")]
        public bool? Estimated { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        public JsonNode Value { get; set; }

        /// <summary>
        /// Gets or Sets ValueUnrounded
        /// </summary>
        [DataMember(Name = "valueUnrounded", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "valueUnrounded")]
        public string ValueUnrounded { get; set; }

        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// Gets or Sets AverageValue
        /// </summary>
        [DataMember(Name = "averageValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "averageValue")]
        public double? AverageValue { get; set; }

        /// <summary>
        /// Gets or Sets MinValue
        /// </summary>
        [DataMember(Name = "minValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "minValue")]
        public double? MinValue { get; set; }

        /// <summary>
        /// Gets or Sets MaxValue
        /// </summary>
        [DataMember(Name = "maxValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "maxValue")]
        public double? MaxValue { get; set; }

        /// <summary>
        /// Gets or Sets NumOccurrences
        /// </summary>
        [DataMember(Name = "numOccurrences", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numOccurrences")]
        public int? NumOccurrences { get; set; }

        /// <summary>
        /// Gets or Sets Percentile50Value
        /// </summary>
        [DataMember(Name = "percentile50Value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "percentile50Value")]
        public double? Percentile50Value { get; set; }

        /// <summary>
        /// Gets or Sets Percentile75Value
        /// </summary>
        [DataMember(Name = "percentile75Value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "percentile75Value")]
        public double? Percentile75Value { get; set; }

        /// <summary>
        /// Gets or Sets Percentile90Value
        /// </summary>
        [DataMember(Name = "percentile90Value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "percentile90Value")]
        public double? Percentile90Value { get; set; }

        /// <summary>
        /// Gets or Sets CompetitiveValue
        /// </summary>
        [DataMember(Name = "competitiveValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "competitiveValue")]
        public double? CompetitiveValue { get; set; }

        /// <summary>
        /// Gets or Sets NumCompetitiveOccurrences
        /// </summary>
        [DataMember(Name = "numCompetitiveOccurrences", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numCompetitiveOccurrences")]
        public int? NumCompetitiveOccurrences { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets PositionId
        /// </summary>
        [DataMember(Name = "positionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "positionId")]
        public int? PositionId { get; set; }

        /// <summary>
        /// Gets or Sets PlayerId
        /// </summary>
        [DataMember(Name = "playerId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playerId")]
        public int? PlayerId { get; set; }

        /// <summary>
        /// Gets or Sets PlayId
        /// </summary>
        [DataMember(Name = "playId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playId")]
        public string PlayId { get; set; }

        /// <summary>
        /// Gets or Sets MetricId
        /// </summary>
        [DataMember(Name = "metricId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "metricId")]
        public int? MetricId { get; set; }

        /// <summary>
        /// Gets or Sets TimeCode
        /// </summary>
        [DataMember(Name = "timeCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeCode")]
        public long? TimeCode { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets _Base
        /// </summary>
        [DataMember(Name = "base", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "base")]
        public string _Base { get; set; }

        /// <summary>
        /// Gets or Sets IsRadarTracked
        /// </summary>
        [DataMember(Name = "isRadarTracked", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isRadarTracked")]
        public bool? IsRadarTracked { get; set; }

        /// <summary>
        /// Gets or Sets IsHeldOn
        /// </summary>
        [DataMember(Name = "isHeldOn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isHeldOn")]
        public bool? IsHeldOn { get; set; }

        /// <summary>
        /// Gets or Sets IsEstimated
        /// </summary>
        [DataMember(Name = "isEstimated", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isEstimated")]
        public bool? IsEstimated { get; set; }

        /// <summary>
        /// Gets or Sets SupportLevel
        /// </summary>
        [DataMember(Name = "supportLevel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "supportLevel")]
        public string SupportLevel { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalFields
        /// </summary>
        [DataMember(Name = "additionalFields", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalFields")]
        public JsonNode AdditionalFields { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalculatedMetricRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Estimated: ").Append(Estimated).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueUnrounded: ").Append(ValueUnrounded).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  AverageValue: ").Append(AverageValue).Append("\n");
            sb.Append("  MinValue: ").Append(MinValue).Append("\n");
            sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  NumOccurrences: ").Append(NumOccurrences).Append("\n");
            sb.Append("  Percentile50Value: ").Append(Percentile50Value).Append("\n");
            sb.Append("  Percentile75Value: ").Append(Percentile75Value).Append("\n");
            sb.Append("  Percentile90Value: ").Append(Percentile90Value).Append("\n");
            sb.Append("  CompetitiveValue: ").Append(CompetitiveValue).Append("\n");
            sb.Append("  NumCompetitiveOccurrences: ").Append(NumCompetitiveOccurrences).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  PositionId: ").Append(PositionId).Append("\n");
            sb.Append("  PlayerId: ").Append(PlayerId).Append("\n");
            sb.Append("  PlayId: ").Append(PlayId).Append("\n");
            sb.Append("  MetricId: ").Append(MetricId).Append("\n");
            sb.Append("  TimeCode: ").Append(TimeCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  _Base: ").Append(_Base).Append("\n");
            sb.Append("  IsRadarTracked: ").Append(IsRadarTracked).Append("\n");
            sb.Append("  IsHeldOn: ").Append(IsHeldOn).Append("\n");
            sb.Append("  IsEstimated: ").Append(IsEstimated).Append("\n");
            sb.Append("  SupportLevel: ").Append(SupportLevel).Append("\n");
            sb.Append("  AdditionalFields: ").Append(AdditionalFields).Append("\n");
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