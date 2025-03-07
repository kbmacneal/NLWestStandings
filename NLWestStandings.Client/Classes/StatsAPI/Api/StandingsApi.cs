using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStandingsApi
    {
        /// <summary>
        /// View standings for a league This endpoint allows you to pull standings
        /// </summary>
        /// <param name="standingsType">Type of season. Available types in /api/v1/standingsTypes</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="season">Season of play</param>
        /// <param name="standingsTypes">Type of season. Available types in /api/v1/standingsTypes</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="includeMLB">Determines whether to include major league teams when using the &#x27;BY_ORGANIZATION&#x27; standings type</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StandingsRestObject</returns>
        StandingsRestObject Standings(string standingsType, List<int?> leagueId, string season, List<StandingsType> standingsTypes, DateTime? date, int? teamId, bool? includeMLB, List<string> fields);

        /// <summary>
        /// View standings for a league This endpoint allows you to pull standings
        /// </summary>
        /// <param name="standingsType">Type of season. Available types in /api/v1/standingsTypes</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="season">Season of play</param>
        /// <param name="standingsTypes">Type of season. Available types in /api/v1/standingsTypes</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="includeMLB">Determines whether to include major league teams when using the &#x27;BY_ORGANIZATION&#x27; standings type</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StandingsRestObject</returns>
        StandingsRestObject Standings1(string standingsType, List<int?> leagueId, string season, List<StandingsType> standingsTypes, DateTime? date, int? teamId, bool? includeMLB, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StandingsApi : IStandingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandingsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StandingsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StandingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StandingsApi(String basePath)
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
        /// View standings for a league This endpoint allows you to pull standings
        /// </summary>
        /// <param name="standingsType">Type of season. Available types in /api/v1/standingsTypes</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="season">Season of play</param>
        /// <param name="standingsTypes">Type of season. Available types in /api/v1/standingsTypes</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="includeMLB">Determines whether to include major league teams when using the &#x27;BY_ORGANIZATION&#x27; standings type</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StandingsRestObject</returns>
        public StandingsRestObject Standings(string standingsType, List<int?> leagueId, string season, List<StandingsType> standingsTypes, DateTime? date, int? teamId, bool? includeMLB, List<string> fields)
        {
            // verify the required parameter 'standingsType' is set
            if (standingsType == null) throw new ApiException(400, "Missing required parameter 'standingsType' when calling Standings");

            var path = "/api/v1/standings/{standingsType}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "standingsType" + "}", ApiClient.ParameterToString(standingsType));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (standingsTypes != null) queryParams.Add("standingsTypes", ApiClient.ParameterToString(standingsTypes)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (includeMLB != null) queryParams.Add("includeMLB", ApiClient.ParameterToString(includeMLB)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Standings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Standings: " + response.ErrorMessage, response.ErrorMessage);

            return (StandingsRestObject)ApiClient.Deserialize(response.Content, typeof(StandingsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View standings for a league This endpoint allows you to pull standings
        /// </summary>
        /// <param name="standingsType">Type of season. Available types in /api/v1/standingsTypes</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="season">Season of play</param>
        /// <param name="standingsTypes">Type of season. Available types in /api/v1/standingsTypes</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="includeMLB">Determines whether to include major league teams when using the &#x27;BY_ORGANIZATION&#x27; standings type</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StandingsRestObject</returns>
        public StandingsRestObject Standings1(string standingsType, List<int?> leagueId, string season, List<StandingsType> standingsTypes, DateTime? date, int? teamId, bool? includeMLB, List<string> fields)
        {
            // verify the required parameter 'standingsType' is set
            if (standingsType == null) throw new ApiException(400, "Missing required parameter 'standingsType' when calling Standings1");

            var path = "/api/v1/standings";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "standingsType" + "}", ApiClient.ParameterToString(standingsType));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (standingsTypes != null) queryParams.Add("standingsTypes", ApiClient.ParameterToString(standingsTypes)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (includeMLB != null) queryParams.Add("includeMLB", ApiClient.ParameterToString(includeMLB)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Standings1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Standings1: " + response.ErrorMessage, response.ErrorMessage);

            return (StandingsRestObject)ApiClient.Deserialize(response.Content, typeof(StandingsRestObject), (IList<Parameter>)response.Headers);
        }
    }
}