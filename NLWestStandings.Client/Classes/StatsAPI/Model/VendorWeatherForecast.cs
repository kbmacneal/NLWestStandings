using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class VendorWeatherForecast
    {
        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name = "gameId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameId")]
        public int? GameId { get; set; }

        /// <summary>
        /// Gets or Sets ForecastTimestamp
        /// </summary>
        [DataMember(Name = "forecastTimestamp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "forecastTimestamp")]
        public DateTime? ForecastTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets AdjustedPrecipitationProbability
        /// </summary>
        [DataMember(Name = "adjustedPrecipitationProbability", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "adjustedPrecipitationProbability")]
        public int? AdjustedPrecipitationProbability { get; set; }

        /// <summary>
        /// Gets or Sets CloudCoverPercentage
        /// </summary>
        [DataMember(Name = "cloudCoverPercentage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cloudCoverPercentage")]
        public int? CloudCoverPercentage { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Dewpoint
        /// </summary>
        [DataMember(Name = "dewpoint", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dewpoint")]
        public double? Dewpoint { get; set; }

        /// <summary>
        /// Gets or Sets TemperatureFeelsLike
        /// </summary>
        [DataMember(Name = "temperatureFeelsLike", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "temperatureFeelsLike")]
        public double? TemperatureFeelsLike { get; set; }

        /// <summary>
        /// Gets or Sets SkyConditionIconId
        /// </summary>
        [DataMember(Name = "skyConditionIconId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "skyConditionIconId")]
        public int? SkyConditionIconId { get; set; }

        /// <summary>
        /// Gets or Sets PrecipitationId
        /// </summary>
        [DataMember(Name = "precipitationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "precipitationId")]
        public int? PrecipitationId { get; set; }

        /// <summary>
        /// Gets or Sets PrecipitationProbability
        /// </summary>
        [DataMember(Name = "precipitationProbability", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "precipitationProbability")]
        public int? PrecipitationProbability { get; set; }

        /// <summary>
        /// Gets or Sets PrecipitationRate
        /// </summary>
        [DataMember(Name = "precipitationRate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "precipitationRate")]
        public double? PrecipitationRate { get; set; }

        /// <summary>
        /// Gets or Sets RelativeHumidity
        /// </summary>
        [DataMember(Name = "relativeHumidity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "relativeHumidity")]
        public int? RelativeHumidity { get; set; }

        /// <summary>
        /// Gets or Sets Temperature
        /// </summary>
        [DataMember(Name = "temperature", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Gets or Sets ThunderstormProbability
        /// </summary>
        [DataMember(Name = "thunderstormProbability", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "thunderstormProbability")]
        public int? ThunderstormProbability { get; set; }

        /// <summary>
        /// Gets or Sets WindDirectionDegrees
        /// </summary>
        [DataMember(Name = "windDirectionDegrees", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "windDirectionDegrees")]
        public int? WindDirectionDegrees { get; set; }

        /// <summary>
        /// Gets or Sets WindSpeed
        /// </summary>
        [DataMember(Name = "windSpeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "windSpeed")]
        public double? WindSpeed { get; set; }

        /// <summary>
        /// Gets or Sets SurfacePressure
        /// </summary>
        [DataMember(Name = "surfacePressure", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "surfacePressure")]
        public double? SurfacePressure { get; set; }

        /// <summary>
        /// Gets or Sets SnowRate
        /// </summary>
        [DataMember(Name = "snowRate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "snowRate")]
        public double? SnowRate { get; set; }

        /// <summary>
        /// Gets or Sets WetBulbGlobeTemperature
        /// </summary>
        [DataMember(Name = "wetBulbGlobeTemperature", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wetBulbGlobeTemperature")]
        public double? WetBulbGlobeTemperature { get; set; }

        /// <summary>
        /// Gets or Sets WetBulbTemperature
        /// </summary>
        [DataMember(Name = "wetBulbTemperature", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wetBulbTemperature")]
        public double? WetBulbTemperature { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VendorWeatherForecast {\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  ForecastTimestamp: ").Append(ForecastTimestamp).Append("\n");
            sb.Append("  AdjustedPrecipitationProbability: ").Append(AdjustedPrecipitationProbability).Append("\n");
            sb.Append("  CloudCoverPercentage: ").Append(CloudCoverPercentage).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Dewpoint: ").Append(Dewpoint).Append("\n");
            sb.Append("  TemperatureFeelsLike: ").Append(TemperatureFeelsLike).Append("\n");
            sb.Append("  SkyConditionIconId: ").Append(SkyConditionIconId).Append("\n");
            sb.Append("  PrecipitationId: ").Append(PrecipitationId).Append("\n");
            sb.Append("  PrecipitationProbability: ").Append(PrecipitationProbability).Append("\n");
            sb.Append("  PrecipitationRate: ").Append(PrecipitationRate).Append("\n");
            sb.Append("  RelativeHumidity: ").Append(RelativeHumidity).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  ThunderstormProbability: ").Append(ThunderstormProbability).Append("\n");
            sb.Append("  WindDirectionDegrees: ").Append(WindDirectionDegrees).Append("\n");
            sb.Append("  WindSpeed: ").Append(WindSpeed).Append("\n");
            sb.Append("  SurfacePressure: ").Append(SurfacePressure).Append("\n");
            sb.Append("  SnowRate: ").Append(SnowRate).Append("\n");
            sb.Append("  WetBulbGlobeTemperature: ").Append(WetBulbGlobeTemperature).Append("\n");
            sb.Append("  WetBulbTemperature: ").Append(WetBulbTemperature).Append("\n");
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