using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Award
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "results")]
        public List<AwardResult> Results { get; set; }

        /// <summary>
        /// Gets or Sets Winners
        /// </summary>
        [DataMember(Name = "winners", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "winners")]
        public List<AwardWinner> Winners { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name = "shortName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets RecipientType
        /// </summary>
        [DataMember(Name = "recipientType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recipientType")]
        public string RecipientType { get; set; }

        /// <summary>
        /// Gets or Sets History
        /// </summary>
        [DataMember(Name = "history", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "history")]
        public string History { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeam Team { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets HomePageUrl
        /// </summary>
        [DataMember(Name = "homePageUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homePageUrl")]
        public string HomePageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "player")]
        public BaseballPerson Player { get; set; }

        /// <summary>
        /// Gets or Sets Votes
        /// </summary>
        [DataMember(Name = "votes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "votes")]
        public int? Votes { get; set; }

        /// <summary>
        /// Gets or Sets VotesAvailable
        /// </summary>
        [DataMember(Name = "votesAvailable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "votesAvailable")]
        public int? VotesAvailable { get; set; }

        /// <summary>
        /// Gets or Sets Sport
        /// </summary>
        [DataMember(Name = "sport", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sport")]
        public Sport Sport { get; set; }

        /// <summary>
        /// Gets or Sets League
        /// </summary>
        [DataMember(Name = "league", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "league")]
        public League League { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "organizationId")]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets UserPrivileges
        /// </summary>
        [DataMember(Name = "userPrivileges", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "userPrivileges")]
        public List<Privilege> UserPrivileges { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Award {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Winners: ").Append(Winners).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RecipientType: ").Append(RecipientType).Append("\n");
            sb.Append("  History: ").Append(History).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  HomePageUrl: ").Append(HomePageUrl).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Votes: ").Append(Votes).Append("\n");
            sb.Append("  VotesAvailable: ").Append(VotesAvailable).Append("\n");
            sb.Append("  Sport: ").Append(Sport).Append("\n");
            sb.Append("  League: ").Append(League).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  UserPrivileges: ").Append(UserPrivileges).Append("\n");
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