// <copyright file="PaymentMethodsResponse.cs" company="APIMatic">
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
    /// PaymentMethodsResponse.
    /// </summary>
    public class PaymentMethodsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodsResponse"/> class.
        /// </summary>
        public PaymentMethodsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodsResponse"/> class.
        /// </summary>
        /// <param name="paymentMethods">paymentMethods.</param>
        /// <param name="storedPaymentMethods">storedPaymentMethods.</param>
        public PaymentMethodsResponse(
            List<Models.PaymentMethod> paymentMethods = null,
            List<Models.StoredPaymentMethod> storedPaymentMethods = null)
        {
            this.PaymentMethods = paymentMethods;
            this.StoredPaymentMethods = storedPaymentMethods;
        }

        /// <summary>
        /// Detailed list of payment methods required to generate payment forms.
        /// </summary>
        [JsonProperty("paymentMethods", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PaymentMethod> PaymentMethods { get; set; }

        /// <summary>
        /// List of all stored payment methods.
        /// </summary>
        [JsonProperty("storedPaymentMethods", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.StoredPaymentMethod> StoredPaymentMethods { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentMethodsResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentMethodsResponse other &&                ((this.PaymentMethods == null && other.PaymentMethods == null) || (this.PaymentMethods?.Equals(other.PaymentMethods) == true)) &&
                ((this.StoredPaymentMethods == null && other.StoredPaymentMethods == null) || (this.StoredPaymentMethods?.Equals(other.StoredPaymentMethods) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PaymentMethods = {(this.PaymentMethods == null ? "null" : $"[{string.Join(", ", this.PaymentMethods)} ]")}");
            toStringOutput.Add($"this.StoredPaymentMethods = {(this.StoredPaymentMethods == null ? "null" : $"[{string.Join(", ", this.StoredPaymentMethods)} ]")}");
        }
    }
}