// <copyright file="CheckoutThreeDS2Action.cs" company="APIMatic">
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
    /// CheckoutThreeDS2Action.
    /// </summary>
    public class CheckoutThreeDS2Action
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutThreeDS2Action"/> class.
        /// </summary>
        public CheckoutThreeDS2Action()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutThreeDS2Action"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="authorisationToken">authorisationToken.</param>
        /// <param name="paymentData">paymentData.</param>
        /// <param name="paymentMethodType">paymentMethodType.</param>
        /// <param name="subtype">subtype.</param>
        /// <param name="token">token.</param>
        /// <param name="url">url.</param>
        public CheckoutThreeDS2Action(
            string type,
            string authorisationToken = null,
            string paymentData = null,
            string paymentMethodType = null,
            string subtype = null,
            string token = null,
            string url = null)
        {
            this.AuthorisationToken = authorisationToken;
            this.PaymentData = paymentData;
            this.PaymentMethodType = paymentMethodType;
            this.Subtype = subtype;
            this.Token = token;
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// A token needed to authorise a payment.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("authorisationToken", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorisationToken { get; set; }

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
        /// A subtype of the token.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("subtype", NullValueHandling = NullValueHandling.Ignore)]
        public string Subtype { get; set; }

        /// <summary>
        /// A token to pass to the 3DS2 Component to get the fingerprint.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// **threeDS2**
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

            return $"CheckoutThreeDS2Action : ({string.Join(", ", toStringOutput)})";
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
            return obj is CheckoutThreeDS2Action other &&                ((this.AuthorisationToken == null && other.AuthorisationToken == null) || (this.AuthorisationToken?.Equals(other.AuthorisationToken) == true)) &&
                ((this.PaymentData == null && other.PaymentData == null) || (this.PaymentData?.Equals(other.PaymentData) == true)) &&
                ((this.PaymentMethodType == null && other.PaymentMethodType == null) || (this.PaymentMethodType?.Equals(other.PaymentMethodType) == true)) &&
                ((this.Subtype == null && other.Subtype == null) || (this.Subtype?.Equals(other.Subtype) == true)) &&
                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AuthorisationToken = {(this.AuthorisationToken == null ? "null" : this.AuthorisationToken)}");
            toStringOutput.Add($"this.PaymentData = {(this.PaymentData == null ? "null" : this.PaymentData)}");
            toStringOutput.Add($"this.PaymentMethodType = {(this.PaymentMethodType == null ? "null" : this.PaymentMethodType)}");
            toStringOutput.Add($"this.Subtype = {(this.Subtype == null ? "null" : this.Subtype)}");
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
        }
    }
}