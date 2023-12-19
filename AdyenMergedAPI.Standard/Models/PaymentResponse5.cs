// <copyright file="PaymentResponse5.cs" company="APIMatic">
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
    using AdyenMergedAPI.Standard.Models.Containers;
    using AdyenMergedAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// PaymentResponse5.
    /// </summary>
    public class PaymentResponse5
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponse5"/> class.
        /// </summary>
        public PaymentResponse5()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponse5"/> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="amount">amount.</param>
        /// <param name="donationToken">donationToken.</param>
        /// <param name="fraudResult">fraudResult.</param>
        /// <param name="merchantReference">merchantReference.</param>
        /// <param name="order">order.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="pspReference">pspReference.</param>
        /// <param name="refusalReason">refusalReason.</param>
        /// <param name="refusalReasonCode">refusalReasonCode.</param>
        /// <param name="resultCode">resultCode.</param>
        /// <param name="threeDS2ResponseData">threeDS2ResponseData.</param>
        /// <param name="threeDS2Result">threeDS2Result.</param>
        /// <param name="threeDSPaymentData">threeDSPaymentData.</param>
        public PaymentResponse5(
            PaymentResponse5Action action = null,
            Dictionary<string, string> additionalData = null,
            Models.Amount23 amount = null,
            string donationToken = null,
            Models.FraudResult1 fraudResult = null,
            string merchantReference = null,
            Models.CheckoutOrderResponse1 order = null,
            Models.PaymentResponse1 paymentMethod = null,
            string pspReference = null,
            string refusalReason = null,
            string refusalReasonCode = null,
            Models.ResultCode1Enum? resultCode = null,
            Models.ThreeDS2ResponseData1 threeDS2ResponseData = null,
            Models.ThreeDS2Result1 threeDS2Result = null,
            string threeDSPaymentData = null)
        {
            this.Action = action;
            this.AdditionalData = additionalData;
            this.Amount = amount;
            this.DonationToken = donationToken;
            this.FraudResult = fraudResult;
            this.MerchantReference = merchantReference;
            this.Order = order;
            this.PaymentMethod = paymentMethod;
            this.PspReference = pspReference;
            this.RefusalReason = refusalReason;
            this.RefusalReasonCode = refusalReasonCode;
            this.ResultCode = resultCode;
            this.ThreeDS2ResponseData = threeDS2ResponseData;
            this.ThreeDS2Result = threeDS2Result;
            this.ThreeDSPaymentData = threeDSPaymentData;
        }

        /// <summary>
        /// Action to be taken for completing the payment.
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public PaymentResponse5Action Action { get; set; }

        /// <summary>
        /// Contains additional information about the payment. Some data fields are included only if you select them first: Go to **Customer Area** > **Developers** > **Additional data**.
        /// </summary>
        [JsonProperty("additionalData", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Authorised amount in the transaction.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount23 Amount { get; set; }

        /// <summary>
        /// Donation Token containing payment details for Adyen Giving.
        /// </summary>
        [JsonProperty("donationToken", NullValueHandling = NullValueHandling.Ignore)]
        public string DonationToken { get; set; }

        /// <summary>
        /// The fraud result properties of the payment.
        /// </summary>
        [JsonProperty("fraudResult", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FraudResult1 FraudResult { get; set; }

        /// <summary>
        /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement.
        /// If you need to provide multiple references for a transaction, separate them with hyphens ("-").
        /// Maximum length: 80 characters.
        /// </summary>
        [JsonProperty("merchantReference", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// Contains updated information regarding the order in case order information was provided in the request.
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutOrderResponse1 Order { get; set; }

        /// <summary>
        /// Details about the payment method used in the transaction.
        /// Only returned if `resultCode` is **Authorised**.
        /// </summary>
        [JsonProperty("paymentMethod", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentResponse1 PaymentMethod { get; set; }

        /// <summary>
        /// Adyen's 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.
        /// > For payment methods that require a redirect or additional action, you will get this value in the `/payments/details` response.
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
        /// Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).
        /// </summary>
        [JsonProperty("refusalReasonCode", NullValueHandling = NullValueHandling.Ignore)]
        public string RefusalReasonCode { get; set; }

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

        /// <summary>
        /// Response of the 3D Secure 2 authentication.
        /// </summary>
        [JsonProperty("threeDS2ResponseData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDS2ResponseData1 ThreeDS2ResponseData { get; set; }

        /// <summary>
        /// Result of the 3D Secure 2 authentication.
        /// </summary>
        [JsonProperty("threeDS2Result", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDS2Result1 ThreeDS2Result { get; set; }

        /// <summary>
        /// When non-empty, contains a value that you must submit to the `/payments/details` endpoint as `paymentData`.
        /// </summary>
        [JsonProperty("threeDSPaymentData", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSPaymentData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentResponse5 : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentResponse5 other &&                ((this.Action == null && other.Action == null) || (this.Action?.Equals(other.Action) == true)) &&
                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.DonationToken == null && other.DonationToken == null) || (this.DonationToken?.Equals(other.DonationToken) == true)) &&
                ((this.FraudResult == null && other.FraudResult == null) || (this.FraudResult?.Equals(other.FraudResult) == true)) &&
                ((this.MerchantReference == null && other.MerchantReference == null) || (this.MerchantReference?.Equals(other.MerchantReference) == true)) &&
                ((this.Order == null && other.Order == null) || (this.Order?.Equals(other.Order) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.PspReference == null && other.PspReference == null) || (this.PspReference?.Equals(other.PspReference) == true)) &&
                ((this.RefusalReason == null && other.RefusalReason == null) || (this.RefusalReason?.Equals(other.RefusalReason) == true)) &&
                ((this.RefusalReasonCode == null && other.RefusalReasonCode == null) || (this.RefusalReasonCode?.Equals(other.RefusalReasonCode) == true)) &&
                ((this.ResultCode == null && other.ResultCode == null) || (this.ResultCode?.Equals(other.ResultCode) == true)) &&
                ((this.ThreeDS2ResponseData == null && other.ThreeDS2ResponseData == null) || (this.ThreeDS2ResponseData?.Equals(other.ThreeDS2ResponseData) == true)) &&
                ((this.ThreeDS2Result == null && other.ThreeDS2Result == null) || (this.ThreeDS2Result?.Equals(other.ThreeDS2Result) == true)) &&
                ((this.ThreeDSPaymentData == null && other.ThreeDSPaymentData == null) || (this.ThreeDSPaymentData?.Equals(other.ThreeDSPaymentData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Action = {(this.Action == null ? "null" : this.Action.ToString())}");
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.DonationToken = {(this.DonationToken == null ? "null" : this.DonationToken)}");
            toStringOutput.Add($"this.FraudResult = {(this.FraudResult == null ? "null" : this.FraudResult.ToString())}");
            toStringOutput.Add($"this.MerchantReference = {(this.MerchantReference == null ? "null" : this.MerchantReference)}");
            toStringOutput.Add($"this.Order = {(this.Order == null ? "null" : this.Order.ToString())}");
            toStringOutput.Add($"this.PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod.ToString())}");
            toStringOutput.Add($"this.PspReference = {(this.PspReference == null ? "null" : this.PspReference)}");
            toStringOutput.Add($"this.RefusalReason = {(this.RefusalReason == null ? "null" : this.RefusalReason)}");
            toStringOutput.Add($"this.RefusalReasonCode = {(this.RefusalReasonCode == null ? "null" : this.RefusalReasonCode)}");
            toStringOutput.Add($"this.ResultCode = {(this.ResultCode == null ? "null" : this.ResultCode.ToString())}");
            toStringOutput.Add($"this.ThreeDS2ResponseData = {(this.ThreeDS2ResponseData == null ? "null" : this.ThreeDS2ResponseData.ToString())}");
            toStringOutput.Add($"this.ThreeDS2Result = {(this.ThreeDS2Result == null ? "null" : this.ThreeDS2Result.ToString())}");
            toStringOutput.Add($"this.ThreeDSPaymentData = {(this.ThreeDSPaymentData == null ? "null" : this.ThreeDSPaymentData)}");
        }
    }
}