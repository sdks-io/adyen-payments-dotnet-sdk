// <copyright file="SubmitRequest.cs" company="APIMatic">
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
    /// SubmitRequest.
    /// </summary>
    public class SubmitRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitRequest"/> class.
        /// </summary>
        public SubmitRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="reference">reference.</param>
        /// <param name="selectedRecurringDetailReference">selectedRecurringDetailReference.</param>
        /// <param name="shopperEmail">shopperEmail.</param>
        /// <param name="shopperReference">shopperReference.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="fraudOffset">fraudOffset.</param>
        /// <param name="nationality">nationality.</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="shopperStatement">shopperStatement.</param>
        /// <param name="socialSecurityNumber">socialSecurityNumber.</param>
        public SubmitRequest(
            Models.Amount amount,
            string merchantAccount,
            Models.Recurring recurring,
            string reference,
            string selectedRecurringDetailReference,
            string shopperEmail,
            string shopperReference,
            Dictionary<string, string> additionalData = null,
            DateTime? dateOfBirth = null,
            Models.EntityType2Enum? entityType = null,
            int? fraudOffset = null,
            string nationality = null,
            Models.Name shopperName = null,
            string shopperStatement = null,
            string socialSecurityNumber = null)
        {
            this.AdditionalData = additionalData;
            this.Amount = amount;
            this.DateOfBirth = dateOfBirth;
            this.EntityType = entityType;
            this.FraudOffset = fraudOffset;
            this.MerchantAccount = merchantAccount;
            this.Nationality = nationality;
            this.Recurring = recurring;
            this.Reference = reference;
            this.SelectedRecurringDetailReference = selectedRecurringDetailReference;
            this.ShopperEmail = shopperEmail;
            this.ShopperName = shopperName;
            this.ShopperReference = shopperReference;
            this.ShopperStatement = shopperStatement;
            this.SocialSecurityNumber = socialSecurityNumber;
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
        /// The date of birth.
        /// Format: ISO-8601; example: YYYY-MM-DD
        /// For Paysafecard it must be the same as used when registering the Paysafecard account.
        /// > This field is mandatory for natural persons.
        /// > This field is required to update the existing `dateOfBirth` that is associated with this recurring contract.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("dateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// The type of the entity the payout is processed for.
        /// Allowed values:
        /// * NaturalPerson
        /// * Company
        /// > This field is required to update the existing `entityType` that is associated with this recurring contract.
        /// </summary>
        [JsonProperty("entityType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EntityType2Enum? EntityType { get; set; }

        /// <summary>
        /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
        /// </summary>
        [JsonProperty("fraudOffset", NullValueHandling = NullValueHandling.Ignore)]
        public int? FraudOffset { get; set; }

        /// <summary>
        /// The merchant account identifier you want to process the transaction request with.
        /// </summary>
        [JsonProperty("merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The shopper's nationality.
        /// A valid value is an ISO 2-character country code (e.g. 'NL').
        /// > This field is required to update the existing nationality that is associated with this recurring contract.
        /// </summary>
        [JsonProperty("nationality", NullValueHandling = NullValueHandling.Ignore)]
        public string Nationality { get; set; }

        /// <summary>
        /// A container for the type of recurring contract to be retrieved.
        /// The `recurring.contract` must be set to "PAYOUT".
        /// </summary>
        [JsonProperty("recurring")]
        public Models.Recurring Recurring { get; set; }

        /// <summary>
        /// The merchant reference for this payout. This reference will be used in all communication to the merchant about the status of the payout. Although it is a good idea to make sure it is unique, this is not a requirement.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// This is the `recurringDetailReference` you want to use for this payout.
        /// You can use the value LATEST to select the most recently used recurring detail.
        /// </summary>
        [JsonProperty("selectedRecurringDetailReference")]
        public string SelectedRecurringDetailReference { get; set; }

        /// <summary>
        /// The shopper's email address.
        /// </summary>
        [JsonProperty("shopperEmail")]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// The shopper's name.
        /// In case the `entityType` is `Company`, the `shopperName.lastName` must contain the company name.
        /// > This field is required to update the existing `shopperName` associated with a recurring contract.
        /// </summary>
        [JsonProperty("shopperName", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Name ShopperName { get; set; }

        /// <summary>
        /// The shopper's reference for the payout transaction.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubmitRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubmitRequest other &&                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.DateOfBirth == null && other.DateOfBirth == null) || (this.DateOfBirth?.Equals(other.DateOfBirth) == true)) &&
                ((this.EntityType == null && other.EntityType == null) || (this.EntityType?.Equals(other.EntityType) == true)) &&
                ((this.FraudOffset == null && other.FraudOffset == null) || (this.FraudOffset?.Equals(other.FraudOffset) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.Nationality == null && other.Nationality == null) || (this.Nationality?.Equals(other.Nationality) == true)) &&
                ((this.Recurring == null && other.Recurring == null) || (this.Recurring?.Equals(other.Recurring) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.SelectedRecurringDetailReference == null && other.SelectedRecurringDetailReference == null) || (this.SelectedRecurringDetailReference?.Equals(other.SelectedRecurringDetailReference) == true)) &&
                ((this.ShopperEmail == null && other.ShopperEmail == null) || (this.ShopperEmail?.Equals(other.ShopperEmail) == true)) &&
                ((this.ShopperName == null && other.ShopperName == null) || (this.ShopperName?.Equals(other.ShopperName) == true)) &&
                ((this.ShopperReference == null && other.ShopperReference == null) || (this.ShopperReference?.Equals(other.ShopperReference) == true)) &&
                ((this.ShopperStatement == null && other.ShopperStatement == null) || (this.ShopperStatement?.Equals(other.ShopperStatement) == true)) &&
                ((this.SocialSecurityNumber == null && other.SocialSecurityNumber == null) || (this.SocialSecurityNumber?.Equals(other.SocialSecurityNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.DateOfBirth = {(this.DateOfBirth == null ? "null" : this.DateOfBirth.ToString())}");
            toStringOutput.Add($"this.EntityType = {(this.EntityType == null ? "null" : this.EntityType.ToString())}");
            toStringOutput.Add($"this.FraudOffset = {(this.FraudOffset == null ? "null" : this.FraudOffset.ToString())}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.Nationality = {(this.Nationality == null ? "null" : this.Nationality)}");
            toStringOutput.Add($"this.Recurring = {(this.Recurring == null ? "null" : this.Recurring.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.SelectedRecurringDetailReference = {(this.SelectedRecurringDetailReference == null ? "null" : this.SelectedRecurringDetailReference)}");
            toStringOutput.Add($"this.ShopperEmail = {(this.ShopperEmail == null ? "null" : this.ShopperEmail)}");
            toStringOutput.Add($"this.ShopperName = {(this.ShopperName == null ? "null" : this.ShopperName.ToString())}");
            toStringOutput.Add($"this.ShopperReference = {(this.ShopperReference == null ? "null" : this.ShopperReference)}");
            toStringOutput.Add($"this.ShopperStatement = {(this.ShopperStatement == null ? "null" : this.ShopperStatement)}");
            toStringOutput.Add($"this.SocialSecurityNumber = {(this.SocialSecurityNumber == null ? "null" : this.SocialSecurityNumber)}");
        }
    }
}