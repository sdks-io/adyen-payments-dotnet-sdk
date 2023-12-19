// <copyright file="PaymentResponse4.cs" company="APIMatic">
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
    /// PaymentResponse4.
    /// </summary>
    public class PaymentResponse4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponse4"/> class.
        /// </summary>
        public PaymentResponse4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponse4"/> class.
        /// </summary>
        /// <param name="brand">brand.</param>
        /// <param name="type">type.</param>
        public PaymentResponse4(
            string brand = null,
            string type = null)
        {
            this.Brand = brand;
            this.Type = type;
        }

        /// <summary>
        /// The card brand that the shopper used to pay. Only returned if `paymentMethod.type` is **scheme**.
        /// </summary>
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public string Brand { get; set; }

        /// <summary>
        /// The `paymentMethod.type` value used in the request.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentResponse4 : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentResponse4 other &&                ((this.Brand == null && other.Brand == null) || (this.Brand?.Equals(other.Brand) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Brand = {(this.Brand == null ? "null" : this.Brand)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}