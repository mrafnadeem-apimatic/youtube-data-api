// <copyright file="CustomQueryAuthenticationManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YoutubeDataAPI.Standard.Authentication
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using YoutubeDataAPI.Standard.Http.Request;

    /// <summary>
    /// CustomQueryAuthenticationManager.
    /// </summary>
    internal class CustomQueryAuthenticationManager : ICustomQueryAuthenticationCredentials, IAuthManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomQueryAuthenticationManager"/> class.
        /// </summary>
        /// <param name="key">key.</param>
        public CustomQueryAuthenticationManager(string key)
        {
            this.Key = key;
        }

        /// <summary>
        /// Gets string value for key.
        /// </summary>
        public string Key { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="key"> The string value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string key)
        {
            return key.Equals(this.Key);
        }

        /// <inheritdoc/>
        public HttpRequest Apply(HttpRequest httpRequest)
        {
            httpRequest.AddQueryParameters(new Dictionary<string, object>
            {
                { "key", this.Key },
            });

            return httpRequest;
        }

        /// <inheritdoc/>
        public Task<HttpRequest> ApplyAsync(HttpRequest httpRequest)
        {
            return Task.FromResult(this.Apply(httpRequest));
        }
    }
}
