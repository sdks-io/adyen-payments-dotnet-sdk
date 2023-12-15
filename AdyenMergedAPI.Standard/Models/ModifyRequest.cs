// <copyright file="ModifyRequest.cs" company="APIMatic">
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
    /// ModifyRequest.
    /// </summary>
    public class ModifyRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyRequest"/> class.
        /// </summary>
        public ModifyRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyRequest"/> class.
        /// </summary>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="originalReference">originalReference.</param>
        /// <param name="additionalData">additionalData.</param>
        public ModifyRequest(
            string merchantAccount,
            string originalReference,
            Dictionary<string, string> additionalData = null)
        {
            this.AdditionalData = additionalData;
            this.MerchantAccount = merchantAccount;
            this.OriginalReference = originalReference;
        }

        /// <summary>
        /// This field contains additional data, which may be required for a particular payout request.
        /// </summary>
        [JsonProperty("additionalData", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        [JsonProperty("merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The PSP reference received in the `/submitThirdParty` response.
        /// </summary>
        [JsonProperty("originalReference")]
        public string OriginalReference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ModifyRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ModifyRequest other &&                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.OriginalReference == null && other.OriginalReference == null) || (this.OriginalReference?.Equals(other.OriginalReference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.OriginalReference = {(this.OriginalReference == null ? "null" : this.OriginalReference)}");
        }
    }
}