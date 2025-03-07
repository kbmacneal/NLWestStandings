using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballGameDataGameRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Pk
        /// </summary>
        [DataMember(Name = "pk", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pk")]
        public int? Pk { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets DoubleHeader
        /// </summary>
        [DataMember(Name = "doubleHeader", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "doubleHeader")]
        public string DoubleHeader { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets GamedayType
        /// </summary>
        [DataMember(Name = "gamedayType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamedayType")]
        public string GamedayType { get; set; }

        /// <summary>
        /// Gets or Sets Tiebreaker
        /// </summary>
        [DataMember(Name = "tiebreaker", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tiebreaker")]
        public string Tiebreaker { get; set; }

        /// <summary>
        /// Gets or Sets GameNumber
        /// </summary>
        [DataMember(Name = "gameNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameNumber")]
        public int? GameNumber { get; set; }

        /// <summary>
        /// Gets or Sets CalendarEventID
        /// </summary>
        [DataMember(Name = "calendarEventID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "calendarEventID")]
        public string CalendarEventID { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or Sets SeasonDisplay
        /// </summary>
        [DataMember(Name = "seasonDisplay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seasonDisplay")]
        public string SeasonDisplay { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballGameDataGameRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Pk: ").Append(Pk).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DoubleHeader: ").Append(DoubleHeader).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GamedayType: ").Append(GamedayType).Append("\n");
            sb.Append("  Tiebreaker: ").Append(Tiebreaker).Append("\n");
            sb.Append("  GameNumber: ").Append(GameNumber).Append("\n");
            sb.Append("  CalendarEventID: ").Append(CalendarEventID).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  SeasonDisplay: ").Append(SeasonDisplay).Append("\n");
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