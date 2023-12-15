// <copyright file="Card3.cs" company="APIMatic">
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
    /// Card3.
    /// </summary>
    public class Card3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Card3"/> class.
        /// </summary>
        public Card3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card3"/> class.
        /// </summary>
        /// <param name="cvc">cvc.</param>
        /// <param name="expiryMonth">expiryMonth.</param>
        /// <param name="expiryYear">expiryYear.</param>
        /// <param name="holderName">holderName.</param>
        /// <param name="issueNumber">issueNumber.</param>
        /// <param name="number">number.</param>
        /// <param name="startMonth">startMonth.</param>
        /// <param name="startYear">startYear.</param>
        public Card3(
            string cvc = null,
            string expiryMonth = null,
            string expiryYear = null,
            string holderName = null,
            string issueNumber = null,
            string number = null,
            string startMonth = null,
            string startYear = null)
        {
            this.Cvc = cvc;
            this.ExpiryMonth = expiryMonth;
            this.ExpiryYear = expiryYear;
            this.HolderName = holderName;
            this.IssueNumber = issueNumber;
            this.Number = number;
            this.StartMonth = startMonth;
            this.StartYear = startYear;
        }

        /// <summary>
        /// The [card verification code](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid) (1-20 characters). Depending on the card brand, it is known also as:
        /// * CVV2/CVC2 – length: 3 digits
        /// * CID – length: 4 digits
        /// > If you are using [Client-Side Encryption](https://docs.adyen.com/classic-integration/cse-integration-ecommerce), the CVC code is present in the encrypted data. You must never post the card details to the server.
        /// > This field must be always present in a [one-click payment request](https://docs.adyen.com/classic-integration/recurring-payments).
        /// > When this value is returned in a response, it is always empty because it is not stored.
        /// </summary>
        [JsonProperty("cvc", NullValueHandling = NullValueHandling.Ignore)]
        public string Cvc { get; set; }

        /// <summary>
        /// The card expiry month.
        /// Format: 2 digits, zero-padded for single digits. For example:
        /// * 03 = March
        /// * 11 = November
        /// </summary>
        [JsonProperty("expiryMonth", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryMonth { get; set; }

        /// <summary>
        /// The card expiry year.
        /// Format: 4 digits. For example: 2020
        /// </summary>
        [JsonProperty("expiryYear", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryYear { get; set; }

        /// <summary>
        /// The name of the cardholder, as printed on the card.
        /// </summary>
        [JsonProperty("holderName", NullValueHandling = NullValueHandling.Ignore)]
        public string HolderName { get; set; }

        /// <summary>
        /// The issue number of the card (for some UK debit cards only).
        /// </summary>
        [JsonProperty("issueNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueNumber { get; set; }

        /// <summary>
        /// The card number (4-19 characters). Do not use any separators.
        /// When this value is returned in a response, only the last 4 digits of the card number are returned.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// The month component of the start date (for some UK debit cards only).
        /// </summary>
        [JsonProperty("startMonth", NullValueHandling = NullValueHandling.Ignore)]
        public string StartMonth { get; set; }

        /// <summary>
        /// The year component of the start date (for some UK debit cards only).
        /// </summary>
        [JsonProperty("startYear", NullValueHandling = NullValueHandling.Ignore)]
        public string StartYear { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Card3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Card3 other &&                ((this.Cvc == null && other.Cvc == null) || (this.Cvc?.Equals(other.Cvc) == true)) &&
                ((this.ExpiryMonth == null && other.ExpiryMonth == null) || (this.ExpiryMonth?.Equals(other.ExpiryMonth) == true)) &&
                ((this.ExpiryYear == null && other.ExpiryYear == null) || (this.ExpiryYear?.Equals(other.ExpiryYear) == true)) &&
                ((this.HolderName == null && other.HolderName == null) || (this.HolderName?.Equals(other.HolderName) == true)) &&
                ((this.IssueNumber == null && other.IssueNumber == null) || (this.IssueNumber?.Equals(other.IssueNumber) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.StartMonth == null && other.StartMonth == null) || (this.StartMonth?.Equals(other.StartMonth) == true)) &&
                ((this.StartYear == null && other.StartYear == null) || (this.StartYear?.Equals(other.StartYear) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Cvc = {(this.Cvc == null ? "null" : this.Cvc)}");
            toStringOutput.Add($"this.ExpiryMonth = {(this.ExpiryMonth == null ? "null" : this.ExpiryMonth)}");
            toStringOutput.Add($"this.ExpiryYear = {(this.ExpiryYear == null ? "null" : this.ExpiryYear)}");
            toStringOutput.Add($"this.HolderName = {(this.HolderName == null ? "null" : this.HolderName)}");
            toStringOutput.Add($"this.IssueNumber = {(this.IssueNumber == null ? "null" : this.IssueNumber)}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number)}");
            toStringOutput.Add($"this.StartMonth = {(this.StartMonth == null ? "null" : this.StartMonth)}");
            toStringOutput.Add($"this.StartYear = {(this.StartYear == null ? "null" : this.StartYear)}");
        }
    }
}