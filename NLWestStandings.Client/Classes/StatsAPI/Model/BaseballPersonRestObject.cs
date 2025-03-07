using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballPersonRestObject
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name = "fullName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryNumber
        /// </summary>
        [DataMember(Name = "primaryNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "primaryNumber")]
        public string PrimaryNumber { get; set; }

        /// <summary>
        /// Gets or Sets BirthDate
        /// </summary>
        [DataMember(Name = "birthDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "birthDate")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAge
        /// </summary>
        [DataMember(Name = "currentAge", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentAge")]
        public int? CurrentAge { get; set; }

        /// <summary>
        /// Gets or Sets BirthCity
        /// </summary>
        [DataMember(Name = "birthCity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "birthCity")]
        public string BirthCity { get; set; }

        /// <summary>
        /// Gets or Sets BirthStateProvince
        /// </summary>
        [DataMember(Name = "birthStateProvince", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "birthStateProvince")]
        public string BirthStateProvince { get; set; }

        /// <summary>
        /// Gets or Sets BirthCountry
        /// </summary>
        [DataMember(Name = "birthCountry", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "birthCountry")]
        public string BirthCountry { get; set; }

        /// <summary>
        /// Gets or Sets Nationality
        /// </summary>
        [DataMember(Name = "nationality", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "height")]
        public string Height { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets AlternateCaptain
        /// </summary>
        [DataMember(Name = "alternateCaptain", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "alternateCaptain")]
        public bool? AlternateCaptain { get; set; }

        /// <summary>
        /// Gets or Sets Captain
        /// </summary>
        [DataMember(Name = "captain", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "captain")]
        public bool? Captain { get; set; }

        /// <summary>
        /// Gets or Sets Rookie
        /// </summary>
        [DataMember(Name = "rookie", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rookie")]
        public bool? Rookie { get; set; }

        /// <summary>
        /// Gets or Sets CurrentTeam
        /// </summary>
        [DataMember(Name = "currentTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentTeam")]
        public BaseballTeamRestObject CurrentTeam { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryPosition
        /// </summary>
        [DataMember(Name = "primaryPosition", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "primaryPosition")]
        public PositionRestObject PrimaryPosition { get; set; }

        /// <summary>
        /// Gets or Sets Social
        /// </summary>
        [DataMember(Name = "social", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "social")]
        public SocialMediaRestObject Social { get; set; }

        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Hydrations
        /// </summary>
        [DataMember(Name = "hydrations", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydrations")]
        public List<string> Hydrations { get; set; }

        /// <summary>
        /// Gets or Sets UseName
        /// </summary>
        [DataMember(Name = "useName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "useName")]
        public string UseName { get; set; }

        /// <summary>
        /// Gets or Sets UseLastName
        /// </summary>
        [DataMember(Name = "useLastName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "useLastName")]
        public string UseLastName { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name = "middleName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets BoxscoreName
        /// </summary>
        [DataMember(Name = "boxscoreName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "boxscoreName")]
        public string BoxscoreName { get; set; }

        /// <summary>
        /// Gets or Sets NickName
        /// </summary>
        [DataMember(Name = "nickName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nickName")]
        public string NickName { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or Sets NameMatrilineal
        /// </summary>
        [DataMember(Name = "nameMatrilineal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nameMatrilineal")]
        public string NameMatrilineal { get; set; }

        /// <summary>
        /// Gets or Sets IsPlayer
        /// </summary>
        [DataMember(Name = "isPlayer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPlayer")]
        public bool? IsPlayer { get; set; }

        /// <summary>
        /// Gets or Sets IsVerified
        /// </summary>
        [DataMember(Name = "isVerified", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isVerified")]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// Gets or Sets DraftYear
        /// </summary>
        [DataMember(Name = "draftYear", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "draftYear")]
        public int? DraftYear { get; set; }

        /// <summary>
        /// Gets or Sets DeathDate
        /// </summary>
        [DataMember(Name = "deathDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deathDate")]
        public DateTime? DeathDate { get; set; }

        /// <summary>
        /// Gets or Sets DeathCity
        /// </summary>
        [DataMember(Name = "deathCity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deathCity")]
        public string DeathCity { get; set; }

        /// <summary>
        /// Gets or Sets DeathStateProvince
        /// </summary>
        [DataMember(Name = "deathStateProvince", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deathStateProvince")]
        public string DeathStateProvince { get; set; }

        /// <summary>
        /// Gets or Sets DeathCountry
        /// </summary>
        [DataMember(Name = "deathCountry", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deathCountry")]
        public string DeathCountry { get; set; }

        /// <summary>
        /// Gets or Sets Pronunciation
        /// </summary>
        [DataMember(Name = "pronunciation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pronunciation")]
        public string Pronunciation { get; set; }

        /// <summary>
        /// Gets or Sets LastPlayedDate
        /// </summary>
        [DataMember(Name = "lastPlayedDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastPlayedDate")]
        public DateTime? LastPlayedDate { get; set; }

        /// <summary>
        /// Gets or Sets RookieSeasons
        /// </summary>
        [DataMember(Name = "rookieSeasons", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rookieSeasons")]
        public List<string> RookieSeasons { get; set; }

        /// <summary>
        /// Gets or Sets OtherNames
        /// </summary>
        [DataMember(Name = "otherNames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "otherNames")]
        public OtherNamesRestObject OtherNames { get; set; }

        /// <summary>
        /// Gets or Sets Education
        /// </summary>
        [DataMember(Name = "education", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "education")]
        public EducationRestObject Education { get; set; }

        /// <summary>
        /// Gets or Sets Photos
        /// </summary>
        [DataMember(Name = "photos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "photos")]
        public List<PhotoRestObject> Photos { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name = "stats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stats")]
        public List<StatContainerRestObject> Stats { get; set; }

        /// <summary>
        /// Gets or Sets Awards
        /// </summary>
        [DataMember(Name = "awards", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awards")]
        public List<AwardRestObject> Awards { get; set; }

        /// <summary>
        /// Gets or Sets Draft
        /// </summary>
        [DataMember(Name = "draft", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "draft")]
        public List<PlayerDraftInfoRestObject> Draft { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalBio
        /// </summary>
        [DataMember(Name = "additionalBio", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalBio")]
        public AdditionalBioRestObject AdditionalBio { get; set; }

        /// <summary>
        /// Gets or Sets MlbDebutDate
        /// </summary>
        [DataMember(Name = "mlbDebutDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mlbDebutDate")]
        public DateTime? MlbDebutDate { get; set; }

        /// <summary>
        /// Gets or Sets BatSide
        /// </summary>
        [DataMember(Name = "batSide", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batSide")]
        public DynamicEnumRestObject BatSide { get; set; }

        /// <summary>
        /// Gets or Sets PitchHand
        /// </summary>
        [DataMember(Name = "pitchHand", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchHand")]
        public DynamicEnumRestObject PitchHand { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets NameFirstLast
        /// </summary>
        [DataMember(Name = "nameFirstLast", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nameFirstLast")]
        public string NameFirstLast { get; set; }

        /// <summary>
        /// Gets or Sets NameTitle
        /// </summary>
        [DataMember(Name = "nameTitle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nameTitle")]
        public string NameTitle { get; set; }

        /// <summary>
        /// Gets or Sets NamePrefix
        /// </summary>
        [DataMember(Name = "namePrefix", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "namePrefix")]
        public string NamePrefix { get; set; }

        /// <summary>
        /// Gets or Sets NameSuffix
        /// </summary>
        [DataMember(Name = "nameSuffix", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nameSuffix")]
        public string NameSuffix { get; set; }

        /// <summary>
        /// Gets or Sets NameSlug
        /// </summary>
        [DataMember(Name = "nameSlug", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nameSlug")]
        public string NameSlug { get; set; }

        /// <summary>
        /// Gets or Sets FirstLastName
        /// </summary>
        [DataMember(Name = "firstLastName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstLastName")]
        public string FirstLastName { get; set; }

        /// <summary>
        /// Gets or Sets LastFirstName
        /// </summary>
        [DataMember(Name = "lastFirstName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastFirstName")]
        public string LastFirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastInitName
        /// </summary>
        [DataMember(Name = "lastInitName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastInitName")]
        public string LastInitName { get; set; }

        /// <summary>
        /// Gets or Sets InitLastName
        /// </summary>
        [DataMember(Name = "initLastName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "initLastName")]
        public string InitLastName { get; set; }

        /// <summary>
        /// Gets or Sets FullFMLName
        /// </summary>
        [DataMember(Name = "fullFMLName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fullFMLName")]
        public string FullFMLName { get; set; }

        /// <summary>
        /// Gets or Sets FullLFMName
        /// </summary>
        [DataMember(Name = "fullLFMName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fullLFMName")]
        public string FullLFMName { get; set; }

        /// <summary>
        /// Gets or Sets StrikeZoneTop
        /// </summary>
        [DataMember(Name = "strikeZoneTop", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikeZoneTop")]
        public double? StrikeZoneTop { get; set; }

        /// <summary>
        /// Gets or Sets StrikeZoneBottom
        /// </summary>
        [DataMember(Name = "strikeZoneBottom", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikeZoneBottom")]
        public double? StrikeZoneBottom { get; set; }

        /// <summary>
        /// Gets or Sets AlumniLastSeason
        /// </summary>
        [DataMember(Name = "alumniLastSeason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "alumniLastSeason")]
        public string AlumniLastSeason { get; set; }

        /// <summary>
        /// Gets or Sets Drafts
        /// </summary>
        [DataMember(Name = "drafts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "drafts")]
        public List<BaseballDraftProspectRestObject> Drafts { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transactions")]
        public List<TransactionRestObject> Transactions { get; set; }

        /// <summary>
        /// Gets or Sets Articles
        /// </summary>
        [DataMember(Name = "articles", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "articles")]
        public List<IFeedRestObject> Articles { get; set; }

        /// <summary>
        /// Gets or Sets Videos
        /// </summary>
        [DataMember(Name = "videos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "videos")]
        public List<IFeedRestObject> Videos { get; set; }

        /// <summary>
        /// Gets or Sets MixedFeed
        /// </summary>
        [DataMember(Name = "mixedFeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mixedFeed")]
        public List<IFeedRestObject> MixedFeed { get; set; }

        /// <summary>
        /// Gets or Sets Relatives
        /// </summary>
        [DataMember(Name = "relatives", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "relatives")]
        public List<BaseballPersonRestObject> Relatives { get; set; }

        /// <summary>
        /// Gets or Sets XrefIds
        /// </summary>
        [DataMember(Name = "xrefIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "xrefIds")]
        public List<XrefIdRestObject> XrefIds { get; set; }

        /// <summary>
        /// Gets or Sets Nicknames
        /// </summary>
        [DataMember(Name = "nicknames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nicknames")]
        public List<string> Nicknames { get; set; }

        /// <summary>
        /// Gets or Sets DepthCharts
        /// </summary>
        [DataMember(Name = "depthCharts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "depthCharts")]
        public List<DepthChartRestObject> DepthCharts { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballPersonRestObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PrimaryNumber: ").Append(PrimaryNumber).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  CurrentAge: ").Append(CurrentAge).Append("\n");
            sb.Append("  BirthCity: ").Append(BirthCity).Append("\n");
            sb.Append("  BirthStateProvince: ").Append(BirthStateProvince).Append("\n");
            sb.Append("  BirthCountry: ").Append(BirthCountry).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AlternateCaptain: ").Append(AlternateCaptain).Append("\n");
            sb.Append("  Captain: ").Append(Captain).Append("\n");
            sb.Append("  Rookie: ").Append(Rookie).Append("\n");
            sb.Append("  CurrentTeam: ").Append(CurrentTeam).Append("\n");
            sb.Append("  PrimaryPosition: ").Append(PrimaryPosition).Append("\n");
            sb.Append("  Social: ").Append(Social).Append("\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Hydrations: ").Append(Hydrations).Append("\n");
            sb.Append("  UseName: ").Append(UseName).Append("\n");
            sb.Append("  UseLastName: ").Append(UseLastName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  BoxscoreName: ").Append(BoxscoreName).Append("\n");
            sb.Append("  NickName: ").Append(NickName).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  NameMatrilineal: ").Append(NameMatrilineal).Append("\n");
            sb.Append("  IsPlayer: ").Append(IsPlayer).Append("\n");
            sb.Append("  IsVerified: ").Append(IsVerified).Append("\n");
            sb.Append("  DraftYear: ").Append(DraftYear).Append("\n");
            sb.Append("  DeathDate: ").Append(DeathDate).Append("\n");
            sb.Append("  DeathCity: ").Append(DeathCity).Append("\n");
            sb.Append("  DeathStateProvince: ").Append(DeathStateProvince).Append("\n");
            sb.Append("  DeathCountry: ").Append(DeathCountry).Append("\n");
            sb.Append("  Pronunciation: ").Append(Pronunciation).Append("\n");
            sb.Append("  LastPlayedDate: ").Append(LastPlayedDate).Append("\n");
            sb.Append("  RookieSeasons: ").Append(RookieSeasons).Append("\n");
            sb.Append("  OtherNames: ").Append(OtherNames).Append("\n");
            sb.Append("  Education: ").Append(Education).Append("\n");
            sb.Append("  Photos: ").Append(Photos).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  Awards: ").Append(Awards).Append("\n");
            sb.Append("  Draft: ").Append(Draft).Append("\n");
            sb.Append("  AdditionalBio: ").Append(AdditionalBio).Append("\n");
            sb.Append("  MlbDebutDate: ").Append(MlbDebutDate).Append("\n");
            sb.Append("  BatSide: ").Append(BatSide).Append("\n");
            sb.Append("  PitchHand: ").Append(PitchHand).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  NameFirstLast: ").Append(NameFirstLast).Append("\n");
            sb.Append("  NameTitle: ").Append(NameTitle).Append("\n");
            sb.Append("  NamePrefix: ").Append(NamePrefix).Append("\n");
            sb.Append("  NameSuffix: ").Append(NameSuffix).Append("\n");
            sb.Append("  NameSlug: ").Append(NameSlug).Append("\n");
            sb.Append("  FirstLastName: ").Append(FirstLastName).Append("\n");
            sb.Append("  LastFirstName: ").Append(LastFirstName).Append("\n");
            sb.Append("  LastInitName: ").Append(LastInitName).Append("\n");
            sb.Append("  InitLastName: ").Append(InitLastName).Append("\n");
            sb.Append("  FullFMLName: ").Append(FullFMLName).Append("\n");
            sb.Append("  FullLFMName: ").Append(FullLFMName).Append("\n");
            sb.Append("  StrikeZoneTop: ").Append(StrikeZoneTop).Append("\n");
            sb.Append("  StrikeZoneBottom: ").Append(StrikeZoneBottom).Append("\n");
            sb.Append("  AlumniLastSeason: ").Append(AlumniLastSeason).Append("\n");
            sb.Append("  Drafts: ").Append(Drafts).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  Articles: ").Append(Articles).Append("\n");
            sb.Append("  Videos: ").Append(Videos).Append("\n");
            sb.Append("  MixedFeed: ").Append(MixedFeed).Append("\n");
            sb.Append("  Relatives: ").Append(Relatives).Append("\n");
            sb.Append("  XrefIds: ").Append(XrefIds).Append("\n");
            sb.Append("  Nicknames: ").Append(Nicknames).Append("\n");
            sb.Append("  DepthCharts: ").Append(DepthCharts).Append("\n");
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