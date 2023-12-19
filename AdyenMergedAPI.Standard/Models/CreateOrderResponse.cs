// <copyright file="CreateOrderResponse.cs" company="APIMatic">
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
    /// CreateOrderResponse.
    /// </summary>
    public class CreateOrderResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderResponse"/> class.
        /// </summary>
        public CreateOrderResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderResponse"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="orderData">orderData.</param>
        /// <param name="remainingAmount">remainingAmount.</param>
        /// <param name="resultCode">resultCode.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="fraudResult">fraudResult.</param>
        /// <param name="pspReference">pspReference.</param>
        /// <param name="reference">reference.</param>
        /// <param name="refusalReason">refusalReason.</param>
        public CreateOrderResponse(
            Models.Amount10 amount,
            string expiresAt,
            string orderData,
            Models.Amount21 remainingAmount,
            string resultCode,
            Dictionary<string, string> additionalData = null,
            Models.FraudResult1 fraudResult = null,
            string pspReference = null,
            string reference = null,
            string refusalReason = null)
        {
            this.AdditionalData = additionalData;
            this.Amount = amount;
            this.ExpiresAt = expiresAt;
            this.FraudResult = fraudResult;
            this.OrderData = orderData;
            this.PspReference = pspReference;
            this.Reference = reference;
            this.RefusalReason = refusalReason;
            this.RemainingAmount = remainingAmount;
            this.ResultCode = resultCode;
        }

        /// <summary>
        /// Contains additional information about the payment. Some data fields are included only if you select them first: Go to **Customer Area** > **Developers** > **Additional data**.
        /// </summary>
        [JsonProperty("additionalData", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// The initial amount of the order.
        /// </summary>
        [JsonProperty("amount")]
        public Models.Amount10 Amount { get; set; }

        /// <summary>
        /// The date that the order will expire.
        /// </summary>
        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// The fraud result properties of the payment.
        /// </summary>
        [JsonProperty("fraudResult", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FraudResult1 FraudResult { get; set; }

        /// <summary>
        /// The encrypted data that will be used by merchant for adding payments to the order.
        /// </summary>
        [JsonProperty("orderData")]
        public string OrderData { get; set; }

        /// <summary>
        /// Adyen's 16-character reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.
        /// </summary>
        [JsonProperty("pspReference", NullValueHandling = NullValueHandling.Ignore)]
        public string PspReference { get; set; }

        /// <summary>
        /// The reference provided by merchant for creating the order.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <summary>
        /// If the payment's authorisation is refused or an error occurs during authorisation, this field holds Adyen's mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes `resultCode` and `refusalReason` values.
        /// For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons).
        /// </summary>
        [JsonProperty("refusalReason", NullValueHandling = NullValueHandling.Ignore)]
        public string RefusalReason { get; set; }

        /// <summary>
        /// The remaining amount in the order.
        /// </summary>
        [JsonProperty("remainingAmount")]
        public Models.Amount21 RemainingAmount { get; set; }

        /// <summary>
        /// The result of the order creation request.
        ///  The value is always **Success**.
        /// </summary>
        [JsonProperty("resultCode")]
        public string ResultCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateOrderResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateOrderResponse other &&                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.FraudResult == null && other.FraudResult == null) || (this.FraudResult?.Equals(other.FraudResult) == true)) &&
                ((this.OrderData == null && other.OrderData == null) || (this.OrderData?.Equals(other.OrderData) == true)) &&
                ((this.PspReference == null && other.PspReference == null) || (this.PspReference?.Equals(other.PspReference) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.RefusalReason == null && other.RefusalReason == null) || (this.RefusalReason?.Equals(other.RefusalReason) == true)) &&
                ((this.RemainingAmount == null && other.RemainingAmount == null) || (this.RemainingAmount?.Equals(other.RemainingAmount) == true)) &&
                ((this.ResultCode == null && other.ResultCode == null) || (this.ResultCode?.Equals(other.ResultCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt)}");
            toStringOutput.Add($"this.FraudResult = {(this.FraudResult == null ? "null" : this.FraudResult.ToString())}");
            toStringOutput.Add($"this.OrderData = {(this.OrderData == null ? "null" : this.OrderData)}");
            toStringOutput.Add($"this.PspReference = {(this.PspReference == null ? "null" : this.PspReference)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.RefusalReason = {(this.RefusalReason == null ? "null" : this.RefusalReason)}");
            toStringOutput.Add($"this.RemainingAmount = {(this.RemainingAmount == null ? "null" : this.RemainingAmount.ToString())}");
            toStringOutput.Add($"this.ResultCode = {(this.ResultCode == null ? "null" : this.ResultCode)}");
        }
    }
}