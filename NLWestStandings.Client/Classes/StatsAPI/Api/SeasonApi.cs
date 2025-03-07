using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISeasonApi
    {
        /// <summary>
        /// View all seasons This endpoint allows you to view all seasons for a given Division, League or Sport
        /// </summary>
        /// <param name="divisionId">Unique Division Identifier</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="withGameTypeDates">Retrieve dates for each game type</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>SeasonsRestObject</returns>
        SeasonsRestObject AllSeasons(int? divisionId, int? leagueId, int? sportId, bool? withGameTypeDates, List<string> fields);

        /// <summary>
        /// View season info This endpoint allows you to pull seasons
        /// </summary>
        /// <param name="seasonId">Season of play</param>
        /// <param name="season">Season of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="withGameTypeDates">Retrieve dates for each game type</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>SeasonsRestObject</returns>
        SeasonsRestObject Seasons(string seasonId, List<string> season, int? sportId, bool? withGameTypeDates, List<string> fields);

        /// <summary>
        /// View season info This endpoint allows you to pull seasons
        /// </summary>
        /// <param name="seasonId">Season of play</param>
        /// <param name="season">Season of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="withGameTypeDates">Retrieve dates for each game type</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>SeasonsRestObject</returns>
        SeasonsRestObject Seasons1(string seasonId, List<string> season, int? sportId, bool? withGameTypeDates, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SeasonApi : ISeasonApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeasonApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SeasonApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeasonApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SeasonApi(String basePath)
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
        /// View all seasons This endpoint allows you to view all seasons for a given Division, League or Sport
        /// </summary>
        /// <param name="divisionId">Unique Division Identifier</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="withGameTypeDates">Retrieve dates for each game type</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>SeasonsRestObject</returns>
        public SeasonsRestObject AllSeasons(int? divisionId, int? leagueId, int? sportId, bool? withGameTypeDates, List<string> fields)
        {
            var path = "/api/v1/seasons/all";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (divisionId != null) queryParams.Add("divisionId", ApiClient.ParameterToString(divisionId)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (withGameTypeDates != null) queryParams.Add("withGameTypeDates", ApiClient.ParameterToString(withGameTypeDates)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AllSeasons: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AllSeasons: " + response.ErrorMessage, response.ErrorMessage);

            return (SeasonsRestObject)ApiClient.Deserialize(response.Content, typeof(SeasonsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View season info This endpoint allows you to pull seasons
        /// </summary>
        /// <param name="seasonId">Season of play</param>
        /// <param name="season">Season of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="withGameTypeDates">Retrieve dates for each game type</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>SeasonsRestObject</returns>
        public SeasonsRestObject Seasons(string seasonId, List<string> season, int? sportId, bool? withGameTypeDates, List<string> fields)
        {
            // verify the required parameter 'seasonId' is set
            if (seasonId == null) throw new ApiException(400, "Missing required parameter 'seasonId' when calling Seasons");

            var path = "/api/v1/seasons";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "seasonId" + "}", ApiClient.ParameterToString(seasonId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (withGameTypeDates != null) queryParams.Add("withGameTypeDates", ApiClient.ParameterToString(withGameTypeDates)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Seasons: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Seasons: " + response.ErrorMessage, response.ErrorMessage);

            return (SeasonsRestObject)ApiClient.Deserialize(response.Content, typeof(SeasonsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View season info This endpoint allows you to pull seasons
        /// </summary>
        /// <param name="seasonId">Season of play</param>
        /// <param name="season">Season of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="withGameTypeDates">Retrieve dates for each game type</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>SeasonsRestObject</returns>
        public SeasonsRestObject Seasons1(string seasonId, List<string> season, int? sportId, bool? withGameTypeDates, List<string> fields)
        {
            // verify the required parameter 'seasonId' is set
            if (seasonId == null) throw new ApiException(400, "Missing required parameter 'seasonId' when calling Seasons1");

            var path = "/api/v1/seasons/{seasonId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "seasonId" + "}", ApiClient.ParameterToString(seasonId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (withGameTypeDates != null) queryParams.Add("withGameTypeDates", ApiClient.ParameterToString(withGameTypeDates)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Seasons1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Seasons1: " + response.ErrorMessage, response.ErrorMessage);

            return (SeasonsRestObject)ApiClient.Deserialize(response.Content, typeof(SeasonsRestObject), (IList<Parameter>)response.Headers);
        }
    }
}