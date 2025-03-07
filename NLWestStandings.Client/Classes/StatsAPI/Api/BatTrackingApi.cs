using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBatTrackingApi
    {
        /// <summary>
        /// View Bat Tracking Data by playId and gameId This endpoint allows you to pull bat tracking data by gameId and playId
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="playId">Unique play identifier</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>BatTrackingRestObject</returns>
        BatTrackingRestObject BatTracking(int? gamePk, string playId, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BatTrackingApi : IBatTrackingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatTrackingApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BatTrackingApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatTrackingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BatTrackingApi(String basePath)
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
        /// View Bat Tracking Data by playId and gameId This endpoint allows you to pull bat tracking data by gameId and playId
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="playId">Unique play identifier</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>BatTrackingRestObject</returns>
        public BatTrackingRestObject BatTracking(int? gamePk, string playId, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling BatTracking");
            // verify the required parameter 'playId' is set
            if (playId == null) throw new ApiException(400, "Missing required parameter 'playId' when calling BatTracking");

            var path = "/api/v1/batTracking/game/{gamePk}/{playId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));
            path = path.Replace("{" + "playId" + "}", ApiClient.ParameterToString(playId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling BatTracking: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling BatTracking: " + response.ErrorMessage, response.ErrorMessage);

            return (BatTrackingRestObject)ApiClient.Deserialize(response.Content, typeof(BatTrackingRestObject), (IList<Parameter>)response.Headers);
        }
    }
}