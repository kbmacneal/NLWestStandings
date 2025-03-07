using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballGameDateTimeRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [DataMember(Name = "dateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dateTime")]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Gets or Sets EndDateTime
        /// </summary>
        [DataMember(Name = "endDateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endDateTime")]
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Gets or Sets OriginalDate
        /// </summary>
        [DataMember(Name = "originalDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "originalDate")]
        public DateTime? OriginalDate { get; set; }

        /// <summary>
        /// Gets or Sets OfficialDate
        /// </summary>
        [DataMember(Name = "officialDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "officialDate")]
        public DateTime? OfficialDate { get; set; }

        /// <summary>
        /// Gets or Sets ResumeDate
        /// </summary>
        [DataMember(Name = "resumeDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resumeDate")]
        public DateTime? ResumeDate { get; set; }

        /// <summary>
        /// Gets or Sets ResumeDateTime
        /// </summary>
        [DataMember(Name = "resumeDateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resumeDateTime")]
        public DateTime? ResumeDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ResumedFromDate
        /// </summary>
        [DataMember(Name = "resumedFromDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resumedFromDate")]
        public DateTime? ResumedFromDate { get; set; }

        /// <summary>
        /// Gets or Sets ResumedFromDateTime
        /// </summary>
        [DataMember(Name = "resumedFromDateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resumedFromDateTime")]
        public DateTime? ResumedFromDateTime { get; set; }

        /// <summary>
        /// Gets or Sets DayNight
        /// </summary>
        [DataMember(Name = "dayNight", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dayNight")]
        public string DayNight { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        /// <summary>
        /// Gets or Sets Ampm
        /// </summary>
        [DataMember(Name = "ampm", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ampm")]
        public string Ampm { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballGameDateTimeRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  OriginalDate: ").Append(OriginalDate).Append("\n");
            sb.Append("  OfficialDate: ").Append(OfficialDate).Append("\n");
            sb.Append("  ResumeDate: ").Append(ResumeDate).Append("\n");
            sb.Append("  ResumeDateTime: ").Append(ResumeDateTime).Append("\n");
            sb.Append("  ResumedFromDate: ").Append(ResumedFromDate).Append("\n");
            sb.Append("  ResumedFromDateTime: ").Append(ResumedFromDateTime).Append("\n");
            sb.Append("  DayNight: ").Append(DayNight).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Ampm: ").Append(Ampm).Append("\n");
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