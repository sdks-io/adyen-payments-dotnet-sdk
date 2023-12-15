// <copyright file="DonationRequest.cs" company="APIMatic">
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
    /// DonationRequest.
    /// </summary>
    public class DonationRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DonationRequest"/> class.
        /// </summary>
        public DonationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DonationRequest"/> class.
        /// </summary>
        /// <param name="donationAccount">donationAccount.</param>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="modificationAmount">modificationAmount.</param>
        /// <param name="originalReference">originalReference.</param>
        /// <param name="platformChargebackLogic">platformChargebackLogic.</param>
        /// <param name="reference">reference.</param>
        public DonationRequest(
            string donationAccount,
            string merchantAccount,
            Models.Amount3 modificationAmount,
            string originalReference = null,
            Models.PlatformChargebackLogic1 platformChargebackLogic = null,
            string reference = null)
        {
            this.DonationAccount = donationAccount;
            this.MerchantAccount = merchantAccount;
            this.ModificationAmount = modificationAmount;
            this.OriginalReference = originalReference;
            this.PlatformChargebackLogic = platformChargebackLogic;
            this.Reference = reference;
        }

        /// <summary>
        /// The Adyen account name of the charity.
        /// </summary>
        [JsonProperty("donationAccount")]
        public string DonationAccount { get; set; }

        /// <summary>
        /// The merchant account that is used to process the payment.
        /// </summary>
        [JsonProperty("merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The amount to be donated.The `currency` must match the currency used in authorisation, the `value` must be smaller than or equal to the authorised amount.
        /// </summary>
        [JsonProperty("modificationAmount")]
        public Models.Amount3 ModificationAmount { get; set; }

        /// <summary>
        /// The original pspReference of the payment to modify.
        /// This reference is returned in:
        /// * authorisation response
        /// * authorisation notification
        /// </summary>
        [JsonProperty("originalReference", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalReference { get; set; }

        /// <summary>
        /// Defines how to book chargebacks when using [Adyen for Platforms](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#chargebacks-and-disputes).
        /// </summary>
        [JsonProperty("platformChargebackLogic", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PlatformChargebackLogic1 PlatformChargebackLogic { get; set; }

        /// <summary>
        /// Your reference for the payment modification. This reference is visible in Customer Area and in reports.
        /// Maximum length: 80 characters.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DonationRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is DonationRequest other &&                ((this.DonationAccount == null && other.DonationAccount == null) || (this.DonationAccount?.Equals(other.DonationAccount) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.ModificationAmount == null && other.ModificationAmount == null) || (this.ModificationAmount?.Equals(other.ModificationAmount) == true)) &&
                ((this.OriginalReference == null && other.OriginalReference == null) || (this.OriginalReference?.Equals(other.OriginalReference) == true)) &&
                ((this.PlatformChargebackLogic == null && other.PlatformChargebackLogic == null) || (this.PlatformChargebackLogic?.Equals(other.PlatformChargebackLogic) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DonationAccount = {(this.DonationAccount == null ? "null" : this.DonationAccount)}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.ModificationAmount = {(this.ModificationAmount == null ? "null" : this.ModificationAmount.ToString())}");
            toStringOutput.Add($"this.OriginalReference = {(this.OriginalReference == null ? "null" : this.OriginalReference)}");
            toStringOutput.Add($"this.PlatformChargebackLogic = {(this.PlatformChargebackLogic == null ? "null" : this.PlatformChargebackLogic.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
        }
    }
}