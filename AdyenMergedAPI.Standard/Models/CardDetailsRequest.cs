// <copyright file="CardDetailsRequest.cs" company="APIMatic">
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
    /// CardDetailsRequest.
    /// </summary>
    public class CardDetailsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetailsRequest"/> class.
        /// </summary>
        public CardDetailsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetailsRequest"/> class.
        /// </summary>
        /// <param name="cardNumber">cardNumber.</param>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="encryptedCardNumber">encryptedCardNumber.</param>
        /// <param name="supportedBrands">supportedBrands.</param>
        public CardDetailsRequest(
            string cardNumber,
            string merchantAccount,
            string countryCode = null,
            string encryptedCardNumber = null,
            List<string> supportedBrands = null)
        {
            this.CardNumber = cardNumber;
            this.CountryCode = countryCode;
            this.EncryptedCardNumber = encryptedCardNumber;
            this.MerchantAccount = merchantAccount;
            this.SupportedBrands = supportedBrands;
        }

        /// <summary>
        /// A minimum of the first 8 digits of the card number and a maximum of the full card number. 11 digits gives the best result.
        /// You must be [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide) to collect raw card data.
        /// </summary>
        [JsonProperty("cardNumber")]
        public string CardNumber { get; set; }

        /// <summary>
        /// The shopper country.
        /// Format: [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)
        /// Example: NL or DE
        /// </summary>
        [JsonProperty("countryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The encrypted card number.
        /// </summary>
        [JsonProperty("encryptedCardNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptedCardNumber { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        [JsonProperty("merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The card brands you support. This is the [`brands`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods__resParam_paymentMethods-brands) array from your [`/paymentMethods`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods) response.
        /// If not included, our API uses the ones configured for your merchant account and, if provided, the country code.
        /// </summary>
        [JsonProperty("supportedBrands", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportedBrands { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardDetailsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardDetailsRequest other &&                ((this.CardNumber == null && other.CardNumber == null) || (this.CardNumber?.Equals(other.CardNumber) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.EncryptedCardNumber == null && other.EncryptedCardNumber == null) || (this.EncryptedCardNumber?.Equals(other.EncryptedCardNumber) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.SupportedBrands == null && other.SupportedBrands == null) || (this.SupportedBrands?.Equals(other.SupportedBrands) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardNumber = {(this.CardNumber == null ? "null" : this.CardNumber)}");
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
            toStringOutput.Add($"this.EncryptedCardNumber = {(this.EncryptedCardNumber == null ? "null" : this.EncryptedCardNumber)}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.SupportedBrands = {(this.SupportedBrands == null ? "null" : $"[{string.Join(", ", this.SupportedBrands)} ]")}");
        }
    }
}