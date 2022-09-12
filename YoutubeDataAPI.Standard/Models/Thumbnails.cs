// <copyright file="Thumbnails.cs" company="APIMatic">
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
    /// Thumbnails.
    /// </summary>
    public class Thumbnails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Thumbnails"/> class.
        /// </summary>
        public Thumbnails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Thumbnails"/> class.
        /// </summary>
        /// <param name="mDefault">default.</param>
        /// <param name="medium">medium.</param>
        /// <param name="high">high.</param>
        public Thumbnails(
            Models.Default mDefault,
            Models.Medium medium,
            Models.High high)
        {
            this.MDefault = mDefault;
            this.Medium = medium;
            this.High = high;
        }

        /// <summary>
        /// Gets or sets MDefault.
        /// </summary>
        [JsonProperty("default")]
        public Models.Default MDefault { get; set; }

        /// <summary>
        /// Gets or sets Medium.
        /// </summary>
        [JsonProperty("medium")]
        public Models.Medium Medium { get; set; }

        /// <summary>
        /// Gets or sets High.
        /// </summary>
        [JsonProperty("high")]
        public Models.High High { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Thumbnails : ({string.Join(", ", toStringOutput)})";
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

            return obj is Thumbnails other &&
                ((this.MDefault == null && other.MDefault == null) || (this.MDefault?.Equals(other.MDefault) == true)) &&
                ((this.Medium == null && other.Medium == null) || (this.Medium?.Equals(other.Medium) == true)) &&
                ((this.High == null && other.High == null) || (this.High?.Equals(other.High) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MDefault = {(this.MDefault == null ? "null" : this.MDefault.ToString())}");
            toStringOutput.Add($"this.Medium = {(this.Medium == null ? "null" : this.Medium.ToString())}");
            toStringOutput.Add($"this.High = {(this.High == null ? "null" : this.High.ToString())}");
        }
    }
}