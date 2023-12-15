// <copyright file="AdditionalDataWallets.cs" company="APIMatic">
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
    /// AdditionalDataWallets.
    /// </summary>
    public class AdditionalDataWallets
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataWallets"/> class.
        /// </summary>
        public AdditionalDataWallets()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataWallets"/> class.
        /// </summary>
        /// <param name="androidpayToken">androidpay.token.</param>
        /// <param name="masterpassTransactionId">masterpass.transactionId.</param>
        /// <param name="paymentToken">payment.token.</param>
        /// <param name="paywithgoogleToken">paywithgoogle.token.</param>
        /// <param name="samsungpayToken">samsungpay.token.</param>
        /// <param name="visacheckoutCallId">visacheckout.callId.</param>
        public AdditionalDataWallets(
            string androidpayToken = null,
            string masterpassTransactionId = null,
            string paymentToken = null,
            string paywithgoogleToken = null,
            string samsungpayToken = null,
            string visacheckoutCallId = null)
        {
            this.AndroidpayToken = androidpayToken;
            this.MasterpassTransactionId = masterpassTransactionId;
            this.PaymentToken = paymentToken;
            this.PaywithgoogleToken = paywithgoogleToken;
            this.SamsungpayToken = samsungpayToken;
            this.VisacheckoutCallId = visacheckoutCallId;
        }

        /// <summary>
        /// The Android Pay token retrieved from the SDK.
        /// </summary>
        [JsonProperty("androidpay.token", NullValueHandling = NullValueHandling.Ignore)]
        public string AndroidpayToken { get; set; }

        /// <summary>
        /// The Mastercard Masterpass Transaction ID retrieved from the SDK.
        /// </summary>
        [JsonProperty("masterpass.transactionId", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterpassTransactionId { get; set; }

        /// <summary>
        /// The Apple Pay token retrieved from the SDK.
        /// </summary>
        [JsonProperty("payment.token", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentToken { get; set; }

        /// <summary>
        /// The Google Pay token retrieved from the SDK.
        /// </summary>
        [JsonProperty("paywithgoogle.token", NullValueHandling = NullValueHandling.Ignore)]
        public string PaywithgoogleToken { get; set; }

        /// <summary>
        /// The Samsung Pay token retrieved from the SDK.
        /// </summary>
        [JsonProperty("samsungpay.token", NullValueHandling = NullValueHandling.Ignore)]
        public string SamsungpayToken { get; set; }

        /// <summary>
        /// The Visa Checkout Call ID retrieved from the SDK.
        /// </summary>
        [JsonProperty("visacheckout.callId", NullValueHandling = NullValueHandling.Ignore)]
        public string VisacheckoutCallId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalDataWallets : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdditionalDataWallets other &&                ((this.AndroidpayToken == null && other.AndroidpayToken == null) || (this.AndroidpayToken?.Equals(other.AndroidpayToken) == true)) &&
                ((this.MasterpassTransactionId == null && other.MasterpassTransactionId == null) || (this.MasterpassTransactionId?.Equals(other.MasterpassTransactionId) == true)) &&
                ((this.PaymentToken == null && other.PaymentToken == null) || (this.PaymentToken?.Equals(other.PaymentToken) == true)) &&
                ((this.PaywithgoogleToken == null && other.PaywithgoogleToken == null) || (this.PaywithgoogleToken?.Equals(other.PaywithgoogleToken) == true)) &&
                ((this.SamsungpayToken == null && other.SamsungpayToken == null) || (this.SamsungpayToken?.Equals(other.SamsungpayToken) == true)) &&
                ((this.VisacheckoutCallId == null && other.VisacheckoutCallId == null) || (this.VisacheckoutCallId?.Equals(other.VisacheckoutCallId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AndroidpayToken = {(this.AndroidpayToken == null ? "null" : this.AndroidpayToken)}");
            toStringOutput.Add($"this.MasterpassTransactionId = {(this.MasterpassTransactionId == null ? "null" : this.MasterpassTransactionId)}");
            toStringOutput.Add($"this.PaymentToken = {(this.PaymentToken == null ? "null" : this.PaymentToken)}");
            toStringOutput.Add($"this.PaywithgoogleToken = {(this.PaywithgoogleToken == null ? "null" : this.PaywithgoogleToken)}");
            toStringOutput.Add($"this.SamsungpayToken = {(this.SamsungpayToken == null ? "null" : this.SamsungpayToken)}");
            toStringOutput.Add($"this.VisacheckoutCallId = {(this.VisacheckoutCallId == null ? "null" : this.VisacheckoutCallId)}");
        }
    }
}