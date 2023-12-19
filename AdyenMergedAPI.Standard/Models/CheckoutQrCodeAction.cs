// <copyright file="CheckoutQrCodeAction.cs" company="APIMatic">
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
    /// CheckoutQrCodeAction.
    /// </summary>
    public class CheckoutQrCodeAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutQrCodeAction"/> class.
        /// </summary>
        public CheckoutQrCodeAction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutQrCodeAction"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="paymentData">paymentData.</param>
        /// <param name="paymentMethodType">paymentMethodType.</param>
        /// <param name="qrCodeData">qrCodeData.</param>
        /// <param name="url">url.</param>
        public CheckoutQrCodeAction(
            string type,
            string expiresAt = null,
            string paymentData = null,
            string paymentMethodType = null,
            string qrCodeData = null,
            string url = null)
        {
            this.ExpiresAt = expiresAt;
            this.PaymentData = paymentData;
            this.PaymentMethodType = paymentMethodType;
            this.QrCodeData = qrCodeData;
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// Expiry time of the QR code.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("expiresAt", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// Encoded payment data.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("paymentData", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentData { get; set; }

        /// <summary>
        /// Specifies the payment method.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("paymentMethodType", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentMethodType { get; set; }

        /// <summary>
        /// The contents of the QR code as a UTF8 string.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("qrCodeData", NullValueHandling = NullValueHandling.Ignore)]
        public string QrCodeData { get; set; }

        /// <summary>
        /// **qrCode**
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("type")]
        [JsonRequired]
        public string Type { get; set; }

        /// <summary>
        /// Specifies the URL to redirect to.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CheckoutQrCodeAction : ({string.Join(", ", toStringOutput)})";
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
            return obj is CheckoutQrCodeAction other &&                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.PaymentData == null && other.PaymentData == null) || (this.PaymentData?.Equals(other.PaymentData) == true)) &&
                ((this.PaymentMethodType == null && other.PaymentMethodType == null) || (this.PaymentMethodType?.Equals(other.PaymentMethodType) == true)) &&
                ((this.QrCodeData == null && other.QrCodeData == null) || (this.QrCodeData?.Equals(other.QrCodeData) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt)}");
            toStringOutput.Add($"this.PaymentData = {(this.PaymentData == null ? "null" : this.PaymentData)}");
            toStringOutput.Add($"this.PaymentMethodType = {(this.PaymentMethodType == null ? "null" : this.PaymentMethodType)}");
            toStringOutput.Add($"this.QrCodeData = {(this.QrCodeData == null ? "null" : this.QrCodeData)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
        }
    }
}