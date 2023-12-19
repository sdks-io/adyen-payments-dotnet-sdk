// <copyright file="AmazonPay.cs" company="APIMatic">
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
    /// AmazonPay.
    /// </summary>
    public class AmazonPay
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonPay"/> class.
        /// </summary>
        public AmazonPay()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonPay"/> class.
        /// </summary>
        /// <param name="amazonPayToken">amazonPayToken.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="checkoutSessionId">checkoutSessionId.</param>
        /// <param name="type">type.</param>
        public AmazonPay(
            string amazonPayToken = null,
            string checkoutAttemptId = null,
            string checkoutSessionId = null,
            Models.Type2Enum? type = Models.Type2Enum.Amazonpay)
        {
            this.AmazonPayToken = amazonPayToken;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.CheckoutSessionId = checkoutSessionId;
            this.Type = type;
        }

        /// <summary>
        /// This is the `amazonPayToken` that you obtained from the [Get Checkout Session](https://amazon-pay-acquirer-guide.s3-eu-west-1.amazonaws.com/v1/amazon-pay-api-v2/checkout-session.html#get-checkout-session) response. This token is used for API only integration specifically.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("amazonPayToken", NullValueHandling = NullValueHandling.Ignore)]
        public string AmazonPayToken { get; set; }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("checkoutAttemptId", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// The `checkoutSessionId` is used to identify the checkout session at the Amazon Pay side. This field is required only for drop-in and components integration, where it replaces the amazonPayToken.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("checkoutSessionId", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckoutSessionId { get; set; }

        /// <summary>
        /// **amazonpay**
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Type2Enum? Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AmazonPay : ({string.Join(", ", toStringOutput)})";
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
            return obj is AmazonPay other &&                ((this.AmazonPayToken == null && other.AmazonPayToken == null) || (this.AmazonPayToken?.Equals(other.AmazonPayToken) == true)) &&
                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.CheckoutSessionId == null && other.CheckoutSessionId == null) || (this.CheckoutSessionId?.Equals(other.CheckoutSessionId) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AmazonPayToken = {(this.AmazonPayToken == null ? "null" : this.AmazonPayToken)}");
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.CheckoutSessionId = {(this.CheckoutSessionId == null ? "null" : this.CheckoutSessionId)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
        }
    }
}