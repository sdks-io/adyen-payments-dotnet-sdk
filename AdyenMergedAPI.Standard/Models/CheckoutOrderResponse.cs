// <copyright file="CheckoutOrderResponse.cs" company="APIMatic">
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
    /// CheckoutOrderResponse.
    /// </summary>
    public class CheckoutOrderResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutOrderResponse"/> class.
        /// </summary>
        public CheckoutOrderResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutOrderResponse"/> class.
        /// </summary>
        /// <param name="pspReference">pspReference.</param>
        /// <param name="amount">amount.</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="orderData">orderData.</param>
        /// <param name="reference">reference.</param>
        /// <param name="remainingAmount">remainingAmount.</param>
        public CheckoutOrderResponse(
            string pspReference,
            Models.Amount10 amount = null,
            string expiresAt = null,
            string orderData = null,
            string reference = null,
            Models.Amount11 remainingAmount = null)
        {
            this.Amount = amount;
            this.ExpiresAt = expiresAt;
            this.OrderData = orderData;
            this.PspReference = pspReference;
            this.Reference = reference;
            this.RemainingAmount = remainingAmount;
        }

        /// <summary>
        /// The initial amount of the order.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount10 Amount { get; set; }

        /// <summary>
        /// The expiry date for the order.
        /// </summary>
        [JsonProperty("expiresAt", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// The encrypted order data.
        /// </summary>
        [JsonProperty("orderData", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderData { get; set; }

        /// <summary>
        /// The `pspReference` that belongs to the order.
        /// </summary>
        [JsonProperty("pspReference")]
        public string PspReference { get; set; }

        /// <summary>
        /// The merchant reference for the order.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <summary>
        /// The updated remaining amount.
        /// </summary>
        [JsonProperty("remainingAmount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount11 RemainingAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CheckoutOrderResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CheckoutOrderResponse other &&                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.OrderData == null && other.OrderData == null) || (this.OrderData?.Equals(other.OrderData) == true)) &&
                ((this.PspReference == null && other.PspReference == null) || (this.PspReference?.Equals(other.PspReference) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.RemainingAmount == null && other.RemainingAmount == null) || (this.RemainingAmount?.Equals(other.RemainingAmount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt)}");
            toStringOutput.Add($"this.OrderData = {(this.OrderData == null ? "null" : this.OrderData)}");
            toStringOutput.Add($"this.PspReference = {(this.PspReference == null ? "null" : this.PspReference)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.RemainingAmount = {(this.RemainingAmount == null ? "null" : this.RemainingAmount.ToString())}");
        }
    }
}