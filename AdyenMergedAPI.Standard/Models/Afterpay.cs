// <copyright file="Afterpay.cs" company="APIMatic">
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
    /// Afterpay.
    /// </summary>
    public class Afterpay
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Afterpay"/> class.
        /// </summary>
        public Afterpay()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Afterpay"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="deliveryAddress">deliveryAddress.</param>
        /// <param name="personalDetails">personalDetails.</param>
        /// <param name="recurringDetailReference">recurringDetailReference.</param>
        /// <param name="storedPaymentMethodId">storedPaymentMethodId.</param>
        public Afterpay(
            Models.Type1Enum type,
            string billingAddress = null,
            string checkoutAttemptId = null,
            string deliveryAddress = null,
            string personalDetails = null,
            string recurringDetailReference = null,
            string storedPaymentMethodId = null)
        {
            this.BillingAddress = billingAddress;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.DeliveryAddress = deliveryAddress;
            this.PersonalDetails = personalDetails;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.Type = type;
        }

        /// <summary>
        /// The address where to send the invoice.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("billingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAddress { get; set; }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("checkoutAttemptId", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// The address where the goods should be delivered.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("deliveryAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// Shopper name, date of birth, phone number, and email address.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("personalDetails", NullValueHandling = NullValueHandling.Ignore)]
        public string PersonalDetails { get; set; }

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
        /// **afterpay_default**
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public Models.Type1Enum Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Afterpay : ({string.Join(", ", toStringOutput)})";
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
            return obj is Afterpay other &&                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.DeliveryAddress == null && other.DeliveryAddress == null) || (this.DeliveryAddress?.Equals(other.DeliveryAddress) == true)) &&
                ((this.PersonalDetails == null && other.PersonalDetails == null) || (this.PersonalDetails?.Equals(other.PersonalDetails) == true)) &&
                ((this.RecurringDetailReference == null && other.RecurringDetailReference == null) || (this.RecurringDetailReference?.Equals(other.RecurringDetailReference) == true)) &&
                ((this.StoredPaymentMethodId == null && other.StoredPaymentMethodId == null) || (this.StoredPaymentMethodId?.Equals(other.StoredPaymentMethodId) == true)) &&
                this.Type.Equals(other.Type);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress)}");
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.DeliveryAddress = {(this.DeliveryAddress == null ? "null" : this.DeliveryAddress)}");
            toStringOutput.Add($"this.PersonalDetails = {(this.PersonalDetails == null ? "null" : this.PersonalDetails)}");
            toStringOutput.Add($"this.RecurringDetailReference = {(this.RecurringDetailReference == null ? "null" : this.RecurringDetailReference)}");
            toStringOutput.Add($"this.StoredPaymentMethodId = {(this.StoredPaymentMethodId == null ? "null" : this.StoredPaymentMethodId)}");
            toStringOutput.Add($"this.Type = {this.Type}");
        }
    }
}