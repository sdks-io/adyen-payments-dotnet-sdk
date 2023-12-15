// <copyright file="ThreeDSecureData.cs" company="APIMatic">
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
    /// ThreeDSecureData.
    /// </summary>
    public class ThreeDSecureData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSecureData"/> class.
        /// </summary>
        public ThreeDSecureData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSecureData"/> class.
        /// </summary>
        /// <param name="authenticationResponse">authenticationResponse.</param>
        /// <param name="cavv">cavv.</param>
        /// <param name="cavvAlgorithm">cavvAlgorithm.</param>
        /// <param name="challengeCancel">challengeCancel.</param>
        /// <param name="directoryResponse">directoryResponse.</param>
        /// <param name="dsTransID">dsTransID.</param>
        /// <param name="eci">eci.</param>
        /// <param name="riskScore">riskScore.</param>
        /// <param name="threeDSVersion">threeDSVersion.</param>
        /// <param name="tokenAuthenticationVerificationValue">tokenAuthenticationVerificationValue.</param>
        /// <param name="transStatusReason">transStatusReason.</param>
        /// <param name="xid">xid.</param>
        public ThreeDSecureData(
            Models.AuthenticationResponseEnum? authenticationResponse = null,
            string cavv = null,
            string cavvAlgorithm = null,
            Models.ChallengeCancelEnum? challengeCancel = null,
            Models.DirectoryResponseEnum? directoryResponse = null,
            string dsTransID = null,
            string eci = null,
            string riskScore = null,
            string threeDSVersion = null,
            string tokenAuthenticationVerificationValue = null,
            string transStatusReason = null,
            string xid = null)
        {
            this.AuthenticationResponse = authenticationResponse;
            this.Cavv = cavv;
            this.CavvAlgorithm = cavvAlgorithm;
            this.ChallengeCancel = challengeCancel;
            this.DirectoryResponse = directoryResponse;
            this.DsTransID = dsTransID;
            this.Eci = eci;
            this.RiskScore = riskScore;
            this.ThreeDSVersion = threeDSVersion;
            this.TokenAuthenticationVerificationValue = tokenAuthenticationVerificationValue;
            this.TransStatusReason = transStatusReason;
            this.Xid = xid;
        }

        /// <summary>
        /// In 3D Secure 1, the authentication response if the shopper was redirected.
        /// In 3D Secure 2, this is the `transStatus` from the challenge result. If the transaction was frictionless, omit this parameter.
        /// </summary>
        [JsonProperty("authenticationResponse", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AuthenticationResponseEnum? AuthenticationResponse { get; set; }

        /// <summary>
        /// The cardholder authentication value (base64 encoded, 20 bytes in a decoded form).
        /// </summary>
        [JsonProperty("cavv", NullValueHandling = NullValueHandling.Ignore)]
        public string Cavv { get; set; }

        /// <summary>
        /// The CAVV algorithm used. Include this only for 3D Secure 1.
        /// </summary>
        [JsonProperty("cavvAlgorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string CavvAlgorithm { get; set; }

        /// <summary>
        /// Indicator informing the Access Control Server (ACS) and the Directory Server (DS) that the authentication has been cancelled. For possible values, refer to [3D Secure API reference](https://docs.adyen.com/online-payments/3d-secure/api-reference#mpidata).
        /// </summary>
        [JsonProperty("challengeCancel", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChallengeCancelEnum? ChallengeCancel { get; set; }

        /// <summary>
        /// In 3D Secure 1, this is the enrollment response from the 3D directory server.
        /// In 3D Secure 2, this is the `transStatus` from the `ARes`.
        /// </summary>
        [JsonProperty("directoryResponse", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectoryResponseEnum? DirectoryResponse { get; set; }

        /// <summary>
        /// Supported for 3D Secure 2. The unique transaction identifier assigned by the Directory Server (DS) to identify a single transaction.
        /// </summary>
        [JsonProperty("dsTransID", NullValueHandling = NullValueHandling.Ignore)]
        public string DsTransID { get; set; }

        /// <summary>
        /// The electronic commerce indicator.
        /// </summary>
        [JsonProperty("eci", NullValueHandling = NullValueHandling.Ignore)]
        public string Eci { get; set; }

        /// <summary>
        /// Risk score calculated by Directory Server (DS). Required for Cartes Bancaires integrations.
        /// </summary>
        [JsonProperty("riskScore", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskScore { get; set; }

        /// <summary>
        /// The version of the 3D Secure protocol.
        /// </summary>
        [JsonProperty("threeDSVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSVersion { get; set; }

        /// <summary>
        /// Network token authentication verification value (TAVV). The network token cryptogram.
        /// </summary>
        [JsonProperty("tokenAuthenticationVerificationValue", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenAuthenticationVerificationValue { get; set; }

        /// <summary>
        /// Provides information on why the `transStatus` field has the specified value. For possible values, refer to [our docs](https://docs.adyen.com/online-payments/3d-secure/api-reference#possible-transstatusreason-values).
        /// </summary>
        [JsonProperty("transStatusReason", NullValueHandling = NullValueHandling.Ignore)]
        public string TransStatusReason { get; set; }

        /// <summary>
        /// Supported for 3D Secure 1. The transaction identifier (Base64-encoded, 20 bytes in a decoded form).
        /// </summary>
        [JsonProperty("xid", NullValueHandling = NullValueHandling.Ignore)]
        public string Xid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ThreeDSecureData : ({string.Join(", ", toStringOutput)})";
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
            return obj is ThreeDSecureData other &&                ((this.AuthenticationResponse == null && other.AuthenticationResponse == null) || (this.AuthenticationResponse?.Equals(other.AuthenticationResponse) == true)) &&
                ((this.Cavv == null && other.Cavv == null) || (this.Cavv?.Equals(other.Cavv) == true)) &&
                ((this.CavvAlgorithm == null && other.CavvAlgorithm == null) || (this.CavvAlgorithm?.Equals(other.CavvAlgorithm) == true)) &&
                ((this.ChallengeCancel == null && other.ChallengeCancel == null) || (this.ChallengeCancel?.Equals(other.ChallengeCancel) == true)) &&
                ((this.DirectoryResponse == null && other.DirectoryResponse == null) || (this.DirectoryResponse?.Equals(other.DirectoryResponse) == true)) &&
                ((this.DsTransID == null && other.DsTransID == null) || (this.DsTransID?.Equals(other.DsTransID) == true)) &&
                ((this.Eci == null && other.Eci == null) || (this.Eci?.Equals(other.Eci) == true)) &&
                ((this.RiskScore == null && other.RiskScore == null) || (this.RiskScore?.Equals(other.RiskScore) == true)) &&
                ((this.ThreeDSVersion == null && other.ThreeDSVersion == null) || (this.ThreeDSVersion?.Equals(other.ThreeDSVersion) == true)) &&
                ((this.TokenAuthenticationVerificationValue == null && other.TokenAuthenticationVerificationValue == null) || (this.TokenAuthenticationVerificationValue?.Equals(other.TokenAuthenticationVerificationValue) == true)) &&
                ((this.TransStatusReason == null && other.TransStatusReason == null) || (this.TransStatusReason?.Equals(other.TransStatusReason) == true)) &&
                ((this.Xid == null && other.Xid == null) || (this.Xid?.Equals(other.Xid) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AuthenticationResponse = {(this.AuthenticationResponse == null ? "null" : this.AuthenticationResponse.ToString())}");
            toStringOutput.Add($"this.Cavv = {(this.Cavv == null ? "null" : this.Cavv)}");
            toStringOutput.Add($"this.CavvAlgorithm = {(this.CavvAlgorithm == null ? "null" : this.CavvAlgorithm)}");
            toStringOutput.Add($"this.ChallengeCancel = {(this.ChallengeCancel == null ? "null" : this.ChallengeCancel.ToString())}");
            toStringOutput.Add($"this.DirectoryResponse = {(this.DirectoryResponse == null ? "null" : this.DirectoryResponse.ToString())}");
            toStringOutput.Add($"this.DsTransID = {(this.DsTransID == null ? "null" : this.DsTransID)}");
            toStringOutput.Add($"this.Eci = {(this.Eci == null ? "null" : this.Eci)}");
            toStringOutput.Add($"this.RiskScore = {(this.RiskScore == null ? "null" : this.RiskScore)}");
            toStringOutput.Add($"this.ThreeDSVersion = {(this.ThreeDSVersion == null ? "null" : this.ThreeDSVersion)}");
            toStringOutput.Add($"this.TokenAuthenticationVerificationValue = {(this.TokenAuthenticationVerificationValue == null ? "null" : this.TokenAuthenticationVerificationValue)}");
            toStringOutput.Add($"this.TransStatusReason = {(this.TransStatusReason == null ? "null" : this.TransStatusReason)}");
            toStringOutput.Add($"this.Xid = {(this.Xid == null ? "null" : this.Xid)}");
        }
    }
}