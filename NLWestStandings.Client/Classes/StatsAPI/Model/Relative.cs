using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Relative
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryPosition
        /// </summary>
        [DataMember(Name = "primaryPosition", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "primaryPosition")]
        public BaseballPosition PrimaryPosition { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name = "stats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stats")]
        public Stats Stats { get; set; }

        /// <summary>
        /// Gets or Sets OtherNames
        /// </summary>
        [DataMember(Name = "otherNames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "otherNames")]
        public OtherNames OtherNames { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets UseName
        /// </summary>
        [DataMember(Name = "useName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "useName")]
        public string UseName { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name = "middleName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets UseLastName
        /// </summary>
        [DataMember(Name = "useLastName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "useLastName")]
        public string UseLastName { get; set; }

        /// <summary>
        /// Gets or Sets NickName
        /// </summary>
        [DataMember(Name = "nickName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nickName")]
        public string NickName { get; set; }

        /// <summary>
        /// Gets or Sets NickNames
        /// </summary>
        [DataMember(Name = "nickNames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nickNames")]
        public List<string> NickNames { get; set; }

        /// <summary>
        /// Gets or Sets BoxscoreName
        /// </summary>
        [DataMember(Name = "boxscoreName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "boxscoreName")]
        public string BoxscoreName { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryNumber
        /// </summary>
        [DataMember(Name = "primaryNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "primaryNumber")]
        public string PrimaryNumber { get; set; }

        /// <summary>
        /// Gets or Sets RosterNumber
        /// </summary>
        [DataMember(Name = "rosterNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rosterNumber")]
        public string RosterNumber { get; set; }

        /// <summary>
        /// Gets or Sets DraftYear
        /// </summary>
        [DataMember(Name = "draftYear", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "draftYear")]
        public int? DraftYear { get; set; }

        /// <summary>
        /// Gets or Sets Age
        /// </summary>
        [DataMember(Name = "age", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "age")]
        public int? Age { get; set; }

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
        /// Gets or Sets BirthDate
        /// </summary>
        [DataMember(Name = "birthDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "birthDate")]
        public DateTime? BirthDate { get; set; }

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
        /// Gets or Sets DeathDate
        /// </summary>
        [DataMember(Name = "deathDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deathDate")]
        public DateTime? DeathDate { get; set; }

        /// <summary>
        /// Gets or Sets LastPlayedDate
        /// </summary>
        [DataMember(Name = "lastPlayedDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastPlayedDate")]
        public DateTime? LastPlayedDate { get; set; }

        /// <summary>
        /// Gets or Sets Pronunciation
        /// </summary>
        [DataMember(Name = "pronunciation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pronunciation")]
        public string Pronunciation { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name = "fullName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or Sets HeightFeet
        /// </summary>
        [DataMember(Name = "heightFeet", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "heightFeet")]
        public int? HeightFeet { get; set; }

        /// <summary>
        /// Gets or Sets HeightInches
        /// </summary>
        [DataMember(Name = "heightInches", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "heightInches")]
        public int? HeightInches { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or Sets CurrentTeam
        /// </summary>
        [DataMember(Name = "currentTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentTeam")]
        public BaseballTeam CurrentTeam { get; set; }

        /// <summary>
        /// Gets or Sets IsRookie
        /// </summary>
        [DataMember(Name = "isRookie", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isRookie")]
        public bool? IsRookie { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "isActive", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isActive")]
        public bool? IsActive { get; set; }

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
        /// Gets or Sets IsAlternateCaptain
        /// </summary>
        [DataMember(Name = "isAlternateCaptain", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isAlternateCaptain")]
        public bool? IsAlternateCaptain { get; set; }

        /// <summary>
        /// Gets or Sets IsCaptain
        /// </summary>
        [DataMember(Name = "isCaptain", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isCaptain")]
        public bool? IsCaptain { get; set; }

        /// <summary>
        /// Gets or Sets Twitter
        /// </summary>
        [DataMember(Name = "twitter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "twitter")]
        public string Twitter { get; set; }

        /// <summary>
        /// Gets or Sets Awards
        /// </summary>
        [DataMember(Name = "awards", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "awards")]
        public List<Award> Awards { get; set; }

        /// <summary>
        /// Gets or Sets SocialMediaInfo
        /// </summary>
        [DataMember(Name = "socialMediaInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "socialMediaInfo")]
        public SocialMediaInfo SocialMediaInfo { get; set; }

        /// <summary>
        /// Gets or Sets EducationInfo
        /// </summary>
        [DataMember(Name = "educationInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "educationInfo")]
        public EducationInfo EducationInfo { get; set; }

        /// <summary>
        /// Gets or Sets Photos
        /// </summary>
        [DataMember(Name = "photos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "photos")]
        public List<Photo> Photos { get; set; }

        /// <summary>
        /// Gets or Sets Draft
        /// </summary>
        [DataMember(Name = "draft", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "draft")]
        public List<PlayerDraftInfo> Draft { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalBio
        /// </summary>
        [DataMember(Name = "additionalBio", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalBio")]
        public AdditionalBio AdditionalBio { get; set; }

        /// <summary>
        /// Gets or Sets PhoneticName
        /// </summary>
        [DataMember(Name = "phoneticName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "phoneticName")]
        public string PhoneticName { get; set; }

        /// <summary>
        /// Gets or Sets Nationality
        /// </summary>
        [DataMember(Name = "nationality", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or Sets BatSide
        /// </summary>
        [DataMember(Name = "batSide", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batSide")]
        public DynamicLookupEnum BatSide { get; set; }

        /// <summary>
        /// Gets or Sets PitchHand
        /// </summary>
        [DataMember(Name = "pitchHand", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchHand")]
        public DynamicLookupEnum PitchHand { get; set; }

        /// <summary>
        /// Gets or Sets MlbDebutDate
        /// </summary>
        [DataMember(Name = "mlbDebutDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mlbDebutDate")]
        public DateTime? MlbDebutDate { get; set; }

        /// <summary>
        /// Gets or Sets BatterPitcher
        /// </summary>
        [DataMember(Name = "batterPitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batterPitcher")]
        public string BatterPitcher { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets NameSlug
        /// </summary>
        [DataMember(Name = "nameSlug", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nameSlug")]
        public string NameSlug { get; set; }

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
        /// Gets or Sets NameFirstLast
        /// </summary>
        [DataMember(Name = "nameFirstLast", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nameFirstLast")]
        public string NameFirstLast { get; set; }

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
        /// Gets or Sets LanguageId
        /// </summary>
        [DataMember(Name = "languageId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "languageId")]
        public int? LanguageId { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transactions")]
        public List<Transaction> Transactions { get; set; }

        /// <summary>
        /// Gets or Sets Drafts
        /// </summary>
        [DataMember(Name = "drafts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "drafts")]
        public List<BaseballDraftProspect> Drafts { get; set; }

        /// <summary>
        /// Gets or Sets Articles
        /// </summary>
        [DataMember(Name = "articles", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "articles")]
        public List<Article> Articles { get; set; }

        /// <summary>
        /// Gets or Sets Videos
        /// </summary>
        [DataMember(Name = "videos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "videos")]
        public List<Video> Videos { get; set; }

        /// <summary>
        /// Gets or Sets MixedFeed
        /// </summary>
        [DataMember(Name = "mixedFeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mixedFeed")]
        public List<IFeed> MixedFeed { get; set; }

        /// <summary>
        /// Gets or Sets XrefIds
        /// </summary>
        [DataMember(Name = "xrefIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "xrefIds")]
        public List<XrefId> XrefIds { get; set; }

        /// <summary>
        /// Gets or Sets DepthCharts
        /// </summary>
        [DataMember(Name = "depthCharts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "depthCharts")]
        public List<DepthChart> DepthCharts { get; set; }

        /// <summary>
        /// Gets or Sets NextStarts
        /// </summary>
        [DataMember(Name = "nextStarts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nextStarts")]
        public List<BaseballScheduleItem> NextStarts { get; set; }

        /// <summary>
        /// Gets or Sets RookieSeasons
        /// </summary>
        [DataMember(Name = "rookieSeasons", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rookieSeasons")]
        public List<string> RookieSeasons { get; set; }

        /// <summary>
        /// Gets or Sets HasStats
        /// </summary>
        [DataMember(Name = "hasStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasStats")]
        public bool? HasStats { get; set; }

        /// <summary>
        /// Gets or Sets Relation
        /// </summary>
        [DataMember(Name = "relation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "relation")]
        public string Relation { get; set; }

        /// <summary>
        /// Gets or Sets Pitcher
        /// </summary>
        [DataMember(Name = "pitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitcher")]
        public bool? Pitcher { get; set; }

        /// <summary>
        /// Gets or Sets Fielder
        /// </summary>
        [DataMember(Name = "fielder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fielder")]
        public bool? Fielder { get; set; }

        /// <summary>
        /// Gets or Sets HydratedSocial
        /// </summary>
        [DataMember(Name = "hydratedSocial", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedSocial")]
        public Dictionary<string, Object> HydratedSocial { get; set; }

        /// <summary>
        /// Gets or Sets HydratedEducation
        /// </summary>
        [DataMember(Name = "hydratedEducation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedEducation")]
        public Dictionary<string, Object> HydratedEducation { get; set; }

        /// <summary>
        /// Gets or Sets HydratedStats
        /// </summary>
        [DataMember(Name = "hydratedStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedStats")]
        public Dictionary<string, Object> HydratedStats { get; set; }

        /// <summary>
        /// Gets or Sets HydratedCurrentTeam
        /// </summary>
        [DataMember(Name = "hydratedCurrentTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedCurrentTeam")]
        public Dictionary<string, Object> HydratedCurrentTeam { get; set; }

        /// <summary>
        /// Gets or Sets HydratedTeam
        /// </summary>
        [DataMember(Name = "hydratedTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedTeam")]
        public Dictionary<string, Object> HydratedTeam { get; set; }

        /// <summary>
        /// Gets or Sets HydratedAwards
        /// </summary>
        [DataMember(Name = "hydratedAwards", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedAwards")]
        public Dictionary<string, Object> HydratedAwards { get; set; }

        /// <summary>
        /// Gets or Sets HydratedPersonRosterEntries
        /// </summary>
        [DataMember(Name = "hydratedPersonRosterEntries", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedPersonRosterEntries")]
        public Dictionary<string, Object> HydratedPersonRosterEntries { get; set; }

        /// <summary>
        /// Gets or Sets HydratedPersonJobsEntries
        /// </summary>
        [DataMember(Name = "hydratedPersonJobsEntries", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedPersonJobsEntries")]
        public Dictionary<string, Object> HydratedPersonJobsEntries { get; set; }

        /// <summary>
        /// Gets or Sets HydratedRelatives
        /// </summary>
        [DataMember(Name = "hydratedRelatives", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedRelatives")]
        public Dictionary<string, Object> HydratedRelatives { get; set; }

        /// <summary>
        /// Gets or Sets DraftProspects
        /// </summary>
        [DataMember(Name = "draftProspects", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "draftProspects")]
        public Dictionary<string, Object> DraftProspects { get; set; }

        /// <summary>
        /// Gets or Sets HydratedDepthCharts
        /// </summary>
        [DataMember(Name = "hydratedDepthCharts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedDepthCharts")]
        public Dictionary<string, Object> HydratedDepthCharts { get; set; }

        /// <summary>
        /// Gets or Sets HydratedNextStarts
        /// </summary>
        [DataMember(Name = "hydratedNextStarts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedNextStarts")]
        public Dictionary<string, Object> HydratedNextStarts { get; set; }

        /// <summary>
        /// Gets or Sets HydratedPlayerPhotos
        /// </summary>
        [DataMember(Name = "hydratedPlayerPhotos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedPlayerPhotos")]
        public Dictionary<string, Object> HydratedPlayerPhotos { get; set; }

        /// <summary>
        /// Gets or Sets HydratedArticles
        /// </summary>
        [DataMember(Name = "hydratedArticles", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedArticles")]
        public Dictionary<string, Object> HydratedArticles { get; set; }

        /// <summary>
        /// Gets or Sets HydratedVideos
        /// </summary>
        [DataMember(Name = "hydratedVideos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedVideos")]
        public Dictionary<string, Object> HydratedVideos { get; set; }

        /// <summary>
        /// Gets or Sets HydratedMixedFeed
        /// </summary>
        [DataMember(Name = "hydratedMixedFeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedMixedFeed")]
        public Dictionary<string, Object> HydratedMixedFeed { get; set; }

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
            sb.Append("class Relative {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  PrimaryPosition: ").Append(PrimaryPosition).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  OtherNames: ").Append(OtherNames).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  UseName: ").Append(UseName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  UseLastName: ").Append(UseLastName).Append("\n");
            sb.Append("  NickName: ").Append(NickName).Append("\n");
            sb.Append("  NickNames: ").Append(NickNames).Append("\n");
            sb.Append("  BoxscoreName: ").Append(BoxscoreName).Append("\n");
            sb.Append("  PrimaryNumber: ").Append(PrimaryNumber).Append("\n");
            sb.Append("  RosterNumber: ").Append(RosterNumber).Append("\n");
            sb.Append("  DraftYear: ").Append(DraftYear).Append("\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("  BirthCity: ").Append(BirthCity).Append("\n");
            sb.Append("  BirthStateProvince: ").Append(BirthStateProvince).Append("\n");
            sb.Append("  BirthCountry: ").Append(BirthCountry).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  DeathCity: ").Append(DeathCity).Append("\n");
            sb.Append("  DeathStateProvince: ").Append(DeathStateProvince).Append("\n");
            sb.Append("  DeathCountry: ").Append(DeathCountry).Append("\n");
            sb.Append("  DeathDate: ").Append(DeathDate).Append("\n");
            sb.Append("  LastPlayedDate: ").Append(LastPlayedDate).Append("\n");
            sb.Append("  Pronunciation: ").Append(Pronunciation).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  HeightFeet: ").Append(HeightFeet).Append("\n");
            sb.Append("  HeightInches: ").Append(HeightInches).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  CurrentTeam: ").Append(CurrentTeam).Append("\n");
            sb.Append("  IsRookie: ").Append(IsRookie).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  NameMatrilineal: ").Append(NameMatrilineal).Append("\n");
            sb.Append("  IsPlayer: ").Append(IsPlayer).Append("\n");
            sb.Append("  IsVerified: ").Append(IsVerified).Append("\n");
            sb.Append("  IsAlternateCaptain: ").Append(IsAlternateCaptain).Append("\n");
            sb.Append("  IsCaptain: ").Append(IsCaptain).Append("\n");
            sb.Append("  Twitter: ").Append(Twitter).Append("\n");
            sb.Append("  Awards: ").Append(Awards).Append("\n");
            sb.Append("  SocialMediaInfo: ").Append(SocialMediaInfo).Append("\n");
            sb.Append("  EducationInfo: ").Append(EducationInfo).Append("\n");
            sb.Append("  Photos: ").Append(Photos).Append("\n");
            sb.Append("  Draft: ").Append(Draft).Append("\n");
            sb.Append("  AdditionalBio: ").Append(AdditionalBio).Append("\n");
            sb.Append("  PhoneticName: ").Append(PhoneticName).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  BatSide: ").Append(BatSide).Append("\n");
            sb.Append("  PitchHand: ").Append(PitchHand).Append("\n");
            sb.Append("  MlbDebutDate: ").Append(MlbDebutDate).Append("\n");
            sb.Append("  BatterPitcher: ").Append(BatterPitcher).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  NameSlug: ").Append(NameSlug).Append("\n");
            sb.Append("  NameTitle: ").Append(NameTitle).Append("\n");
            sb.Append("  NamePrefix: ").Append(NamePrefix).Append("\n");
            sb.Append("  NameFirstLast: ").Append(NameFirstLast).Append("\n");
            sb.Append("  FirstLastName: ").Append(FirstLastName).Append("\n");
            sb.Append("  LastFirstName: ").Append(LastFirstName).Append("\n");
            sb.Append("  LastInitName: ").Append(LastInitName).Append("\n");
            sb.Append("  InitLastName: ").Append(InitLastName).Append("\n");
            sb.Append("  FullFMLName: ").Append(FullFMLName).Append("\n");
            sb.Append("  FullLFMName: ").Append(FullLFMName).Append("\n");
            sb.Append("  StrikeZoneTop: ").Append(StrikeZoneTop).Append("\n");
            sb.Append("  StrikeZoneBottom: ").Append(StrikeZoneBottom).Append("\n");
            sb.Append("  AlumniLastSeason: ").Append(AlumniLastSeason).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  Drafts: ").Append(Drafts).Append("\n");
            sb.Append("  Articles: ").Append(Articles).Append("\n");
            sb.Append("  Videos: ").Append(Videos).Append("\n");
            sb.Append("  MixedFeed: ").Append(MixedFeed).Append("\n");
            sb.Append("  XrefIds: ").Append(XrefIds).Append("\n");
            sb.Append("  DepthCharts: ").Append(DepthCharts).Append("\n");
            sb.Append("  NextStarts: ").Append(NextStarts).Append("\n");
            sb.Append("  RookieSeasons: ").Append(RookieSeasons).Append("\n");
            sb.Append("  HasStats: ").Append(HasStats).Append("\n");
            sb.Append("  Relation: ").Append(Relation).Append("\n");
            sb.Append("  Pitcher: ").Append(Pitcher).Append("\n");
            sb.Append("  Fielder: ").Append(Fielder).Append("\n");
            sb.Append("  HydratedSocial: ").Append(HydratedSocial).Append("\n");
            sb.Append("  HydratedEducation: ").Append(HydratedEducation).Append("\n");
            sb.Append("  HydratedStats: ").Append(HydratedStats).Append("\n");
            sb.Append("  HydratedCurrentTeam: ").Append(HydratedCurrentTeam).Append("\n");
            sb.Append("  HydratedTeam: ").Append(HydratedTeam).Append("\n");
            sb.Append("  HydratedAwards: ").Append(HydratedAwards).Append("\n");
            sb.Append("  HydratedPersonRosterEntries: ").Append(HydratedPersonRosterEntries).Append("\n");
            sb.Append("  HydratedPersonJobsEntries: ").Append(HydratedPersonJobsEntries).Append("\n");
            sb.Append("  HydratedRelatives: ").Append(HydratedRelatives).Append("\n");
            sb.Append("  DraftProspects: ").Append(DraftProspects).Append("\n");
            sb.Append("  HydratedDepthCharts: ").Append(HydratedDepthCharts).Append("\n");
            sb.Append("  HydratedNextStarts: ").Append(HydratedNextStarts).Append("\n");
            sb.Append("  HydratedPlayerPhotos: ").Append(HydratedPlayerPhotos).Append("\n");
            sb.Append("  HydratedArticles: ").Append(HydratedArticles).Append("\n");
            sb.Append("  HydratedVideos: ").Append(HydratedVideos).Append("\n");
            sb.Append("  HydratedMixedFeed: ").Append(HydratedMixedFeed).Append("\n");
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