using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PostseasonSeries
    {
        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets SeriesId
        /// </summary>
        [DataMember(Name = "seriesId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seriesId")]
        public string SeriesId { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name = "isDefault", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isDefault")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets GameType
        /// </summary>
        [DataMember(Name = "gameType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameType")]
        public GameTypeEnum GameType { get; set; }

        /// <summary>
        /// Gets or Sets SeriesConfigId
        /// </summary>
        [DataMember(Name = "seriesConfigId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seriesConfigId")]
        public string SeriesConfigId { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostseasonSeries {\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  SeriesId: ").Append(SeriesId).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  GameType: ").Append(GameType).Append("\n");
            sb.Append("  SeriesConfigId: ").Append(SeriesConfigId).Append("\n");
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