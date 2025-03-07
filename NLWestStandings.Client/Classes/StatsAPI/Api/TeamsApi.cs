using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITeamsApi
    {
        /// <summary>
        /// View team and affiliate teams
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="teamIds">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">Season of play</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>TeamsRestObject</returns>
        TeamsRestObject Affiliates(int? teamId, List<int?> teamIds, int? sportId, string season, GameTypeEnum gameType, List<string> fields);

        /// <summary>
        /// View team and affiliate teams
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="teamIds">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">Season of play</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>TeamsRestObject</returns>
        TeamsRestObject Affiliates1(int? teamId, List<int?> teamIds, int? sportId, string season, GameTypeEnum gameType, List<string> fields);

        /// <summary>
        /// View historical records for a list of teams
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="teamIds">Comma delimited list of Unique Team identifiers</param>
        /// <param name="startSeason">Start date for range of data (used with end date optionally). Example: &#x27;2018&#x27; or &#x27;2018.2&#x27;</param>
        /// <param name="endSeason">End date for range of data (used with start date optionally). Format: &#x27;2018&#x27; or &#x27;2018.2&#x27;</param>
        /// <param name="fields"></param>
        /// <returns>TeamsRestObject</returns>
        TeamsRestObject AllTeams(int? teamId, List<int?> teamIds, string startSeason, string endSeason, List<string> fields);

        /// <summary>
        /// View historical records for a list of teams
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="teamIds">Comma delimited list of Unique Team identifiers</param>
        /// <param name="startSeason">Start date for range of data (used with end date optionally). Example: &#x27;2018&#x27; or &#x27;2018.2&#x27;</param>
        /// <param name="endSeason">End date for range of data (used with start date optionally). Format: &#x27;2018&#x27; or &#x27;2018.2&#x27;</param>
        /// <param name="fields"></param>
        /// <returns>TeamsRestObject</returns>
        TeamsRestObject AllTeams1(int? teamId, List<int?> teamIds, string startSeason, string endSeason, List<string> fields);

        /// <summary>
        /// View all team alumni
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="season">Season of play</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="fields"></param>
        /// <returns>PeopleRestObject</returns>
        PeopleRestObject Alumni(int? teamId, string season, StatGroup group, List<string> fields);

        /// <summary>
        /// View all coaches for a team
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="season">Season of play</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="fields"></param>
        /// <returns>RosterRestObject</returns>
        RosterRestObject Coaches(int? teamId, string season, DateTime? date, List<string> fields);

        /// <summary>
        /// View team stat leaders
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="leaderCategories"></param>
        /// <param name="season"></param>
        /// <param name="leaderGameTypes"></param>
        /// <param name="expand"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="playerPool"></param>
        /// <param name="fields"></param>
        /// <returns>TeamLeaderContainerRestObject</returns>
        TeamLeaderContainerRestObject Leaders(int? teamId, List<PersonLeadersEnum> leaderCategories, string season, List<GameTypeEnum> leaderGameTypes, List<ExpandEnum> expand, int? limit, int? offset, PlayerPoolEnum playerPool, List<string> fields);

        /// <summary>
        /// View leaders for team stats
        /// </summary>
        /// <param name="leaderCategories">TBD</param>
        /// <param name="gameTypes">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="stats">Type of statistics. Format: Individual, Team, Career, etc. Available types in /api/v1/statTypes</param>
        /// <param name="statType"></param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="statGroup">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="daysBack">Returns results from the last &#x27;X&#x27; days (Starting from yesterday).</param>
        /// <param name="sitCodes">Situation code for a given stat split.</param>
        /// <param name="opposingTeamId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="fields"></param>
        /// <returns>LeagueLeaderContainerRestObject</returns>
        LeagueLeaderContainerRestObject Leaders1(List<PersonLeadersEnum> leaderCategories, List<GameTypeEnum> gameTypes, List<StatType> stats, StatType statType, int? sportId, List<int?> sportIds, int? leagueId, List<int?> leagueIds, string season, List<StatGroup> statGroup, List<StatGroup> group, DateTime? startDate, DateTime? endDate, int? daysBack, string sitCodes, int? opposingTeamId, int? limit, int? offset, List<string> fields);

        /// <summary>
        /// View all coaches for a team
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="season">Season of play</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="fields"></param>
        /// <returns>RosterRestObject</returns>
        RosterRestObject Personnel(int? teamId, string season, DateTime? date, List<string> fields);

        /// <summary>
        /// View a teams roster This endpoint allows you to pull teams
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="rosterType">Type of roster. Available types in /api/v1/rosterTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>RosterRestObject</returns>
        RosterRestObject Roster(int? teamId, string rosterType, string season, DateTime? date, GameTypeEnum gameType, List<string> fields);

        /// <summary>
        /// View a teams roster This endpoint allows you to pull teams
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="rosterType">Type of roster. Available types in /api/v1/rosterTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>RosterRestObject</returns>
        RosterRestObject Roster1(int? teamId, string rosterType, string season, DateTime? date, GameTypeEnum gameType, List<string> fields);

        /// <summary>
        /// View a teams stats
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">Season of play</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="stats">Type of statistics. Format: Individual, Team, Career, etc. Available types in /api/v1/statTypes</param>
        /// <param name="sortStat">Baseball stat to sort splits by.</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="groupBy">Group stats by PLAYER, TEAM, SEASON, VENUE, SPORT or STAT_GROUP</param>
        /// <param name="opposingTeamId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="opposingPlayerId">A unique identifier for the opposing team</param>
        /// <param name="sitCodes">Situation code for a given stat split.</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StatsRestObject</returns>
        StatsRestObject Stats(int? teamId, List<StatGroup> group, int? sportId, string season, GameTypeEnum gameType, List<StatType> stats, BaseballStatsEnum sortStat, SortOrderEnum order, List<GroupByEnum> groupBy, int? opposingTeamId, int? opposingPlayerId, string sitCodes, DateTime? startDate, DateTime? endDate, List<string> fields);

        /// <summary>
        /// View a teams stats
        /// </summary>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="stats">Type of statistics. Format: Individual, Team, Career, etc. Available types in /api/v1/statTypes</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="sortStat">Baseball stat to sort splits by.</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="daysBack">Returns results from the last &#x27;X&#x27; days (Starting from yesterday).</param>
        /// <param name="sitCodes">Situation code for a given stat split.</param>
        /// <param name="combineSits">If true, gathers stats where all of the situational criteria are met. If false, returns stats where any of the situational criteria are met. Default: false</param>
        /// <param name="opposingTeamId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="fields"></param>
        /// <returns>StatsRestObject</returns>
        StatsRestObject Stats1(List<StatGroup> group, GameTypeEnum gameType, List<StatType> stats, int? sportId, List<int?> sportIds, List<int?> leagueIds, string season, BaseballStatsEnum sortStat, SortOrderEnum order, DateTime? startDate, DateTime? endDate, int? daysBack, string sitCodes, bool? combineSits, int? opposingTeamId, int? offset, int? limit, List<string> fields);

        /// <summary>
        /// View info for all teams This endpoint allows you to pull teams
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="season">Season of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="divisionId">Unique Division Identifier</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="activeStatus">Flag for fetching teams that are currently active (Y), inactive (N), pending (P), or all teams (B)</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="allStarStatuses"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>TeamsRestObject</returns>
        TeamsRestObject Teams(int? teamId, string season, int? sportId, int? divisionId, GameTypeEnum gameType, List<int?> leagueIds, List<int?> sportIds, TeamActiveStatusEnum activeStatus, LeagueListsEnum leagueListId, List<AllStarEnum> allStarStatuses, List<string> fields);

        /// <summary>
        /// View info for all teams This endpoint allows you to pull teams
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="season">Season of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="divisionId">Unique Division Identifier</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="activeStatus">Flag for fetching teams that are currently active (Y), inactive (N), pending (P), or all teams (B)</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="allStarStatuses"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>TeamsRestObject</returns>
        TeamsRestObject Teams1(int? teamId, string season, int? sportId, int? divisionId, GameTypeEnum gameType, List<int?> leagueIds, List<int?> sportIds, TeamActiveStatusEnum activeStatus, LeagueListsEnum leagueListId, List<AllStarEnum> allStarStatuses, List<string> fields);

        /// <summary>
        ///
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="season">Season of play</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="fields"></param>
        /// <returns>string</returns>
        string UpdateAlumni(int? teamId, string season, StatGroup group, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TeamsApi : ITeamsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TeamsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TeamsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// View team and affiliate teams
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="teamIds">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">Season of play</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>TeamsRestObject</returns>
        public TeamsRestObject Affiliates(int? teamId, List<int?> teamIds, int? sportId, string season, GameTypeEnum gameType, List<string> fields)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling Affiliates");

            var path = "/api/v1/teams/{teamId}/affiliates";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "teamId" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (teamIds != null) queryParams.Add("teamIds", ApiClient.ParameterToString(teamIds)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Affiliates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Affiliates: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamsRestObject)ApiClient.Deserialize(response.Content, typeof(TeamsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View team and affiliate teams
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="teamIds">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">Season of play</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>TeamsRestObject</returns>
        public TeamsRestObject Affiliates1(int? teamId, List<int?> teamIds, int? sportId, string season, GameTypeEnum gameType, List<string> fields)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling Affiliates1");

            var path = "/api/v1/teams/affiliates";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "teamId" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (teamIds != null) queryParams.Add("teamIds", ApiClient.ParameterToString(teamIds)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Affiliates1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Affiliates1: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamsRestObject)ApiClient.Deserialize(response.Content, typeof(TeamsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View historical records for a list of teams
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="teamIds">Comma delimited list of Unique Team identifiers</param>
        /// <param name="startSeason">Start date for range of data (used with end date optionally). Example: &#x27;2018&#x27; or &#x27;2018.2&#x27;</param>
        /// <param name="endSeason">End date for range of data (used with start date optionally). Format: &#x27;2018&#x27; or &#x27;2018.2&#x27;</param>
        /// <param name="fields"></param>
        /// <returns>TeamsRestObject</returns>
        public TeamsRestObject AllTeams(int? teamId, List<int?> teamIds, string startSeason, string endSeason, List<string> fields)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling AllTeams");

            var path = "/api/v1/teams/{teamId}/history";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "teamId" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (teamIds != null) queryParams.Add("teamIds", ApiClient.ParameterToString(teamIds)); // query parameter
            if (startSeason != null) queryParams.Add("startSeason", ApiClient.ParameterToString(startSeason)); // query parameter
            if (endSeason != null) queryParams.Add("endSeason", ApiClient.ParameterToString(endSeason)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AllTeams: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AllTeams: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamsRestObject)ApiClient.Deserialize(response.Content, typeof(TeamsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View historical records for a list of teams
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="teamIds">Comma delimited list of Unique Team identifiers</param>
        /// <param name="startSeason">Start date for range of data (used with end date optionally). Example: &#x27;2018&#x27; or &#x27;2018.2&#x27;</param>
        /// <param name="endSeason">End date for range of data (used with start date optionally). Format: &#x27;2018&#x27; or &#x27;2018.2&#x27;</param>
        /// <param name="fields"></param>
        /// <returns>TeamsRestObject</returns>
        public TeamsRestObject AllTeams1(int? teamId, List<int?> teamIds, string startSeason, string endSeason, List<string> fields)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling AllTeams1");

            var path = "/api/v1/teams/history";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "teamId" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (teamIds != null) queryParams.Add("teamIds", ApiClient.ParameterToString(teamIds)); // query parameter
            if (startSeason != null) queryParams.Add("startSeason", ApiClient.ParameterToString(startSeason)); // query parameter
            if (endSeason != null) queryParams.Add("endSeason", ApiClient.ParameterToString(endSeason)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AllTeams1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AllTeams1: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamsRestObject)ApiClient.Deserialize(response.Content, typeof(TeamsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View all team alumni
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="season">Season of play</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="fields"></param>
        /// <returns>PeopleRestObject</returns>
        public PeopleRestObject Alumni(int? teamId, string season, StatGroup group, List<string> fields)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling Alumni");
            // verify the required parameter 'season' is set
            if (season == null) throw new ApiException(400, "Missing required parameter 'season' when calling Alumni");

            var path = "/api/v1/teams/{teamId}/alumni";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "teamId" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Alumni: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Alumni: " + response.ErrorMessage, response.ErrorMessage);

            return (PeopleRestObject)ApiClient.Deserialize(response.Content, typeof(PeopleRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View all coaches for a team
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="season">Season of play</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="fields"></param>
        /// <returns>RosterRestObject</returns>
        public RosterRestObject Coaches(int? teamId, string season, DateTime? date, List<string> fields)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling Coaches");

            var path = "/api/v1/teams/{teamId}/coaches";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "teamId" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Coaches: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Coaches: " + response.ErrorMessage, response.ErrorMessage);

            return (RosterRestObject)ApiClient.Deserialize(response.Content, typeof(RosterRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View team stat leaders
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="leaderCategories"></param>
        /// <param name="season"></param>
        /// <param name="leaderGameTypes"></param>
        /// <param name="expand"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="playerPool"></param>
        /// <param name="fields"></param>
        /// <returns>TeamLeaderContainerRestObject</returns>
        public TeamLeaderContainerRestObject Leaders(int? teamId, List<PersonLeadersEnum> leaderCategories, string season, List<GameTypeEnum> leaderGameTypes, List<ExpandEnum> expand, int? limit, int? offset, PlayerPoolEnum playerPool, List<string> fields)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling Leaders");

            var path = "/api/v1/teams/{teamId}/leaders";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "teamId" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (leaderCategories != null) queryParams.Add("leaderCategories", ApiClient.ParameterToString(leaderCategories)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (leaderGameTypes != null) queryParams.Add("leaderGameTypes", ApiClient.ParameterToString(leaderGameTypes)); // query parameter
            if (expand != null) queryParams.Add("expand", ApiClient.ParameterToString(expand)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (playerPool != null) queryParams.Add("playerPool", ApiClient.ParameterToString(playerPool)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Leaders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Leaders: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamLeaderContainerRestObject)ApiClient.Deserialize(response.Content, typeof(TeamLeaderContainerRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View leaders for team stats
        /// </summary>
        /// <param name="leaderCategories">TBD</param>
        /// <param name="gameTypes">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="stats">Type of statistics. Format: Individual, Team, Career, etc. Available types in /api/v1/statTypes</param>
        /// <param name="statType"></param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="statGroup">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="daysBack">Returns results from the last &#x27;X&#x27; days (Starting from yesterday).</param>
        /// <param name="sitCodes">Situation code for a given stat split.</param>
        /// <param name="opposingTeamId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="fields"></param>
        /// <returns>LeagueLeaderContainerRestObject</returns>
        public LeagueLeaderContainerRestObject Leaders1(List<PersonLeadersEnum> leaderCategories, List<GameTypeEnum> gameTypes, List<StatType> stats, StatType statType, int? sportId, List<int?> sportIds, int? leagueId, List<int?> leagueIds, string season, List<StatGroup> statGroup, List<StatGroup> group, DateTime? startDate, DateTime? endDate, int? daysBack, string sitCodes, int? opposingTeamId, int? limit, int? offset, List<string> fields)
        {
            var path = "/api/v1/teams/stats/leaders";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (leaderCategories != null) queryParams.Add("leaderCategories", ApiClient.ParameterToString(leaderCategories)); // query parameter
            if (gameTypes != null) queryParams.Add("gameTypes", ApiClient.ParameterToString(gameTypes)); // query parameter
            if (stats != null) queryParams.Add("stats", ApiClient.ParameterToString(stats)); // query parameter
            if (statType != null) queryParams.Add("statType", ApiClient.ParameterToString(statType)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (sportIds != null) queryParams.Add("sportIds", ApiClient.ParameterToString(sportIds)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (statGroup != null) queryParams.Add("statGroup", ApiClient.ParameterToString(statGroup)); // query parameter
            if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (daysBack != null) queryParams.Add("daysBack", ApiClient.ParameterToString(daysBack)); // query parameter
            if (sitCodes != null) queryParams.Add("sitCodes", ApiClient.ParameterToString(sitCodes)); // query parameter
            if (opposingTeamId != null) queryParams.Add("opposingTeamId", ApiClient.ParameterToString(opposingTeamId)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Leaders1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Leaders1: " + response.ErrorMessage, response.ErrorMessage);

            return (LeagueLeaderContainerRestObject)ApiClient.Deserialize(response.Content, typeof(LeagueLeaderContainerRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View all coaches for a team
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="season">Season of play</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="fields"></param>
        /// <returns>RosterRestObject</returns>
        public RosterRestObject Personnel(int? teamId, string season, DateTime? date, List<string> fields)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling Personnel");

            var path = "/api/v1/teams/{teamId}/personnel";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "teamId" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Personnel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Personnel: " + response.ErrorMessage, response.ErrorMessage);

            return (RosterRestObject)ApiClient.Deserialize(response.Content, typeof(RosterRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View a teams roster This endpoint allows you to pull teams
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="rosterType">Type of roster. Available types in /api/v1/rosterTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>RosterRestObject</returns>
        public RosterRestObject Roster(int? teamId, string rosterType, string season, DateTime? date, GameTypeEnum gameType, List<string> fields)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling Roster");
            // verify the required parameter 'rosterType' is set
            if (rosterType == null) throw new ApiException(400, "Missing required parameter 'rosterType' when calling Roster");

            var path = "/api/v1/teams/{teamId}/roster";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "teamId" + "}", ApiClient.ParameterToString(teamId));
            path = path.Replace("{" + "rosterType" + "}", ApiClient.ParameterToString(rosterType));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Roster: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Roster: " + response.ErrorMessage, response.ErrorMessage);

            return (RosterRestObject)ApiClient.Deserialize(response.Content, typeof(RosterRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View a teams roster This endpoint allows you to pull teams
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="rosterType">Type of roster. Available types in /api/v1/rosterTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>RosterRestObject</returns>
        public RosterRestObject Roster1(int? teamId, string rosterType, string season, DateTime? date, GameTypeEnum gameType, List<string> fields)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling Roster1");
            // verify the required parameter 'rosterType' is set
            if (rosterType == null) throw new ApiException(400, "Missing required parameter 'rosterType' when calling Roster1");

            var path = "/api/v1/teams/{teamId}/roster/{rosterType}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "teamId" + "}", ApiClient.ParameterToString(teamId));
            path = path.Replace("{" + "rosterType" + "}", ApiClient.ParameterToString(rosterType));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Roster1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Roster1: " + response.ErrorMessage, response.ErrorMessage);

            return (RosterRestObject)ApiClient.Deserialize(response.Content, typeof(RosterRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View a teams stats
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">Season of play</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="stats">Type of statistics. Format: Individual, Team, Career, etc. Available types in /api/v1/statTypes</param>
        /// <param name="sortStat">Baseball stat to sort splits by.</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="groupBy">Group stats by PLAYER, TEAM, SEASON, VENUE, SPORT or STAT_GROUP</param>
        /// <param name="opposingTeamId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="opposingPlayerId">A unique identifier for the opposing team</param>
        /// <param name="sitCodes">Situation code for a given stat split.</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StatsRestObject</returns>
        public StatsRestObject Stats(int? teamId, List<StatGroup> group, int? sportId, string season, GameTypeEnum gameType, List<StatType> stats, BaseballStatsEnum sortStat, SortOrderEnum order, List<GroupByEnum> groupBy, int? opposingTeamId, int? opposingPlayerId, string sitCodes, DateTime? startDate, DateTime? endDate, List<string> fields)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling Stats");
            // verify the required parameter 'group' is set
            if (group == null) throw new ApiException(400, "Missing required parameter 'group' when calling Stats");

            var path = "/api/v1/teams/{teamId}/stats";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "teamId" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (stats != null) queryParams.Add("stats", ApiClient.ParameterToString(stats)); // query parameter
            if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
            if (sortStat != null) queryParams.Add("sortStat", ApiClient.ParameterToString(sortStat)); // query parameter
            if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
            if (groupBy != null) queryParams.Add("groupBy", ApiClient.ParameterToString(groupBy)); // query parameter
            if (opposingTeamId != null) queryParams.Add("opposingTeamId", ApiClient.ParameterToString(opposingTeamId)); // query parameter
            if (opposingPlayerId != null) queryParams.Add("opposingPlayerId", ApiClient.ParameterToString(opposingPlayerId)); // query parameter
            if (sitCodes != null) queryParams.Add("sitCodes", ApiClient.ParameterToString(sitCodes)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Stats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Stats: " + response.ErrorMessage, response.ErrorMessage);

            return (StatsRestObject)ApiClient.Deserialize(response.Content, typeof(StatsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View a teams stats
        /// </summary>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="stats">Type of statistics. Format: Individual, Team, Career, etc. Available types in /api/v1/statTypes</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="sortStat">Baseball stat to sort splits by.</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="daysBack">Returns results from the last &#x27;X&#x27; days (Starting from yesterday).</param>
        /// <param name="sitCodes">Situation code for a given stat split.</param>
        /// <param name="combineSits">If true, gathers stats where all of the situational criteria are met. If false, returns stats where any of the situational criteria are met. Default: false</param>
        /// <param name="opposingTeamId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="fields"></param>
        /// <returns>StatsRestObject</returns>
        public StatsRestObject Stats1(List<StatGroup> group, GameTypeEnum gameType, List<StatType> stats, int? sportId, List<int?> sportIds, List<int?> leagueIds, string season, BaseballStatsEnum sortStat, SortOrderEnum order, DateTime? startDate, DateTime? endDate, int? daysBack, string sitCodes, bool? combineSits, int? opposingTeamId, int? offset, int? limit, List<string> fields)
        {
            // verify the required parameter 'group' is set
            if (group == null) throw new ApiException(400, "Missing required parameter 'group' when calling Stats1");

            var path = "/api/v1/teams/stats";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (stats != null) queryParams.Add("stats", ApiClient.ParameterToString(stats)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (sportIds != null) queryParams.Add("sportIds", ApiClient.ParameterToString(sportIds)); // query parameter
            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
            if (sortStat != null) queryParams.Add("sortStat", ApiClient.ParameterToString(sortStat)); // query parameter
            if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (daysBack != null) queryParams.Add("daysBack", ApiClient.ParameterToString(daysBack)); // query parameter
            if (sitCodes != null) queryParams.Add("sitCodes", ApiClient.ParameterToString(sitCodes)); // query parameter
            if (combineSits != null) queryParams.Add("combineSits", ApiClient.ParameterToString(combineSits)); // query parameter
            if (opposingTeamId != null) queryParams.Add("opposingTeamId", ApiClient.ParameterToString(opposingTeamId)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Stats1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Stats1: " + response.ErrorMessage, response.ErrorMessage);

            return (StatsRestObject)ApiClient.Deserialize(response.Content, typeof(StatsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View info for all teams This endpoint allows you to pull teams
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="season">Season of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="divisionId">Unique Division Identifier</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="activeStatus">Flag for fetching teams that are currently active (Y), inactive (N), pending (P), or all teams (B)</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="allStarStatuses"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>TeamsRestObject</returns>
        public TeamsRestObject Teams(int? teamId, string season, int? sportId, int? divisionId, GameTypeEnum gameType, List<int?> leagueIds, List<int?> sportIds, TeamActiveStatusEnum activeStatus, LeagueListsEnum leagueListId, List<AllStarEnum> allStarStatuses, List<string> fields)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling Teams");

            var path = "/api/v1/teams";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "teamId" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (divisionId != null) queryParams.Add("divisionId", ApiClient.ParameterToString(divisionId)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (sportIds != null) queryParams.Add("sportIds", ApiClient.ParameterToString(sportIds)); // query parameter
            if (activeStatus != null) queryParams.Add("activeStatus", ApiClient.ParameterToString(activeStatus)); // query parameter
            if (leagueListId != null) queryParams.Add("leagueListId", ApiClient.ParameterToString(leagueListId)); // query parameter
            if (allStarStatuses != null) queryParams.Add("allStarStatuses", ApiClient.ParameterToString(allStarStatuses)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Teams: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Teams: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamsRestObject)ApiClient.Deserialize(response.Content, typeof(TeamsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View info for all teams This endpoint allows you to pull teams
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="season">Season of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="divisionId">Unique Division Identifier</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="activeStatus">Flag for fetching teams that are currently active (Y), inactive (N), pending (P), or all teams (B)</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="allStarStatuses"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>TeamsRestObject</returns>
        public TeamsRestObject Teams1(int? teamId, string season, int? sportId, int? divisionId, GameTypeEnum gameType, List<int?> leagueIds, List<int?> sportIds, TeamActiveStatusEnum activeStatus, LeagueListsEnum leagueListId, List<AllStarEnum> allStarStatuses, List<string> fields)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling Teams1");

            var path = "/api/v1/teams/{teamId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "teamId" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (divisionId != null) queryParams.Add("divisionId", ApiClient.ParameterToString(divisionId)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (sportIds != null) queryParams.Add("sportIds", ApiClient.ParameterToString(sportIds)); // query parameter
            if (activeStatus != null) queryParams.Add("activeStatus", ApiClient.ParameterToString(activeStatus)); // query parameter
            if (leagueListId != null) queryParams.Add("leagueListId", ApiClient.ParameterToString(leagueListId)); // query parameter
            if (allStarStatuses != null) queryParams.Add("allStarStatuses", ApiClient.ParameterToString(allStarStatuses)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Teams1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Teams1: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamsRestObject)ApiClient.Deserialize(response.Content, typeof(TeamsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="season">Season of play</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="fields"></param>
        /// <returns>string</returns>
        public string UpdateAlumni(int? teamId, string season, StatGroup group, List<string> fields)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling UpdateAlumni");
            // verify the required parameter 'season' is set
            if (season == null) throw new ApiException(400, "Missing required parameter 'season' when calling UpdateAlumni");

            var path = "/api/v1/teams/{teamId}/alumni";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "teamId" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAlumni: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAlumni: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }
    }
}