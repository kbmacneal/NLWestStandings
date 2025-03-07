using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHomerunDerbyApi
    {
        /// <summary>
        /// View a home run derby object This endpoint allows you to pull home run derby information
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HomeRunDerbyRestObject</returns>
        HomeRunDerbyRestObject HomeRunDerbyBracket(int? gamePk, List<string> fields);

        /// <summary>
        /// View a home run derby object This endpoint allows you to pull home run derby information
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HomeRunDerbyRestObject</returns>
        HomeRunDerbyRestObject HomeRunDerbyBracket1(int? gamePk, List<string> fields);

        /// <summary>
        /// View a home run derby object This endpoint allows you to pull home run derby information
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HomeRunDerbyRestObject</returns>
        HomeRunDerbyRestObject HomeRunDerbyBracket2(int? gamePk, List<string> fields);

        /// <summary>
        /// View a home run derby object This endpoint allows you to pull home run derby information
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HomeRunDerbyRestObject</returns>
        HomeRunDerbyRestObject HomeRunDerbyBracket3(int? gamePk, List<string> fields);

        /// <summary>
        /// View home run derby mixed mode (Bracket/Pool combo) This endpoint allows you to pull home run derby information
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HomeRunDerbyRestObject</returns>
        HomeRunDerbyRestObject HomeRunDerbyMixedMode(int? gamePk, List<string> fields);

        /// <summary>
        /// View home run derby mixed mode (Bracket/Pool combo) This endpoint allows you to pull home run derby information
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HomeRunDerbyRestObject</returns>
        HomeRunDerbyRestObject HomeRunDerbyMixedMode1(int? gamePk, List<string> fields);

        /// <summary>
        /// View home run derby pool This endpoint allows you to pull home run derby information
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HomeRunDerbyRestObject</returns>
        HomeRunDerbyRestObject HomeRunDerbyPool(int? gamePk, List<string> fields);

        /// <summary>
        /// View home run derby pool This endpoint allows you to pull home run derby information
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HomeRunDerbyRestObject</returns>
        HomeRunDerbyRestObject HomeRunDerbyPool1(int? gamePk, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class HomerunDerbyApi : IHomerunDerbyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HomerunDerbyApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public HomerunDerbyApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HomerunDerbyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HomerunDerbyApi(String basePath)
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
        /// View a home run derby object This endpoint allows you to pull home run derby information
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HomeRunDerbyRestObject</returns>
        public HomeRunDerbyRestObject HomeRunDerbyBracket(int? gamePk, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling HomeRunDerbyBracket");

            var path = "/api/v1/homeRunDerby/{gamePk}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunDerbyBracket: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunDerbyBracket: " + response.ErrorMessage, response.ErrorMessage);

            return (HomeRunDerbyRestObject)ApiClient.Deserialize(response.Content, typeof(HomeRunDerbyRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View a home run derby object This endpoint allows you to pull home run derby information
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HomeRunDerbyRestObject</returns>
        public HomeRunDerbyRestObject HomeRunDerbyBracket1(int? gamePk, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling HomeRunDerbyBracket1");

            var path = "/api/v1/homeRunDerby";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunDerbyBracket1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunDerbyBracket1: " + response.ErrorMessage, response.ErrorMessage);

            return (HomeRunDerbyRestObject)ApiClient.Deserialize(response.Content, typeof(HomeRunDerbyRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View a home run derby object This endpoint allows you to pull home run derby information
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HomeRunDerbyRestObject</returns>
        public HomeRunDerbyRestObject HomeRunDerbyBracket2(int? gamePk, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling HomeRunDerbyBracket2");

            var path = "/api/v1/homeRunDerby/{gamePk}/bracket";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunDerbyBracket2: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunDerbyBracket2: " + response.ErrorMessage, response.ErrorMessage);

            return (HomeRunDerbyRestObject)ApiClient.Deserialize(response.Content, typeof(HomeRunDerbyRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View a home run derby object This endpoint allows you to pull home run derby information
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HomeRunDerbyRestObject</returns>
        public HomeRunDerbyRestObject HomeRunDerbyBracket3(int? gamePk, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling HomeRunDerbyBracket3");

            var path = "/api/v1/homeRunDerby/bracket";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunDerbyBracket3: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunDerbyBracket3: " + response.ErrorMessage, response.ErrorMessage);

            return (HomeRunDerbyRestObject)ApiClient.Deserialize(response.Content, typeof(HomeRunDerbyRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View home run derby mixed mode (Bracket/Pool combo) This endpoint allows you to pull home run derby information
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HomeRunDerbyRestObject</returns>
        public HomeRunDerbyRestObject HomeRunDerbyMixedMode(int? gamePk, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling HomeRunDerbyMixedMode");

            var path = "/api/v1/homeRunDerby/{gamePk}/mixed";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunDerbyMixedMode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunDerbyMixedMode: " + response.ErrorMessage, response.ErrorMessage);

            return (HomeRunDerbyRestObject)ApiClient.Deserialize(response.Content, typeof(HomeRunDerbyRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View home run derby mixed mode (Bracket/Pool combo) This endpoint allows you to pull home run derby information
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HomeRunDerbyRestObject</returns>
        public HomeRunDerbyRestObject HomeRunDerbyMixedMode1(int? gamePk, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling HomeRunDerbyMixedMode1");

            var path = "/api/v1/homeRunDerby/mixed";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunDerbyMixedMode1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunDerbyMixedMode1: " + response.ErrorMessage, response.ErrorMessage);

            return (HomeRunDerbyRestObject)ApiClient.Deserialize(response.Content, typeof(HomeRunDerbyRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View home run derby pool This endpoint allows you to pull home run derby information
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HomeRunDerbyRestObject</returns>
        public HomeRunDerbyRestObject HomeRunDerbyPool(int? gamePk, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling HomeRunDerbyPool");

            var path = "/api/v1/homeRunDerby/{gamePk}/pool";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunDerbyPool: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunDerbyPool: " + response.ErrorMessage, response.ErrorMessage);

            return (HomeRunDerbyRestObject)ApiClient.Deserialize(response.Content, typeof(HomeRunDerbyRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View home run derby pool This endpoint allows you to pull home run derby information
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>HomeRunDerbyRestObject</returns>
        public HomeRunDerbyRestObject HomeRunDerbyPool1(int? gamePk, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling HomeRunDerbyPool1");

            var path = "/api/v1/homeRunDerby/pool";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunDerbyPool1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunDerbyPool1: " + response.ErrorMessage, response.ErrorMessage);

            return (HomeRunDerbyRestObject)ApiClient.Deserialize(response.Content, typeof(HomeRunDerbyRestObject), (IList<Parameter>)response.Headers);
        }
    }
}