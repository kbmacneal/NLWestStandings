using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionsApi
    {
        /// <summary>
        /// View transaction info This endpoint allows you to pull transactions.
        /// </summary>
        /// <param name="leagueId">Comma delimited list of Unique league identifiers</param>
        /// <param name="sportId">Comma delimited list of top level organizations of a sport</param>
        /// <param name="teamId">Comma delimited list of Unique Team identifiers</param>
        /// <param name="playerId">A unique identifier for a player</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="transactionIds"></param>
        /// <param name="transactionTypes"></param>
        /// <param name="divisionIds"></param>
        /// <param name="order"></param>
        /// <param name="limit"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>TransactionsRestObject</returns>
        TransactionsRestObject Transactions(List<int?> leagueId, List<int?> sportId, List<int?> teamId, List<int?> playerId, DateTime? date, DateTime? startDate, DateTime? endDate, List<int?> transactionIds, List<string> transactionTypes, List<int?> divisionIds, SortOrderEnum order, int? limit, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransactionsApi : ITransactionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TransactionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionsApi(String basePath)
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
        /// View transaction info This endpoint allows you to pull transactions.
        /// </summary>
        /// <param name="leagueId">Comma delimited list of Unique league identifiers</param>
        /// <param name="sportId">Comma delimited list of top level organizations of a sport</param>
        /// <param name="teamId">Comma delimited list of Unique Team identifiers</param>
        /// <param name="playerId">A unique identifier for a player</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="transactionIds"></param>
        /// <param name="transactionTypes"></param>
        /// <param name="divisionIds"></param>
        /// <param name="order"></param>
        /// <param name="limit"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>TransactionsRestObject</returns>
        public TransactionsRestObject Transactions(List<int?> leagueId, List<int?> sportId, List<int?> teamId, List<int?> playerId, DateTime? date, DateTime? startDate, DateTime? endDate, List<int?> transactionIds, List<string> transactionTypes, List<int?> divisionIds, SortOrderEnum order, int? limit, List<string> fields)
        {
            var path = "/api/v1/transactions";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (playerId != null) queryParams.Add("playerId", ApiClient.ParameterToString(playerId)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (transactionIds != null) queryParams.Add("transactionIds", ApiClient.ParameterToString(transactionIds)); // query parameter
            if (transactionTypes != null) queryParams.Add("transactionTypes", ApiClient.ParameterToString(transactionTypes)); // query parameter
            if (divisionIds != null) queryParams.Add("divisionIds", ApiClient.ParameterToString(divisionIds)); // query parameter
            if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Transactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Transactions: " + response.ErrorMessage, response.ErrorMessage);

            return (TransactionsRestObject)ApiClient.Deserialize(response.Content, typeof(TransactionsRestObject), (IList<Parameter>)response.Headers);
        }
    }
}