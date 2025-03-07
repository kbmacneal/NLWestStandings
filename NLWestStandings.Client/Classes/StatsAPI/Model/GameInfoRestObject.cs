using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class GameInfoRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Attendance
        /// </summary>
        [DataMember(Name = "attendance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attendance")]
        public int? Attendance { get; set; }

        /// <summary>
        /// Gets or Sets FirstPitch
        /// </summary>
        [DataMember(Name = "firstPitch", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstPitch")]
        public DateTime? FirstPitch { get; set; }

        /// <summary>
        /// Gets or Sets GameDurationMinutes
        /// </summary>
        [DataMember(Name = "gameDurationMinutes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameDurationMinutes")]
        public int? GameDurationMinutes { get; set; }

        /// <summary>
        /// Gets or Sets DelayDurationMinutes
        /// </summary>
        [DataMember(Name = "delayDurationMinutes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "delayDurationMinutes")]
        public int? DelayDurationMinutes { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameInfoRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Attendance: ").Append(Attendance).Append("\n");
            sb.Append("  FirstPitch: ").Append(FirstPitch).Append("\n");
            sb.Append("  GameDurationMinutes: ").Append(GameDurationMinutes).Append("\n");
            sb.Append("  DelayDurationMinutes: ").Append(DelayDurationMinutes).Append("\n");
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