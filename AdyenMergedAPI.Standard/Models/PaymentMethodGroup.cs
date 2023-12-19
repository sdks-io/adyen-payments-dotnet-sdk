// <copyright file="PaymentMethodGroup.cs" company="APIMatic">
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
    /// PaymentMethodGroup.
    /// </summary>
    public class PaymentMethodGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodGroup"/> class.
        /// </summary>
        public PaymentMethodGroup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodGroup"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="paymentMethodData">paymentMethodData.</param>
        /// <param name="type">type.</param>
        public PaymentMethodGroup(
            string name = null,
            string paymentMethodData = null,
            string type = null)
        {
            this.Name = name;
            this.PaymentMethodData = paymentMethodData;
            this.Type = type;
        }

        /// <summary>
        /// The name of the group.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Echo data to be used if the payment method is displayed as part of this group.
        /// </summary>
        [JsonProperty("paymentMethodData", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentMethodData { get; set; }

        /// <summary>
        /// The unique code of the group.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentMethodGroup : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentMethodGroup other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.PaymentMethodData == null && other.PaymentMethodData == null) || (this.PaymentMethodData?.Equals(other.PaymentMethodData) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.PaymentMethodData = {(this.PaymentMethodData == null ? "null" : this.PaymentMethodData)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}