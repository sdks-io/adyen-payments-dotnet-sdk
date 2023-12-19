// <copyright file="PayPal.cs" company="APIMatic">
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
    /// PayPal.
    /// </summary>
    public class PayPal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayPal"/> class.
        /// </summary>
        public PayPal()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayPal"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="orderID">orderID.</param>
        /// <param name="payeePreferred">payeePreferred.</param>
        /// <param name="payerID">payerID.</param>
        /// <param name="payerSelected">payerSelected.</param>
        /// <param name="recurringDetailReference">recurringDetailReference.</param>
        /// <param name="storedPaymentMethodId">storedPaymentMethodId.</param>
        /// <param name="subtype">subtype.</param>
        public PayPal(
            string type,
            string checkoutAttemptId = null,
            string orderID = null,
            string payeePreferred = null,
            string payerID = null,
            string payerSelected = null,
            string recurringDetailReference = null,
            string storedPaymentMethodId = null,
            Models.SubtypeEnum? subtype = null)
        {
            this.CheckoutAttemptId = checkoutAttemptId;
            this.OrderID = orderID;
            this.PayeePreferred = payeePreferred;
            this.PayerID = payerID;
            this.PayerSelected = payerSelected;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.Subtype = subtype;
            this.Type = type;
        }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("checkoutAttemptId", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// The unique ID associated with the order.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("orderID", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderID { get; set; }

        /// <summary>
        /// IMMEDIATE_PAYMENT_REQUIRED or UNRESTRICTED
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("payeePreferred", NullValueHandling = NullValueHandling.Ignore)]
        public string PayeePreferred { get; set; }

        /// <summary>
        /// The unique ID associated with the payer.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("payerID", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerID { get; set; }

        /// <summary>
        /// PAYPAL or PAYPAL_CREDIT
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("payerSelected", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerSelected { get; set; }

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
        /// The type of flow to initiate.
        /// </summary>
        [JsonProperty("subtype", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubtypeEnum? Subtype { get; set; }

        /// <summary>
        /// **paypal**
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("type")]
        [JsonRequired]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PayPal : ({string.Join(", ", toStringOutput)})";
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
            return obj is PayPal other &&                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.OrderID == null && other.OrderID == null) || (this.OrderID?.Equals(other.OrderID) == true)) &&
                ((this.PayeePreferred == null && other.PayeePreferred == null) || (this.PayeePreferred?.Equals(other.PayeePreferred) == true)) &&
                ((this.PayerID == null && other.PayerID == null) || (this.PayerID?.Equals(other.PayerID) == true)) &&
                ((this.PayerSelected == null && other.PayerSelected == null) || (this.PayerSelected?.Equals(other.PayerSelected) == true)) &&
                ((this.RecurringDetailReference == null && other.RecurringDetailReference == null) || (this.RecurringDetailReference?.Equals(other.RecurringDetailReference) == true)) &&
                ((this.StoredPaymentMethodId == null && other.StoredPaymentMethodId == null) || (this.StoredPaymentMethodId?.Equals(other.StoredPaymentMethodId) == true)) &&
                ((this.Subtype == null && other.Subtype == null) || (this.Subtype?.Equals(other.Subtype) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.OrderID = {(this.OrderID == null ? "null" : this.OrderID)}");
            toStringOutput.Add($"this.PayeePreferred = {(this.PayeePreferred == null ? "null" : this.PayeePreferred)}");
            toStringOutput.Add($"this.PayerID = {(this.PayerID == null ? "null" : this.PayerID)}");
            toStringOutput.Add($"this.PayerSelected = {(this.PayerSelected == null ? "null" : this.PayerSelected)}");
            toStringOutput.Add($"this.RecurringDetailReference = {(this.RecurringDetailReference == null ? "null" : this.RecurringDetailReference)}");
            toStringOutput.Add($"this.StoredPaymentMethodId = {(this.StoredPaymentMethodId == null ? "null" : this.StoredPaymentMethodId)}");
            toStringOutput.Add($"this.Subtype = {(this.Subtype == null ? "null" : this.Subtype.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}