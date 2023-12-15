// <copyright file="ModificationResult.cs" company="APIMatic">
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
    /// ModificationResult.
    /// </summary>
    public class ModificationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModificationResult"/> class.
        /// </summary>
        public ModificationResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModificationResult"/> class.
        /// </summary>
        /// <param name="pspReference">pspReference.</param>
        /// <param name="response">response.</param>
        /// <param name="additionalData">additionalData.</param>
        public ModificationResult(
            string pspReference,
            Models.ResponseEnum response,
            Dictionary<string, string> additionalData = null)
        {
            this.AdditionalData = additionalData;
            this.PspReference = pspReference;
            this.Response = response;
        }

        /// <summary>
        /// This field contains additional data, which may be returned in a particular modification response.
        /// </summary>
        [JsonProperty("additionalData", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Adyen's 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.
        /// </summary>
        [JsonProperty("pspReference")]
        public string PspReference { get; set; }

        /// <summary>
        /// Indicates if the modification request has been received for processing.
        /// </summary>
        [JsonProperty("response")]
        public Models.ResponseEnum Response { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ModificationResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is ModificationResult other &&                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.PspReference == null && other.PspReference == null) || (this.PspReference?.Equals(other.PspReference) == true)) &&
                this.Response.Equals(other.Response);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.PspReference = {(this.PspReference == null ? "null" : this.PspReference)}");
            toStringOutput.Add($"this.Response = {this.Response}");
        }
    }
}