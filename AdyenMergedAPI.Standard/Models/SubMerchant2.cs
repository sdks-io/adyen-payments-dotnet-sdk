// <copyright file="SubMerchant2.cs" company="APIMatic">
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
    /// SubMerchant2.
    /// </summary>
    public class SubMerchant2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubMerchant2"/> class.
        /// </summary>
        public SubMerchant2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubMerchant2"/> class.
        /// </summary>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="mcc">mcc.</param>
        /// <param name="name">name.</param>
        /// <param name="taxId">taxId.</param>
        public SubMerchant2(
            string city = null,
            string country = null,
            string mcc = null,
            string name = null,
            string taxId = null)
        {
            this.City = city;
            this.Country = country;
            this.Mcc = mcc;
            this.Name = name;
            this.TaxId = taxId;
        }

        /// <summary>
        /// The city of the sub-merchant's address.
        /// * Format: Alphanumeric
        /// * Maximum length: 13 characters
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// The three-letter country code of the sub-merchant's address. For example, **BRA** for Brazil.
        /// * Format: [ISO 3166-1 alpha-3](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3)
        /// * Fixed length: 3 characters
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// The sub-merchant's 4-digit Merchant Category Code (MCC).
        /// * Format: Numeric
        /// * Fixed length: 4 digits
        /// </summary>
        [JsonProperty("mcc", NullValueHandling = NullValueHandling.Ignore)]
        public string Mcc { get; set; }

        /// <summary>
        /// The name of the sub-merchant. Based on scheme specifications, this value will overwrite the shopper statement  that will appear in the card statement.
        /// * Format: Alphanumeric
        /// * Maximum length: 22 characters
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The tax ID of the sub-merchant.
        /// * Format: Numeric
        /// * Fixed length: 11 digits for the CPF or 14 digits for the CNPJ
        /// </summary>
        [JsonProperty("taxId", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubMerchant2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubMerchant2 other &&                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.Mcc == null && other.Mcc == null) || (this.Mcc?.Equals(other.Mcc) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.TaxId == null && other.TaxId == null) || (this.TaxId?.Equals(other.TaxId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.Mcc = {(this.Mcc == null ? "null" : this.Mcc)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.TaxId = {(this.TaxId == null ? "null" : this.TaxId)}");
        }
    }
}