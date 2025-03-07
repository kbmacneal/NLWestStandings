using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PromotionRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets OfferId
        /// </summary>
        [DataMember(Name = "offerId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offerId")]
        public int? OfferId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets AltPageUrl
        /// </summary>
        [DataMember(Name = "altPageUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "altPageUrl")]
        public string AltPageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Tlink
        /// </summary>
        [DataMember(Name = "tlink", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tlink")]
        public string Tlink { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "order")]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or Sets PresentedBy
        /// </summary>
        [DataMember(Name = "presentedBy", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "presentedBy")]
        public string PresentedBy { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailUrl
        /// </summary>
        [DataMember(Name = "thumbnailUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or Sets OfferType
        /// </summary>
        [DataMember(Name = "offerType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offerType")]
        public string OfferType { get; set; }

        /// <summary>
        /// Gets or Sets Distribution
        /// </summary>
        [DataMember(Name = "distribution", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "distribution")]
        public string Distribution { get; set; }

        /// <summary>
        /// Gets or Sets SortKey
        /// </summary>
        [DataMember(Name = "sortKey", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortKey")]
        public string SortKey { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name = "teamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teamId")]
        public int? TeamId { get; set; }

        /// <summary>
        /// Gets or Sets DisplayIfPast
        /// </summary>
        [DataMember(Name = "displayIfPast", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayIfPast")]
        public bool? DisplayIfPast { get; set; }

        /// <summary>
        /// Gets or Sets Other
        /// </summary>
        [DataMember(Name = "other", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "other")]
        public string Other { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PromotionRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  OfferId: ").Append(OfferId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AltPageUrl: ").Append(AltPageUrl).Append("\n");
            sb.Append("  Tlink: ").Append(Tlink).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  PresentedBy: ").Append(PresentedBy).Append("\n");
            sb.Append("  ThumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
            sb.Append("  OfferType: ").Append(OfferType).Append("\n");
            sb.Append("  Distribution: ").Append(Distribution).Append("\n");
            sb.Append("  SortKey: ").Append(SortKey).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  DisplayIfPast: ").Append(DisplayIfPast).Append("\n");
            sb.Append("  Other: ").Append(Other).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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