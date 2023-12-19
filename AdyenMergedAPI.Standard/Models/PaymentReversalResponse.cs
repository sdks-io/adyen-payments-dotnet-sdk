// <copyright file="PaymentReversalResponse.cs" company="APIMatic">
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
    /// PaymentReversalResponse.
    /// </summary>
    public class PaymentReversalResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentReversalResponse"/> class.
        /// </summary>
        public PaymentReversalResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentReversalResponse"/> class.
        /// </summary>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="paymentPspReference">paymentPspReference.</param>
        /// <param name="pspReference">pspReference.</param>
        /// <param name="status">status.</param>
        /// <param name="reference">reference.</param>
        public PaymentReversalResponse(
            string merchantAccount,
            string paymentPspReference,
            string pspReference,
            string status,
            string reference = null)
        {
            this.MerchantAccount = merchantAccount;
            this.PaymentPspReference = paymentPspReference;
            this.PspReference = pspReference;
            this.Reference = reference;
            this.Status = status;
        }

        /// <summary>
        /// The merchant account that is used to process the payment.
        /// </summary>
        [JsonProperty("merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment to reverse.
        /// </summary>
        [JsonProperty("paymentPspReference")]
        public string PaymentPspReference { get; set; }

        /// <summary>
        /// Adyen's 16-character reference associated with the reversal request.
        /// </summary>
        [JsonProperty("pspReference")]
        public string PspReference { get; set; }

        /// <summary>
        /// Your reference for the reversal request.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <summary>
        /// The status of your request. This will always have the value **received**.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentReversalResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentReversalResponse other &&                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.PaymentPspReference == null && other.PaymentPspReference == null) || (this.PaymentPspReference?.Equals(other.PaymentPspReference) == true)) &&
                ((this.PspReference == null && other.PspReference == null) || (this.PspReference?.Equals(other.PspReference) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.PaymentPspReference = {(this.PaymentPspReference == null ? "null" : this.PaymentPspReference)}");
            toStringOutput.Add($"this.PspReference = {(this.PspReference == null ? "null" : this.PspReference)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
        }
    }
}