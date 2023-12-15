// <copyright file="StoreDetailAndSubmitRequest.cs" company="APIMatic">
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
    /// StoreDetailAndSubmitRequest.
    /// </summary>
    public class StoreDetailAndSubmitRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDetailAndSubmitRequest"/> class.
        /// </summary>
        public StoreDetailAndSubmitRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDetailAndSubmitRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="nationality">nationality.</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="reference">reference.</param>
        /// <param name="shopperEmail">shopperEmail.</param>
        /// <param name="shopperReference">shopperReference.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="bank">bank.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="card">card.</param>
        /// <param name="fraudOffset">fraudOffset.</param>
        /// <param name="selectedBrand">selectedBrand.</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="shopperStatement">shopperStatement.</param>
        /// <param name="socialSecurityNumber">socialSecurityNumber.</param>
        /// <param name="telephoneNumber">telephoneNumber.</param>
        public StoreDetailAndSubmitRequest(
            Models.Amount amount,
            DateTime dateOfBirth,
            Models.EntityType1Enum entityType,
            string merchantAccount,
            string nationality,
            Models.Recurring recurring,
            string reference,
            string shopperEmail,
            string shopperReference,
            Dictionary<string, string> additionalData = null,
            Models.BankAccount bank = null,
            Models.Address billingAddress = null,
            Models.Card card = null,
            int? fraudOffset = null,
            string selectedBrand = null,
            Models.Name shopperName = null,
            string shopperStatement = null,
            string socialSecurityNumber = null,
            string telephoneNumber = null)
        {
            this.AdditionalData = additionalData;
            this.Amount = amount;
            this.Bank = bank;
            this.BillingAddress = billingAddress;
            this.Card = card;
            this.DateOfBirth = dateOfBirth;
            this.EntityType = entityType;
            this.FraudOffset = fraudOffset;
            this.MerchantAccount = merchantAccount;
            this.Nationality = nationality;
            this.Recurring = recurring;
            this.Reference = reference;
            this.SelectedBrand = selectedBrand;
            this.ShopperEmail = shopperEmail;
            this.ShopperName = shopperName;
            this.ShopperReference = shopperReference;
            this.ShopperStatement = shopperStatement;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.TelephoneNumber = telephoneNumber;
        }

        /// <summary>
        /// This field contains additional data, which may be required for a particular request.
        /// </summary>
        [JsonProperty("additionalData", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// A container object for the payable amount information of the transaction.
        /// </summary>
        [JsonProperty("amount")]
        public Models.Amount Amount { get; set; }

        /// <summary>
        /// A container for bank account data.
        /// > This field is mandatory if `card` is not provided.
        /// </summary>
        [JsonProperty("bank", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccount Bank { get; set; }

        /// <summary>
        /// The billing address.
        /// > The `billingAddress` object is required for cross-border payouts to and from Canada. Include all of the fields within this object.
        /// </summary>
        [JsonProperty("billingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address BillingAddress { get; set; }

        /// <summary>
        /// A container for card data.
        /// > This field is mandatory if `bank` is not provided.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Card Card { get; set; }

        /// <summary>
        /// The date of birth.
        /// Format: [ISO-8601](https://www.w3.org/TR/NOTE-datetime); example: YYYY-MM-DD
        /// For Paysafecard it must be the same as used when registering the Paysafecard account.
        /// > This field is mandatory for natural persons.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("dateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The type of the entity the payout is processed for.
        /// </summary>
        [JsonProperty("entityType")]
        public Models.EntityType1Enum EntityType { get; set; }

        /// <summary>
        /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
        /// </summary>
        [JsonProperty("fraudOffset", NullValueHandling = NullValueHandling.Ignore)]
        public int? FraudOffset { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        [JsonProperty("merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The shopper's nationality.
        /// A valid value is an ISO 2-character country code (e.g. 'NL').
        /// </summary>
        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// A container for the type of recurring contract to be retrieved.
        /// The recurring.contract must be set to `PAYOUT`
        /// </summary>
        [JsonProperty("recurring")]
        public Models.Recurring Recurring { get; set; }

        /// <summary>
        /// The merchant reference for this payment. This reference will be used in all communication to the merchant about the status of the payout. Although it is a good idea to make sure it is unique, this is not a requirement.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The name of the brand to make a payout to.
        /// For Paysafecard it must be set to `paysafecard`.
        /// </summary>
        [JsonProperty("selectedBrand", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectedBrand { get; set; }

        /// <summary>
        /// The shopper's email address.
        /// </summary>
        [JsonProperty("shopperEmail")]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// The shopper's name.
        /// When the `entityType` is `Company`, the `shopperName.lastName` must contain the company name.
        /// </summary>
        [JsonProperty("shopperName", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Name ShopperName { get; set; }

        /// <summary>
        /// The shopper's reference for the payment transaction.
        /// </summary>
        [JsonProperty("shopperReference")]
        public string ShopperReference { get; set; }

        /// <summary>
        /// The description of this payout. This description is shown on the bank statement of the shopper (if this is supported by the chosen payment method).
        /// </summary>
        [JsonProperty("shopperStatement", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperStatement { get; set; }

        /// <summary>
        /// The shopper's social security number.
        /// </summary>
        [JsonProperty("socialSecurityNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// The shopper's phone number.
        /// </summary>
        [JsonProperty("telephoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string TelephoneNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StoreDetailAndSubmitRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is StoreDetailAndSubmitRequest other &&                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Bank == null && other.Bank == null) || (this.Bank?.Equals(other.Bank) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                this.DateOfBirth.Equals(other.DateOfBirth) &&
                this.EntityType.Equals(other.EntityType) &&
                ((this.FraudOffset == null && other.FraudOffset == null) || (this.FraudOffset?.Equals(other.FraudOffset) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.Nationality == null && other.Nationality == null) || (this.Nationality?.Equals(other.Nationality) == true)) &&
                ((this.Recurring == null && other.Recurring == null) || (this.Recurring?.Equals(other.Recurring) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.SelectedBrand == null && other.SelectedBrand == null) || (this.SelectedBrand?.Equals(other.SelectedBrand) == true)) &&
                ((this.ShopperEmail == null && other.ShopperEmail == null) || (this.ShopperEmail?.Equals(other.ShopperEmail) == true)) &&
                ((this.ShopperName == null && other.ShopperName == null) || (this.ShopperName?.Equals(other.ShopperName) == true)) &&
                ((this.ShopperReference == null && other.ShopperReference == null) || (this.ShopperReference?.Equals(other.ShopperReference) == true)) &&
                ((this.ShopperStatement == null && other.ShopperStatement == null) || (this.ShopperStatement?.Equals(other.ShopperStatement) == true)) &&
                ((this.SocialSecurityNumber == null && other.SocialSecurityNumber == null) || (this.SocialSecurityNumber?.Equals(other.SocialSecurityNumber) == true)) &&
                ((this.TelephoneNumber == null && other.TelephoneNumber == null) || (this.TelephoneNumber?.Equals(other.TelephoneNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.Bank = {(this.Bank == null ? "null" : this.Bank.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.DateOfBirth = {this.DateOfBirth}");
            toStringOutput.Add($"this.EntityType = {this.EntityType}");
            toStringOutput.Add($"this.FraudOffset = {(this.FraudOffset == null ? "null" : this.FraudOffset.ToString())}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.Nationality = {(this.Nationality == null ? "null" : this.Nationality)}");
            toStringOutput.Add($"this.Recurring = {(this.Recurring == null ? "null" : this.Recurring.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.SelectedBrand = {(this.SelectedBrand == null ? "null" : this.SelectedBrand)}");
            toStringOutput.Add($"this.ShopperEmail = {(this.ShopperEmail == null ? "null" : this.ShopperEmail)}");
            toStringOutput.Add($"this.ShopperName = {(this.ShopperName == null ? "null" : this.ShopperName.ToString())}");
            toStringOutput.Add($"this.ShopperReference = {(this.ShopperReference == null ? "null" : this.ShopperReference)}");
            toStringOutput.Add($"this.ShopperStatement = {(this.ShopperStatement == null ? "null" : this.ShopperStatement)}");
            toStringOutput.Add($"this.SocialSecurityNumber = {(this.SocialSecurityNumber == null ? "null" : this.SocialSecurityNumber)}");
            toStringOutput.Add($"this.TelephoneNumber = {(this.TelephoneNumber == null ? "null" : this.TelephoneNumber)}");
        }
    }
}