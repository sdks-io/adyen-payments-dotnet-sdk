// <copyright file="FundDestination1.cs" company="APIMatic">
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
    /// FundDestination1.
    /// </summary>
    public class FundDestination1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundDestination1"/> class.
        /// </summary>
        public FundDestination1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundDestination1"/> class.
        /// </summary>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="card">card.</param>
        /// <param name="selectedRecurringDetailReference">selectedRecurringDetailReference.</param>
        /// <param name="shopperEmail">shopperEmail.</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="shopperReference">shopperReference.</param>
        /// <param name="subMerchant">subMerchant.</param>
        /// <param name="telephoneNumber">telephoneNumber.</param>
        public FundDestination1(
            Dictionary<string, string> additionalData = null,
            Models.Address billingAddress = null,
            Models.Card card = null,
            string selectedRecurringDetailReference = null,
            string shopperEmail = null,
            Models.Name shopperName = null,
            string shopperReference = null,
            Models.SubMerchant subMerchant = null,
            string telephoneNumber = null)
        {
            this.AdditionalData = additionalData;
            this.BillingAddress = billingAddress;
            this.Card = card;
            this.SelectedRecurringDetailReference = selectedRecurringDetailReference;
            this.ShopperEmail = shopperEmail;
            this.ShopperName = shopperName;
            this.ShopperReference = shopperReference;
            this.SubMerchant = subMerchant;
            this.TelephoneNumber = telephoneNumber;
        }

        /// <summary>
        /// a map of name/value pairs for passing in additional/industry-specific data
        /// </summary>
        [JsonProperty("additionalData", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// The address where to send the invoice.
        /// </summary>
        [JsonProperty("billingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address BillingAddress { get; set; }

        /// <summary>
        /// Credit card data.
        /// Optional if `shopperReference` and `selectedRecurringDetailReference` are provided.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Card Card { get; set; }

        /// <summary>
        /// The `recurringDetailReference` you want to use for this payment. The value `LATEST` can be used to select the most recently stored recurring detail.
        /// </summary>
        [JsonProperty("selectedRecurringDetailReference", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectedRecurringDetailReference { get; set; }

        /// <summary>
        /// the email address of the person
        /// </summary>
        [JsonProperty("shopperEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// the name of the person
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FundDestination1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is FundDestination1 other &&                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.SelectedRecurringDetailReference == null && other.SelectedRecurringDetailReference == null) || (this.SelectedRecurringDetailReference?.Equals(other.SelectedRecurringDetailReference) == true)) &&
                ((this.ShopperEmail == null && other.ShopperEmail == null) || (this.ShopperEmail?.Equals(other.ShopperEmail) == true)) &&
                ((this.ShopperName == null && other.ShopperName == null) || (this.ShopperName?.Equals(other.ShopperName) == true)) &&
                ((this.ShopperReference == null && other.ShopperReference == null) || (this.ShopperReference?.Equals(other.ShopperReference) == true)) &&
                ((this.SubMerchant == null && other.SubMerchant == null) || (this.SubMerchant?.Equals(other.SubMerchant) == true)) &&
                ((this.TelephoneNumber == null && other.TelephoneNumber == null) || (this.TelephoneNumber?.Equals(other.TelephoneNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.SelectedRecurringDetailReference = {(this.SelectedRecurringDetailReference == null ? "null" : this.SelectedRecurringDetailReference)}");
            toStringOutput.Add($"this.ShopperEmail = {(this.ShopperEmail == null ? "null" : this.ShopperEmail)}");
            toStringOutput.Add($"this.ShopperName = {(this.ShopperName == null ? "null" : this.ShopperName.ToString())}");
            toStringOutput.Add($"this.ShopperReference = {(this.ShopperReference == null ? "null" : this.ShopperReference)}");
            toStringOutput.Add($"this.SubMerchant = {(this.SubMerchant == null ? "null" : this.SubMerchant.ToString())}");
            toStringOutput.Add($"this.TelephoneNumber = {(this.TelephoneNumber == null ? "null" : this.TelephoneNumber)}");
        }
    }
}