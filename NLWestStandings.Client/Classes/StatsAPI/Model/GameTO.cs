using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class GameTO
    {
        /// <summary>
        /// Gets or Sets GameStatusDetail
        /// </summary>
        [DataMember(Name = "gameStatusDetail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameStatusDetail")]
        public string GameStatusDetail { get; set; }

        /// <summary>
        /// Gets or Sets AwayHolds
        /// </summary>
        [DataMember(Name = "awayHolds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayHolds")]
        public List<int?> AwayHolds { get; set; }

        /// <summary>
        /// Gets or Sets HomeHolds
        /// </summary>
        [DataMember(Name = "homeHolds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeHolds")]
        public List<int?> HomeHolds { get; set; }

        /// <summary>
        /// Gets or Sets AwayBlownSaves
        /// </summary>
        [DataMember(Name = "awayBlownSaves", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awayBlownSaves")]
        public List<int?> AwayBlownSaves { get; set; }

        /// <summary>
        /// Gets or Sets HomeBlownSaves
        /// </summary>
        [DataMember(Name = "homeBlownSaves", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeBlownSaves")]
        public List<int?> HomeBlownSaves { get; set; }

        /// <summary>
        /// Gets or Sets GameMinutes
        /// </summary>
        [DataMember(Name = "gameMinutes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameMinutes")]
        public int? GameMinutes { get; set; }

        /// <summary>
        /// Gets or Sets FirstPitchTimeUTC
        /// </summary>
        [DataMember(Name = "firstPitchTimeUTC", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstPitchTimeUTC")]
        public DateTime? FirstPitchTimeUTC { get; set; }

        /// <summary>
        /// Gets or Sets FirstPitchTime
        /// </summary>
        [DataMember(Name = "firstPitchTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstPitchTime")]
        public string FirstPitchTime { get; set; }

        /// <summary>
        /// Gets or Sets TotalMinutes
        /// </summary>
        [DataMember(Name = "totalMinutes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalMinutes")]
        public int? TotalMinutes { get; set; }

        /// <summary>
        /// Gets or Sets DelayMinutes
        /// </summary>
        [DataMember(Name = "delayMinutes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "delayMinutes")]
        public int? DelayMinutes { get; set; }

        /// <summary>
        /// Gets or Sets GamePk
        /// </summary>
        [DataMember(Name = "game_pk", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "game_pk")]
        public int? GamePk { get; set; }

        /// <summary>
        /// Gets or Sets Attendance
        /// </summary>
        [DataMember(Name = "attendance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendance")]
        public int? Attendance { get; set; }

        /// <summary>
        /// Gets or Sets WindDirection
        /// </summary>
        [DataMember(Name = "wind_direction", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wind_direction")]
        public string WindDirection { get; set; }

        /// <summary>
        /// Gets or Sets WindSpeed
        /// </summary>
        [DataMember(Name = "wind_speed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wind_speed")]
        public string WindSpeed { get; set; }

        /// <summary>
        /// Gets or Sets Sky
        /// </summary>
        [DataMember(Name = "sky", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sky")]
        public string Sky { get; set; }

        /// <summary>
        /// Gets or Sets Temperature
        /// </summary>
        [DataMember(Name = "temperature", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "temperature")]
        public string Temperature { get; set; }

        /// <summary>
        /// Gets or Sets GameStatusInd
        /// </summary>
        [DataMember(Name = "game_status_ind", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "game_status_ind")]
        public string GameStatusInd { get; set; }

        /// <summary>
        /// Gets or Sets DelayReason
        /// </summary>
        [DataMember(Name = "delay_reason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "delay_reason")]
        public string DelayReason { get; set; }

        /// <summary>
        /// Gets or Sets OfficialScorer
        /// </summary>
        [DataMember(Name = "official_scorer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "official_scorer")]
        public int? OfficialScorer { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryDatacaster
        /// </summary>
        [DataMember(Name = "primary_datacaster", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "primary_datacaster")]
        public int? PrimaryDatacaster { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryDatacaster
        /// </summary>
        [DataMember(Name = "secondary_datacaster", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "secondary_datacaster")]
        public int? SecondaryDatacaster { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameTO {\n");
            sb.Append("  GameStatusDetail: ").Append(GameStatusDetail).Append("\n");
            sb.Append("  AwayHolds: ").Append(AwayHolds).Append("\n");
            sb.Append("  HomeHolds: ").Append(HomeHolds).Append("\n");
            sb.Append("  AwayBlownSaves: ").Append(AwayBlownSaves).Append("\n");
            sb.Append("  HomeBlownSaves: ").Append(HomeBlownSaves).Append("\n");
            sb.Append("  GameMinutes: ").Append(GameMinutes).Append("\n");
            sb.Append("  FirstPitchTimeUTC: ").Append(FirstPitchTimeUTC).Append("\n");
            sb.Append("  FirstPitchTime: ").Append(FirstPitchTime).Append("\n");
            sb.Append("  TotalMinutes: ").Append(TotalMinutes).Append("\n");
            sb.Append("  DelayMinutes: ").Append(DelayMinutes).Append("\n");
            sb.Append("  GamePk: ").Append(GamePk).Append("\n");
            sb.Append("  Attendance: ").Append(Attendance).Append("\n");
            sb.Append("  WindDirection: ").Append(WindDirection).Append("\n");
            sb.Append("  WindSpeed: ").Append(WindSpeed).Append("\n");
            sb.Append("  Sky: ").Append(Sky).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  GameStatusInd: ").Append(GameStatusInd).Append("\n");
            sb.Append("  DelayReason: ").Append(DelayReason).Append("\n");
            sb.Append("  OfficialScorer: ").Append(OfficialScorer).Append("\n");
            sb.Append("  PrimaryDatacaster: ").Append(PrimaryDatacaster).Append("\n");
            sb.Append("  SecondaryDatacaster: ").Append(SecondaryDatacaster).Append("\n");
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