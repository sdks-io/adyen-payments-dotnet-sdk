// <copyright file="BankAccount.cs" company="APIMatic">
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
    /// BankAccount.
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount"/> class.
        /// </summary>
        public BankAccount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount"/> class.
        /// </summary>
        /// <param name="bankAccountNumber">bankAccountNumber.</param>
        /// <param name="bankCity">bankCity.</param>
        /// <param name="bankLocationId">bankLocationId.</param>
        /// <param name="bankName">bankName.</param>
        /// <param name="bic">bic.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="iban">iban.</param>
        /// <param name="ownerName">ownerName.</param>
        /// <param name="taxId">taxId.</param>
        public BankAccount(
            string bankAccountNumber = null,
            string bankCity = null,
            string bankLocationId = null,
            string bankName = null,
            string bic = null,
            string countryCode = null,
            string iban = null,
            string ownerName = null,
            string taxId = null)
        {
            this.BankAccountNumber = bankAccountNumber;
            this.BankCity = bankCity;
            this.BankLocationId = bankLocationId;
            this.BankName = bankName;
            this.Bic = bic;
            this.CountryCode = countryCode;
            this.Iban = iban;
            this.OwnerName = ownerName;
            this.TaxId = taxId;
        }

        /// <summary>
        /// The bank account number (without separators).
        /// </summary>
        [JsonProperty("bankAccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// The bank city.
        /// </summary>
        [JsonProperty("bankCity", NullValueHandling = NullValueHandling.Ignore)]
        public string BankCity { get; set; }

        /// <summary>
        /// The location id of the bank. The field value is `nil` in most cases.
        /// </summary>
        [JsonProperty("bankLocationId", NullValueHandling = NullValueHandling.Ignore)]
        public string BankLocationId { get; set; }

        /// <summary>
        /// The name of the bank.
        /// </summary>
        [JsonProperty("bankName", NullValueHandling = NullValueHandling.Ignore)]
        public string BankName { get; set; }

        /// <summary>
        /// The [Business Identifier Code](https://en.wikipedia.org/wiki/ISO_9362) (BIC) is the SWIFT address assigned to a bank. The field value is `nil` in most cases.
        /// </summary>
        [JsonProperty("bic", NullValueHandling = NullValueHandling.Ignore)]
        public string Bic { get; set; }

        /// <summary>
        /// Country code where the bank is located.
        /// A valid value is an ISO two-character country code (e.g. 'NL').
        /// </summary>
        [JsonProperty("countryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The [International Bank Account Number](https://en.wikipedia.org/wiki/International_Bank_Account_Number) (IBAN).
        /// </summary>
        [JsonProperty("iban", NullValueHandling = NullValueHandling.Ignore)]
        public string Iban { get; set; }

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
        [JsonProperty("ownerName", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        /// <summary>
        /// The bank account holder's tax ID.
        /// </summary>
        [JsonProperty("taxId", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BankAccount : ({string.Join(", ", toStringOutput)})";
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
            return obj is BankAccount other &&                ((this.BankAccountNumber == null && other.BankAccountNumber == null) || (this.BankAccountNumber?.Equals(other.BankAccountNumber) == true)) &&
                ((this.BankCity == null && other.BankCity == null) || (this.BankCity?.Equals(other.BankCity) == true)) &&
                ((this.BankLocationId == null && other.BankLocationId == null) || (this.BankLocationId?.Equals(other.BankLocationId) == true)) &&
                ((this.BankName == null && other.BankName == null) || (this.BankName?.Equals(other.BankName) == true)) &&
                ((this.Bic == null && other.Bic == null) || (this.Bic?.Equals(other.Bic) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.Iban == null && other.Iban == null) || (this.Iban?.Equals(other.Iban) == true)) &&
                ((this.OwnerName == null && other.OwnerName == null) || (this.OwnerName?.Equals(other.OwnerName) == true)) &&
                ((this.TaxId == null && other.TaxId == null) || (this.TaxId?.Equals(other.TaxId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BankAccountNumber = {(this.BankAccountNumber == null ? "null" : this.BankAccountNumber)}");
            toStringOutput.Add($"this.BankCity = {(this.BankCity == null ? "null" : this.BankCity)}");
            toStringOutput.Add($"this.BankLocationId = {(this.BankLocationId == null ? "null" : this.BankLocationId)}");
            toStringOutput.Add($"this.BankName = {(this.BankName == null ? "null" : this.BankName)}");
            toStringOutput.Add($"this.Bic = {(this.Bic == null ? "null" : this.Bic)}");
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
            toStringOutput.Add($"this.Iban = {(this.Iban == null ? "null" : this.Iban)}");
            toStringOutput.Add($"this.OwnerName = {(this.OwnerName == null ? "null" : this.OwnerName)}");
            toStringOutput.Add($"this.TaxId = {(this.TaxId == null ? "null" : this.TaxId)}");
        }
    }
}