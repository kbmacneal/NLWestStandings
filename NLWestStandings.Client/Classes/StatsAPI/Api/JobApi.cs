using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IJobApi
    {
        /// <summary>
        /// Get datacaster jobs Get datacaster jobs
        /// </summary>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>RosterRestObject</returns>
        RosterRestObject Datacasters(int? sportId, DateTime? date, List<string> fields);

        /// <summary>
        /// Get jobs by type This endpoint allows you to pull teams
        /// </summary>
        /// <param name="jobType">Job Type Identifier (ie. UMPR, etc..)</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>RosterRestObject</returns>
        RosterRestObject GetJobsByType(string jobType, int? sportId, DateTime? date, List<string> fields);

        /// <summary>
        /// Get official scorers This endpoint allows you to pull teams
        /// </summary>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>RosterRestObject</returns>
        RosterRestObject OfficialScorers(int? sportId, DateTime? date, List<string> fields);

        /// <summary>
        /// Get umpires and associated game for umpireId This endpoint allows you to pull teams
        /// </summary>
        /// <param name="umpireId">A unique identifier for an umpire</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ScheduleRestObject</returns>
        ScheduleRestObject UmpireSchedule(int? umpireId, string season, List<string> fields);

        /// <summary>
        /// Get umpires This endpoint allows you to pull teams
        /// </summary>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="season">Season of play</param>
        /// <returns>RosterRestObject</returns>
        RosterRestObject Umpires(int? sportId, DateTime? date, List<string> fields, string season);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class JobApi : IJobApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public JobApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobApi"/> class.
        /// </summary>
        /// <returns></returns>
        public JobApi(String basePath)
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
        /// Get datacaster jobs Get datacaster jobs
        /// </summary>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>RosterRestObject</returns>
        public RosterRestObject Datacasters(int? sportId, DateTime? date, List<string> fields)
        {
            var path = "/api/v1/jobs/datacasters";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Datacasters: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Datacasters: " + response.ErrorMessage, response.ErrorMessage);

            return (RosterRestObject)ApiClient.Deserialize(response.Content, typeof(RosterRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get jobs by type This endpoint allows you to pull teams
        /// </summary>
        /// <param name="jobType">Job Type Identifier (ie. UMPR, etc..)</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>RosterRestObject</returns>
        public RosterRestObject GetJobsByType(string jobType, int? sportId, DateTime? date, List<string> fields)
        {
            // verify the required parameter 'jobType' is set
            if (jobType == null) throw new ApiException(400, "Missing required parameter 'jobType' when calling GetJobsByType");

            var path = "/api/v1/jobs";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (jobType != null) queryParams.Add("jobType", ApiClient.ParameterToString(jobType)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetJobsByType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetJobsByType: " + response.ErrorMessage, response.ErrorMessage);

            return (RosterRestObject)ApiClient.Deserialize(response.Content, typeof(RosterRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get official scorers This endpoint allows you to pull teams
        /// </summary>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>RosterRestObject</returns>
        public RosterRestObject OfficialScorers(int? sportId, DateTime? date, List<string> fields)
        {
            var path = "/api/v1/jobs/officialScorers";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling OfficialScorers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling OfficialScorers: " + response.ErrorMessage, response.ErrorMessage);

            return (RosterRestObject)ApiClient.Deserialize(response.Content, typeof(RosterRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get umpires and associated game for umpireId This endpoint allows you to pull teams
        /// </summary>
        /// <param name="umpireId">A unique identifier for an umpire</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ScheduleRestObject</returns>
        public ScheduleRestObject UmpireSchedule(int? umpireId, string season, List<string> fields)
        {
            // verify the required parameter 'umpireId' is set
            if (umpireId == null) throw new ApiException(400, "Missing required parameter 'umpireId' when calling UmpireSchedule");
            // verify the required parameter 'season' is set
            if (season == null) throw new ApiException(400, "Missing required parameter 'season' when calling UmpireSchedule");

            var path = "/api/v1/jobs/umpires/games/{umpireId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "umpireId" + "}", ApiClient.ParameterToString(umpireId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UmpireSchedule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UmpireSchedule: " + response.ErrorMessage, response.ErrorMessage);

            return (ScheduleRestObject)ApiClient.Deserialize(response.Content, typeof(ScheduleRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get umpires This endpoint allows you to pull teams
        /// </summary>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="season">Season of play</param>
        /// <returns>RosterRestObject</returns>
        public RosterRestObject Umpires(int? sportId, DateTime? date, List<string> fields, string season)
        {
            var path = "/api/v1/jobs/umpires";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Umpires: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Umpires: " + response.ErrorMessage, response.ErrorMessage);

            return (RosterRestObject)ApiClient.Deserialize(response.Content, typeof(RosterRestObject), (IList<Parameter>)response.Headers);
        }
    }
}