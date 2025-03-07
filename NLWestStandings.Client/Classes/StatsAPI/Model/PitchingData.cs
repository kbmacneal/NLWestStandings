using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PitchingData
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "summary")]
        public Dictionary<string, string> Summary { get; set; }

        /// <summary>
        /// Gets or Sets CatchersInterference
        /// </summary>
        [DataMember(Name = "catchersInterference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "catchersInterference")]
        public int? CatchersInterference { get; set; }

        /// <summary>
        /// Gets or Sets Average
        /// </summary>
        [DataMember(Name = "average", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "average")]
        public string Average { get; set; }

        /// <summary>
        /// Gets or Sets OnBasePercentage
        /// </summary>
        [DataMember(Name = "onBasePercentage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "onBasePercentage")]
        public string OnBasePercentage { get; set; }

        /// <summary>
        /// Gets or Sets OnBasePlusSlugging
        /// </summary>
        [DataMember(Name = "onBasePlusSlugging", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "onBasePlusSlugging")]
        public string OnBasePlusSlugging { get; set; }

        /// <summary>
        /// Gets or Sets StolenBases
        /// </summary>
        [DataMember(Name = "stolenBases", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stolenBases")]
        public int? StolenBases { get; set; }

        /// <summary>
        /// Gets or Sets CaughtStealing
        /// </summary>
        [DataMember(Name = "caughtStealing", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "caughtStealing")]
        public int? CaughtStealing { get; set; }

        /// <summary>
        /// Gets or Sets Slugging
        /// </summary>
        [DataMember(Name = "slugging", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "slugging")]
        public string Slugging { get; set; }

        /// <summary>
        /// Gets or Sets Outs
        /// </summary>
        [DataMember(Name = "outs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outs")]
        public int? Outs { get; set; }

        /// <summary>
        /// Gets or Sets Gidp
        /// </summary>
        [DataMember(Name = "gidp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gidp")]
        public int? Gidp { get; set; }

        /// <summary>
        /// Gets or Sets Gitp
        /// </summary>
        [DataMember(Name = "gitp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gitp")]
        public int? Gitp { get; set; }

        /// <summary>
        /// Gets or Sets HomeRuns
        /// </summary>
        [DataMember(Name = "homeRuns", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeRuns")]
        public int? HomeRuns { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfPitches
        /// </summary>
        [DataMember(Name = "numberOfPitches", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numberOfPitches")]
        public int? NumberOfPitches { get; set; }

        /// <summary>
        /// Gets or Sets TotalBases
        /// </summary>
        [DataMember(Name = "totalBases", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalBases")]
        public int? TotalBases { get; set; }

        /// <summary>
        /// Gets or Sets GidpOpportunites
        /// </summary>
        [DataMember(Name = "gidpOpportunites", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gidpOpportunites")]
        public int? GidpOpportunites { get; set; }

        /// <summary>
        /// Gets or Sets Walks
        /// </summary>
        [DataMember(Name = "walks", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "walks")]
        public int? Walks { get; set; }

        /// <summary>
        /// Gets or Sets HitByPitch
        /// </summary>
        [DataMember(Name = "hitByPitch", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitByPitch")]
        public int? HitByPitch { get; set; }

        /// <summary>
        /// Gets or Sets Strikeouts
        /// </summary>
        [DataMember(Name = "strikeouts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikeouts")]
        public int? Strikeouts { get; set; }

        /// <summary>
        /// Gets or Sets AirOuts
        /// </summary>
        [DataMember(Name = "airOuts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "airOuts")]
        public int? AirOuts { get; set; }

        /// <summary>
        /// Gets or Sets GoAo
        /// </summary>
        [DataMember(Name = "goAo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "goAo")]
        public string GoAo { get; set; }

        /// <summary>
        /// Gets or Sets PitchesPerPlateAppearance
        /// </summary>
        [DataMember(Name = "pitchesPerPlateAppearance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchesPerPlateAppearance")]
        public double? PitchesPerPlateAppearance { get; set; }

        /// <summary>
        /// Gets or Sets IntentionalWalks
        /// </summary>
        [DataMember(Name = "intentionalWalks", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "intentionalWalks")]
        public int? IntentionalWalks { get; set; }

        /// <summary>
        /// Gets or Sets GroundOuts
        /// </summary>
        [DataMember(Name = "groundOuts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "groundOuts")]
        public int? GroundOuts { get; set; }

        /// <summary>
        /// Gets or Sets FlyOuts
        /// </summary>
        [DataMember(Name = "flyOuts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "flyOuts")]
        public int? FlyOuts { get; set; }

        /// <summary>
        /// Gets or Sets Games
        /// </summary>
        [DataMember(Name = "games", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "games")]
        public int? Games { get; set; }

        /// <summary>
        /// Gets or Sets GamesStarted
        /// </summary>
        [DataMember(Name = "gamesStarted", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamesStarted")]
        public int? GamesStarted { get; set; }

        /// <summary>
        /// Gets or Sets Doubles
        /// </summary>
        [DataMember(Name = "doubles", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "doubles")]
        public int? Doubles { get; set; }

        /// <summary>
        /// Gets or Sets Hits
        /// </summary>
        [DataMember(Name = "hits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hits")]
        public int? Hits { get; set; }

        /// <summary>
        /// Gets or Sets Triples
        /// </summary>
        [DataMember(Name = "triples", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "triples")]
        public int? Triples { get; set; }

        /// <summary>
        /// Gets or Sets Singles
        /// </summary>
        [DataMember(Name = "singles", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "singles")]
        public int? Singles { get; set; }

        /// <summary>
        /// Gets or Sets Runs
        /// </summary>
        [DataMember(Name = "runs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runs")]
        public int? Runs { get; set; }

        /// <summary>
        /// Gets or Sets AtBats
        /// </summary>
        [DataMember(Name = "atBats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "atBats")]
        public int? AtBats { get; set; }

        /// <summary>
        /// Gets or Sets Pickoffs
        /// </summary>
        [DataMember(Name = "pickoffs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pickoffs")]
        public int? Pickoffs { get; set; }

        /// <summary>
        /// Gets or Sets StolenBasePercentage
        /// </summary>
        [DataMember(Name = "stolenBasePercentage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stolenBasePercentage")]
        public string StolenBasePercentage { get; set; }

        /// <summary>
        /// Gets or Sets WildPitches
        /// </summary>
        [DataMember(Name = "wildPitches", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wildPitches")]
        public int? WildPitches { get; set; }

        /// <summary>
        /// Gets or Sets SacFlies
        /// </summary>
        [DataMember(Name = "sacFlies", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sacFlies")]
        public int? SacFlies { get; set; }

        /// <summary>
        /// Gets or Sets SacBunts
        /// </summary>
        [DataMember(Name = "sacBunts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sacBunts")]
        public int? SacBunts { get; set; }

        /// <summary>
        /// Gets or Sets Putouts
        /// </summary>
        [DataMember(Name = "putouts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "putouts")]
        public int? Putouts { get; set; }

        /// <summary>
        /// Gets or Sets Assists
        /// </summary>
        [DataMember(Name = "assists", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "assists")]
        public int? Assists { get; set; }

        /// <summary>
        /// Gets or Sets Chances
        /// </summary>
        [DataMember(Name = "chances", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "chances")]
        public int? Chances { get; set; }

        /// <summary>
        /// Gets or Sets Streak
        /// </summary>
        [DataMember(Name = "streak", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "streak")]
        public int? Streak { get; set; }

        /// <summary>
        /// Gets or Sets BattingOrder
        /// </summary>
        [DataMember(Name = "battingOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "battingOrder")]
        public string BattingOrder { get; set; }

        /// <summary>
        /// Gets or Sets TotalSwings
        /// </summary>
        [DataMember(Name = "totalSwings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalSwings")]
        public int? TotalSwings { get; set; }

        /// <summary>
        /// Gets or Sets SwingsAndMisses
        /// </summary>
        [DataMember(Name = "swingsAndMisses", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "swingsAndMisses")]
        public int? SwingsAndMisses { get; set; }

        /// <summary>
        /// Gets or Sets BallsInPlay
        /// </summary>
        [DataMember(Name = "ballsInPlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ballsInPlay")]
        public int? BallsInPlay { get; set; }

        /// <summary>
        /// Gets or Sets PopOuts
        /// </summary>
        [DataMember(Name = "popOuts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "popOuts")]
        public int? PopOuts { get; set; }

        /// <summary>
        /// Gets or Sets LineOuts
        /// </summary>
        [DataMember(Name = "lineOuts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lineOuts")]
        public int? LineOuts { get; set; }

        /// <summary>
        /// Gets or Sets FlyHits
        /// </summary>
        [DataMember(Name = "flyHits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "flyHits")]
        public int? FlyHits { get; set; }

        /// <summary>
        /// Gets or Sets PopHits
        /// </summary>
        [DataMember(Name = "popHits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "popHits")]
        public int? PopHits { get; set; }

        /// <summary>
        /// Gets or Sets LineHits
        /// </summary>
        [DataMember(Name = "lineHits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lineHits")]
        public int? LineHits { get; set; }

        /// <summary>
        /// Gets or Sets GroundHits
        /// </summary>
        [DataMember(Name = "groundHits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "groundHits")]
        public int? GroundHits { get; set; }

        /// <summary>
        /// Gets or Sets GamesPlayedOnBothTeams
        /// </summary>
        [DataMember(Name = "gamesPlayedOnBothTeams", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamesPlayedOnBothTeams")]
        public int? GamesPlayedOnBothTeams { get; set; }

        /// <summary>
        /// Gets or Sets BattersFaced
        /// </summary>
        [DataMember(Name = "battersFaced", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "battersFaced")]
        public int? BattersFaced { get; set; }

        /// <summary>
        /// Gets or Sets EarnedRuns
        /// </summary>
        [DataMember(Name = "earnedRuns", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "earnedRuns")]
        public int? EarnedRuns { get; set; }

        /// <summary>
        /// Gets or Sets WalksHitsPerInningPitched
        /// </summary>
        [DataMember(Name = "walksHitsPerInningPitched", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "walksHitsPerInningPitched")]
        public string WalksHitsPerInningPitched { get; set; }

        /// <summary>
        /// Gets or Sets Wins
        /// </summary>
        [DataMember(Name = "wins", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wins")]
        public int? Wins { get; set; }

        /// <summary>
        /// Gets or Sets Losses
        /// </summary>
        [DataMember(Name = "losses", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "losses")]
        public int? Losses { get; set; }

        /// <summary>
        /// Gets or Sets Ties
        /// </summary>
        [DataMember(Name = "ties", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ties")]
        public int? Ties { get; set; }

        /// <summary>
        /// Gets or Sets Saves
        /// </summary>
        [DataMember(Name = "saves", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "saves")]
        public int? Saves { get; set; }

        /// <summary>
        /// Gets or Sets SaveOpportunities
        /// </summary>
        [DataMember(Name = "saveOpportunities", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "saveOpportunities")]
        public int? SaveOpportunities { get; set; }

        /// <summary>
        /// Gets or Sets Holds
        /// </summary>
        [DataMember(Name = "holds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "holds")]
        public int? Holds { get; set; }

        /// <summary>
        /// Gets or Sets BlownSaves
        /// </summary>
        [DataMember(Name = "blownSaves", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "blownSaves")]
        public int? BlownSaves { get; set; }

        /// <summary>
        /// Gets or Sets PitchesThrown
        /// </summary>
        [DataMember(Name = "pitchesThrown", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchesThrown")]
        public int? PitchesThrown { get; set; }

        /// <summary>
        /// Gets or Sets Balls
        /// </summary>
        [DataMember(Name = "balls", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "balls")]
        public int? Balls { get; set; }

        /// <summary>
        /// Gets or Sets Strikes
        /// </summary>
        [DataMember(Name = "strikes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikes")]
        public int? Strikes { get; set; }

        /// <summary>
        /// Gets or Sets InningsPitched
        /// </summary>
        [DataMember(Name = "inningsPitched", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inningsPitched")]
        public string InningsPitched { get; set; }

        /// <summary>
        /// Gets or Sets OutsPitched
        /// </summary>
        [DataMember(Name = "outsPitched", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outsPitched")]
        public int? OutsPitched { get; set; }

        /// <summary>
        /// Gets or Sets EarnedRunAverage
        /// </summary>
        [DataMember(Name = "earnedRunAverage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "earnedRunAverage")]
        public string EarnedRunAverage { get; set; }

        /// <summary>
        /// Gets or Sets InheritedRuns
        /// </summary>
        [DataMember(Name = "inheritedRuns", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inheritedRuns")]
        public int? InheritedRuns { get; set; }

        /// <summary>
        /// Gets or Sets InheritedRunsScored
        /// </summary>
        [DataMember(Name = "inheritedRunsScored", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inheritedRunsScored")]
        public int? InheritedRunsScored { get; set; }

        /// <summary>
        /// Gets or Sets InheritedRunnersStrandedPercentage
        /// </summary>
        [DataMember(Name = "inheritedRunnersStrandedPercentage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inheritedRunnersStrandedPercentage")]
        public string InheritedRunnersStrandedPercentage { get; set; }

        /// <summary>
        /// Gets or Sets CompleteGames
        /// </summary>
        [DataMember(Name = "completeGames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "completeGames")]
        public int? CompleteGames { get; set; }

        /// <summary>
        /// Gets or Sets Shutouts
        /// </summary>
        [DataMember(Name = "shutouts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shutouts")]
        public int? Shutouts { get; set; }

        /// <summary>
        /// Gets or Sets Balks
        /// </summary>
        [DataMember(Name = "balks", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "balks")]
        public int? Balks { get; set; }

        /// <summary>
        /// Gets or Sets HitBatsmen
        /// </summary>
        [DataMember(Name = "hitBatsmen", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitBatsmen")]
        public int? HitBatsmen { get; set; }

        /// <summary>
        /// Gets or Sets RunsBattedIn
        /// </summary>
        [DataMember(Name = "runsBattedIn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runsBattedIn")]
        public int? RunsBattedIn { get; set; }

        /// <summary>
        /// Gets or Sets WinPercentage
        /// </summary>
        [DataMember(Name = "winPercentage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "winPercentage")]
        public string WinPercentage { get; set; }

        /// <summary>
        /// Gets or Sets PitchesPerInning
        /// </summary>
        [DataMember(Name = "pitchesPerInning", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchesPerInning")]
        public string PitchesPerInning { get; set; }

        /// <summary>
        /// Gets or Sets GamesFinished
        /// </summary>
        [DataMember(Name = "gamesFinished", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamesFinished")]
        public int? GamesFinished { get; set; }

        /// <summary>
        /// Gets or Sets StrikeoutWalkRatio
        /// </summary>
        [DataMember(Name = "strikeoutWalkRatio", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikeoutWalkRatio")]
        public string StrikeoutWalkRatio { get; set; }

        /// <summary>
        /// Gets or Sets StrikeoutsPer9Inn
        /// </summary>
        [DataMember(Name = "strikeoutsPer9Inn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikeoutsPer9Inn")]
        public string StrikeoutsPer9Inn { get; set; }

        /// <summary>
        /// Gets or Sets WalksPer9Inn
        /// </summary>
        [DataMember(Name = "walksPer9Inn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "walksPer9Inn")]
        public string WalksPer9Inn { get; set; }

        /// <summary>
        /// Gets or Sets HitsPer9Inn
        /// </summary>
        [DataMember(Name = "hitsPer9Inn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitsPer9Inn")]
        public string HitsPer9Inn { get; set; }

        /// <summary>
        /// Gets or Sets RunsScoredPer9
        /// </summary>
        [DataMember(Name = "runsScoredPer9", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runsScoredPer9")]
        public string RunsScoredPer9 { get; set; }

        /// <summary>
        /// Gets or Sets HomeRunsPer9
        /// </summary>
        [DataMember(Name = "homeRunsPer9", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeRunsPer9")]
        public string HomeRunsPer9 { get; set; }

        /// <summary>
        /// Gets or Sets StrikePercentage
        /// </summary>
        [DataMember(Name = "strikePercentage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikePercentage")]
        public string StrikePercentage { get; set; }

        /// <summary>
        /// Gets or Sets PitchingOrder
        /// </summary>
        [DataMember(Name = "pitchingOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchingOrder")]
        public int? PitchingOrder { get; set; }

        /// <summary>
        /// Gets or Sets PassedBall
        /// </summary>
        [DataMember(Name = "passedBall", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "passedBall")]
        public int? PassedBall { get; set; }

        /// <summary>
        /// Gets or Sets PlateAppearances
        /// </summary>
        [DataMember(Name = "plateAppearances", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "plateAppearances")]
        public int? PlateAppearances { get; set; }

        /// <summary>
        /// Gets or Sets RunsScoredPer9OrNull
        /// </summary>
        [DataMember(Name = "runsScoredPer9OrNull", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runsScoredPer9OrNull")]
        public string RunsScoredPer9OrNull { get; set; }

        /// <summary>
        /// Gets or Sets HomeRunsPer9OrNull
        /// </summary>
        [DataMember(Name = "homeRunsPer9OrNull", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeRunsPer9OrNull")]
        public string HomeRunsPer9OrNull { get; set; }

        /// <summary>
        /// Gets or Sets StrikePercentageOrNull
        /// </summary>
        [DataMember(Name = "strikePercentageOrNull", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikePercentageOrNull")]
        public string StrikePercentageOrNull { get; set; }

        /// <summary>
        /// Gets or Sets PitchesPerPlateAppearanceStr
        /// </summary>
        [DataMember(Name = "pitchesPerPlateAppearanceStr", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchesPerPlateAppearanceStr")]
        public string PitchesPerPlateAppearanceStr { get; set; }

        /// <summary>
        /// Gets or Sets StolenBasePercentageOrNull
        /// </summary>
        [DataMember(Name = "stolenBasePercentageOrNull", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stolenBasePercentageOrNull")]
        public string StolenBasePercentageOrNull { get; set; }

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
            sb.Append("class PitchingData {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  CatchersInterference: ").Append(CatchersInterference).Append("\n");
            sb.Append("  Average: ").Append(Average).Append("\n");
            sb.Append("  OnBasePercentage: ").Append(OnBasePercentage).Append("\n");
            sb.Append("  OnBasePlusSlugging: ").Append(OnBasePlusSlugging).Append("\n");
            sb.Append("  StolenBases: ").Append(StolenBases).Append("\n");
            sb.Append("  CaughtStealing: ").Append(CaughtStealing).Append("\n");
            sb.Append("  Slugging: ").Append(Slugging).Append("\n");
            sb.Append("  Outs: ").Append(Outs).Append("\n");
            sb.Append("  Gidp: ").Append(Gidp).Append("\n");
            sb.Append("  Gitp: ").Append(Gitp).Append("\n");
            sb.Append("  HomeRuns: ").Append(HomeRuns).Append("\n");
            sb.Append("  NumberOfPitches: ").Append(NumberOfPitches).Append("\n");
            sb.Append("  TotalBases: ").Append(TotalBases).Append("\n");
            sb.Append("  GidpOpportunites: ").Append(GidpOpportunites).Append("\n");
            sb.Append("  Walks: ").Append(Walks).Append("\n");
            sb.Append("  HitByPitch: ").Append(HitByPitch).Append("\n");
            sb.Append("  Strikeouts: ").Append(Strikeouts).Append("\n");
            sb.Append("  AirOuts: ").Append(AirOuts).Append("\n");
            sb.Append("  GoAo: ").Append(GoAo).Append("\n");
            sb.Append("  PitchesPerPlateAppearance: ").Append(PitchesPerPlateAppearance).Append("\n");
            sb.Append("  IntentionalWalks: ").Append(IntentionalWalks).Append("\n");
            sb.Append("  GroundOuts: ").Append(GroundOuts).Append("\n");
            sb.Append("  FlyOuts: ").Append(FlyOuts).Append("\n");
            sb.Append("  Games: ").Append(Games).Append("\n");
            sb.Append("  GamesStarted: ").Append(GamesStarted).Append("\n");
            sb.Append("  Doubles: ").Append(Doubles).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
            sb.Append("  Triples: ").Append(Triples).Append("\n");
            sb.Append("  Singles: ").Append(Singles).Append("\n");
            sb.Append("  Runs: ").Append(Runs).Append("\n");
            sb.Append("  AtBats: ").Append(AtBats).Append("\n");
            sb.Append("  Pickoffs: ").Append(Pickoffs).Append("\n");
            sb.Append("  StolenBasePercentage: ").Append(StolenBasePercentage).Append("\n");
            sb.Append("  WildPitches: ").Append(WildPitches).Append("\n");
            sb.Append("  SacFlies: ").Append(SacFlies).Append("\n");
            sb.Append("  SacBunts: ").Append(SacBunts).Append("\n");
            sb.Append("  Putouts: ").Append(Putouts).Append("\n");
            sb.Append("  Assists: ").Append(Assists).Append("\n");
            sb.Append("  Chances: ").Append(Chances).Append("\n");
            sb.Append("  Streak: ").Append(Streak).Append("\n");
            sb.Append("  BattingOrder: ").Append(BattingOrder).Append("\n");
            sb.Append("  TotalSwings: ").Append(TotalSwings).Append("\n");
            sb.Append("  SwingsAndMisses: ").Append(SwingsAndMisses).Append("\n");
            sb.Append("  BallsInPlay: ").Append(BallsInPlay).Append("\n");
            sb.Append("  PopOuts: ").Append(PopOuts).Append("\n");
            sb.Append("  LineOuts: ").Append(LineOuts).Append("\n");
            sb.Append("  FlyHits: ").Append(FlyHits).Append("\n");
            sb.Append("  PopHits: ").Append(PopHits).Append("\n");
            sb.Append("  LineHits: ").Append(LineHits).Append("\n");
            sb.Append("  GroundHits: ").Append(GroundHits).Append("\n");
            sb.Append("  GamesPlayedOnBothTeams: ").Append(GamesPlayedOnBothTeams).Append("\n");
            sb.Append("  BattersFaced: ").Append(BattersFaced).Append("\n");
            sb.Append("  EarnedRuns: ").Append(EarnedRuns).Append("\n");
            sb.Append("  WalksHitsPerInningPitched: ").Append(WalksHitsPerInningPitched).Append("\n");
            sb.Append("  Wins: ").Append(Wins).Append("\n");
            sb.Append("  Losses: ").Append(Losses).Append("\n");
            sb.Append("  Ties: ").Append(Ties).Append("\n");
            sb.Append("  Saves: ").Append(Saves).Append("\n");
            sb.Append("  SaveOpportunities: ").Append(SaveOpportunities).Append("\n");
            sb.Append("  Holds: ").Append(Holds).Append("\n");
            sb.Append("  BlownSaves: ").Append(BlownSaves).Append("\n");
            sb.Append("  PitchesThrown: ").Append(PitchesThrown).Append("\n");
            sb.Append("  Balls: ").Append(Balls).Append("\n");
            sb.Append("  Strikes: ").Append(Strikes).Append("\n");
            sb.Append("  InningsPitched: ").Append(InningsPitched).Append("\n");
            sb.Append("  OutsPitched: ").Append(OutsPitched).Append("\n");
            sb.Append("  EarnedRunAverage: ").Append(EarnedRunAverage).Append("\n");
            sb.Append("  InheritedRuns: ").Append(InheritedRuns).Append("\n");
            sb.Append("  InheritedRunsScored: ").Append(InheritedRunsScored).Append("\n");
            sb.Append("  InheritedRunnersStrandedPercentage: ").Append(InheritedRunnersStrandedPercentage).Append("\n");
            sb.Append("  CompleteGames: ").Append(CompleteGames).Append("\n");
            sb.Append("  Shutouts: ").Append(Shutouts).Append("\n");
            sb.Append("  Balks: ").Append(Balks).Append("\n");
            sb.Append("  HitBatsmen: ").Append(HitBatsmen).Append("\n");
            sb.Append("  RunsBattedIn: ").Append(RunsBattedIn).Append("\n");
            sb.Append("  WinPercentage: ").Append(WinPercentage).Append("\n");
            sb.Append("  PitchesPerInning: ").Append(PitchesPerInning).Append("\n");
            sb.Append("  GamesFinished: ").Append(GamesFinished).Append("\n");
            sb.Append("  StrikeoutWalkRatio: ").Append(StrikeoutWalkRatio).Append("\n");
            sb.Append("  StrikeoutsPer9Inn: ").Append(StrikeoutsPer9Inn).Append("\n");
            sb.Append("  WalksPer9Inn: ").Append(WalksPer9Inn).Append("\n");
            sb.Append("  HitsPer9Inn: ").Append(HitsPer9Inn).Append("\n");
            sb.Append("  RunsScoredPer9: ").Append(RunsScoredPer9).Append("\n");
            sb.Append("  HomeRunsPer9: ").Append(HomeRunsPer9).Append("\n");
            sb.Append("  StrikePercentage: ").Append(StrikePercentage).Append("\n");
            sb.Append("  PitchingOrder: ").Append(PitchingOrder).Append("\n");
            sb.Append("  PassedBall: ").Append(PassedBall).Append("\n");
            sb.Append("  PlateAppearances: ").Append(PlateAppearances).Append("\n");
            sb.Append("  RunsScoredPer9OrNull: ").Append(RunsScoredPer9OrNull).Append("\n");
            sb.Append("  HomeRunsPer9OrNull: ").Append(HomeRunsPer9OrNull).Append("\n");
            sb.Append("  StrikePercentageOrNull: ").Append(StrikePercentageOrNull).Append("\n");
            sb.Append("  PitchesPerPlateAppearanceStr: ").Append(PitchesPerPlateAppearanceStr).Append("\n");
            sb.Append("  StolenBasePercentageOrNull: ").Append(StolenBasePercentageOrNull).Append("\n");
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