// <copyright file="PaymentMethodIssuer.cs" company="APIMatic">
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
    /// PaymentMethodIssuer.
    /// </summary>
    public class PaymentMethodIssuer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodIssuer"/> class.
        /// </summary>
        public PaymentMethodIssuer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodIssuer"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="disabled">disabled.</param>
        public PaymentMethodIssuer(
            string id,
            string name,
            bool? disabled = false)
        {
            this.Disabled = disabled;
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// A boolean value indicating whether this issuer is unavailable. Can be `true` whenever the issuer is offline.
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// The unique identifier of this issuer, to submit in requests to /payments.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// A localized name of the issuer.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentMethodIssuer : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentMethodIssuer other &&                ((this.Disabled == null && other.Disabled == null) || (this.Disabled?.Equals(other.Disabled) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Disabled = {(this.Disabled == null ? "null" : this.Disabled.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
        }
    }
}