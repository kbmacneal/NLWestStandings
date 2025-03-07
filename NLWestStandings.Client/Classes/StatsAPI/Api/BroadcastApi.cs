using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBroadcastApi
    {
        /// <summary>
        /// Get All Active Broadcasters
        /// </summary>
        /// <param name="activeStatus">Current status of the broadcaster. Format: Active &#x3D; y, inactive &#x3D; n, both &#x3D; b</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;BroadcasterRestObject&gt;</returns>
        List<BroadcasterRestObject> GetAllBroadcasters(BroadcasterActiveStatusEnum activeStatus, List<string> fields);

        /// <summary>
        /// Get Broadcasters
        /// </summary>
        /// <param name="broadcasterIds">All of the broadcast details</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;BroadcasterRestObject&gt;</returns>
        List<BroadcasterRestObject> GetBroadcasts(List<int?> broadcasterIds, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BroadcastApi : IBroadcastApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BroadcastApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BroadcastApi(String basePath)
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
        /// Get All Active Broadcasters
        /// </summary>
        /// <param name="activeStatus">Current status of the broadcaster. Format: Active &#x3D; y, inactive &#x3D; n, both &#x3D; b</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;BroadcasterRestObject&gt;</returns>
        public List<BroadcasterRestObject> GetAllBroadcasters(BroadcasterActiveStatusEnum activeStatus, List<string> fields)
        {
            var path = "/api/v1/broadcasters";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (activeStatus != null) queryParams.Add("activeStatus", ApiClient.ParameterToString(activeStatus)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAllBroadcasters: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAllBroadcasters: " + response.ErrorMessage, response.ErrorMessage);

            return (List<BroadcasterRestObject>)ApiClient.Deserialize(response.Content, typeof(List<BroadcasterRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get Broadcasters
        /// </summary>
        /// <param name="broadcasterIds">All of the broadcast details</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;BroadcasterRestObject&gt;</returns>
        public List<BroadcasterRestObject> GetBroadcasts(List<int?> broadcasterIds, List<string> fields)
        {
            // verify the required parameter 'broadcasterIds' is set
            if (broadcasterIds == null) throw new ApiException(400, "Missing required parameter 'broadcasterIds' when calling GetBroadcasts");

            var path = "/api/v1/broadcast";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (broadcasterIds != null) queryParams.Add("broadcasterIds", ApiClient.ParameterToString(broadcasterIds)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetBroadcasts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetBroadcasts: " + response.ErrorMessage, response.ErrorMessage);

            return (List<BroadcasterRestObject>)ApiClient.Deserialize(response.Content, typeof(List<BroadcasterRestObject>), (IList<Parameter>)response.Headers);
        }
    }
}