// <copyright file="Snippet.cs" company="APIMatic">
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
    /// Snippet.
    /// </summary>
    public class Snippet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Snippet"/> class.
        /// </summary>
        public Snippet()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Snippet"/> class.
        /// </summary>
        /// <param name="publishedAt">publishedAt.</param>
        /// <param name="channelId">channelId.</param>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        /// <param name="thumbnails">thumbnails.</param>
        /// <param name="channelTitle">channelTitle.</param>
        /// <param name="liveBroadcastContent">liveBroadcastContent.</param>
        /// <param name="publishTime">publishTime.</param>
        public Snippet(
            string publishedAt,
            string channelId,
            string title,
            string description,
            Models.Thumbnails thumbnails,
            string channelTitle,
            string liveBroadcastContent,
            string publishTime)
        {
            this.PublishedAt = publishedAt;
            this.ChannelId = channelId;
            this.Title = title;
            this.Description = description;
            this.Thumbnails = thumbnails;
            this.ChannelTitle = channelTitle;
            this.LiveBroadcastContent = liveBroadcastContent;
            this.PublishTime = publishTime;
        }

        /// <summary>
        /// Gets or sets PublishedAt.
        /// </summary>
        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }

        /// <summary>
        /// Gets or sets ChannelId.
        /// </summary>
        [JsonProperty("channelId")]
        public string ChannelId { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Thumbnails.
        /// </summary>
        [JsonProperty("thumbnails")]
        public Models.Thumbnails Thumbnails { get; set; }

        /// <summary>
        /// Gets or sets ChannelTitle.
        /// </summary>
        [JsonProperty("channelTitle")]
        public string ChannelTitle { get; set; }

        /// <summary>
        /// Gets or sets LiveBroadcastContent.
        /// </summary>
        [JsonProperty("liveBroadcastContent")]
        public string LiveBroadcastContent { get; set; }

        /// <summary>
        /// Gets or sets PublishTime.
        /// </summary>
        [JsonProperty("publishTime")]
        public string PublishTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Snippet : ({string.Join(", ", toStringOutput)})";
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

            return obj is Snippet other &&
                ((this.PublishedAt == null && other.PublishedAt == null) || (this.PublishedAt?.Equals(other.PublishedAt) == true)) &&
                ((this.ChannelId == null && other.ChannelId == null) || (this.ChannelId?.Equals(other.ChannelId) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Thumbnails == null && other.Thumbnails == null) || (this.Thumbnails?.Equals(other.Thumbnails) == true)) &&
                ((this.ChannelTitle == null && other.ChannelTitle == null) || (this.ChannelTitle?.Equals(other.ChannelTitle) == true)) &&
                ((this.LiveBroadcastContent == null && other.LiveBroadcastContent == null) || (this.LiveBroadcastContent?.Equals(other.LiveBroadcastContent) == true)) &&
                ((this.PublishTime == null && other.PublishTime == null) || (this.PublishTime?.Equals(other.PublishTime) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PublishedAt = {(this.PublishedAt == null ? "null" : this.PublishedAt == string.Empty ? "" : this.PublishedAt)}");
            toStringOutput.Add($"this.ChannelId = {(this.ChannelId == null ? "null" : this.ChannelId == string.Empty ? "" : this.ChannelId)}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title == string.Empty ? "" : this.Title)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Thumbnails = {(this.Thumbnails == null ? "null" : this.Thumbnails.ToString())}");
            toStringOutput.Add($"this.ChannelTitle = {(this.ChannelTitle == null ? "null" : this.ChannelTitle == string.Empty ? "" : this.ChannelTitle)}");
            toStringOutput.Add($"this.LiveBroadcastContent = {(this.LiveBroadcastContent == null ? "null" : this.LiveBroadcastContent == string.Empty ? "" : this.LiveBroadcastContent)}");
            toStringOutput.Add($"this.PublishTime = {(this.PublishTime == null ? "null" : this.PublishTime == string.Empty ? "" : this.PublishTime)}");
        }
    }
}