using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Season
    {
        /// <summary>
        /// Gets or Sets SeasonId
        /// </summary>
        [DataMember(Name = "seasonId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seasonId")]
        public string SeasonId { get; set; }

        /// <summary>
        /// Gets or Sets HasWildcard
        /// </summary>
        [DataMember(Name = "hasWildcard", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasWildcard")]
        public bool? HasWildcard { get; set; }

        /// <summary>
        /// Gets or Sets SpringStartDate
        /// </summary>
        [DataMember(Name = "springStartDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "springStartDate")]
        public DateTime? SpringStartDate { get; set; }

        /// <summary>
        /// Gets or Sets SpringEndDate
        /// </summary>
        [DataMember(Name = "springEndDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "springEndDate")]
        public DateTime? SpringEndDate { get; set; }

        /// <summary>
        /// Gets or Sets OffSeasonStartDate
        /// </summary>
        [DataMember(Name = "offSeasonStartDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offSeasonStartDate")]
        public DateTime? OffSeasonStartDate { get; set; }

        /// <summary>
        /// Gets or Sets OffSeasonEndDate
        /// </summary>
        [DataMember(Name = "offSeasonEndDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offSeasonEndDate")]
        public DateTime? OffSeasonEndDate { get; set; }

        /// <summary>
        /// Gets or Sets RegularSeasonStartDate
        /// </summary>
        [DataMember(Name = "regularSeasonStartDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "regularSeasonStartDate")]
        public DateTime? RegularSeasonStartDate { get; set; }

        /// <summary>
        /// Gets or Sets RegularSeasonEndDate
        /// </summary>
        [DataMember(Name = "regularSeasonEndDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "regularSeasonEndDate")]
        public DateTime? RegularSeasonEndDate { get; set; }

        /// <summary>
        /// Gets or Sets SeasonStartDate
        /// </summary>
        [DataMember(Name = "seasonStartDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seasonStartDate")]
        public DateTime? SeasonStartDate { get; set; }

        /// <summary>
        /// Gets or Sets SeasonEndDate
        /// </summary>
        [DataMember(Name = "seasonEndDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seasonEndDate")]
        public DateTime? SeasonEndDate { get; set; }

        /// <summary>
        /// Gets or Sets PreSeasonStartDate
        /// </summary>
        [DataMember(Name = "preSeasonStartDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "preSeasonStartDate")]
        public DateTime? PreSeasonStartDate { get; set; }

        /// <summary>
        /// Gets or Sets PreSeasonEndDate
        /// </summary>
        [DataMember(Name = "preSeasonEndDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "preSeasonEndDate")]
        public DateTime? PreSeasonEndDate { get; set; }

        /// <summary>
        /// Gets or Sets PostSeasonStartDate
        /// </summary>
        [DataMember(Name = "postSeasonStartDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postSeasonStartDate")]
        public DateTime? PostSeasonStartDate { get; set; }

        /// <summary>
        /// Gets or Sets PostSeasonEndDate
        /// </summary>
        [DataMember(Name = "postSeasonEndDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postSeasonEndDate")]
        public DateTime? PostSeasonEndDate { get; set; }

        /// <summary>
        /// Gets or Sets LastDate1stHalf
        /// </summary>
        [DataMember(Name = "lastDate1stHalf", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastDate1stHalf")]
        public DateTime? LastDate1stHalf { get; set; }

        /// <summary>
        /// Gets or Sets FirstDate2ndHalf
        /// </summary>
        [DataMember(Name = "firstDate2ndHalf", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstDate2ndHalf")]
        public DateTime? FirstDate2ndHalf { get; set; }

        /// <summary>
        /// Gets or Sets AllStarDate
        /// </summary>
        [DataMember(Name = "allStarDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "allStarDate")]
        public DateTime? AllStarDate { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfGames
        /// </summary>
        [DataMember(Name = "numberOfGames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numberOfGames")]
        public int? NumberOfGames { get; set; }

        /// <summary>
        /// Gets or Sets OlympicsParticipation
        /// </summary>
        [DataMember(Name = "olympicsParticipation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "olympicsParticipation")]
        public bool? OlympicsParticipation { get; set; }

        /// <summary>
        /// Gets or Sets TiesInUse
        /// </summary>
        [DataMember(Name = "tiesInUse", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tiesInUse")]
        public bool? TiesInUse { get; set; }

        /// <summary>
        /// Gets or Sets ConferencesInUse
        /// </summary>
        [DataMember(Name = "conferencesInUse", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "conferencesInUse")]
        public bool? ConferencesInUse { get; set; }

        /// <summary>
        /// Gets or Sets DivisionsInUse
        /// </summary>
        [DataMember(Name = "divisionsInUse", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "divisionsInUse")]
        public bool? DivisionsInUse { get; set; }

        /// <summary>
        /// Gets or Sets GameTypeDates
        /// </summary>
        [DataMember(Name = "gameTypeDates", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameTypeDates")]
        public List<GameTypeDates> GameTypeDates { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "organizationId")]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets SeasonLevelGamedayType
        /// </summary>
        [DataMember(Name = "seasonLevelGamedayType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seasonLevelGamedayType")]
        public string SeasonLevelGamedayType { get; set; }

        /// <summary>
        /// Gets or Sets GameLevelGamedayType
        /// </summary>
        [DataMember(Name = "gameLevelGamedayType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameLevelGamedayType")]
        public string GameLevelGamedayType { get; set; }

        /// <summary>
        /// Gets or Sets QualifierPlateAppearances
        /// </summary>
        [DataMember(Name = "qualifierPlateAppearances", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "qualifierPlateAppearances")]
        public double? QualifierPlateAppearances { get; set; }

        /// <summary>
        /// Gets or Sets QualifierOutsPitched
        /// </summary>
        [DataMember(Name = "qualifierOutsPitched", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "qualifierOutsPitched")]
        public double? QualifierOutsPitched { get; set; }

        /// <summary>
        /// Gets or Sets QualifierInningsPitched
        /// </summary>
        [DataMember(Name = "qualifierInningsPitched", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "qualifierInningsPitched")]
        public double? QualifierInningsPitched { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Season {\n");
            sb.Append("  SeasonId: ").Append(SeasonId).Append("\n");
            sb.Append("  HasWildcard: ").Append(HasWildcard).Append("\n");
            sb.Append("  SpringStartDate: ").Append(SpringStartDate).Append("\n");
            sb.Append("  SpringEndDate: ").Append(SpringEndDate).Append("\n");
            sb.Append("  OffSeasonStartDate: ").Append(OffSeasonStartDate).Append("\n");
            sb.Append("  OffSeasonEndDate: ").Append(OffSeasonEndDate).Append("\n");
            sb.Append("  RegularSeasonStartDate: ").Append(RegularSeasonStartDate).Append("\n");
            sb.Append("  RegularSeasonEndDate: ").Append(RegularSeasonEndDate).Append("\n");
            sb.Append("  SeasonStartDate: ").Append(SeasonStartDate).Append("\n");
            sb.Append("  SeasonEndDate: ").Append(SeasonEndDate).Append("\n");
            sb.Append("  PreSeasonStartDate: ").Append(PreSeasonStartDate).Append("\n");
            sb.Append("  PreSeasonEndDate: ").Append(PreSeasonEndDate).Append("\n");
            sb.Append("  PostSeasonStartDate: ").Append(PostSeasonStartDate).Append("\n");
            sb.Append("  PostSeasonEndDate: ").Append(PostSeasonEndDate).Append("\n");
            sb.Append("  LastDate1stHalf: ").Append(LastDate1stHalf).Append("\n");
            sb.Append("  FirstDate2ndHalf: ").Append(FirstDate2ndHalf).Append("\n");
            sb.Append("  AllStarDate: ").Append(AllStarDate).Append("\n");
            sb.Append("  NumberOfGames: ").Append(NumberOfGames).Append("\n");
            sb.Append("  OlympicsParticipation: ").Append(OlympicsParticipation).Append("\n");
            sb.Append("  TiesInUse: ").Append(TiesInUse).Append("\n");
            sb.Append("  ConferencesInUse: ").Append(ConferencesInUse).Append("\n");
            sb.Append("  DivisionsInUse: ").Append(DivisionsInUse).Append("\n");
            sb.Append("  GameTypeDates: ").Append(GameTypeDates).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  SeasonLevelGamedayType: ").Append(SeasonLevelGamedayType).Append("\n");
            sb.Append("  GameLevelGamedayType: ").Append(GameLevelGamedayType).Append("\n");
            sb.Append("  QualifierPlateAppearances: ").Append(QualifierPlateAppearances).Append("\n");
            sb.Append("  QualifierOutsPitched: ").Append(QualifierOutsPitched).Append("\n");
            sb.Append("  QualifierInningsPitched: ").Append(QualifierInningsPitched).Append("\n");
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