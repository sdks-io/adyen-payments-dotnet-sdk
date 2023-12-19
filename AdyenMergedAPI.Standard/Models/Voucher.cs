// <copyright file="Voucher.cs" company="APIMatic">
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
    /// Voucher.
    /// </summary>
    public class Voucher
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Voucher"/> class.
        /// </summary>
        public Voucher()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Voucher"/> class.
        /// </summary>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="shopperEmail">shopperEmail.</param>
        /// <param name="telephoneNumber">telephoneNumber.</param>
        /// <param name="type">type.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        public Voucher(
            string firstName,
            string lastName,
            string shopperEmail,
            string telephoneNumber,
            Models.Type18Enum type,
            string checkoutAttemptId = null)
        {
            this.CheckoutAttemptId = checkoutAttemptId;
            this.FirstName = firstName;
            this.LastName = lastName;
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
        /// The shopper's first name.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("firstName")]
        [JsonRequired]
        public string FirstName { get; set; }

        /// <summary>
        /// The shopper's last name.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("lastName")]
        [JsonRequired]
        public string LastName { get; set; }

        /// <summary>
        /// The shopper's email.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("shopperEmail")]
        [JsonRequired]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// The shopper's contact number. It must have an international number format, for example **+31 20 779 1846**. Formats like **+31 (0)20 779 1846** or **0031 20 779 1846** are not accepted.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("telephoneNumber")]
        [JsonRequired]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// **econtextvoucher**
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public Models.Type18Enum Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Voucher : ({string.Join(", ", toStringOutput)})";
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
            return obj is Voucher other &&                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.ShopperEmail == null && other.ShopperEmail == null) || (this.ShopperEmail?.Equals(other.ShopperEmail) == true)) &&
                ((this.TelephoneNumber == null && other.TelephoneNumber == null) || (this.TelephoneNumber?.Equals(other.TelephoneNumber) == true)) &&
                this.Type.Equals(other.Type);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.ShopperEmail = {(this.ShopperEmail == null ? "null" : this.ShopperEmail)}");
            toStringOutput.Add($"this.TelephoneNumber = {(this.TelephoneNumber == null ? "null" : this.TelephoneNumber)}");
            toStringOutput.Add($"this.Type = {this.Type}");
        }
    }
}