// <copyright file="CancelOrderRequest.cs" company="APIMatic">
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
    /// CancelOrderRequest.
    /// </summary>
    public class CancelOrderRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrderRequest"/> class.
        /// </summary>
        public CancelOrderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrderRequest"/> class.
        /// </summary>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="order">order.</param>
        public CancelOrderRequest(
            string merchantAccount,
            Models.EncryptedOrderData4 order)
        {
            this.MerchantAccount = merchantAccount;
            this.Order = order;
        }

        /// <summary>
        /// The merchant account identifier that orderData belongs to.
        /// </summary>
        [JsonProperty("merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The order request object that contains a pspReference that represents the order and the matching encrypted order data.
        /// </summary>
        [JsonProperty("order")]
        public Models.EncryptedOrderData4 Order { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CancelOrderRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CancelOrderRequest other &&                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.Order == null && other.Order == null) || (this.Order?.Equals(other.Order) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.Order = {(this.Order == null ? "null" : this.Order.ToString())}");
        }
    }
}