// <copyright file="StoreDetailResponse.cs" company="APIMatic">
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
    /// StoreDetailResponse.
    /// </summary>
    public class StoreDetailResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDetailResponse"/> class.
        /// </summary>
        public StoreDetailResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDetailResponse"/> class.
        /// </summary>
        /// <param name="pspReference">pspReference.</param>
        /// <param name="recurringDetailReference">recurringDetailReference.</param>
        /// <param name="resultCode">resultCode.</param>
        /// <param name="additionalData">additionalData.</param>
        public StoreDetailResponse(
            string pspReference,
            string recurringDetailReference,
            string resultCode,
            Dictionary<string, string> additionalData = null)
        {
            this.AdditionalData = additionalData;
            this.PspReference = pspReference;
            this.RecurringDetailReference = recurringDetailReference;
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
        /// The token which you can use later on for submitting the payout.
        /// </summary>
        [JsonProperty("recurringDetailReference")]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// The result code of the transaction. `Success` indicates that the details were stored successfully.
        /// </summary>
        [JsonProperty("resultCode")]
        public string ResultCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StoreDetailResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is StoreDetailResponse other &&                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.PspReference == null && other.PspReference == null) || (this.PspReference?.Equals(other.PspReference) == true)) &&
                ((this.RecurringDetailReference == null && other.RecurringDetailReference == null) || (this.RecurringDetailReference?.Equals(other.RecurringDetailReference) == true)) &&
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
            toStringOutput.Add($"this.RecurringDetailReference = {(this.RecurringDetailReference == null ? "null" : this.RecurringDetailReference)}");
            toStringOutput.Add($"this.ResultCode = {(this.ResultCode == null ? "null" : this.ResultCode)}");
        }
    }
}