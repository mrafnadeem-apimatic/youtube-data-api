// <copyright file="Item.cs" company="APIMatic">
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
    /// Item.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        public Item()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="kind">kind.</param>
        /// <param name="etag">etag.</param>
        /// <param name="id">id.</param>
        /// <param name="snippet">snippet.</param>
        public Item(
            string kind,
            string etag,
            Models.Id id,
            Models.Snippet snippet)
        {
            this.Kind = kind;
            this.Etag = etag;
            this.Id = id;
            this.Snippet = snippet;
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
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public Models.Id Id { get; set; }

        /// <summary>
        /// Gets or sets Snippet.
        /// </summary>
        [JsonProperty("snippet")]
        public Models.Snippet Snippet { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Item : ({string.Join(", ", toStringOutput)})";
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

            return obj is Item other &&
                ((this.Kind == null && other.Kind == null) || (this.Kind?.Equals(other.Kind) == true)) &&
                ((this.Etag == null && other.Etag == null) || (this.Etag?.Equals(other.Etag) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Snippet == null && other.Snippet == null) || (this.Snippet?.Equals(other.Snippet) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Kind = {(this.Kind == null ? "null" : this.Kind == string.Empty ? "" : this.Kind)}");
            toStringOutput.Add($"this.Etag = {(this.Etag == null ? "null" : this.Etag == string.Empty ? "" : this.Etag)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Snippet = {(this.Snippet == null ? "null" : this.Snippet.ToString())}");
        }
    }
}