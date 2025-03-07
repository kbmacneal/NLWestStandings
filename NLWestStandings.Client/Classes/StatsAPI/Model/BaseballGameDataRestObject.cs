using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballGameDataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Game
        /// </summary>
        [DataMember(Name = "game", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "game")]
        public BaseballGameDataGameRestObject Game { get; set; }

        /// <summary>
        /// Gets or Sets Datetime
        /// </summary>
        [DataMember(Name = "datetime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "datetime")]
        public BaseballGameDateTimeRestObject Datetime { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public GameStatusRestObject Status { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teams")]
        public Dictionary<string, BaseballTeamRestObject> Teams { get; set; }

        /// <summary>
        /// Gets or Sets Players
        /// </summary>
        [DataMember(Name = "players", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "players")]
        public Dictionary<string, BaseballPersonRestObject> Players { get; set; }

        /// <summary>
        /// Gets or Sets Venue
        /// </summary>
        [DataMember(Name = "venue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "venue")]
        public VenueRestObject Venue { get; set; }

        /// <summary>
        /// Gets or Sets OfficialVenue
        /// </summary>
        [DataMember(Name = "officialVenue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "officialVenue")]
        public VenueRestObject OfficialVenue { get; set; }

        /// <summary>
        /// Gets or Sets Weather
        /// </summary>
        [DataMember(Name = "weather", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "weather")]
        public WeatherRestObject Weather { get; set; }

        /// <summary>
        /// Gets or Sets GameInfo
        /// </summary>
        [DataMember(Name = "gameInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameInfo")]
        public GameInfoRestObject GameInfo { get; set; }

        /// <summary>
        /// Gets or Sets Review
        /// </summary>
        [DataMember(Name = "review", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "review")]
        public BaseballReviewRestObject Review { get; set; }

        /// <summary>
        /// Gets or Sets AbsChallenges
        /// </summary>
        [DataMember(Name = "absChallenges", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "absChallenges")]
        public BaseballABSChallengeRestObject AbsChallenges { get; set; }

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "flags")]
        public BaseballGameFlagRestObject Flags { get; set; }

        /// <summary>
        /// Gets or Sets Alerts
        /// </summary>
        [DataMember(Name = "alerts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "alerts")]
        public List<BaseballGameAlertRestObject> Alerts { get; set; }

        /// <summary>
        /// Gets or Sets ProbablePitchers
        /// </summary>
        [DataMember(Name = "probablePitchers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "probablePitchers")]
        public BaseballGameProbableRestObject ProbablePitchers { get; set; }

        /// <summary>
        /// Gets or Sets OfficialScorer
        /// </summary>
        [DataMember(Name = "officialScorer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "officialScorer")]
        public BaseballPersonRestObject OfficialScorer { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryDatacaster
        /// </summary>
        [DataMember(Name = "primaryDatacaster", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "primaryDatacaster")]
        public BaseballPersonRestObject PrimaryDatacaster { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryDatacaster
        /// </summary>
        [DataMember(Name = "secondaryDatacaster", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "secondaryDatacaster")]
        public BaseballPersonRestObject SecondaryDatacaster { get; set; }

        /// <summary>
        /// Gets or Sets RuleSettings
        /// </summary>
        [DataMember(Name = "ruleSettings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ruleSettings")]
        public List<RuleSettingsRestObject> RuleSettings { get; set; }

        /// <summary>
        /// Gets or Sets MoundVisits
        /// </summary>
        [DataMember(Name = "moundVisits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "moundVisits")]
        public MoundVisitsRestObject MoundVisits { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballGameDataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Game: ").Append(Game).Append("\n");
            sb.Append("  Datetime: ").Append(Datetime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
            sb.Append("  Players: ").Append(Players).Append("\n");
            sb.Append("  Venue: ").Append(Venue).Append("\n");
            sb.Append("  OfficialVenue: ").Append(OfficialVenue).Append("\n");
            sb.Append("  Weather: ").Append(Weather).Append("\n");
            sb.Append("  GameInfo: ").Append(GameInfo).Append("\n");
            sb.Append("  Review: ").Append(Review).Append("\n");
            sb.Append("  AbsChallenges: ").Append(AbsChallenges).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Alerts: ").Append(Alerts).Append("\n");
            sb.Append("  ProbablePitchers: ").Append(ProbablePitchers).Append("\n");
            sb.Append("  OfficialScorer: ").Append(OfficialScorer).Append("\n");
            sb.Append("  PrimaryDatacaster: ").Append(PrimaryDatacaster).Append("\n");
            sb.Append("  SecondaryDatacaster: ").Append(SecondaryDatacaster).Append("\n");
            sb.Append("  RuleSettings: ").Append(RuleSettings).Append("\n");
            sb.Append("  MoundVisits: ").Append(MoundVisits).Append("\n");
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