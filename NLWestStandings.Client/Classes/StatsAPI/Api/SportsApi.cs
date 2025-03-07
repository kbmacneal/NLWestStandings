using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISportsApi
    {
        /// <summary>
        /// Get ALL MLB ballot for sport This endpoint allows you to get all players for MLB ballot
        /// </summary>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">season</param>
        /// <param name="fields"></param>
        /// <returns>PeopleRestObject</returns>
        PeopleRestObject AllSportBallot(int? sportId, string season, List<string> fields);

        /// <summary>
        /// Get all players for a sport level This endpoint allows you to pull all players for a given sport
        /// </summary>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">Season of play</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="hasStats">Returns sports that have individual player stats</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>PeopleRestObject</returns>
        PeopleRestObject SportPlayers(int? sportId, string season, GameTypeEnum gameType, bool? hasStats, bool? accent, List<string> fields);

        /// <summary>
        /// Get sports information This endpoint allows you to pull sports
        /// </summary>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="hasStats">Returns sports that have individual player stats</param>
        /// <param name="activeStatus">Flag for fetching sports that are currently active (Y), inactive (N), pending (P), or all teams (B)</param>
        /// <returns>SportsRestObject</returns>
        SportsRestObject Sports(int? sportId, string season, List<string> fields, bool? hasStats, SportActiveStatusEnum activeStatus);

        /// <summary>
        /// Get sports information This endpoint allows you to pull sports
        /// </summary>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="hasStats">Returns sports that have individual player stats</param>
        /// <param name="activeStatus">Flag for fetching sports that are currently active (Y), inactive (N), pending (P), or all teams (B)</param>
        /// <returns>SportsRestObject</returns>
        SportsRestObject Sports1(int? sportId, string season, List<string> fields, bool? hasStats, SportActiveStatusEnum activeStatus);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SportsApi : ISportsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SportsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SportsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SportsApi(String basePath)
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
        /// Get ALL MLB ballot for sport This endpoint allows you to get all players for MLB ballot
        /// </summary>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">season</param>
        /// <param name="fields"></param>
        /// <returns>PeopleRestObject</returns>
        public PeopleRestObject AllSportBallot(int? sportId, string season, List<string> fields)
        {
            // verify the required parameter 'sportId' is set
            if (sportId == null) throw new ApiException(400, "Missing required parameter 'sportId' when calling AllSportBallot");
            // verify the required parameter 'season' is set
            if (season == null) throw new ApiException(400, "Missing required parameter 'season' when calling AllSportBallot");

            var path = "/api/v1/sports/{sportId}/allSportBallot";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "sportId" + "}", ApiClient.ParameterToString(sportId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AllSportBallot: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AllSportBallot: " + response.ErrorMessage, response.ErrorMessage);

            return (PeopleRestObject)ApiClient.Deserialize(response.Content, typeof(PeopleRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get all players for a sport level This endpoint allows you to pull all players for a given sport
        /// </summary>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">Season of play</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="hasStats">Returns sports that have individual player stats</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>PeopleRestObject</returns>
        public PeopleRestObject SportPlayers(int? sportId, string season, GameTypeEnum gameType, bool? hasStats, bool? accent, List<string> fields)
        {
            // verify the required parameter 'sportId' is set
            if (sportId == null) throw new ApiException(400, "Missing required parameter 'sportId' when calling SportPlayers");

            var path = "/api/v1/sports/{sportId}/players";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "sportId" + "}", ApiClient.ParameterToString(sportId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (hasStats != null) queryParams.Add("hasStats", ApiClient.ParameterToString(hasStats)); // query parameter
            if (accent != null) queryParams.Add("accent", ApiClient.ParameterToString(accent)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling SportPlayers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling SportPlayers: " + response.ErrorMessage, response.ErrorMessage);

            return (PeopleRestObject)ApiClient.Deserialize(response.Content, typeof(PeopleRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get sports information This endpoint allows you to pull sports
        /// </summary>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="hasStats">Returns sports that have individual player stats</param>
        /// <param name="activeStatus">Flag for fetching sports that are currently active (Y), inactive (N), pending (P), or all teams (B)</param>
        /// <returns>SportsRestObject</returns>
        public SportsRestObject Sports(int? sportId, string season, List<string> fields, bool? hasStats, SportActiveStatusEnum activeStatus)
        {
            // verify the required parameter 'sportId' is set
            if (sportId == null) throw new ApiException(400, "Missing required parameter 'sportId' when calling Sports");

            var path = "/api/v1/sports";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "sportId" + "}", ApiClient.ParameterToString(sportId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (hasStats != null) queryParams.Add("hasStats", ApiClient.ParameterToString(hasStats)); // query parameter
            if (activeStatus != null) queryParams.Add("activeStatus", ApiClient.ParameterToString(activeStatus)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Sports: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Sports: " + response.ErrorMessage, response.ErrorMessage);

            return (SportsRestObject)ApiClient.Deserialize(response.Content, typeof(SportsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get sports information This endpoint allows you to pull sports
        /// </summary>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="hasStats">Returns sports that have individual player stats</param>
        /// <param name="activeStatus">Flag for fetching sports that are currently active (Y), inactive (N), pending (P), or all teams (B)</param>
        /// <returns>SportsRestObject</returns>
        public SportsRestObject Sports1(int? sportId, string season, List<string> fields, bool? hasStats, SportActiveStatusEnum activeStatus)
        {
            // verify the required parameter 'sportId' is set
            if (sportId == null) throw new ApiException(400, "Missing required parameter 'sportId' when calling Sports1");

            var path = "/api/v1/sports/{sportId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "sportId" + "}", ApiClient.ParameterToString(sportId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (hasStats != null) queryParams.Add("hasStats", ApiClient.ParameterToString(hasStats)); // query parameter
            if (activeStatus != null) queryParams.Add("activeStatus", ApiClient.ParameterToString(activeStatus)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Sports1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Sports1: " + response.ErrorMessage, response.ErrorMessage);

            return (SportsRestObject)ApiClient.Deserialize(response.Content, typeof(SportsRestObject), (IList<Parameter>)response.Headers);
        }
    }
}