// <copyright file="Id.cs" company="APIMatic">
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
    /// Id.
    /// </summary>
    public class Id
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Id"/> class.
        /// </summary>
        public Id()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Id"/> class.
        /// </summary>
        /// <param name="kind">kind.</param>
        /// <param name="videoId">videoId.</param>
        public Id(
            string kind,
            string videoId)
        {
            this.Kind = kind;
            this.VideoId = videoId;
        }

        /// <summary>
        /// Gets or sets Kind.
        /// </summary>
        [JsonProperty("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets VideoId.
        /// </summary>
        [JsonProperty("videoId")]
        public string VideoId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Id : ({string.Join(", ", toStringOutput)})";
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

            return obj is Id other &&
                ((this.Kind == null && other.Kind == null) || (this.Kind?.Equals(other.Kind) == true)) &&
                ((this.VideoId == null && other.VideoId == null) || (this.VideoId?.Equals(other.VideoId) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Kind = {(this.Kind == null ? "null" : this.Kind == string.Empty ? "" : this.Kind)}");
            toStringOutput.Add($"this.VideoId = {(this.VideoId == null ? "null" : this.VideoId == string.Empty ? "" : this.VideoId)}");
        }
    }
}