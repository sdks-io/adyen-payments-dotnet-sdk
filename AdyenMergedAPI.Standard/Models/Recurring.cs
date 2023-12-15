// <copyright file="Recurring.cs" company="APIMatic">
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
    /// Recurring.
    /// </summary>
    public class Recurring
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Recurring"/> class.
        /// </summary>
        public Recurring()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Recurring"/> class.
        /// </summary>
        /// <param name="contract">contract.</param>
        /// <param name="recurringDetailName">recurringDetailName.</param>
        /// <param name="recurringExpiry">recurringExpiry.</param>
        /// <param name="recurringFrequency">recurringFrequency.</param>
        /// <param name="tokenService">tokenService.</param>
        public Recurring(
            Models.ContractEnum? contract = null,
            string recurringDetailName = null,
            DateTime? recurringExpiry = null,
            string recurringFrequency = null,
            Models.TokenServiceEnum? tokenService = null)
        {
            this.Contract = contract;
            this.RecurringDetailName = recurringDetailName;
            this.RecurringExpiry = recurringExpiry;
            this.RecurringFrequency = recurringFrequency;
            this.TokenService = tokenService;
        }

        /// <summary>
        /// The type of recurring contract to be used.
        /// Possible values:
        /// * `ONECLICK` – Payment details can be used to initiate a one-click payment, where the shopper enters the [card security code (CVC/CVV)](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid).
        /// * `RECURRING` – Payment details can be used without the card security code to initiate [card-not-present transactions](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-not-present-cnp).
        /// * `ONECLICK,RECURRING` – Payment details can be used regardless of whether the shopper is on your site or not.
        /// * `PAYOUT` – Payment details can be used to [make a payout](https://docs.adyen.com/online-payments/online-payouts).
        /// </summary>
        [JsonProperty("contract", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ContractEnum? Contract { get; set; }

        /// <summary>
        /// A descriptive name for this detail.
        /// </summary>
        [JsonProperty("recurringDetailName", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurringDetailName { get; set; }

        /// <summary>
        /// Date after which no further authorisations shall be performed. Only for 3D Secure 2.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("recurringExpiry", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RecurringExpiry { get; set; }

        /// <summary>
        /// Minimum number of days between authorisations. Only for 3D Secure 2.
        /// </summary>
        [JsonProperty("recurringFrequency", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurringFrequency { get; set; }

        /// <summary>
        /// The name of the token service.
        /// </summary>
        [JsonProperty("tokenService", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TokenServiceEnum? TokenService { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Recurring : ({string.Join(", ", toStringOutput)})";
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
            return obj is Recurring other &&                ((this.Contract == null && other.Contract == null) || (this.Contract?.Equals(other.Contract) == true)) &&
                ((this.RecurringDetailName == null && other.RecurringDetailName == null) || (this.RecurringDetailName?.Equals(other.RecurringDetailName) == true)) &&
                ((this.RecurringExpiry == null && other.RecurringExpiry == null) || (this.RecurringExpiry?.Equals(other.RecurringExpiry) == true)) &&
                ((this.RecurringFrequency == null && other.RecurringFrequency == null) || (this.RecurringFrequency?.Equals(other.RecurringFrequency) == true)) &&
                ((this.TokenService == null && other.TokenService == null) || (this.TokenService?.Equals(other.TokenService) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Contract = {(this.Contract == null ? "null" : this.Contract.ToString())}");
            toStringOutput.Add($"this.RecurringDetailName = {(this.RecurringDetailName == null ? "null" : this.RecurringDetailName)}");
            toStringOutput.Add($"this.RecurringExpiry = {(this.RecurringExpiry == null ? "null" : this.RecurringExpiry.ToString())}");
            toStringOutput.Add($"this.RecurringFrequency = {(this.RecurringFrequency == null ? "null" : this.RecurringFrequency)}");
            toStringOutput.Add($"this.TokenService = {(this.TokenService == null ? "null" : this.TokenService.ToString())}");
        }
    }
}