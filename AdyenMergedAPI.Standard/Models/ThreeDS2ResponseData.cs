// <copyright file="ThreeDS2ResponseData.cs" company="APIMatic">
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
    /// ThreeDS2ResponseData.
    /// </summary>
    public class ThreeDS2ResponseData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDS2ResponseData"/> class.
        /// </summary>
        public ThreeDS2ResponseData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDS2ResponseData"/> class.
        /// </summary>
        /// <param name="acsChallengeMandated">acsChallengeMandated.</param>
        /// <param name="acsOperatorID">acsOperatorID.</param>
        /// <param name="acsReferenceNumber">acsReferenceNumber.</param>
        /// <param name="acsSignedContent">acsSignedContent.</param>
        /// <param name="acsTransID">acsTransID.</param>
        /// <param name="acsURL">acsURL.</param>
        /// <param name="authenticationType">authenticationType.</param>
        /// <param name="cardHolderInfo">cardHolderInfo.</param>
        /// <param name="cavvAlgorithm">cavvAlgorithm.</param>
        /// <param name="challengeIndicator">challengeIndicator.</param>
        /// <param name="dsReferenceNumber">dsReferenceNumber.</param>
        /// <param name="dsTransID">dsTransID.</param>
        /// <param name="exemptionIndicator">exemptionIndicator.</param>
        /// <param name="messageVersion">messageVersion.</param>
        /// <param name="riskScore">riskScore.</param>
        /// <param name="sdkEphemPubKey">sdkEphemPubKey.</param>
        /// <param name="threeDSServerTransID">threeDSServerTransID.</param>
        /// <param name="transStatus">transStatus.</param>
        /// <param name="transStatusReason">transStatusReason.</param>
        public ThreeDS2ResponseData(
            string acsChallengeMandated = null,
            string acsOperatorID = null,
            string acsReferenceNumber = null,
            string acsSignedContent = null,
            string acsTransID = null,
            string acsURL = null,
            string authenticationType = null,
            string cardHolderInfo = null,
            string cavvAlgorithm = null,
            string challengeIndicator = null,
            string dsReferenceNumber = null,
            string dsTransID = null,
            string exemptionIndicator = null,
            string messageVersion = null,
            string riskScore = null,
            string sdkEphemPubKey = null,
            string threeDSServerTransID = null,
            string transStatus = null,
            string transStatusReason = null)
        {
            this.AcsChallengeMandated = acsChallengeMandated;
            this.AcsOperatorID = acsOperatorID;
            this.AcsReferenceNumber = acsReferenceNumber;
            this.AcsSignedContent = acsSignedContent;
            this.AcsTransID = acsTransID;
            this.AcsURL = acsURL;
            this.AuthenticationType = authenticationType;
            this.CardHolderInfo = cardHolderInfo;
            this.CavvAlgorithm = cavvAlgorithm;
            this.ChallengeIndicator = challengeIndicator;
            this.DsReferenceNumber = dsReferenceNumber;
            this.DsTransID = dsTransID;
            this.ExemptionIndicator = exemptionIndicator;
            this.MessageVersion = messageVersion;
            this.RiskScore = riskScore;
            this.SdkEphemPubKey = sdkEphemPubKey;
            this.ThreeDSServerTransID = threeDSServerTransID;
            this.TransStatus = transStatus;
            this.TransStatusReason = transStatusReason;
        }

        /// <summary>
        /// Gets or sets AcsChallengeMandated.
        /// </summary>
        [JsonProperty("acsChallengeMandated", NullValueHandling = NullValueHandling.Ignore)]
        public string AcsChallengeMandated { get; set; }

        /// <summary>
        /// Gets or sets AcsOperatorID.
        /// </summary>
        [JsonProperty("acsOperatorID", NullValueHandling = NullValueHandling.Ignore)]
        public string AcsOperatorID { get; set; }

        /// <summary>
        /// Gets or sets AcsReferenceNumber.
        /// </summary>
        [JsonProperty("acsReferenceNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AcsReferenceNumber { get; set; }

        /// <summary>
        /// Gets or sets AcsSignedContent.
        /// </summary>
        [JsonProperty("acsSignedContent", NullValueHandling = NullValueHandling.Ignore)]
        public string AcsSignedContent { get; set; }

        /// <summary>
        /// Gets or sets AcsTransID.
        /// </summary>
        [JsonProperty("acsTransID", NullValueHandling = NullValueHandling.Ignore)]
        public string AcsTransID { get; set; }

        /// <summary>
        /// Gets or sets AcsURL.
        /// </summary>
        [JsonProperty("acsURL", NullValueHandling = NullValueHandling.Ignore)]
        public string AcsURL { get; set; }

        /// <summary>
        /// Gets or sets AuthenticationType.
        /// </summary>
        [JsonProperty("authenticationType", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets CardHolderInfo.
        /// </summary>
        [JsonProperty("cardHolderInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string CardHolderInfo { get; set; }

        /// <summary>
        /// Gets or sets CavvAlgorithm.
        /// </summary>
        [JsonProperty("cavvAlgorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string CavvAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets ChallengeIndicator.
        /// </summary>
        [JsonProperty("challengeIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public string ChallengeIndicator { get; set; }

        /// <summary>
        /// Gets or sets DsReferenceNumber.
        /// </summary>
        [JsonProperty("dsReferenceNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string DsReferenceNumber { get; set; }

        /// <summary>
        /// Gets or sets DsTransID.
        /// </summary>
        [JsonProperty("dsTransID", NullValueHandling = NullValueHandling.Ignore)]
        public string DsTransID { get; set; }

        /// <summary>
        /// Gets or sets ExemptionIndicator.
        /// </summary>
        [JsonProperty("exemptionIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public string ExemptionIndicator { get; set; }

        /// <summary>
        /// Gets or sets MessageVersion.
        /// </summary>
        [JsonProperty("messageVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageVersion { get; set; }

        /// <summary>
        /// Gets or sets RiskScore.
        /// </summary>
        [JsonProperty("riskScore", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskScore { get; set; }

        /// <summary>
        /// Gets or sets SdkEphemPubKey.
        /// </summary>
        [JsonProperty("sdkEphemPubKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SdkEphemPubKey { get; set; }

        /// <summary>
        /// Gets or sets ThreeDSServerTransID.
        /// </summary>
        [JsonProperty("threeDSServerTransID", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSServerTransID { get; set; }

        /// <summary>
        /// Gets or sets TransStatus.
        /// </summary>
        [JsonProperty("transStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string TransStatus { get; set; }

        /// <summary>
        /// Gets or sets TransStatusReason.
        /// </summary>
        [JsonProperty("transStatusReason", NullValueHandling = NullValueHandling.Ignore)]
        public string TransStatusReason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ThreeDS2ResponseData : ({string.Join(", ", toStringOutput)})";
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
            return obj is ThreeDS2ResponseData other &&                ((this.AcsChallengeMandated == null && other.AcsChallengeMandated == null) || (this.AcsChallengeMandated?.Equals(other.AcsChallengeMandated) == true)) &&
                ((this.AcsOperatorID == null && other.AcsOperatorID == null) || (this.AcsOperatorID?.Equals(other.AcsOperatorID) == true)) &&
                ((this.AcsReferenceNumber == null && other.AcsReferenceNumber == null) || (this.AcsReferenceNumber?.Equals(other.AcsReferenceNumber) == true)) &&
                ((this.AcsSignedContent == null && other.AcsSignedContent == null) || (this.AcsSignedContent?.Equals(other.AcsSignedContent) == true)) &&
                ((this.AcsTransID == null && other.AcsTransID == null) || (this.AcsTransID?.Equals(other.AcsTransID) == true)) &&
                ((this.AcsURL == null && other.AcsURL == null) || (this.AcsURL?.Equals(other.AcsURL) == true)) &&
                ((this.AuthenticationType == null && other.AuthenticationType == null) || (this.AuthenticationType?.Equals(other.AuthenticationType) == true)) &&
                ((this.CardHolderInfo == null && other.CardHolderInfo == null) || (this.CardHolderInfo?.Equals(other.CardHolderInfo) == true)) &&
                ((this.CavvAlgorithm == null && other.CavvAlgorithm == null) || (this.CavvAlgorithm?.Equals(other.CavvAlgorithm) == true)) &&
                ((this.ChallengeIndicator == null && other.ChallengeIndicator == null) || (this.ChallengeIndicator?.Equals(other.ChallengeIndicator) == true)) &&
                ((this.DsReferenceNumber == null && other.DsReferenceNumber == null) || (this.DsReferenceNumber?.Equals(other.DsReferenceNumber) == true)) &&
                ((this.DsTransID == null && other.DsTransID == null) || (this.DsTransID?.Equals(other.DsTransID) == true)) &&
                ((this.ExemptionIndicator == null && other.ExemptionIndicator == null) || (this.ExemptionIndicator?.Equals(other.ExemptionIndicator) == true)) &&
                ((this.MessageVersion == null && other.MessageVersion == null) || (this.MessageVersion?.Equals(other.MessageVersion) == true)) &&
                ((this.RiskScore == null && other.RiskScore == null) || (this.RiskScore?.Equals(other.RiskScore) == true)) &&
                ((this.SdkEphemPubKey == null && other.SdkEphemPubKey == null) || (this.SdkEphemPubKey?.Equals(other.SdkEphemPubKey) == true)) &&
                ((this.ThreeDSServerTransID == null && other.ThreeDSServerTransID == null) || (this.ThreeDSServerTransID?.Equals(other.ThreeDSServerTransID) == true)) &&
                ((this.TransStatus == null && other.TransStatus == null) || (this.TransStatus?.Equals(other.TransStatus) == true)) &&
                ((this.TransStatusReason == null && other.TransStatusReason == null) || (this.TransStatusReason?.Equals(other.TransStatusReason) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AcsChallengeMandated = {(this.AcsChallengeMandated == null ? "null" : this.AcsChallengeMandated)}");
            toStringOutput.Add($"this.AcsOperatorID = {(this.AcsOperatorID == null ? "null" : this.AcsOperatorID)}");
            toStringOutput.Add($"this.AcsReferenceNumber = {(this.AcsReferenceNumber == null ? "null" : this.AcsReferenceNumber)}");
            toStringOutput.Add($"this.AcsSignedContent = {(this.AcsSignedContent == null ? "null" : this.AcsSignedContent)}");
            toStringOutput.Add($"this.AcsTransID = {(this.AcsTransID == null ? "null" : this.AcsTransID)}");
            toStringOutput.Add($"this.AcsURL = {(this.AcsURL == null ? "null" : this.AcsURL)}");
            toStringOutput.Add($"this.AuthenticationType = {(this.AuthenticationType == null ? "null" : this.AuthenticationType)}");
            toStringOutput.Add($"this.CardHolderInfo = {(this.CardHolderInfo == null ? "null" : this.CardHolderInfo)}");
            toStringOutput.Add($"this.CavvAlgorithm = {(this.CavvAlgorithm == null ? "null" : this.CavvAlgorithm)}");
            toStringOutput.Add($"this.ChallengeIndicator = {(this.ChallengeIndicator == null ? "null" : this.ChallengeIndicator)}");
            toStringOutput.Add($"this.DsReferenceNumber = {(this.DsReferenceNumber == null ? "null" : this.DsReferenceNumber)}");
            toStringOutput.Add($"this.DsTransID = {(this.DsTransID == null ? "null" : this.DsTransID)}");
            toStringOutput.Add($"this.ExemptionIndicator = {(this.ExemptionIndicator == null ? "null" : this.ExemptionIndicator)}");
            toStringOutput.Add($"this.MessageVersion = {(this.MessageVersion == null ? "null" : this.MessageVersion)}");
            toStringOutput.Add($"this.RiskScore = {(this.RiskScore == null ? "null" : this.RiskScore)}");
            toStringOutput.Add($"this.SdkEphemPubKey = {(this.SdkEphemPubKey == null ? "null" : this.SdkEphemPubKey)}");
            toStringOutput.Add($"this.ThreeDSServerTransID = {(this.ThreeDSServerTransID == null ? "null" : this.ThreeDSServerTransID)}");
            toStringOutput.Add($"this.TransStatus = {(this.TransStatus == null ? "null" : this.TransStatus)}");
            toStringOutput.Add($"this.TransStatusReason = {(this.TransStatusReason == null ? "null" : this.TransStatusReason)}");
        }
    }
}