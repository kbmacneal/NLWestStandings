using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class GameStory
    {
        /// <summary>
        /// Gets or Sets GamePk
        /// </summary>
        [DataMember(Name = "gamePk", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamePk")]
        public int? GamePk { get; set; }

        /// <summary>
        /// Gets or Sets NumStories
        /// </summary>
        [DataMember(Name = "numStories", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numStories")]
        public int? NumStories { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name = "thumbnail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "thumbnail")]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailTemplate
        /// </summary>
        [DataMember(Name = "thumbnailTemplate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "thumbnailTemplate")]
        public string ThumbnailTemplate { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdatedTime
        /// </summary>
        [DataMember(Name = "lastUpdatedTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastUpdatedTime")]
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Pages
        /// </summary>
        [DataMember(Name = "pages", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pages")]
        public int? Pages { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameStory {\n");
            sb.Append("  GamePk: ").Append(GamePk).Append("\n");
            sb.Append("  NumStories: ").Append(NumStories).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  ThumbnailTemplate: ").Append(ThumbnailTemplate).Append("\n");
            sb.Append("  LastUpdatedTime: ").Append(LastUpdatedTime).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
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