using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class WeatherConditionFlagRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets HomeRun
        /// </summary>
        [DataMember(Name = "homeRun", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeRun")]
        public bool? HomeRun { get; set; }

        /// <summary>
        /// Gets or Sets HomeRunChange
        /// </summary>
        [DataMember(Name = "homeRunChange", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeRunChange")]
        public bool? HomeRunChange { get; set; }

        /// <summary>
        /// Gets or Sets OffTheWall
        /// </summary>
        [DataMember(Name = "offTheWall", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offTheWall")]
        public bool? OffTheWall { get; set; }

        /// <summary>
        /// Gets or Sets OffTheWallChange
        /// </summary>
        [DataMember(Name = "offTheWallChange", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offTheWallChange")]
        public bool? OffTheWallChange { get; set; }

        /// <summary>
        /// Gets or Sets Foul
        /// </summary>
        [DataMember(Name = "foul", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "foul")]
        public bool? Foul { get; set; }

        /// <summary>
        /// Gets or Sets FoulChange
        /// </summary>
        [DataMember(Name = "foulChange", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "foulChange")]
        public bool? FoulChange { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeatherConditionFlagRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  HomeRun: ").Append(HomeRun).Append("\n");
            sb.Append("  HomeRunChange: ").Append(HomeRunChange).Append("\n");
            sb.Append("  OffTheWall: ").Append(OffTheWall).Append("\n");
            sb.Append("  OffTheWallChange: ").Append(OffTheWallChange).Append("\n");
            sb.Append("  Foul: ").Append(Foul).Append("\n");
            sb.Append("  FoulChange: ").Append(FoulChange).Append("\n");
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