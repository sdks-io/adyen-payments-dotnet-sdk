// <copyright file="ServiceErrorDetails.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdyenMergedAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using AdyenMergedAPI.Standard;
    using AdyenMergedAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ServiceErrorDetails.
    /// </summary>
    public class ServiceErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceErrorDetails"/> class.
        /// </summary>
        public ServiceErrorDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceErrorDetails"/> class.
        /// </summary>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorType">errorType.</param>
        /// <param name="message">message.</param>
        /// <param name="pspReference">pspReference.</param>
        public ServiceErrorDetails(
            string errorCode = null,
            string errorType = null,
            string message = null,
            string pspReference = null)
        {
            this.ErrorCode = errorCode;
            this.ErrorType = errorType;
            this.Message = message;
            this.PspReference = pspReference;
        }

        /// <summary>
        /// Gets or sets ErrorCode.
        /// </summary>
        [JsonProperty("errorCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets ErrorType.
        /// </summary>
        [JsonProperty("errorType", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorType { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets PspReference.
        /// </summary>
        [JsonProperty("pspReference", NullValueHandling = NullValueHandling.Ignore)]
        public string PspReference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceErrorDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceErrorDetails other &&                ((this.ErrorCode == null && other.ErrorCode == null) || (this.ErrorCode?.Equals(other.ErrorCode) == true)) &&
                ((this.ErrorType == null && other.ErrorType == null) || (this.ErrorType?.Equals(other.ErrorType) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.PspReference == null && other.PspReference == null) || (this.PspReference?.Equals(other.PspReference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ErrorCode = {(this.ErrorCode == null ? "null" : this.ErrorCode)}");
            toStringOutput.Add($"this.ErrorType = {(this.ErrorType == null ? "null" : this.ErrorType)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"this.PspReference = {(this.PspReference == null ? "null" : this.PspReference)}");
        }
    }
}