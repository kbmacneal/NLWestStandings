using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDivisionApi
    {
        /// <summary>
        /// Get division information This endpoint allows you to pull divisions
        /// </summary>
        /// <param name="divisionId">Unique Division Identifier</param>
        /// <param name="includeInactive">Whether or not to include inactive</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>DivisionsRestObject</returns>
        DivisionsRestObject Divisions(int? divisionId, bool? includeInactive, int? leagueId, int? sportId, string season, List<string> fields);

        /// <summary>
        /// Get division information This endpoint allows you to pull divisions
        /// </summary>
        /// <param name="divisionId">Unique Division Identifier</param>
        /// <param name="includeInactive">Whether or not to include inactive</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>DivisionsRestObject</returns>
        DivisionsRestObject Divisions1(int? divisionId, bool? includeInactive, int? leagueId, int? sportId, string season, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DivisionApi : IDivisionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DivisionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DivisionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DivisionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DivisionApi(String basePath)
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
        /// Get division information This endpoint allows you to pull divisions
        /// </summary>
        /// <param name="divisionId">Unique Division Identifier</param>
        /// <param name="includeInactive">Whether or not to include inactive</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>DivisionsRestObject</returns>
        public DivisionsRestObject Divisions(int? divisionId, bool? includeInactive, int? leagueId, int? sportId, string season, List<string> fields)
        {
            // verify the required parameter 'divisionId' is set
            if (divisionId == null) throw new ApiException(400, "Missing required parameter 'divisionId' when calling Divisions");

            var path = "/api/v1/divisions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "divisionId" + "}", ApiClient.ParameterToString(divisionId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (includeInactive != null) queryParams.Add("includeInactive", ApiClient.ParameterToString(includeInactive)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Divisions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Divisions: " + response.ErrorMessage, response.ErrorMessage);

            return (DivisionsRestObject)ApiClient.Deserialize(response.Content, typeof(DivisionsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get division information This endpoint allows you to pull divisions
        /// </summary>
        /// <param name="divisionId">Unique Division Identifier</param>
        /// <param name="includeInactive">Whether or not to include inactive</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>DivisionsRestObject</returns>
        public DivisionsRestObject Divisions1(int? divisionId, bool? includeInactive, int? leagueId, int? sportId, string season, List<string> fields)
        {
            // verify the required parameter 'divisionId' is set
            if (divisionId == null) throw new ApiException(400, "Missing required parameter 'divisionId' when calling Divisions1");

            var path = "/api/v1/divisions/{divisionId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "divisionId" + "}", ApiClient.ParameterToString(divisionId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (includeInactive != null) queryParams.Add("includeInactive", ApiClient.ParameterToString(includeInactive)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Divisions1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Divisions1: " + response.ErrorMessage, response.ErrorMessage);

            return (DivisionsRestObject)ApiClient.Deserialize(response.Content, typeof(DivisionsRestObject), (IList<Parameter>)response.Headers);
        }
    }
}