// <copyright file="BLIK.cs" company="APIMatic">
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
    /// BLIK.
    /// </summary>
    public class BLIK
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BLIK"/> class.
        /// </summary>
        public BLIK()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BLIK"/> class.
        /// </summary>
        /// <param name="blikCode">blikCode.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="recurringDetailReference">recurringDetailReference.</param>
        /// <param name="storedPaymentMethodId">storedPaymentMethodId.</param>
        /// <param name="type">type.</param>
        public BLIK(
            string blikCode = null,
            string checkoutAttemptId = null,
            string recurringDetailReference = null,
            string storedPaymentMethodId = null,
            Models.Type8Enum? type = null)
        {
            this.BlikCode = blikCode;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.Type = type;
        }

        /// <summary>
        /// BLIK code consisting of 6 digits.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("blikCode", NullValueHandling = NullValueHandling.Ignore)]
        public string BlikCode { get; set; }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("checkoutAttemptId", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckoutAttemptId { get; set; }

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
        /// **blik**
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Type8Enum? Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BLIK : ({string.Join(", ", toStringOutput)})";
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
            return obj is BLIK other &&                ((this.BlikCode == null && other.BlikCode == null) || (this.BlikCode?.Equals(other.BlikCode) == true)) &&
                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
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
            toStringOutput.Add($"this.BlikCode = {(this.BlikCode == null ? "null" : this.BlikCode)}");
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.RecurringDetailReference = {(this.RecurringDetailReference == null ? "null" : this.RecurringDetailReference)}");
            toStringOutput.Add($"this.StoredPaymentMethodId = {(this.StoredPaymentMethodId == null ? "null" : this.StoredPaymentMethodId)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
        }
    }
}