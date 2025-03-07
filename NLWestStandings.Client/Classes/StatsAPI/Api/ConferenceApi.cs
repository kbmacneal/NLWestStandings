using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConferenceApi
    {
        /// <summary>
        /// View conference info
        /// </summary>
        /// <param name="conferenceId"></param>
        /// <param name="season">Season of play</param>
        /// <param name="includeInactive"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ConferencesRestObject</returns>
        ConferencesRestObject Conferences(int? conferenceId, string season, bool? includeInactive, List<string> fields);

        /// <summary>
        /// View conference info
        /// </summary>
        /// <param name="conferenceId"></param>
        /// <param name="season">Season of play</param>
        /// <param name="includeInactive"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ConferencesRestObject</returns>
        ConferencesRestObject Conferences1(int? conferenceId, string season, bool? includeInactive, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConferenceApi : IConferenceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ConferenceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConferenceApi(String basePath)
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
        /// View conference info
        /// </summary>
        /// <param name="conferenceId"></param>
        /// <param name="season">Season of play</param>
        /// <param name="includeInactive"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ConferencesRestObject</returns>
        public ConferencesRestObject Conferences(int? conferenceId, string season, bool? includeInactive, List<string> fields)
        {
            // verify the required parameter 'conferenceId' is set
            if (conferenceId == null) throw new ApiException(400, "Missing required parameter 'conferenceId' when calling Conferences");

            var path = "/api/v1/conferences";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "conferenceId" + "}", ApiClient.ParameterToString(conferenceId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (includeInactive != null) queryParams.Add("includeInactive", ApiClient.ParameterToString(includeInactive)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Conferences: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Conferences: " + response.ErrorMessage, response.ErrorMessage);

            return (ConferencesRestObject)ApiClient.Deserialize(response.Content, typeof(ConferencesRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View conference info
        /// </summary>
        /// <param name="conferenceId"></param>
        /// <param name="season">Season of play</param>
        /// <param name="includeInactive"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ConferencesRestObject</returns>
        public ConferencesRestObject Conferences1(int? conferenceId, string season, bool? includeInactive, List<string> fields)
        {
            // verify the required parameter 'conferenceId' is set
            if (conferenceId == null) throw new ApiException(400, "Missing required parameter 'conferenceId' when calling Conferences1");

            var path = "/api/v1/conferences/{conferenceId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "conferenceId" + "}", ApiClient.ParameterToString(conferenceId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (includeInactive != null) queryParams.Add("includeInactive", ApiClient.ParameterToString(includeInactive)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Conferences1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Conferences1: " + response.ErrorMessage, response.ErrorMessage);

            return (ConferencesRestObject)ApiClient.Deserialize(response.Content, typeof(ConferencesRestObject), (IList<Parameter>)response.Headers);
        }
    }
}