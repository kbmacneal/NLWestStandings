using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballInning
    {
        /// <summary>
        /// Gets or Sets RunsAway
        /// </summary>
        [DataMember(Name = "runsAway", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runsAway")]
        public int? RunsAway { get; set; }

        /// <summary>
        /// Gets or Sets RunsHome
        /// </summary>
        [DataMember(Name = "runsHome", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runsHome")]
        public int? RunsHome { get; set; }

        /// <summary>
        /// Gets or Sets HitsAway
        /// </summary>
        [DataMember(Name = "hitsAway", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitsAway")]
        public int? HitsAway { get; set; }

        /// <summary>
        /// Gets or Sets HitsHome
        /// </summary>
        [DataMember(Name = "hitsHome", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitsHome")]
        public int? HitsHome { get; set; }

        /// <summary>
        /// Gets or Sets ErrorsAway
        /// </summary>
        [DataMember(Name = "errorsAway", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorsAway")]
        public int? ErrorsAway { get; set; }

        /// <summary>
        /// Gets or Sets ErrorsHome
        /// </summary>
        [DataMember(Name = "errorsHome", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorsHome")]
        public int? ErrorsHome { get; set; }

        /// <summary>
        /// Gets or Sets LeftOnBaseAway
        /// </summary>
        [DataMember(Name = "leftOnBaseAway", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leftOnBaseAway")]
        public int? LeftOnBaseAway { get; set; }

        /// <summary>
        /// Gets or Sets LeftOnBaseHome
        /// </summary>
        [DataMember(Name = "leftOnBaseHome", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leftOnBaseHome")]
        public int? LeftOnBaseHome { get; set; }

        /// <summary>
        /// Gets or Sets Num
        /// </summary>
        [DataMember(Name = "num", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "num")]
        public int? Num { get; set; }

        /// <summary>
        /// Gets or Sets OrdinalNum
        /// </summary>
        [DataMember(Name = "ordinalNum", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ordinalNum")]
        public string OrdinalNum { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballInning {\n");
            sb.Append("  RunsAway: ").Append(RunsAway).Append("\n");
            sb.Append("  RunsHome: ").Append(RunsHome).Append("\n");
            sb.Append("  HitsAway: ").Append(HitsAway).Append("\n");
            sb.Append("  HitsHome: ").Append(HitsHome).Append("\n");
            sb.Append("  ErrorsAway: ").Append(ErrorsAway).Append("\n");
            sb.Append("  ErrorsHome: ").Append(ErrorsHome).Append("\n");
            sb.Append("  LeftOnBaseAway: ").Append(LeftOnBaseAway).Append("\n");
            sb.Append("  LeftOnBaseHome: ").Append(LeftOnBaseHome).Append("\n");
            sb.Append("  Num: ").Append(Num).Append("\n");
            sb.Append("  OrdinalNum: ").Append(OrdinalNum).Append("\n");
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