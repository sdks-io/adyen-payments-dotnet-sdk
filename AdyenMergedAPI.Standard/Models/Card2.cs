// <copyright file="Card2.cs" company="APIMatic">
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
    /// Card2.
    /// </summary>
    public class Card2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Card2"/> class.
        /// </summary>
        public Card2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card2"/> class.
        /// </summary>
        /// <param name="brand">brand.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="cupsecureplusSmscode">cupsecureplus.smscode.</param>
        /// <param name="cvc">cvc.</param>
        /// <param name="encryptedCardNumber">encryptedCardNumber.</param>
        /// <param name="encryptedExpiryMonth">encryptedExpiryMonth.</param>
        /// <param name="encryptedExpiryYear">encryptedExpiryYear.</param>
        /// <param name="encryptedSecurityCode">encryptedSecurityCode.</param>
        /// <param name="expiryMonth">expiryMonth.</param>
        /// <param name="expiryYear">expiryYear.</param>
        /// <param name="fundingSource">fundingSource.</param>
        /// <param name="holderName">holderName.</param>
        /// <param name="networkPaymentReference">networkPaymentReference.</param>
        /// <param name="number">number.</param>
        /// <param name="recurringDetailReference">recurringDetailReference.</param>
        /// <param name="shopperNotificationReference">shopperNotificationReference.</param>
        /// <param name="storedPaymentMethodId">storedPaymentMethodId.</param>
        /// <param name="threeDS2SdkVersion">threeDS2SdkVersion.</param>
        /// <param name="type">type.</param>
        public Card2(
            string brand = null,
            string checkoutAttemptId = null,
            string cupsecureplusSmscode = null,
            string cvc = null,
            string encryptedCardNumber = null,
            string encryptedExpiryMonth = null,
            string encryptedExpiryYear = null,
            string encryptedSecurityCode = null,
            string expiryMonth = null,
            string expiryYear = null,
            Models.FundingSourceEnum? fundingSource = null,
            string holderName = null,
            string networkPaymentReference = null,
            string number = null,
            string recurringDetailReference = null,
            string shopperNotificationReference = null,
            string storedPaymentMethodId = null,
            string threeDS2SdkVersion = null,
            Models.Type9Enum? type = Models.Type9Enum.Scheme)
        {
            this.Brand = brand;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.CupsecureplusSmscode = cupsecureplusSmscode;
            this.Cvc = cvc;
            this.EncryptedCardNumber = encryptedCardNumber;
            this.EncryptedExpiryMonth = encryptedExpiryMonth;
            this.EncryptedExpiryYear = encryptedExpiryYear;
            this.EncryptedSecurityCode = encryptedSecurityCode;
            this.ExpiryMonth = expiryMonth;
            this.ExpiryYear = expiryYear;
            this.FundingSource = fundingSource;
            this.HolderName = holderName;
            this.NetworkPaymentReference = networkPaymentReference;
            this.Number = number;
            this.RecurringDetailReference = recurringDetailReference;
            this.ShopperNotificationReference = shopperNotificationReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.ThreeDS2SdkVersion = threeDS2SdkVersion;
            this.Type = type;
        }

        /// <summary>
        /// Secondary brand of the card. For example: **plastix**, **hmclub**.
        /// </summary>
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public string Brand { get; set; }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        [JsonProperty("checkoutAttemptId", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// Gets or sets CupsecureplusSmscode.
        /// </summary>
        [JsonProperty("cupsecureplus.smscode", NullValueHandling = NullValueHandling.Ignore)]
        public string CupsecureplusSmscode { get; set; }

        /// <summary>
        /// The card verification code. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).
        /// </summary>
        [JsonProperty("cvc", NullValueHandling = NullValueHandling.Ignore)]
        public string Cvc { get; set; }

        /// <summary>
        /// The encrypted card number.
        /// </summary>
        [JsonProperty("encryptedCardNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptedCardNumber { get; set; }

        /// <summary>
        /// The encrypted card expiry month.
        /// </summary>
        [JsonProperty("encryptedExpiryMonth", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptedExpiryMonth { get; set; }

        /// <summary>
        /// The encrypted card expiry year.
        /// </summary>
        [JsonProperty("encryptedExpiryYear", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptedExpiryYear { get; set; }

        /// <summary>
        /// The encrypted card verification code.
        /// </summary>
        [JsonProperty("encryptedSecurityCode", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptedSecurityCode { get; set; }

        /// <summary>
        /// The card expiry month. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).
        /// </summary>
        [JsonProperty("expiryMonth", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryMonth { get; set; }

        /// <summary>
        /// The card expiry year. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).
        /// </summary>
        [JsonProperty("expiryYear", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryYear { get; set; }

        /// <summary>
        /// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.
        /// </summary>
        [JsonProperty("fundingSource", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FundingSourceEnum? FundingSource { get; set; }

        /// <summary>
        /// The name of the card holder.
        /// </summary>
        [JsonProperty("holderName", NullValueHandling = NullValueHandling.Ignore)]
        public string HolderName { get; set; }

        /// <summary>
        /// The network token reference. This is the [`networkTxReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_additionalData-ResponseAdditionalDataCommon-networkTxReference) from the response to the first payment.
        /// </summary>
        [JsonProperty("networkPaymentReference", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkPaymentReference { get; set; }

        /// <summary>
        /// The card number. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// This is the `recurringDetailReference` returned in the response when you created the token.
        /// </summary>
        [JsonProperty("recurringDetailReference", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// The `shopperNotificationReference` returned in the response when you requested to notify the shopper. Used only for recurring payments in India.
        /// </summary>
        [JsonProperty("shopperNotificationReference", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperNotificationReference { get; set; }

        /// <summary>
        /// This is the `recurringDetailReference` returned in the response when you created the token.
        /// </summary>
        [JsonProperty("storedPaymentMethodId", NullValueHandling = NullValueHandling.Ignore)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// Required for mobile integrations. Version of the 3D Secure 2 mobile SDK.
        /// </summary>
        [JsonProperty("threeDS2SdkVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDS2SdkVersion { get; set; }

        /// <summary>
        /// Default payment method details. Common for scheme payment methods, and for simple payment method details.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Type9Enum? Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Card2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Card2 other &&                ((this.Brand == null && other.Brand == null) || (this.Brand?.Equals(other.Brand) == true)) &&
                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.CupsecureplusSmscode == null && other.CupsecureplusSmscode == null) || (this.CupsecureplusSmscode?.Equals(other.CupsecureplusSmscode) == true)) &&
                ((this.Cvc == null && other.Cvc == null) || (this.Cvc?.Equals(other.Cvc) == true)) &&
                ((this.EncryptedCardNumber == null && other.EncryptedCardNumber == null) || (this.EncryptedCardNumber?.Equals(other.EncryptedCardNumber) == true)) &&
                ((this.EncryptedExpiryMonth == null && other.EncryptedExpiryMonth == null) || (this.EncryptedExpiryMonth?.Equals(other.EncryptedExpiryMonth) == true)) &&
                ((this.EncryptedExpiryYear == null && other.EncryptedExpiryYear == null) || (this.EncryptedExpiryYear?.Equals(other.EncryptedExpiryYear) == true)) &&
                ((this.EncryptedSecurityCode == null && other.EncryptedSecurityCode == null) || (this.EncryptedSecurityCode?.Equals(other.EncryptedSecurityCode) == true)) &&
                ((this.ExpiryMonth == null && other.ExpiryMonth == null) || (this.ExpiryMonth?.Equals(other.ExpiryMonth) == true)) &&
                ((this.ExpiryYear == null && other.ExpiryYear == null) || (this.ExpiryYear?.Equals(other.ExpiryYear) == true)) &&
                ((this.FundingSource == null && other.FundingSource == null) || (this.FundingSource?.Equals(other.FundingSource) == true)) &&
                ((this.HolderName == null && other.HolderName == null) || (this.HolderName?.Equals(other.HolderName) == true)) &&
                ((this.NetworkPaymentReference == null && other.NetworkPaymentReference == null) || (this.NetworkPaymentReference?.Equals(other.NetworkPaymentReference) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.RecurringDetailReference == null && other.RecurringDetailReference == null) || (this.RecurringDetailReference?.Equals(other.RecurringDetailReference) == true)) &&
                ((this.ShopperNotificationReference == null && other.ShopperNotificationReference == null) || (this.ShopperNotificationReference?.Equals(other.ShopperNotificationReference) == true)) &&
                ((this.StoredPaymentMethodId == null && other.StoredPaymentMethodId == null) || (this.StoredPaymentMethodId?.Equals(other.StoredPaymentMethodId) == true)) &&
                ((this.ThreeDS2SdkVersion == null && other.ThreeDS2SdkVersion == null) || (this.ThreeDS2SdkVersion?.Equals(other.ThreeDS2SdkVersion) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Brand = {(this.Brand == null ? "null" : this.Brand)}");
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.CupsecureplusSmscode = {(this.CupsecureplusSmscode == null ? "null" : this.CupsecureplusSmscode)}");
            toStringOutput.Add($"this.Cvc = {(this.Cvc == null ? "null" : this.Cvc)}");
            toStringOutput.Add($"this.EncryptedCardNumber = {(this.EncryptedCardNumber == null ? "null" : this.EncryptedCardNumber)}");
            toStringOutput.Add($"this.EncryptedExpiryMonth = {(this.EncryptedExpiryMonth == null ? "null" : this.EncryptedExpiryMonth)}");
            toStringOutput.Add($"this.EncryptedExpiryYear = {(this.EncryptedExpiryYear == null ? "null" : this.EncryptedExpiryYear)}");
            toStringOutput.Add($"this.EncryptedSecurityCode = {(this.EncryptedSecurityCode == null ? "null" : this.EncryptedSecurityCode)}");
            toStringOutput.Add($"this.ExpiryMonth = {(this.ExpiryMonth == null ? "null" : this.ExpiryMonth)}");
            toStringOutput.Add($"this.ExpiryYear = {(this.ExpiryYear == null ? "null" : this.ExpiryYear)}");
            toStringOutput.Add($"this.FundingSource = {(this.FundingSource == null ? "null" : this.FundingSource.ToString())}");
            toStringOutput.Add($"this.HolderName = {(this.HolderName == null ? "null" : this.HolderName)}");
            toStringOutput.Add($"this.NetworkPaymentReference = {(this.NetworkPaymentReference == null ? "null" : this.NetworkPaymentReference)}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number)}");
            toStringOutput.Add($"this.RecurringDetailReference = {(this.RecurringDetailReference == null ? "null" : this.RecurringDetailReference)}");
            toStringOutput.Add($"this.ShopperNotificationReference = {(this.ShopperNotificationReference == null ? "null" : this.ShopperNotificationReference)}");
            toStringOutput.Add($"this.StoredPaymentMethodId = {(this.StoredPaymentMethodId == null ? "null" : this.StoredPaymentMethodId)}");
            toStringOutput.Add($"this.ThreeDS2SdkVersion = {(this.ThreeDS2SdkVersion == null ? "null" : this.ThreeDS2SdkVersion)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
        }
    }
}