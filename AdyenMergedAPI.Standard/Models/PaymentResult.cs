// <copyright file="PaymentResult.cs" company="APIMatic">
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
    /// PaymentResult.
    /// </summary>
    public class PaymentResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResult"/> class.
        /// </summary>
        public PaymentResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResult"/> class.
        /// </summary>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="authCode">authCode.</param>
        /// <param name="dccAmount">dccAmount.</param>
        /// <param name="dccSignature">dccSignature.</param>
        /// <param name="fraudResult">fraudResult.</param>
        /// <param name="issuerUrl">issuerUrl.</param>
        /// <param name="md">md.</param>
        /// <param name="paRequest">paRequest.</param>
        /// <param name="pspReference">pspReference.</param>
        /// <param name="refusalReason">refusalReason.</param>
        /// <param name="resultCode">resultCode.</param>
        public PaymentResult(
            Dictionary<string, string> additionalData = null,
            string authCode = null,
            Models.Amount dccAmount = null,
            string dccSignature = null,
            Models.FraudResult2 fraudResult = null,
            string issuerUrl = null,
            string md = null,
            string paRequest = null,
            string pspReference = null,
            string refusalReason = null,
            Models.ResultCode1Enum? resultCode = null)
        {
            this.AdditionalData = additionalData;
            this.AuthCode = authCode;
            this.DccAmount = dccAmount;
            this.DccSignature = dccSignature;
            this.FraudResult = fraudResult;
            this.IssuerUrl = issuerUrl;
            this.Md = md;
            this.PaRequest = paRequest;
            this.PspReference = pspReference;
            this.RefusalReason = refusalReason;
            this.ResultCode = resultCode;
        }

        /// <summary>
        /// Contains additional information about the payment. Some data fields are included only if you select them first: Go to **Customer Area** > **Developers** > **Additional data**.
        /// </summary>
        [JsonProperty("additionalData", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Authorisation code:
        /// * When the payment is authorised successfully, this field holds the authorisation code for the payment.
        /// * When the payment is not authorised, this field is empty.
        /// </summary>
        [JsonProperty("authCode", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthCode { get; set; }

        /// <summary>
        /// Includes the currency of the conversion and the value of the transaction.
        /// > This value only applies if you have implemented Dynamic Currency Conversion. For more information, [contact Support](https://www.adyen.help/hc/en-us/requests/new).
        /// </summary>
        [JsonProperty("dccAmount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount DccAmount { get; set; }

        /// <summary>
        /// Cryptographic signature used to verify `dccQuote`.
        /// > This value only applies if you have implemented Dynamic Currency Conversion. For more information, [contact Support](https://www.adyen.help/hc/en-us/requests/new).
        /// </summary>
        [JsonProperty("dccSignature", NullValueHandling = NullValueHandling.Ignore)]
        public string DccSignature { get; set; }

        /// <summary>
        /// The fraud result properties of the payment.
        /// </summary>
        [JsonProperty("fraudResult", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FraudResult2 FraudResult { get; set; }

        /// <summary>
        /// The URL to direct the shopper to.
        /// > In case of SecurePlus, do not redirect a shopper to this URL.
        /// </summary>
        [JsonProperty("issuerUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerUrl { get; set; }

        /// <summary>
        /// The payment session.
        /// </summary>
        [JsonProperty("md", NullValueHandling = NullValueHandling.Ignore)]
        public string Md { get; set; }

        /// <summary>
        /// The 3D request data for the issuer.
        /// If the value is **CUPSecurePlus-CollectSMSVerificationCode**, collect an SMS code from the shopper and pass it in the `/authorise3D` request. For more information, see [3D Secure](https://docs.adyen.com/classic-integration/3d-secure).
        /// </summary>
        [JsonProperty("paRequest", NullValueHandling = NullValueHandling.Ignore)]
        public string PaRequest { get; set; }

        /// <summary>
        /// Adyen's 16-character reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.
        /// </summary>
        [JsonProperty("pspReference", NullValueHandling = NullValueHandling.Ignore)]
        public string PspReference { get; set; }

        /// <summary>
        /// If the payment's authorisation is refused or an error occurs during authorisation, this field holds Adyen's mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes `resultCode` and `refusalReason` values.
        /// For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).
        /// </summary>
        [JsonProperty("refusalReason", NullValueHandling = NullValueHandling.Ignore)]
        public string RefusalReason { get; set; }

        /// <summary>
        /// The result of the payment. For more information, see [Result codes](https://docs.adyen.com/online-payments/payment-result-codes).
        /// Possible values:
        /// * **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions.
        /// * **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only).
        /// * **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state.
        /// * **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state.
        /// * **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions.
        /// * **Error** – There was an error when the payment was being processed. The reason is given in the `refusalReason` field. This is a final state.
        /// * **IdentifyShopper** – The issuer requires the shopper's device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions.
        /// * **PartiallyAuthorised** – The payment has been authorised for a partial amount.
        /// This happens for card payments when the merchant supports Partial Authorisations and the cardholder has insufficient funds.
        /// * **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment.
        /// * **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment.
        /// * **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments.
        /// * **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation.
        /// * **Refused** – Indicates the payment was refused. The reason is given in the `refusalReason` field. This is a final state.
        /// </summary>
        [JsonProperty("resultCode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResultCode1Enum? ResultCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentResult other &&                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.AuthCode == null && other.AuthCode == null) || (this.AuthCode?.Equals(other.AuthCode) == true)) &&
                ((this.DccAmount == null && other.DccAmount == null) || (this.DccAmount?.Equals(other.DccAmount) == true)) &&
                ((this.DccSignature == null && other.DccSignature == null) || (this.DccSignature?.Equals(other.DccSignature) == true)) &&
                ((this.FraudResult == null && other.FraudResult == null) || (this.FraudResult?.Equals(other.FraudResult) == true)) &&
                ((this.IssuerUrl == null && other.IssuerUrl == null) || (this.IssuerUrl?.Equals(other.IssuerUrl) == true)) &&
                ((this.Md == null && other.Md == null) || (this.Md?.Equals(other.Md) == true)) &&
                ((this.PaRequest == null && other.PaRequest == null) || (this.PaRequest?.Equals(other.PaRequest) == true)) &&
                ((this.PspReference == null && other.PspReference == null) || (this.PspReference?.Equals(other.PspReference) == true)) &&
                ((this.RefusalReason == null && other.RefusalReason == null) || (this.RefusalReason?.Equals(other.RefusalReason) == true)) &&
                ((this.ResultCode == null && other.ResultCode == null) || (this.ResultCode?.Equals(other.ResultCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.AuthCode = {(this.AuthCode == null ? "null" : this.AuthCode)}");
            toStringOutput.Add($"this.DccAmount = {(this.DccAmount == null ? "null" : this.DccAmount.ToString())}");
            toStringOutput.Add($"this.DccSignature = {(this.DccSignature == null ? "null" : this.DccSignature)}");
            toStringOutput.Add($"this.FraudResult = {(this.FraudResult == null ? "null" : this.FraudResult.ToString())}");
            toStringOutput.Add($"this.IssuerUrl = {(this.IssuerUrl == null ? "null" : this.IssuerUrl)}");
            toStringOutput.Add($"this.Md = {(this.Md == null ? "null" : this.Md)}");
            toStringOutput.Add($"this.PaRequest = {(this.PaRequest == null ? "null" : this.PaRequest)}");
            toStringOutput.Add($"this.PspReference = {(this.PspReference == null ? "null" : this.PspReference)}");
            toStringOutput.Add($"this.RefusalReason = {(this.RefusalReason == null ? "null" : this.RefusalReason)}");
            toStringOutput.Add($"this.ResultCode = {(this.ResultCode == null ? "null" : this.ResultCode.ToString())}");
        }
    }
}