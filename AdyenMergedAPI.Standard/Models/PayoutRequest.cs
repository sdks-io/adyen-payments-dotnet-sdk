// <copyright file="PayoutRequest.cs" company="APIMatic">
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
    /// PayoutRequest.
    /// </summary>
    public class PayoutRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutRequest"/> class.
        /// </summary>
        public PayoutRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="reference">reference.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="card">card.</param>
        /// <param name="fraudOffset">fraudOffset.</param>
        /// <param name="fundSource">fundSource.</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="selectedRecurringDetailReference">selectedRecurringDetailReference.</param>
        /// <param name="shopperEmail">shopperEmail.</param>
        /// <param name="shopperInteraction">shopperInteraction.</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="shopperReference">shopperReference.</param>
        /// <param name="telephoneNumber">telephoneNumber.</param>
        public PayoutRequest(
            Models.Amount amount,
            string merchantAccount,
            string reference,
            Models.Address billingAddress = null,
            Models.Card card = null,
            int? fraudOffset = null,
            Models.FundSource11 fundSource = null,
            Models.Recurring recurring = null,
            string selectedRecurringDetailReference = null,
            string shopperEmail = null,
            Models.ShopperInteractionEnum? shopperInteraction = null,
            Models.Name shopperName = null,
            string shopperReference = null,
            string telephoneNumber = null)
        {
            this.Amount = amount;
            this.BillingAddress = billingAddress;
            this.Card = card;
            this.FraudOffset = fraudOffset;
            this.FundSource = fundSource;
            this.MerchantAccount = merchantAccount;
            this.Recurring = recurring;
            this.Reference = reference;
            this.SelectedRecurringDetailReference = selectedRecurringDetailReference;
            this.ShopperEmail = shopperEmail;
            this.ShopperInteraction = shopperInteraction;
            this.ShopperName = shopperName;
            this.ShopperReference = shopperReference;
            this.TelephoneNumber = telephoneNumber;
        }

        /// <summary>
        /// The amount information for the transaction (in [minor units](https://docs.adyen.com/development-resources/currency-codes)). For [BIN or card verification](https://docs.adyen.com/payment-methods/cards/bin-data-and-card-verification) requests, set amount to 0 (zero).
        /// </summary>
        [JsonProperty("amount")]
        public Models.Amount Amount { get; set; }

        /// <summary>
        /// The address where to send the invoice.
        /// > The `billingAddress` object is required in the following scenarios. Include all of the fields within this object.
        /// >* For 3D Secure 2 transactions in all browser-based and mobile implementations.
        /// >* For cross-border payouts to and from Canada.
        /// </summary>
        [JsonProperty("billingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address BillingAddress { get; set; }

        /// <summary>
        /// A container for card data.
        /// > Either `bankAccount` or `card` field must be provided in a payment request.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Card Card { get; set; }

        /// <summary>
        /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
        /// </summary>
        [JsonProperty("fraudOffset", NullValueHandling = NullValueHandling.Ignore)]
        public int? FraudOffset { get; set; }

        /// <summary>
        /// The person or entity funding the money.
        /// </summary>
        [JsonProperty("fundSource", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FundSource11 FundSource { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        [JsonProperty("merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The recurring settings for the payment. Use this property when you want to enable [recurring payments](https://docs.adyen.com/classic-integration/recurring-payments).
        /// </summary>
        [JsonProperty("recurring", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Recurring Recurring { get; set; }

        /// <summary>
        /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement.
        /// If you need to provide multiple references for a transaction, separate them with hyphens ("-").
        /// Maximum length: 80 characters.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The `recurringDetailReference` you want to use for this payment. The value `LATEST` can be used to select the most recently stored recurring detail.
        /// </summary>
        [JsonProperty("selectedRecurringDetailReference", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectedRecurringDetailReference { get; set; }

        /// <summary>
        /// The shopper's email address. We recommend that you provide this data, as it is used in velocity fraud checks.
        /// > For 3D Secure 2 transactions, schemes require `shopperEmail` for all browser-based and mobile implementations.
        /// </summary>
        [JsonProperty("shopperEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer.
        /// For the web service API, Adyen assumes Ecommerce shopper interaction by default.
        /// This field has the following possible values:
        /// * `Ecommerce` - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request.
        /// * `ContAuth` - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment).
        /// * `Moto` - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone.
        /// * `POS` - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
        /// </summary>
        [JsonProperty("shopperInteraction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ShopperInteractionEnum? ShopperInteraction { get; set; }

        /// <summary>
        /// The shopper's full name.
        /// </summary>
        [JsonProperty("shopperName", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Name ShopperName { get; set; }

        /// <summary>
        /// Required for recurring payments.
        /// Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.
        /// > Your reference must not include personally identifiable information (PII), for example name or email address.
        /// </summary>
        [JsonProperty("shopperReference", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// The shopper's telephone number.
        /// </summary>
        [JsonProperty("telephoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string TelephoneNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PayoutRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is PayoutRequest other &&                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.FraudOffset == null && other.FraudOffset == null) || (this.FraudOffset?.Equals(other.FraudOffset) == true)) &&
                ((this.FundSource == null && other.FundSource == null) || (this.FundSource?.Equals(other.FundSource) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.Recurring == null && other.Recurring == null) || (this.Recurring?.Equals(other.Recurring) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.SelectedRecurringDetailReference == null && other.SelectedRecurringDetailReference == null) || (this.SelectedRecurringDetailReference?.Equals(other.SelectedRecurringDetailReference) == true)) &&
                ((this.ShopperEmail == null && other.ShopperEmail == null) || (this.ShopperEmail?.Equals(other.ShopperEmail) == true)) &&
                ((this.ShopperInteraction == null && other.ShopperInteraction == null) || (this.ShopperInteraction?.Equals(other.ShopperInteraction) == true)) &&
                ((this.ShopperName == null && other.ShopperName == null) || (this.ShopperName?.Equals(other.ShopperName) == true)) &&
                ((this.ShopperReference == null && other.ShopperReference == null) || (this.ShopperReference?.Equals(other.ShopperReference) == true)) &&
                ((this.TelephoneNumber == null && other.TelephoneNumber == null) || (this.TelephoneNumber?.Equals(other.TelephoneNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.FraudOffset = {(this.FraudOffset == null ? "null" : this.FraudOffset.ToString())}");
            toStringOutput.Add($"this.FundSource = {(this.FundSource == null ? "null" : this.FundSource.ToString())}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.Recurring = {(this.Recurring == null ? "null" : this.Recurring.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.SelectedRecurringDetailReference = {(this.SelectedRecurringDetailReference == null ? "null" : this.SelectedRecurringDetailReference)}");
            toStringOutput.Add($"this.ShopperEmail = {(this.ShopperEmail == null ? "null" : this.ShopperEmail)}");
            toStringOutput.Add($"this.ShopperInteraction = {(this.ShopperInteraction == null ? "null" : this.ShopperInteraction.ToString())}");
            toStringOutput.Add($"this.ShopperName = {(this.ShopperName == null ? "null" : this.ShopperName.ToString())}");
            toStringOutput.Add($"this.ShopperReference = {(this.ShopperReference == null ? "null" : this.ShopperReference)}");
            toStringOutput.Add($"this.TelephoneNumber = {(this.TelephoneNumber == null ? "null" : this.TelephoneNumber)}");
        }
    }
}