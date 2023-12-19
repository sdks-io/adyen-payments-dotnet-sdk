// <copyright file="SubMerchantInfo.cs" company="APIMatic">
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
    /// SubMerchantInfo.
    /// </summary>
    public class SubMerchantInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubMerchantInfo"/> class.
        /// </summary>
        public SubMerchantInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubMerchantInfo"/> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="id">id.</param>
        /// <param name="mcc">mcc.</param>
        /// <param name="name">name.</param>
        /// <param name="taxId">taxId.</param>
        public SubMerchantInfo(
            Models.BillingAddress address = null,
            string id = null,
            string mcc = null,
            string name = null,
            string taxId = null)
        {
            this.Address = address;
            this.Id = id;
            this.Mcc = mcc;
            this.Name = name;
            this.TaxId = taxId;
        }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingAddress Address { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Mcc.
        /// </summary>
        [JsonProperty("mcc", NullValueHandling = NullValueHandling.Ignore)]
        public string Mcc { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets TaxId.
        /// </summary>
        [JsonProperty("taxId", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubMerchantInfo : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubMerchantInfo other &&                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
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
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Mcc = {(this.Mcc == null ? "null" : this.Mcc)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.TaxId = {(this.TaxId == null ? "null" : this.TaxId)}");
        }
    }
}