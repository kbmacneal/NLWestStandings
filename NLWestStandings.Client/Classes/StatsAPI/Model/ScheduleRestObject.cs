using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class ScheduleRestObject
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
        /// Gets or Sets TotalItems
        /// </summary>
        [DataMember(Name = "totalItems", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalItems")]
        public int? TotalItems { get; set; }

        /// <summary>
        /// Gets or Sets TotalEvents
        /// </summary>
        [DataMember(Name = "totalEvents", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalEvents")]
        public int? TotalEvents { get; set; }

        /// <summary>
        /// Gets or Sets TotalGames
        /// </summary>
        [DataMember(Name = "totalGames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalGames")]
        public int? TotalGames { get; set; }

        /// <summary>
        /// Gets or Sets TotalGamesInProgress
        /// </summary>
        [DataMember(Name = "totalGamesInProgress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalGamesInProgress")]
        public int? TotalGamesInProgress { get; set; }

        /// <summary>
        /// Gets or Sets Wait
        /// </summary>
        [DataMember(Name = "wait", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wait")]
        public int? Wait { get; set; }

        /// <summary>
        /// Gets or Sets Dates
        /// </summary>
        [DataMember(Name = "dates", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dates")]
        public List<ScheduleDateRestObject> Dates { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Hydrations: ").Append(Hydrations).Append("\n");
            sb.Append("  TotalItems: ").Append(TotalItems).Append("\n");
            sb.Append("  TotalEvents: ").Append(TotalEvents).Append("\n");
            sb.Append("  TotalGames: ").Append(TotalGames).Append("\n");
            sb.Append("  TotalGamesInProgress: ").Append(TotalGamesInProgress).Append("\n");
            sb.Append("  Wait: ").Append(Wait).Append("\n");
            sb.Append("  Dates: ").Append(Dates).Append("\n");
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