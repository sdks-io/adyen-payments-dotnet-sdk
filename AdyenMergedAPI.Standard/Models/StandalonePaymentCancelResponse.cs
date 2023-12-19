// <copyright file="StandalonePaymentCancelResponse.cs" company="APIMatic">
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
    /// StandalonePaymentCancelResponse.
    /// </summary>
    public class StandalonePaymentCancelResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandalonePaymentCancelResponse"/> class.
        /// </summary>
        public StandalonePaymentCancelResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StandalonePaymentCancelResponse"/> class.
        /// </summary>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="paymentReference">paymentReference.</param>
        /// <param name="pspReference">pspReference.</param>
        /// <param name="status">status.</param>
        /// <param name="reference">reference.</param>
        public StandalonePaymentCancelResponse(
            string merchantAccount,
            string paymentReference,
            string pspReference,
            string status,
            string reference = null)
        {
            this.MerchantAccount = merchantAccount;
            this.PaymentReference = paymentReference;
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
        /// The [`reference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_reference) of the payment to cancel.
        /// </summary>
        [JsonProperty("paymentReference")]
        public string PaymentReference { get; set; }

        /// <summary>
        /// Adyen's 16-character reference associated with the cancel request.
        /// </summary>
        [JsonProperty("pspReference")]
        public string PspReference { get; set; }

        /// <summary>
        /// Your reference for the cancel request.
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

            return $"StandalonePaymentCancelResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is StandalonePaymentCancelResponse other &&                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.PaymentReference == null && other.PaymentReference == null) || (this.PaymentReference?.Equals(other.PaymentReference) == true)) &&
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
            toStringOutput.Add($"this.PaymentReference = {(this.PaymentReference == null ? "null" : this.PaymentReference)}");
            toStringOutput.Add($"this.PspReference = {(this.PspReference == null ? "null" : this.PspReference)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
        }
    }
}