// <copyright file="PaymentVerificationResponse.cs" company="APIMatic">
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
    /// PaymentVerificationResponse.
    /// </summary>
    public class PaymentVerificationResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentVerificationResponse"/> class.
        /// </summary>
        public PaymentVerificationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentVerificationResponse"/> class.
        /// </summary>
        /// <param name="merchantReference">merchantReference.</param>
        /// <param name="shopperLocale">shopperLocale.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="fraudResult">fraudResult.</param>
        /// <param name="order">order.</param>
        /// <param name="pspReference">pspReference.</param>
        /// <param name="refusalReason">refusalReason.</param>
        /// <param name="refusalReasonCode">refusalReasonCode.</param>
        /// <param name="resultCode">resultCode.</param>
        /// <param name="serviceError">serviceError.</param>
        public PaymentVerificationResponse(
            string merchantReference,
            string shopperLocale,
            Dictionary<string, string> additionalData = null,
            Models.FraudResult1 fraudResult = null,
            Models.CheckoutOrderResponse1 order = null,
            string pspReference = null,
            string refusalReason = null,
            string refusalReasonCode = null,
            Models.ResultCode1Enum? resultCode = null,
            Models.ServiceErrorDetails2 serviceError = null)
        {
            this.AdditionalData = additionalData;
            this.FraudResult = fraudResult;
            this.MerchantReference = merchantReference;
            this.Order = order;
            this.PspReference = pspReference;
            this.RefusalReason = refusalReason;
            this.RefusalReasonCode = refusalReasonCode;
            this.ResultCode = resultCode;
            this.ServiceError = serviceError;
            this.ShopperLocale = shopperLocale;
        }

        /// <summary>
        /// Contains additional information about the payment. Some data fields are included only if you select them first: Go to **Customer Area** > **Developers** > **Additional data**.
        /// </summary>
        [JsonProperty("additionalData", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// The fraud result properties of the payment.
        /// </summary>
        [JsonProperty("fraudResult", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FraudResult1 FraudResult { get; set; }

        /// <summary>
        /// A unique value that you provided in the initial `/paymentSession` request as a `reference` field.
        /// </summary>
        [JsonProperty("merchantReference")]
        public string MerchantReference { get; set; }

        /// <summary>
        /// Contains updated information regarding the order in case order information was provided in the request.
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutOrderResponse1 Order { get; set; }

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
        /// The type of the error.
        /// </summary>
        [JsonProperty("serviceError", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceErrorDetails2 ServiceError { get; set; }

        /// <summary>
        /// The shopperLocale value provided in the payment request.
        /// </summary>
        [JsonProperty("shopperLocale")]
        public string ShopperLocale { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentVerificationResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentVerificationResponse other &&                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.FraudResult == null && other.FraudResult == null) || (this.FraudResult?.Equals(other.FraudResult) == true)) &&
                ((this.MerchantReference == null && other.MerchantReference == null) || (this.MerchantReference?.Equals(other.MerchantReference) == true)) &&
                ((this.Order == null && other.Order == null) || (this.Order?.Equals(other.Order) == true)) &&
                ((this.PspReference == null && other.PspReference == null) || (this.PspReference?.Equals(other.PspReference) == true)) &&
                ((this.RefusalReason == null && other.RefusalReason == null) || (this.RefusalReason?.Equals(other.RefusalReason) == true)) &&
                ((this.RefusalReasonCode == null && other.RefusalReasonCode == null) || (this.RefusalReasonCode?.Equals(other.RefusalReasonCode) == true)) &&
                ((this.ResultCode == null && other.ResultCode == null) || (this.ResultCode?.Equals(other.ResultCode) == true)) &&
                ((this.ServiceError == null && other.ServiceError == null) || (this.ServiceError?.Equals(other.ServiceError) == true)) &&
                ((this.ShopperLocale == null && other.ShopperLocale == null) || (this.ShopperLocale?.Equals(other.ShopperLocale) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.FraudResult = {(this.FraudResult == null ? "null" : this.FraudResult.ToString())}");
            toStringOutput.Add($"this.MerchantReference = {(this.MerchantReference == null ? "null" : this.MerchantReference)}");
            toStringOutput.Add($"this.Order = {(this.Order == null ? "null" : this.Order.ToString())}");
            toStringOutput.Add($"this.PspReference = {(this.PspReference == null ? "null" : this.PspReference)}");
            toStringOutput.Add($"this.RefusalReason = {(this.RefusalReason == null ? "null" : this.RefusalReason)}");
            toStringOutput.Add($"this.RefusalReasonCode = {(this.RefusalReasonCode == null ? "null" : this.RefusalReasonCode)}");
            toStringOutput.Add($"this.ResultCode = {(this.ResultCode == null ? "null" : this.ResultCode.ToString())}");
            toStringOutput.Add($"this.ServiceError = {(this.ServiceError == null ? "null" : this.ServiceError.ToString())}");
            toStringOutput.Add($"this.ShopperLocale = {(this.ShopperLocale == null ? "null" : this.ShopperLocale)}");
        }
    }
}