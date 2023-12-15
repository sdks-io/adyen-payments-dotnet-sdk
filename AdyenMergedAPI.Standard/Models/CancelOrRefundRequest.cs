// <copyright file="CancelOrRefundRequest.cs" company="APIMatic">
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
    /// CancelOrRefundRequest.
    /// </summary>
    public class CancelOrRefundRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrRefundRequest"/> class.
        /// </summary>
        public CancelOrRefundRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrRefundRequest"/> class.
        /// </summary>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="originalReference">originalReference.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="mpiData">mpiData.</param>
        /// <param name="originalMerchantReference">originalMerchantReference.</param>
        /// <param name="platformChargebackLogic">platformChargebackLogic.</param>
        /// <param name="reference">reference.</param>
        /// <param name="tenderReference">tenderReference.</param>
        /// <param name="uniqueTerminalId">uniqueTerminalId.</param>
        public CancelOrRefundRequest(
            string merchantAccount,
            string originalReference,
            Dictionary<string, string> additionalData = null,
            Models.ThreeDSecureData1 mpiData = null,
            string originalMerchantReference = null,
            Models.PlatformChargebackLogic1 platformChargebackLogic = null,
            string reference = null,
            string tenderReference = null,
            string uniqueTerminalId = null)
        {
            this.AdditionalData = additionalData;
            this.MerchantAccount = merchantAccount;
            this.MpiData = mpiData;
            this.OriginalMerchantReference = originalMerchantReference;
            this.OriginalReference = originalReference;
            this.PlatformChargebackLogic = platformChargebackLogic;
            this.Reference = reference;
            this.TenderReference = tenderReference;
            this.UniqueTerminalId = uniqueTerminalId;
        }

        /// <summary>
        /// This field contains additional data, which may be required for a particular modification request.
        /// The additionalData object consists of entries, each of which includes the key and value.
        /// </summary>
        [JsonProperty("additionalData", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// The merchant account that is used to process the payment.
        /// </summary>
        [JsonProperty("merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Authentication data produced by an MPI (Mastercard SecureCode, Visa Secure, or Cartes Bancaires).
        /// </summary>
        [JsonProperty("mpiData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDSecureData1 MpiData { get; set; }

        /// <summary>
        /// The original merchant reference to cancel.
        /// </summary>
        [JsonProperty("originalMerchantReference", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalMerchantReference { get; set; }

        /// <summary>
        /// The original pspReference of the payment to modify.
        /// This reference is returned in:
        /// * authorisation response
        /// * authorisation notification
        /// </summary>
        [JsonProperty("originalReference")]
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

        /// <summary>
        /// The transaction reference provided by the PED. For point-of-sale integrations only.
        /// </summary>
        [JsonProperty("tenderReference", NullValueHandling = NullValueHandling.Ignore)]
        public string TenderReference { get; set; }

        /// <summary>
        /// Unique terminal ID for the PED that originally processed the request. For point-of-sale integrations only.
        /// </summary>
        [JsonProperty("uniqueTerminalId", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueTerminalId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CancelOrRefundRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CancelOrRefundRequest other &&                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.MpiData == null && other.MpiData == null) || (this.MpiData?.Equals(other.MpiData) == true)) &&
                ((this.OriginalMerchantReference == null && other.OriginalMerchantReference == null) || (this.OriginalMerchantReference?.Equals(other.OriginalMerchantReference) == true)) &&
                ((this.OriginalReference == null && other.OriginalReference == null) || (this.OriginalReference?.Equals(other.OriginalReference) == true)) &&
                ((this.PlatformChargebackLogic == null && other.PlatformChargebackLogic == null) || (this.PlatformChargebackLogic?.Equals(other.PlatformChargebackLogic) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.TenderReference == null && other.TenderReference == null) || (this.TenderReference?.Equals(other.TenderReference) == true)) &&
                ((this.UniqueTerminalId == null && other.UniqueTerminalId == null) || (this.UniqueTerminalId?.Equals(other.UniqueTerminalId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.MpiData = {(this.MpiData == null ? "null" : this.MpiData.ToString())}");
            toStringOutput.Add($"this.OriginalMerchantReference = {(this.OriginalMerchantReference == null ? "null" : this.OriginalMerchantReference)}");
            toStringOutput.Add($"this.OriginalReference = {(this.OriginalReference == null ? "null" : this.OriginalReference)}");
            toStringOutput.Add($"this.PlatformChargebackLogic = {(this.PlatformChargebackLogic == null ? "null" : this.PlatformChargebackLogic.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.TenderReference = {(this.TenderReference == null ? "null" : this.TenderReference)}");
            toStringOutput.Add($"this.UniqueTerminalId = {(this.UniqueTerminalId == null ? "null" : this.UniqueTerminalId)}");
        }
    }
}