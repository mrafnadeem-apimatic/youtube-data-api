// <copyright file="SearchResult.cs" company="APIMatic">
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
    /// SearchResult.
    /// </summary>
    public class SearchResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult"/> class.
        /// </summary>
        public SearchResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult"/> class.
        /// </summary>
        /// <param name="kind">kind.</param>
        /// <param name="etag">etag.</param>
        /// <param name="nextPageToken">nextPageToken.</param>
        /// <param name="regionCode">regionCode.</param>
        /// <param name="pageInfo">pageInfo.</param>
        /// <param name="items">items.</param>
        public SearchResult(
            string kind,
            string etag,
            string nextPageToken,
            string regionCode,
            Models.PageInfo pageInfo,
            List<Models.Item> items)
        {
            this.Kind = kind;
            this.Etag = etag;
            this.NextPageToken = nextPageToken;
            this.RegionCode = regionCode;
            this.PageInfo = pageInfo;
            this.Items = items;
        }

        /// <summary>
        /// Gets or sets Kind.
        /// </summary>
        [JsonProperty("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets Etag.
        /// </summary>
        [JsonProperty("etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets NextPageToken.
        /// </summary>
        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Gets or sets RegionCode.
        /// </summary>
        [JsonProperty("regionCode")]
        public string RegionCode { get; set; }

        /// <summary>
        /// Gets or sets PageInfo.
        /// </summary>
        [JsonProperty("pageInfo")]
        public Models.PageInfo PageInfo { get; set; }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items")]
        public List<Models.Item> Items { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchResult : ({string.Join(", ", toStringOutput)})";
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

            return obj is SearchResult other &&
                ((this.Kind == null && other.Kind == null) || (this.Kind?.Equals(other.Kind) == true)) &&
                ((this.Etag == null && other.Etag == null) || (this.Etag?.Equals(other.Etag) == true)) &&
                ((this.NextPageToken == null && other.NextPageToken == null) || (this.NextPageToken?.Equals(other.NextPageToken) == true)) &&
                ((this.RegionCode == null && other.RegionCode == null) || (this.RegionCode?.Equals(other.RegionCode) == true)) &&
                ((this.PageInfo == null && other.PageInfo == null) || (this.PageInfo?.Equals(other.PageInfo) == true)) &&
                ((this.Items == null && other.Items == null) || (this.Items?.Equals(other.Items) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Kind = {(this.Kind == null ? "null" : this.Kind == string.Empty ? "" : this.Kind)}");
            toStringOutput.Add($"this.Etag = {(this.Etag == null ? "null" : this.Etag == string.Empty ? "" : this.Etag)}");
            toStringOutput.Add($"this.NextPageToken = {(this.NextPageToken == null ? "null" : this.NextPageToken == string.Empty ? "" : this.NextPageToken)}");
            toStringOutput.Add($"this.RegionCode = {(this.RegionCode == null ? "null" : this.RegionCode == string.Empty ? "" : this.RegionCode)}");
            toStringOutput.Add($"this.PageInfo = {(this.PageInfo == null ? "null" : this.PageInfo.ToString())}");
            toStringOutput.Add($"this.Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
        }
    }
}