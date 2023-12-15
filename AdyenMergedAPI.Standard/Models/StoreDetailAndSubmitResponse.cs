// <copyright file="StoreDetailAndSubmitResponse.cs" company="APIMatic">
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
    /// StoreDetailAndSubmitResponse.
    /// </summary>
    public class StoreDetailAndSubmitResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDetailAndSubmitResponse"/> class.
        /// </summary>
        public StoreDetailAndSubmitResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDetailAndSubmitResponse"/> class.
        /// </summary>
        /// <param name="pspReference">pspReference.</param>
        /// <param name="resultCode">resultCode.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="refusalReason">refusalReason.</param>
        public StoreDetailAndSubmitResponse(
            string pspReference,
            string resultCode,
            Dictionary<string, string> additionalData = null,
            string refusalReason = null)
        {
            this.AdditionalData = additionalData;
            this.PspReference = pspReference;
            this.RefusalReason = refusalReason;
            this.ResultCode = resultCode;
        }

        /// <summary>
        /// This field contains additional data, which may be returned in a particular response.
        /// </summary>
        [JsonProperty("additionalData", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// A new reference to uniquely identify this request.
        /// </summary>
        [JsonProperty("pspReference")]
        public string PspReference { get; set; }

        /// <summary>
        /// In case of refusal, an informational message for the reason.
        /// </summary>
        [JsonProperty("refusalReason", NullValueHandling = NullValueHandling.Ignore)]
        public string RefusalReason { get; set; }

        /// <summary>
        /// The response:
        /// * In case of success is payout-submit-received.
        /// * In case of an error, an informational message is returned.
        /// </summary>
        [JsonProperty("resultCode")]
        public string ResultCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StoreDetailAndSubmitResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is StoreDetailAndSubmitResponse other &&                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.PspReference == null && other.PspReference == null) || (this.PspReference?.Equals(other.PspReference) == true)) &&
                ((this.RefusalReason == null && other.RefusalReason == null) || (this.RefusalReason?.Equals(other.RefusalReason) == true)) &&
                ((this.ResultCode == null && other.ResultCode == null) || (this.ResultCode?.Equals(other.ResultCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.PspReference = {(this.PspReference == null ? "null" : this.PspReference)}");
            toStringOutput.Add($"this.RefusalReason = {(this.RefusalReason == null ? "null" : this.RefusalReason)}");
            toStringOutput.Add($"this.ResultCode = {(this.ResultCode == null ? "null" : this.ResultCode)}");
        }
    }
}