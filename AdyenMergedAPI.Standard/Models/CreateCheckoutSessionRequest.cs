// <copyright file="CreateCheckoutSessionRequest.cs" company="APIMatic">
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
    /// CreateCheckoutSessionRequest.
    /// </summary>
    public class CreateCheckoutSessionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutSessionRequest"/> class.
        /// </summary>
        public CreateCheckoutSessionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutSessionRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="reference">reference.</param>
        /// <param name="returnUrl">returnUrl.</param>
        /// <param name="accountInfo">accountInfo.</param>
        /// <param name="additionalAmount">additionalAmount.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="allowedPaymentMethods">allowedPaymentMethods.</param>
        /// <param name="applicationInfo">applicationInfo.</param>
        /// <param name="authenticationData">authenticationData.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="blockedPaymentMethods">blockedPaymentMethods.</param>
        /// <param name="captureDelayHours">captureDelayHours.</param>
        /// <param name="channel">channel.</param>
        /// <param name="company">company.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="deliverAt">deliverAt.</param>
        /// <param name="deliveryAddress">deliveryAddress.</param>
        /// <param name="enableOneClick">enableOneClick.</param>
        /// <param name="enablePayOut">enablePayOut.</param>
        /// <param name="enableRecurring">enableRecurring.</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="fundOrigin">fundOrigin.</param>
        /// <param name="fundRecipient">fundRecipient.</param>
        /// <param name="installmentOptions">installmentOptions.</param>
        /// <param name="lineItems">lineItems.</param>
        /// <param name="mandate">mandate.</param>
        /// <param name="mcc">mcc.</param>
        /// <param name="merchantOrderReference">merchantOrderReference.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="mode">mode.</param>
        /// <param name="mpiData">mpiData.</param>
        /// <param name="platformChargebackLogic">platformChargebackLogic.</param>
        /// <param name="recurringExpiry">recurringExpiry.</param>
        /// <param name="recurringFrequency">recurringFrequency.</param>
        /// <param name="recurringProcessingModel">recurringProcessingModel.</param>
        /// <param name="redirectFromIssuerMethod">redirectFromIssuerMethod.</param>
        /// <param name="redirectToIssuerMethod">redirectToIssuerMethod.</param>
        /// <param name="riskData">riskData.</param>
        /// <param name="shopperEmail">shopperEmail.</param>
        /// <param name="shopperIP">shopperIP.</param>
        /// <param name="shopperInteraction">shopperInteraction.</param>
        /// <param name="shopperLocale">shopperLocale.</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="shopperReference">shopperReference.</param>
        /// <param name="shopperStatement">shopperStatement.</param>
        /// <param name="showInstallmentAmount">showInstallmentAmount.</param>
        /// <param name="socialSecurityNumber">socialSecurityNumber.</param>
        /// <param name="splitCardFundingSources">splitCardFundingSources.</param>
        /// <param name="splits">splits.</param>
        /// <param name="store">store.</param>
        /// <param name="storePaymentMethod">storePaymentMethod.</param>
        /// <param name="storePaymentMethodMode">storePaymentMethodMode.</param>
        /// <param name="telephoneNumber">telephoneNumber.</param>
        /// <param name="themeId">themeId.</param>
        /// <param name="threeDSAuthenticationOnly">threeDSAuthenticationOnly.</param>
        /// <param name="trustedShopper">trustedShopper.</param>
        public CreateCheckoutSessionRequest(
            Models.Amount16 amount,
            string merchantAccount,
            string reference,
            string returnUrl,
            Models.AccountInfo accountInfo = null,
            Models.Amount1 additionalAmount = null,
            Dictionary<string, string> additionalData = null,
            List<string> allowedPaymentMethods = null,
            Models.ApplicationInfo applicationInfo = null,
            Models.AuthenticationData1 authenticationData = null,
            Models.BillingAddress2 billingAddress = null,
            List<string> blockedPaymentMethods = null,
            int? captureDelayHours = null,
            Models.ChannelEnum? channel = null,
            Models.Company1 company = null,
            string countryCode = null,
            DateTime? dateOfBirth = null,
            DateTime? deliverAt = null,
            Models.DeliveryAddress1 deliveryAddress = null,
            bool? enableOneClick = null,
            bool? enablePayOut = null,
            bool? enableRecurring = null,
            DateTime? expiresAt = null,
            Models.FundOrigin1 fundOrigin = null,
            Models.FundRecipient1 fundRecipient = null,
            Dictionary<string, Models.CheckoutSessionInstallmentOption> installmentOptions = null,
            List<Models.LineItem> lineItems = null,
            Models.Mandate mandate = null,
            string mcc = null,
            string merchantOrderReference = null,
            Dictionary<string, string> metadata = null,
            Models.ModeEnum? mode = Models.ModeEnum.Embedded,
            Models.ThreeDSecureData mpiData = null,
            Models.PlatformChargebackLogic platformChargebackLogic = null,
            string recurringExpiry = null,
            string recurringFrequency = null,
            Models.RecurringProcessingModel1Enum? recurringProcessingModel = null,
            string redirectFromIssuerMethod = null,
            string redirectToIssuerMethod = null,
            Models.RiskData1 riskData = null,
            string shopperEmail = null,
            string shopperIP = null,
            Models.ShopperInteractionEnum? shopperInteraction = null,
            string shopperLocale = null,
            Models.Name3 shopperName = null,
            string shopperReference = null,
            string shopperStatement = null,
            bool? showInstallmentAmount = null,
            string socialSecurityNumber = null,
            bool? splitCardFundingSources = false,
            List<Models.Split> splits = null,
            string store = null,
            bool? storePaymentMethod = null,
            Models.StorePaymentMethodModeEnum? storePaymentMethodMode = null,
            string telephoneNumber = null,
            string themeId = null,
            bool? threeDSAuthenticationOnly = false,
            bool? trustedShopper = null)
        {
            this.AccountInfo = accountInfo;
            this.AdditionalAmount = additionalAmount;
            this.AdditionalData = additionalData;
            this.AllowedPaymentMethods = allowedPaymentMethods;
            this.Amount = amount;
            this.ApplicationInfo = applicationInfo;
            this.AuthenticationData = authenticationData;
            this.BillingAddress = billingAddress;
            this.BlockedPaymentMethods = blockedPaymentMethods;
            this.CaptureDelayHours = captureDelayHours;
            this.Channel = channel;
            this.Company = company;
            this.CountryCode = countryCode;
            this.DateOfBirth = dateOfBirth;
            this.DeliverAt = deliverAt;
            this.DeliveryAddress = deliveryAddress;
            this.EnableOneClick = enableOneClick;
            this.EnablePayOut = enablePayOut;
            this.EnableRecurring = enableRecurring;
            this.ExpiresAt = expiresAt;
            this.FundOrigin = fundOrigin;
            this.FundRecipient = fundRecipient;
            this.InstallmentOptions = installmentOptions;
            this.LineItems = lineItems;
            this.Mandate = mandate;
            this.Mcc = mcc;
            this.MerchantAccount = merchantAccount;
            this.MerchantOrderReference = merchantOrderReference;
            this.Metadata = metadata;
            this.Mode = mode;
            this.MpiData = mpiData;
            this.PlatformChargebackLogic = platformChargebackLogic;
            this.RecurringExpiry = recurringExpiry;
            this.RecurringFrequency = recurringFrequency;
            this.RecurringProcessingModel = recurringProcessingModel;
            this.RedirectFromIssuerMethod = redirectFromIssuerMethod;
            this.RedirectToIssuerMethod = redirectToIssuerMethod;
            this.Reference = reference;
            this.ReturnUrl = returnUrl;
            this.RiskData = riskData;
            this.ShopperEmail = shopperEmail;
            this.ShopperIP = shopperIP;
            this.ShopperInteraction = shopperInteraction;
            this.ShopperLocale = shopperLocale;
            this.ShopperName = shopperName;
            this.ShopperReference = shopperReference;
            this.ShopperStatement = shopperStatement;
            this.ShowInstallmentAmount = showInstallmentAmount;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.SplitCardFundingSources = splitCardFundingSources;
            this.Splits = splits;
            this.Store = store;
            this.StorePaymentMethod = storePaymentMethod;
            this.StorePaymentMethodMode = storePaymentMethodMode;
            this.TelephoneNumber = telephoneNumber;
            this.ThemeId = themeId;
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
        /// List of payment methods to be presented to the shopper. To refer to payment methods, use their [payment method type](https://docs.adyen.com/payment-methods/payment-method-types).
        /// Example: `"allowedPaymentMethods":["ideal","giropay"]`
        /// </summary>
        [JsonProperty("allowedPaymentMethods", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowedPaymentMethods { get; set; }

        /// <summary>
        /// The amount of the payment.
        /// </summary>
        [JsonProperty("amount")]
        public Models.Amount16 Amount { get; set; }

        /// <summary>
        /// Information about your application. For more details, see [Building Adyen solutions](https://docs.adyen.com/development-resources/building-adyen-solutions).
        /// </summary>
        [JsonProperty("applicationInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplicationInfo ApplicationInfo { get; set; }

        /// <summary>
        /// Configuration data for 3DS payments.
        /// </summary>
        [JsonProperty("authenticationData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AuthenticationData1 AuthenticationData { get; set; }

        /// <summary>
        /// The address where to send the invoice.
        /// </summary>
        [JsonProperty("billingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingAddress2 BillingAddress { get; set; }

        /// <summary>
        /// List of payment methods to be hidden from the shopper. To refer to payment methods, use their [payment method type](https://docs.adyen.com/payment-methods/payment-method-types).
        /// Example: `"blockedPaymentMethods":["ideal","giropay"]`
        /// </summary>
        [JsonProperty("blockedPaymentMethods", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BlockedPaymentMethods { get; set; }

        /// <summary>
        /// The delay between the authorisation and scheduled auto-capture, specified in hours.
        /// </summary>
        [JsonProperty("captureDelayHours", NullValueHandling = NullValueHandling.Ignore)]
        public int? CaptureDelayHours { get; set; }

        /// <summary>
        /// The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the `sdkVersion` or `token`.
        /// Possible values:
        /// * **iOS**
        /// * **Android**
        /// * **Web**
        /// </summary>
        [JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChannelEnum? Channel { get; set; }

        /// <summary>
        /// Information regarding the company.
        /// </summary>
        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Company1 Company { get; set; }

        /// <summary>
        /// The shopper's two-letter country code.
        /// </summary>
        [JsonProperty("countryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The shopper's date of birth.
        /// Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("dateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// The date and time when the purchased goods should be delivered.
        /// [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format: YYYY-MM-DDThh:mm:ss+TZD, for example, **2020-12-18T10:15:30+01:00**.
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
        /// The date the session expires in [ISO8601](https://www.iso.org/iso-8601-date-and-time-format.html) format. When not specified, the expiry date is set to 1 hour after session creation. You cannot set the session expiry to more than 24 hours after session creation.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expiresAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpiresAt { get; set; }

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
        /// A set of key-value pairs that specifies the installment options available per payment method. The key must be a payment method name in lowercase. For example, **card** to specify installment options for all cards, or **visa** or **mc**. The value must be an object containing the installment options.
        /// </summary>
        [JsonProperty("installmentOptions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.CheckoutSessionInstallmentOption> InstallmentOptions { get; set; }

        /// <summary>
        /// Price and product information about the purchased items, to be included on the invoice sent to the shopper.
        /// > This field is required for 3x 4x Oney, Affirm, Afterpay, Clearpay, Klarna, Ratepay, and Zip.
        /// </summary>
        [JsonProperty("lineItems", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LineItem> LineItems { get; set; }

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
        /// Metadata consists of entries, each of which includes a key and a value.
        /// Limits:
        /// * Maximum 20 key-value pairs per request.
        /// * Maximum 20 characters per key.
        /// * Maximum 80 characters per value.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Indicates the type of front end integration. Possible values:
        /// * **embedded** (default): Drop-in or Components integration
        /// * **hosted**: Hosted Checkout integration
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ModeEnum? Mode { get; set; }

        /// <summary>
        /// Authentication data produced by an MPI (Mastercard SecureCode, Visa Secure, or Cartes Bancaires).
        /// </summary>
        [JsonProperty("mpiData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDSecureData MpiData { get; set; }

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
        /// Defines a recurring payment type. Required when creating a token to store payment details.
        /// Allowed values:
        /// * `Subscription` – A transaction for a fixed or variable amount, which follows a fixed schedule.
        /// * `CardOnFile` – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.
        /// * `UnscheduledCardOnFile` – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount.
        /// </summary>
        [JsonProperty("recurringProcessingModel", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RecurringProcessingModel1Enum? RecurringProcessingModel { get; set; }

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
        /// The reference to uniquely identify a payment.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The URL to return to when a redirect payment is completed.
        /// </summary>
        [JsonProperty("returnUrl")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Any risk-related settings to apply to the payment.
        /// </summary>
        [JsonProperty("riskData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RiskData1 RiskData { get; set; }

        /// <summary>
        /// The shopper's email address.
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
        /// The shopper's full name. This object is required for some payment methods such as AfterPay, Klarna, or if you're enrolled in the PayPal Seller Protection program.
        /// </summary>
        [JsonProperty("shopperName", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Name3 ShopperName { get; set; }

        /// <summary>
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
        /// Set to true to show the payment amount per installment.
        /// </summary>
        [JsonProperty("showInstallmentAmount", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowInstallmentAmount { get; set; }

        /// <summary>
        /// The shopper's social security number.
        /// </summary>
        [JsonProperty("socialSecurityNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// Boolean value indicating whether the card payment method should be split into separate debit and credit options.
        /// </summary>
        [JsonProperty("splitCardFundingSources", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SplitCardFundingSources { get; set; }

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
        /// When this is set to **true** and the `shopperReference` is provided, the payment details will be stored.
        /// </summary>
        [JsonProperty("storePaymentMethod", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StorePaymentMethod { get; set; }

        /// <summary>
        /// Indicates if the details of the payment method will be stored for the shopper. Possible values:
        /// * **disabled** – No details will be stored (default).
        /// * **askForConsent** – If the `shopperReference` is provided, the UI lets the shopper choose if they want their payment details to be stored.
        /// * **enabled** – If the `shopperReference` is provided, the details will be stored without asking the shopper for consent.
        /// </summary>
        [JsonProperty("storePaymentMethodMode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StorePaymentMethodModeEnum? StorePaymentMethodMode { get; set; }

        /// <summary>
        /// The shopper's telephone number.
        /// </summary>
        [JsonProperty("telephoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Sets a custom theme for [Hosted Checkout](https://docs.adyen.com/online-payments/build-your-integration/?platform=Web&integration=Hosted+Checkout). The value can be any of the **Theme ID** values from your Customer Area.
        /// </summary>
        [JsonProperty("themeId", NullValueHandling = NullValueHandling.Ignore)]
        public string ThemeId { get; set; }

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

            return $"CreateCheckoutSessionRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateCheckoutSessionRequest other &&                ((this.AccountInfo == null && other.AccountInfo == null) || (this.AccountInfo?.Equals(other.AccountInfo) == true)) &&
                ((this.AdditionalAmount == null && other.AdditionalAmount == null) || (this.AdditionalAmount?.Equals(other.AdditionalAmount) == true)) &&
                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.AllowedPaymentMethods == null && other.AllowedPaymentMethods == null) || (this.AllowedPaymentMethods?.Equals(other.AllowedPaymentMethods) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.ApplicationInfo == null && other.ApplicationInfo == null) || (this.ApplicationInfo?.Equals(other.ApplicationInfo) == true)) &&
                ((this.AuthenticationData == null && other.AuthenticationData == null) || (this.AuthenticationData?.Equals(other.AuthenticationData) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.BlockedPaymentMethods == null && other.BlockedPaymentMethods == null) || (this.BlockedPaymentMethods?.Equals(other.BlockedPaymentMethods) == true)) &&
                ((this.CaptureDelayHours == null && other.CaptureDelayHours == null) || (this.CaptureDelayHours?.Equals(other.CaptureDelayHours) == true)) &&
                ((this.Channel == null && other.Channel == null) || (this.Channel?.Equals(other.Channel) == true)) &&
                ((this.Company == null && other.Company == null) || (this.Company?.Equals(other.Company) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.DateOfBirth == null && other.DateOfBirth == null) || (this.DateOfBirth?.Equals(other.DateOfBirth) == true)) &&
                ((this.DeliverAt == null && other.DeliverAt == null) || (this.DeliverAt?.Equals(other.DeliverAt) == true)) &&
                ((this.DeliveryAddress == null && other.DeliveryAddress == null) || (this.DeliveryAddress?.Equals(other.DeliveryAddress) == true)) &&
                ((this.EnableOneClick == null && other.EnableOneClick == null) || (this.EnableOneClick?.Equals(other.EnableOneClick) == true)) &&
                ((this.EnablePayOut == null && other.EnablePayOut == null) || (this.EnablePayOut?.Equals(other.EnablePayOut) == true)) &&
                ((this.EnableRecurring == null && other.EnableRecurring == null) || (this.EnableRecurring?.Equals(other.EnableRecurring) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.FundOrigin == null && other.FundOrigin == null) || (this.FundOrigin?.Equals(other.FundOrigin) == true)) &&
                ((this.FundRecipient == null && other.FundRecipient == null) || (this.FundRecipient?.Equals(other.FundRecipient) == true)) &&
                ((this.InstallmentOptions == null && other.InstallmentOptions == null) || (this.InstallmentOptions?.Equals(other.InstallmentOptions) == true)) &&
                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true)) &&
                ((this.Mandate == null && other.Mandate == null) || (this.Mandate?.Equals(other.Mandate) == true)) &&
                ((this.Mcc == null && other.Mcc == null) || (this.Mcc?.Equals(other.Mcc) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.MerchantOrderReference == null && other.MerchantOrderReference == null) || (this.MerchantOrderReference?.Equals(other.MerchantOrderReference) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Mode == null && other.Mode == null) || (this.Mode?.Equals(other.Mode) == true)) &&
                ((this.MpiData == null && other.MpiData == null) || (this.MpiData?.Equals(other.MpiData) == true)) &&
                ((this.PlatformChargebackLogic == null && other.PlatformChargebackLogic == null) || (this.PlatformChargebackLogic?.Equals(other.PlatformChargebackLogic) == true)) &&
                ((this.RecurringExpiry == null && other.RecurringExpiry == null) || (this.RecurringExpiry?.Equals(other.RecurringExpiry) == true)) &&
                ((this.RecurringFrequency == null && other.RecurringFrequency == null) || (this.RecurringFrequency?.Equals(other.RecurringFrequency) == true)) &&
                ((this.RecurringProcessingModel == null && other.RecurringProcessingModel == null) || (this.RecurringProcessingModel?.Equals(other.RecurringProcessingModel) == true)) &&
                ((this.RedirectFromIssuerMethod == null && other.RedirectFromIssuerMethod == null) || (this.RedirectFromIssuerMethod?.Equals(other.RedirectFromIssuerMethod) == true)) &&
                ((this.RedirectToIssuerMethod == null && other.RedirectToIssuerMethod == null) || (this.RedirectToIssuerMethod?.Equals(other.RedirectToIssuerMethod) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.ReturnUrl == null && other.ReturnUrl == null) || (this.ReturnUrl?.Equals(other.ReturnUrl) == true)) &&
                ((this.RiskData == null && other.RiskData == null) || (this.RiskData?.Equals(other.RiskData) == true)) &&
                ((this.ShopperEmail == null && other.ShopperEmail == null) || (this.ShopperEmail?.Equals(other.ShopperEmail) == true)) &&
                ((this.ShopperIP == null && other.ShopperIP == null) || (this.ShopperIP?.Equals(other.ShopperIP) == true)) &&
                ((this.ShopperInteraction == null && other.ShopperInteraction == null) || (this.ShopperInteraction?.Equals(other.ShopperInteraction) == true)) &&
                ((this.ShopperLocale == null && other.ShopperLocale == null) || (this.ShopperLocale?.Equals(other.ShopperLocale) == true)) &&
                ((this.ShopperName == null && other.ShopperName == null) || (this.ShopperName?.Equals(other.ShopperName) == true)) &&
                ((this.ShopperReference == null && other.ShopperReference == null) || (this.ShopperReference?.Equals(other.ShopperReference) == true)) &&
                ((this.ShopperStatement == null && other.ShopperStatement == null) || (this.ShopperStatement?.Equals(other.ShopperStatement) == true)) &&
                ((this.ShowInstallmentAmount == null && other.ShowInstallmentAmount == null) || (this.ShowInstallmentAmount?.Equals(other.ShowInstallmentAmount) == true)) &&
                ((this.SocialSecurityNumber == null && other.SocialSecurityNumber == null) || (this.SocialSecurityNumber?.Equals(other.SocialSecurityNumber) == true)) &&
                ((this.SplitCardFundingSources == null && other.SplitCardFundingSources == null) || (this.SplitCardFundingSources?.Equals(other.SplitCardFundingSources) == true)) &&
                ((this.Splits == null && other.Splits == null) || (this.Splits?.Equals(other.Splits) == true)) &&
                ((this.Store == null && other.Store == null) || (this.Store?.Equals(other.Store) == true)) &&
                ((this.StorePaymentMethod == null && other.StorePaymentMethod == null) || (this.StorePaymentMethod?.Equals(other.StorePaymentMethod) == true)) &&
                ((this.StorePaymentMethodMode == null && other.StorePaymentMethodMode == null) || (this.StorePaymentMethodMode?.Equals(other.StorePaymentMethodMode) == true)) &&
                ((this.TelephoneNumber == null && other.TelephoneNumber == null) || (this.TelephoneNumber?.Equals(other.TelephoneNumber) == true)) &&
                ((this.ThemeId == null && other.ThemeId == null) || (this.ThemeId?.Equals(other.ThemeId) == true)) &&
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
            toStringOutput.Add($"this.AllowedPaymentMethods = {(this.AllowedPaymentMethods == null ? "null" : $"[{string.Join(", ", this.AllowedPaymentMethods)} ]")}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.ApplicationInfo = {(this.ApplicationInfo == null ? "null" : this.ApplicationInfo.ToString())}");
            toStringOutput.Add($"this.AuthenticationData = {(this.AuthenticationData == null ? "null" : this.AuthenticationData.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.BlockedPaymentMethods = {(this.BlockedPaymentMethods == null ? "null" : $"[{string.Join(", ", this.BlockedPaymentMethods)} ]")}");
            toStringOutput.Add($"this.CaptureDelayHours = {(this.CaptureDelayHours == null ? "null" : this.CaptureDelayHours.ToString())}");
            toStringOutput.Add($"this.Channel = {(this.Channel == null ? "null" : this.Channel.ToString())}");
            toStringOutput.Add($"this.Company = {(this.Company == null ? "null" : this.Company.ToString())}");
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
            toStringOutput.Add($"this.DateOfBirth = {(this.DateOfBirth == null ? "null" : this.DateOfBirth.ToString())}");
            toStringOutput.Add($"this.DeliverAt = {(this.DeliverAt == null ? "null" : this.DeliverAt.ToString())}");
            toStringOutput.Add($"this.DeliveryAddress = {(this.DeliveryAddress == null ? "null" : this.DeliveryAddress.ToString())}");
            toStringOutput.Add($"this.EnableOneClick = {(this.EnableOneClick == null ? "null" : this.EnableOneClick.ToString())}");
            toStringOutput.Add($"this.EnablePayOut = {(this.EnablePayOut == null ? "null" : this.EnablePayOut.ToString())}");
            toStringOutput.Add($"this.EnableRecurring = {(this.EnableRecurring == null ? "null" : this.EnableRecurring.ToString())}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");
            toStringOutput.Add($"this.FundOrigin = {(this.FundOrigin == null ? "null" : this.FundOrigin.ToString())}");
            toStringOutput.Add($"this.FundRecipient = {(this.FundRecipient == null ? "null" : this.FundRecipient.ToString())}");
            toStringOutput.Add($"InstallmentOptions = {(this.InstallmentOptions == null ? "null" : this.InstallmentOptions.ToString())}");
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
            toStringOutput.Add($"this.Mandate = {(this.Mandate == null ? "null" : this.Mandate.ToString())}");
            toStringOutput.Add($"this.Mcc = {(this.Mcc == null ? "null" : this.Mcc)}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.MerchantOrderReference = {(this.MerchantOrderReference == null ? "null" : this.MerchantOrderReference)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Mode = {(this.Mode == null ? "null" : this.Mode.ToString())}");
            toStringOutput.Add($"this.MpiData = {(this.MpiData == null ? "null" : this.MpiData.ToString())}");
            toStringOutput.Add($"this.PlatformChargebackLogic = {(this.PlatformChargebackLogic == null ? "null" : this.PlatformChargebackLogic.ToString())}");
            toStringOutput.Add($"this.RecurringExpiry = {(this.RecurringExpiry == null ? "null" : this.RecurringExpiry)}");
            toStringOutput.Add($"this.RecurringFrequency = {(this.RecurringFrequency == null ? "null" : this.RecurringFrequency)}");
            toStringOutput.Add($"this.RecurringProcessingModel = {(this.RecurringProcessingModel == null ? "null" : this.RecurringProcessingModel.ToString())}");
            toStringOutput.Add($"this.RedirectFromIssuerMethod = {(this.RedirectFromIssuerMethod == null ? "null" : this.RedirectFromIssuerMethod)}");
            toStringOutput.Add($"this.RedirectToIssuerMethod = {(this.RedirectToIssuerMethod == null ? "null" : this.RedirectToIssuerMethod)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.ReturnUrl = {(this.ReturnUrl == null ? "null" : this.ReturnUrl)}");
            toStringOutput.Add($"this.RiskData = {(this.RiskData == null ? "null" : this.RiskData.ToString())}");
            toStringOutput.Add($"this.ShopperEmail = {(this.ShopperEmail == null ? "null" : this.ShopperEmail)}");
            toStringOutput.Add($"this.ShopperIP = {(this.ShopperIP == null ? "null" : this.ShopperIP)}");
            toStringOutput.Add($"this.ShopperInteraction = {(this.ShopperInteraction == null ? "null" : this.ShopperInteraction.ToString())}");
            toStringOutput.Add($"this.ShopperLocale = {(this.ShopperLocale == null ? "null" : this.ShopperLocale)}");
            toStringOutput.Add($"this.ShopperName = {(this.ShopperName == null ? "null" : this.ShopperName.ToString())}");
            toStringOutput.Add($"this.ShopperReference = {(this.ShopperReference == null ? "null" : this.ShopperReference)}");
            toStringOutput.Add($"this.ShopperStatement = {(this.ShopperStatement == null ? "null" : this.ShopperStatement)}");
            toStringOutput.Add($"this.ShowInstallmentAmount = {(this.ShowInstallmentAmount == null ? "null" : this.ShowInstallmentAmount.ToString())}");
            toStringOutput.Add($"this.SocialSecurityNumber = {(this.SocialSecurityNumber == null ? "null" : this.SocialSecurityNumber)}");
            toStringOutput.Add($"this.SplitCardFundingSources = {(this.SplitCardFundingSources == null ? "null" : this.SplitCardFundingSources.ToString())}");
            toStringOutput.Add($"this.Splits = {(this.Splits == null ? "null" : $"[{string.Join(", ", this.Splits)} ]")}");
            toStringOutput.Add($"this.Store = {(this.Store == null ? "null" : this.Store)}");
            toStringOutput.Add($"this.StorePaymentMethod = {(this.StorePaymentMethod == null ? "null" : this.StorePaymentMethod.ToString())}");
            toStringOutput.Add($"this.StorePaymentMethodMode = {(this.StorePaymentMethodMode == null ? "null" : this.StorePaymentMethodMode.ToString())}");
            toStringOutput.Add($"this.TelephoneNumber = {(this.TelephoneNumber == null ? "null" : this.TelephoneNumber)}");
            toStringOutput.Add($"this.ThemeId = {(this.ThemeId == null ? "null" : this.ThemeId)}");
            toStringOutput.Add($"this.ThreeDSAuthenticationOnly = {(this.ThreeDSAuthenticationOnly == null ? "null" : this.ThreeDSAuthenticationOnly.ToString())}");
            toStringOutput.Add($"this.TrustedShopper = {(this.TrustedShopper == null ? "null" : this.TrustedShopper.ToString())}");
        }
    }
}