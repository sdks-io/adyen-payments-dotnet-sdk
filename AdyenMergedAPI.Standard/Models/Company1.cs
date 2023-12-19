// <copyright file="Company1.cs" company="APIMatic">
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
    /// Company1.
    /// </summary>
    public class Company1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company1"/> class.
        /// </summary>
        public Company1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Company1"/> class.
        /// </summary>
        /// <param name="homepage">homepage.</param>
        /// <param name="name">name.</param>
        /// <param name="registrationNumber">registrationNumber.</param>
        /// <param name="registryLocation">registryLocation.</param>
        /// <param name="taxId">taxId.</param>
        /// <param name="type">type.</param>
        public Company1(
            string homepage = null,
            string name = null,
            string registrationNumber = null,
            string registryLocation = null,
            string taxId = null,
            string type = null)
        {
            this.Homepage = homepage;
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.RegistryLocation = registryLocation;
            this.TaxId = taxId;
            this.Type = type;
        }

        /// <summary>
        /// The company website's home page.
        /// </summary>
        [JsonProperty("homepage", NullValueHandling = NullValueHandling.Ignore)]
        public string Homepage { get; set; }

        /// <summary>
        /// The company name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Registration number of the company.
        /// </summary>
        [JsonProperty("registrationNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Registry location of the company.
        /// </summary>
        [JsonProperty("registryLocation", NullValueHandling = NullValueHandling.Ignore)]
        public string RegistryLocation { get; set; }

        /// <summary>
        /// Tax ID of the company.
        /// </summary>
        [JsonProperty("taxId", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxId { get; set; }

        /// <summary>
        /// The company type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Company1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Company1 other &&                ((this.Homepage == null && other.Homepage == null) || (this.Homepage?.Equals(other.Homepage) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.RegistrationNumber == null && other.RegistrationNumber == null) || (this.RegistrationNumber?.Equals(other.RegistrationNumber) == true)) &&
                ((this.RegistryLocation == null && other.RegistryLocation == null) || (this.RegistryLocation?.Equals(other.RegistryLocation) == true)) &&
                ((this.TaxId == null && other.TaxId == null) || (this.TaxId?.Equals(other.TaxId) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Homepage = {(this.Homepage == null ? "null" : this.Homepage)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.RegistrationNumber = {(this.RegistrationNumber == null ? "null" : this.RegistrationNumber)}");
            toStringOutput.Add($"this.RegistryLocation = {(this.RegistryLocation == null ? "null" : this.RegistryLocation)}");
            toStringOutput.Add($"this.TaxId = {(this.TaxId == null ? "null" : this.TaxId)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}