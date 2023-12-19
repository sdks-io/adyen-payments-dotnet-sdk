// <copyright file="DonationPaymentResponse.cs" company="APIMatic">
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
    /// DonationPaymentResponse.
    /// </summary>
    public class DonationPaymentResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DonationPaymentResponse"/> class.
        /// </summary>
        public DonationPaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DonationPaymentResponse"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="donationAccount">donationAccount.</param>
        /// <param name="id">id.</param>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="payment">payment.</param>
        /// <param name="reference">reference.</param>
        /// <param name="status">status.</param>
        public DonationPaymentResponse(
            Models.Amount23 amount = null,
            string donationAccount = null,
            string id = null,
            string merchantAccount = null,
            Models.PaymentResponse5 payment = null,
            string reference = null,
            Models.StatusEnum? status = null)
        {
            this.Amount = amount;
            this.DonationAccount = donationAccount;
            this.Id = id;
            this.MerchantAccount = merchantAccount;
            this.Payment = payment;
            this.Reference = reference;
            this.Status = status;
        }

        /// <summary>
        /// Authorised amount in the transaction.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount23 Amount { get; set; }

        /// <summary>
        /// The Adyen account name of your charity. We will provide you with this account name once your chosen charity has been [onboarded](https://docs.adyen.com/online-payments/donations#onboarding).
        /// </summary>
        [JsonProperty("donationAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string DonationAccount { get; set; }

        /// <summary>
        /// Your unique resource identifier.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        [JsonProperty("merchantAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Action to be taken for completing the payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentResponse5 Payment { get; set; }

        /// <summary>
        /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens ("-"). Maximum length: 80 characters.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <summary>
        /// The status of the donation transaction.
        /// Possible values:
        /// * **completed**
        /// * **pending**
        /// * **refused**
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StatusEnum? Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DonationPaymentResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is DonationPaymentResponse other &&                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.DonationAccount == null && other.DonationAccount == null) || (this.DonationAccount?.Equals(other.DonationAccount) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.DonationAccount = {(this.DonationAccount == null ? "null" : this.DonationAccount)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
        }
    }
}