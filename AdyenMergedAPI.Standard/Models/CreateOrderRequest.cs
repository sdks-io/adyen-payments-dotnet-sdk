// <copyright file="CreateOrderRequest.cs" company="APIMatic">
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
    /// CreateOrderRequest.
    /// </summary>
    public class CreateOrderRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequest"/> class.
        /// </summary>
        public CreateOrderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="reference">reference.</param>
        /// <param name="expiresAt">expiresAt.</param>
        public CreateOrderRequest(
            Models.Amount19 amount,
            string merchantAccount,
            string reference,
            string expiresAt = null)
        {
            this.Amount = amount;
            this.ExpiresAt = expiresAt;
            this.MerchantAccount = merchantAccount;
            this.Reference = reference;
        }

        /// <summary>
        /// The total amount of the order.
        /// </summary>
        [JsonProperty("amount")]
        public Models.Amount19 Amount { get; set; }

        /// <summary>
        /// The date that order expires; e.g. 2019-03-23T12:25:28Z. If not provided, the default expiry duration is 1 day.
        /// </summary>
        [JsonProperty("expiresAt", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the order.
        /// </summary>
        [JsonProperty("merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// A custom reference identifying the order.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateOrderRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateOrderRequest other &&                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt)}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
        }
    }
}