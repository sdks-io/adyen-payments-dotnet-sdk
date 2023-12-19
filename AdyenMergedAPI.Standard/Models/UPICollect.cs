// <copyright file="UPICollect.cs" company="APIMatic">
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
    /// UPICollect.
    /// </summary>
    public class UPICollect
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UPICollect"/> class.
        /// </summary>
        public UPICollect()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UPICollect"/> class.
        /// </summary>
        /// <param name="billingSequenceNumber">billingSequenceNumber.</param>
        /// <param name="type">type.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="recurringDetailReference">recurringDetailReference.</param>
        /// <param name="shopperNotificationReference">shopperNotificationReference.</param>
        /// <param name="storedPaymentMethodId">storedPaymentMethodId.</param>
        /// <param name="virtualPaymentAddress">virtualPaymentAddress.</param>
        public UPICollect(
            string billingSequenceNumber,
            string type,
            string checkoutAttemptId = null,
            string recurringDetailReference = null,
            string shopperNotificationReference = null,
            string storedPaymentMethodId = null,
            string virtualPaymentAddress = null)
        {
            this.BillingSequenceNumber = billingSequenceNumber;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.RecurringDetailReference = recurringDetailReference;
            this.ShopperNotificationReference = shopperNotificationReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.Type = type;
            this.VirtualPaymentAddress = virtualPaymentAddress;
        }

        /// <summary>
        /// The sequence number for the debit. For example, send **2** if this is the second debit for the subscription. The sequence number is included in the notification sent to the shopper.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("billingSequenceNumber")]
        [JsonRequired]
        public string BillingSequenceNumber { get; set; }

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
        /// The `shopperNotificationReference` returned in the response when you requested to notify the shopper. Used for recurring payment only.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("shopperNotificationReference", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperNotificationReference { get; set; }

        /// <summary>
        /// This is the `recurringDetailReference` returned in the response when you created the token.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("storedPaymentMethodId", NullValueHandling = NullValueHandling.Ignore)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// **upi_collect**
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("type")]
        [JsonRequired]
        public string Type { get; set; }

        /// <summary>
        /// The virtual payment address for UPI.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("virtualPaymentAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string VirtualPaymentAddress { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UPICollect : ({string.Join(", ", toStringOutput)})";
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
            return obj is UPICollect other &&                ((this.BillingSequenceNumber == null && other.BillingSequenceNumber == null) || (this.BillingSequenceNumber?.Equals(other.BillingSequenceNumber) == true)) &&
                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.RecurringDetailReference == null && other.RecurringDetailReference == null) || (this.RecurringDetailReference?.Equals(other.RecurringDetailReference) == true)) &&
                ((this.ShopperNotificationReference == null && other.ShopperNotificationReference == null) || (this.ShopperNotificationReference?.Equals(other.ShopperNotificationReference) == true)) &&
                ((this.StoredPaymentMethodId == null && other.StoredPaymentMethodId == null) || (this.StoredPaymentMethodId?.Equals(other.StoredPaymentMethodId) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.VirtualPaymentAddress == null && other.VirtualPaymentAddress == null) || (this.VirtualPaymentAddress?.Equals(other.VirtualPaymentAddress) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BillingSequenceNumber = {(this.BillingSequenceNumber == null ? "null" : this.BillingSequenceNumber)}");
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.RecurringDetailReference = {(this.RecurringDetailReference == null ? "null" : this.RecurringDetailReference)}");
            toStringOutput.Add($"this.ShopperNotificationReference = {(this.ShopperNotificationReference == null ? "null" : this.ShopperNotificationReference)}");
            toStringOutput.Add($"this.StoredPaymentMethodId = {(this.StoredPaymentMethodId == null ? "null" : this.StoredPaymentMethodId)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.VirtualPaymentAddress = {(this.VirtualPaymentAddress == null ? "null" : this.VirtualPaymentAddress)}");
        }
    }
}