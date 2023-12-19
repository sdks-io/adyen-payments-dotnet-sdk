// <copyright file="FundOrigin1.cs" company="APIMatic">
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
    /// FundOrigin1.
    /// </summary>
    public class FundOrigin1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundOrigin1"/> class.
        /// </summary>
        public FundOrigin1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundOrigin1"/> class.
        /// </summary>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="shopperName">shopperName.</param>
        public FundOrigin1(
            Models.Address billingAddress = null,
            Models.Name1 shopperName = null)
        {
            this.BillingAddress = billingAddress;
            this.ShopperName = shopperName;
        }

        /// <summary>
        /// The address where to send the invoice.
        /// </summary>
        [JsonProperty("billingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address BillingAddress { get; set; }

        /// <summary>
        /// The name of the person
        /// </summary>
        [JsonProperty("shopperName", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Name1 ShopperName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FundOrigin1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is FundOrigin1 other &&                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.ShopperName == null && other.ShopperName == null) || (this.ShopperName?.Equals(other.ShopperName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.ShopperName = {(this.ShopperName == null ? "null" : this.ShopperName.ToString())}");
        }
    }
}