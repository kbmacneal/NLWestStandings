using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPersonApi
    {
        /// <summary>
        /// View a player&#x27;s awards
        /// </summary>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>AwardsRestObject</returns>
        AwardsRestObject Award(int? personId, List<string> fields);

        /// <summary>
        /// View a player&#x27;s change log
        /// </summary>
        /// <param name="updatedSince">Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>PeopleRestObject</returns>
        PeopleRestObject CurrentGameStats(DateTime? updatedSince, int? limit, int? offset, bool? accent, List<string> fields);

        /// <summary>
        /// Get free agents
        /// </summary>
        /// <param name="season">Season of play</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <param name="fields"></param>
        /// <returns>FreeAgentListRestObject</returns>
        FreeAgentListRestObject FreeAgents(string season, SortOrderEnum order, bool? accent, List<string> fields);

        /// <summary>
        /// View a player This endpoint allows you to pull the information of players
        /// </summary>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="personIds">Comma delimited list of person ID. Format: 1234, 2345</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <param name="season">Season of play</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>PeopleRestObject</returns>
        PeopleRestObject Person(int? personId, List<int?> personIds, bool? accent, string season, List<StatGroup> group, List<string> fields);

        /// <summary>
        /// View a player This endpoint allows you to pull the information of players
        /// </summary>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="personIds">Comma delimited list of person ID. Format: 1234, 2345</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <param name="season">Season of play</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>PeopleRestObject</returns>
        PeopleRestObject Person1(int? personId, List<int?> personIds, bool? accent, string season, List<StatGroup> group, List<string> fields);

        /// <summary>
        /// View a player&#x27;s game stats
        /// </summary>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StatsRestObject</returns>
        StatsRestObject PlayerGameStats(int? personId, int? gamePk, List<StatGroup> group, List<string> fields);

        /// <summary>
        /// Search for a player by name
        /// </summary>
        /// <param name="names">Name a player uses</param>
        /// <param name="personIds">Comma delimited list of person ID. Format: 1234, 2345</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="teamIds">Comma delimited list of Unique Team identifiers</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="active">Whether or not a player is active</param>
        /// <param name="verified">Complete and confirmed all biographical data</param>
        /// <param name="rookie">Whether or not a player is a rookie</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <param name="limit">Number of results to return</param>
        /// <returns>PeopleRestObject</returns>
        PeopleRestObject Search(List<string> names, List<int?> personIds, List<int?> sportIds, List<int?> leagueIds, List<int?> teamIds, LeagueListsEnum leagueListId, bool? active, bool? verified, bool? rookie, List<string> seasons, List<string> fields, bool? accent, int? limit);

        /// <summary>
        /// View a players stats
        /// </summary>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="stats">Type of statistics. Format: Individual, Team, Career, etc. Available types in /api/v1/statTypes</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="opposingTeamId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="opposingPlayerId">A unique identifier for the opposing team</param>
        /// <param name="metrics">Name of metric(s) for metric log stats.  Available metrics in /api/v1/metrics</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="sitCodes">Situation code for a given stat split.</param>
        /// <param name="combineSits">If true, gathers stats where all of the situational criteria are met. If false, returns stats where any of the situational criteria are met. Default: false</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="daysBack">Returns results from the last &#x27;X&#x27; days (Starting from yesterday).</param>
        /// <param name="gamesBack">Returns results from the last &#x27;X&#x27; games played.</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="eventType">Type of event</param>
        /// <param name="pitchType">Classification of pitch (fastball, curveball, etc...)</param>
        /// <param name="hitTrajectory">Trajectory of hit (line drive, fly ball, etc...)</param>
        /// <param name="batSide">Bat side of hitter</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="groupBy">Group stats by PLAYER, TEAM, SEASON, VENUE, SPORT or STAT_GROUP</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StatsRestObject</returns>
        StatsRestObject Stats3(int? personId, List<StatType> stats, List<StatGroup> group, string season, List<string> seasons, int? sportId, int? opposingTeamId, int? opposingPlayerId, List<MetricType> metrics, int? leagueId, LeagueListsEnum leagueListId, List<string> sitCodes, bool? combineSits, DateTime? startDate, DateTime? endDate, int? daysBack, int? gamesBack, int? limit, List<EventType> eventType, List<string> pitchType, List<HitTrajectory> hitTrajectory, string batSide, List<GameTypeEnum> gameType, List<GroupByEnum> groupBy, bool? accent, List<string> fields);

        /// <summary>
        /// View a player&#x27;s stat metrics
        /// </summary>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="stats">Type of statistics. Format: Individual, Team, Career, etc. Available types in /api/v1/statTypes</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="opposingTeamId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="opposingPlayerId">A unique identifier for the opposing team</param>
        /// <param name="metrics">Name of metric(s) for metric log stats.  Available metrics in /api/v1/metrics</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="sitCodes">Situation code for a given stat split.</param>
        /// <param name="combineSits">If true, gathers stats where all of the situational criteria are met. If false, returns stats where any of the situational criteria are met. Default: false</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="daysBack">Returns results from the last &#x27;X&#x27; days (Starting from yesterday).</param>
        /// <param name="gamesBack">Returns results from the last &#x27;X&#x27; games played.</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="eventType">Type of event</param>
        /// <param name="pitchType">Classification of pitch (fastball, curveball, etc...)</param>
        /// <param name="hitTrajectory">Trajectory of hit (line drive, fly ball, etc...)</param>
        /// <param name="batSide">Bat side of hitter</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="groupBy">Group stats by PLAYER, TEAM, SEASON, VENUE, SPORT or STAT_GROUP</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StatsRestObject</returns>
        StatsRestObject StatsMetrics(int? personId, List<StatType> stats, List<StatGroup> group, string season, List<string> seasons, int? sportId, int? opposingTeamId, int? opposingPlayerId, List<MetricType> metrics, int? leagueId, LeagueListsEnum leagueListId, List<string> sitCodes, bool? combineSits, DateTime? startDate, DateTime? endDate, int? daysBack, int? gamesBack, int? limit, List<EventType> eventType, List<string> pitchType, List<HitTrajectory> hitTrajectory, string batSide, List<GameTypeEnum> gameType, List<GroupByEnum> groupBy, bool? accent, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PersonApi : IPersonApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PersonApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PersonApi(String basePath)
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
        /// View a player&#x27;s awards
        /// </summary>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>AwardsRestObject</returns>
        public AwardsRestObject Award(int? personId, List<string> fields)
        {
            // verify the required parameter 'personId' is set
            if (personId == null) throw new ApiException(400, "Missing required parameter 'personId' when calling Award");

            var path = "/api/v1/people/{personId}/awards";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "personId" + "}", ApiClient.ParameterToString(personId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Award: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Award: " + response.ErrorMessage, response.ErrorMessage);

            return (AwardsRestObject)ApiClient.Deserialize(response.Content, typeof(AwardsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View a player&#x27;s change log
        /// </summary>
        /// <param name="updatedSince">Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>PeopleRestObject</returns>
        public PeopleRestObject CurrentGameStats(DateTime? updatedSince, int? limit, int? offset, bool? accent, List<string> fields)
        {
            // verify the required parameter 'updatedSince' is set
            if (updatedSince == null) throw new ApiException(400, "Missing required parameter 'updatedSince' when calling CurrentGameStats");

            var path = "/api/v1/people/changes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (updatedSince != null) queryParams.Add("updatedSince", ApiClient.ParameterToString(updatedSince)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (accent != null) queryParams.Add("accent", ApiClient.ParameterToString(accent)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CurrentGameStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CurrentGameStats: " + response.ErrorMessage, response.ErrorMessage);

            return (PeopleRestObject)ApiClient.Deserialize(response.Content, typeof(PeopleRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get free agents
        /// </summary>
        /// <param name="season">Season of play</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <param name="fields"></param>
        /// <returns>FreeAgentListRestObject</returns>
        public FreeAgentListRestObject FreeAgents(string season, SortOrderEnum order, bool? accent, List<string> fields)
        {
            // verify the required parameter 'season' is set
            if (season == null) throw new ApiException(400, "Missing required parameter 'season' when calling FreeAgents");

            var path = "/api/v1/people/freeAgents";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
            if (accent != null) queryParams.Add("accent", ApiClient.ParameterToString(accent)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling FreeAgents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling FreeAgents: " + response.ErrorMessage, response.ErrorMessage);

            return (FreeAgentListRestObject)ApiClient.Deserialize(response.Content, typeof(FreeAgentListRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View a player This endpoint allows you to pull the information of players
        /// </summary>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="personIds">Comma delimited list of person ID. Format: 1234, 2345</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <param name="season">Season of play</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>PeopleRestObject</returns>
        public PeopleRestObject Person(int? personId, List<int?> personIds, bool? accent, string season, List<StatGroup> group, List<string> fields)
        {
            // verify the required parameter 'personId' is set
            if (personId == null) throw new ApiException(400, "Missing required parameter 'personId' when calling Person");

            var path = "/api/v1/people/{personId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "personId" + "}", ApiClient.ParameterToString(personId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (personIds != null) queryParams.Add("personIds", ApiClient.ParameterToString(personIds)); // query parameter
            if (accent != null) queryParams.Add("accent", ApiClient.ParameterToString(accent)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Person: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Person: " + response.ErrorMessage, response.ErrorMessage);

            return (PeopleRestObject)ApiClient.Deserialize(response.Content, typeof(PeopleRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View a player This endpoint allows you to pull the information of players
        /// </summary>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="personIds">Comma delimited list of person ID. Format: 1234, 2345</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <param name="season">Season of play</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>PeopleRestObject</returns>
        public PeopleRestObject Person1(int? personId, List<int?> personIds, bool? accent, string season, List<StatGroup> group, List<string> fields)
        {
            // verify the required parameter 'personId' is set
            if (personId == null) throw new ApiException(400, "Missing required parameter 'personId' when calling Person1");

            var path = "/api/v1/people";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "personId" + "}", ApiClient.ParameterToString(personId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (personIds != null) queryParams.Add("personIds", ApiClient.ParameterToString(personIds)); // query parameter
            if (accent != null) queryParams.Add("accent", ApiClient.ParameterToString(accent)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Person1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Person1: " + response.ErrorMessage, response.ErrorMessage);

            return (PeopleRestObject)ApiClient.Deserialize(response.Content, typeof(PeopleRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View a player&#x27;s game stats
        /// </summary>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StatsRestObject</returns>
        public StatsRestObject PlayerGameStats(int? personId, int? gamePk, List<StatGroup> group, List<string> fields)
        {
            // verify the required parameter 'personId' is set
            if (personId == null) throw new ApiException(400, "Missing required parameter 'personId' when calling PlayerGameStats");
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling PlayerGameStats");

            var path = "/api/v1/people/{personId}/stats/game/{gamePk}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "personId" + "}", ApiClient.ParameterToString(personId));
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PlayerGameStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PlayerGameStats: " + response.ErrorMessage, response.ErrorMessage);

            return (StatsRestObject)ApiClient.Deserialize(response.Content, typeof(StatsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Search for a player by name
        /// </summary>
        /// <param name="names">Name a player uses</param>
        /// <param name="personIds">Comma delimited list of person ID. Format: 1234, 2345</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="teamIds">Comma delimited list of Unique Team identifiers</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="active">Whether or not a player is active</param>
        /// <param name="verified">Complete and confirmed all biographical data</param>
        /// <param name="rookie">Whether or not a player is a rookie</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <param name="limit">Number of results to return</param>
        /// <returns>PeopleRestObject</returns>
        public PeopleRestObject Search(List<string> names, List<int?> personIds, List<int?> sportIds, List<int?> leagueIds, List<int?> teamIds, LeagueListsEnum leagueListId, bool? active, bool? verified, bool? rookie, List<string> seasons, List<string> fields, bool? accent, int? limit)
        {
            var path = "/api/v1/people/search";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (names != null) queryParams.Add("names", ApiClient.ParameterToString(names)); // query parameter
            if (personIds != null) queryParams.Add("personIds", ApiClient.ParameterToString(personIds)); // query parameter
            if (sportIds != null) queryParams.Add("sportIds", ApiClient.ParameterToString(sportIds)); // query parameter
            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (teamIds != null) queryParams.Add("teamIds", ApiClient.ParameterToString(teamIds)); // query parameter
            if (leagueListId != null) queryParams.Add("leagueListId", ApiClient.ParameterToString(leagueListId)); // query parameter
            if (active != null) queryParams.Add("active", ApiClient.ParameterToString(active)); // query parameter
            if (verified != null) queryParams.Add("verified", ApiClient.ParameterToString(verified)); // query parameter
            if (rookie != null) queryParams.Add("rookie", ApiClient.ParameterToString(rookie)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (accent != null) queryParams.Add("accent", ApiClient.ParameterToString(accent)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Search: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Search: " + response.ErrorMessage, response.ErrorMessage);

            return (PeopleRestObject)ApiClient.Deserialize(response.Content, typeof(PeopleRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View a players stats
        /// </summary>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="stats">Type of statistics. Format: Individual, Team, Career, etc. Available types in /api/v1/statTypes</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="opposingTeamId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="opposingPlayerId">A unique identifier for the opposing team</param>
        /// <param name="metrics">Name of metric(s) for metric log stats.  Available metrics in /api/v1/metrics</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="sitCodes">Situation code for a given stat split.</param>
        /// <param name="combineSits">If true, gathers stats where all of the situational criteria are met. If false, returns stats where any of the situational criteria are met. Default: false</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="daysBack">Returns results from the last &#x27;X&#x27; days (Starting from yesterday).</param>
        /// <param name="gamesBack">Returns results from the last &#x27;X&#x27; games played.</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="eventType">Type of event</param>
        /// <param name="pitchType">Classification of pitch (fastball, curveball, etc...)</param>
        /// <param name="hitTrajectory">Trajectory of hit (line drive, fly ball, etc...)</param>
        /// <param name="batSide">Bat side of hitter</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="groupBy">Group stats by PLAYER, TEAM, SEASON, VENUE, SPORT or STAT_GROUP</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StatsRestObject</returns>
        public StatsRestObject Stats3(int? personId, List<StatType> stats, List<StatGroup> group, string season, List<string> seasons, int? sportId, int? opposingTeamId, int? opposingPlayerId, List<MetricType> metrics, int? leagueId, LeagueListsEnum leagueListId, List<string> sitCodes, bool? combineSits, DateTime? startDate, DateTime? endDate, int? daysBack, int? gamesBack, int? limit, List<EventType> eventType, List<string> pitchType, List<HitTrajectory> hitTrajectory, string batSide, List<GameTypeEnum> gameType, List<GroupByEnum> groupBy, bool? accent, List<string> fields)
        {
            // verify the required parameter 'personId' is set
            if (personId == null) throw new ApiException(400, "Missing required parameter 'personId' when calling Stats3");
            // verify the required parameter 'stats' is set
            if (stats == null) throw new ApiException(400, "Missing required parameter 'stats' when calling Stats3");

            var path = "/api/v1/people/{personId}/stats";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "personId" + "}", ApiClient.ParameterToString(personId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (stats != null) queryParams.Add("stats", ApiClient.ParameterToString(stats)); // query parameter
            if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (opposingTeamId != null) queryParams.Add("opposingTeamId", ApiClient.ParameterToString(opposingTeamId)); // query parameter
            if (opposingPlayerId != null) queryParams.Add("opposingPlayerId", ApiClient.ParameterToString(opposingPlayerId)); // query parameter
            if (metrics != null) queryParams.Add("metrics", ApiClient.ParameterToString(metrics)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (leagueListId != null) queryParams.Add("leagueListId", ApiClient.ParameterToString(leagueListId)); // query parameter
            if (sitCodes != null) queryParams.Add("sitCodes", ApiClient.ParameterToString(sitCodes)); // query parameter
            if (combineSits != null) queryParams.Add("combineSits", ApiClient.ParameterToString(combineSits)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (daysBack != null) queryParams.Add("daysBack", ApiClient.ParameterToString(daysBack)); // query parameter
            if (gamesBack != null) queryParams.Add("gamesBack", ApiClient.ParameterToString(gamesBack)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (eventType != null) queryParams.Add("eventType", ApiClient.ParameterToString(eventType)); // query parameter
            if (pitchType != null) queryParams.Add("pitchType", ApiClient.ParameterToString(pitchType)); // query parameter
            if (hitTrajectory != null) queryParams.Add("hitTrajectory", ApiClient.ParameterToString(hitTrajectory)); // query parameter
            if (batSide != null) queryParams.Add("batSide", ApiClient.ParameterToString(batSide)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (groupBy != null) queryParams.Add("groupBy", ApiClient.ParameterToString(groupBy)); // query parameter
            if (accent != null) queryParams.Add("accent", ApiClient.ParameterToString(accent)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Stats3: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Stats3: " + response.ErrorMessage, response.ErrorMessage);

            return (StatsRestObject)ApiClient.Deserialize(response.Content, typeof(StatsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View a player&#x27;s stat metrics
        /// </summary>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="stats">Type of statistics. Format: Individual, Team, Career, etc. Available types in /api/v1/statTypes</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="opposingTeamId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="opposingPlayerId">A unique identifier for the opposing team</param>
        /// <param name="metrics">Name of metric(s) for metric log stats.  Available metrics in /api/v1/metrics</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="sitCodes">Situation code for a given stat split.</param>
        /// <param name="combineSits">If true, gathers stats where all of the situational criteria are met. If false, returns stats where any of the situational criteria are met. Default: false</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="daysBack">Returns results from the last &#x27;X&#x27; days (Starting from yesterday).</param>
        /// <param name="gamesBack">Returns results from the last &#x27;X&#x27; games played.</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="eventType">Type of event</param>
        /// <param name="pitchType">Classification of pitch (fastball, curveball, etc...)</param>
        /// <param name="hitTrajectory">Trajectory of hit (line drive, fly ball, etc...)</param>
        /// <param name="batSide">Bat side of hitter</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="groupBy">Group stats by PLAYER, TEAM, SEASON, VENUE, SPORT or STAT_GROUP</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StatsRestObject</returns>
        public StatsRestObject StatsMetrics(int? personId, List<StatType> stats, List<StatGroup> group, string season, List<string> seasons, int? sportId, int? opposingTeamId, int? opposingPlayerId, List<MetricType> metrics, int? leagueId, LeagueListsEnum leagueListId, List<string> sitCodes, bool? combineSits, DateTime? startDate, DateTime? endDate, int? daysBack, int? gamesBack, int? limit, List<EventType> eventType, List<string> pitchType, List<HitTrajectory> hitTrajectory, string batSide, List<GameTypeEnum> gameType, List<GroupByEnum> groupBy, bool? accent, List<string> fields)
        {
            // verify the required parameter 'personId' is set
            if (personId == null) throw new ApiException(400, "Missing required parameter 'personId' when calling StatsMetrics");
            // verify the required parameter 'stats' is set
            if (stats == null) throw new ApiException(400, "Missing required parameter 'stats' when calling StatsMetrics");

            var path = "/api/v1/people/{personId}/stats/metrics";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "personId" + "}", ApiClient.ParameterToString(personId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (stats != null) queryParams.Add("stats", ApiClient.ParameterToString(stats)); // query parameter
            if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (opposingTeamId != null) queryParams.Add("opposingTeamId", ApiClient.ParameterToString(opposingTeamId)); // query parameter
            if (opposingPlayerId != null) queryParams.Add("opposingPlayerId", ApiClient.ParameterToString(opposingPlayerId)); // query parameter
            if (metrics != null) queryParams.Add("metrics", ApiClient.ParameterToString(metrics)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (leagueListId != null) queryParams.Add("leagueListId", ApiClient.ParameterToString(leagueListId)); // query parameter
            if (sitCodes != null) queryParams.Add("sitCodes", ApiClient.ParameterToString(sitCodes)); // query parameter
            if (combineSits != null) queryParams.Add("combineSits", ApiClient.ParameterToString(combineSits)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (daysBack != null) queryParams.Add("daysBack", ApiClient.ParameterToString(daysBack)); // query parameter
            if (gamesBack != null) queryParams.Add("gamesBack", ApiClient.ParameterToString(gamesBack)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (eventType != null) queryParams.Add("eventType", ApiClient.ParameterToString(eventType)); // query parameter
            if (pitchType != null) queryParams.Add("pitchType", ApiClient.ParameterToString(pitchType)); // query parameter
            if (hitTrajectory != null) queryParams.Add("hitTrajectory", ApiClient.ParameterToString(hitTrajectory)); // query parameter
            if (batSide != null) queryParams.Add("batSide", ApiClient.ParameterToString(batSide)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (groupBy != null) queryParams.Add("groupBy", ApiClient.ParameterToString(groupBy)); // query parameter
            if (accent != null) queryParams.Add("accent", ApiClient.ParameterToString(accent)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling StatsMetrics: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling StatsMetrics: " + response.ErrorMessage, response.ErrorMessage);

            return (StatsRestObject)ApiClient.Deserialize(response.Content, typeof(StatsRestObject), (IList<Parameter>)response.Headers);
        }
    }
}