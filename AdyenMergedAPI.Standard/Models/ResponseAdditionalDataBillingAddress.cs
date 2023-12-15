// <copyright file="ResponseAdditionalDataBillingAddress.cs" company="APIMatic">
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
    /// ResponseAdditionalDataBillingAddress.
    /// </summary>
    public class ResponseAdditionalDataBillingAddress
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataBillingAddress"/> class.
        /// </summary>
        public ResponseAdditionalDataBillingAddress()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataBillingAddress"/> class.
        /// </summary>
        /// <param name="billingAddressCity">billingAddress.city.</param>
        /// <param name="billingAddressCountry">billingAddress.country.</param>
        /// <param name="billingAddressHouseNumberOrName">billingAddress.houseNumberOrName.</param>
        /// <param name="billingAddressPostalCode">billingAddress.postalCode.</param>
        /// <param name="billingAddressStateOrProvince">billingAddress.stateOrProvince.</param>
        /// <param name="billingAddressStreet">billingAddress.street.</param>
        public ResponseAdditionalDataBillingAddress(
            string billingAddressCity = null,
            string billingAddressCountry = null,
            string billingAddressHouseNumberOrName = null,
            string billingAddressPostalCode = null,
            string billingAddressStateOrProvince = null,
            string billingAddressStreet = null)
        {
            this.BillingAddressCity = billingAddressCity;
            this.BillingAddressCountry = billingAddressCountry;
            this.BillingAddressHouseNumberOrName = billingAddressHouseNumberOrName;
            this.BillingAddressPostalCode = billingAddressPostalCode;
            this.BillingAddressStateOrProvince = billingAddressStateOrProvince;
            this.BillingAddressStreet = billingAddressStreet;
        }

        /// <summary>
        /// The billing address city passed in the payment request.
        /// </summary>
        [JsonProperty("billingAddress.city", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAddressCity { get; set; }

        /// <summary>
        /// The billing address country passed in the payment request.
        /// Example: NL
        /// </summary>
        [JsonProperty("billingAddress.country", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAddressCountry { get; set; }

        /// <summary>
        /// The billing address house number or name passed in the payment request.
        /// </summary>
        [JsonProperty("billingAddress.houseNumberOrName", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAddressHouseNumberOrName { get; set; }

        /// <summary>
        /// The billing address postal code passed in the payment request.
        /// Example: 1011 DJ
        /// </summary>
        [JsonProperty("billingAddress.postalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAddressPostalCode { get; set; }

        /// <summary>
        /// The billing address state or province passed in the payment request.
        /// Example: NH
        /// </summary>
        [JsonProperty("billingAddress.stateOrProvince", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAddressStateOrProvince { get; set; }

        /// <summary>
        /// The billing address street passed in the payment request.
        /// </summary>
        [JsonProperty("billingAddress.street", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAddressStreet { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseAdditionalDataBillingAddress : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResponseAdditionalDataBillingAddress other &&                ((this.BillingAddressCity == null && other.BillingAddressCity == null) || (this.BillingAddressCity?.Equals(other.BillingAddressCity) == true)) &&
                ((this.BillingAddressCountry == null && other.BillingAddressCountry == null) || (this.BillingAddressCountry?.Equals(other.BillingAddressCountry) == true)) &&
                ((this.BillingAddressHouseNumberOrName == null && other.BillingAddressHouseNumberOrName == null) || (this.BillingAddressHouseNumberOrName?.Equals(other.BillingAddressHouseNumberOrName) == true)) &&
                ((this.BillingAddressPostalCode == null && other.BillingAddressPostalCode == null) || (this.BillingAddressPostalCode?.Equals(other.BillingAddressPostalCode) == true)) &&
                ((this.BillingAddressStateOrProvince == null && other.BillingAddressStateOrProvince == null) || (this.BillingAddressStateOrProvince?.Equals(other.BillingAddressStateOrProvince) == true)) &&
                ((this.BillingAddressStreet == null && other.BillingAddressStreet == null) || (this.BillingAddressStreet?.Equals(other.BillingAddressStreet) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BillingAddressCity = {(this.BillingAddressCity == null ? "null" : this.BillingAddressCity)}");
            toStringOutput.Add($"this.BillingAddressCountry = {(this.BillingAddressCountry == null ? "null" : this.BillingAddressCountry)}");
            toStringOutput.Add($"this.BillingAddressHouseNumberOrName = {(this.BillingAddressHouseNumberOrName == null ? "null" : this.BillingAddressHouseNumberOrName)}");
            toStringOutput.Add($"this.BillingAddressPostalCode = {(this.BillingAddressPostalCode == null ? "null" : this.BillingAddressPostalCode)}");
            toStringOutput.Add($"this.BillingAddressStateOrProvince = {(this.BillingAddressStateOrProvince == null ? "null" : this.BillingAddressStateOrProvince)}");
            toStringOutput.Add($"this.BillingAddressStreet = {(this.BillingAddressStreet == null ? "null" : this.BillingAddressStreet)}");
        }
    }
}