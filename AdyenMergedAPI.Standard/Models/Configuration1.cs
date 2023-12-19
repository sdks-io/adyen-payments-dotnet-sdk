// <copyright file="Configuration1.cs" company="APIMatic">
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
    /// Configuration1.
    /// </summary>
    public class Configuration1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration1"/> class.
        /// </summary>
        public Configuration1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration1"/> class.
        /// </summary>
        /// <param name="avs">avs.</param>
        /// <param name="cardHolderName">cardHolderName.</param>
        /// <param name="installments">installments.</param>
        /// <param name="shopperInput">shopperInput.</param>
        public Configuration1(
            Models.Avs1 avs = null,
            Models.CardHolderNameEnum? cardHolderName = null,
            Models.InstallmentsNumber2 installments = null,
            Models.ShopperInput2 shopperInput = null)
        {
            this.Avs = avs;
            this.CardHolderName = cardHolderName;
            this.Installments = installments;
            this.ShopperInput = shopperInput;
        }

        /// <summary>
        /// Describes the configuration for AVS ([Address Verification System](https://en.wikipedia.org/wiki/Address_Verification_System)).
        /// </summary>
        [JsonProperty("avs", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Avs1 Avs { get; set; }

        /// <summary>
        /// Determines whether the cardholder name should be provided or not.
        /// Permitted values:
        /// * NONE
        /// * OPTIONAL
        /// * REQUIRED
        /// </summary>
        [JsonProperty("cardHolderName", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardHolderNameEnum? CardHolderName { get; set; }

        /// <summary>
        /// Describes the configuration for [installment payments](https://docs.adyen.com/payment-methods/cards/credit-card-installments).
        /// </summary>
        [JsonProperty("installments", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InstallmentsNumber2 Installments { get; set; }

        /// <summary>
        /// Determines how to display the details fields.
        /// </summary>
        [JsonProperty("shopperInput", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ShopperInput2 ShopperInput { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Configuration1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Configuration1 other &&                ((this.Avs == null && other.Avs == null) || (this.Avs?.Equals(other.Avs) == true)) &&
                ((this.CardHolderName == null && other.CardHolderName == null) || (this.CardHolderName?.Equals(other.CardHolderName) == true)) &&
                ((this.Installments == null && other.Installments == null) || (this.Installments?.Equals(other.Installments) == true)) &&
                ((this.ShopperInput == null && other.ShopperInput == null) || (this.ShopperInput?.Equals(other.ShopperInput) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Avs = {(this.Avs == null ? "null" : this.Avs.ToString())}");
            toStringOutput.Add($"this.CardHolderName = {(this.CardHolderName == null ? "null" : this.CardHolderName.ToString())}");
            toStringOutput.Add($"this.Installments = {(this.Installments == null ? "null" : this.Installments.ToString())}");
            toStringOutput.Add($"this.ShopperInput = {(this.ShopperInput == null ? "null" : this.ShopperInput.ToString())}");
        }
    }
}