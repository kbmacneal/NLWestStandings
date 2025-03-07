using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballGameRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets GamePk
        /// </summary>
        [DataMember(Name = "gamePk", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamePk")]
        public int? GamePk { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets MetaData
        /// </summary>
        [DataMember(Name = "metaData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "metaData")]
        public BaseballGameMetaDataRestObject MetaData { get; set; }

        /// <summary>
        /// Gets or Sets GameData
        /// </summary>
        [DataMember(Name = "gameData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameData")]
        public BaseballGameDataRestObject GameData { get; set; }

        /// <summary>
        /// Gets or Sets LiveData
        /// </summary>
        [DataMember(Name = "liveData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "liveData")]
        public BaseballGameLiveDataRestObject LiveData { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballGameRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  GamePk: ").Append(GamePk).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  GameData: ").Append(GameData).Append("\n");
            sb.Append("  LiveData: ").Append(LiveData).Append("\n");
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