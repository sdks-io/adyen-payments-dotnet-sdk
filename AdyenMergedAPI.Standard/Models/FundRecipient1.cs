// <copyright file="FundRecipient1.cs" company="APIMatic">
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
    /// FundRecipient1.
    /// </summary>
    public class FundRecipient1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundRecipient1"/> class.
        /// </summary>
        public FundRecipient1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundRecipient1"/> class.
        /// </summary>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="shopperEmail">shopperEmail.</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="shopperReference">shopperReference.</param>
        /// <param name="storedPaymentMethodId">storedPaymentMethodId.</param>
        /// <param name="subMerchant">subMerchant.</param>
        /// <param name="telephoneNumber">telephoneNumber.</param>
        /// <param name="walletIdentifier">walletIdentifier.</param>
        /// <param name="walletOwnerTaxId">walletOwnerTaxId.</param>
        public FundRecipient1(
            Models.Address billingAddress = null,
            Models.Card2 paymentMethod = null,
            string shopperEmail = null,
            Models.Name2 shopperName = null,
            string shopperReference = null,
            string storedPaymentMethodId = null,
            Models.SubMerchant subMerchant = null,
            string telephoneNumber = null,
            string walletIdentifier = null,
            string walletOwnerTaxId = null)
        {
            this.BillingAddress = billingAddress;
            this.PaymentMethod = paymentMethod;
            this.ShopperEmail = shopperEmail;
            this.ShopperName = shopperName;
            this.ShopperReference = shopperReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.SubMerchant = subMerchant;
            this.TelephoneNumber = telephoneNumber;
            this.WalletIdentifier = walletIdentifier;
            this.WalletOwnerTaxId = walletOwnerTaxId;
        }

        /// <summary>
        /// The address where to send the invoice.
        /// </summary>
        [JsonProperty("billingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address BillingAddress { get; set; }

        /// <summary>
        /// the used paymentMetohd
        /// </summary>
        [JsonProperty("paymentMethod", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Card2 PaymentMethod { get; set; }

        /// <summary>
        /// the email address of the person
        /// </summary>
        [JsonProperty("shopperEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// the name of the person
        /// </summary>
        [JsonProperty("shopperName", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Name2 ShopperName { get; set; }

        /// <summary>
        /// Required for recurring payments.
        /// Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.
        /// > Your reference must not include personally identifiable information (PII), for example name or email address.
        /// </summary>
        [JsonProperty("shopperReference", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// This is the `recurringDetailReference` returned in the response when you created the token.
        /// </summary>
        [JsonProperty("storedPaymentMethodId", NullValueHandling = NullValueHandling.Ignore)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// Required for Back-to-Back/ purchase driven load in Wallet transactions.
        /// Contains the final merchant who will be receiving the money, also known as subMerchant, information.
        /// </summary>
        [JsonProperty("subMerchant", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubMerchant SubMerchant { get; set; }

        /// <summary>
        /// the telephone number of the person
        /// </summary>
        [JsonProperty("telephoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// indicates where the money is going
        /// </summary>
        [JsonProperty("walletIdentifier", NullValueHandling = NullValueHandling.Ignore)]
        public string WalletIdentifier { get; set; }

        /// <summary>
        /// indicates the tax identifier of the fund recepient
        /// </summary>
        [JsonProperty("walletOwnerTaxId", NullValueHandling = NullValueHandling.Ignore)]
        public string WalletOwnerTaxId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FundRecipient1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is FundRecipient1 other &&                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.ShopperEmail == null && other.ShopperEmail == null) || (this.ShopperEmail?.Equals(other.ShopperEmail) == true)) &&
                ((this.ShopperName == null && other.ShopperName == null) || (this.ShopperName?.Equals(other.ShopperName) == true)) &&
                ((this.ShopperReference == null && other.ShopperReference == null) || (this.ShopperReference?.Equals(other.ShopperReference) == true)) &&
                ((this.StoredPaymentMethodId == null && other.StoredPaymentMethodId == null) || (this.StoredPaymentMethodId?.Equals(other.StoredPaymentMethodId) == true)) &&
                ((this.SubMerchant == null && other.SubMerchant == null) || (this.SubMerchant?.Equals(other.SubMerchant) == true)) &&
                ((this.TelephoneNumber == null && other.TelephoneNumber == null) || (this.TelephoneNumber?.Equals(other.TelephoneNumber) == true)) &&
                ((this.WalletIdentifier == null && other.WalletIdentifier == null) || (this.WalletIdentifier?.Equals(other.WalletIdentifier) == true)) &&
                ((this.WalletOwnerTaxId == null && other.WalletOwnerTaxId == null) || (this.WalletOwnerTaxId?.Equals(other.WalletOwnerTaxId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod.ToString())}");
            toStringOutput.Add($"this.ShopperEmail = {(this.ShopperEmail == null ? "null" : this.ShopperEmail)}");
            toStringOutput.Add($"this.ShopperName = {(this.ShopperName == null ? "null" : this.ShopperName.ToString())}");
            toStringOutput.Add($"this.ShopperReference = {(this.ShopperReference == null ? "null" : this.ShopperReference)}");
            toStringOutput.Add($"this.StoredPaymentMethodId = {(this.StoredPaymentMethodId == null ? "null" : this.StoredPaymentMethodId)}");
            toStringOutput.Add($"this.SubMerchant = {(this.SubMerchant == null ? "null" : this.SubMerchant.ToString())}");
            toStringOutput.Add($"this.TelephoneNumber = {(this.TelephoneNumber == null ? "null" : this.TelephoneNumber)}");
            toStringOutput.Add($"this.WalletIdentifier = {(this.WalletIdentifier == null ? "null" : this.WalletIdentifier)}");
            toStringOutput.Add($"this.WalletOwnerTaxId = {(this.WalletOwnerTaxId == null ? "null" : this.WalletOwnerTaxId)}");
        }
    }
}