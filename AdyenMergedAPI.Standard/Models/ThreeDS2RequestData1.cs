// <copyright file="ThreeDS2RequestData1.cs" company="APIMatic">
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
    /// ThreeDS2RequestData1.
    /// </summary>
    public class ThreeDS2RequestData1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDS2RequestData1"/> class.
        /// </summary>
        public ThreeDS2RequestData1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDS2RequestData1"/> class.
        /// </summary>
        /// <param name="deviceChannel">deviceChannel.</param>
        /// <param name="acctInfo">acctInfo.</param>
        /// <param name="acctType">acctType.</param>
        /// <param name="acquirerBIN">acquirerBIN.</param>
        /// <param name="acquirerMerchantID">acquirerMerchantID.</param>
        /// <param name="addrMatch">addrMatch.</param>
        /// <param name="authenticationOnly">authenticationOnly.</param>
        /// <param name="challengeIndicator">challengeIndicator.</param>
        /// <param name="deviceRenderOptions">deviceRenderOptions.</param>
        /// <param name="homePhone">homePhone.</param>
        /// <param name="mcc">mcc.</param>
        /// <param name="merchantName">merchantName.</param>
        /// <param name="messageVersion">messageVersion.</param>
        /// <param name="mobilePhone">mobilePhone.</param>
        /// <param name="notificationURL">notificationURL.</param>
        /// <param name="payTokenInd">payTokenInd.</param>
        /// <param name="paymentAuthenticationUseCase">paymentAuthenticationUseCase.</param>
        /// <param name="purchaseInstalData">purchaseInstalData.</param>
        /// <param name="recurringExpiry">recurringExpiry.</param>
        /// <param name="recurringFrequency">recurringFrequency.</param>
        /// <param name="sdkAppID">sdkAppID.</param>
        /// <param name="sdkEncData">sdkEncData.</param>
        /// <param name="sdkEphemPubKey">sdkEphemPubKey.</param>
        /// <param name="sdkMaxTimeout">sdkMaxTimeout.</param>
        /// <param name="sdkReferenceNumber">sdkReferenceNumber.</param>
        /// <param name="sdkTransID">sdkTransID.</param>
        /// <param name="sdkVersion">sdkVersion.</param>
        /// <param name="threeDSCompInd">threeDSCompInd.</param>
        /// <param name="threeDSRequestorAuthenticationInd">threeDSRequestorAuthenticationInd.</param>
        /// <param name="threeDSRequestorAuthenticationInfo">threeDSRequestorAuthenticationInfo.</param>
        /// <param name="threeDSRequestorChallengeInd">threeDSRequestorChallengeInd.</param>
        /// <param name="threeDSRequestorID">threeDSRequestorID.</param>
        /// <param name="threeDSRequestorName">threeDSRequestorName.</param>
        /// <param name="threeDSRequestorPriorAuthenticationInfo">threeDSRequestorPriorAuthenticationInfo.</param>
        /// <param name="threeDSRequestorURL">threeDSRequestorURL.</param>
        /// <param name="transType">transType.</param>
        /// <param name="transactionType">transactionType.</param>
        /// <param name="whiteListStatus">whiteListStatus.</param>
        /// <param name="workPhone">workPhone.</param>
        public ThreeDS2RequestData1(
            string deviceChannel,
            Models.AcctInfo1 acctInfo = null,
            Models.AcctTypeEnum? acctType = null,
            string acquirerBIN = null,
            string acquirerMerchantID = null,
            Models.AddrMatchEnum? addrMatch = null,
            bool? authenticationOnly = false,
            Models.ChallengeIndicatorEnum? challengeIndicator = null,
            Models.DeviceRenderOptions1 deviceRenderOptions = null,
            Models.Phone4 homePhone = null,
            string mcc = null,
            string merchantName = null,
            string messageVersion = null,
            Models.Phone1 mobilePhone = null,
            string notificationURL = null,
            bool? payTokenInd = null,
            string paymentAuthenticationUseCase = null,
            string purchaseInstalData = null,
            string recurringExpiry = null,
            string recurringFrequency = null,
            string sdkAppID = null,
            string sdkEncData = null,
            Models.SDKEphemPubKey2 sdkEphemPubKey = null,
            int? sdkMaxTimeout = 60,
            string sdkReferenceNumber = null,
            string sdkTransID = null,
            string sdkVersion = null,
            string threeDSCompInd = null,
            string threeDSRequestorAuthenticationInd = null,
            Models.ThreeDSRequestorAuthenticationInfo2 threeDSRequestorAuthenticationInfo = null,
            Models.ThreeDSRequestorChallengeIndEnum? threeDSRequestorChallengeInd = null,
            string threeDSRequestorID = null,
            string threeDSRequestorName = null,
            Models.ThreeDSRequestorPriorAuthenticationInfo2 threeDSRequestorPriorAuthenticationInfo = null,
            string threeDSRequestorURL = null,
            Models.TransTypeEnum? transType = null,
            Models.TransactionTypeEnum? transactionType = null,
            string whiteListStatus = null,
            Models.Phone2 workPhone = null)
        {
            this.AcctInfo = acctInfo;
            this.AcctType = acctType;
            this.AcquirerBIN = acquirerBIN;
            this.AcquirerMerchantID = acquirerMerchantID;
            this.AddrMatch = addrMatch;
            this.AuthenticationOnly = authenticationOnly;
            this.ChallengeIndicator = challengeIndicator;
            this.DeviceChannel = deviceChannel;
            this.DeviceRenderOptions = deviceRenderOptions;
            this.HomePhone = homePhone;
            this.Mcc = mcc;
            this.MerchantName = merchantName;
            this.MessageVersion = messageVersion;
            this.MobilePhone = mobilePhone;
            this.NotificationURL = notificationURL;
            this.PayTokenInd = payTokenInd;
            this.PaymentAuthenticationUseCase = paymentAuthenticationUseCase;
            this.PurchaseInstalData = purchaseInstalData;
            this.RecurringExpiry = recurringExpiry;
            this.RecurringFrequency = recurringFrequency;
            this.SdkAppID = sdkAppID;
            this.SdkEncData = sdkEncData;
            this.SdkEphemPubKey = sdkEphemPubKey;
            this.SdkMaxTimeout = sdkMaxTimeout;
            this.SdkReferenceNumber = sdkReferenceNumber;
            this.SdkTransID = sdkTransID;
            this.SdkVersion = sdkVersion;
            this.ThreeDSCompInd = threeDSCompInd;
            this.ThreeDSRequestorAuthenticationInd = threeDSRequestorAuthenticationInd;
            this.ThreeDSRequestorAuthenticationInfo = threeDSRequestorAuthenticationInfo;
            this.ThreeDSRequestorChallengeInd = threeDSRequestorChallengeInd;
            this.ThreeDSRequestorID = threeDSRequestorID;
            this.ThreeDSRequestorName = threeDSRequestorName;
            this.ThreeDSRequestorPriorAuthenticationInfo = threeDSRequestorPriorAuthenticationInfo;
            this.ThreeDSRequestorURL = threeDSRequestorURL;
            this.TransType = transType;
            this.TransactionType = transactionType;
            this.WhiteListStatus = whiteListStatus;
            this.WorkPhone = workPhone;
        }

        /// <summary>
        /// Additional information about the Cardholder’s account provided by the 3DS Requestor.
        /// </summary>
        [JsonProperty("acctInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AcctInfo1 AcctInfo { get; set; }

        /// <summary>
        /// Indicates the type of account. For example, for a multi-account card product. Length: 2 characters. Allowed values:
        /// * **01** — Not applicable
        /// * **02** — Credit
        /// * **03** — Debit
        /// </summary>
        [JsonProperty("acctType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AcctTypeEnum? AcctType { get; set; }

        /// <summary>
        /// Required for [authentication-only integration](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only). The acquiring BIN enrolled for 3D Secure 2. This string should match the value that you will use in the authorisation. Use 123456 on the Test platform.
        /// </summary>
        [JsonProperty("acquirerBIN", NullValueHandling = NullValueHandling.Ignore)]
        public string AcquirerBIN { get; set; }

        /// <summary>
        /// Required for [authentication-only integration](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only). The merchantId that is enrolled for 3D Secure 2 by the merchant's acquirer. This string should match the value that you will use in the authorisation. Use 123456 on the Test platform.
        /// </summary>
        [JsonProperty("acquirerMerchantID", NullValueHandling = NullValueHandling.Ignore)]
        public string AcquirerMerchantID { get; set; }

        /// <summary>
        /// Indicates whether the Cardholder Shipping Address and Cardholder Billing Address are the same. Allowed values:
        /// * **Y** — Shipping Address matches Billing Address.
        /// * **N** — Shipping Address does not match Billing Address.
        /// </summary>
        [JsonProperty("addrMatch", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AddrMatchEnum? AddrMatch { get; set; }

        /// <summary>
        /// If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.
        /// </summary>
        [JsonProperty("authenticationOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AuthenticationOnly { get; set; }

        /// <summary>
        /// Possibility to specify a preference for receiving a challenge from the issuer.
        /// Allowed values:
        /// * `noPreference`
        /// * `requestNoChallenge`
        /// * `requestChallenge`
        /// * `requestChallengeAsMandate`
        /// </summary>
        [JsonProperty("challengeIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChallengeIndicatorEnum? ChallengeIndicator { get; set; }

        /// <summary>
        /// The environment of the shopper.
        /// Allowed values:
        /// * `app`
        /// * `browser`
        /// </summary>
        [JsonProperty("deviceChannel")]
        public string DeviceChannel { get; set; }

        /// <summary>
        /// Display options for the 3D Secure 2 SDK.
        /// Optional and only for `deviceChannel` **app**.
        /// </summary>
        [JsonProperty("deviceRenderOptions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeviceRenderOptions1 DeviceRenderOptions { get; set; }

        /// <summary>
        /// The home phone number provided by the Cardholder.
        /// </summary>
        [JsonProperty("homePhone", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Phone4 HomePhone { get; set; }

        /// <summary>
        /// Required for merchants that have been enrolled for 3D Secure 2 by another party than Adyen, mostly [authentication-only integrations](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only). The `mcc` is a four-digit code with which the previously given `acquirerMerchantID` is registered at the scheme.
        /// </summary>
        [JsonProperty("mcc", NullValueHandling = NullValueHandling.Ignore)]
        public string Mcc { get; set; }

        /// <summary>
        /// Required for [authentication-only integration](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only). The merchant name that the issuer presents to the shopper if they get a challenge. We recommend to use the same value that you will use in the authorization. Maximum length is 40 characters.
        /// > Optional for a [full 3D Secure 2 integration](https://docs.adyen.com/online-payments/3d-secure/native-3ds2/api-integration). Use this field if you are enrolled for 3D Secure 2 with us and want to override the merchant name already configured on your account.
        /// </summary>
        [JsonProperty("merchantName", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantName { get; set; }

        /// <summary>
        /// The `messageVersion` value indicating the 3D Secure 2 protocol version.
        /// </summary>
        [JsonProperty("messageVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageVersion { get; set; }

        /// <summary>
        /// The mobile phone number provided by the Cardholder.
        /// </summary>
        [JsonProperty("mobilePhone", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Phone1 MobilePhone { get; set; }

        /// <summary>
        /// URL to where the issuer should send the `CRes`. Required if you are not using components for `channel` **Web** or if you are using classic integration `deviceChannel` **browser**.
        /// </summary>
        [JsonProperty("notificationURL", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationURL { get; set; }

        /// <summary>
        /// Value **true** indicates that the transaction was de-tokenised prior to being received by the ACS.
        /// </summary>
        [JsonProperty("payTokenInd", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PayTokenInd { get; set; }

        /// <summary>
        /// Indicates the type of payment for which an authentication is requested (message extension)
        /// </summary>
        [JsonProperty("paymentAuthenticationUseCase", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentAuthenticationUseCase { get; set; }

        /// <summary>
        /// Indicates the maximum number of authorisations permitted for instalment payments. Length: 1–3 characters.
        /// </summary>
        [JsonProperty("purchaseInstalData", NullValueHandling = NullValueHandling.Ignore)]
        public string PurchaseInstalData { get; set; }

        /// <summary>
        /// Date after which no further authorisations shall be performed. Format: YYYYMMDD
        /// </summary>
        [JsonProperty("recurringExpiry", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurringExpiry { get; set; }

        /// <summary>
        /// Indicates the minimum number of days between authorisations. Maximum length: 4 characters.
        /// </summary>
        [JsonProperty("recurringFrequency", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurringFrequency { get; set; }

        /// <summary>
        /// The `sdkAppID` value as received from the 3D Secure 2 SDK.
        /// Required for `deviceChannel` set to **app**.
        /// </summary>
        [JsonProperty("sdkAppID", NullValueHandling = NullValueHandling.Ignore)]
        public string SdkAppID { get; set; }

        /// <summary>
        /// The `sdkEncData` value as received from the 3D Secure 2 SDK.
        /// Required for `deviceChannel` set to **app**.
        /// </summary>
        [JsonProperty("sdkEncData", NullValueHandling = NullValueHandling.Ignore)]
        public string SdkEncData { get; set; }

        /// <summary>
        /// The `sdkEphemPubKey` value as received from the 3D Secure 2 SDK.
        /// Required for `deviceChannel` set to **app**.
        /// </summary>
        [JsonProperty("sdkEphemPubKey", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SDKEphemPubKey2 SdkEphemPubKey { get; set; }

        /// <summary>
        /// The maximum amount of time in minutes for the 3D Secure 2 authentication process.
        /// Optional and only for `deviceChannel` set to **app**. Defaults to **60** minutes.
        /// </summary>
        [JsonProperty("sdkMaxTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? SdkMaxTimeout { get; set; }

        /// <summary>
        /// The `sdkReferenceNumber` value as received from the 3D Secure 2 SDK.
        /// Only for `deviceChannel` set to **app**.
        /// </summary>
        [JsonProperty("sdkReferenceNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SdkReferenceNumber { get; set; }

        /// <summary>
        /// The `sdkTransID` value as received from the 3D Secure 2 SDK.
        /// Only for `deviceChannel` set to **app**.
        /// </summary>
        [JsonProperty("sdkTransID", NullValueHandling = NullValueHandling.Ignore)]
        public string SdkTransID { get; set; }

        /// <summary>
        /// Version of the 3D Secure 2 mobile SDK.
        /// Only for `deviceChannel` set to **app**.
        /// </summary>
        [JsonProperty("sdkVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string SdkVersion { get; set; }

        /// <summary>
        /// Completion indicator for the device fingerprinting.
        /// </summary>
        [JsonProperty("threeDSCompInd", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSCompInd { get; set; }

        /// <summary>
        /// Indicates the type of Authentication request.
        /// </summary>
        [JsonProperty("threeDSRequestorAuthenticationInd", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSRequestorAuthenticationInd { get; set; }

        /// <summary>
        /// Information about how the 3DS Requestor authenticated the cardholder before or during the transaction
        /// </summary>
        [JsonProperty("threeDSRequestorAuthenticationInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDSRequestorAuthenticationInfo2 ThreeDSRequestorAuthenticationInfo { get; set; }

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
        /// Required for [authentication-only integration](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only) for Visa. Unique 3D Secure requestor identifier assigned by the Directory Server when you enrol for 3D Secure 2.
        /// </summary>
        [JsonProperty("threeDSRequestorID", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSRequestorID { get; set; }

        /// <summary>
        /// Required for [authentication-only integration](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only) for Visa. Unique 3D Secure requestor name assigned by the Directory Server when you enrol for 3D Secure 2.
        /// </summary>
        [JsonProperty("threeDSRequestorName", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSRequestorName { get; set; }

        /// <summary>
        /// Information about how the 3DS Requestor authenticated the cardholder as part of a previous 3DS transaction.
        /// </summary>
        [JsonProperty("threeDSRequestorPriorAuthenticationInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDSRequestorPriorAuthenticationInfo2 ThreeDSRequestorPriorAuthenticationInfo { get; set; }

        /// <summary>
        /// URL of the (customer service) website that will be shown to the shopper in case of technical errors during the 3D Secure 2 process.
        /// </summary>
        [JsonProperty("threeDSRequestorURL", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSRequestorURL { get; set; }

        /// <summary>
        /// Identifies the type of transaction being authenticated. Length: 2 characters. Allowed values:
        /// * **01** — Goods/Service Purchase
        /// * **03** — Check Acceptance
        /// * **10** — Account Funding
        /// * **11** — Quasi-Cash Transaction
        /// * **28** — Prepaid Activation and Load
        /// </summary>
        [JsonProperty("transType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransTypeEnum? TransType { get; set; }

        /// <summary>
        /// Identify the type of the transaction being authenticated.
        /// </summary>
        [JsonProperty("transactionType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionTypeEnum? TransactionType { get; set; }

        /// <summary>
        /// The `whiteListStatus` value returned from a previous 3D Secure 2 transaction, only applicable for 3D Secure 2 protocol version 2.2.0.
        /// </summary>
        [JsonProperty("whiteListStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string WhiteListStatus { get; set; }

        /// <summary>
        /// The work phone number provided by the Cardholder.
        /// </summary>
        [JsonProperty("workPhone", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Phone2 WorkPhone { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ThreeDS2RequestData1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is ThreeDS2RequestData1 other &&                ((this.AcctInfo == null && other.AcctInfo == null) || (this.AcctInfo?.Equals(other.AcctInfo) == true)) &&
                ((this.AcctType == null && other.AcctType == null) || (this.AcctType?.Equals(other.AcctType) == true)) &&
                ((this.AcquirerBIN == null && other.AcquirerBIN == null) || (this.AcquirerBIN?.Equals(other.AcquirerBIN) == true)) &&
                ((this.AcquirerMerchantID == null && other.AcquirerMerchantID == null) || (this.AcquirerMerchantID?.Equals(other.AcquirerMerchantID) == true)) &&
                ((this.AddrMatch == null && other.AddrMatch == null) || (this.AddrMatch?.Equals(other.AddrMatch) == true)) &&
                ((this.AuthenticationOnly == null && other.AuthenticationOnly == null) || (this.AuthenticationOnly?.Equals(other.AuthenticationOnly) == true)) &&
                ((this.ChallengeIndicator == null && other.ChallengeIndicator == null) || (this.ChallengeIndicator?.Equals(other.ChallengeIndicator) == true)) &&
                ((this.DeviceChannel == null && other.DeviceChannel == null) || (this.DeviceChannel?.Equals(other.DeviceChannel) == true)) &&
                ((this.DeviceRenderOptions == null && other.DeviceRenderOptions == null) || (this.DeviceRenderOptions?.Equals(other.DeviceRenderOptions) == true)) &&
                ((this.HomePhone == null && other.HomePhone == null) || (this.HomePhone?.Equals(other.HomePhone) == true)) &&
                ((this.Mcc == null && other.Mcc == null) || (this.Mcc?.Equals(other.Mcc) == true)) &&
                ((this.MerchantName == null && other.MerchantName == null) || (this.MerchantName?.Equals(other.MerchantName) == true)) &&
                ((this.MessageVersion == null && other.MessageVersion == null) || (this.MessageVersion?.Equals(other.MessageVersion) == true)) &&
                ((this.MobilePhone == null && other.MobilePhone == null) || (this.MobilePhone?.Equals(other.MobilePhone) == true)) &&
                ((this.NotificationURL == null && other.NotificationURL == null) || (this.NotificationURL?.Equals(other.NotificationURL) == true)) &&
                ((this.PayTokenInd == null && other.PayTokenInd == null) || (this.PayTokenInd?.Equals(other.PayTokenInd) == true)) &&
                ((this.PaymentAuthenticationUseCase == null && other.PaymentAuthenticationUseCase == null) || (this.PaymentAuthenticationUseCase?.Equals(other.PaymentAuthenticationUseCase) == true)) &&
                ((this.PurchaseInstalData == null && other.PurchaseInstalData == null) || (this.PurchaseInstalData?.Equals(other.PurchaseInstalData) == true)) &&
                ((this.RecurringExpiry == null && other.RecurringExpiry == null) || (this.RecurringExpiry?.Equals(other.RecurringExpiry) == true)) &&
                ((this.RecurringFrequency == null && other.RecurringFrequency == null) || (this.RecurringFrequency?.Equals(other.RecurringFrequency) == true)) &&
                ((this.SdkAppID == null && other.SdkAppID == null) || (this.SdkAppID?.Equals(other.SdkAppID) == true)) &&
                ((this.SdkEncData == null && other.SdkEncData == null) || (this.SdkEncData?.Equals(other.SdkEncData) == true)) &&
                ((this.SdkEphemPubKey == null && other.SdkEphemPubKey == null) || (this.SdkEphemPubKey?.Equals(other.SdkEphemPubKey) == true)) &&
                ((this.SdkMaxTimeout == null && other.SdkMaxTimeout == null) || (this.SdkMaxTimeout?.Equals(other.SdkMaxTimeout) == true)) &&
                ((this.SdkReferenceNumber == null && other.SdkReferenceNumber == null) || (this.SdkReferenceNumber?.Equals(other.SdkReferenceNumber) == true)) &&
                ((this.SdkTransID == null && other.SdkTransID == null) || (this.SdkTransID?.Equals(other.SdkTransID) == true)) &&
                ((this.SdkVersion == null && other.SdkVersion == null) || (this.SdkVersion?.Equals(other.SdkVersion) == true)) &&
                ((this.ThreeDSCompInd == null && other.ThreeDSCompInd == null) || (this.ThreeDSCompInd?.Equals(other.ThreeDSCompInd) == true)) &&
                ((this.ThreeDSRequestorAuthenticationInd == null && other.ThreeDSRequestorAuthenticationInd == null) || (this.ThreeDSRequestorAuthenticationInd?.Equals(other.ThreeDSRequestorAuthenticationInd) == true)) &&
                ((this.ThreeDSRequestorAuthenticationInfo == null && other.ThreeDSRequestorAuthenticationInfo == null) || (this.ThreeDSRequestorAuthenticationInfo?.Equals(other.ThreeDSRequestorAuthenticationInfo) == true)) &&
                ((this.ThreeDSRequestorChallengeInd == null && other.ThreeDSRequestorChallengeInd == null) || (this.ThreeDSRequestorChallengeInd?.Equals(other.ThreeDSRequestorChallengeInd) == true)) &&
                ((this.ThreeDSRequestorID == null && other.ThreeDSRequestorID == null) || (this.ThreeDSRequestorID?.Equals(other.ThreeDSRequestorID) == true)) &&
                ((this.ThreeDSRequestorName == null && other.ThreeDSRequestorName == null) || (this.ThreeDSRequestorName?.Equals(other.ThreeDSRequestorName) == true)) &&
                ((this.ThreeDSRequestorPriorAuthenticationInfo == null && other.ThreeDSRequestorPriorAuthenticationInfo == null) || (this.ThreeDSRequestorPriorAuthenticationInfo?.Equals(other.ThreeDSRequestorPriorAuthenticationInfo) == true)) &&
                ((this.ThreeDSRequestorURL == null && other.ThreeDSRequestorURL == null) || (this.ThreeDSRequestorURL?.Equals(other.ThreeDSRequestorURL) == true)) &&
                ((this.TransType == null && other.TransType == null) || (this.TransType?.Equals(other.TransType) == true)) &&
                ((this.TransactionType == null && other.TransactionType == null) || (this.TransactionType?.Equals(other.TransactionType) == true)) &&
                ((this.WhiteListStatus == null && other.WhiteListStatus == null) || (this.WhiteListStatus?.Equals(other.WhiteListStatus) == true)) &&
                ((this.WorkPhone == null && other.WorkPhone == null) || (this.WorkPhone?.Equals(other.WorkPhone) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AcctInfo = {(this.AcctInfo == null ? "null" : this.AcctInfo.ToString())}");
            toStringOutput.Add($"this.AcctType = {(this.AcctType == null ? "null" : this.AcctType.ToString())}");
            toStringOutput.Add($"this.AcquirerBIN = {(this.AcquirerBIN == null ? "null" : this.AcquirerBIN)}");
            toStringOutput.Add($"this.AcquirerMerchantID = {(this.AcquirerMerchantID == null ? "null" : this.AcquirerMerchantID)}");
            toStringOutput.Add($"this.AddrMatch = {(this.AddrMatch == null ? "null" : this.AddrMatch.ToString())}");
            toStringOutput.Add($"this.AuthenticationOnly = {(this.AuthenticationOnly == null ? "null" : this.AuthenticationOnly.ToString())}");
            toStringOutput.Add($"this.ChallengeIndicator = {(this.ChallengeIndicator == null ? "null" : this.ChallengeIndicator.ToString())}");
            toStringOutput.Add($"this.DeviceChannel = {(this.DeviceChannel == null ? "null" : this.DeviceChannel)}");
            toStringOutput.Add($"this.DeviceRenderOptions = {(this.DeviceRenderOptions == null ? "null" : this.DeviceRenderOptions.ToString())}");
            toStringOutput.Add($"this.HomePhone = {(this.HomePhone == null ? "null" : this.HomePhone.ToString())}");
            toStringOutput.Add($"this.Mcc = {(this.Mcc == null ? "null" : this.Mcc)}");
            toStringOutput.Add($"this.MerchantName = {(this.MerchantName == null ? "null" : this.MerchantName)}");
            toStringOutput.Add($"this.MessageVersion = {(this.MessageVersion == null ? "null" : this.MessageVersion)}");
            toStringOutput.Add($"this.MobilePhone = {(this.MobilePhone == null ? "null" : this.MobilePhone.ToString())}");
            toStringOutput.Add($"this.NotificationURL = {(this.NotificationURL == null ? "null" : this.NotificationURL)}");
            toStringOutput.Add($"this.PayTokenInd = {(this.PayTokenInd == null ? "null" : this.PayTokenInd.ToString())}");
            toStringOutput.Add($"this.PaymentAuthenticationUseCase = {(this.PaymentAuthenticationUseCase == null ? "null" : this.PaymentAuthenticationUseCase)}");
            toStringOutput.Add($"this.PurchaseInstalData = {(this.PurchaseInstalData == null ? "null" : this.PurchaseInstalData)}");
            toStringOutput.Add($"this.RecurringExpiry = {(this.RecurringExpiry == null ? "null" : this.RecurringExpiry)}");
            toStringOutput.Add($"this.RecurringFrequency = {(this.RecurringFrequency == null ? "null" : this.RecurringFrequency)}");
            toStringOutput.Add($"this.SdkAppID = {(this.SdkAppID == null ? "null" : this.SdkAppID)}");
            toStringOutput.Add($"this.SdkEncData = {(this.SdkEncData == null ? "null" : this.SdkEncData)}");
            toStringOutput.Add($"this.SdkEphemPubKey = {(this.SdkEphemPubKey == null ? "null" : this.SdkEphemPubKey.ToString())}");
            toStringOutput.Add($"this.SdkMaxTimeout = {(this.SdkMaxTimeout == null ? "null" : this.SdkMaxTimeout.ToString())}");
            toStringOutput.Add($"this.SdkReferenceNumber = {(this.SdkReferenceNumber == null ? "null" : this.SdkReferenceNumber)}");
            toStringOutput.Add($"this.SdkTransID = {(this.SdkTransID == null ? "null" : this.SdkTransID)}");
            toStringOutput.Add($"this.SdkVersion = {(this.SdkVersion == null ? "null" : this.SdkVersion)}");
            toStringOutput.Add($"this.ThreeDSCompInd = {(this.ThreeDSCompInd == null ? "null" : this.ThreeDSCompInd)}");
            toStringOutput.Add($"this.ThreeDSRequestorAuthenticationInd = {(this.ThreeDSRequestorAuthenticationInd == null ? "null" : this.ThreeDSRequestorAuthenticationInd)}");
            toStringOutput.Add($"this.ThreeDSRequestorAuthenticationInfo = {(this.ThreeDSRequestorAuthenticationInfo == null ? "null" : this.ThreeDSRequestorAuthenticationInfo.ToString())}");
            toStringOutput.Add($"this.ThreeDSRequestorChallengeInd = {(this.ThreeDSRequestorChallengeInd == null ? "null" : this.ThreeDSRequestorChallengeInd.ToString())}");
            toStringOutput.Add($"this.ThreeDSRequestorID = {(this.ThreeDSRequestorID == null ? "null" : this.ThreeDSRequestorID)}");
            toStringOutput.Add($"this.ThreeDSRequestorName = {(this.ThreeDSRequestorName == null ? "null" : this.ThreeDSRequestorName)}");
            toStringOutput.Add($"this.ThreeDSRequestorPriorAuthenticationInfo = {(this.ThreeDSRequestorPriorAuthenticationInfo == null ? "null" : this.ThreeDSRequestorPriorAuthenticationInfo.ToString())}");
            toStringOutput.Add($"this.ThreeDSRequestorURL = {(this.ThreeDSRequestorURL == null ? "null" : this.ThreeDSRequestorURL)}");
            toStringOutput.Add($"this.TransType = {(this.TransType == null ? "null" : this.TransType.ToString())}");
            toStringOutput.Add($"this.TransactionType = {(this.TransactionType == null ? "null" : this.TransactionType.ToString())}");
            toStringOutput.Add($"this.WhiteListStatus = {(this.WhiteListStatus == null ? "null" : this.WhiteListStatus)}");
            toStringOutput.Add($"this.WorkPhone = {(this.WorkPhone == null ? "null" : this.WorkPhone.ToString())}");
        }
    }
}