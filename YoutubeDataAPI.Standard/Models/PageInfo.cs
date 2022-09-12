// <copyright file="PageInfo.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YoutubeDataAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using YoutubeDataAPI.Standard;
    using YoutubeDataAPI.Standard.Utilities;

    /// <summary>
    /// PageInfo.
    /// </summary>
    public class PageInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageInfo"/> class.
        /// </summary>
        public PageInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageInfo"/> class.
        /// </summary>
        /// <param name="totalResults">totalResults.</param>
        /// <param name="resultsPerPage">resultsPerPage.</param>
        public PageInfo(
            int totalResults,
            int resultsPerPage)
        {
            this.TotalResults = totalResults;
            this.ResultsPerPage = resultsPerPage;
        }

        /// <summary>
        /// Gets or sets TotalResults.
        /// </summary>
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        /// <summary>
        /// Gets or sets ResultsPerPage.
        /// </summary>
        [JsonProperty("resultsPerPage")]
        public int ResultsPerPage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PageInfo : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is PageInfo other &&
                this.TotalResults.Equals(other.TotalResults) &&
                this.ResultsPerPage.Equals(other.ResultsPerPage);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TotalResults = {this.TotalResults}");
            toStringOutput.Add($"this.ResultsPerPage = {this.ResultsPerPage}");
        }
    }
}