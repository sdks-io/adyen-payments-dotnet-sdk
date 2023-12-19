// <copyright file="PaymentCompletionDetails1.cs" company="APIMatic">
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
    /// PaymentCompletionDetails1.
    /// </summary>
    public class PaymentCompletionDetails1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCompletionDetails1"/> class.
        /// </summary>
        public PaymentCompletionDetails1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCompletionDetails1"/> class.
        /// </summary>
        /// <param name="mD">MD.</param>
        /// <param name="paReq">PaReq.</param>
        /// <param name="paRes">PaRes.</param>
        /// <param name="authorizationToken">authorization_token.</param>
        /// <param name="billingToken">billingToken.</param>
        /// <param name="cupsecureplusSmscode">cupsecureplus.smscode.</param>
        /// <param name="facilitatorAccessToken">facilitatorAccessToken.</param>
        /// <param name="oneTimePasscode">oneTimePasscode.</param>
        /// <param name="orderID">orderID.</param>
        /// <param name="payerID">payerID.</param>
        /// <param name="payload">payload.</param>
        /// <param name="paymentID">paymentID.</param>
        /// <param name="paymentStatus">paymentStatus.</param>
        /// <param name="redirectResult">redirectResult.</param>
        /// <param name="resultCode">resultCode.</param>
        /// <param name="threeDSResult">threeDSResult.</param>
        /// <param name="threeds2ChallengeResult">threeds2.challengeResult.</param>
        /// <param name="threeds2Fingerprint">threeds2.fingerprint.</param>
        public PaymentCompletionDetails1(
            string mD = null,
            string paReq = null,
            string paRes = null,
            string authorizationToken = null,
            string billingToken = null,
            string cupsecureplusSmscode = null,
            string facilitatorAccessToken = null,
            string oneTimePasscode = null,
            string orderID = null,
            string payerID = null,
            string payload = null,
            string paymentID = null,
            string paymentStatus = null,
            string redirectResult = null,
            string resultCode = null,
            string threeDSResult = null,
            string threeds2ChallengeResult = null,
            string threeds2Fingerprint = null)
        {
            this.MD = mD;
            this.PaReq = paReq;
            this.PaRes = paRes;
            this.AuthorizationToken = authorizationToken;
            this.BillingToken = billingToken;
            this.CupsecureplusSmscode = cupsecureplusSmscode;
            this.FacilitatorAccessToken = facilitatorAccessToken;
            this.OneTimePasscode = oneTimePasscode;
            this.OrderID = orderID;
            this.PayerID = payerID;
            this.Payload = payload;
            this.PaymentID = paymentID;
            this.PaymentStatus = paymentStatus;
            this.RedirectResult = redirectResult;
            this.ResultCode = resultCode;
            this.ThreeDSResult = threeDSResult;
            this.Threeds2ChallengeResult = threeds2ChallengeResult;
            this.Threeds2Fingerprint = threeds2Fingerprint;
        }

        /// <summary>
        /// A payment session identifier returned by the card issuer.
        /// </summary>
        [JsonProperty("MD", NullValueHandling = NullValueHandling.Ignore)]
        public string MD { get; set; }

        /// <summary>
        /// (3D) Payment Authentication Request data for the card issuer.
        /// </summary>
        [JsonProperty("PaReq", NullValueHandling = NullValueHandling.Ignore)]
        public string PaReq { get; set; }

        /// <summary>
        /// (3D) Payment Authentication Response data by the card issuer.
        /// </summary>
        [JsonProperty("PaRes", NullValueHandling = NullValueHandling.Ignore)]
        public string PaRes { get; set; }

        /// <summary>
        /// Gets or sets AuthorizationToken.
        /// </summary>
        [JsonProperty("authorization_token", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizationToken { get; set; }

        /// <summary>
        /// PayPal-generated token for recurring payments.
        /// </summary>
        [JsonProperty("billingToken", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingToken { get; set; }

        /// <summary>
        /// The SMS verification code collected from the shopper.
        /// </summary>
        [JsonProperty("cupsecureplus.smscode", NullValueHandling = NullValueHandling.Ignore)]
        public string CupsecureplusSmscode { get; set; }

        /// <summary>
        /// PayPal-generated third party access token.
        /// </summary>
        [JsonProperty("facilitatorAccessToken", NullValueHandling = NullValueHandling.Ignore)]
        public string FacilitatorAccessToken { get; set; }

        /// <summary>
        /// A random number sent to the mobile phone number of the shopper to verify the payment.
        /// </summary>
        [JsonProperty("oneTimePasscode", NullValueHandling = NullValueHandling.Ignore)]
        public string OneTimePasscode { get; set; }

        /// <summary>
        /// PayPal-assigned ID for the order.
        /// </summary>
        [JsonProperty("orderID", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderID { get; set; }

        /// <summary>
        /// PayPal-assigned ID for the payer (shopper).
        /// </summary>
        [JsonProperty("payerID", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerID { get; set; }

        /// <summary>
        /// Payload appended to the `returnURL` as a result of the redirect.
        /// </summary>
        [JsonProperty("payload", NullValueHandling = NullValueHandling.Ignore)]
        public string Payload { get; set; }

        /// <summary>
        /// PayPal-generated ID for the payment.
        /// </summary>
        [JsonProperty("paymentID", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentID { get; set; }

        /// <summary>
        /// Value passed from the WeChat MiniProgram `wx.requestPayment` **complete** callback. Possible values: any value starting with `requestPayment:`.
        /// </summary>
        [JsonProperty("paymentStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentStatus { get; set; }

        /// <summary>
        /// The result of the redirect as appended to the `returnURL`.
        /// </summary>
        [JsonProperty("redirectResult", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectResult { get; set; }

        /// <summary>
        /// Value you received from the WeChat Pay SDK.
        /// </summary>
        [JsonProperty("resultCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultCode { get; set; }

        /// <summary>
        /// Base64-encoded string returned by the Component after the challenge flow. It contains the following parameters: `transStatus`, `authorisationToken`.
        /// </summary>
        [JsonProperty("threeDSResult", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSResult { get; set; }

        /// <summary>
        /// Base64-encoded string returned by the Component after the challenge flow. It contains the following parameter: `transStatus`.
        /// </summary>
        [JsonProperty("threeds2.challengeResult", NullValueHandling = NullValueHandling.Ignore)]
        public string Threeds2ChallengeResult { get; set; }

        /// <summary>
        /// Base64-encoded string returned by the Component after the challenge flow. It contains the following parameter: `threeDSCompInd`.
        /// </summary>
        [JsonProperty("threeds2.fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public string Threeds2Fingerprint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentCompletionDetails1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentCompletionDetails1 other &&                ((this.MD == null && other.MD == null) || (this.MD?.Equals(other.MD) == true)) &&
                ((this.PaReq == null && other.PaReq == null) || (this.PaReq?.Equals(other.PaReq) == true)) &&
                ((this.PaRes == null && other.PaRes == null) || (this.PaRes?.Equals(other.PaRes) == true)) &&
                ((this.AuthorizationToken == null && other.AuthorizationToken == null) || (this.AuthorizationToken?.Equals(other.AuthorizationToken) == true)) &&
                ((this.BillingToken == null && other.BillingToken == null) || (this.BillingToken?.Equals(other.BillingToken) == true)) &&
                ((this.CupsecureplusSmscode == null && other.CupsecureplusSmscode == null) || (this.CupsecureplusSmscode?.Equals(other.CupsecureplusSmscode) == true)) &&
                ((this.FacilitatorAccessToken == null && other.FacilitatorAccessToken == null) || (this.FacilitatorAccessToken?.Equals(other.FacilitatorAccessToken) == true)) &&
                ((this.OneTimePasscode == null && other.OneTimePasscode == null) || (this.OneTimePasscode?.Equals(other.OneTimePasscode) == true)) &&
                ((this.OrderID == null && other.OrderID == null) || (this.OrderID?.Equals(other.OrderID) == true)) &&
                ((this.PayerID == null && other.PayerID == null) || (this.PayerID?.Equals(other.PayerID) == true)) &&
                ((this.Payload == null && other.Payload == null) || (this.Payload?.Equals(other.Payload) == true)) &&
                ((this.PaymentID == null && other.PaymentID == null) || (this.PaymentID?.Equals(other.PaymentID) == true)) &&
                ((this.PaymentStatus == null && other.PaymentStatus == null) || (this.PaymentStatus?.Equals(other.PaymentStatus) == true)) &&
                ((this.RedirectResult == null && other.RedirectResult == null) || (this.RedirectResult?.Equals(other.RedirectResult) == true)) &&
                ((this.ResultCode == null && other.ResultCode == null) || (this.ResultCode?.Equals(other.ResultCode) == true)) &&
                ((this.ThreeDSResult == null && other.ThreeDSResult == null) || (this.ThreeDSResult?.Equals(other.ThreeDSResult) == true)) &&
                ((this.Threeds2ChallengeResult == null && other.Threeds2ChallengeResult == null) || (this.Threeds2ChallengeResult?.Equals(other.Threeds2ChallengeResult) == true)) &&
                ((this.Threeds2Fingerprint == null && other.Threeds2Fingerprint == null) || (this.Threeds2Fingerprint?.Equals(other.Threeds2Fingerprint) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MD = {(this.MD == null ? "null" : this.MD)}");
            toStringOutput.Add($"this.PaReq = {(this.PaReq == null ? "null" : this.PaReq)}");
            toStringOutput.Add($"this.PaRes = {(this.PaRes == null ? "null" : this.PaRes)}");
            toStringOutput.Add($"this.AuthorizationToken = {(this.AuthorizationToken == null ? "null" : this.AuthorizationToken)}");
            toStringOutput.Add($"this.BillingToken = {(this.BillingToken == null ? "null" : this.BillingToken)}");
            toStringOutput.Add($"this.CupsecureplusSmscode = {(this.CupsecureplusSmscode == null ? "null" : this.CupsecureplusSmscode)}");
            toStringOutput.Add($"this.FacilitatorAccessToken = {(this.FacilitatorAccessToken == null ? "null" : this.FacilitatorAccessToken)}");
            toStringOutput.Add($"this.OneTimePasscode = {(this.OneTimePasscode == null ? "null" : this.OneTimePasscode)}");
            toStringOutput.Add($"this.OrderID = {(this.OrderID == null ? "null" : this.OrderID)}");
            toStringOutput.Add($"this.PayerID = {(this.PayerID == null ? "null" : this.PayerID)}");
            toStringOutput.Add($"this.Payload = {(this.Payload == null ? "null" : this.Payload)}");
            toStringOutput.Add($"this.PaymentID = {(this.PaymentID == null ? "null" : this.PaymentID)}");
            toStringOutput.Add($"this.PaymentStatus = {(this.PaymentStatus == null ? "null" : this.PaymentStatus)}");
            toStringOutput.Add($"this.RedirectResult = {(this.RedirectResult == null ? "null" : this.RedirectResult)}");
            toStringOutput.Add($"this.ResultCode = {(this.ResultCode == null ? "null" : this.ResultCode)}");
            toStringOutput.Add($"this.ThreeDSResult = {(this.ThreeDSResult == null ? "null" : this.ThreeDSResult)}");
            toStringOutput.Add($"this.Threeds2ChallengeResult = {(this.Threeds2ChallengeResult == null ? "null" : this.Threeds2ChallengeResult)}");
            toStringOutput.Add($"this.Threeds2Fingerprint = {(this.Threeds2Fingerprint == null ? "null" : this.Threeds2Fingerprint)}");
        }
    }
}