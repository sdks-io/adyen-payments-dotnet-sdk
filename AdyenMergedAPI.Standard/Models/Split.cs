// <copyright file="Split.cs" company="APIMatic">
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
    /// Split.
    /// </summary>
    public class Split
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Split"/> class.
        /// </summary>
        public Split()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Split"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="account">account.</param>
        /// <param name="amount">amount.</param>
        /// <param name="description">description.</param>
        /// <param name="reference">reference.</param>
        public Split(
            Models.Type6Enum type,
            string account = null,
            Models.SplitAmount amount = null,
            string description = null,
            string reference = null)
        {
            this.Account = account;
            this.Amount = amount;
            this.Description = description;
            this.Reference = reference;
            this.Type = type;
        }

        /// <summary>
        /// The unique identifier of the account to which the split amount is booked. Required if `type` is **MarketPlace** or **BalanceAccount**.
        /// * [Classic Platforms integration](https://docs.adyen.com/marketplaces-and-platforms/classic): The [`accountCode`](https://docs.adyen.com/api-explorer/Account/latest/post/updateAccount#request-accountCode) of the account to which the split amount is booked.
        /// * [Balance Platform](https://docs.adyen.com/marketplaces-and-platforms): The [`balanceAccountId`](https://docs.adyen.com/api-explorer/balanceplatform/latest/get/balanceAccounts/_id_#path-id) of the account to which the split amount is booked.
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// The amount of the split item.
        /// * Required for all split types in the [Classic Platforms integration](https://docs.adyen.com/marketplaces-and-platforms/classic).
        /// * Required if `type` is **BalanceAccount**, **Commission**, **Default**, or **VAT** in your [Balance Platform](https://docs.adyen.com/marketplaces-and-platforms) integration.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SplitAmount Amount { get; set; }

        /// <summary>
        /// Your description for the split item.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Your unique reference for the split item.
        /// This is required if `type` is **MarketPlace** ([Classic Platforms integration](https://docs.adyen.com/marketplaces-and-platforms/classic)) or **BalanceAccount** ([Balance Platform](https://docs.adyen.com/marketplaces-and-platforms)).
        /// For the other types, we also recommend providing a **unique** reference so you can reconcile the split and the associated payment in the transaction overview and in the reports.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <summary>
        /// The type of the split item.
        /// Possible values:
        /// * [Classic Platforms integration](https://docs.adyen.com/marketplaces-and-platforms/classic): **Commission**, **Default**, **Marketplace**, **PaymentFee**, **VAT**.
        /// * [Balance Platform](https://docs.adyen.com/marketplaces-and-platforms): **BalanceAccount**, **Commission**, **Default**, **PaymentFee**, **Remainder**, **Surcharge**, **Tip**, **VAT**.
        /// </summary>
        [JsonProperty("type")]
        public Models.Type6Enum Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Split : ({string.Join(", ", toStringOutput)})";
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
            return obj is Split other &&                ((this.Account == null && other.Account == null) || (this.Account?.Equals(other.Account) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                this.Type.Equals(other.Type);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Account = {(this.Account == null ? "null" : this.Account)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.Type = {this.Type}");
        }
    }
}