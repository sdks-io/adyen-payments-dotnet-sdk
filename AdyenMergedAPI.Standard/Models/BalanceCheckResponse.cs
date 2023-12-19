// <copyright file="BalanceCheckResponse.cs" company="APIMatic">
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
    /// BalanceCheckResponse.
    /// </summary>
    public class BalanceCheckResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceCheckResponse"/> class.
        /// </summary>
        public BalanceCheckResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceCheckResponse"/> class.
        /// </summary>
        /// <param name="balance">balance.</param>
        /// <param name="resultCode">resultCode.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="fraudResult">fraudResult.</param>
        /// <param name="pspReference">pspReference.</param>
        /// <param name="refusalReason">refusalReason.</param>
        /// <param name="transactionLimit">transactionLimit.</param>
        public BalanceCheckResponse(
            Models.Amount8 balance,
            Models.ResultCodeEnum resultCode,
            Dictionary<string, string> additionalData = null,
            Models.FraudResult1 fraudResult = null,
            string pspReference = null,
            string refusalReason = null,
            Models.Amount9 transactionLimit = null)
        {
            this.AdditionalData = additionalData;
            this.Balance = balance;
            this.FraudResult = fraudResult;
            this.PspReference = pspReference;
            this.RefusalReason = refusalReason;
            this.ResultCode = resultCode;
            this.TransactionLimit = transactionLimit;
        }

        /// <summary>
        /// Contains additional information about the payment. Some data fields are included only if you select them first: Go to **Customer Area** > **Developers** > **Additional data**.
        /// </summary>
        [JsonProperty("additionalData", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// The balance for the payment method.
        /// </summary>
        [JsonProperty("balance")]
        public Models.Amount8 Balance { get; set; }

        /// <summary>
        /// The fraud result properties of the payment.
        /// </summary>
        [JsonProperty("fraudResult", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FraudResult1 FraudResult { get; set; }

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
        /// The result of the cancellation request.
        /// Possible values:
        /// * **Success** – Indicates that the balance check was successful.
        /// * **NotEnoughBalance** – Commonly indicates that the card did not have enough balance to pay the amount in the request, or that the currency of the balance on the card did not match the currency of the requested amount.
        /// * **Failed** – Indicates that the balance check failed.
        /// </summary>
        [JsonProperty("resultCode")]
        public Models.ResultCodeEnum ResultCode { get; set; }

        /// <summary>
        /// The maximum spendable balance for a single transaction. Applicable to some gift cards.
        /// </summary>
        [JsonProperty("transactionLimit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount9 TransactionLimit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BalanceCheckResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is BalanceCheckResponse other &&                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.Balance == null && other.Balance == null) || (this.Balance?.Equals(other.Balance) == true)) &&
                ((this.FraudResult == null && other.FraudResult == null) || (this.FraudResult?.Equals(other.FraudResult) == true)) &&
                ((this.PspReference == null && other.PspReference == null) || (this.PspReference?.Equals(other.PspReference) == true)) &&
                ((this.RefusalReason == null && other.RefusalReason == null) || (this.RefusalReason?.Equals(other.RefusalReason) == true)) &&
                this.ResultCode.Equals(other.ResultCode) &&
                ((this.TransactionLimit == null && other.TransactionLimit == null) || (this.TransactionLimit?.Equals(other.TransactionLimit) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.Balance = {(this.Balance == null ? "null" : this.Balance.ToString())}");
            toStringOutput.Add($"this.FraudResult = {(this.FraudResult == null ? "null" : this.FraudResult.ToString())}");
            toStringOutput.Add($"this.PspReference = {(this.PspReference == null ? "null" : this.PspReference)}");
            toStringOutput.Add($"this.RefusalReason = {(this.RefusalReason == null ? "null" : this.RefusalReason)}");
            toStringOutput.Add($"this.ResultCode = {this.ResultCode}");
            toStringOutput.Add($"this.TransactionLimit = {(this.TransactionLimit == null ? "null" : this.TransactionLimit.ToString())}");
        }
    }
}