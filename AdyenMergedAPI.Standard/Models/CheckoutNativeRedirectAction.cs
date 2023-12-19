// <copyright file="CheckoutNativeRedirectAction.cs" company="APIMatic">
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
    /// CheckoutNativeRedirectAction.
    /// </summary>
    public class CheckoutNativeRedirectAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutNativeRedirectAction"/> class.
        /// </summary>
        public CheckoutNativeRedirectAction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutNativeRedirectAction"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="data">data.</param>
        /// <param name="method">method.</param>
        /// <param name="nativeRedirectData">nativeRedirectData.</param>
        /// <param name="paymentMethodType">paymentMethodType.</param>
        /// <param name="url">url.</param>
        public CheckoutNativeRedirectAction(
            string type,
            Dictionary<string, string> data = null,
            string method = null,
            string nativeRedirectData = null,
            string paymentMethodType = null,
            string url = null)
        {
            this.Data = data;
            this.Method = method;
            this.NativeRedirectData = nativeRedirectData;
            this.PaymentMethodType = paymentMethodType;
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// When the redirect URL must be accessed via POST, use this data to post to the redirect URL.
        /// </summary>
        [JsonConverter(typeof(CoreMapConverter), typeof(JsonStringConverter))]
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Data { get; set; }

        /// <summary>
        /// Specifies the HTTP method, for example GET or POST.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public string Method { get; set; }

        /// <summary>
        /// Native SDK's redirect data containing the direct issuer link and state data that must be submitted to the /v1/nativeRedirect/redirectResult.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("nativeRedirectData", NullValueHandling = NullValueHandling.Ignore)]
        public string NativeRedirectData { get; set; }

        /// <summary>
        /// Specifies the payment method.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("paymentMethodType", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentMethodType { get; set; }

        /// <summary>
        /// **nativeRedirect**
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

            return $"CheckoutNativeRedirectAction : ({string.Join(", ", toStringOutput)})";
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
            return obj is CheckoutNativeRedirectAction other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Method == null && other.Method == null) || (this.Method?.Equals(other.Method) == true)) &&
                ((this.NativeRedirectData == null && other.NativeRedirectData == null) || (this.NativeRedirectData?.Equals(other.NativeRedirectData) == true)) &&
                ((this.PaymentMethodType == null && other.PaymentMethodType == null) || (this.PaymentMethodType?.Equals(other.PaymentMethodType) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Data = {(this.Data == null ? "null" : this.Data.ToString())}");
            toStringOutput.Add($"this.Method = {(this.Method == null ? "null" : this.Method)}");
            toStringOutput.Add($"this.NativeRedirectData = {(this.NativeRedirectData == null ? "null" : this.NativeRedirectData)}");
            toStringOutput.Add($"this.PaymentMethodType = {(this.PaymentMethodType == null ? "null" : this.PaymentMethodType)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
        }
    }
}