// <copyright file="ForexQuote.cs" company="APIMatic">
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
    /// ForexQuote.
    /// </summary>
    public class ForexQuote
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForexQuote"/> class.
        /// </summary>
        public ForexQuote()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForexQuote"/> class.
        /// </summary>
        /// <param name="basePoints">basePoints.</param>
        /// <param name="validTill">validTill.</param>
        /// <param name="account">account.</param>
        /// <param name="accountType">accountType.</param>
        /// <param name="baseAmount">baseAmount.</param>
        /// <param name="buy">buy.</param>
        /// <param name="interbank">interbank.</param>
        /// <param name="reference">reference.</param>
        /// <param name="sell">sell.</param>
        /// <param name="signature">signature.</param>
        /// <param name="source">source.</param>
        /// <param name="type">type.</param>
        public ForexQuote(
            int basePoints,
            DateTime validTill,
            string account = null,
            string accountType = null,
            Models.Amount3 baseAmount = null,
            Models.Amount4 buy = null,
            Models.Amount5 interbank = null,
            string reference = null,
            Models.Amount6 sell = null,
            string signature = null,
            string source = null,
            string type = null)
        {
            this.Account = account;
            this.AccountType = accountType;
            this.BaseAmount = baseAmount;
            this.BasePoints = basePoints;
            this.Buy = buy;
            this.Interbank = interbank;
            this.Reference = reference;
            this.Sell = sell;
            this.Signature = signature;
            this.Source = source;
            this.Type = type;
            this.ValidTill = validTill;
        }

        /// <summary>
        /// The account name.
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// The account type.
        /// </summary>
        [JsonProperty("accountType", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountType { get; set; }

        /// <summary>
        /// The base amount.
        /// </summary>
        [JsonProperty("baseAmount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount3 BaseAmount { get; set; }

        /// <summary>
        /// The base points.
        /// </summary>
        [JsonProperty("basePoints")]
        public int BasePoints { get; set; }

        /// <summary>
        /// The buy rate.
        /// </summary>
        [JsonProperty("buy", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount4 Buy { get; set; }

        /// <summary>
        /// The interbank amount.
        /// </summary>
        [JsonProperty("interbank", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount5 Interbank { get; set; }

        /// <summary>
        /// The reference assigned to the forex quote request.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <summary>
        /// The sell rate.
        /// </summary>
        [JsonProperty("sell", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount6 Sell { get; set; }

        /// <summary>
        /// The signature to validate the integrity.
        /// </summary>
        [JsonProperty("signature", NullValueHandling = NullValueHandling.Ignore)]
        public string Signature { get; set; }

        /// <summary>
        /// The source of the forex quote.
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// The type of forex.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// The date until which the forex quote is valid.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("validTill")]
        public DateTime ValidTill { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ForexQuote : ({string.Join(", ", toStringOutput)})";
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
            return obj is ForexQuote other &&                ((this.Account == null && other.Account == null) || (this.Account?.Equals(other.Account) == true)) &&
                ((this.AccountType == null && other.AccountType == null) || (this.AccountType?.Equals(other.AccountType) == true)) &&
                ((this.BaseAmount == null && other.BaseAmount == null) || (this.BaseAmount?.Equals(other.BaseAmount) == true)) &&
                this.BasePoints.Equals(other.BasePoints) &&
                ((this.Buy == null && other.Buy == null) || (this.Buy?.Equals(other.Buy) == true)) &&
                ((this.Interbank == null && other.Interbank == null) || (this.Interbank?.Equals(other.Interbank) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.Sell == null && other.Sell == null) || (this.Sell?.Equals(other.Sell) == true)) &&
                ((this.Signature == null && other.Signature == null) || (this.Signature?.Equals(other.Signature) == true)) &&
                ((this.Source == null && other.Source == null) || (this.Source?.Equals(other.Source) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                this.ValidTill.Equals(other.ValidTill);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Account = {(this.Account == null ? "null" : this.Account)}");
            toStringOutput.Add($"this.AccountType = {(this.AccountType == null ? "null" : this.AccountType)}");
            toStringOutput.Add($"this.BaseAmount = {(this.BaseAmount == null ? "null" : this.BaseAmount.ToString())}");
            toStringOutput.Add($"this.BasePoints = {this.BasePoints}");
            toStringOutput.Add($"this.Buy = {(this.Buy == null ? "null" : this.Buy.ToString())}");
            toStringOutput.Add($"this.Interbank = {(this.Interbank == null ? "null" : this.Interbank.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.Sell = {(this.Sell == null ? "null" : this.Sell.ToString())}");
            toStringOutput.Add($"this.Signature = {(this.Signature == null ? "null" : this.Signature)}");
            toStringOutput.Add($"this.Source = {(this.Source == null ? "null" : this.Source)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.ValidTill = {this.ValidTill}");
        }
    }
}