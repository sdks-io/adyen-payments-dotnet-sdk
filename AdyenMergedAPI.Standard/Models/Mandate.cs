// <copyright file="Mandate.cs" company="APIMatic">
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
    /// Mandate.
    /// </summary>
    public class Mandate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mandate"/> class.
        /// </summary>
        public Mandate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mandate"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="endsAt">endsAt.</param>
        /// <param name="frequency">frequency.</param>
        /// <param name="amountRule">amountRule.</param>
        /// <param name="billingAttemptsRule">billingAttemptsRule.</param>
        /// <param name="billingDay">billingDay.</param>
        /// <param name="remarks">remarks.</param>
        /// <param name="startsAt">startsAt.</param>
        public Mandate(
            string amount,
            string endsAt,
            Models.FrequencyEnum frequency,
            Models.AmountRuleEnum? amountRule = null,
            Models.BillingAttemptsRuleEnum? billingAttemptsRule = null,
            string billingDay = null,
            string remarks = null,
            string startsAt = null)
        {
            this.Amount = amount;
            this.AmountRule = amountRule;
            this.BillingAttemptsRule = billingAttemptsRule;
            this.BillingDay = billingDay;
            this.EndsAt = endsAt;
            this.Frequency = frequency;
            this.Remarks = remarks;
            this.StartsAt = startsAt;
        }

        /// <summary>
        /// The billing amount (in minor units) of the recurring transactions.
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// The limitation rule of the billing amount.
        /// Possible values:
        ///  * **max**: The transaction amount can not exceed the `amount`.
        ///  * **exact**: The transaction amount should be the same as the `amount`.
        /// </summary>
        [JsonProperty("amountRule", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AmountRuleEnum? AmountRule { get; set; }

        /// <summary>
        /// The rule to specify the period, within which the recurring debit can happen, relative to the mandate recurring date.
        /// Possible values:
        ///  * **on**: On a specific date.
        ///  * **before**:  Before and on a specific date.
        ///  * **after**: On and after a specific date.
        /// </summary>
        [JsonProperty("billingAttemptsRule", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingAttemptsRuleEnum? BillingAttemptsRule { get; set; }

        /// <summary>
        /// The number of the day, on which the recurring debit can happen. Should be within the same calendar month as the mandate recurring date.
        /// Possible values: 1-31 based on the `frequency`.
        /// </summary>
        [JsonProperty("billingDay", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingDay { get; set; }

        /// <summary>
        /// End date of the billing plan, in YYYY-MM-DD format.
        /// </summary>
        [JsonProperty("endsAt")]
        public string EndsAt { get; set; }

        /// <summary>
        /// The frequency with which a shopper should be charged.
        /// Possible values: **daily**, **weekly**, **biWeekly**, **monthly**, **quarterly**, **halfYearly**, **yearly**.
        /// </summary>
        [JsonProperty("frequency")]
        public Models.FrequencyEnum Frequency { get; set; }

        /// <summary>
        /// The message shown by UPI to the shopper on the approval screen.
        /// </summary>
        [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
        public string Remarks { get; set; }

        /// <summary>
        /// Start date of the billing plan, in YYYY-MM-DD format. By default, the transaction date.
        /// </summary>
        [JsonProperty("startsAt", NullValueHandling = NullValueHandling.Ignore)]
        public string StartsAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Mandate : ({string.Join(", ", toStringOutput)})";
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
            return obj is Mandate other &&                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.AmountRule == null && other.AmountRule == null) || (this.AmountRule?.Equals(other.AmountRule) == true)) &&
                ((this.BillingAttemptsRule == null && other.BillingAttemptsRule == null) || (this.BillingAttemptsRule?.Equals(other.BillingAttemptsRule) == true)) &&
                ((this.BillingDay == null && other.BillingDay == null) || (this.BillingDay?.Equals(other.BillingDay) == true)) &&
                ((this.EndsAt == null && other.EndsAt == null) || (this.EndsAt?.Equals(other.EndsAt) == true)) &&
                this.Frequency.Equals(other.Frequency) &&
                ((this.Remarks == null && other.Remarks == null) || (this.Remarks?.Equals(other.Remarks) == true)) &&
                ((this.StartsAt == null && other.StartsAt == null) || (this.StartsAt?.Equals(other.StartsAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount)}");
            toStringOutput.Add($"this.AmountRule = {(this.AmountRule == null ? "null" : this.AmountRule.ToString())}");
            toStringOutput.Add($"this.BillingAttemptsRule = {(this.BillingAttemptsRule == null ? "null" : this.BillingAttemptsRule.ToString())}");
            toStringOutput.Add($"this.BillingDay = {(this.BillingDay == null ? "null" : this.BillingDay)}");
            toStringOutput.Add($"this.EndsAt = {(this.EndsAt == null ? "null" : this.EndsAt)}");
            toStringOutput.Add($"this.Frequency = {this.Frequency}");
            toStringOutput.Add($"this.Remarks = {(this.Remarks == null ? "null" : this.Remarks)}");
            toStringOutput.Add($"this.StartsAt = {(this.StartsAt == null ? "null" : this.StartsAt)}");
        }
    }
}