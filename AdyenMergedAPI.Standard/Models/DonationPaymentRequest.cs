// <copyright file="DonationPaymentRequest.cs" company="APIMatic">
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
    /// DonationPaymentRequest.
    /// </summary>
    public class DonationPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DonationPaymentRequest"/> class.
        /// </summary>
        public DonationPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DonationPaymentRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="reference">reference.</param>
        /// <param name="returnUrl">returnUrl.</param>
        /// <param name="accountInfo">accountInfo.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="applicationInfo">applicationInfo.</param>
        /// <param name="authenticationData">authenticationData.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="browserInfo">browserInfo.</param>
        /// <param name="channel">channel.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="conversionId">conversionId.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="deliverAt">deliverAt.</param>
        /// <param name="deliveryAddress">deliveryAddress.</param>
        /// <param name="deviceFingerprint">deviceFingerprint.</param>
        /// <param name="donationAccount">donationAccount.</param>
        /// <param name="donationOriginalPspReference">donationOriginalPspReference.</param>
        /// <param name="donationToken">donationToken.</param>
        /// <param name="lineItems">lineItems.</param>
        /// <param name="merchantRiskIndicator">merchantRiskIndicator.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="mpiData">mpiData.</param>
        /// <param name="origin">origin.</param>
        /// <param name="recurringProcessingModel">recurringProcessingModel.</param>
        /// <param name="redirectFromIssuerMethod">redirectFromIssuerMethod.</param>
        /// <param name="redirectToIssuerMethod">redirectToIssuerMethod.</param>
        /// <param name="sessionValidity">sessionValidity.</param>
        /// <param name="shopperEmail">shopperEmail.</param>
        /// <param name="shopperIP">shopperIP.</param>
        /// <param name="shopperInteraction">shopperInteraction.</param>
        /// <param name="shopperLocale">shopperLocale.</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="shopperReference">shopperReference.</param>
        /// <param name="socialSecurityNumber">socialSecurityNumber.</param>
        /// <param name="telephoneNumber">telephoneNumber.</param>
        /// <param name="threeDS2RequestData">threeDS2RequestData.</param>
        /// <param name="threeDSAuthenticationOnly">threeDSAuthenticationOnly.</param>
        public DonationPaymentRequest(
            Models.Amount2 amount,
            string merchantAccount,
            DonationPaymentRequestPaymentMethod paymentMethod,
            string reference,
            string returnUrl,
            Models.AccountInfo accountInfo = null,
            Dictionary<string, string> additionalData = null,
            Models.ApplicationInfo applicationInfo = null,
            Models.AuthenticationData3 authenticationData = null,
            Models.BillingAddress4 billingAddress = null,
            Models.BrowserInfo browserInfo = null,
            Models.Channel2Enum? channel = null,
            string checkoutAttemptId = null,
            string conversionId = null,
            string countryCode = null,
            DateTime? dateOfBirth = null,
            DateTime? deliverAt = null,
            Models.DeliveryAddress1 deliveryAddress = null,
            string deviceFingerprint = null,
            string donationAccount = null,
            string donationOriginalPspReference = null,
            string donationToken = null,
            List<Models.LineItem> lineItems = null,
            Models.MerchantRiskIndicator1 merchantRiskIndicator = null,
            Dictionary<string, string> metadata = null,
            Models.ThreeDSecureData mpiData = null,
            string origin = null,
            Models.RecurringProcessingModelEnum? recurringProcessingModel = null,
            string redirectFromIssuerMethod = null,
            string redirectToIssuerMethod = null,
            string sessionValidity = null,
            string shopperEmail = null,
            string shopperIP = null,
            Models.ShopperInteractionEnum? shopperInteraction = null,
            string shopperLocale = null,
            Models.Name5 shopperName = null,
            string shopperReference = null,
            string socialSecurityNumber = null,
            string telephoneNumber = null,
            Models.ThreeDS2RequestFields1 threeDS2RequestData = null,
            bool? threeDSAuthenticationOnly = false)
        {
            this.AccountInfo = accountInfo;
            this.AdditionalData = additionalData;
            this.Amount = amount;
            this.ApplicationInfo = applicationInfo;
            this.AuthenticationData = authenticationData;
            this.BillingAddress = billingAddress;
            this.BrowserInfo = browserInfo;
            this.Channel = channel;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.ConversionId = conversionId;
            this.CountryCode = countryCode;
            this.DateOfBirth = dateOfBirth;
            this.DeliverAt = deliverAt;
            this.DeliveryAddress = deliveryAddress;
            this.DeviceFingerprint = deviceFingerprint;
            this.DonationAccount = donationAccount;
            this.DonationOriginalPspReference = donationOriginalPspReference;
            this.DonationToken = donationToken;
            this.LineItems = lineItems;
            this.MerchantAccount = merchantAccount;
            this.MerchantRiskIndicator = merchantRiskIndicator;
            this.Metadata = metadata;
            this.MpiData = mpiData;
            this.Origin = origin;
            this.PaymentMethod = paymentMethod;
            this.RecurringProcessingModel = recurringProcessingModel;
            this.RedirectFromIssuerMethod = redirectFromIssuerMethod;
            this.RedirectToIssuerMethod = redirectToIssuerMethod;
            this.Reference = reference;
            this.ReturnUrl = returnUrl;
            this.SessionValidity = sessionValidity;
            this.ShopperEmail = shopperEmail;
            this.ShopperIP = shopperIP;
            this.ShopperInteraction = shopperInteraction;
            this.ShopperLocale = shopperLocale;
            this.ShopperName = shopperName;
            this.ShopperReference = shopperReference;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.TelephoneNumber = telephoneNumber;
            this.ThreeDS2RequestData = threeDS2RequestData;
            this.ThreeDSAuthenticationOnly = threeDSAuthenticationOnly;
        }

        /// <summary>
        /// Shopper account information for 3D Secure 2.
        /// > For 3D Secure 2 transactions, we recommend that you include this object to increase the chances of achieving a frictionless flow.
        /// </summary>
        [JsonProperty("accountInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountInfo AccountInfo { get; set; }

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
        /// A string containing the shopper's device fingerprint. For more information, refer to [Device fingerprinting](https://docs.adyen.com/risk-management/device-fingerprinting).
        /// </summary>
        [JsonProperty("deviceFingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceFingerprint { get; set; }

        /// <summary>
        /// Donation account to which the transaction is credited.
        /// </summary>
        [JsonProperty("donationAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string DonationAccount { get; set; }

        /// <summary>
        /// PSP reference of the transaction from which the donation token is generated. Required when `donationToken` is provided.
        /// </summary>
        [JsonProperty("donationOriginalPspReference", NullValueHandling = NullValueHandling.Ignore)]
        public string DonationOriginalPspReference { get; set; }

        /// <summary>
        /// Donation token received in the `/payments` call.
        /// </summary>
        [JsonProperty("donationToken", NullValueHandling = NullValueHandling.Ignore)]
        public string DonationToken { get; set; }

        /// <summary>
        /// Price and product information about the purchased items, to be included on the invoice sent to the shopper.
        /// > This field is required for 3x 4x Oney, Affirm, Afterpay, Clearpay, Klarna, Ratepay, and Zip.
        /// </summary>
        [JsonProperty("lineItems", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LineItem> LineItems { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        [JsonProperty("merchantAccount")]
        public string MerchantAccount { get; set; }

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
        /// Required for the 3D Secure 2 `channel` **Web** integration.
        /// Set this parameter to the origin URL of the page that you are loading the 3D Secure Component from.
        /// </summary>
        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public string Origin { get; set; }

        /// <summary>
        /// The type and required details of a payment method to use.
        /// </summary>
        [JsonProperty("paymentMethod")]
        public DonationPaymentRequestPaymentMethod PaymentMethod { get; set; }

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
        /// The format depends on the channel. This URL can have a maximum of 1024 characters.
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
        /// The shopper's social security number.
        /// </summary>
        [JsonProperty("socialSecurityNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SocialSecurityNumber { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DonationPaymentRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is DonationPaymentRequest other &&                ((this.AccountInfo == null && other.AccountInfo == null) || (this.AccountInfo?.Equals(other.AccountInfo) == true)) &&
                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.ApplicationInfo == null && other.ApplicationInfo == null) || (this.ApplicationInfo?.Equals(other.ApplicationInfo) == true)) &&
                ((this.AuthenticationData == null && other.AuthenticationData == null) || (this.AuthenticationData?.Equals(other.AuthenticationData) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.BrowserInfo == null && other.BrowserInfo == null) || (this.BrowserInfo?.Equals(other.BrowserInfo) == true)) &&
                ((this.Channel == null && other.Channel == null) || (this.Channel?.Equals(other.Channel) == true)) &&
                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.ConversionId == null && other.ConversionId == null) || (this.ConversionId?.Equals(other.ConversionId) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.DateOfBirth == null && other.DateOfBirth == null) || (this.DateOfBirth?.Equals(other.DateOfBirth) == true)) &&
                ((this.DeliverAt == null && other.DeliverAt == null) || (this.DeliverAt?.Equals(other.DeliverAt) == true)) &&
                ((this.DeliveryAddress == null && other.DeliveryAddress == null) || (this.DeliveryAddress?.Equals(other.DeliveryAddress) == true)) &&
                ((this.DeviceFingerprint == null && other.DeviceFingerprint == null) || (this.DeviceFingerprint?.Equals(other.DeviceFingerprint) == true)) &&
                ((this.DonationAccount == null && other.DonationAccount == null) || (this.DonationAccount?.Equals(other.DonationAccount) == true)) &&
                ((this.DonationOriginalPspReference == null && other.DonationOriginalPspReference == null) || (this.DonationOriginalPspReference?.Equals(other.DonationOriginalPspReference) == true)) &&
                ((this.DonationToken == null && other.DonationToken == null) || (this.DonationToken?.Equals(other.DonationToken) == true)) &&
                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.MerchantRiskIndicator == null && other.MerchantRiskIndicator == null) || (this.MerchantRiskIndicator?.Equals(other.MerchantRiskIndicator) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.MpiData == null && other.MpiData == null) || (this.MpiData?.Equals(other.MpiData) == true)) &&
                ((this.Origin == null && other.Origin == null) || (this.Origin?.Equals(other.Origin) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.RecurringProcessingModel == null && other.RecurringProcessingModel == null) || (this.RecurringProcessingModel?.Equals(other.RecurringProcessingModel) == true)) &&
                ((this.RedirectFromIssuerMethod == null && other.RedirectFromIssuerMethod == null) || (this.RedirectFromIssuerMethod?.Equals(other.RedirectFromIssuerMethod) == true)) &&
                ((this.RedirectToIssuerMethod == null && other.RedirectToIssuerMethod == null) || (this.RedirectToIssuerMethod?.Equals(other.RedirectToIssuerMethod) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.ReturnUrl == null && other.ReturnUrl == null) || (this.ReturnUrl?.Equals(other.ReturnUrl) == true)) &&
                ((this.SessionValidity == null && other.SessionValidity == null) || (this.SessionValidity?.Equals(other.SessionValidity) == true)) &&
                ((this.ShopperEmail == null && other.ShopperEmail == null) || (this.ShopperEmail?.Equals(other.ShopperEmail) == true)) &&
                ((this.ShopperIP == null && other.ShopperIP == null) || (this.ShopperIP?.Equals(other.ShopperIP) == true)) &&
                ((this.ShopperInteraction == null && other.ShopperInteraction == null) || (this.ShopperInteraction?.Equals(other.ShopperInteraction) == true)) &&
                ((this.ShopperLocale == null && other.ShopperLocale == null) || (this.ShopperLocale?.Equals(other.ShopperLocale) == true)) &&
                ((this.ShopperName == null && other.ShopperName == null) || (this.ShopperName?.Equals(other.ShopperName) == true)) &&
                ((this.ShopperReference == null && other.ShopperReference == null) || (this.ShopperReference?.Equals(other.ShopperReference) == true)) &&
                ((this.SocialSecurityNumber == null && other.SocialSecurityNumber == null) || (this.SocialSecurityNumber?.Equals(other.SocialSecurityNumber) == true)) &&
                ((this.TelephoneNumber == null && other.TelephoneNumber == null) || (this.TelephoneNumber?.Equals(other.TelephoneNumber) == true)) &&
                ((this.ThreeDS2RequestData == null && other.ThreeDS2RequestData == null) || (this.ThreeDS2RequestData?.Equals(other.ThreeDS2RequestData) == true)) &&
                ((this.ThreeDSAuthenticationOnly == null && other.ThreeDSAuthenticationOnly == null) || (this.ThreeDSAuthenticationOnly?.Equals(other.ThreeDSAuthenticationOnly) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountInfo = {(this.AccountInfo == null ? "null" : this.AccountInfo.ToString())}");
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.ApplicationInfo = {(this.ApplicationInfo == null ? "null" : this.ApplicationInfo.ToString())}");
            toStringOutput.Add($"this.AuthenticationData = {(this.AuthenticationData == null ? "null" : this.AuthenticationData.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.BrowserInfo = {(this.BrowserInfo == null ? "null" : this.BrowserInfo.ToString())}");
            toStringOutput.Add($"this.Channel = {(this.Channel == null ? "null" : this.Channel.ToString())}");
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.ConversionId = {(this.ConversionId == null ? "null" : this.ConversionId)}");
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
            toStringOutput.Add($"this.DateOfBirth = {(this.DateOfBirth == null ? "null" : this.DateOfBirth.ToString())}");
            toStringOutput.Add($"this.DeliverAt = {(this.DeliverAt == null ? "null" : this.DeliverAt.ToString())}");
            toStringOutput.Add($"this.DeliveryAddress = {(this.DeliveryAddress == null ? "null" : this.DeliveryAddress.ToString())}");
            toStringOutput.Add($"this.DeviceFingerprint = {(this.DeviceFingerprint == null ? "null" : this.DeviceFingerprint)}");
            toStringOutput.Add($"this.DonationAccount = {(this.DonationAccount == null ? "null" : this.DonationAccount)}");
            toStringOutput.Add($"this.DonationOriginalPspReference = {(this.DonationOriginalPspReference == null ? "null" : this.DonationOriginalPspReference)}");
            toStringOutput.Add($"this.DonationToken = {(this.DonationToken == null ? "null" : this.DonationToken)}");
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.MerchantRiskIndicator = {(this.MerchantRiskIndicator == null ? "null" : this.MerchantRiskIndicator.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.MpiData = {(this.MpiData == null ? "null" : this.MpiData.ToString())}");
            toStringOutput.Add($"this.Origin = {(this.Origin == null ? "null" : this.Origin)}");
            toStringOutput.Add($"PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod.ToString())}");
            toStringOutput.Add($"this.RecurringProcessingModel = {(this.RecurringProcessingModel == null ? "null" : this.RecurringProcessingModel.ToString())}");
            toStringOutput.Add($"this.RedirectFromIssuerMethod = {(this.RedirectFromIssuerMethod == null ? "null" : this.RedirectFromIssuerMethod)}");
            toStringOutput.Add($"this.RedirectToIssuerMethod = {(this.RedirectToIssuerMethod == null ? "null" : this.RedirectToIssuerMethod)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.ReturnUrl = {(this.ReturnUrl == null ? "null" : this.ReturnUrl)}");
            toStringOutput.Add($"this.SessionValidity = {(this.SessionValidity == null ? "null" : this.SessionValidity)}");
            toStringOutput.Add($"this.ShopperEmail = {(this.ShopperEmail == null ? "null" : this.ShopperEmail)}");
            toStringOutput.Add($"this.ShopperIP = {(this.ShopperIP == null ? "null" : this.ShopperIP)}");
            toStringOutput.Add($"this.ShopperInteraction = {(this.ShopperInteraction == null ? "null" : this.ShopperInteraction.ToString())}");
            toStringOutput.Add($"this.ShopperLocale = {(this.ShopperLocale == null ? "null" : this.ShopperLocale)}");
            toStringOutput.Add($"this.ShopperName = {(this.ShopperName == null ? "null" : this.ShopperName.ToString())}");
            toStringOutput.Add($"this.ShopperReference = {(this.ShopperReference == null ? "null" : this.ShopperReference)}");
            toStringOutput.Add($"this.SocialSecurityNumber = {(this.SocialSecurityNumber == null ? "null" : this.SocialSecurityNumber)}");
            toStringOutput.Add($"this.TelephoneNumber = {(this.TelephoneNumber == null ? "null" : this.TelephoneNumber)}");
            toStringOutput.Add($"this.ThreeDS2RequestData = {(this.ThreeDS2RequestData == null ? "null" : this.ThreeDS2RequestData.ToString())}");
            toStringOutput.Add($"this.ThreeDSAuthenticationOnly = {(this.ThreeDSAuthenticationOnly == null ? "null" : this.ThreeDSAuthenticationOnly.ToString())}");
        }
    }
}