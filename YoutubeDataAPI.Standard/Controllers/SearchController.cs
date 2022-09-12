// <copyright file="SearchController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YoutubeDataAPI.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Converters;
    using YoutubeDataAPI.Standard;
    using YoutubeDataAPI.Standard.Authentication;
    using YoutubeDataAPI.Standard.Exceptions;
    using YoutubeDataAPI.Standard.Http.Client;
    using YoutubeDataAPI.Standard.Http.Request;
    using YoutubeDataAPI.Standard.Http.Request.Configuration;
    using YoutubeDataAPI.Standard.Http.Response;
    using YoutubeDataAPI.Standard.Utilities;

    /// <summary>
    /// SearchController.
    /// </summary>
    public class SearchController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal SearchController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Returns a collection of search results that match the query parameters specified in the API request.
        /// </summary>
        /// <param name="part">Required parameter: The part parameter specifies a comma-separated list of one or more search resource properties that the API response will include. Set the parameter value to snippet..</param>
        /// <param name="q">Optional parameter: The q parameter specifies the query term to search for..</param>
        /// <returns>Returns the Models.SearchResult response from the API call.</returns>
        public Models.SearchResult SearchList(
                string part,
                string q = null)
        {
            Task<Models.SearchResult> t = this.SearchListAsync(part, q);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Returns a collection of search results that match the query parameters specified in the API request.
        /// </summary>
        /// <param name="part">Required parameter: The part parameter specifies a comma-separated list of one or more search resource properties that the API response will include. Set the parameter value to snippet..</param>
        /// <param name="q">Optional parameter: The q parameter specifies the query term to search for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SearchResult response from the API call.</returns>
        public async Task<Models.SearchResult> SearchListAsync(
                string part,
                string q = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/search");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "part", part },
                { "type", "video" },
                { "q", q },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // [200,208] = HTTP OK
            if ((response.StatusCode < 200) || (response.StatusCode > 208))
            {
                throw new SearchErrorException("Search Result Error!", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.SearchResult>(response.Body);
        }
    }
}