using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHighLowApi
    {
        /// <summary>
        /// View high/low stats by player or team
        /// </summary>
        /// <param name="highLowType">Type of high/low stats (&#x27;player&#x27;, &#x27;team&#x27;, &#x27;game&#x27;)</param>
        /// <param name="statGroup">Comma delimited list of  categories of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="sortStat">Comma delimited list of baseball stats to sort splits by.</param>
        /// <param name="season">Comma delimited list of Seasons of play</param>
        /// <param name="gameType">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HighLowWrapperRestObject</returns>
        HighLowWrapperRestObject HighLow(HighLowTypeEnum highLowType, List<StatGroup> statGroup, List<HighLowStatEnum> sortStat, List<string> season, List<GameTypeEnum> gameType, int? teamId, int? leagueId, int? sportId, int? offset, int? limit, List<string> fields);

        /// <summary>
        /// View high/low stat types
        /// </summary>
        /// <returns>List&lt;BaseballStatsTypeRestObject&gt;</returns>
        List<BaseballStatsTypeRestObject> HighLowStats();
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class HighLowApi : IHighLowApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HighLowApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public HighLowApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HighLowApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HighLowApi(String basePath)
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
        /// View high/low stats by player or team
        /// </summary>
        /// <param name="highLowType">Type of high/low stats (&#x27;player&#x27;, &#x27;team&#x27;, &#x27;game&#x27;)</param>
        /// <param name="statGroup">Comma delimited list of  categories of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="sortStat">Comma delimited list of baseball stats to sort splits by.</param>
        /// <param name="season">Comma delimited list of Seasons of play</param>
        /// <param name="gameType">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HighLowWrapperRestObject</returns>
        public HighLowWrapperRestObject HighLow(HighLowTypeEnum highLowType, List<StatGroup> statGroup, List<HighLowStatEnum> sortStat, List<string> season, List<GameTypeEnum> gameType, int? teamId, int? leagueId, int? sportId, int? offset, int? limit, List<string> fields)
        {
            // verify the required parameter 'highLowType' is set
            if (highLowType == null) throw new ApiException(400, "Missing required parameter 'highLowType' when calling HighLow");

            var path = "/api/v1/highLow/{highLowType}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "highLowType" + "}", ApiClient.ParameterToString(highLowType));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (statGroup != null) queryParams.Add("statGroup", ApiClient.ParameterToString(statGroup)); // query parameter
            if (sortStat != null) queryParams.Add("sortStat", ApiClient.ParameterToString(sortStat)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling HighLow: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling HighLow: " + response.ErrorMessage, response.ErrorMessage);

            return (HighLowWrapperRestObject)ApiClient.Deserialize(response.Content, typeof(HighLowWrapperRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View high/low stat types
        /// </summary>
        /// <returns>List&lt;BaseballStatsTypeRestObject&gt;</returns>
        public List<BaseballStatsTypeRestObject> HighLowStats()
        {
            var path = "/api/v1/highLow/types";
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
                throw new ApiException((int)response.StatusCode, "Error calling HighLowStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling HighLowStats: " + response.ErrorMessage, response.ErrorMessage);

            return (List<BaseballStatsTypeRestObject>)ApiClient.Deserialize(response.Content, typeof(List<BaseballStatsTypeRestObject>), (IList<Parameter>)response.Headers);
        }
    }
}