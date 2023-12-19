// <copyright file="PaymentSetupResponse.cs" company="APIMatic">
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
    /// PaymentSetupResponse.
    /// </summary>
    public class PaymentSetupResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSetupResponse"/> class.
        /// </summary>
        public PaymentSetupResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSetupResponse"/> class.
        /// </summary>
        /// <param name="paymentSession">paymentSession.</param>
        /// <param name="recurringDetails">recurringDetails.</param>
        public PaymentSetupResponse(
            string paymentSession = null,
            List<Models.RecurringDetail> recurringDetails = null)
        {
            this.PaymentSession = paymentSession;
            this.RecurringDetails = recurringDetails;
        }

        /// <summary>
        /// The encoded payment session that you need to pass to the SDK.
        /// </summary>
        [JsonProperty("paymentSession", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentSession { get; set; }

        /// <summary>
        /// The detailed list of stored payment details required to generate payment forms. Will be empty if oneClick is set to false in the request.
        /// </summary>
        [JsonProperty("recurringDetails", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RecurringDetail> RecurringDetails { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentSetupResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentSetupResponse other &&                ((this.PaymentSession == null && other.PaymentSession == null) || (this.PaymentSession?.Equals(other.PaymentSession) == true)) &&
                ((this.RecurringDetails == null && other.RecurringDetails == null) || (this.RecurringDetails?.Equals(other.RecurringDetails) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PaymentSession = {(this.PaymentSession == null ? "null" : this.PaymentSession)}");
            toStringOutput.Add($"this.RecurringDetails = {(this.RecurringDetails == null ? "null" : $"[{string.Join(", ", this.RecurringDetails)} ]")}");
        }
    }
}