// <copyright file="MBWay.cs" company="APIMatic">
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
    /// MBWay.
    /// </summary>
    public class MBWay
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MBWay"/> class.
        /// </summary>
        public MBWay()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MBWay"/> class.
        /// </summary>
        /// <param name="shopperEmail">shopperEmail.</param>
        /// <param name="telephoneNumber">telephoneNumber.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="type">type.</param>
        public MBWay(
            string shopperEmail,
            string telephoneNumber,
            string checkoutAttemptId = null,
            Models.Type23Enum? type = Models.Type23Enum.Mbway)
        {
            this.CheckoutAttemptId = checkoutAttemptId;
            this.ShopperEmail = shopperEmail;
            this.TelephoneNumber = telephoneNumber;
            this.Type = type;
        }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("checkoutAttemptId", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// Gets or sets ShopperEmail.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("shopperEmail")]
        [JsonRequired]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// Gets or sets TelephoneNumber.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("telephoneNumber")]
        [JsonRequired]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// **mbway**
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Type23Enum? Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MBWay : ({string.Join(", ", toStringOutput)})";
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
            return obj is MBWay other &&                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.ShopperEmail == null && other.ShopperEmail == null) || (this.ShopperEmail?.Equals(other.ShopperEmail) == true)) &&
                ((this.TelephoneNumber == null && other.TelephoneNumber == null) || (this.TelephoneNumber?.Equals(other.TelephoneNumber) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.ShopperEmail = {(this.ShopperEmail == null ? "null" : this.ShopperEmail)}");
            toStringOutput.Add($"this.TelephoneNumber = {(this.TelephoneNumber == null ? "null" : this.TelephoneNumber)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
        }
    }
}