// <copyright file="PaymentMethod.cs" company="APIMatic">
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
    /// PaymentMethod.
    /// </summary>
    public class PaymentMethod
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod"/> class.
        /// </summary>
        public PaymentMethod()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod"/> class.
        /// </summary>
        /// <param name="brand">brand.</param>
        /// <param name="brands">brands.</param>
        /// <param name="configuration">configuration.</param>
        /// <param name="fundingSource">fundingSource.</param>
        /// <param name="mGroup">group.</param>
        /// <param name="inputDetails">inputDetails.</param>
        /// <param name="issuers">issuers.</param>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        public PaymentMethod(
            string brand = null,
            List<string> brands = null,
            Dictionary<string, string> configuration = null,
            Models.FundingSource5Enum? fundingSource = null,
            Models.PaymentMethodGroup2 mGroup = null,
            List<Models.InputDetail> inputDetails = null,
            List<Models.PaymentMethodIssuer> issuers = null,
            string name = null,
            string type = null)
        {
            this.Brand = brand;
            this.Brands = brands;
            this.Configuration = configuration;
            this.FundingSource = fundingSource;
            this.MGroup = mGroup;
            this.InputDetails = inputDetails;
            this.Issuers = issuers;
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Brand for the selected gift card. For example: plastix, hmclub.
        /// </summary>
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public string Brand { get; set; }

        /// <summary>
        /// List of possible brands. For example: visa, mc.
        /// </summary>
        [JsonProperty("brands", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Brands { get; set; }

        /// <summary>
        /// The configuration of the payment method.
        /// </summary>
        [JsonProperty("configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Configuration { get; set; }

        /// <summary>
        /// The funding source of the payment method.
        /// </summary>
        [JsonProperty("fundingSource", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FundingSource5Enum? FundingSource { get; set; }

        /// <summary>
        /// The group where this payment method belongs to.
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentMethodGroup2 MGroup { get; set; }

        /// <summary>
        /// All input details to be provided to complete the payment with this payment method.
        /// </summary>
        [JsonProperty("inputDetails", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InputDetail> InputDetails { get; set; }

        /// <summary>
        /// A list of issuers for this payment method.
        /// </summary>
        [JsonProperty("issuers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PaymentMethodIssuer> Issuers { get; set; }

        /// <summary>
        /// The displayable name of this payment method.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The unique payment method code.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentMethod : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentMethod other &&                ((this.Brand == null && other.Brand == null) || (this.Brand?.Equals(other.Brand) == true)) &&
                ((this.Brands == null && other.Brands == null) || (this.Brands?.Equals(other.Brands) == true)) &&
                ((this.Configuration == null && other.Configuration == null) || (this.Configuration?.Equals(other.Configuration) == true)) &&
                ((this.FundingSource == null && other.FundingSource == null) || (this.FundingSource?.Equals(other.FundingSource) == true)) &&
                ((this.MGroup == null && other.MGroup == null) || (this.MGroup?.Equals(other.MGroup) == true)) &&
                ((this.InputDetails == null && other.InputDetails == null) || (this.InputDetails?.Equals(other.InputDetails) == true)) &&
                ((this.Issuers == null && other.Issuers == null) || (this.Issuers?.Equals(other.Issuers) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Brand = {(this.Brand == null ? "null" : this.Brand)}");
            toStringOutput.Add($"this.Brands = {(this.Brands == null ? "null" : $"[{string.Join(", ", this.Brands)} ]")}");
            toStringOutput.Add($"Configuration = {(this.Configuration == null ? "null" : this.Configuration.ToString())}");
            toStringOutput.Add($"this.FundingSource = {(this.FundingSource == null ? "null" : this.FundingSource.ToString())}");
            toStringOutput.Add($"this.MGroup = {(this.MGroup == null ? "null" : this.MGroup.ToString())}");
            toStringOutput.Add($"this.InputDetails = {(this.InputDetails == null ? "null" : $"[{string.Join(", ", this.InputDetails)} ]")}");
            toStringOutput.Add($"this.Issuers = {(this.Issuers == null ? "null" : $"[{string.Join(", ", this.Issuers)} ]")}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}