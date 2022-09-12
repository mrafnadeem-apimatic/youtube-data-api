// <copyright file="ErrorFurtherDetail.cs" company="APIMatic">
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
    /// ErrorFurtherDetail.
    /// </summary>
    public class ErrorFurtherDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorFurtherDetail"/> class.
        /// </summary>
        public ErrorFurtherDetail()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorFurtherDetail"/> class.
        /// </summary>
        /// <param name="type">@type.</param>
        /// <param name="fieldViolations">fieldViolations.</param>
        public ErrorFurtherDetail(
            string type,
            List<Models.FieldViolation> fieldViolations)
        {
            this.Type = type;
            this.FieldViolations = fieldViolations;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("@type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets FieldViolations.
        /// </summary>
        [JsonProperty("fieldViolations")]
        public List<Models.FieldViolation> FieldViolations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ErrorFurtherDetail : ({string.Join(", ", toStringOutput)})";
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

            return obj is ErrorFurtherDetail other &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.FieldViolations == null && other.FieldViolations == null) || (this.FieldViolations?.Equals(other.FieldViolations) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.FieldViolations = {(this.FieldViolations == null ? "null" : $"[{string.Join(", ", this.FieldViolations)} ]")}");
        }
    }
}