// <copyright file="AdditionalDataModifications.cs" company="APIMatic">
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
    /// AdditionalDataModifications.
    /// </summary>
    public class AdditionalDataModifications
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataModifications"/> class.
        /// </summary>
        public AdditionalDataModifications()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataModifications"/> class.
        /// </summary>
        /// <param name="installmentPaymentDataSelectedInstallmentOption">installmentPaymentData.selectedInstallmentOption.</param>
        public AdditionalDataModifications(
            string installmentPaymentDataSelectedInstallmentOption = null)
        {
            this.InstallmentPaymentDataSelectedInstallmentOption = installmentPaymentDataSelectedInstallmentOption;
        }

        /// <summary>
        /// This is the installment option selected by the shopper. It is required only if specified by the user.
        /// </summary>
        [JsonProperty("installmentPaymentData.selectedInstallmentOption", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentPaymentDataSelectedInstallmentOption { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalDataModifications : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdditionalDataModifications other &&                ((this.InstallmentPaymentDataSelectedInstallmentOption == null && other.InstallmentPaymentDataSelectedInstallmentOption == null) || (this.InstallmentPaymentDataSelectedInstallmentOption?.Equals(other.InstallmentPaymentDataSelectedInstallmentOption) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InstallmentPaymentDataSelectedInstallmentOption = {(this.InstallmentPaymentDataSelectedInstallmentOption == null ? "null" : this.InstallmentPaymentDataSelectedInstallmentOption)}");
        }
    }
}