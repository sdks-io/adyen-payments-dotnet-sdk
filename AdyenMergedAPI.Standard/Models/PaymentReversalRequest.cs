// <copyright file="PaymentReversalRequest.cs" company="APIMatic">
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
    /// PaymentReversalRequest.
    /// </summary>
    public class PaymentReversalRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentReversalRequest"/> class.
        /// </summary>
        public PaymentReversalRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentReversalRequest"/> class.
        /// </summary>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="applicationInfo">applicationInfo.</param>
        /// <param name="reference">reference.</param>
        public PaymentReversalRequest(
            string merchantAccount,
            Models.ApplicationInfo applicationInfo = null,
            string reference = null)
        {
            this.ApplicationInfo = applicationInfo;
            this.MerchantAccount = merchantAccount;
            this.Reference = reference;
        }

        /// <summary>
        /// Information about your application. For more details, see [Building Adyen solutions](https://docs.adyen.com/development-resources/building-adyen-solutions).
        /// </summary>
        [JsonProperty("applicationInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplicationInfo ApplicationInfo { get; set; }

        /// <summary>
        /// The merchant account that is used to process the payment.
        /// </summary>
        [JsonProperty("merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Your reference for the reversal request. Maximum length: 80 characters.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentReversalRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentReversalRequest other &&                ((this.ApplicationInfo == null && other.ApplicationInfo == null) || (this.ApplicationInfo?.Equals(other.ApplicationInfo) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ApplicationInfo = {(this.ApplicationInfo == null ? "null" : this.ApplicationInfo.ToString())}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
        }
    }
}