// <copyright file="PaymentRequest.cs" company="APIMatic">
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
    using AdyenMergedAPI.Standard.Models.Containers;
    using AdyenMergedAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// PaymentRequest.
    /// </summary>
    public class PaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequest"/> class.
        /// </summary>
        public PaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="reference">reference.</param>
        /// <param name="returnUrl">returnUrl.</param>
        /// <param name="accountInfo">accountInfo.</param>
        /// <param name="additionalAmount">additionalAmount.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="applicationInfo">applicationInfo.</param>
        /// <param name="authenticationData">authenticationData.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="browserInfo">browserInfo.</param>
        /// <param name="captureDelayHours">captureDelayHours.</param>
        /// <param name="channel">channel.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="company">company.</param>
        /// <param name="conversionId">conversionId.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="dccQuote">dccQuote.</param>
        /// <param name="deliverAt">deliverAt.</param>
        /// <param name="deliveryAddress">deliveryAddress.</param>
        /// <param name="deliveryDate">deliveryDate.</param>
        /// <param name="deviceFingerprint">deviceFingerprint.</param>
        /// <param name="enableOneClick">enableOneClick.</param>
        /// <param name="enablePayOut">enablePayOut.</param>
        /// <param name="enableRecurring">enableRecurring.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="fraudOffset">fraudOffset.</param>
        /// <param name="fundOrigin">fundOrigin.</param>
        /// <param name="fundRecipient">fundRecipient.</param>
        /// <param name="industryUsage">industryUsage.</param>
        /// <param name="installments">installments.</param>
        /// <param name="lineItems">lineItems.</param>
        /// <param name="localizedShopperStatement">localizedShopperStatement.</param>
        /// <param name="mandate">mandate.</param>
        /// <param name="mcc">mcc.</param>
        /// <param name="merchantOrderReference">merchantOrderReference.</param>
        /// <param name="merchantRiskIndicator">merchantRiskIndicator.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="mpiData">mpiData.</param>
        /// <param name="order">order.</param>
        /// <param name="orderReference">orderReference.</param>
        /// <param name="origin">origin.</param>
        /// <param name="platformChargebackLogic">platformChargebackLogic.</param>
        /// <param name="recurringExpiry">recurringExpiry.</param>
        /// <param name="recurringFrequency">recurringFrequency.</param>
        /// <param name="recurringProcessingModel">recurringProcessingModel.</param>
        /// <param name="redirectFromIssuerMethod">redirectFromIssuerMethod.</param>
        /// <param name="redirectToIssuerMethod">redirectToIssuerMethod.</param>
        /// <param name="riskData">riskData.</param>
        /// <param name="sessionValidity">sessionValidity.</param>
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
        /// <param name="storePaymentMethod">storePaymentMethod.</param>
        /// <param name="telephoneNumber">telephoneNumber.</param>
        /// <param name="threeDS2RequestData">threeDS2RequestData.</param>
        /// <param name="threeDSAuthenticationOnly">threeDSAuthenticationOnly.</param>
        /// <param name="trustedShopper">trustedShopper.</param>
        public PaymentRequest(
            Models.Amount2 amount,
            string merchantAccount,
            PaymentRequestPaymentMethod paymentMethod,
            string reference,
            string returnUrl,
            Models.AccountInfo accountInfo = null,
            Models.Amount1 additionalAmount = null,
            Dictionary<string, string> additionalData = null,
            Models.ApplicationInfo applicationInfo = null,
            Models.AuthenticationData3 authenticationData = null,
            Models.BillingAddress4 billingAddress = null,
            Models.BrowserInfo browserInfo = null,
            int? captureDelayHours = null,
            Models.Channel2Enum? channel = null,
            string checkoutAttemptId = null,
            Models.Company1 company = null,
            string conversionId = null,
            string countryCode = null,
            DateTime? dateOfBirth = null,
            Models.ForexQuote2 dccQuote = null,
            DateTime? deliverAt = null,
            Models.DeliveryAddress1 deliveryAddress = null,
            DateTime? deliveryDate = null,
            string deviceFingerprint = null,
            bool? enableOneClick = null,
            bool? enablePayOut = null,
            bool? enableRecurring = null,
            Models.EntityTypeEnum? entityType = null,
            int? fraudOffset = null,
            Models.FundOrigin1 fundOrigin = null,
            Models.FundRecipient1 fundRecipient = null,
            Models.IndustryUsage1Enum? industryUsage = null,
            Models.Installments installments = null,
            List<Models.LineItem> lineItems = null,
            Dictionary<string, string> localizedShopperStatement = null,
            Models.Mandate mandate = null,
            string mcc = null,
            string merchantOrderReference = null,
            Models.MerchantRiskIndicator1 merchantRiskIndicator = null,
            Dictionary<string, string> metadata = null,
            Models.ThreeDSecureData mpiData = null,
            Models.EncryptedOrderData2 order = null,
            string orderReference = null,
            string origin = null,
            Models.PlatformChargebackLogic platformChargebackLogic = null,
            string recurringExpiry = null,
            string recurringFrequency = null,
            Models.RecurringProcessingModelEnum? recurringProcessingModel = null,
            string redirectFromIssuerMethod = null,
            string redirectToIssuerMethod = null,
            Models.RiskData4 riskData = null,
            string sessionValidity = null,
            string shopperEmail = null,
            string shopperIP = null,
            Models.ShopperInteractionEnum? shopperInteraction = null,
            string shopperLocale = null,
            Models.Name5 shopperName = null,
            string shopperReference = null,
            string shopperStatement = null,
            string socialSecurityNumber = null,
            List<Models.Split> splits = null,
            string store = null,
            bool? storePaymentMethod = null,
            string telephoneNumber = null,
            Models.ThreeDS2RequestFields1 threeDS2RequestData = null,
            bool? threeDSAuthenticationOnly = false,
            bool? trustedShopper = null)
        {
            this.AccountInfo = accountInfo;
            this.AdditionalAmount = additionalAmount;
            this.AdditionalData = additionalData;
            this.Amount = amount;
            this.ApplicationInfo = applicationInfo;
            this.AuthenticationData = authenticationData;
            this.BillingAddress = billingAddress;
            this.BrowserInfo = browserInfo;
            this.CaptureDelayHours = captureDelayHours;
            this.Channel = channel;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.Company = company;
            this.ConversionId = conversionId;
            this.CountryCode = countryCode;
            this.DateOfBirth = dateOfBirth;
            this.DccQuote = dccQuote;
            this.DeliverAt = deliverAt;
            this.DeliveryAddress = deliveryAddress;
            this.DeliveryDate = deliveryDate;
            this.DeviceFingerprint = deviceFingerprint;
            this.EnableOneClick = enableOneClick;
            this.EnablePayOut = enablePayOut;
            this.EnableRecurring = enableRecurring;
            this.EntityType = entityType;
            this.FraudOffset = fraudOffset;
            this.FundOrigin = fundOrigin;
            this.FundRecipient = fundRecipient;
            this.IndustryUsage = industryUsage;
            this.Installments = installments;
            this.LineItems = lineItems;
            this.LocalizedShopperStatement = localizedShopperStatement;
            this.Mandate = mandate;
            this.Mcc = mcc;
            this.MerchantAccount = merchantAccount;
            this.MerchantOrderReference = merchantOrderReference;
            this.MerchantRiskIndicator = merchantRiskIndicator;
            this.Metadata = metadata;
            this.MpiData = mpiData;
            this.Order = order;
            this.OrderReference = orderReference;
            this.Origin = origin;
            this.PaymentMethod = paymentMethod;
            this.PlatformChargebackLogic = platformChargebackLogic;
            this.RecurringExpiry = recurringExpiry;
            this.RecurringFrequency = recurringFrequency;
            this.RecurringProcessingModel = recurringProcessingModel;
            this.RedirectFromIssuerMethod = redirectFromIssuerMethod;
            this.RedirectToIssuerMethod = redirectToIssuerMethod;
            this.Reference = reference;
            this.ReturnUrl = returnUrl;
            this.RiskData = riskData;
            this.SessionValidity = sessionValidity;
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
            this.StorePaymentMethod = storePaymentMethod;
            this.TelephoneNumber = telephoneNumber;
            this.ThreeDS2RequestData = threeDS2RequestData;
            this.ThreeDSAuthenticationOnly = threeDSAuthenticationOnly;
            this.TrustedShopper = trustedShopper;
        }

        /// <summary>
        /// Shopper account information for 3D Secure 2.
        /// > For 3D Secure 2 transactions, we recommend that you include this object to increase the chances of achieving a frictionless flow.
        /// </summary>
        [JsonProperty("accountInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountInfo AccountInfo { get; set; }

        /// <summary>
        /// If you want a [BIN or card verification](https://docs.adyen.com/payment-methods/cards/bin-data-and-card-verification) request to use a non-zero value, assign this value to `additionalAmount` (while the amount must be still set to 0 to trigger BIN or card verification).
        /// Required to be in the same currency as the `amount`.
        /// </summary>
        [JsonProperty("additionalAmount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount1 AdditionalAmount { get; set; }

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
        public Models.Amount2 Amount { get; set; }

        /// <summary>
        /// Information about your application. For more details, see [Building Adyen solutions](https://docs.adyen.com/development-resources/building-adyen-solutions).
        /// </summary>
        [JsonProperty("applicationInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplicationInfo ApplicationInfo { get; set; }

        /// <summary>
        /// Data for 3DS authentication.
        /// </summary>
        [JsonProperty("authenticationData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AuthenticationData3 AuthenticationData { get; set; }

        /// <summary>
        /// The address where to send the invoice.
        /// > The `billingAddress` object is required in the following scenarios. Include all of the fields within this object.
        /// >* For 3D Secure 2 transactions in all browser-based and mobile implementations.
        /// >* For cross-border payouts to and from Canada.
        /// </summary>
        [JsonProperty("billingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingAddress4 BillingAddress { get; set; }

        /// <summary>
        /// The shopper's browser information.
        /// > For 3D Secure, the full object is required for web integrations. For mobile app integrations, include the `userAgent` and `acceptHeader` fields to indicate  that your integration can support a redirect in case a payment is routed to 3D Secure 1.
        /// </summary>
        [JsonProperty("browserInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BrowserInfo BrowserInfo { get; set; }

        /// <summary>
        /// The delay between the authorisation and scheduled auto-capture, specified in hours.
        /// </summary>
        [JsonProperty("captureDelayHours", NullValueHandling = NullValueHandling.Ignore)]
        public int? CaptureDelayHours { get; set; }

        /// <summary>
        /// The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the `sdkVersion` or `token`.
        /// Possible values:
        /// * iOS
        /// * Android
        /// * Web
        /// </summary>
        [JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Channel2Enum? Channel { get; set; }

        /// <summary>
        /// Checkout attempt ID that corresponds to the Id generated by the client SDK for tracking user payment journey.
        /// </summary>
        [JsonProperty("checkoutAttemptId", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// Information regarding the company.
        /// </summary>
        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Company1 Company { get; set; }

        /// <summary>
        /// Conversion ID that corresponds to the Id generated by the client SDK for tracking user payment journey.
        /// </summary>
        [JsonProperty("conversionId", NullValueHandling = NullValueHandling.Ignore)]
        public string ConversionId { get; set; }

        /// <summary>
        /// The shopper country.
        /// Format: [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)
        /// Example: NL or DE
        /// </summary>
        [JsonProperty("countryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The shopper's date of birth.
        /// Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("dateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// The forex quote as returned in the response of the forex service.
        /// </summary>
        [JsonProperty("dccQuote", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ForexQuote2 DccQuote { get; set; }

        /// <summary>
        /// The date and time the purchased goods should be delivered.
        /// Format [ISO 8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DDThh:mm:ss.sssTZD
        /// Example: 2017-07-17T13:42:40.428+01:00
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deliverAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DeliverAt { get; set; }

        /// <summary>
        /// The address where the purchased goods should be delivered.
        /// </summary>
        [JsonProperty("deliveryAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeliveryAddress1 DeliveryAddress { get; set; }

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
        /// When true and `shopperReference` is provided, the shopper will be asked if the payment details should be stored for future one-click payments.
        /// </summary>
        [JsonProperty("enableOneClick", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableOneClick { get; set; }

        /// <summary>
        /// When true and `shopperReference` is provided, the payment details will be tokenized for payouts.
        /// </summary>
        [JsonProperty("enablePayOut", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePayOut { get; set; }

        /// <summary>
        /// When true and `shopperReference` is provided, the payment details will be tokenized for recurring payments.
        /// </summary>
        [JsonProperty("enableRecurring", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableRecurring { get; set; }

        /// <summary>
        /// The type of the entity the payment is processed for.
        /// </summary>
        [JsonProperty("entityType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EntityTypeEnum? EntityType { get; set; }

        /// <summary>
        /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
        /// </summary>
        [JsonProperty("fraudOffset", NullValueHandling = NullValueHandling.Ignore)]
        public int? FraudOffset { get; set; }

        /// <summary>
        /// The person or entity funding the money.
        /// </summary>
        [JsonProperty("fundOrigin", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FundOrigin1 FundOrigin { get; set; }

        /// <summary>
        /// the person or entity receiving the money
        /// </summary>
        [JsonProperty("fundRecipient", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FundRecipient1 FundRecipient { get; set; }

        /// <summary>
        /// The reason for the amount update. Possible values:
        /// * **delayedCharge**
        /// * **noShow**
        /// * **installment**
        /// </summary>
        [JsonProperty("industryUsage", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IndustryUsage1Enum? IndustryUsage { get; set; }

        /// <summary>
        /// Contains installment settings. For more information, refer to [Installments](https://docs.adyen.com/payment-methods/cards/credit-card-installments).
        /// </summary>
        [JsonProperty("installments", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Installments Installments { get; set; }

        /// <summary>
        /// Price and product information about the purchased items, to be included on the invoice sent to the shopper.
        /// > This field is required for 3x 4x Oney, Affirm, Afterpay, Clearpay, Klarna, Ratepay, and Zip.
        /// </summary>
        [JsonProperty("lineItems", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LineItem> LineItems { get; set; }

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
        /// The mandate details to initiate recurring transaction.
        /// </summary>
        [JsonProperty("mandate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Mandate Mandate { get; set; }

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
        /// Authentication data produced by an MPI (Mastercard SecureCode, Visa Secure, or Cartes Bancaires).
        /// </summary>
        [JsonProperty("mpiData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDSecureData MpiData { get; set; }

        /// <summary>
        /// The order information required for partial payments.
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EncryptedOrderData2 Order { get; set; }

        /// <summary>
        /// When you are doing multiple partial (gift card) payments, this is the `pspReference` of the first payment. We use this to link the multiple payments to each other. As your own reference for linking multiple payments, use the `merchantOrderReference`instead.
        /// </summary>
        [JsonProperty("orderReference", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderReference { get; set; }

        /// <summary>
        /// Required for the 3D Secure 2 `channel` **Web** integration.
        /// Set this parameter to the origin URL of the page that you are loading the 3D Secure Component from.
        /// </summary>
        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public string Origin { get; set; }

        /// <summary>
        /// The type and required details of a payment method to use.
        /// </summary>
        [JsonProperty("paymentMethod")]
        public PaymentRequestPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Defines how to book chargebacks when using [Adyen for Platforms](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#chargebacks-and-disputes).
        /// </summary>
        [JsonProperty("platformChargebackLogic", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PlatformChargebackLogic PlatformChargebackLogic { get; set; }

        /// <summary>
        /// Date after which no further authorisations shall be performed. Only for 3D Secure 2.
        /// </summary>
        [JsonProperty("recurringExpiry", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurringExpiry { get; set; }

        /// <summary>
        /// Minimum number of days between authorisations. Only for 3D Secure 2.
        /// </summary>
        [JsonProperty("recurringFrequency", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurringFrequency { get; set; }

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
        /// Specifies the redirect method (GET or POST) when redirecting back from the issuer.
        /// </summary>
        [JsonProperty("redirectFromIssuerMethod", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectFromIssuerMethod { get; set; }

        /// <summary>
        /// Specifies the redirect method (GET or POST) when redirecting to the issuer.
        /// </summary>
        [JsonProperty("redirectToIssuerMethod", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectToIssuerMethod { get; set; }

        /// <summary>
        /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement.
        /// If you need to provide multiple references for a transaction, separate them with hyphens ("-").
        /// Maximum length: 80 characters.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The URL to return to in case of a redirection.
        /// The format depends on the channel.
        /// * For web, include the protocol `http://` or `https://`. You can also include your own additional query parameters, for example, shopper ID or order reference number.
        /// Example: `https://your-company.com/checkout?shopperOrder=12xy`
        /// * For iOS, use the custom URL for your app. To know more about setting custom URL schemes, refer to the [Apple Developer documentation](https://developer.apple.com/documentation/uikit/inter-process_communication/allowing_apps_and_websites_to_link_to_your_content/defining_a_custom_url_scheme_for_your_app).
        /// Example: `my-app://`
        /// * For Android, use a custom URL handled by an Activity on your app. You can configure it with an [intent filter](https://developer.android.com/guide/components/intents-filters).
        /// Example: `my-app://your.package.name`
        /// </summary>
        [JsonProperty("returnUrl")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Contains risk data, such as client-side data, used to identify risk for a transaction.
        /// </summary>
        [JsonProperty("riskData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RiskData4 RiskData { get; set; }

        /// <summary>
        /// The date and time until when the session remains valid, in [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.
        /// For example: 2020-07-18T15:42:40.428+01:00
        /// </summary>
        [JsonProperty("sessionValidity", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionValidity { get; set; }

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
        public Models.Name5 ShopperName { get; set; }

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
        /// An array of objects specifying how to split a payment when using [Adyen for Platforms](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information), [Classic Platforms integration](https://docs.adyen.com/marketplaces-and-platforms/classic/processing-payments#providing-split-information), or [Issuing](https://docs.adyen.com/issuing/manage-funds#split).
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
        /// When true and `shopperReference` is provided, the payment details will be stored.
        /// </summary>
        [JsonProperty("storePaymentMethod", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StorePaymentMethod { get; set; }

        /// <summary>
        /// The shopper's telephone number.
        /// </summary>
        [JsonProperty("telephoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Request fields for 3D Secure 2. To check if any of the following fields are required for your integration, refer to [Online payments](https://docs.adyen.com/online-payments) or [Classic integration](https://docs.adyen.com/classic-integration) documentation.
        /// </summary>
        [JsonProperty("threeDS2RequestData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDS2RequestFields1 ThreeDS2RequestData { get; set; }

        /// <summary>
        /// If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.
        /// </summary>
        [JsonProperty("threeDSAuthenticationOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ThreeDSAuthenticationOnly { get; set; }

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

            return $"PaymentRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentRequest other &&                ((this.AccountInfo == null && other.AccountInfo == null) || (this.AccountInfo?.Equals(other.AccountInfo) == true)) &&
                ((this.AdditionalAmount == null && other.AdditionalAmount == null) || (this.AdditionalAmount?.Equals(other.AdditionalAmount) == true)) &&
                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.ApplicationInfo == null && other.ApplicationInfo == null) || (this.ApplicationInfo?.Equals(other.ApplicationInfo) == true)) &&
                ((this.AuthenticationData == null && other.AuthenticationData == null) || (this.AuthenticationData?.Equals(other.AuthenticationData) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.BrowserInfo == null && other.BrowserInfo == null) || (this.BrowserInfo?.Equals(other.BrowserInfo) == true)) &&
                ((this.CaptureDelayHours == null && other.CaptureDelayHours == null) || (this.CaptureDelayHours?.Equals(other.CaptureDelayHours) == true)) &&
                ((this.Channel == null && other.Channel == null) || (this.Channel?.Equals(other.Channel) == true)) &&
                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.Company == null && other.Company == null) || (this.Company?.Equals(other.Company) == true)) &&
                ((this.ConversionId == null && other.ConversionId == null) || (this.ConversionId?.Equals(other.ConversionId) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.DateOfBirth == null && other.DateOfBirth == null) || (this.DateOfBirth?.Equals(other.DateOfBirth) == true)) &&
                ((this.DccQuote == null && other.DccQuote == null) || (this.DccQuote?.Equals(other.DccQuote) == true)) &&
                ((this.DeliverAt == null && other.DeliverAt == null) || (this.DeliverAt?.Equals(other.DeliverAt) == true)) &&
                ((this.DeliveryAddress == null && other.DeliveryAddress == null) || (this.DeliveryAddress?.Equals(other.DeliveryAddress) == true)) &&
                ((this.DeliveryDate == null && other.DeliveryDate == null) || (this.DeliveryDate?.Equals(other.DeliveryDate) == true)) &&
                ((this.DeviceFingerprint == null && other.DeviceFingerprint == null) || (this.DeviceFingerprint?.Equals(other.DeviceFingerprint) == true)) &&
                ((this.EnableOneClick == null && other.EnableOneClick == null) || (this.EnableOneClick?.Equals(other.EnableOneClick) == true)) &&
                ((this.EnablePayOut == null && other.EnablePayOut == null) || (this.EnablePayOut?.Equals(other.EnablePayOut) == true)) &&
                ((this.EnableRecurring == null && other.EnableRecurring == null) || (this.EnableRecurring?.Equals(other.EnableRecurring) == true)) &&
                ((this.EntityType == null && other.EntityType == null) || (this.EntityType?.Equals(other.EntityType) == true)) &&
                ((this.FraudOffset == null && other.FraudOffset == null) || (this.FraudOffset?.Equals(other.FraudOffset) == true)) &&
                ((this.FundOrigin == null && other.FundOrigin == null) || (this.FundOrigin?.Equals(other.FundOrigin) == true)) &&
                ((this.FundRecipient == null && other.FundRecipient == null) || (this.FundRecipient?.Equals(other.FundRecipient) == true)) &&
                ((this.IndustryUsage == null && other.IndustryUsage == null) || (this.IndustryUsage?.Equals(other.IndustryUsage) == true)) &&
                ((this.Installments == null && other.Installments == null) || (this.Installments?.Equals(other.Installments) == true)) &&
                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true)) &&
                ((this.LocalizedShopperStatement == null && other.LocalizedShopperStatement == null) || (this.LocalizedShopperStatement?.Equals(other.LocalizedShopperStatement) == true)) &&
                ((this.Mandate == null && other.Mandate == null) || (this.Mandate?.Equals(other.Mandate) == true)) &&
                ((this.Mcc == null && other.Mcc == null) || (this.Mcc?.Equals(other.Mcc) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.MerchantOrderReference == null && other.MerchantOrderReference == null) || (this.MerchantOrderReference?.Equals(other.MerchantOrderReference) == true)) &&
                ((this.MerchantRiskIndicator == null && other.MerchantRiskIndicator == null) || (this.MerchantRiskIndicator?.Equals(other.MerchantRiskIndicator) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.MpiData == null && other.MpiData == null) || (this.MpiData?.Equals(other.MpiData) == true)) &&
                ((this.Order == null && other.Order == null) || (this.Order?.Equals(other.Order) == true)) &&
                ((this.OrderReference == null && other.OrderReference == null) || (this.OrderReference?.Equals(other.OrderReference) == true)) &&
                ((this.Origin == null && other.Origin == null) || (this.Origin?.Equals(other.Origin) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.PlatformChargebackLogic == null && other.PlatformChargebackLogic == null) || (this.PlatformChargebackLogic?.Equals(other.PlatformChargebackLogic) == true)) &&
                ((this.RecurringExpiry == null && other.RecurringExpiry == null) || (this.RecurringExpiry?.Equals(other.RecurringExpiry) == true)) &&
                ((this.RecurringFrequency == null && other.RecurringFrequency == null) || (this.RecurringFrequency?.Equals(other.RecurringFrequency) == true)) &&
                ((this.RecurringProcessingModel == null && other.RecurringProcessingModel == null) || (this.RecurringProcessingModel?.Equals(other.RecurringProcessingModel) == true)) &&
                ((this.RedirectFromIssuerMethod == null && other.RedirectFromIssuerMethod == null) || (this.RedirectFromIssuerMethod?.Equals(other.RedirectFromIssuerMethod) == true)) &&
                ((this.RedirectToIssuerMethod == null && other.RedirectToIssuerMethod == null) || (this.RedirectToIssuerMethod?.Equals(other.RedirectToIssuerMethod) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.ReturnUrl == null && other.ReturnUrl == null) || (this.ReturnUrl?.Equals(other.ReturnUrl) == true)) &&
                ((this.RiskData == null && other.RiskData == null) || (this.RiskData?.Equals(other.RiskData) == true)) &&
                ((this.SessionValidity == null && other.SessionValidity == null) || (this.SessionValidity?.Equals(other.SessionValidity) == true)) &&
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
                ((this.StorePaymentMethod == null && other.StorePaymentMethod == null) || (this.StorePaymentMethod?.Equals(other.StorePaymentMethod) == true)) &&
                ((this.TelephoneNumber == null && other.TelephoneNumber == null) || (this.TelephoneNumber?.Equals(other.TelephoneNumber) == true)) &&
                ((this.ThreeDS2RequestData == null && other.ThreeDS2RequestData == null) || (this.ThreeDS2RequestData?.Equals(other.ThreeDS2RequestData) == true)) &&
                ((this.ThreeDSAuthenticationOnly == null && other.ThreeDSAuthenticationOnly == null) || (this.ThreeDSAuthenticationOnly?.Equals(other.ThreeDSAuthenticationOnly) == true)) &&
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
            toStringOutput.Add($"this.AuthenticationData = {(this.AuthenticationData == null ? "null" : this.AuthenticationData.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.BrowserInfo = {(this.BrowserInfo == null ? "null" : this.BrowserInfo.ToString())}");
            toStringOutput.Add($"this.CaptureDelayHours = {(this.CaptureDelayHours == null ? "null" : this.CaptureDelayHours.ToString())}");
            toStringOutput.Add($"this.Channel = {(this.Channel == null ? "null" : this.Channel.ToString())}");
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.Company = {(this.Company == null ? "null" : this.Company.ToString())}");
            toStringOutput.Add($"this.ConversionId = {(this.ConversionId == null ? "null" : this.ConversionId)}");
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
            toStringOutput.Add($"this.DateOfBirth = {(this.DateOfBirth == null ? "null" : this.DateOfBirth.ToString())}");
            toStringOutput.Add($"this.DccQuote = {(this.DccQuote == null ? "null" : this.DccQuote.ToString())}");
            toStringOutput.Add($"this.DeliverAt = {(this.DeliverAt == null ? "null" : this.DeliverAt.ToString())}");
            toStringOutput.Add($"this.DeliveryAddress = {(this.DeliveryAddress == null ? "null" : this.DeliveryAddress.ToString())}");
            toStringOutput.Add($"this.DeliveryDate = {(this.DeliveryDate == null ? "null" : this.DeliveryDate.ToString())}");
            toStringOutput.Add($"this.DeviceFingerprint = {(this.DeviceFingerprint == null ? "null" : this.DeviceFingerprint)}");
            toStringOutput.Add($"this.EnableOneClick = {(this.EnableOneClick == null ? "null" : this.EnableOneClick.ToString())}");
            toStringOutput.Add($"this.EnablePayOut = {(this.EnablePayOut == null ? "null" : this.EnablePayOut.ToString())}");
            toStringOutput.Add($"this.EnableRecurring = {(this.EnableRecurring == null ? "null" : this.EnableRecurring.ToString())}");
            toStringOutput.Add($"this.EntityType = {(this.EntityType == null ? "null" : this.EntityType.ToString())}");
            toStringOutput.Add($"this.FraudOffset = {(this.FraudOffset == null ? "null" : this.FraudOffset.ToString())}");
            toStringOutput.Add($"this.FundOrigin = {(this.FundOrigin == null ? "null" : this.FundOrigin.ToString())}");
            toStringOutput.Add($"this.FundRecipient = {(this.FundRecipient == null ? "null" : this.FundRecipient.ToString())}");
            toStringOutput.Add($"this.IndustryUsage = {(this.IndustryUsage == null ? "null" : this.IndustryUsage.ToString())}");
            toStringOutput.Add($"this.Installments = {(this.Installments == null ? "null" : this.Installments.ToString())}");
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
            toStringOutput.Add($"LocalizedShopperStatement = {(this.LocalizedShopperStatement == null ? "null" : this.LocalizedShopperStatement.ToString())}");
            toStringOutput.Add($"this.Mandate = {(this.Mandate == null ? "null" : this.Mandate.ToString())}");
            toStringOutput.Add($"this.Mcc = {(this.Mcc == null ? "null" : this.Mcc)}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.MerchantOrderReference = {(this.MerchantOrderReference == null ? "null" : this.MerchantOrderReference)}");
            toStringOutput.Add($"this.MerchantRiskIndicator = {(this.MerchantRiskIndicator == null ? "null" : this.MerchantRiskIndicator.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.MpiData = {(this.MpiData == null ? "null" : this.MpiData.ToString())}");
            toStringOutput.Add($"this.Order = {(this.Order == null ? "null" : this.Order.ToString())}");
            toStringOutput.Add($"this.OrderReference = {(this.OrderReference == null ? "null" : this.OrderReference)}");
            toStringOutput.Add($"this.Origin = {(this.Origin == null ? "null" : this.Origin)}");
            toStringOutput.Add($"PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod.ToString())}");
            toStringOutput.Add($"this.PlatformChargebackLogic = {(this.PlatformChargebackLogic == null ? "null" : this.PlatformChargebackLogic.ToString())}");
            toStringOutput.Add($"this.RecurringExpiry = {(this.RecurringExpiry == null ? "null" : this.RecurringExpiry)}");
            toStringOutput.Add($"this.RecurringFrequency = {(this.RecurringFrequency == null ? "null" : this.RecurringFrequency)}");
            toStringOutput.Add($"this.RecurringProcessingModel = {(this.RecurringProcessingModel == null ? "null" : this.RecurringProcessingModel.ToString())}");
            toStringOutput.Add($"this.RedirectFromIssuerMethod = {(this.RedirectFromIssuerMethod == null ? "null" : this.RedirectFromIssuerMethod)}");
            toStringOutput.Add($"this.RedirectToIssuerMethod = {(this.RedirectToIssuerMethod == null ? "null" : this.RedirectToIssuerMethod)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.ReturnUrl = {(this.ReturnUrl == null ? "null" : this.ReturnUrl)}");
            toStringOutput.Add($"this.RiskData = {(this.RiskData == null ? "null" : this.RiskData.ToString())}");
            toStringOutput.Add($"this.SessionValidity = {(this.SessionValidity == null ? "null" : this.SessionValidity)}");
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
            toStringOutput.Add($"this.StorePaymentMethod = {(this.StorePaymentMethod == null ? "null" : this.StorePaymentMethod.ToString())}");
            toStringOutput.Add($"this.TelephoneNumber = {(this.TelephoneNumber == null ? "null" : this.TelephoneNumber)}");
            toStringOutput.Add($"this.ThreeDS2RequestData = {(this.ThreeDS2RequestData == null ? "null" : this.ThreeDS2RequestData.ToString())}");
            toStringOutput.Add($"this.ThreeDSAuthenticationOnly = {(this.ThreeDSAuthenticationOnly == null ? "null" : this.ThreeDSAuthenticationOnly.ToString())}");
            toStringOutput.Add($"this.TrustedShopper = {(this.TrustedShopper == null ? "null" : this.TrustedShopper.ToString())}");
        }
    }
}