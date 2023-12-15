// <copyright file="AdditionalDataRiskStandalone.cs" company="APIMatic">
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
    /// AdditionalDataRiskStandalone.
    /// </summary>
    public class AdditionalDataRiskStandalone
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataRiskStandalone"/> class.
        /// </summary>
        public AdditionalDataRiskStandalone()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataRiskStandalone"/> class.
        /// </summary>
        /// <param name="payPalCountryCode">PayPal.CountryCode.</param>
        /// <param name="payPalEmailId">PayPal.EmailId.</param>
        /// <param name="payPalFirstName">PayPal.FirstName.</param>
        /// <param name="payPalLastName">PayPal.LastName.</param>
        /// <param name="payPalPayerId">PayPal.PayerId.</param>
        /// <param name="payPalPhone">PayPal.Phone.</param>
        /// <param name="payPalProtectionEligibility">PayPal.ProtectionEligibility.</param>
        /// <param name="payPalTransactionId">PayPal.TransactionId.</param>
        /// <param name="avsResultRaw">avsResultRaw.</param>
        /// <param name="bin">bin.</param>
        /// <param name="cvcResultRaw">cvcResultRaw.</param>
        /// <param name="riskToken">riskToken.</param>
        /// <param name="threeDAuthenticated">threeDAuthenticated.</param>
        /// <param name="threeDOffered">threeDOffered.</param>
        /// <param name="tokenDataType">tokenDataType.</param>
        public AdditionalDataRiskStandalone(
            string payPalCountryCode = null,
            string payPalEmailId = null,
            string payPalFirstName = null,
            string payPalLastName = null,
            string payPalPayerId = null,
            string payPalPhone = null,
            string payPalProtectionEligibility = null,
            string payPalTransactionId = null,
            string avsResultRaw = null,
            string bin = null,
            string cvcResultRaw = null,
            string riskToken = null,
            string threeDAuthenticated = null,
            string threeDOffered = null,
            string tokenDataType = null)
        {
            this.PayPalCountryCode = payPalCountryCode;
            this.PayPalEmailId = payPalEmailId;
            this.PayPalFirstName = payPalFirstName;
            this.PayPalLastName = payPalLastName;
            this.PayPalPayerId = payPalPayerId;
            this.PayPalPhone = payPalPhone;
            this.PayPalProtectionEligibility = payPalProtectionEligibility;
            this.PayPalTransactionId = payPalTransactionId;
            this.AvsResultRaw = avsResultRaw;
            this.Bin = bin;
            this.CvcResultRaw = cvcResultRaw;
            this.RiskToken = riskToken;
            this.ThreeDAuthenticated = threeDAuthenticated;
            this.ThreeDOffered = threeDOffered;
            this.TokenDataType = tokenDataType;
        }

        /// <summary>
        /// Shopper's country of residence in the form of ISO standard 3166 2-character country codes.
        /// </summary>
        [JsonProperty("PayPal.CountryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string PayPalCountryCode { get; set; }

        /// <summary>
        /// Shopper's email.
        /// </summary>
        [JsonProperty("PayPal.EmailId", NullValueHandling = NullValueHandling.Ignore)]
        public string PayPalEmailId { get; set; }

        /// <summary>
        /// Shopper's first name.
        /// </summary>
        [JsonProperty("PayPal.FirstName", NullValueHandling = NullValueHandling.Ignore)]
        public string PayPalFirstName { get; set; }

        /// <summary>
        /// Shopper's last name.
        /// </summary>
        [JsonProperty("PayPal.LastName", NullValueHandling = NullValueHandling.Ignore)]
        public string PayPalLastName { get; set; }

        /// <summary>
        /// Unique PayPal Customer Account identification number. Character length and limitations: 13 single-byte alphanumeric characters.
        /// </summary>
        [JsonProperty("PayPal.PayerId", NullValueHandling = NullValueHandling.Ignore)]
        public string PayPalPayerId { get; set; }

        /// <summary>
        /// Shopper's phone number.
        /// </summary>
        [JsonProperty("PayPal.Phone", NullValueHandling = NullValueHandling.Ignore)]
        public string PayPalPhone { get; set; }

        /// <summary>
        /// Allowed values:
        /// * **Eligible** — Merchant is protected by PayPal's Seller Protection Policy for Unauthorized Payments and Item Not Received.
        /// * **PartiallyEligible** — Merchant is protected by PayPal's Seller Protection Policy for Item Not Received.
        /// * **Ineligible** — Merchant is not protected under the Seller Protection Policy.
        /// </summary>
        [JsonProperty("PayPal.ProtectionEligibility", NullValueHandling = NullValueHandling.Ignore)]
        public string PayPalProtectionEligibility { get; set; }

        /// <summary>
        /// Unique transaction ID of the payment.
        /// </summary>
        [JsonProperty("PayPal.TransactionId", NullValueHandling = NullValueHandling.Ignore)]
        public string PayPalTransactionId { get; set; }

        /// <summary>
        /// Raw AVS result received from the acquirer, where available. Example: D
        /// </summary>
        [JsonProperty("avsResultRaw", NullValueHandling = NullValueHandling.Ignore)]
        public string AvsResultRaw { get; set; }

        /// <summary>
        /// The Bank Identification Number of a credit card, which is the first six digits of a card number. Required for [tokenized card request](https://docs.adyen.com/risk-management/standalone-risk#tokenised-pan-request).
        /// </summary>
        [JsonProperty("bin", NullValueHandling = NullValueHandling.Ignore)]
        public string Bin { get; set; }

        /// <summary>
        /// Raw CVC result received from the acquirer, where available. Example: 1
        /// </summary>
        [JsonProperty("cvcResultRaw", NullValueHandling = NullValueHandling.Ignore)]
        public string CvcResultRaw { get; set; }

        /// <summary>
        /// Unique identifier or token for the shopper's card details.
        /// </summary>
        [JsonProperty("riskToken", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskToken { get; set; }

        /// <summary>
        /// A Boolean value indicating whether 3DS authentication was completed on this payment. Example: true
        /// </summary>
        [JsonProperty("threeDAuthenticated", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDAuthenticated { get; set; }

        /// <summary>
        /// A Boolean value indicating whether 3DS was offered for this payment. Example: true
        /// </summary>
        [JsonProperty("threeDOffered", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDOffered { get; set; }

        /// <summary>
        /// Required for PayPal payments only. The only supported value is: **paypal**.
        /// </summary>
        [JsonProperty("tokenDataType", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenDataType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalDataRiskStandalone : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdditionalDataRiskStandalone other &&                ((this.PayPalCountryCode == null && other.PayPalCountryCode == null) || (this.PayPalCountryCode?.Equals(other.PayPalCountryCode) == true)) &&
                ((this.PayPalEmailId == null && other.PayPalEmailId == null) || (this.PayPalEmailId?.Equals(other.PayPalEmailId) == true)) &&
                ((this.PayPalFirstName == null && other.PayPalFirstName == null) || (this.PayPalFirstName?.Equals(other.PayPalFirstName) == true)) &&
                ((this.PayPalLastName == null && other.PayPalLastName == null) || (this.PayPalLastName?.Equals(other.PayPalLastName) == true)) &&
                ((this.PayPalPayerId == null && other.PayPalPayerId == null) || (this.PayPalPayerId?.Equals(other.PayPalPayerId) == true)) &&
                ((this.PayPalPhone == null && other.PayPalPhone == null) || (this.PayPalPhone?.Equals(other.PayPalPhone) == true)) &&
                ((this.PayPalProtectionEligibility == null && other.PayPalProtectionEligibility == null) || (this.PayPalProtectionEligibility?.Equals(other.PayPalProtectionEligibility) == true)) &&
                ((this.PayPalTransactionId == null && other.PayPalTransactionId == null) || (this.PayPalTransactionId?.Equals(other.PayPalTransactionId) == true)) &&
                ((this.AvsResultRaw == null && other.AvsResultRaw == null) || (this.AvsResultRaw?.Equals(other.AvsResultRaw) == true)) &&
                ((this.Bin == null && other.Bin == null) || (this.Bin?.Equals(other.Bin) == true)) &&
                ((this.CvcResultRaw == null && other.CvcResultRaw == null) || (this.CvcResultRaw?.Equals(other.CvcResultRaw) == true)) &&
                ((this.RiskToken == null && other.RiskToken == null) || (this.RiskToken?.Equals(other.RiskToken) == true)) &&
                ((this.ThreeDAuthenticated == null && other.ThreeDAuthenticated == null) || (this.ThreeDAuthenticated?.Equals(other.ThreeDAuthenticated) == true)) &&
                ((this.ThreeDOffered == null && other.ThreeDOffered == null) || (this.ThreeDOffered?.Equals(other.ThreeDOffered) == true)) &&
                ((this.TokenDataType == null && other.TokenDataType == null) || (this.TokenDataType?.Equals(other.TokenDataType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PayPalCountryCode = {(this.PayPalCountryCode == null ? "null" : this.PayPalCountryCode)}");
            toStringOutput.Add($"this.PayPalEmailId = {(this.PayPalEmailId == null ? "null" : this.PayPalEmailId)}");
            toStringOutput.Add($"this.PayPalFirstName = {(this.PayPalFirstName == null ? "null" : this.PayPalFirstName)}");
            toStringOutput.Add($"this.PayPalLastName = {(this.PayPalLastName == null ? "null" : this.PayPalLastName)}");
            toStringOutput.Add($"this.PayPalPayerId = {(this.PayPalPayerId == null ? "null" : this.PayPalPayerId)}");
            toStringOutput.Add($"this.PayPalPhone = {(this.PayPalPhone == null ? "null" : this.PayPalPhone)}");
            toStringOutput.Add($"this.PayPalProtectionEligibility = {(this.PayPalProtectionEligibility == null ? "null" : this.PayPalProtectionEligibility)}");
            toStringOutput.Add($"this.PayPalTransactionId = {(this.PayPalTransactionId == null ? "null" : this.PayPalTransactionId)}");
            toStringOutput.Add($"this.AvsResultRaw = {(this.AvsResultRaw == null ? "null" : this.AvsResultRaw)}");
            toStringOutput.Add($"this.Bin = {(this.Bin == null ? "null" : this.Bin)}");
            toStringOutput.Add($"this.CvcResultRaw = {(this.CvcResultRaw == null ? "null" : this.CvcResultRaw)}");
            toStringOutput.Add($"this.RiskToken = {(this.RiskToken == null ? "null" : this.RiskToken)}");
            toStringOutput.Add($"this.ThreeDAuthenticated = {(this.ThreeDAuthenticated == null ? "null" : this.ThreeDAuthenticated)}");
            toStringOutput.Add($"this.ThreeDOffered = {(this.ThreeDOffered == null ? "null" : this.ThreeDOffered)}");
            toStringOutput.Add($"this.TokenDataType = {(this.TokenDataType == null ? "null" : this.TokenDataType)}");
        }
    }
}