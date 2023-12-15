// <copyright file="ResponseAdditionalData3DSecure.cs" company="APIMatic">
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
    /// ResponseAdditionalData3DSecure.
    /// </summary>
    public class ResponseAdditionalData3DSecure
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalData3DSecure"/> class.
        /// </summary>
        public ResponseAdditionalData3DSecure()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalData3DSecure"/> class.
        /// </summary>
        /// <param name="cardHolderInfo">cardHolderInfo.</param>
        /// <param name="cavv">cavv.</param>
        /// <param name="cavvAlgorithm">cavvAlgorithm.</param>
        /// <param name="scaExemptionRequested">scaExemptionRequested.</param>
        /// <param name="threeds2CardEnrolled">threeds2.cardEnrolled.</param>
        public ResponseAdditionalData3DSecure(
            string cardHolderInfo = null,
            string cavv = null,
            string cavvAlgorithm = null,
            string scaExemptionRequested = null,
            bool? threeds2CardEnrolled = null)
        {
            this.CardHolderInfo = cardHolderInfo;
            this.Cavv = cavv;
            this.CavvAlgorithm = cavvAlgorithm;
            this.ScaExemptionRequested = scaExemptionRequested;
            this.Threeds2CardEnrolled = threeds2CardEnrolled;
        }

        /// <summary>
        /// Information provided by the issuer to the cardholder. If this field is present, you need to display this information to the cardholder.
        /// </summary>
        [JsonProperty("cardHolderInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string CardHolderInfo { get; set; }

        /// <summary>
        /// The Cardholder Authentication Verification Value (CAVV) for the 3D Secure authentication session, as a Base64-encoded 20-byte array.
        /// </summary>
        [JsonProperty("cavv", NullValueHandling = NullValueHandling.Ignore)]
        public string Cavv { get; set; }

        /// <summary>
        /// The CAVV algorithm used.
        /// </summary>
        [JsonProperty("cavvAlgorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string CavvAlgorithm { get; set; }

        /// <summary>
        /// Shows the [exemption type](https://docs.adyen.com/payments-fundamentals/psd2-sca-compliance-and-implementation-guide#specifypreferenceinyourapirequest) that Adyen requested for the payment.
        ///  Possible values:
        /// * **lowValue**
        /// * **secureCorporate**
        /// * **trustedBeneficiary**
        /// * **transactionRiskAnalysis**
        /// </summary>
        [JsonProperty("scaExemptionRequested", NullValueHandling = NullValueHandling.Ignore)]
        public string ScaExemptionRequested { get; set; }

        /// <summary>
        /// Indicates whether a card is enrolled for 3D Secure 2.
        /// </summary>
        [JsonProperty("threeds2.cardEnrolled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Threeds2CardEnrolled { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseAdditionalData3DSecure : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResponseAdditionalData3DSecure other &&                ((this.CardHolderInfo == null && other.CardHolderInfo == null) || (this.CardHolderInfo?.Equals(other.CardHolderInfo) == true)) &&
                ((this.Cavv == null && other.Cavv == null) || (this.Cavv?.Equals(other.Cavv) == true)) &&
                ((this.CavvAlgorithm == null && other.CavvAlgorithm == null) || (this.CavvAlgorithm?.Equals(other.CavvAlgorithm) == true)) &&
                ((this.ScaExemptionRequested == null && other.ScaExemptionRequested == null) || (this.ScaExemptionRequested?.Equals(other.ScaExemptionRequested) == true)) &&
                ((this.Threeds2CardEnrolled == null && other.Threeds2CardEnrolled == null) || (this.Threeds2CardEnrolled?.Equals(other.Threeds2CardEnrolled) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardHolderInfo = {(this.CardHolderInfo == null ? "null" : this.CardHolderInfo)}");
            toStringOutput.Add($"this.Cavv = {(this.Cavv == null ? "null" : this.Cavv)}");
            toStringOutput.Add($"this.CavvAlgorithm = {(this.CavvAlgorithm == null ? "null" : this.CavvAlgorithm)}");
            toStringOutput.Add($"this.ScaExemptionRequested = {(this.ScaExemptionRequested == null ? "null" : this.ScaExemptionRequested)}");
            toStringOutput.Add($"this.Threeds2CardEnrolled = {(this.Threeds2CardEnrolled == null ? "null" : this.Threeds2CardEnrolled.ToString())}");
        }
    }
}