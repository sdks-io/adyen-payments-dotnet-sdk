// <copyright file="Dragonpay.cs" company="APIMatic">
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
    /// Dragonpay.
    /// </summary>
    public class Dragonpay
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dragonpay"/> class.
        /// </summary>
        public Dragonpay()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dragonpay"/> class.
        /// </summary>
        /// <param name="issuer">issuer.</param>
        /// <param name="type">type.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="shopperEmail">shopperEmail.</param>
        public Dragonpay(
            string issuer,
            Models.Type17Enum type,
            string checkoutAttemptId = null,
            string shopperEmail = null)
        {
            this.CheckoutAttemptId = checkoutAttemptId;
            this.Issuer = issuer;
            this.ShopperEmail = shopperEmail;
            this.Type = type;
        }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("checkoutAttemptId", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// The Dragonpay issuer value of the shopper's selected bank. Set this to an **id** of a Dragonpay issuer to preselect it.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("issuer")]
        [JsonRequired]
        public string Issuer { get; set; }

        /// <summary>
        /// The shopper’s email address.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("shopperEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// **dragonpay**
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public Models.Type17Enum Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Dragonpay : ({string.Join(", ", toStringOutput)})";
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
            return obj is Dragonpay other &&                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.Issuer == null && other.Issuer == null) || (this.Issuer?.Equals(other.Issuer) == true)) &&
                ((this.ShopperEmail == null && other.ShopperEmail == null) || (this.ShopperEmail?.Equals(other.ShopperEmail) == true)) &&
                this.Type.Equals(other.Type);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.Issuer = {(this.Issuer == null ? "null" : this.Issuer)}");
            toStringOutput.Add($"this.ShopperEmail = {(this.ShopperEmail == null ? "null" : this.ShopperEmail)}");
            toStringOutput.Add($"this.Type = {this.Type}");
        }
    }
}