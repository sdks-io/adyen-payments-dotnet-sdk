// <copyright file="ResponseAdditionalDataInstallments.cs" company="APIMatic">
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
    /// ResponseAdditionalDataInstallments.
    /// </summary>
    public class ResponseAdditionalDataInstallments
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataInstallments"/> class.
        /// </summary>
        public ResponseAdditionalDataInstallments()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataInstallments"/> class.
        /// </summary>
        /// <param name="installmentPaymentDataInstallmentType">installmentPaymentData.installmentType.</param>
        /// <param name="installmentPaymentDataOptionItemNrAnnualPercentageRate">installmentPaymentData.option[itemNr].annualPercentageRate.</param>
        /// <param name="installmentPaymentDataOptionItemNrFirstInstallmentAmount">installmentPaymentData.option[itemNr].firstInstallmentAmount.</param>
        /// <param name="installmentPaymentDataOptionItemNrInstallmentFee">installmentPaymentData.option[itemNr].installmentFee.</param>
        /// <param name="installmentPaymentDataOptionItemNrInterestRate">installmentPaymentData.option[itemNr].interestRate.</param>
        /// <param name="installmentPaymentDataOptionItemNrMaximumNumberOfInstallments">installmentPaymentData.option[itemNr].maximumNumberOfInstallments.</param>
        /// <param name="installmentPaymentDataOptionItemNrMinimumNumberOfInstallments">installmentPaymentData.option[itemNr].minimumNumberOfInstallments.</param>
        /// <param name="installmentPaymentDataOptionItemNrNumberOfInstallments">installmentPaymentData.option[itemNr].numberOfInstallments.</param>
        /// <param name="installmentPaymentDataOptionItemNrSubsequentInstallmentAmount">installmentPaymentData.option[itemNr].subsequentInstallmentAmount.</param>
        /// <param name="installmentPaymentDataOptionItemNrTotalAmountDue">installmentPaymentData.option[itemNr].totalAmountDue.</param>
        /// <param name="installmentPaymentDataPaymentOptions">installmentPaymentData.paymentOptions.</param>
        /// <param name="installmentsValue">installments.value.</param>
        public ResponseAdditionalDataInstallments(
            string installmentPaymentDataInstallmentType = null,
            string installmentPaymentDataOptionItemNrAnnualPercentageRate = null,
            string installmentPaymentDataOptionItemNrFirstInstallmentAmount = null,
            string installmentPaymentDataOptionItemNrInstallmentFee = null,
            string installmentPaymentDataOptionItemNrInterestRate = null,
            string installmentPaymentDataOptionItemNrMaximumNumberOfInstallments = null,
            string installmentPaymentDataOptionItemNrMinimumNumberOfInstallments = null,
            string installmentPaymentDataOptionItemNrNumberOfInstallments = null,
            string installmentPaymentDataOptionItemNrSubsequentInstallmentAmount = null,
            string installmentPaymentDataOptionItemNrTotalAmountDue = null,
            string installmentPaymentDataPaymentOptions = null,
            string installmentsValue = null)
        {
            this.InstallmentPaymentDataInstallmentType = installmentPaymentDataInstallmentType;
            this.InstallmentPaymentDataOptionItemNrAnnualPercentageRate = installmentPaymentDataOptionItemNrAnnualPercentageRate;
            this.InstallmentPaymentDataOptionItemNrFirstInstallmentAmount = installmentPaymentDataOptionItemNrFirstInstallmentAmount;
            this.InstallmentPaymentDataOptionItemNrInstallmentFee = installmentPaymentDataOptionItemNrInstallmentFee;
            this.InstallmentPaymentDataOptionItemNrInterestRate = installmentPaymentDataOptionItemNrInterestRate;
            this.InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments = installmentPaymentDataOptionItemNrMaximumNumberOfInstallments;
            this.InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments = installmentPaymentDataOptionItemNrMinimumNumberOfInstallments;
            this.InstallmentPaymentDataOptionItemNrNumberOfInstallments = installmentPaymentDataOptionItemNrNumberOfInstallments;
            this.InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount = installmentPaymentDataOptionItemNrSubsequentInstallmentAmount;
            this.InstallmentPaymentDataOptionItemNrTotalAmountDue = installmentPaymentDataOptionItemNrTotalAmountDue;
            this.InstallmentPaymentDataPaymentOptions = installmentPaymentDataPaymentOptions;
            this.InstallmentsValue = installmentsValue;
        }

        /// <summary>
        /// Type of installment. The value of `installmentType` should be **IssuerFinanced**.
        /// </summary>
        [JsonProperty("installmentPaymentData.installmentType", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentPaymentDataInstallmentType { get; set; }

        /// <summary>
        /// Annual interest rate.
        /// </summary>
        [JsonProperty("installmentPaymentData.option[itemNr].annualPercentageRate", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentPaymentDataOptionItemNrAnnualPercentageRate { get; set; }

        /// <summary>
        /// First Installment Amount in minor units.
        /// </summary>
        [JsonProperty("installmentPaymentData.option[itemNr].firstInstallmentAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentPaymentDataOptionItemNrFirstInstallmentAmount { get; set; }

        /// <summary>
        /// Installment fee amount in minor units.
        /// </summary>
        [JsonProperty("installmentPaymentData.option[itemNr].installmentFee", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentPaymentDataOptionItemNrInstallmentFee { get; set; }

        /// <summary>
        /// Interest rate for the installment period.
        /// </summary>
        [JsonProperty("installmentPaymentData.option[itemNr].interestRate", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentPaymentDataOptionItemNrInterestRate { get; set; }

        /// <summary>
        /// Maximum number of installments possible for this payment.
        /// </summary>
        [JsonProperty("installmentPaymentData.option[itemNr].maximumNumberOfInstallments", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments { get; set; }

        /// <summary>
        /// Minimum number of installments possible for this payment.
        /// </summary>
        [JsonProperty("installmentPaymentData.option[itemNr].minimumNumberOfInstallments", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments { get; set; }

        /// <summary>
        /// Total number of installments possible for this payment.
        /// </summary>
        [JsonProperty("installmentPaymentData.option[itemNr].numberOfInstallments", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentPaymentDataOptionItemNrNumberOfInstallments { get; set; }

        /// <summary>
        /// Subsequent Installment Amount in minor units.
        /// </summary>
        [JsonProperty("installmentPaymentData.option[itemNr].subsequentInstallmentAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount { get; set; }

        /// <summary>
        /// Total amount in minor units.
        /// </summary>
        [JsonProperty("installmentPaymentData.option[itemNr].totalAmountDue", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentPaymentDataOptionItemNrTotalAmountDue { get; set; }

        /// <summary>
        /// Possible values:
        /// * PayInInstallmentsOnly
        /// * PayInFullOnly
        /// * PayInFullOrInstallments
        /// </summary>
        [JsonProperty("installmentPaymentData.paymentOptions", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentPaymentDataPaymentOptions { get; set; }

        /// <summary>
        /// The number of installments that the payment amount should be charged with.
        /// Example: 5
        /// > Only relevant for card payments in countries that support installments.
        /// </summary>
        [JsonProperty("installments.value", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentsValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseAdditionalDataInstallments : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResponseAdditionalDataInstallments other &&                ((this.InstallmentPaymentDataInstallmentType == null && other.InstallmentPaymentDataInstallmentType == null) || (this.InstallmentPaymentDataInstallmentType?.Equals(other.InstallmentPaymentDataInstallmentType) == true)) &&
                ((this.InstallmentPaymentDataOptionItemNrAnnualPercentageRate == null && other.InstallmentPaymentDataOptionItemNrAnnualPercentageRate == null) || (this.InstallmentPaymentDataOptionItemNrAnnualPercentageRate?.Equals(other.InstallmentPaymentDataOptionItemNrAnnualPercentageRate) == true)) &&
                ((this.InstallmentPaymentDataOptionItemNrFirstInstallmentAmount == null && other.InstallmentPaymentDataOptionItemNrFirstInstallmentAmount == null) || (this.InstallmentPaymentDataOptionItemNrFirstInstallmentAmount?.Equals(other.InstallmentPaymentDataOptionItemNrFirstInstallmentAmount) == true)) &&
                ((this.InstallmentPaymentDataOptionItemNrInstallmentFee == null && other.InstallmentPaymentDataOptionItemNrInstallmentFee == null) || (this.InstallmentPaymentDataOptionItemNrInstallmentFee?.Equals(other.InstallmentPaymentDataOptionItemNrInstallmentFee) == true)) &&
                ((this.InstallmentPaymentDataOptionItemNrInterestRate == null && other.InstallmentPaymentDataOptionItemNrInterestRate == null) || (this.InstallmentPaymentDataOptionItemNrInterestRate?.Equals(other.InstallmentPaymentDataOptionItemNrInterestRate) == true)) &&
                ((this.InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments == null && other.InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments == null) || (this.InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments?.Equals(other.InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments) == true)) &&
                ((this.InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments == null && other.InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments == null) || (this.InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments?.Equals(other.InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments) == true)) &&
                ((this.InstallmentPaymentDataOptionItemNrNumberOfInstallments == null && other.InstallmentPaymentDataOptionItemNrNumberOfInstallments == null) || (this.InstallmentPaymentDataOptionItemNrNumberOfInstallments?.Equals(other.InstallmentPaymentDataOptionItemNrNumberOfInstallments) == true)) &&
                ((this.InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount == null && other.InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount == null) || (this.InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount?.Equals(other.InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount) == true)) &&
                ((this.InstallmentPaymentDataOptionItemNrTotalAmountDue == null && other.InstallmentPaymentDataOptionItemNrTotalAmountDue == null) || (this.InstallmentPaymentDataOptionItemNrTotalAmountDue?.Equals(other.InstallmentPaymentDataOptionItemNrTotalAmountDue) == true)) &&
                ((this.InstallmentPaymentDataPaymentOptions == null && other.InstallmentPaymentDataPaymentOptions == null) || (this.InstallmentPaymentDataPaymentOptions?.Equals(other.InstallmentPaymentDataPaymentOptions) == true)) &&
                ((this.InstallmentsValue == null && other.InstallmentsValue == null) || (this.InstallmentsValue?.Equals(other.InstallmentsValue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InstallmentPaymentDataInstallmentType = {(this.InstallmentPaymentDataInstallmentType == null ? "null" : this.InstallmentPaymentDataInstallmentType)}");
            toStringOutput.Add($"this.InstallmentPaymentDataOptionItemNrAnnualPercentageRate = {(this.InstallmentPaymentDataOptionItemNrAnnualPercentageRate == null ? "null" : this.InstallmentPaymentDataOptionItemNrAnnualPercentageRate)}");
            toStringOutput.Add($"this.InstallmentPaymentDataOptionItemNrFirstInstallmentAmount = {(this.InstallmentPaymentDataOptionItemNrFirstInstallmentAmount == null ? "null" : this.InstallmentPaymentDataOptionItemNrFirstInstallmentAmount)}");
            toStringOutput.Add($"this.InstallmentPaymentDataOptionItemNrInstallmentFee = {(this.InstallmentPaymentDataOptionItemNrInstallmentFee == null ? "null" : this.InstallmentPaymentDataOptionItemNrInstallmentFee)}");
            toStringOutput.Add($"this.InstallmentPaymentDataOptionItemNrInterestRate = {(this.InstallmentPaymentDataOptionItemNrInterestRate == null ? "null" : this.InstallmentPaymentDataOptionItemNrInterestRate)}");
            toStringOutput.Add($"this.InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments = {(this.InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments == null ? "null" : this.InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments)}");
            toStringOutput.Add($"this.InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments = {(this.InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments == null ? "null" : this.InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments)}");
            toStringOutput.Add($"this.InstallmentPaymentDataOptionItemNrNumberOfInstallments = {(this.InstallmentPaymentDataOptionItemNrNumberOfInstallments == null ? "null" : this.InstallmentPaymentDataOptionItemNrNumberOfInstallments)}");
            toStringOutput.Add($"this.InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount = {(this.InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount == null ? "null" : this.InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount)}");
            toStringOutput.Add($"this.InstallmentPaymentDataOptionItemNrTotalAmountDue = {(this.InstallmentPaymentDataOptionItemNrTotalAmountDue == null ? "null" : this.InstallmentPaymentDataOptionItemNrTotalAmountDue)}");
            toStringOutput.Add($"this.InstallmentPaymentDataPaymentOptions = {(this.InstallmentPaymentDataPaymentOptions == null ? "null" : this.InstallmentPaymentDataPaymentOptions)}");
            toStringOutput.Add($"this.InstallmentsValue = {(this.InstallmentsValue == null ? "null" : this.InstallmentsValue)}");
        }
    }
}