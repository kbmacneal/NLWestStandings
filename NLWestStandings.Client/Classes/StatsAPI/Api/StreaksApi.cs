using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStreaksApi
    {
        /// <summary>
        /// View streaks
        /// </summary>
        /// <param name="streakOrg"></param>
        /// <param name="streakStat"></param>
        /// <param name="streakSpan"></param>
        /// <param name="streakLevel"></param>
        /// <param name="streakThreshold"></param>
        /// <param name="inverse"></param>
        /// <param name="startersOnly"></param>
        /// <param name="statGroup">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="activeStreak">Whether or not a player is active</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="playerId">A unique identifier for a player</param>
        /// <returns>StreaksWrapperRestObject</returns>
        StreaksWrapperRestObject GetStreaks(OrganizationType streakOrg, List<StreakStatEnum> streakStat, StreakSpanEnum streakSpan, StreakLevelEnum streakLevel, int? streakThreshold, bool? inverse, bool? startersOnly, List<StatGroup> statGroup, List<GameTypeEnum> gameType, List<string> season, List<int?> teamId, List<int?> leagueId, List<int?> sportId, bool? activeStreak, int? limit, List<string> fields, List<int?> playerId);

        /// <summary>
        /// View streaks parameter options
        /// </summary>
        /// <returns>Dictionary&lt;string, List&lt;Object&gt;&gt;</returns>
        Dictionary<string, List<Object>> StreakTypes();
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StreaksApi : IStreaksApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreaksApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StreaksApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreaksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StreaksApi(String basePath)
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
        /// View streaks
        /// </summary>
        /// <param name="streakOrg"></param>
        /// <param name="streakStat"></param>
        /// <param name="streakSpan"></param>
        /// <param name="streakLevel"></param>
        /// <param name="streakThreshold"></param>
        /// <param name="inverse"></param>
        /// <param name="startersOnly"></param>
        /// <param name="statGroup">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="activeStreak">Whether or not a player is active</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="playerId">A unique identifier for a player</param>
        /// <returns>StreaksWrapperRestObject</returns>
        public StreaksWrapperRestObject GetStreaks(OrganizationType streakOrg, List<StreakStatEnum> streakStat, StreakSpanEnum streakSpan, StreakLevelEnum streakLevel, int? streakThreshold, bool? inverse, bool? startersOnly, List<StatGroup> statGroup, List<GameTypeEnum> gameType, List<string> season, List<int?> teamId, List<int?> leagueId, List<int?> sportId, bool? activeStreak, int? limit, List<string> fields, List<int?> playerId)
        {
            var path = "/api/v1/streaks";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (streakOrg != null) queryParams.Add("streakOrg", ApiClient.ParameterToString(streakOrg)); // query parameter
            if (streakStat != null) queryParams.Add("streakStat", ApiClient.ParameterToString(streakStat)); // query parameter
            if (streakSpan != null) queryParams.Add("streakSpan", ApiClient.ParameterToString(streakSpan)); // query parameter
            if (streakLevel != null) queryParams.Add("streakLevel", ApiClient.ParameterToString(streakLevel)); // query parameter
            if (streakThreshold != null) queryParams.Add("streakThreshold", ApiClient.ParameterToString(streakThreshold)); // query parameter
            if (inverse != null) queryParams.Add("inverse", ApiClient.ParameterToString(inverse)); // query parameter
            if (startersOnly != null) queryParams.Add("startersOnly", ApiClient.ParameterToString(startersOnly)); // query parameter
            if (statGroup != null) queryParams.Add("statGroup", ApiClient.ParameterToString(statGroup)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (activeStreak != null) queryParams.Add("activeStreak", ApiClient.ParameterToString(activeStreak)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (playerId != null) queryParams.Add("playerId", ApiClient.ParameterToString(playerId)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetStreaks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetStreaks: " + response.ErrorMessage, response.ErrorMessage);

            return (StreaksWrapperRestObject)ApiClient.Deserialize(response.Content, typeof(StreaksWrapperRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View streaks parameter options
        /// </summary>
        /// <returns>Dictionary&lt;string, List&lt;Object&gt;&gt;</returns>
        public Dictionary<string, List<Object>> StreakTypes()
        {
            var path = "/api/v1/streaks/types";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling StreakTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling StreakTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (Dictionary<string, List<Object>>)ApiClient.Deserialize(response.Content, typeof(Dictionary<string, List<Object>>), (IList<Parameter>)response.Headers);
        }
    }
}