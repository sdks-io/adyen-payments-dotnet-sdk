// <copyright file="ResponseAdditionalDataCard.cs" company="APIMatic">
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
    /// ResponseAdditionalDataCard.
    /// </summary>
    public class ResponseAdditionalDataCard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataCard"/> class.
        /// </summary>
        public ResponseAdditionalDataCard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataCard"/> class.
        /// </summary>
        /// <param name="cardBin">cardBin.</param>
        /// <param name="cardHolderName">cardHolderName.</param>
        /// <param name="cardIssuingBank">cardIssuingBank.</param>
        /// <param name="cardIssuingCountry">cardIssuingCountry.</param>
        /// <param name="cardIssuingCurrency">cardIssuingCurrency.</param>
        /// <param name="cardPaymentMethod">cardPaymentMethod.</param>
        /// <param name="cardSummary">cardSummary.</param>
        /// <param name="issuerBin">issuerBin.</param>
        public ResponseAdditionalDataCard(
            string cardBin = null,
            string cardHolderName = null,
            string cardIssuingBank = null,
            string cardIssuingCountry = null,
            string cardIssuingCurrency = null,
            string cardPaymentMethod = null,
            string cardSummary = null,
            string issuerBin = null)
        {
            this.CardBin = cardBin;
            this.CardHolderName = cardHolderName;
            this.CardIssuingBank = cardIssuingBank;
            this.CardIssuingCountry = cardIssuingCountry;
            this.CardIssuingCurrency = cardIssuingCurrency;
            this.CardPaymentMethod = cardPaymentMethod;
            this.CardSummary = cardSummary;
            this.IssuerBin = issuerBin;
        }

        /// <summary>
        /// The first six digits of the card number.
        /// This is the [Bank Identification Number (BIN)](https://docs.adyen.com/get-started-with-adyen/payment-glossary#bank-identification-number-bin) for card numbers with a six-digit BIN.
        /// Example: 521234
        /// </summary>
        [JsonProperty("cardBin", NullValueHandling = NullValueHandling.Ignore)]
        public string CardBin { get; set; }

        /// <summary>
        /// The cardholder name passed in the payment request.
        /// </summary>
        [JsonProperty("cardHolderName", NullValueHandling = NullValueHandling.Ignore)]
        public string CardHolderName { get; set; }

        /// <summary>
        /// The bank or the financial institution granting lines of credit through card association branded payment cards. This information can be included when available.
        /// </summary>
        [JsonProperty("cardIssuingBank", NullValueHandling = NullValueHandling.Ignore)]
        public string CardIssuingBank { get; set; }

        /// <summary>
        /// The country where the card was issued.
        /// Example: US
        /// </summary>
        [JsonProperty("cardIssuingCountry", NullValueHandling = NullValueHandling.Ignore)]
        public string CardIssuingCountry { get; set; }

        /// <summary>
        /// The currency in which the card is issued, if this information is available. Provided as the currency code or currency number from the ISO-4217 standard.
        /// Example: USD
        /// </summary>
        [JsonProperty("cardIssuingCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public string CardIssuingCurrency { get; set; }

        /// <summary>
        /// The card payment method used for the transaction.
        /// Example: amex
        /// </summary>
        [JsonProperty("cardPaymentMethod", NullValueHandling = NullValueHandling.Ignore)]
        public string CardPaymentMethod { get; set; }

        /// <summary>
        /// The last four digits of a card number.
        /// > Returned only in case of a card payment.
        /// </summary>
        [JsonProperty("cardSummary", NullValueHandling = NullValueHandling.Ignore)]
        public string CardSummary { get; set; }

        /// <summary>
        /// The first eight digits of the card number. Only returned if the card number is 16 digits or more.
        /// This is the [Bank Identification Number (BIN)](https://docs.adyen.com/get-started-with-adyen/payment-glossary#bank-identification-number-bin) for card numbers with an eight-digit BIN.
        /// Example: 52123423
        /// </summary>
        [JsonProperty("issuerBin", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerBin { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseAdditionalDataCard : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResponseAdditionalDataCard other &&                ((this.CardBin == null && other.CardBin == null) || (this.CardBin?.Equals(other.CardBin) == true)) &&
                ((this.CardHolderName == null && other.CardHolderName == null) || (this.CardHolderName?.Equals(other.CardHolderName) == true)) &&
                ((this.CardIssuingBank == null && other.CardIssuingBank == null) || (this.CardIssuingBank?.Equals(other.CardIssuingBank) == true)) &&
                ((this.CardIssuingCountry == null && other.CardIssuingCountry == null) || (this.CardIssuingCountry?.Equals(other.CardIssuingCountry) == true)) &&
                ((this.CardIssuingCurrency == null && other.CardIssuingCurrency == null) || (this.CardIssuingCurrency?.Equals(other.CardIssuingCurrency) == true)) &&
                ((this.CardPaymentMethod == null && other.CardPaymentMethod == null) || (this.CardPaymentMethod?.Equals(other.CardPaymentMethod) == true)) &&
                ((this.CardSummary == null && other.CardSummary == null) || (this.CardSummary?.Equals(other.CardSummary) == true)) &&
                ((this.IssuerBin == null && other.IssuerBin == null) || (this.IssuerBin?.Equals(other.IssuerBin) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardBin = {(this.CardBin == null ? "null" : this.CardBin)}");
            toStringOutput.Add($"this.CardHolderName = {(this.CardHolderName == null ? "null" : this.CardHolderName)}");
            toStringOutput.Add($"this.CardIssuingBank = {(this.CardIssuingBank == null ? "null" : this.CardIssuingBank)}");
            toStringOutput.Add($"this.CardIssuingCountry = {(this.CardIssuingCountry == null ? "null" : this.CardIssuingCountry)}");
            toStringOutput.Add($"this.CardIssuingCurrency = {(this.CardIssuingCurrency == null ? "null" : this.CardIssuingCurrency)}");
            toStringOutput.Add($"this.CardPaymentMethod = {(this.CardPaymentMethod == null ? "null" : this.CardPaymentMethod)}");
            toStringOutput.Add($"this.CardSummary = {(this.CardSummary == null ? "null" : this.CardSummary)}");
            toStringOutput.Add($"this.IssuerBin = {(this.IssuerBin == null ? "null" : this.IssuerBin)}");
        }
    }
}