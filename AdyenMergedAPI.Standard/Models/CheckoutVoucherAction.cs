// <copyright file="CheckoutVoucherAction.cs" company="APIMatic">
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
    /// CheckoutVoucherAction.
    /// </summary>
    public class CheckoutVoucherAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutVoucherAction"/> class.
        /// </summary>
        public CheckoutVoucherAction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutVoucherAction"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="alternativeReference">alternativeReference.</param>
        /// <param name="collectionInstitutionNumber">collectionInstitutionNumber.</param>
        /// <param name="downloadUrl">downloadUrl.</param>
        /// <param name="entity">entity.</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="initialAmount">initialAmount.</param>
        /// <param name="instructionsUrl">instructionsUrl.</param>
        /// <param name="issuer">issuer.</param>
        /// <param name="maskedTelephoneNumber">maskedTelephoneNumber.</param>
        /// <param name="merchantName">merchantName.</param>
        /// <param name="merchantReference">merchantReference.</param>
        /// <param name="passCreationToken">passCreationToken.</param>
        /// <param name="paymentData">paymentData.</param>
        /// <param name="paymentMethodType">paymentMethodType.</param>
        /// <param name="reference">reference.</param>
        /// <param name="shopperEmail">shopperEmail.</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="surcharge">surcharge.</param>
        /// <param name="totalAmount">totalAmount.</param>
        /// <param name="url">url.</param>
        public CheckoutVoucherAction(
            string type,
            string alternativeReference = null,
            string collectionInstitutionNumber = null,
            string downloadUrl = null,
            string entity = null,
            string expiresAt = null,
            Models.Amount12 initialAmount = null,
            string instructionsUrl = null,
            string issuer = null,
            string maskedTelephoneNumber = null,
            string merchantName = null,
            string merchantReference = null,
            string passCreationToken = null,
            string paymentData = null,
            string paymentMethodType = null,
            string reference = null,
            string shopperEmail = null,
            string shopperName = null,
            Models.Amount13 surcharge = null,
            Models.Amount14 totalAmount = null,
            string url = null)
        {
            this.AlternativeReference = alternativeReference;
            this.CollectionInstitutionNumber = collectionInstitutionNumber;
            this.DownloadUrl = downloadUrl;
            this.Entity = entity;
            this.ExpiresAt = expiresAt;
            this.InitialAmount = initialAmount;
            this.InstructionsUrl = instructionsUrl;
            this.Issuer = issuer;
            this.MaskedTelephoneNumber = maskedTelephoneNumber;
            this.MerchantName = merchantName;
            this.MerchantReference = merchantReference;
            this.PassCreationToken = passCreationToken;
            this.PaymentData = paymentData;
            this.PaymentMethodType = paymentMethodType;
            this.Reference = reference;
            this.ShopperEmail = shopperEmail;
            this.ShopperName = shopperName;
            this.Surcharge = surcharge;
            this.TotalAmount = totalAmount;
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// The voucher alternative reference code.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("alternativeReference", NullValueHandling = NullValueHandling.Ignore)]
        public string AlternativeReference { get; set; }

        /// <summary>
        /// A collection institution number (store number) for Econtext Pay-Easy ATM.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("collectionInstitutionNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string CollectionInstitutionNumber { get; set; }

        /// <summary>
        /// The URL to download the voucher.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("downloadUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// An entity number of Multibanco.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("entity", NullValueHandling = NullValueHandling.Ignore)]
        public string Entity { get; set; }

        /// <summary>
        /// The date time of the voucher expiry.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("expiresAt", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// The initial amount.
        /// </summary>
        [JsonProperty("initialAmount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount12 InitialAmount { get; set; }

        /// <summary>
        /// The URL to the detailed instructions to make payment using the voucher.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("instructionsUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string InstructionsUrl { get; set; }

        /// <summary>
        /// The issuer of the voucher.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string Issuer { get; set; }

        /// <summary>
        /// The shopper telephone number (partially masked).
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("maskedTelephoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskedTelephoneNumber { get; set; }

        /// <summary>
        /// The merchant name.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("merchantName", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantName { get; set; }

        /// <summary>
        /// The merchant reference.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("merchantReference", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// A base64 encoded signature of all properties
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("passCreationToken", NullValueHandling = NullValueHandling.Ignore)]
        public string PassCreationToken { get; set; }

        /// <summary>
        /// Encoded payment data.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("paymentData", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentData { get; set; }

        /// <summary>
        /// Specifies the payment method.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("paymentMethodType", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentMethodType { get; set; }

        /// <summary>
        /// The voucher reference code.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <summary>
        /// The shopper email.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("shopperEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// The shopper name.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("shopperName", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperName { get; set; }

        /// <summary>
        /// The surcharge amount.
        /// </summary>
        [JsonProperty("surcharge", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount13 Surcharge { get; set; }

        /// <summary>
        /// The total amount (initial plus surcharge amount).
        /// </summary>
        [JsonProperty("totalAmount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount14 TotalAmount { get; set; }

        /// <summary>
        /// **voucher**
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("type")]
        [JsonRequired]
        public string Type { get; set; }

        /// <summary>
        /// Specifies the URL to redirect to.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CheckoutVoucherAction : ({string.Join(", ", toStringOutput)})";
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
            return obj is CheckoutVoucherAction other &&                ((this.AlternativeReference == null && other.AlternativeReference == null) || (this.AlternativeReference?.Equals(other.AlternativeReference) == true)) &&
                ((this.CollectionInstitutionNumber == null && other.CollectionInstitutionNumber == null) || (this.CollectionInstitutionNumber?.Equals(other.CollectionInstitutionNumber) == true)) &&
                ((this.DownloadUrl == null && other.DownloadUrl == null) || (this.DownloadUrl?.Equals(other.DownloadUrl) == true)) &&
                ((this.Entity == null && other.Entity == null) || (this.Entity?.Equals(other.Entity) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.InitialAmount == null && other.InitialAmount == null) || (this.InitialAmount?.Equals(other.InitialAmount) == true)) &&
                ((this.InstructionsUrl == null && other.InstructionsUrl == null) || (this.InstructionsUrl?.Equals(other.InstructionsUrl) == true)) &&
                ((this.Issuer == null && other.Issuer == null) || (this.Issuer?.Equals(other.Issuer) == true)) &&
                ((this.MaskedTelephoneNumber == null && other.MaskedTelephoneNumber == null) || (this.MaskedTelephoneNumber?.Equals(other.MaskedTelephoneNumber) == true)) &&
                ((this.MerchantName == null && other.MerchantName == null) || (this.MerchantName?.Equals(other.MerchantName) == true)) &&
                ((this.MerchantReference == null && other.MerchantReference == null) || (this.MerchantReference?.Equals(other.MerchantReference) == true)) &&
                ((this.PassCreationToken == null && other.PassCreationToken == null) || (this.PassCreationToken?.Equals(other.PassCreationToken) == true)) &&
                ((this.PaymentData == null && other.PaymentData == null) || (this.PaymentData?.Equals(other.PaymentData) == true)) &&
                ((this.PaymentMethodType == null && other.PaymentMethodType == null) || (this.PaymentMethodType?.Equals(other.PaymentMethodType) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.ShopperEmail == null && other.ShopperEmail == null) || (this.ShopperEmail?.Equals(other.ShopperEmail) == true)) &&
                ((this.ShopperName == null && other.ShopperName == null) || (this.ShopperName?.Equals(other.ShopperName) == true)) &&
                ((this.Surcharge == null && other.Surcharge == null) || (this.Surcharge?.Equals(other.Surcharge) == true)) &&
                ((this.TotalAmount == null && other.TotalAmount == null) || (this.TotalAmount?.Equals(other.TotalAmount) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AlternativeReference = {(this.AlternativeReference == null ? "null" : this.AlternativeReference)}");
            toStringOutput.Add($"this.CollectionInstitutionNumber = {(this.CollectionInstitutionNumber == null ? "null" : this.CollectionInstitutionNumber)}");
            toStringOutput.Add($"this.DownloadUrl = {(this.DownloadUrl == null ? "null" : this.DownloadUrl)}");
            toStringOutput.Add($"this.Entity = {(this.Entity == null ? "null" : this.Entity)}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt)}");
            toStringOutput.Add($"this.InitialAmount = {(this.InitialAmount == null ? "null" : this.InitialAmount.ToString())}");
            toStringOutput.Add($"this.InstructionsUrl = {(this.InstructionsUrl == null ? "null" : this.InstructionsUrl)}");
            toStringOutput.Add($"this.Issuer = {(this.Issuer == null ? "null" : this.Issuer)}");
            toStringOutput.Add($"this.MaskedTelephoneNumber = {(this.MaskedTelephoneNumber == null ? "null" : this.MaskedTelephoneNumber)}");
            toStringOutput.Add($"this.MerchantName = {(this.MerchantName == null ? "null" : this.MerchantName)}");
            toStringOutput.Add($"this.MerchantReference = {(this.MerchantReference == null ? "null" : this.MerchantReference)}");
            toStringOutput.Add($"this.PassCreationToken = {(this.PassCreationToken == null ? "null" : this.PassCreationToken)}");
            toStringOutput.Add($"this.PaymentData = {(this.PaymentData == null ? "null" : this.PaymentData)}");
            toStringOutput.Add($"this.PaymentMethodType = {(this.PaymentMethodType == null ? "null" : this.PaymentMethodType)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.ShopperEmail = {(this.ShopperEmail == null ? "null" : this.ShopperEmail)}");
            toStringOutput.Add($"this.ShopperName = {(this.ShopperName == null ? "null" : this.ShopperName)}");
            toStringOutput.Add($"this.Surcharge = {(this.Surcharge == null ? "null" : this.Surcharge.ToString())}");
            toStringOutput.Add($"this.TotalAmount = {(this.TotalAmount == null ? "null" : this.TotalAmount.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
        }
    }
}