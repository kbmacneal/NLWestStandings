using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class ScheduleSeriesRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Series
        /// </summary>
        [DataMember(Name = "series", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "series")]
        public PostseasonSeriesRestObject Series { get; set; }

        /// <summary>
        /// Gets or Sets TotalItems
        /// </summary>
        [DataMember(Name = "totalItems", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalItems")]
        public int? TotalItems { get; set; }

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
        /// Gets or Sets Games
        /// </summary>
        [DataMember(Name = "games", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "games")]
        public List<BaseballScheduleItemRestObject> Games { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleSeriesRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Series: ").Append(Series).Append("\n");
            sb.Append("  TotalItems: ").Append(TotalItems).Append("\n");
            sb.Append("  TotalGames: ").Append(TotalGames).Append("\n");
            sb.Append("  TotalGamesInProgress: ").Append(TotalGamesInProgress).Append("\n");
            sb.Append("  Games: ").Append(Games).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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