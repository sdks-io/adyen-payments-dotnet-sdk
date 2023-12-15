// <copyright file="ThreeDS2Result1.cs" company="APIMatic">
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
    /// ThreeDS2Result1.
    /// </summary>
    public class ThreeDS2Result1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDS2Result1"/> class.
        /// </summary>
        public ThreeDS2Result1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDS2Result1"/> class.
        /// </summary>
        /// <param name="authenticationValue">authenticationValue.</param>
        /// <param name="cavvAlgorithm">cavvAlgorithm.</param>
        /// <param name="challengeCancel">challengeCancel.</param>
        /// <param name="dsTransID">dsTransID.</param>
        /// <param name="eci">eci.</param>
        /// <param name="exemptionIndicator">exemptionIndicator.</param>
        /// <param name="messageVersion">messageVersion.</param>
        /// <param name="riskScore">riskScore.</param>
        /// <param name="threeDSRequestorChallengeInd">threeDSRequestorChallengeInd.</param>
        /// <param name="threeDSServerTransID">threeDSServerTransID.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="transStatus">transStatus.</param>
        /// <param name="transStatusReason">transStatusReason.</param>
        /// <param name="whiteListStatus">whiteListStatus.</param>
        public ThreeDS2Result1(
            string authenticationValue = null,
            string cavvAlgorithm = null,
            Models.ChallengeCancelEnum? challengeCancel = null,
            string dsTransID = null,
            string eci = null,
            Models.ExemptionIndicatorEnum? exemptionIndicator = null,
            string messageVersion = null,
            string riskScore = null,
            Models.ThreeDSRequestorChallengeIndEnum? threeDSRequestorChallengeInd = null,
            string threeDSServerTransID = null,
            string timestamp = null,
            string transStatus = null,
            string transStatusReason = null,
            string whiteListStatus = null)
        {
            this.AuthenticationValue = authenticationValue;
            this.CavvAlgorithm = cavvAlgorithm;
            this.ChallengeCancel = challengeCancel;
            this.DsTransID = dsTransID;
            this.Eci = eci;
            this.ExemptionIndicator = exemptionIndicator;
            this.MessageVersion = messageVersion;
            this.RiskScore = riskScore;
            this.ThreeDSRequestorChallengeInd = threeDSRequestorChallengeInd;
            this.ThreeDSServerTransID = threeDSServerTransID;
            this.Timestamp = timestamp;
            this.TransStatus = transStatus;
            this.TransStatusReason = transStatusReason;
            this.WhiteListStatus = whiteListStatus;
        }

        /// <summary>
        /// The `authenticationValue` value as defined in the 3D Secure 2 specification.
        /// </summary>
        [JsonProperty("authenticationValue", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthenticationValue { get; set; }

        /// <summary>
        /// The algorithm used by the ACS to calculate the authentication value, only for Cartes Bancaires integrations.
        /// </summary>
        [JsonProperty("cavvAlgorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string CavvAlgorithm { get; set; }

        /// <summary>
        /// Indicator informing the Access Control Server (ACS) and the Directory Server (DS) that the authentication has been cancelled. For possible values, refer to [3D Secure API reference](https://docs.adyen.com/online-payments/3d-secure/api-reference#mpidata).
        /// </summary>
        [JsonProperty("challengeCancel", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChallengeCancelEnum? ChallengeCancel { get; set; }

        /// <summary>
        /// The `dsTransID` value as defined in the 3D Secure 2 specification.
        /// </summary>
        [JsonProperty("dsTransID", NullValueHandling = NullValueHandling.Ignore)]
        public string DsTransID { get; set; }

        /// <summary>
        /// The `eci` value as defined in the 3D Secure 2 specification.
        /// </summary>
        [JsonProperty("eci", NullValueHandling = NullValueHandling.Ignore)]
        public string Eci { get; set; }

        /// <summary>
        /// Indicates the exemption type that was applied by the issuer to the authentication, if exemption applied.
        /// Allowed values:
        /// * `lowValue`
        /// * `secureCorporate`
        /// * `trustedBeneficiary`
        /// * `transactionRiskAnalysis`
        /// </summary>
        [JsonProperty("exemptionIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ExemptionIndicatorEnum? ExemptionIndicator { get; set; }

        /// <summary>
        /// The `messageVersion` value as defined in the 3D Secure 2 specification.
        /// </summary>
        [JsonProperty("messageVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageVersion { get; set; }

        /// <summary>
        /// Risk score calculated by Cartes Bancaires Directory Server (DS).
        /// </summary>
        [JsonProperty("riskScore", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskScore { get; set; }

        /// <summary>
        /// Indicates whether a challenge is requested for this transaction. Possible values:
        /// * **01** — No preference
        /// * **02** — No challenge requested
        /// * **03** — Challenge requested (3DS Requestor preference)
        /// * **04** — Challenge requested (Mandate)
        /// * **05** — No challenge (transactional risk analysis is already performed)
        /// * **06** — Data Only
        /// </summary>
        [JsonProperty("threeDSRequestorChallengeInd", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDSRequestorChallengeIndEnum? ThreeDSRequestorChallengeInd { get; set; }

        /// <summary>
        /// The `threeDSServerTransID` value as defined in the 3D Secure 2 specification.
        /// </summary>
        [JsonProperty("threeDSServerTransID", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSServerTransID { get; set; }

        /// <summary>
        /// The `timestamp` value of the 3D Secure 2 authentication.
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// The `transStatus` value as defined in the 3D Secure 2 specification.
        /// </summary>
        [JsonProperty("transStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string TransStatus { get; set; }

        /// <summary>
        /// Provides information on why the `transStatus` field has the specified value. For possible values, refer to [our docs](https://docs.adyen.com/online-payments/3d-secure/api-reference#possible-transstatusreason-values).
        /// </summary>
        [JsonProperty("transStatusReason", NullValueHandling = NullValueHandling.Ignore)]
        public string TransStatusReason { get; set; }

        /// <summary>
        /// The `whiteListStatus` value as defined in the 3D Secure 2 specification.
        /// </summary>
        [JsonProperty("whiteListStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string WhiteListStatus { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ThreeDS2Result1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is ThreeDS2Result1 other &&                ((this.AuthenticationValue == null && other.AuthenticationValue == null) || (this.AuthenticationValue?.Equals(other.AuthenticationValue) == true)) &&
                ((this.CavvAlgorithm == null && other.CavvAlgorithm == null) || (this.CavvAlgorithm?.Equals(other.CavvAlgorithm) == true)) &&
                ((this.ChallengeCancel == null && other.ChallengeCancel == null) || (this.ChallengeCancel?.Equals(other.ChallengeCancel) == true)) &&
                ((this.DsTransID == null && other.DsTransID == null) || (this.DsTransID?.Equals(other.DsTransID) == true)) &&
                ((this.Eci == null && other.Eci == null) || (this.Eci?.Equals(other.Eci) == true)) &&
                ((this.ExemptionIndicator == null && other.ExemptionIndicator == null) || (this.ExemptionIndicator?.Equals(other.ExemptionIndicator) == true)) &&
                ((this.MessageVersion == null && other.MessageVersion == null) || (this.MessageVersion?.Equals(other.MessageVersion) == true)) &&
                ((this.RiskScore == null && other.RiskScore == null) || (this.RiskScore?.Equals(other.RiskScore) == true)) &&
                ((this.ThreeDSRequestorChallengeInd == null && other.ThreeDSRequestorChallengeInd == null) || (this.ThreeDSRequestorChallengeInd?.Equals(other.ThreeDSRequestorChallengeInd) == true)) &&
                ((this.ThreeDSServerTransID == null && other.ThreeDSServerTransID == null) || (this.ThreeDSServerTransID?.Equals(other.ThreeDSServerTransID) == true)) &&
                ((this.Timestamp == null && other.Timestamp == null) || (this.Timestamp?.Equals(other.Timestamp) == true)) &&
                ((this.TransStatus == null && other.TransStatus == null) || (this.TransStatus?.Equals(other.TransStatus) == true)) &&
                ((this.TransStatusReason == null && other.TransStatusReason == null) || (this.TransStatusReason?.Equals(other.TransStatusReason) == true)) &&
                ((this.WhiteListStatus == null && other.WhiteListStatus == null) || (this.WhiteListStatus?.Equals(other.WhiteListStatus) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AuthenticationValue = {(this.AuthenticationValue == null ? "null" : this.AuthenticationValue)}");
            toStringOutput.Add($"this.CavvAlgorithm = {(this.CavvAlgorithm == null ? "null" : this.CavvAlgorithm)}");
            toStringOutput.Add($"this.ChallengeCancel = {(this.ChallengeCancel == null ? "null" : this.ChallengeCancel.ToString())}");
            toStringOutput.Add($"this.DsTransID = {(this.DsTransID == null ? "null" : this.DsTransID)}");
            toStringOutput.Add($"this.Eci = {(this.Eci == null ? "null" : this.Eci)}");
            toStringOutput.Add($"this.ExemptionIndicator = {(this.ExemptionIndicator == null ? "null" : this.ExemptionIndicator.ToString())}");
            toStringOutput.Add($"this.MessageVersion = {(this.MessageVersion == null ? "null" : this.MessageVersion)}");
            toStringOutput.Add($"this.RiskScore = {(this.RiskScore == null ? "null" : this.RiskScore)}");
            toStringOutput.Add($"this.ThreeDSRequestorChallengeInd = {(this.ThreeDSRequestorChallengeInd == null ? "null" : this.ThreeDSRequestorChallengeInd.ToString())}");
            toStringOutput.Add($"this.ThreeDSServerTransID = {(this.ThreeDSServerTransID == null ? "null" : this.ThreeDSServerTransID)}");
            toStringOutput.Add($"this.Timestamp = {(this.Timestamp == null ? "null" : this.Timestamp)}");
            toStringOutput.Add($"this.TransStatus = {(this.TransStatus == null ? "null" : this.TransStatus)}");
            toStringOutput.Add($"this.TransStatusReason = {(this.TransStatusReason == null ? "null" : this.TransStatusReason)}");
            toStringOutput.Add($"this.WhiteListStatus = {(this.WhiteListStatus == null ? "null" : this.WhiteListStatus)}");
        }
    }
}