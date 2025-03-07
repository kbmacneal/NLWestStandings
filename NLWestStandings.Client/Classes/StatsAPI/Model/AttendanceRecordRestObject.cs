using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class AttendanceRecordRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets OpeningsTotal7day
        /// </summary>
        [DataMember(Name = "openingsTotal7day", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "openingsTotal7day")]
        public int? OpeningsTotal7day { get; set; }

        /// <summary>
        /// Gets or Sets OpeningsTotal
        /// </summary>
        [DataMember(Name = "openingsTotal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "openingsTotal")]
        public int? OpeningsTotal { get; set; }

        /// <summary>
        /// Gets or Sets OpeningsTotalAway
        /// </summary>
        [DataMember(Name = "openingsTotalAway", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "openingsTotalAway")]
        public int? OpeningsTotalAway { get; set; }

        /// <summary>
        /// Gets or Sets OpeningsTotalHome
        /// </summary>
        [DataMember(Name = "openingsTotalHome", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "openingsTotalHome")]
        public int? OpeningsTotalHome { get; set; }

        /// <summary>
        /// Gets or Sets OpeningsTotalLost
        /// </summary>
        [DataMember(Name = "openingsTotalLost", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "openingsTotalLost")]
        public int? OpeningsTotalLost { get; set; }

        /// <summary>
        /// Gets or Sets OpeningsTotalYtd
        /// </summary>
        [DataMember(Name = "openingsTotalYtd", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "openingsTotalYtd")]
        public int? OpeningsTotalYtd { get; set; }

        /// <summary>
        /// Gets or Sets GamesTotal
        /// </summary>
        [DataMember(Name = "gamesTotal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamesTotal")]
        public int? GamesTotal { get; set; }

        /// <summary>
        /// Gets or Sets GamesAwayTotal
        /// </summary>
        [DataMember(Name = "gamesAwayTotal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamesAwayTotal")]
        public int? GamesAwayTotal { get; set; }

        /// <summary>
        /// Gets or Sets GamesHomeTotal
        /// </summary>
        [DataMember(Name = "gamesHomeTotal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamesHomeTotal")]
        public int? GamesHomeTotal { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "year")]
        public string Year { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceAverageAway
        /// </summary>
        [DataMember(Name = "attendanceAverageAway", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceAverageAway")]
        public int? AttendanceAverageAway { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceAverageHome
        /// </summary>
        [DataMember(Name = "attendanceAverageHome", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceAverageHome")]
        public int? AttendanceAverageHome { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceAverageYtd
        /// </summary>
        [DataMember(Name = "attendanceAverageYtd", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceAverageYtd")]
        public int? AttendanceAverageYtd { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceHigh
        /// </summary>
        [DataMember(Name = "attendanceHigh", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceHigh")]
        public int? AttendanceHigh { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceHighDate
        /// </summary>
        [DataMember(Name = "attendanceHighDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceHighDate")]
        public string AttendanceHighDate { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceHighGame
        /// </summary>
        [DataMember(Name = "attendanceHighGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceHighGame")]
        public BaseballScheduleItemRestObject AttendanceHighGame { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceLow
        /// </summary>
        [DataMember(Name = "attendanceLow", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceLow")]
        public int? AttendanceLow { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceLowDate
        /// </summary>
        [DataMember(Name = "attendanceLowDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceLowDate")]
        public string AttendanceLowDate { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceLowGame
        /// </summary>
        [DataMember(Name = "attendanceLowGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceLowGame")]
        public BaseballScheduleItemRestObject AttendanceLowGame { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceOpening7dayAvg
        /// </summary>
        [DataMember(Name = "attendanceOpening7dayAvg", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceOpening7dayAvg")]
        public int? AttendanceOpening7dayAvg { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceOpeningAverage
        /// </summary>
        [DataMember(Name = "attendanceOpeningAverage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceOpeningAverage")]
        public int? AttendanceOpeningAverage { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceTotal7day
        /// </summary>
        [DataMember(Name = "attendanceTotal7day", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceTotal7day")]
        public int? AttendanceTotal7day { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceTotal
        /// </summary>
        [DataMember(Name = "attendanceTotal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceTotal")]
        public int? AttendanceTotal { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceTotalAway
        /// </summary>
        [DataMember(Name = "attendanceTotalAway", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceTotalAway")]
        public int? AttendanceTotalAway { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceTotalHome
        /// </summary>
        [DataMember(Name = "attendanceTotalHome", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceTotalHome")]
        public int? AttendanceTotalHome { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceTotalYesterday
        /// </summary>
        [DataMember(Name = "attendanceTotalYesterday", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceTotalYesterday")]
        public int? AttendanceTotalYesterday { get; set; }

        /// <summary>
        /// Gets or Sets AttendanceTotalYtd
        /// </summary>
        [DataMember(Name = "attendanceTotalYtd", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendanceTotalYtd")]
        public int? AttendanceTotalYtd { get; set; }

        /// <summary>
        /// Gets or Sets GameType
        /// </summary>
        [DataMember(Name = "gameType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameType")]
        public GameTypeEnum GameType { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeamRestObject Team { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttendanceRecordRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  OpeningsTotal7day: ").Append(OpeningsTotal7day).Append("\n");
            sb.Append("  OpeningsTotal: ").Append(OpeningsTotal).Append("\n");
            sb.Append("  OpeningsTotalAway: ").Append(OpeningsTotalAway).Append("\n");
            sb.Append("  OpeningsTotalHome: ").Append(OpeningsTotalHome).Append("\n");
            sb.Append("  OpeningsTotalLost: ").Append(OpeningsTotalLost).Append("\n");
            sb.Append("  OpeningsTotalYtd: ").Append(OpeningsTotalYtd).Append("\n");
            sb.Append("  GamesTotal: ").Append(GamesTotal).Append("\n");
            sb.Append("  GamesAwayTotal: ").Append(GamesAwayTotal).Append("\n");
            sb.Append("  GamesHomeTotal: ").Append(GamesHomeTotal).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  AttendanceAverageAway: ").Append(AttendanceAverageAway).Append("\n");
            sb.Append("  AttendanceAverageHome: ").Append(AttendanceAverageHome).Append("\n");
            sb.Append("  AttendanceAverageYtd: ").Append(AttendanceAverageYtd).Append("\n");
            sb.Append("  AttendanceHigh: ").Append(AttendanceHigh).Append("\n");
            sb.Append("  AttendanceHighDate: ").Append(AttendanceHighDate).Append("\n");
            sb.Append("  AttendanceHighGame: ").Append(AttendanceHighGame).Append("\n");
            sb.Append("  AttendanceLow: ").Append(AttendanceLow).Append("\n");
            sb.Append("  AttendanceLowDate: ").Append(AttendanceLowDate).Append("\n");
            sb.Append("  AttendanceLowGame: ").Append(AttendanceLowGame).Append("\n");
            sb.Append("  AttendanceOpening7dayAvg: ").Append(AttendanceOpening7dayAvg).Append("\n");
            sb.Append("  AttendanceOpeningAverage: ").Append(AttendanceOpeningAverage).Append("\n");
            sb.Append("  AttendanceTotal7day: ").Append(AttendanceTotal7day).Append("\n");
            sb.Append("  AttendanceTotal: ").Append(AttendanceTotal).Append("\n");
            sb.Append("  AttendanceTotalAway: ").Append(AttendanceTotalAway).Append("\n");
            sb.Append("  AttendanceTotalHome: ").Append(AttendanceTotalHome).Append("\n");
            sb.Append("  AttendanceTotalYesterday: ").Append(AttendanceTotalYesterday).Append("\n");
            sb.Append("  AttendanceTotalYtd: ").Append(AttendanceTotalYtd).Append("\n");
            sb.Append("  GameType: ").Append(GameType).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
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