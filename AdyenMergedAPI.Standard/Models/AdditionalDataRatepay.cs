// <copyright file="AdditionalDataRatepay.cs" company="APIMatic">
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
    /// AdditionalDataRatepay.
    /// </summary>
    public class AdditionalDataRatepay
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataRatepay"/> class.
        /// </summary>
        public AdditionalDataRatepay()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataRatepay"/> class.
        /// </summary>
        /// <param name="ratepayInstallmentAmount">ratepay.installmentAmount.</param>
        /// <param name="ratepayInterestRate">ratepay.interestRate.</param>
        /// <param name="ratepayLastInstallmentAmount">ratepay.lastInstallmentAmount.</param>
        /// <param name="ratepayPaymentFirstday">ratepay.paymentFirstday.</param>
        /// <param name="ratepaydataDeliveryDate">ratepaydata.deliveryDate.</param>
        /// <param name="ratepaydataDueDate">ratepaydata.dueDate.</param>
        /// <param name="ratepaydataInvoiceDate">ratepaydata.invoiceDate.</param>
        /// <param name="ratepaydataInvoiceId">ratepaydata.invoiceId.</param>
        public AdditionalDataRatepay(
            string ratepayInstallmentAmount = null,
            string ratepayInterestRate = null,
            string ratepayLastInstallmentAmount = null,
            string ratepayPaymentFirstday = null,
            string ratepaydataDeliveryDate = null,
            string ratepaydataDueDate = null,
            string ratepaydataInvoiceDate = null,
            string ratepaydataInvoiceId = null)
        {
            this.RatepayInstallmentAmount = ratepayInstallmentAmount;
            this.RatepayInterestRate = ratepayInterestRate;
            this.RatepayLastInstallmentAmount = ratepayLastInstallmentAmount;
            this.RatepayPaymentFirstday = ratepayPaymentFirstday;
            this.RatepaydataDeliveryDate = ratepaydataDeliveryDate;
            this.RatepaydataDueDate = ratepaydataDueDate;
            this.RatepaydataInvoiceDate = ratepaydataInvoiceDate;
            this.RatepaydataInvoiceId = ratepaydataInvoiceId;
        }

        /// <summary>
        /// Amount the customer has to pay each month.
        /// </summary>
        [JsonProperty("ratepay.installmentAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string RatepayInstallmentAmount { get; set; }

        /// <summary>
        /// Interest rate of this installment.
        /// </summary>
        [JsonProperty("ratepay.interestRate", NullValueHandling = NullValueHandling.Ignore)]
        public string RatepayInterestRate { get; set; }

        /// <summary>
        /// Amount of the last installment.
        /// </summary>
        [JsonProperty("ratepay.lastInstallmentAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string RatepayLastInstallmentAmount { get; set; }

        /// <summary>
        /// Calendar day of the first payment.
        /// </summary>
        [JsonProperty("ratepay.paymentFirstday", NullValueHandling = NullValueHandling.Ignore)]
        public string RatepayPaymentFirstday { get; set; }

        /// <summary>
        /// Date the merchant delivered the goods to the customer.
        /// </summary>
        [JsonProperty("ratepaydata.deliveryDate", NullValueHandling = NullValueHandling.Ignore)]
        public string RatepaydataDeliveryDate { get; set; }

        /// <summary>
        /// Date by which the customer must settle the payment.
        /// </summary>
        [JsonProperty("ratepaydata.dueDate", NullValueHandling = NullValueHandling.Ignore)]
        public string RatepaydataDueDate { get; set; }

        /// <summary>
        /// Invoice date, defined by the merchant. If not included, the invoice date is set to the delivery date.
        /// </summary>
        [JsonProperty("ratepaydata.invoiceDate", NullValueHandling = NullValueHandling.Ignore)]
        public string RatepaydataInvoiceDate { get; set; }

        /// <summary>
        /// Identification name or number for the invoice, defined by the merchant.
        /// </summary>
        [JsonProperty("ratepaydata.invoiceId", NullValueHandling = NullValueHandling.Ignore)]
        public string RatepaydataInvoiceId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalDataRatepay : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdditionalDataRatepay other &&                ((this.RatepayInstallmentAmount == null && other.RatepayInstallmentAmount == null) || (this.RatepayInstallmentAmount?.Equals(other.RatepayInstallmentAmount) == true)) &&
                ((this.RatepayInterestRate == null && other.RatepayInterestRate == null) || (this.RatepayInterestRate?.Equals(other.RatepayInterestRate) == true)) &&
                ((this.RatepayLastInstallmentAmount == null && other.RatepayLastInstallmentAmount == null) || (this.RatepayLastInstallmentAmount?.Equals(other.RatepayLastInstallmentAmount) == true)) &&
                ((this.RatepayPaymentFirstday == null && other.RatepayPaymentFirstday == null) || (this.RatepayPaymentFirstday?.Equals(other.RatepayPaymentFirstday) == true)) &&
                ((this.RatepaydataDeliveryDate == null && other.RatepaydataDeliveryDate == null) || (this.RatepaydataDeliveryDate?.Equals(other.RatepaydataDeliveryDate) == true)) &&
                ((this.RatepaydataDueDate == null && other.RatepaydataDueDate == null) || (this.RatepaydataDueDate?.Equals(other.RatepaydataDueDate) == true)) &&
                ((this.RatepaydataInvoiceDate == null && other.RatepaydataInvoiceDate == null) || (this.RatepaydataInvoiceDate?.Equals(other.RatepaydataInvoiceDate) == true)) &&
                ((this.RatepaydataInvoiceId == null && other.RatepaydataInvoiceId == null) || (this.RatepaydataInvoiceId?.Equals(other.RatepaydataInvoiceId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RatepayInstallmentAmount = {(this.RatepayInstallmentAmount == null ? "null" : this.RatepayInstallmentAmount)}");
            toStringOutput.Add($"this.RatepayInterestRate = {(this.RatepayInterestRate == null ? "null" : this.RatepayInterestRate)}");
            toStringOutput.Add($"this.RatepayLastInstallmentAmount = {(this.RatepayLastInstallmentAmount == null ? "null" : this.RatepayLastInstallmentAmount)}");
            toStringOutput.Add($"this.RatepayPaymentFirstday = {(this.RatepayPaymentFirstday == null ? "null" : this.RatepayPaymentFirstday)}");
            toStringOutput.Add($"this.RatepaydataDeliveryDate = {(this.RatepaydataDeliveryDate == null ? "null" : this.RatepaydataDeliveryDate)}");
            toStringOutput.Add($"this.RatepaydataDueDate = {(this.RatepaydataDueDate == null ? "null" : this.RatepaydataDueDate)}");
            toStringOutput.Add($"this.RatepaydataInvoiceDate = {(this.RatepaydataInvoiceDate == null ? "null" : this.RatepaydataInvoiceDate)}");
            toStringOutput.Add($"this.RatepaydataInvoiceId = {(this.RatepaydataInvoiceId == null ? "null" : this.RatepaydataInvoiceId)}");
        }
    }
}