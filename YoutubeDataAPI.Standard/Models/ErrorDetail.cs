// <copyright file="ErrorDetail.cs" company="APIMatic">
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
    /// ErrorDetail.
    /// </summary>
    public class ErrorDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetail"/> class.
        /// </summary>
        public ErrorDetail()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetail"/> class.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="reason">reason.</param>
        /// <param name="domain">domain.</param>
        public ErrorDetail(
            string message,
            string reason,
            string domain = null)
        {
            this.Message = message;
            this.Domain = domain;
            this.Reason = reason;
        }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets Domain.
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets Reason.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ErrorDetail : ({string.Join(", ", toStringOutput)})";
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

            return obj is ErrorDetail other &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.Domain == null && other.Domain == null) || (this.Domain?.Equals(other.Domain) == true)) &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message == string.Empty ? "" : this.Message)}");
            toStringOutput.Add($"this.Domain = {(this.Domain == null ? "null" : this.Domain == string.Empty ? "" : this.Domain)}");
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason == string.Empty ? "" : this.Reason)}");
        }
    }
}