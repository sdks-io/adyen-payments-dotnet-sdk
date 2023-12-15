// <copyright file="PaymentRequest3ds2.cs" company="APIMatic">
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
    /// PaymentRequest3ds2.
    /// </summary>
    public class PaymentRequest3ds2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequest3ds2"/> class.
        /// </summary>
        public PaymentRequest3ds2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequest3ds2"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="reference">reference.</param>
        /// <param name="accountInfo">accountInfo.</param>
        /// <param name="additionalAmount">additionalAmount.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="applicationInfo">applicationInfo.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="browserInfo">browserInfo.</param>
        /// <param name="captureDelayHours">captureDelayHours.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="dccQuote">dccQuote.</param>
        /// <param name="deliveryAddress">deliveryAddress.</param>
        /// <param name="deliveryDate">deliveryDate.</param>
        /// <param name="deviceFingerprint">deviceFingerprint.</param>
        /// <param name="fraudOffset">fraudOffset.</param>
        /// <param name="installments">installments.</param>
        /// <param name="localizedShopperStatement">localizedShopperStatement.</param>
        /// <param name="mcc">mcc.</param>
        /// <param name="merchantOrderReference">merchantOrderReference.</param>
        /// <param name="merchantRiskIndicator">merchantRiskIndicator.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="orderReference">orderReference.</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="recurringProcessingModel">recurringProcessingModel.</param>
        /// <param name="selectedBrand">selectedBrand.</param>
        /// <param name="selectedRecurringDetailReference">selectedRecurringDetailReference.</param>
        /// <param name="sessionId">sessionId.</param>
        /// <param name="shopperEmail">shopperEmail.</param>
        /// <param name="shopperIP">shopperIP.</param>
        /// <param name="shopperInteraction">shopperInteraction.</param>
        /// <param name="shopperLocale">shopperLocale.</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="shopperReference">shopperReference.</param>
        /// <param name="shopperStatement">shopperStatement.</param>
        /// <param name="socialSecurityNumber">socialSecurityNumber.</param>
        /// <param name="splits">splits.</param>
        /// <param name="store">store.</param>
        /// <param name="telephoneNumber">telephoneNumber.</param>
        /// <param name="threeDS2RequestData">threeDS2RequestData.</param>
        /// <param name="threeDS2Result">threeDS2Result.</param>
        /// <param name="threeDS2Token">threeDS2Token.</param>
        /// <param name="threeDSAuthenticationOnly">threeDSAuthenticationOnly.</param>
        /// <param name="totalsGroup">totalsGroup.</param>
        /// <param name="trustedShopper">trustedShopper.</param>
        public PaymentRequest3ds2(
            Models.Amount amount,
            string merchantAccount,
            string reference,
            Models.AccountInfo1 accountInfo = null,
            Models.Amount9 additionalAmount = null,
            Dictionary<string, string> additionalData = null,
            Models.ApplicationInfo1 applicationInfo = null,
            Models.Address3 billingAddress = null,
            Models.BrowserInfo1 browserInfo = null,
            int? captureDelayHours = null,
            DateTime? dateOfBirth = null,
            Models.ForexQuote1 dccQuote = null,
            Models.Address4 deliveryAddress = null,
            DateTime? deliveryDate = null,
            string deviceFingerprint = null,
            int? fraudOffset = null,
            Models.Installments1 installments = null,
            Dictionary<string, string> localizedShopperStatement = null,
            string mcc = null,
            string merchantOrderReference = null,
            Models.MerchantRiskIndicator1 merchantRiskIndicator = null,
            Dictionary<string, string> metadata = null,
            string orderReference = null,
            Models.Recurring1 recurring = null,
            Models.RecurringProcessingModelEnum? recurringProcessingModel = null,
            string selectedBrand = null,
            string selectedRecurringDetailReference = null,
            string sessionId = null,
            string shopperEmail = null,
            string shopperIP = null,
            Models.ShopperInteractionEnum? shopperInteraction = null,
            string shopperLocale = null,
            Models.Name shopperName = null,
            string shopperReference = null,
            string shopperStatement = null,
            string socialSecurityNumber = null,
            List<Models.Split> splits = null,
            string store = null,
            string telephoneNumber = null,
            Models.ThreeDS2RequestData1 threeDS2RequestData = null,
            Models.ThreeDS2Result1 threeDS2Result = null,
            string threeDS2Token = null,
            bool? threeDSAuthenticationOnly = false,
            string totalsGroup = null,
            bool? trustedShopper = null)
        {
            this.AccountInfo = accountInfo;
            this.AdditionalAmount = additionalAmount;
            this.AdditionalData = additionalData;
            this.Amount = amount;
            this.ApplicationInfo = applicationInfo;
            this.BillingAddress = billingAddress;
            this.BrowserInfo = browserInfo;
            this.CaptureDelayHours = captureDelayHours;
            this.DateOfBirth = dateOfBirth;
            this.DccQuote = dccQuote;
            this.DeliveryAddress = deliveryAddress;
            this.DeliveryDate = deliveryDate;
            this.DeviceFingerprint = deviceFingerprint;
            this.FraudOffset = fraudOffset;
            this.Installments = installments;
            this.LocalizedShopperStatement = localizedShopperStatement;
            this.Mcc = mcc;
            this.MerchantAccount = merchantAccount;
            this.MerchantOrderReference = merchantOrderReference;
            this.MerchantRiskIndicator = merchantRiskIndicator;
            this.Metadata = metadata;
            this.OrderReference = orderReference;
            this.Recurring = recurring;
            this.RecurringProcessingModel = recurringProcessingModel;
            this.Reference = reference;
            this.SelectedBrand = selectedBrand;
            this.SelectedRecurringDetailReference = selectedRecurringDetailReference;
            this.SessionId = sessionId;
            this.ShopperEmail = shopperEmail;
            this.ShopperIP = shopperIP;
            this.ShopperInteraction = shopperInteraction;
            this.ShopperLocale = shopperLocale;
            this.ShopperName = shopperName;
            this.ShopperReference = shopperReference;
            this.ShopperStatement = shopperStatement;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.Splits = splits;
            this.Store = store;
            this.TelephoneNumber = telephoneNumber;
            this.ThreeDS2RequestData = threeDS2RequestData;
            this.ThreeDS2Result = threeDS2Result;
            this.ThreeDS2Token = threeDS2Token;
            this.ThreeDSAuthenticationOnly = threeDSAuthenticationOnly;
            this.TotalsGroup = totalsGroup;
            this.TrustedShopper = trustedShopper;
        }

        /// <summary>
        /// Shopper account information for 3D Secure 2.
        /// > For 3D Secure 2 transactions, we recommend that you include this object to increase the chances of achieving a frictionless flow.
        /// </summary>
        [JsonProperty("accountInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountInfo1 AccountInfo { get; set; }

        /// <summary>
        /// If you want a [BIN or card verification](https://docs.adyen.com/payment-methods/cards/bin-data-and-card-verification) request to use a non-zero value, assign this value to `additionalAmount` (while the amount must be still set to 0 to trigger BIN or card verification).
        /// Required to be in the same currency as the `amount`.
        /// </summary>
        [JsonProperty("additionalAmount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount9 AdditionalAmount { get; set; }

        /// <summary>
        /// This field contains additional data, which may be required for a particular payment request.
        /// The `additionalData` object consists of entries, each of which includes the key and value.
        /// </summary>
        [JsonProperty("additionalData", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// The amount information for the transaction (in [minor units](https://docs.adyen.com/development-resources/currency-codes)). For [BIN or card verification](https://docs.adyen.com/payment-methods/cards/bin-data-and-card-verification) requests, set amount to 0 (zero).
        /// </summary>
        [JsonProperty("amount")]
        public Models.Amount Amount { get; set; }

        /// <summary>
        /// Information about your application. For more details, see [Building Adyen solutions](https://docs.adyen.com/development-resources/building-adyen-solutions).
        /// </summary>
        [JsonProperty("applicationInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplicationInfo1 ApplicationInfo { get; set; }

        /// <summary>
        /// The address where to send the invoice.
        /// > The `billingAddress` object is required in the following scenarios. Include all of the fields within this object.
        /// >* For 3D Secure 2 transactions in all browser-based and mobile implementations.
        /// >* For cross-border payouts to and from Canada.
        /// </summary>
        [JsonProperty("billingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address3 BillingAddress { get; set; }

        /// <summary>
        /// The shopper's browser information.
        /// > For 3D Secure, the full object is required for web integrations. For mobile app integrations, include the `userAgent` and `acceptHeader` fields to indicate  that your integration can support a redirect in case a payment is routed to 3D Secure 1.
        /// </summary>
        [JsonProperty("browserInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BrowserInfo1 BrowserInfo { get; set; }

        /// <summary>
        /// The delay between the authorisation and scheduled auto-capture, specified in hours.
        /// </summary>
        [JsonProperty("captureDelayHours", NullValueHandling = NullValueHandling.Ignore)]
        public int? CaptureDelayHours { get; set; }

        /// <summary>
        /// The shopper's date of birth.
        /// Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("dateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// The forex quote as returned in the response of the forex service.
        /// </summary>
        [JsonProperty("dccQuote", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ForexQuote1 DccQuote { get; set; }

        /// <summary>
        /// The address where the purchased goods should be delivered.
        /// </summary>
        [JsonProperty("deliveryAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address4 DeliveryAddress { get; set; }

        /// <summary>
        /// The date and time the purchased goods should be delivered.
        /// Format [ISO 8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DDThh:mm:ss.sssTZD
        /// Example: 2017-07-17T13:42:40.428+01:00
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deliveryDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// A string containing the shopper's device fingerprint. For more information, refer to [Device fingerprinting](https://docs.adyen.com/risk-management/device-fingerprinting).
        /// </summary>
        [JsonProperty("deviceFingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceFingerprint { get; set; }

        /// <summary>
        /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
        /// </summary>
        [JsonProperty("fraudOffset", NullValueHandling = NullValueHandling.Ignore)]
        public int? FraudOffset { get; set; }

        /// <summary>
        /// Contains installment settings. For more information, refer to [Installments](https://docs.adyen.com/payment-methods/cards/credit-card-installments).
        /// </summary>
        [JsonProperty("installments", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Installments1 Installments { get; set; }

        /// <summary>
        /// The `localizedShopperStatement` field lets you use dynamic values for your shopper statement in a local character set.
        /// If not supplied, left empty, or for cross-border transactions, **shopperStatement** is used.
        /// Adyen currently supports the ja-Kana character set for Visa and Mastercard payments in Japan using Japanese cards. This character set supports:
        /// * UTF-8 based Katakana, capital letters, numbers and special characters.
        /// * Half-width or full-width characters.
        /// </summary>
        [JsonProperty("localizedShopperStatement", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> LocalizedShopperStatement { get; set; }

        /// <summary>
        /// The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.
        /// </summary>
        [JsonProperty("mcc", NullValueHandling = NullValueHandling.Ignore)]
        public string Mcc { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        [JsonProperty("merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// This reference allows linking multiple transactions to each other for reporting purposes (i.e. order auth-rate). The reference should be unique per billing cycle.
        /// The same merchant order reference should never be reused after the first authorised attempt. If used, this field should be supplied for all incoming authorisations.
        /// > We strongly recommend you send the `merchantOrderReference` value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide `retry.orderAttemptNumber`, `retry.chainAttemptNumber`, and `retry.skipRetry` values in `PaymentRequest.additionalData`.
        /// </summary>
        [JsonProperty("merchantOrderReference", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantOrderReference { get; set; }

        /// <summary>
        /// Additional risk fields for 3D Secure 2.
        /// > For 3D Secure 2 transactions, we recommend that you include this object to increase the chances of achieving a frictionless flow.
        /// </summary>
        [JsonProperty("merchantRiskIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantRiskIndicator1 MerchantRiskIndicator { get; set; }

        /// <summary>
        /// Metadata consists of entries, each of which includes a key and a value.
        /// Limits:
        /// * Maximum 20 key-value pairs per request. When exceeding, the "177" error occurs: "Metadata size exceeds limit".
        /// * Maximum 20 characters per key.
        /// * Maximum 80 characters per value.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// When you are doing multiple partial (gift card) payments, this is the `pspReference` of the first payment. We use this to link the multiple payments to each other. As your own reference for linking multiple payments, use the `merchantOrderReference`instead.
        /// </summary>
        [JsonProperty("orderReference", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderReference { get; set; }

        /// <summary>
        /// The recurring settings for the payment. Use this property when you want to enable [recurring payments](https://docs.adyen.com/classic-integration/recurring-payments).
        /// </summary>
        [JsonProperty("recurring", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Recurring1 Recurring { get; set; }

        /// <summary>
        /// Defines a recurring payment type. Required when creating a token to store payment details or using stored payment details.
        /// Allowed values:
        /// * `Subscription` – A transaction for a fixed or variable amount, which follows a fixed schedule.
        /// * `CardOnFile` – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.
        /// * `UnscheduledCardOnFile` – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount.
        /// </summary>
        [JsonProperty("recurringProcessingModel", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RecurringProcessingModelEnum? RecurringProcessingModel { get; set; }

        /// <summary>
        /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement.
        /// If you need to provide multiple references for a transaction, separate them with hyphens ("-").
        /// Maximum length: 80 characters.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Some payment methods require defining a value for this field to specify how to process the transaction.
        /// For the Bancontact payment method, it can be set to:
        /// * `maestro` (default), to be processed like a Maestro card, or
        /// * `bcmc`, to be processed like a Bancontact card.
        /// </summary>
        [JsonProperty("selectedBrand", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectedBrand { get; set; }

        /// <summary>
        /// The `recurringDetailReference` you want to use for this payment. The value `LATEST` can be used to select the most recently stored recurring detail.
        /// </summary>
        [JsonProperty("selectedRecurringDetailReference", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectedRecurringDetailReference { get; set; }

        /// <summary>
        /// A session ID used to identify a payment session.
        /// </summary>
        [JsonProperty("sessionId", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionId { get; set; }

        /// <summary>
        /// The shopper's email address. We recommend that you provide this data, as it is used in velocity fraud checks.
        /// > For 3D Secure 2 transactions, schemes require `shopperEmail` for all browser-based and mobile implementations.
        /// </summary>
        [JsonProperty("shopperEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// The shopper's IP address. In general, we recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks).
        /// > For 3D Secure 2 transactions, schemes require `shopperIP` for all browser-based implementations.
        /// This field is also mandatory for some merchants depending on your business model. For more information, [contact Support](https://www.adyen.help/hc/en-us/requests/new).
        /// </summary>
        [JsonProperty("shopperIP", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperIP { get; set; }

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
        /// The combination of a language code and a country code to specify the language to be used in the payment.
        /// </summary>
        [JsonProperty("shopperLocale", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperLocale { get; set; }

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
        /// The text to be shown on the shopper's bank statement.
        ///  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.
        ///  Allowed characters: **a-z**, **A-Z**, **0-9**, spaces, and special characters **. , ' _ - ? + * /**.
        /// </summary>
        [JsonProperty("shopperStatement", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperStatement { get; set; }

        /// <summary>
        /// The shopper's social security number.
        /// </summary>
        [JsonProperty("socialSecurityNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// An array of objects specifying how the payment should be split when using [Adyen for Platforms](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information) or [Issuing](https://docs.adyen.com/issuing/add-manage-funds#split).
        /// </summary>
        [JsonProperty("splits", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Split> Splits { get; set; }

        /// <summary>
        /// The ecommerce or point-of-sale store that is processing the payment. Used in:
        /// * [Partner platform integrations](https://docs.adyen.com/marketplaces-and-platforms/classic/platforms-for-partners#route-payments) for the [Classic Platforms integration](https://docs.adyen.com/marketplaces-and-platforms/classic).
        /// * [Platform setup integrations](https://docs.adyen.com/marketplaces-and-platforms/additional-for-platform-setup/route-payment-to-store) for the [Balance Platform](https://docs.adyen.com/marketplaces-and-platforms).
        /// </summary>
        [JsonProperty("store", NullValueHandling = NullValueHandling.Ignore)]
        public string Store { get; set; }

        /// <summary>
        /// The shopper's telephone number.
        /// </summary>
        [JsonProperty("telephoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Request fields for 3D Secure 2. To check if any of the following fields are required for your integration, refer to [Online payments](https://docs.adyen.com/online-payments) or [Classic integration](https://docs.adyen.com/classic-integration) documentation.
        /// </summary>
        [JsonProperty("threeDS2RequestData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDS2RequestData1 ThreeDS2RequestData { get; set; }

        /// <summary>
        /// Thre ThreeDS2Result that was returned in the final CRes.
        /// </summary>
        [JsonProperty("threeDS2Result", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDS2Result1 ThreeDS2Result { get; set; }

        /// <summary>
        /// The ThreeDS2Token that was returned in the /authorise call.
        /// </summary>
        [JsonProperty("threeDS2Token", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDS2Token { get; set; }

        /// <summary>
        /// If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.
        /// </summary>
        [JsonProperty("threeDSAuthenticationOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ThreeDSAuthenticationOnly { get; set; }

        /// <summary>
        /// The reference value to aggregate sales totals in reporting. When not specified, the store field is used (if available).
        /// </summary>
        [JsonProperty("totalsGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalsGroup { get; set; }

        /// <summary>
        /// Set to true if the payment should be routed to a trusted MID.
        /// </summary>
        [JsonProperty("trustedShopper", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TrustedShopper { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentRequest3ds2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentRequest3ds2 other &&                ((this.AccountInfo == null && other.AccountInfo == null) || (this.AccountInfo?.Equals(other.AccountInfo) == true)) &&
                ((this.AdditionalAmount == null && other.AdditionalAmount == null) || (this.AdditionalAmount?.Equals(other.AdditionalAmount) == true)) &&
                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.ApplicationInfo == null && other.ApplicationInfo == null) || (this.ApplicationInfo?.Equals(other.ApplicationInfo) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.BrowserInfo == null && other.BrowserInfo == null) || (this.BrowserInfo?.Equals(other.BrowserInfo) == true)) &&
                ((this.CaptureDelayHours == null && other.CaptureDelayHours == null) || (this.CaptureDelayHours?.Equals(other.CaptureDelayHours) == true)) &&
                ((this.DateOfBirth == null && other.DateOfBirth == null) || (this.DateOfBirth?.Equals(other.DateOfBirth) == true)) &&
                ((this.DccQuote == null && other.DccQuote == null) || (this.DccQuote?.Equals(other.DccQuote) == true)) &&
                ((this.DeliveryAddress == null && other.DeliveryAddress == null) || (this.DeliveryAddress?.Equals(other.DeliveryAddress) == true)) &&
                ((this.DeliveryDate == null && other.DeliveryDate == null) || (this.DeliveryDate?.Equals(other.DeliveryDate) == true)) &&
                ((this.DeviceFingerprint == null && other.DeviceFingerprint == null) || (this.DeviceFingerprint?.Equals(other.DeviceFingerprint) == true)) &&
                ((this.FraudOffset == null && other.FraudOffset == null) || (this.FraudOffset?.Equals(other.FraudOffset) == true)) &&
                ((this.Installments == null && other.Installments == null) || (this.Installments?.Equals(other.Installments) == true)) &&
                ((this.LocalizedShopperStatement == null && other.LocalizedShopperStatement == null) || (this.LocalizedShopperStatement?.Equals(other.LocalizedShopperStatement) == true)) &&
                ((this.Mcc == null && other.Mcc == null) || (this.Mcc?.Equals(other.Mcc) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.MerchantOrderReference == null && other.MerchantOrderReference == null) || (this.MerchantOrderReference?.Equals(other.MerchantOrderReference) == true)) &&
                ((this.MerchantRiskIndicator == null && other.MerchantRiskIndicator == null) || (this.MerchantRiskIndicator?.Equals(other.MerchantRiskIndicator) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.OrderReference == null && other.OrderReference == null) || (this.OrderReference?.Equals(other.OrderReference) == true)) &&
                ((this.Recurring == null && other.Recurring == null) || (this.Recurring?.Equals(other.Recurring) == true)) &&
                ((this.RecurringProcessingModel == null && other.RecurringProcessingModel == null) || (this.RecurringProcessingModel?.Equals(other.RecurringProcessingModel) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.SelectedBrand == null && other.SelectedBrand == null) || (this.SelectedBrand?.Equals(other.SelectedBrand) == true)) &&
                ((this.SelectedRecurringDetailReference == null && other.SelectedRecurringDetailReference == null) || (this.SelectedRecurringDetailReference?.Equals(other.SelectedRecurringDetailReference) == true)) &&
                ((this.SessionId == null && other.SessionId == null) || (this.SessionId?.Equals(other.SessionId) == true)) &&
                ((this.ShopperEmail == null && other.ShopperEmail == null) || (this.ShopperEmail?.Equals(other.ShopperEmail) == true)) &&
                ((this.ShopperIP == null && other.ShopperIP == null) || (this.ShopperIP?.Equals(other.ShopperIP) == true)) &&
                ((this.ShopperInteraction == null && other.ShopperInteraction == null) || (this.ShopperInteraction?.Equals(other.ShopperInteraction) == true)) &&
                ((this.ShopperLocale == null && other.ShopperLocale == null) || (this.ShopperLocale?.Equals(other.ShopperLocale) == true)) &&
                ((this.ShopperName == null && other.ShopperName == null) || (this.ShopperName?.Equals(other.ShopperName) == true)) &&
                ((this.ShopperReference == null && other.ShopperReference == null) || (this.ShopperReference?.Equals(other.ShopperReference) == true)) &&
                ((this.ShopperStatement == null && other.ShopperStatement == null) || (this.ShopperStatement?.Equals(other.ShopperStatement) == true)) &&
                ((this.SocialSecurityNumber == null && other.SocialSecurityNumber == null) || (this.SocialSecurityNumber?.Equals(other.SocialSecurityNumber) == true)) &&
                ((this.Splits == null && other.Splits == null) || (this.Splits?.Equals(other.Splits) == true)) &&
                ((this.Store == null && other.Store == null) || (this.Store?.Equals(other.Store) == true)) &&
                ((this.TelephoneNumber == null && other.TelephoneNumber == null) || (this.TelephoneNumber?.Equals(other.TelephoneNumber) == true)) &&
                ((this.ThreeDS2RequestData == null && other.ThreeDS2RequestData == null) || (this.ThreeDS2RequestData?.Equals(other.ThreeDS2RequestData) == true)) &&
                ((this.ThreeDS2Result == null && other.ThreeDS2Result == null) || (this.ThreeDS2Result?.Equals(other.ThreeDS2Result) == true)) &&
                ((this.ThreeDS2Token == null && other.ThreeDS2Token == null) || (this.ThreeDS2Token?.Equals(other.ThreeDS2Token) == true)) &&
                ((this.ThreeDSAuthenticationOnly == null && other.ThreeDSAuthenticationOnly == null) || (this.ThreeDSAuthenticationOnly?.Equals(other.ThreeDSAuthenticationOnly) == true)) &&
                ((this.TotalsGroup == null && other.TotalsGroup == null) || (this.TotalsGroup?.Equals(other.TotalsGroup) == true)) &&
                ((this.TrustedShopper == null && other.TrustedShopper == null) || (this.TrustedShopper?.Equals(other.TrustedShopper) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountInfo = {(this.AccountInfo == null ? "null" : this.AccountInfo.ToString())}");
            toStringOutput.Add($"this.AdditionalAmount = {(this.AdditionalAmount == null ? "null" : this.AdditionalAmount.ToString())}");
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.ApplicationInfo = {(this.ApplicationInfo == null ? "null" : this.ApplicationInfo.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.BrowserInfo = {(this.BrowserInfo == null ? "null" : this.BrowserInfo.ToString())}");
            toStringOutput.Add($"this.CaptureDelayHours = {(this.CaptureDelayHours == null ? "null" : this.CaptureDelayHours.ToString())}");
            toStringOutput.Add($"this.DateOfBirth = {(this.DateOfBirth == null ? "null" : this.DateOfBirth.ToString())}");
            toStringOutput.Add($"this.DccQuote = {(this.DccQuote == null ? "null" : this.DccQuote.ToString())}");
            toStringOutput.Add($"this.DeliveryAddress = {(this.DeliveryAddress == null ? "null" : this.DeliveryAddress.ToString())}");
            toStringOutput.Add($"this.DeliveryDate = {(this.DeliveryDate == null ? "null" : this.DeliveryDate.ToString())}");
            toStringOutput.Add($"this.DeviceFingerprint = {(this.DeviceFingerprint == null ? "null" : this.DeviceFingerprint)}");
            toStringOutput.Add($"this.FraudOffset = {(this.FraudOffset == null ? "null" : this.FraudOffset.ToString())}");
            toStringOutput.Add($"this.Installments = {(this.Installments == null ? "null" : this.Installments.ToString())}");
            toStringOutput.Add($"LocalizedShopperStatement = {(this.LocalizedShopperStatement == null ? "null" : this.LocalizedShopperStatement.ToString())}");
            toStringOutput.Add($"this.Mcc = {(this.Mcc == null ? "null" : this.Mcc)}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.MerchantOrderReference = {(this.MerchantOrderReference == null ? "null" : this.MerchantOrderReference)}");
            toStringOutput.Add($"this.MerchantRiskIndicator = {(this.MerchantRiskIndicator == null ? "null" : this.MerchantRiskIndicator.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.OrderReference = {(this.OrderReference == null ? "null" : this.OrderReference)}");
            toStringOutput.Add($"this.Recurring = {(this.Recurring == null ? "null" : this.Recurring.ToString())}");
            toStringOutput.Add($"this.RecurringProcessingModel = {(this.RecurringProcessingModel == null ? "null" : this.RecurringProcessingModel.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.SelectedBrand = {(this.SelectedBrand == null ? "null" : this.SelectedBrand)}");
            toStringOutput.Add($"this.SelectedRecurringDetailReference = {(this.SelectedRecurringDetailReference == null ? "null" : this.SelectedRecurringDetailReference)}");
            toStringOutput.Add($"this.SessionId = {(this.SessionId == null ? "null" : this.SessionId)}");
            toStringOutput.Add($"this.ShopperEmail = {(this.ShopperEmail == null ? "null" : this.ShopperEmail)}");
            toStringOutput.Add($"this.ShopperIP = {(this.ShopperIP == null ? "null" : this.ShopperIP)}");
            toStringOutput.Add($"this.ShopperInteraction = {(this.ShopperInteraction == null ? "null" : this.ShopperInteraction.ToString())}");
            toStringOutput.Add($"this.ShopperLocale = {(this.ShopperLocale == null ? "null" : this.ShopperLocale)}");
            toStringOutput.Add($"this.ShopperName = {(this.ShopperName == null ? "null" : this.ShopperName.ToString())}");
            toStringOutput.Add($"this.ShopperReference = {(this.ShopperReference == null ? "null" : this.ShopperReference)}");
            toStringOutput.Add($"this.ShopperStatement = {(this.ShopperStatement == null ? "null" : this.ShopperStatement)}");
            toStringOutput.Add($"this.SocialSecurityNumber = {(this.SocialSecurityNumber == null ? "null" : this.SocialSecurityNumber)}");
            toStringOutput.Add($"this.Splits = {(this.Splits == null ? "null" : $"[{string.Join(", ", this.Splits)} ]")}");
            toStringOutput.Add($"this.Store = {(this.Store == null ? "null" : this.Store)}");
            toStringOutput.Add($"this.TelephoneNumber = {(this.TelephoneNumber == null ? "null" : this.TelephoneNumber)}");
            toStringOutput.Add($"this.ThreeDS2RequestData = {(this.ThreeDS2RequestData == null ? "null" : this.ThreeDS2RequestData.ToString())}");
            toStringOutput.Add($"this.ThreeDS2Result = {(this.ThreeDS2Result == null ? "null" : this.ThreeDS2Result.ToString())}");
            toStringOutput.Add($"this.ThreeDS2Token = {(this.ThreeDS2Token == null ? "null" : this.ThreeDS2Token)}");
            toStringOutput.Add($"this.ThreeDSAuthenticationOnly = {(this.ThreeDSAuthenticationOnly == null ? "null" : this.ThreeDSAuthenticationOnly.ToString())}");
            toStringOutput.Add($"this.TotalsGroup = {(this.TotalsGroup == null ? "null" : this.TotalsGroup)}");
            toStringOutput.Add($"this.TrustedShopper = {(this.TrustedShopper == null ? "null" : this.TrustedShopper.ToString())}");
        }
    }
}