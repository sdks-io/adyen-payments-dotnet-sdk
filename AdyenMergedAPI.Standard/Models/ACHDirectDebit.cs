// <copyright file="ACHDirectDebit.cs" company="APIMatic">
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
    /// ACHDirectDebit.
    /// </summary>
    public class ACHDirectDebit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ACHDirectDebit"/> class.
        /// </summary>
        public ACHDirectDebit()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ACHDirectDebit"/> class.
        /// </summary>
        /// <param name="bankAccountNumber">bankAccountNumber.</param>
        /// <param name="bankAccountType">bankAccountType.</param>
        /// <param name="bankLocationId">bankLocationId.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="encryptedBankAccountNumber">encryptedBankAccountNumber.</param>
        /// <param name="encryptedBankLocationId">encryptedBankLocationId.</param>
        /// <param name="ownerName">ownerName.</param>
        /// <param name="recurringDetailReference">recurringDetailReference.</param>
        /// <param name="storedPaymentMethodId">storedPaymentMethodId.</param>
        /// <param name="type">type.</param>
        public ACHDirectDebit(
            string bankAccountNumber,
            Models.BankAccountTypeEnum? bankAccountType = null,
            string bankLocationId = null,
            string checkoutAttemptId = null,
            string encryptedBankAccountNumber = null,
            string encryptedBankLocationId = null,
            string ownerName = null,
            string recurringDetailReference = null,
            string storedPaymentMethodId = null,
            Models.TypeEnum? type = Models.TypeEnum.Ach)
        {
            this.BankAccountNumber = bankAccountNumber;
            this.BankAccountType = bankAccountType;
            this.BankLocationId = bankLocationId;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.EncryptedBankAccountNumber = encryptedBankAccountNumber;
            this.EncryptedBankLocationId = encryptedBankLocationId;
            this.OwnerName = ownerName;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.Type = type;
        }

        /// <summary>
        /// The bank account number (without separators).
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("bankAccountNumber")]
        [JsonRequired]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// The bank account type (checking, savings...).
        /// </summary>
        [JsonProperty("bankAccountType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountTypeEnum? BankAccountType { get; set; }

        /// <summary>
        /// The bank routing number of the account. The field value is `nil` in most cases.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("bankLocationId", NullValueHandling = NullValueHandling.Ignore)]
        public string BankLocationId { get; set; }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("checkoutAttemptId", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// Encrypted bank account number. The bank account number (without separators).
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("encryptedBankAccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptedBankAccountNumber { get; set; }

        /// <summary>
        /// Encrypted location id. The bank routing number of the account. The field value is `nil` in most cases.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("encryptedBankLocationId", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptedBankLocationId { get; set; }

        /// <summary>
        /// The name of the bank account holder.
        /// If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example:
        /// * χ12 is converted to ch12.
        /// * üA is converted to euA.
        /// * Peter Møller is converted to Peter Mller, because banks don't accept 'ø'.
        /// After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example:
        /// * John17 - allowed.
        /// * J17 - allowed.
        /// * 171 - not allowed.
        /// * John-7 - allowed.
        /// > If provided details don't match the required format, the response returns the error message: 203 'Invalid bank account holder name'.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("ownerName", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        /// <summary>
        /// This is the `recurringDetailReference` returned in the response when you created the token.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("recurringDetailReference", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// This is the `recurringDetailReference` returned in the response when you created the token.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("storedPaymentMethodId", NullValueHandling = NullValueHandling.Ignore)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// **ach**
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TypeEnum? Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ACHDirectDebit : ({string.Join(", ", toStringOutput)})";
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
            return obj is ACHDirectDebit other &&                ((this.BankAccountNumber == null && other.BankAccountNumber == null) || (this.BankAccountNumber?.Equals(other.BankAccountNumber) == true)) &&
                ((this.BankAccountType == null && other.BankAccountType == null) || (this.BankAccountType?.Equals(other.BankAccountType) == true)) &&
                ((this.BankLocationId == null && other.BankLocationId == null) || (this.BankLocationId?.Equals(other.BankLocationId) == true)) &&
                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.EncryptedBankAccountNumber == null && other.EncryptedBankAccountNumber == null) || (this.EncryptedBankAccountNumber?.Equals(other.EncryptedBankAccountNumber) == true)) &&
                ((this.EncryptedBankLocationId == null && other.EncryptedBankLocationId == null) || (this.EncryptedBankLocationId?.Equals(other.EncryptedBankLocationId) == true)) &&
                ((this.OwnerName == null && other.OwnerName == null) || (this.OwnerName?.Equals(other.OwnerName) == true)) &&
                ((this.RecurringDetailReference == null && other.RecurringDetailReference == null) || (this.RecurringDetailReference?.Equals(other.RecurringDetailReference) == true)) &&
                ((this.StoredPaymentMethodId == null && other.StoredPaymentMethodId == null) || (this.StoredPaymentMethodId?.Equals(other.StoredPaymentMethodId) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BankAccountNumber = {(this.BankAccountNumber == null ? "null" : this.BankAccountNumber)}");
            toStringOutput.Add($"this.BankAccountType = {(this.BankAccountType == null ? "null" : this.BankAccountType.ToString())}");
            toStringOutput.Add($"this.BankLocationId = {(this.BankLocationId == null ? "null" : this.BankLocationId)}");
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.EncryptedBankAccountNumber = {(this.EncryptedBankAccountNumber == null ? "null" : this.EncryptedBankAccountNumber)}");
            toStringOutput.Add($"this.EncryptedBankLocationId = {(this.EncryptedBankLocationId == null ? "null" : this.EncryptedBankLocationId)}");
            toStringOutput.Add($"this.OwnerName = {(this.OwnerName == null ? "null" : this.OwnerName)}");
            toStringOutput.Add($"this.RecurringDetailReference = {(this.RecurringDetailReference == null ? "null" : this.RecurringDetailReference)}");
            toStringOutput.Add($"this.StoredPaymentMethodId = {(this.StoredPaymentMethodId == null ? "null" : this.StoredPaymentMethodId)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
        }
    }
}