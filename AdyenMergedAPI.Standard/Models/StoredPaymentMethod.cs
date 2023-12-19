// <copyright file="StoredPaymentMethod.cs" company="APIMatic">
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
    /// StoredPaymentMethod.
    /// </summary>
    public class StoredPaymentMethod
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredPaymentMethod"/> class.
        /// </summary>
        public StoredPaymentMethod()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoredPaymentMethod"/> class.
        /// </summary>
        /// <param name="bankAccountNumber">bankAccountNumber.</param>
        /// <param name="bankLocationId">bankLocationId.</param>
        /// <param name="brand">brand.</param>
        /// <param name="expiryMonth">expiryMonth.</param>
        /// <param name="expiryYear">expiryYear.</param>
        /// <param name="holderName">holderName.</param>
        /// <param name="iban">iban.</param>
        /// <param name="id">id.</param>
        /// <param name="label">label.</param>
        /// <param name="lastFour">lastFour.</param>
        /// <param name="name">name.</param>
        /// <param name="networkTxReference">networkTxReference.</param>
        /// <param name="ownerName">ownerName.</param>
        /// <param name="shopperEmail">shopperEmail.</param>
        /// <param name="supportedRecurringProcessingModels">supportedRecurringProcessingModels.</param>
        /// <param name="supportedShopperInteractions">supportedShopperInteractions.</param>
        /// <param name="type">type.</param>
        public StoredPaymentMethod(
            string bankAccountNumber = null,
            string bankLocationId = null,
            string brand = null,
            string expiryMonth = null,
            string expiryYear = null,
            string holderName = null,
            string iban = null,
            string id = null,
            string label = null,
            string lastFour = null,
            string name = null,
            string networkTxReference = null,
            string ownerName = null,
            string shopperEmail = null,
            List<string> supportedRecurringProcessingModels = null,
            List<string> supportedShopperInteractions = null,
            string type = null)
        {
            this.BankAccountNumber = bankAccountNumber;
            this.BankLocationId = bankLocationId;
            this.Brand = brand;
            this.ExpiryMonth = expiryMonth;
            this.ExpiryYear = expiryYear;
            this.HolderName = holderName;
            this.Iban = iban;
            this.Id = id;
            this.Label = label;
            this.LastFour = lastFour;
            this.Name = name;
            this.NetworkTxReference = networkTxReference;
            this.OwnerName = ownerName;
            this.ShopperEmail = shopperEmail;
            this.SupportedRecurringProcessingModels = supportedRecurringProcessingModels;
            this.SupportedShopperInteractions = supportedShopperInteractions;
            this.Type = type;
        }

        /// <summary>
        /// The bank account number (without separators).
        /// </summary>
        [JsonProperty("bankAccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// The location id of the bank. The field value is `nil` in most cases.
        /// </summary>
        [JsonProperty("bankLocationId", NullValueHandling = NullValueHandling.Ignore)]
        public string BankLocationId { get; set; }

        /// <summary>
        /// The brand of the card.
        /// </summary>
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public string Brand { get; set; }

        /// <summary>
        /// The month the card expires.
        /// </summary>
        [JsonProperty("expiryMonth", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryMonth { get; set; }

        /// <summary>
        /// The last two digits of the year the card expires. For example, **22** for the year 2022.
        /// </summary>
        [JsonProperty("expiryYear", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryYear { get; set; }

        /// <summary>
        /// The unique payment method code.
        /// </summary>
        [JsonProperty("holderName", NullValueHandling = NullValueHandling.Ignore)]
        public string HolderName { get; set; }

        /// <summary>
        /// The IBAN of the bank account.
        /// </summary>
        [JsonProperty("iban", NullValueHandling = NullValueHandling.Ignore)]
        public string Iban { get; set; }

        /// <summary>
        /// A unique identifier of this stored payment method.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The shopper’s issuer account label
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// The last four digits of the PAN.
        /// </summary>
        [JsonProperty("lastFour", NullValueHandling = NullValueHandling.Ignore)]
        public string LastFour { get; set; }

        /// <summary>
        /// The display name of the stored payment method.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Returned in the response if you are not tokenizing with Adyen and are using the Merchant-initiated transactions (MIT) framework from Mastercard or Visa.
        /// This contains either the Mastercard Trace ID or the Visa Transaction ID.
        /// </summary>
        [JsonProperty("networkTxReference", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkTxReference { get; set; }

        /// <summary>
        /// The name of the bank account holder.
        /// </summary>
        [JsonProperty("ownerName", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        /// <summary>
        /// The shopper’s email address.
        /// </summary>
        [JsonProperty("shopperEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// The supported recurring processing models for this stored payment method.
        /// </summary>
        [JsonProperty("supportedRecurringProcessingModels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportedRecurringProcessingModels { get; set; }

        /// <summary>
        /// The supported shopper interactions for this stored payment method.
        /// </summary>
        [JsonProperty("supportedShopperInteractions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportedShopperInteractions { get; set; }

        /// <summary>
        /// The type of payment method.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StoredPaymentMethod : ({string.Join(", ", toStringOutput)})";
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
            return obj is StoredPaymentMethod other &&                ((this.BankAccountNumber == null && other.BankAccountNumber == null) || (this.BankAccountNumber?.Equals(other.BankAccountNumber) == true)) &&
                ((this.BankLocationId == null && other.BankLocationId == null) || (this.BankLocationId?.Equals(other.BankLocationId) == true)) &&
                ((this.Brand == null && other.Brand == null) || (this.Brand?.Equals(other.Brand) == true)) &&
                ((this.ExpiryMonth == null && other.ExpiryMonth == null) || (this.ExpiryMonth?.Equals(other.ExpiryMonth) == true)) &&
                ((this.ExpiryYear == null && other.ExpiryYear == null) || (this.ExpiryYear?.Equals(other.ExpiryYear) == true)) &&
                ((this.HolderName == null && other.HolderName == null) || (this.HolderName?.Equals(other.HolderName) == true)) &&
                ((this.Iban == null && other.Iban == null) || (this.Iban?.Equals(other.Iban) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Label == null && other.Label == null) || (this.Label?.Equals(other.Label) == true)) &&
                ((this.LastFour == null && other.LastFour == null) || (this.LastFour?.Equals(other.LastFour) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.NetworkTxReference == null && other.NetworkTxReference == null) || (this.NetworkTxReference?.Equals(other.NetworkTxReference) == true)) &&
                ((this.OwnerName == null && other.OwnerName == null) || (this.OwnerName?.Equals(other.OwnerName) == true)) &&
                ((this.ShopperEmail == null && other.ShopperEmail == null) || (this.ShopperEmail?.Equals(other.ShopperEmail) == true)) &&
                ((this.SupportedRecurringProcessingModels == null && other.SupportedRecurringProcessingModels == null) || (this.SupportedRecurringProcessingModels?.Equals(other.SupportedRecurringProcessingModels) == true)) &&
                ((this.SupportedShopperInteractions == null && other.SupportedShopperInteractions == null) || (this.SupportedShopperInteractions?.Equals(other.SupportedShopperInteractions) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BankAccountNumber = {(this.BankAccountNumber == null ? "null" : this.BankAccountNumber)}");
            toStringOutput.Add($"this.BankLocationId = {(this.BankLocationId == null ? "null" : this.BankLocationId)}");
            toStringOutput.Add($"this.Brand = {(this.Brand == null ? "null" : this.Brand)}");
            toStringOutput.Add($"this.ExpiryMonth = {(this.ExpiryMonth == null ? "null" : this.ExpiryMonth)}");
            toStringOutput.Add($"this.ExpiryYear = {(this.ExpiryYear == null ? "null" : this.ExpiryYear)}");
            toStringOutput.Add($"this.HolderName = {(this.HolderName == null ? "null" : this.HolderName)}");
            toStringOutput.Add($"this.Iban = {(this.Iban == null ? "null" : this.Iban)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Label = {(this.Label == null ? "null" : this.Label)}");
            toStringOutput.Add($"this.LastFour = {(this.LastFour == null ? "null" : this.LastFour)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.NetworkTxReference = {(this.NetworkTxReference == null ? "null" : this.NetworkTxReference)}");
            toStringOutput.Add($"this.OwnerName = {(this.OwnerName == null ? "null" : this.OwnerName)}");
            toStringOutput.Add($"this.ShopperEmail = {(this.ShopperEmail == null ? "null" : this.ShopperEmail)}");
            toStringOutput.Add($"this.SupportedRecurringProcessingModels = {(this.SupportedRecurringProcessingModels == null ? "null" : $"[{string.Join(", ", this.SupportedRecurringProcessingModels)} ]")}");
            toStringOutput.Add($"this.SupportedShopperInteractions = {(this.SupportedShopperInteractions == null ? "null" : $"[{string.Join(", ", this.SupportedShopperInteractions)} ]")}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}