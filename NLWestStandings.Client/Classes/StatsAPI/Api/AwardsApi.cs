using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAwardsApi
    {
        /// <summary>
        /// View recipients of an award
        /// </summary>
        /// <param name="awardId">Unique Award Identifier. Available awards in /api/v1/awards</param>
        /// <param name="season">Season of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="leagueId">Comma delimited list of Unique league identifiers</param>
        /// <param name="fields"></param>
        /// <returns>AwardsRestObject</returns>
        AwardsRestObject AwardRecipients(string awardId, string season, int? sportId, List<int?> leagueId, List<string> fields);

        /// <summary>
        /// View awards info
        /// </summary>
        /// <param name="awardId">Unique Award Identifier. Available awards in /api/v1/awards</param>
        /// <param name="orgId">Comma delimited list of top level organizations of a sport</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>AwardsRestObject</returns>
        AwardsRestObject Awards(string awardId, List<int?> orgId, List<string> fields);

        /// <summary>
        /// View awards info
        /// </summary>
        /// <param name="awardId">Unique Award Identifier. Available awards in /api/v1/awards</param>
        /// <param name="orgId">Comma delimited list of top level organizations of a sport</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>AwardsRestObject</returns>
        AwardsRestObject Awards1(string awardId, List<int?> orgId, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AwardsApi : IAwardsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AwardsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AwardsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwardsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AwardsApi(String basePath)
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
        /// View recipients of an award
        /// </summary>
        /// <param name="awardId">Unique Award Identifier. Available awards in /api/v1/awards</param>
        /// <param name="season">Season of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="leagueId">Comma delimited list of Unique league identifiers</param>
        /// <param name="fields"></param>
        /// <returns>AwardsRestObject</returns>
        public AwardsRestObject AwardRecipients(string awardId, string season, int? sportId, List<int?> leagueId, List<string> fields)
        {
            // verify the required parameter 'awardId' is set
            if (awardId == null) throw new ApiException(400, "Missing required parameter 'awardId' when calling AwardRecipients");

            var path = "/api/v1/awards/{awardId}/recipients";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "awardId" + "}", ApiClient.ParameterToString(awardId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AwardRecipients: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AwardRecipients: " + response.ErrorMessage, response.ErrorMessage);

            return (AwardsRestObject)ApiClient.Deserialize(response.Content, typeof(AwardsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View awards info
        /// </summary>
        /// <param name="awardId">Unique Award Identifier. Available awards in /api/v1/awards</param>
        /// <param name="orgId">Comma delimited list of top level organizations of a sport</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>AwardsRestObject</returns>
        public AwardsRestObject Awards(string awardId, List<int?> orgId, List<string> fields)
        {
            // verify the required parameter 'awardId' is set
            if (awardId == null) throw new ApiException(400, "Missing required parameter 'awardId' when calling Awards");

            var path = "/api/v1/awards";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "awardId" + "}", ApiClient.ParameterToString(awardId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (orgId != null) queryParams.Add("orgId", ApiClient.ParameterToString(orgId)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Awards: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Awards: " + response.ErrorMessage, response.ErrorMessage);

            return (AwardsRestObject)ApiClient.Deserialize(response.Content, typeof(AwardsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View awards info
        /// </summary>
        /// <param name="awardId">Unique Award Identifier. Available awards in /api/v1/awards</param>
        /// <param name="orgId">Comma delimited list of top level organizations of a sport</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>AwardsRestObject</returns>
        public AwardsRestObject Awards1(string awardId, List<int?> orgId, List<string> fields)
        {
            // verify the required parameter 'awardId' is set
            if (awardId == null) throw new ApiException(400, "Missing required parameter 'awardId' when calling Awards1");

            var path = "/api/v1/awards/{awardId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "awardId" + "}", ApiClient.ParameterToString(awardId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (orgId != null) queryParams.Add("orgId", ApiClient.ParameterToString(orgId)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Awards1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Awards1: " + response.ErrorMessage, response.ErrorMessage);

            return (AwardsRestObject)ApiClient.Deserialize(response.Content, typeof(AwardsRestObject), (IList<Parameter>)response.Headers);
        }
    }
}