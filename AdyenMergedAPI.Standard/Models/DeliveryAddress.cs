// <copyright file="DeliveryAddress.cs" company="APIMatic">
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
    /// DeliveryAddress.
    /// </summary>
    public class DeliveryAddress
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryAddress"/> class.
        /// </summary>
        public DeliveryAddress()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryAddress"/> class.
        /// </summary>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="houseNumberOrName">houseNumberOrName.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="street">street.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="stateOrProvince">stateOrProvince.</param>
        public DeliveryAddress(
            string city,
            string country,
            string houseNumberOrName,
            string postalCode,
            string street,
            string firstName = null,
            string lastName = null,
            string stateOrProvince = null)
        {
            this.City = city;
            this.Country = country;
            this.FirstName = firstName;
            this.HouseNumberOrName = houseNumberOrName;
            this.LastName = lastName;
            this.PostalCode = postalCode;
            this.StateOrProvince = stateOrProvince;
            this.Street = street;
        }

        /// <summary>
        /// The name of the city. Maximum length: 3000 characters.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The two-character ISO-3166-1 alpha-2 country code. For example, **US**.
        /// > If you don't know the country or are not collecting the country from the shopper, provide `country` as `ZZ`.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets FirstName.
        /// </summary>
        [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// The number or name of the house. Maximum length: 3000 characters.
        /// </summary>
        [JsonProperty("houseNumberOrName")]
        public string HouseNumberOrName { get; set; }

        /// <summary>
        /// Gets or sets LastName.
        /// </summary>
        [JsonProperty("lastName", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// A maximum of five digits for an address in the US, or a maximum of ten characters for an address in all other countries.
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The two-character ISO 3166-2 state or province code. For example, **CA** in the US or **ON** in Canada.
        /// > Required for the US and Canada.
        /// </summary>
        [JsonProperty("stateOrProvince", NullValueHandling = NullValueHandling.Ignore)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// The name of the street. Maximum length: 3000 characters.
        /// > The house number should not be included in this field; it should be separately provided via `houseNumberOrName`.
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeliveryAddress : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeliveryAddress other &&                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.HouseNumberOrName == null && other.HouseNumberOrName == null) || (this.HouseNumberOrName?.Equals(other.HouseNumberOrName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.PostalCode == null && other.PostalCode == null) || (this.PostalCode?.Equals(other.PostalCode) == true)) &&
                ((this.StateOrProvince == null && other.StateOrProvince == null) || (this.StateOrProvince?.Equals(other.StateOrProvince) == true)) &&
                ((this.Street == null && other.Street == null) || (this.Street?.Equals(other.Street) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.HouseNumberOrName = {(this.HouseNumberOrName == null ? "null" : this.HouseNumberOrName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.PostalCode = {(this.PostalCode == null ? "null" : this.PostalCode)}");
            toStringOutput.Add($"this.StateOrProvince = {(this.StateOrProvince == null ? "null" : this.StateOrProvince)}");
            toStringOutput.Add($"this.Street = {(this.Street == null ? "null" : this.Street)}");
        }
    }
}