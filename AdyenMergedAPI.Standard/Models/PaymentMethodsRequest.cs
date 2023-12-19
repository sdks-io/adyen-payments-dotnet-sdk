// <copyright file="PaymentMethodsRequest.cs" company="APIMatic">
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
    /// PaymentMethodsRequest.
    /// </summary>
    public class PaymentMethodsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodsRequest"/> class.
        /// </summary>
        public PaymentMethodsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodsRequest"/> class.
        /// </summary>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="allowedPaymentMethods">allowedPaymentMethods.</param>
        /// <param name="amount">amount.</param>
        /// <param name="blockedPaymentMethods">blockedPaymentMethods.</param>
        /// <param name="channel">channel.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="order">order.</param>
        /// <param name="shopperLocale">shopperLocale.</param>
        /// <param name="shopperReference">shopperReference.</param>
        /// <param name="splitCardFundingSources">splitCardFundingSources.</param>
        /// <param name="store">store.</param>
        public PaymentMethodsRequest(
            string merchantAccount,
            Dictionary<string, string> additionalData = null,
            List<string> allowedPaymentMethods = null,
            Models.Amount2 amount = null,
            List<string> blockedPaymentMethods = null,
            Models.Channel3Enum? channel = null,
            string countryCode = null,
            Models.EncryptedOrderData2 order = null,
            string shopperLocale = null,
            string shopperReference = null,
            bool? splitCardFundingSources = false,
            string store = null)
        {
            this.AdditionalData = additionalData;
            this.AllowedPaymentMethods = allowedPaymentMethods;
            this.Amount = amount;
            this.BlockedPaymentMethods = blockedPaymentMethods;
            this.Channel = channel;
            this.CountryCode = countryCode;
            this.MerchantAccount = merchantAccount;
            this.Order = order;
            this.ShopperLocale = shopperLocale;
            this.ShopperReference = shopperReference;
            this.SplitCardFundingSources = splitCardFundingSources;
            this.Store = store;
        }

        /// <summary>
        /// This field contains additional data, which may be required for a particular payment request.
        /// The `additionalData` object consists of entries, each of which includes the key and value.
        /// </summary>
        [JsonProperty("additionalData", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// List of payment methods to be presented to the shopper. To refer to payment methods, use their [payment method type](https://docs.adyen.com/payment-methods/payment-method-types).
        /// Example: `"allowedPaymentMethods":["ideal","giropay"]`
        /// </summary>
        [JsonProperty("allowedPaymentMethods", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowedPaymentMethods { get; set; }

        /// <summary>
        /// The amount information for the transaction (in [minor units](https://docs.adyen.com/development-resources/currency-codes)). For [BIN or card verification](https://docs.adyen.com/payment-methods/cards/bin-data-and-card-verification) requests, set amount to 0 (zero).
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount2 Amount { get; set; }

        /// <summary>
        /// List of payment methods to be hidden from the shopper. To refer to payment methods, use their [payment method type](https://docs.adyen.com/payment-methods/payment-method-types).
        /// Example: `"blockedPaymentMethods":["ideal","giropay"]`
        /// </summary>
        [JsonProperty("blockedPaymentMethods", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BlockedPaymentMethods { get; set; }

        /// <summary>
        /// The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values:
        /// * iOS
        /// * Android
        /// * Web
        /// </summary>
        [JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Channel3Enum? Channel { get; set; }

        /// <summary>
        /// The shopper's country code.
        /// </summary>
        [JsonProperty("countryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        [JsonProperty("merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The order information required for partial payments.
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EncryptedOrderData2 Order { get; set; }

        /// <summary>
        /// The combination of a language code and a country code to specify the language to be used in the payment.
        /// </summary>
        [JsonProperty("shopperLocale", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperLocale { get; set; }

        /// <summary>
        /// Required for recurring payments.
        /// Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.
        /// > Your reference must not include personally identifiable information (PII), for example name or email address.
        /// </summary>
        [JsonProperty("shopperReference", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// Boolean value indicating whether the card payment method should be split into separate debit and credit options.
        /// </summary>
        [JsonProperty("splitCardFundingSources", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SplitCardFundingSources { get; set; }

        /// <summary>
        /// The ecommerce or point-of-sale store that is processing the payment. Used in:
        /// * [Partner platform integrations](https://docs.adyen.com/marketplaces-and-platforms/classic/platforms-for-partners#route-payments) for the [Classic Platforms integration](https://docs.adyen.com/marketplaces-and-platforms/classic).
        /// * [Platform setup integrations](https://docs.adyen.com/marketplaces-and-platforms/additional-for-platform-setup/route-payment-to-store) for the [Balance Platform](https://docs.adyen.com/marketplaces-and-platforms).
        /// </summary>
        [JsonProperty("store", NullValueHandling = NullValueHandling.Ignore)]
        public string Store { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentMethodsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentMethodsRequest other &&                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.AllowedPaymentMethods == null && other.AllowedPaymentMethods == null) || (this.AllowedPaymentMethods?.Equals(other.AllowedPaymentMethods) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.BlockedPaymentMethods == null && other.BlockedPaymentMethods == null) || (this.BlockedPaymentMethods?.Equals(other.BlockedPaymentMethods) == true)) &&
                ((this.Channel == null && other.Channel == null) || (this.Channel?.Equals(other.Channel) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.Order == null && other.Order == null) || (this.Order?.Equals(other.Order) == true)) &&
                ((this.ShopperLocale == null && other.ShopperLocale == null) || (this.ShopperLocale?.Equals(other.ShopperLocale) == true)) &&
                ((this.ShopperReference == null && other.ShopperReference == null) || (this.ShopperReference?.Equals(other.ShopperReference) == true)) &&
                ((this.SplitCardFundingSources == null && other.SplitCardFundingSources == null) || (this.SplitCardFundingSources?.Equals(other.SplitCardFundingSources) == true)) &&
                ((this.Store == null && other.Store == null) || (this.Store?.Equals(other.Store) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.AllowedPaymentMethods = {(this.AllowedPaymentMethods == null ? "null" : $"[{string.Join(", ", this.AllowedPaymentMethods)} ]")}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.BlockedPaymentMethods = {(this.BlockedPaymentMethods == null ? "null" : $"[{string.Join(", ", this.BlockedPaymentMethods)} ]")}");
            toStringOutput.Add($"this.Channel = {(this.Channel == null ? "null" : this.Channel.ToString())}");
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.Order = {(this.Order == null ? "null" : this.Order.ToString())}");
            toStringOutput.Add($"this.ShopperLocale = {(this.ShopperLocale == null ? "null" : this.ShopperLocale)}");
            toStringOutput.Add($"this.ShopperReference = {(this.ShopperReference == null ? "null" : this.ShopperReference)}");
            toStringOutput.Add($"this.SplitCardFundingSources = {(this.SplitCardFundingSources == null ? "null" : this.SplitCardFundingSources.ToString())}");
            toStringOutput.Add($"this.Store = {(this.Store == null ? "null" : this.Store)}");
        }
    }
}