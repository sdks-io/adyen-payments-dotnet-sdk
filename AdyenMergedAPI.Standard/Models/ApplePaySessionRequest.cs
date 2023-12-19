// <copyright file="ApplePaySessionRequest.cs" company="APIMatic">
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
    /// ApplePaySessionRequest.
    /// </summary>
    public class ApplePaySessionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePaySessionRequest"/> class.
        /// </summary>
        public ApplePaySessionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePaySessionRequest"/> class.
        /// </summary>
        /// <param name="displayName">displayName.</param>
        /// <param name="domainName">domainName.</param>
        /// <param name="merchantIdentifier">merchantIdentifier.</param>
        public ApplePaySessionRequest(
            string displayName,
            string domainName,
            string merchantIdentifier)
        {
            this.DisplayName = displayName;
            this.DomainName = domainName;
            this.MerchantIdentifier = merchantIdentifier;
        }

        /// <summary>
        /// This is the name that your shoppers will see in the Apple Pay interface.
        /// The value returned as `configuration.merchantName` field from the [`/paymentMethods`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods) response.
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The domain name you provided when you added Apple Pay in your Customer Area.
        /// This must match the `window.location.hostname` of the web shop.
        /// </summary>
        [JsonProperty("domainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Your merchant identifier registered with Apple Pay.
        /// Use the value of the `configuration.merchantId` field from the [`/paymentMethods`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods) response.
        /// </summary>
        [JsonProperty("merchantIdentifier")]
        public string MerchantIdentifier { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApplePaySessionRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ApplePaySessionRequest other &&                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.DomainName == null && other.DomainName == null) || (this.DomainName?.Equals(other.DomainName) == true)) &&
                ((this.MerchantIdentifier == null && other.MerchantIdentifier == null) || (this.MerchantIdentifier?.Equals(other.MerchantIdentifier) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName)}");
            toStringOutput.Add($"this.DomainName = {(this.DomainName == null ? "null" : this.DomainName)}");
            toStringOutput.Add($"this.MerchantIdentifier = {(this.MerchantIdentifier == null ? "null" : this.MerchantIdentifier)}");
        }
    }
}