// <copyright file="CheckoutRedirectAction.cs" company="APIMatic">
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
    /// CheckoutRedirectAction.
    /// </summary>
    public class CheckoutRedirectAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutRedirectAction"/> class.
        /// </summary>
        public CheckoutRedirectAction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutRedirectAction"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="data">data.</param>
        /// <param name="method">method.</param>
        /// <param name="paymentMethodType">paymentMethodType.</param>
        /// <param name="url">url.</param>
        public CheckoutRedirectAction(
            string type,
            Dictionary<string, string> data = null,
            string method = null,
            string paymentMethodType = null,
            string url = null)
        {
            this.Data = data;
            this.Method = method;
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
        /// Specifies the payment method.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("paymentMethodType", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentMethodType { get; set; }

        /// <summary>
        /// **redirect**
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

            return $"CheckoutRedirectAction : ({string.Join(", ", toStringOutput)})";
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
            return obj is CheckoutRedirectAction other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Method == null && other.Method == null) || (this.Method?.Equals(other.Method) == true)) &&
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
            toStringOutput.Add($"this.PaymentMethodType = {(this.PaymentMethodType == null ? "null" : this.PaymentMethodType)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
        }
    }
}