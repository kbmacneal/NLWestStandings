using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class StatusFlagsRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets IsAllStarGame
        /// </summary>
        [DataMember(Name = "isAllStarGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isAllStarGame")]
        public bool? IsAllStarGame { get; set; }

        /// <summary>
        /// Gets or Sets IsCancelled
        /// </summary>
        [DataMember(Name = "isCancelled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isCancelled")]
        public bool? IsCancelled { get; set; }

        /// <summary>
        /// Gets or Sets IsClassicDoubleHeader
        /// </summary>
        [DataMember(Name = "isClassicDoubleHeader", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isClassicDoubleHeader")]
        public bool? IsClassicDoubleHeader { get; set; }

        /// <summary>
        /// Gets or Sets IsCompletedEarly
        /// </summary>
        [DataMember(Name = "isCompletedEarly", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isCompletedEarly")]
        public bool? IsCompletedEarly { get; set; }

        /// <summary>
        /// Gets or Sets IsDelayed
        /// </summary>
        [DataMember(Name = "isDelayed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isDelayed")]
        public bool? IsDelayed { get; set; }

        /// <summary>
        /// Gets or Sets IsDoubleHeader
        /// </summary>
        [DataMember(Name = "isDoubleHeader", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isDoubleHeader")]
        public bool? IsDoubleHeader { get; set; }

        /// <summary>
        /// Gets or Sets IsNonDoubleHeaderTBD
        /// </summary>
        [DataMember(Name = "isNonDoubleHeaderTBD", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isNonDoubleHeaderTBD")]
        public bool? IsNonDoubleHeaderTBD { get; set; }

        /// <summary>
        /// Gets or Sets IsExhibition
        /// </summary>
        [DataMember(Name = "isExhibition", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isExhibition")]
        public bool? IsExhibition { get; set; }

        /// <summary>
        /// Gets or Sets IsFinal
        /// </summary>
        [DataMember(Name = "isFinal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isFinal")]
        public bool? IsFinal { get; set; }

        /// <summary>
        /// Gets or Sets IsForfeit
        /// </summary>
        [DataMember(Name = "isForfeit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isForfeit")]
        public bool? IsForfeit { get; set; }

        /// <summary>
        /// Gets or Sets IsFreeGame
        /// </summary>
        [DataMember(Name = "isFreeGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isFreeGame")]
        public bool? IsFreeGame { get; set; }

        /// <summary>
        /// Gets or Sets IsGameOver
        /// </summary>
        [DataMember(Name = "isGameOver", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isGameOver")]
        public bool? IsGameOver { get; set; }

        /// <summary>
        /// Gets or Sets IsInstantReplay
        /// </summary>
        [DataMember(Name = "isInstantReplay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isInstantReplay")]
        public bool? IsInstantReplay { get; set; }

        /// <summary>
        /// Gets or Sets IsLive
        /// </summary>
        [DataMember(Name = "isLive", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isLive")]
        public bool? IsLive { get; set; }

        /// <summary>
        /// Gets or Sets IsManagerChallenge
        /// </summary>
        [DataMember(Name = "isManagerChallenge", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isManagerChallenge")]
        public bool? IsManagerChallenge { get; set; }

        /// <summary>
        /// Gets or Sets IsPostponed
        /// </summary>
        [DataMember(Name = "isPostponed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPostponed")]
        public bool? IsPostponed { get; set; }

        /// <summary>
        /// Gets or Sets IsPreview
        /// </summary>
        [DataMember(Name = "isPreview", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPreview")]
        public bool? IsPreview { get; set; }

        /// <summary>
        /// Gets or Sets IsSplitTicketDoubleHeader
        /// </summary>
        [DataMember(Name = "isSplitTicketDoubleHeader", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isSplitTicketDoubleHeader")]
        public bool? IsSplitTicketDoubleHeader { get; set; }

        /// <summary>
        /// Gets or Sets IsSpring
        /// </summary>
        [DataMember(Name = "isSpring", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isSpring")]
        public bool? IsSpring { get; set; }

        /// <summary>
        /// Gets or Sets IsSuspended
        /// </summary>
        [DataMember(Name = "isSuspended", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isSuspended")]
        public bool? IsSuspended { get; set; }

        /// <summary>
        /// Gets or Sets IsSuspendedOnDate
        /// </summary>
        [DataMember(Name = "isSuspendedOnDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isSuspendedOnDate")]
        public bool? IsSuspendedOnDate { get; set; }

        /// <summary>
        /// Gets or Sets IsSuspendedResumptionOnDate
        /// </summary>
        [DataMember(Name = "isSuspendedResumptionOnDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isSuspendedResumptionOnDate")]
        public bool? IsSuspendedResumptionOnDate { get; set; }

        /// <summary>
        /// Gets or Sets IsTBD
        /// </summary>
        [DataMember(Name = "isTBD", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isTBD")]
        public bool? IsTBD { get; set; }

        /// <summary>
        /// Gets or Sets IsTieBreaker
        /// </summary>
        [DataMember(Name = "isTieBreaker", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isTieBreaker")]
        public bool? IsTieBreaker { get; set; }

        /// <summary>
        /// Gets or Sets IsUmpireReview
        /// </summary>
        [DataMember(Name = "isUmpireReview", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isUmpireReview")]
        public bool? IsUmpireReview { get; set; }

        /// <summary>
        /// Gets or Sets IsWarmup
        /// </summary>
        [DataMember(Name = "isWarmup", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isWarmup")]
        public bool? IsWarmup { get; set; }

        /// <summary>
        /// Gets or Sets IsPostSeason
        /// </summary>
        [DataMember(Name = "isPostSeason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPostSeason")]
        public bool? IsPostSeason { get; set; }

        /// <summary>
        /// Gets or Sets IsPostSeasonReady
        /// </summary>
        [DataMember(Name = "isPostSeasonReady", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPostSeasonReady")]
        public bool? IsPostSeasonReady { get; set; }

        /// <summary>
        /// Gets or Sets IsWildCard
        /// </summary>
        [DataMember(Name = "isWildCard", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isWildCard")]
        public bool? IsWildCard { get; set; }

        /// <summary>
        /// Gets or Sets IsDivisionSeries
        /// </summary>
        [DataMember(Name = "isDivisionSeries", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isDivisionSeries")]
        public bool? IsDivisionSeries { get; set; }

        /// <summary>
        /// Gets or Sets IsChampionshopSeries
        /// </summary>
        [DataMember(Name = "isChampionshopSeries", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isChampionshopSeries")]
        public bool? IsChampionshopSeries { get; set; }

        /// <summary>
        /// Gets or Sets IsWorldSeries
        /// </summary>
        [DataMember(Name = "isWorldSeries", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isWorldSeries")]
        public bool? IsWorldSeries { get; set; }

        /// <summary>
        /// Gets or Sets IsPreGameDelay
        /// </summary>
        [DataMember(Name = "isPreGameDelay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPreGameDelay")]
        public bool? IsPreGameDelay { get; set; }

        /// <summary>
        /// Gets or Sets IsInGameDelay
        /// </summary>
        [DataMember(Name = "isInGameDelay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isInGameDelay")]
        public bool? IsInGameDelay { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusFlagsRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  IsAllStarGame: ").Append(IsAllStarGame).Append("\n");
            sb.Append("  IsCancelled: ").Append(IsCancelled).Append("\n");
            sb.Append("  IsClassicDoubleHeader: ").Append(IsClassicDoubleHeader).Append("\n");
            sb.Append("  IsCompletedEarly: ").Append(IsCompletedEarly).Append("\n");
            sb.Append("  IsDelayed: ").Append(IsDelayed).Append("\n");
            sb.Append("  IsDoubleHeader: ").Append(IsDoubleHeader).Append("\n");
            sb.Append("  IsNonDoubleHeaderTBD: ").Append(IsNonDoubleHeaderTBD).Append("\n");
            sb.Append("  IsExhibition: ").Append(IsExhibition).Append("\n");
            sb.Append("  IsFinal: ").Append(IsFinal).Append("\n");
            sb.Append("  IsForfeit: ").Append(IsForfeit).Append("\n");
            sb.Append("  IsFreeGame: ").Append(IsFreeGame).Append("\n");
            sb.Append("  IsGameOver: ").Append(IsGameOver).Append("\n");
            sb.Append("  IsInstantReplay: ").Append(IsInstantReplay).Append("\n");
            sb.Append("  IsLive: ").Append(IsLive).Append("\n");
            sb.Append("  IsManagerChallenge: ").Append(IsManagerChallenge).Append("\n");
            sb.Append("  IsPostponed: ").Append(IsPostponed).Append("\n");
            sb.Append("  IsPreview: ").Append(IsPreview).Append("\n");
            sb.Append("  IsSplitTicketDoubleHeader: ").Append(IsSplitTicketDoubleHeader).Append("\n");
            sb.Append("  IsSpring: ").Append(IsSpring).Append("\n");
            sb.Append("  IsSuspended: ").Append(IsSuspended).Append("\n");
            sb.Append("  IsSuspendedOnDate: ").Append(IsSuspendedOnDate).Append("\n");
            sb.Append("  IsSuspendedResumptionOnDate: ").Append(IsSuspendedResumptionOnDate).Append("\n");
            sb.Append("  IsTBD: ").Append(IsTBD).Append("\n");
            sb.Append("  IsTieBreaker: ").Append(IsTieBreaker).Append("\n");
            sb.Append("  IsUmpireReview: ").Append(IsUmpireReview).Append("\n");
            sb.Append("  IsWarmup: ").Append(IsWarmup).Append("\n");
            sb.Append("  IsPostSeason: ").Append(IsPostSeason).Append("\n");
            sb.Append("  IsPostSeasonReady: ").Append(IsPostSeasonReady).Append("\n");
            sb.Append("  IsWildCard: ").Append(IsWildCard).Append("\n");
            sb.Append("  IsDivisionSeries: ").Append(IsDivisionSeries).Append("\n");
            sb.Append("  IsChampionshopSeries: ").Append(IsChampionshopSeries).Append("\n");
            sb.Append("  IsWorldSeries: ").Append(IsWorldSeries).Append("\n");
            sb.Append("  IsPreGameDelay: ").Append(IsPreGameDelay).Append("\n");
            sb.Append("  IsInGameDelay: ").Append(IsInGameDelay).Append("\n");
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