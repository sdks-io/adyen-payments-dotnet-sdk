// <copyright file="CheckoutSDKAction.cs" company="APIMatic">
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
    /// CheckoutSDKAction.
    /// </summary>
    public class CheckoutSDKAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutSDKAction"/> class.
        /// </summary>
        public CheckoutSDKAction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutSDKAction"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="paymentData">paymentData.</param>
        /// <param name="paymentMethodType">paymentMethodType.</param>
        /// <param name="sdkData">sdkData.</param>
        /// <param name="url">url.</param>
        public CheckoutSDKAction(
            Models.Type11Enum type,
            string paymentData = null,
            string paymentMethodType = null,
            Dictionary<string, string> sdkData = null,
            string url = null)
        {
            this.PaymentData = paymentData;
            this.PaymentMethodType = paymentMethodType;
            this.SdkData = sdkData;
            this.Type = type;
            this.Url = url;
        }

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
        /// The data to pass to the SDK.
        /// </summary>
        [JsonConverter(typeof(CoreMapConverter), typeof(JsonStringConverter))]
        [JsonProperty("sdkData", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> SdkData { get; set; }

        /// <summary>
        /// The type of the action.
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public Models.Type11Enum Type { get; set; }

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

            return $"CheckoutSDKAction : ({string.Join(", ", toStringOutput)})";
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
            return obj is CheckoutSDKAction other &&                ((this.PaymentData == null && other.PaymentData == null) || (this.PaymentData?.Equals(other.PaymentData) == true)) &&
                ((this.PaymentMethodType == null && other.PaymentMethodType == null) || (this.PaymentMethodType?.Equals(other.PaymentMethodType) == true)) &&
                ((this.SdkData == null && other.SdkData == null) || (this.SdkData?.Equals(other.SdkData) == true)) &&
                this.Type.Equals(other.Type) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PaymentData = {(this.PaymentData == null ? "null" : this.PaymentData)}");
            toStringOutput.Add($"this.PaymentMethodType = {(this.PaymentMethodType == null ? "null" : this.PaymentMethodType)}");
            toStringOutput.Add($"SdkData = {(this.SdkData == null ? "null" : this.SdkData.ToString())}");
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
        }
    }
}