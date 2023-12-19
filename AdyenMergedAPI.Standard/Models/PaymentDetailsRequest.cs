// <copyright file="PaymentDetailsRequest.cs" company="APIMatic">
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
    /// PaymentDetailsRequest.
    /// </summary>
    public class PaymentDetailsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDetailsRequest"/> class.
        /// </summary>
        public PaymentDetailsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDetailsRequest"/> class.
        /// </summary>
        /// <param name="details">details.</param>
        /// <param name="authenticationData">authenticationData.</param>
        /// <param name="paymentData">paymentData.</param>
        /// <param name="threeDSAuthenticationOnly">threeDSAuthenticationOnly.</param>
        public PaymentDetailsRequest(
            Models.PaymentCompletionDetails1 details,
            Models.DetailsRequestAuthenticationData1 authenticationData = null,
            string paymentData = null,
            bool? threeDSAuthenticationOnly = null)
        {
            this.AuthenticationData = authenticationData;
            this.Details = details;
            this.PaymentData = paymentData;
            this.ThreeDSAuthenticationOnly = threeDSAuthenticationOnly;
        }

        /// <summary>
        /// Data for 3DS authentication.
        /// </summary>
        [JsonProperty("authenticationData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DetailsRequestAuthenticationData1 AuthenticationData { get; set; }

        /// <summary>
        /// Use this collection to submit the details that were returned as a result of the `/payments` call.
        /// </summary>
        [JsonProperty("details")]
        public Models.PaymentCompletionDetails1 Details { get; set; }

        /// <summary>
        /// Encoded payment data. For [authorizing a payment after using 3D Secure 2 Authentication-only](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only/#authorise-the-payment-with-adyen):
        /// If you received `resultCode`: **AuthenticationNotRequired** in the `/payments` response, use the `threeDSPaymentData` from the same response.
        /// If you received `resultCode`: **AuthenticationFinished** in the `/payments` response, use the `action.paymentData` from the same response.
        /// </summary>
        [JsonProperty("paymentData", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentData { get; set; }

        /// <summary>
        /// Change the `authenticationOnly` indicator originally set in the `/payments` request. Only needs to be set if you want to modify the value set previously.
        /// </summary>
        [JsonProperty("threeDSAuthenticationOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ThreeDSAuthenticationOnly { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentDetailsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentDetailsRequest other &&                ((this.AuthenticationData == null && other.AuthenticationData == null) || (this.AuthenticationData?.Equals(other.AuthenticationData) == true)) &&
                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true)) &&
                ((this.PaymentData == null && other.PaymentData == null) || (this.PaymentData?.Equals(other.PaymentData) == true)) &&
                ((this.ThreeDSAuthenticationOnly == null && other.ThreeDSAuthenticationOnly == null) || (this.ThreeDSAuthenticationOnly?.Equals(other.ThreeDSAuthenticationOnly) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AuthenticationData = {(this.AuthenticationData == null ? "null" : this.AuthenticationData.ToString())}");
            toStringOutput.Add($"this.Details = {(this.Details == null ? "null" : this.Details.ToString())}");
            toStringOutput.Add($"this.PaymentData = {(this.PaymentData == null ? "null" : this.PaymentData)}");
            toStringOutput.Add($"this.ThreeDSAuthenticationOnly = {(this.ThreeDSAuthenticationOnly == null ? "null" : this.ThreeDSAuthenticationOnly.ToString())}");
        }
    }
}