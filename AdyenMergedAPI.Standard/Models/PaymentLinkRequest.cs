// <copyright file="PaymentLinkRequest.cs" company="APIMatic">
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
    /// PaymentLinkRequest.
    /// </summary>
    public class PaymentLinkRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLinkRequest"/> class.
        /// </summary>
        public PaymentLinkRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLinkRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="reference">reference.</param>
        /// <param name="allowedPaymentMethods">allowedPaymentMethods.</param>
        /// <param name="applicationInfo">applicationInfo.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="blockedPaymentMethods">blockedPaymentMethods.</param>
        /// <param name="captureDelayHours">captureDelayHours.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="deliverAt">deliverAt.</param>
        /// <param name="deliveryAddress">deliveryAddress.</param>
        /// <param name="description">description.</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="installmentOptions">installmentOptions.</param>
        /// <param name="lineItems">lineItems.</param>
        /// <param name="manualCapture">manualCapture.</param>
        /// <param name="mcc">mcc.</param>
        /// <param name="merchantOrderReference">merchantOrderReference.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="recurringProcessingModel">recurringProcessingModel.</param>
        /// <param name="requiredShopperFields">requiredShopperFields.</param>
        /// <param name="returnUrl">returnUrl.</param>
        /// <param name="reusable">reusable.</param>
        /// <param name="riskData">riskData.</param>
        /// <param name="shopperEmail">shopperEmail.</param>
        /// <param name="shopperLocale">shopperLocale.</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="shopperReference">shopperReference.</param>
        /// <param name="shopperStatement">shopperStatement.</param>
        /// <param name="showRemovePaymentMethodButton">showRemovePaymentMethodButton.</param>
        /// <param name="socialSecurityNumber">socialSecurityNumber.</param>
        /// <param name="splitCardFundingSources">splitCardFundingSources.</param>
        /// <param name="splits">splits.</param>
        /// <param name="store">store.</param>
        /// <param name="storePaymentMethodMode">storePaymentMethodMode.</param>
        /// <param name="telephoneNumber">telephoneNumber.</param>
        /// <param name="themeId">themeId.</param>
        public PaymentLinkRequest(
            Models.Amount30 amount,
            string merchantAccount,
            string reference,
            List<string> allowedPaymentMethods = null,
            Models.ApplicationInfo applicationInfo = null,
            Models.Address billingAddress = null,
            List<string> blockedPaymentMethods = null,
            int? captureDelayHours = null,
            string countryCode = null,
            DateTime? dateOfBirth = null,
            DateTime? deliverAt = null,
            Models.Address2 deliveryAddress = null,
            string description = null,
            DateTime? expiresAt = null,
            Dictionary<string, Models.InstallmentOption> installmentOptions = null,
            List<Models.LineItem> lineItems = null,
            bool? manualCapture = null,
            string mcc = null,
            string merchantOrderReference = null,
            Dictionary<string, string> metadata = null,
            Models.RecurringProcessingModel4Enum? recurringProcessingModel = null,
            List<Models.RequiredShopperFieldEnum> requiredShopperFields = null,
            string returnUrl = null,
            bool? reusable = null,
            Models.RiskData1 riskData = null,
            string shopperEmail = null,
            string shopperLocale = null,
            Models.Name3 shopperName = null,
            string shopperReference = null,
            string shopperStatement = null,
            bool? showRemovePaymentMethodButton = true,
            string socialSecurityNumber = null,
            bool? splitCardFundingSources = false,
            List<Models.Split> splits = null,
            string store = null,
            Models.StorePaymentMethodMode2Enum? storePaymentMethodMode = null,
            string telephoneNumber = null,
            string themeId = null)
        {
            this.AllowedPaymentMethods = allowedPaymentMethods;
            this.Amount = amount;
            this.ApplicationInfo = applicationInfo;
            this.BillingAddress = billingAddress;
            this.BlockedPaymentMethods = blockedPaymentMethods;
            this.CaptureDelayHours = captureDelayHours;
            this.CountryCode = countryCode;
            this.DateOfBirth = dateOfBirth;
            this.DeliverAt = deliverAt;
            this.DeliveryAddress = deliveryAddress;
            this.Description = description;
            this.ExpiresAt = expiresAt;
            this.InstallmentOptions = installmentOptions;
            this.LineItems = lineItems;
            this.ManualCapture = manualCapture;
            this.Mcc = mcc;
            this.MerchantAccount = merchantAccount;
            this.MerchantOrderReference = merchantOrderReference;
            this.Metadata = metadata;
            this.RecurringProcessingModel = recurringProcessingModel;
            this.Reference = reference;
            this.RequiredShopperFields = requiredShopperFields;
            this.ReturnUrl = returnUrl;
            this.Reusable = reusable;
            this.RiskData = riskData;
            this.ShopperEmail = shopperEmail;
            this.ShopperLocale = shopperLocale;
            this.ShopperName = shopperName;
            this.ShopperReference = shopperReference;
            this.ShopperStatement = shopperStatement;
            this.ShowRemovePaymentMethodButton = showRemovePaymentMethodButton;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.SplitCardFundingSources = splitCardFundingSources;
            this.Splits = splits;
            this.Store = store;
            this.StorePaymentMethodMode = storePaymentMethodMode;
            this.TelephoneNumber = telephoneNumber;
            this.ThemeId = themeId;
        }

        /// <summary>
        /// List of payment methods to be presented to the shopper. To refer to payment methods, use their [payment method type](https://docs.adyen.com/payment-methods/payment-method-types).
        /// Example: `"allowedPaymentMethods":["ideal","giropay"]`
        /// </summary>
        [JsonProperty("allowedPaymentMethods", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowedPaymentMethods { get; set; }

        /// <summary>
        /// The payment amount and currency.
        /// </summary>
        [JsonProperty("amount")]
        public Models.Amount30 Amount { get; set; }

        /// <summary>
        /// Information about your application. For more details, see [Building Adyen solutions](https://docs.adyen.com/development-resources/building-adyen-solutions).
        /// </summary>
        [JsonProperty("applicationInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplicationInfo ApplicationInfo { get; set; }

        /// <summary>
        /// The address where to send the invoice.
        /// </summary>
        [JsonProperty("billingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address BillingAddress { get; set; }

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
        public Models.Address2 DeliveryAddress { get; set; }

        /// <summary>
        /// A short description visible on the payment page.
        /// Maximum length: 280 characters.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The date when the payment link expires.
        /// [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format with time zone offset: YYYY-MM-DDThh:mm:ss+TZD, for example, **2020-12-18T10:15:30+01:00**.
        /// The maximum expiry date is 70 days after the payment link is created.
        /// If not provided, the payment link expires 24 hours after it was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expiresAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// A set of key-value pairs that specifies the installment options available per payment method. The key must be a payment method name in lowercase. For example, **card** to specify installment options for all cards, or **visa** or **mc**. The value must be an object containing the installment options.
        /// </summary>
        [JsonProperty("installmentOptions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.InstallmentOption> InstallmentOptions { get; set; }

        /// <summary>
        /// Price and product information about the purchased items, to be included on the invoice sent to the shopper.
        /// This parameter is required for open invoice (_buy now, pay later_) payment methods such Afterpay, Clearpay, Klarna, RatePay, and Zip.
        /// </summary>
        [JsonProperty("lineItems", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LineItem> LineItems { get; set; }

        /// <summary>
        /// Indicates if the payment must be [captured manually](https://docs.adyen.com/online-payments/capture).
        /// </summary>
        [JsonProperty("manualCapture", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ManualCapture { get; set; }

        /// <summary>
        /// The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.
        /// </summary>
        [JsonProperty("mcc", NullValueHandling = NullValueHandling.Ignore)]
        public string Mcc { get; set; }

        /// <summary>
        /// The merchant account identifier for which the payment link is created.
        /// </summary>
        [JsonProperty("merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// This reference allows linking multiple transactions to each other for reporting purposes (for example, order auth-rate). The reference should be unique per billing cycle.
        /// </summary>
        [JsonProperty("merchantOrderReference", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantOrderReference { get; set; }

        /// <summary>
        /// Metadata consists of entries, each of which includes a key and a value.
        /// Limitations:
        /// * Maximum 20 key-value pairs per request. Otherwise, error "177" occurs: "Metadata size exceeds limit"
        /// * Maximum 20 characters per key. Otherwise, error "178" occurs: "Metadata key size exceeds limit"
        /// * A key cannot have the name `checkout.linkId`. Any value that you provide with this key is going to be replaced by the real payment link ID.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Defines a recurring payment type. Required when `storePaymentMethodMode` is set to **askForConsent** or **enabled**.
        /// Possible values:
        /// * **Subscription** – A transaction for a fixed or variable amount, which follows a fixed schedule.
        /// * **CardOnFile** – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.
        /// * **UnscheduledCardOnFile** – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or has variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount.
        /// </summary>
        [JsonProperty("recurringProcessingModel", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RecurringProcessingModel4Enum? RecurringProcessingModel { get; set; }

        /// <summary>
        /// A reference that is used to uniquely identify the payment in future communications about the payment status.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// List of fields that the shopper has to provide on the payment page before completing the payment. For more information, refer to [Provide shopper information](https://docs.adyen.com/unified-commerce/pay-by-link/payment-links/api#shopper-information).
        /// Possible values:
        /// * **billingAddress** – The address where to send the invoice.
        /// * **deliveryAddress** – The address where the purchased goods should be delivered.
        /// * **shopperEmail** – The shopper's email address.
        /// * **shopperName** – The shopper's full name.
        /// * **telephoneNumber** – The shopper's phone number.
        /// </summary>
        [JsonProperty("requiredShopperFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RequiredShopperFieldEnum> RequiredShopperFields { get; set; }

        /// <summary>
        /// Website URL used for redirection after payment is completed.
        /// If provided, a **Continue** button will be shown on the payment page. If shoppers select the button, they are redirected to the specified URL.
        /// </summary>
        [JsonProperty("returnUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Indicates whether the payment link can be reused for multiple payments. If not provided, this defaults to **false** which means the link can be used for one successful payment only.
        /// </summary>
        [JsonProperty("reusable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reusable { get; set; }

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
        /// The language to be used in the payment page, specified by a combination of a language and country code. For example, `en-US`.
        /// For a list of shopper locales that Pay by Link supports, refer to [Language and localization](https://docs.adyen.com/unified-commerce/pay-by-link/payment-links/api#language).
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
        /// Set to **false** to hide the button that lets the shopper remove a stored payment method.
        /// </summary>
        [JsonProperty("showRemovePaymentMethodButton", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowRemovePaymentMethodButton { get; set; }

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
        /// The physical store, for which this payment is processed.
        /// </summary>
        [JsonProperty("store", NullValueHandling = NullValueHandling.Ignore)]
        public string Store { get; set; }

        /// <summary>
        /// Indicates if the details of the payment method will be stored for the shopper. Possible values:
        /// * **disabled** – No details will be stored (default).
        /// * **askForConsent** – If the `shopperReference` is provided, the UI lets the shopper choose if they want their payment details to be stored.
        /// * **enabled** – If the `shopperReference` is provided, the details will be stored without asking the shopper for consent.
        ///  When set to **askForConsent** or **enabled**, you must also include the `recurringProcessingModel` parameter.
        /// </summary>
        [JsonProperty("storePaymentMethodMode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StorePaymentMethodMode2Enum? StorePaymentMethodMode { get; set; }

        /// <summary>
        /// The shopper's telephone number.
        /// </summary>
        [JsonProperty("telephoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// A [theme](https://docs.adyen.com/unified-commerce/pay-by-link/payment-links/api#themes) to customize the appearance of the payment page. If not specified, the payment page is rendered according to the theme set as default in your Customer Area.
        /// </summary>
        [JsonProperty("themeId", NullValueHandling = NullValueHandling.Ignore)]
        public string ThemeId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentLinkRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentLinkRequest other &&                ((this.AllowedPaymentMethods == null && other.AllowedPaymentMethods == null) || (this.AllowedPaymentMethods?.Equals(other.AllowedPaymentMethods) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.ApplicationInfo == null && other.ApplicationInfo == null) || (this.ApplicationInfo?.Equals(other.ApplicationInfo) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.BlockedPaymentMethods == null && other.BlockedPaymentMethods == null) || (this.BlockedPaymentMethods?.Equals(other.BlockedPaymentMethods) == true)) &&
                ((this.CaptureDelayHours == null && other.CaptureDelayHours == null) || (this.CaptureDelayHours?.Equals(other.CaptureDelayHours) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.DateOfBirth == null && other.DateOfBirth == null) || (this.DateOfBirth?.Equals(other.DateOfBirth) == true)) &&
                ((this.DeliverAt == null && other.DeliverAt == null) || (this.DeliverAt?.Equals(other.DeliverAt) == true)) &&
                ((this.DeliveryAddress == null && other.DeliveryAddress == null) || (this.DeliveryAddress?.Equals(other.DeliveryAddress) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.InstallmentOptions == null && other.InstallmentOptions == null) || (this.InstallmentOptions?.Equals(other.InstallmentOptions) == true)) &&
                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true)) &&
                ((this.ManualCapture == null && other.ManualCapture == null) || (this.ManualCapture?.Equals(other.ManualCapture) == true)) &&
                ((this.Mcc == null && other.Mcc == null) || (this.Mcc?.Equals(other.Mcc) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.MerchantOrderReference == null && other.MerchantOrderReference == null) || (this.MerchantOrderReference?.Equals(other.MerchantOrderReference) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.RecurringProcessingModel == null && other.RecurringProcessingModel == null) || (this.RecurringProcessingModel?.Equals(other.RecurringProcessingModel) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.RequiredShopperFields == null && other.RequiredShopperFields == null) || (this.RequiredShopperFields?.Equals(other.RequiredShopperFields) == true)) &&
                ((this.ReturnUrl == null && other.ReturnUrl == null) || (this.ReturnUrl?.Equals(other.ReturnUrl) == true)) &&
                ((this.Reusable == null && other.Reusable == null) || (this.Reusable?.Equals(other.Reusable) == true)) &&
                ((this.RiskData == null && other.RiskData == null) || (this.RiskData?.Equals(other.RiskData) == true)) &&
                ((this.ShopperEmail == null && other.ShopperEmail == null) || (this.ShopperEmail?.Equals(other.ShopperEmail) == true)) &&
                ((this.ShopperLocale == null && other.ShopperLocale == null) || (this.ShopperLocale?.Equals(other.ShopperLocale) == true)) &&
                ((this.ShopperName == null && other.ShopperName == null) || (this.ShopperName?.Equals(other.ShopperName) == true)) &&
                ((this.ShopperReference == null && other.ShopperReference == null) || (this.ShopperReference?.Equals(other.ShopperReference) == true)) &&
                ((this.ShopperStatement == null && other.ShopperStatement == null) || (this.ShopperStatement?.Equals(other.ShopperStatement) == true)) &&
                ((this.ShowRemovePaymentMethodButton == null && other.ShowRemovePaymentMethodButton == null) || (this.ShowRemovePaymentMethodButton?.Equals(other.ShowRemovePaymentMethodButton) == true)) &&
                ((this.SocialSecurityNumber == null && other.SocialSecurityNumber == null) || (this.SocialSecurityNumber?.Equals(other.SocialSecurityNumber) == true)) &&
                ((this.SplitCardFundingSources == null && other.SplitCardFundingSources == null) || (this.SplitCardFundingSources?.Equals(other.SplitCardFundingSources) == true)) &&
                ((this.Splits == null && other.Splits == null) || (this.Splits?.Equals(other.Splits) == true)) &&
                ((this.Store == null && other.Store == null) || (this.Store?.Equals(other.Store) == true)) &&
                ((this.StorePaymentMethodMode == null && other.StorePaymentMethodMode == null) || (this.StorePaymentMethodMode?.Equals(other.StorePaymentMethodMode) == true)) &&
                ((this.TelephoneNumber == null && other.TelephoneNumber == null) || (this.TelephoneNumber?.Equals(other.TelephoneNumber) == true)) &&
                ((this.ThemeId == null && other.ThemeId == null) || (this.ThemeId?.Equals(other.ThemeId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AllowedPaymentMethods = {(this.AllowedPaymentMethods == null ? "null" : $"[{string.Join(", ", this.AllowedPaymentMethods)} ]")}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.ApplicationInfo = {(this.ApplicationInfo == null ? "null" : this.ApplicationInfo.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.BlockedPaymentMethods = {(this.BlockedPaymentMethods == null ? "null" : $"[{string.Join(", ", this.BlockedPaymentMethods)} ]")}");
            toStringOutput.Add($"this.CaptureDelayHours = {(this.CaptureDelayHours == null ? "null" : this.CaptureDelayHours.ToString())}");
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
            toStringOutput.Add($"this.DateOfBirth = {(this.DateOfBirth == null ? "null" : this.DateOfBirth.ToString())}");
            toStringOutput.Add($"this.DeliverAt = {(this.DeliverAt == null ? "null" : this.DeliverAt.ToString())}");
            toStringOutput.Add($"this.DeliveryAddress = {(this.DeliveryAddress == null ? "null" : this.DeliveryAddress.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");
            toStringOutput.Add($"InstallmentOptions = {(this.InstallmentOptions == null ? "null" : this.InstallmentOptions.ToString())}");
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
            toStringOutput.Add($"this.ManualCapture = {(this.ManualCapture == null ? "null" : this.ManualCapture.ToString())}");
            toStringOutput.Add($"this.Mcc = {(this.Mcc == null ? "null" : this.Mcc)}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.MerchantOrderReference = {(this.MerchantOrderReference == null ? "null" : this.MerchantOrderReference)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.RecurringProcessingModel = {(this.RecurringProcessingModel == null ? "null" : this.RecurringProcessingModel.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.RequiredShopperFields = {(this.RequiredShopperFields == null ? "null" : $"[{string.Join(", ", this.RequiredShopperFields)} ]")}");
            toStringOutput.Add($"this.ReturnUrl = {(this.ReturnUrl == null ? "null" : this.ReturnUrl)}");
            toStringOutput.Add($"this.Reusable = {(this.Reusable == null ? "null" : this.Reusable.ToString())}");
            toStringOutput.Add($"this.RiskData = {(this.RiskData == null ? "null" : this.RiskData.ToString())}");
            toStringOutput.Add($"this.ShopperEmail = {(this.ShopperEmail == null ? "null" : this.ShopperEmail)}");
            toStringOutput.Add($"this.ShopperLocale = {(this.ShopperLocale == null ? "null" : this.ShopperLocale)}");
            toStringOutput.Add($"this.ShopperName = {(this.ShopperName == null ? "null" : this.ShopperName.ToString())}");
            toStringOutput.Add($"this.ShopperReference = {(this.ShopperReference == null ? "null" : this.ShopperReference)}");
            toStringOutput.Add($"this.ShopperStatement = {(this.ShopperStatement == null ? "null" : this.ShopperStatement)}");
            toStringOutput.Add($"this.ShowRemovePaymentMethodButton = {(this.ShowRemovePaymentMethodButton == null ? "null" : this.ShowRemovePaymentMethodButton.ToString())}");
            toStringOutput.Add($"this.SocialSecurityNumber = {(this.SocialSecurityNumber == null ? "null" : this.SocialSecurityNumber)}");
            toStringOutput.Add($"this.SplitCardFundingSources = {(this.SplitCardFundingSources == null ? "null" : this.SplitCardFundingSources.ToString())}");
            toStringOutput.Add($"this.Splits = {(this.Splits == null ? "null" : $"[{string.Join(", ", this.Splits)} ]")}");
            toStringOutput.Add($"this.Store = {(this.Store == null ? "null" : this.Store)}");
            toStringOutput.Add($"this.StorePaymentMethodMode = {(this.StorePaymentMethodMode == null ? "null" : this.StorePaymentMethodMode.ToString())}");
            toStringOutput.Add($"this.TelephoneNumber = {(this.TelephoneNumber == null ? "null" : this.TelephoneNumber)}");
            toStringOutput.Add($"this.ThemeId = {(this.ThemeId == null ? "null" : this.ThemeId)}");
        }
    }
}