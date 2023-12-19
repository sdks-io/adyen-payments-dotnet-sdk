// <copyright file="ListStoredPaymentMethodsResponse.cs" company="APIMatic">
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
    /// ListStoredPaymentMethodsResponse.
    /// </summary>
    public class ListStoredPaymentMethodsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListStoredPaymentMethodsResponse"/> class.
        /// </summary>
        public ListStoredPaymentMethodsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListStoredPaymentMethodsResponse"/> class.
        /// </summary>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="shopperReference">shopperReference.</param>
        /// <param name="storedPaymentMethods">storedPaymentMethods.</param>
        public ListStoredPaymentMethodsResponse(
            string merchantAccount = null,
            string shopperReference = null,
            List<Models.StoredPaymentMethodResource> storedPaymentMethods = null)
        {
            this.MerchantAccount = merchantAccount;
            this.ShopperReference = shopperReference;
            this.StoredPaymentMethods = storedPaymentMethods;
        }

        /// <summary>
        /// Your merchant account.
        /// </summary>
        [JsonProperty("merchantAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.
        /// > Your reference must not include personally identifiable information (PII), for example name or email address.
        /// </summary>
        [JsonProperty("shopperReference", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// List of all stored payment methods.
        /// </summary>
        [JsonProperty("storedPaymentMethods", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.StoredPaymentMethodResource> StoredPaymentMethods { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListStoredPaymentMethodsResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListStoredPaymentMethodsResponse other &&                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.ShopperReference == null && other.ShopperReference == null) || (this.ShopperReference?.Equals(other.ShopperReference) == true)) &&
                ((this.StoredPaymentMethods == null && other.StoredPaymentMethods == null) || (this.StoredPaymentMethods?.Equals(other.StoredPaymentMethods) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.ShopperReference = {(this.ShopperReference == null ? "null" : this.ShopperReference)}");
            toStringOutput.Add($"this.StoredPaymentMethods = {(this.StoredPaymentMethods == null ? "null" : $"[{string.Join(", ", this.StoredPaymentMethods)} ]")}");
        }
    }
}