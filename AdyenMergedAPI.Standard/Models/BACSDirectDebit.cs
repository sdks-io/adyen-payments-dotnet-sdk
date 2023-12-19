// <copyright file="BACSDirectDebit.cs" company="APIMatic">
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
    /// BACSDirectDebit.
    /// </summary>
    public class BACSDirectDebit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BACSDirectDebit"/> class.
        /// </summary>
        public BACSDirectDebit()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BACSDirectDebit"/> class.
        /// </summary>
        /// <param name="bankAccountNumber">bankAccountNumber.</param>
        /// <param name="bankLocationId">bankLocationId.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="holderName">holderName.</param>
        /// <param name="recurringDetailReference">recurringDetailReference.</param>
        /// <param name="storedPaymentMethodId">storedPaymentMethodId.</param>
        /// <param name="type">type.</param>
        public BACSDirectDebit(
            string bankAccountNumber = null,
            string bankLocationId = null,
            string checkoutAttemptId = null,
            string holderName = null,
            string recurringDetailReference = null,
            string storedPaymentMethodId = null,
            Models.Type5Enum? type = Models.Type5Enum.DirectdebitGB)
        {
            this.BankAccountNumber = bankAccountNumber;
            this.BankLocationId = bankLocationId;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.HolderName = holderName;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.Type = type;
        }

        /// <summary>
        /// The bank account number (without separators).
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("bankAccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// The bank routing number of the account.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("bankLocationId", NullValueHandling = NullValueHandling.Ignore)]
        public string BankLocationId { get; set; }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("checkoutAttemptId", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// The name of the bank account holder.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("holderName", NullValueHandling = NullValueHandling.Ignore)]
        public string HolderName { get; set; }

        /// <summary>
        /// This is the `recurringDetailReference` returned in the response when you created the token.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("recurringDetailReference", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// This is the `recurringDetailReference` returned in the response when you created the token.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("storedPaymentMethodId", NullValueHandling = NullValueHandling.Ignore)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// **directdebit_GB**
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Type5Enum? Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BACSDirectDebit : ({string.Join(", ", toStringOutput)})";
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
            return obj is BACSDirectDebit other &&                ((this.BankAccountNumber == null && other.BankAccountNumber == null) || (this.BankAccountNumber?.Equals(other.BankAccountNumber) == true)) &&
                ((this.BankLocationId == null && other.BankLocationId == null) || (this.BankLocationId?.Equals(other.BankLocationId) == true)) &&
                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.HolderName == null && other.HolderName == null) || (this.HolderName?.Equals(other.HolderName) == true)) &&
                ((this.RecurringDetailReference == null && other.RecurringDetailReference == null) || (this.RecurringDetailReference?.Equals(other.RecurringDetailReference) == true)) &&
                ((this.StoredPaymentMethodId == null && other.StoredPaymentMethodId == null) || (this.StoredPaymentMethodId?.Equals(other.StoredPaymentMethodId) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BankAccountNumber = {(this.BankAccountNumber == null ? "null" : this.BankAccountNumber)}");
            toStringOutput.Add($"this.BankLocationId = {(this.BankLocationId == null ? "null" : this.BankLocationId)}");
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.HolderName = {(this.HolderName == null ? "null" : this.HolderName)}");
            toStringOutput.Add($"this.RecurringDetailReference = {(this.RecurringDetailReference == null ? "null" : this.RecurringDetailReference)}");
            toStringOutput.Add($"this.StoredPaymentMethodId = {(this.StoredPaymentMethodId == null ? "null" : this.StoredPaymentMethodId)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
        }
    }
}