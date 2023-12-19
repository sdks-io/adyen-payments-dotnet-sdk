// <copyright file="ResponseAdditionalDataCommon.cs" company="APIMatic">
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
    /// ResponseAdditionalDataCommon.
    /// </summary>
    public class ResponseAdditionalDataCommon
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataCommon"/> class.
        /// </summary>
        public ResponseAdditionalDataCommon()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataCommon"/> class.
        /// </summary>
        /// <param name="acquirerAccountCode">acquirerAccountCode.</param>
        /// <param name="acquirerCode">acquirerCode.</param>
        /// <param name="acquirerReference">acquirerReference.</param>
        /// <param name="mAlias">alias.</param>
        /// <param name="aliasType">aliasType.</param>
        /// <param name="authCode">authCode.</param>
        /// <param name="authorisationMid">authorisationMid.</param>
        /// <param name="authorisedAmountCurrency">authorisedAmountCurrency.</param>
        /// <param name="authorisedAmountValue">authorisedAmountValue.</param>
        /// <param name="avsResult">avsResult.</param>
        /// <param name="avsResultRaw">avsResultRaw.</param>
        /// <param name="bic">bic.</param>
        /// <param name="coBrandedWith">coBrandedWith.</param>
        /// <param name="cvcResult">cvcResult.</param>
        /// <param name="cvcResultRaw">cvcResultRaw.</param>
        /// <param name="dsTransID">dsTransID.</param>
        /// <param name="eci">eci.</param>
        /// <param name="expiryDate">expiryDate.</param>
        /// <param name="extraCostsCurrency">extraCostsCurrency.</param>
        /// <param name="extraCostsValue">extraCostsValue.</param>
        /// <param name="fraudCheckItemNrFraudCheckname">fraudCheck-[itemNr]-[FraudCheckname].</param>
        /// <param name="fraudManualReview">fraudManualReview.</param>
        /// <param name="fraudResultType">fraudResultType.</param>
        /// <param name="fundingSource">fundingSource.</param>
        /// <param name="fundsAvailability">fundsAvailability.</param>
        /// <param name="inferredRefusalReason">inferredRefusalReason.</param>
        /// <param name="isCardCommercial">isCardCommercial.</param>
        /// <param name="issuerCountry">issuerCountry.</param>
        /// <param name="liabilityShift">liabilityShift.</param>
        /// <param name="mcBankNetReferenceNumber">mcBankNetReferenceNumber.</param>
        /// <param name="merchantAdviceCode">merchantAdviceCode.</param>
        /// <param name="merchantReference">merchantReference.</param>
        /// <param name="networkTxReference">networkTxReference.</param>
        /// <param name="ownerName">ownerName.</param>
        /// <param name="paymentAccountReference">paymentAccountReference.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="paymentMethodVariant">paymentMethodVariant.</param>
        /// <param name="payoutEligible">payoutEligible.</param>
        /// <param name="realtimeAccountUpdaterStatus">realtimeAccountUpdaterStatus.</param>
        /// <param name="receiptFreeText">receiptFreeText.</param>
        /// <param name="recurringContractTypes">recurring.contractTypes.</param>
        /// <param name="recurringFirstPspReference">recurring.firstPspReference.</param>
        /// <param name="recurringRecurringDetailReference">recurring.recurringDetailReference.</param>
        /// <param name="recurringShopperReference">recurring.shopperReference.</param>
        /// <param name="recurringProcessingModel">recurringProcessingModel.</param>
        /// <param name="referred">referred.</param>
        /// <param name="refusalReasonRaw">refusalReasonRaw.</param>
        /// <param name="requestAmount">requestAmount.</param>
        /// <param name="requestCurrencyCode">requestCurrencyCode.</param>
        /// <param name="shopperInteraction">shopperInteraction.</param>
        /// <param name="shopperReference">shopperReference.</param>
        /// <param name="terminalId">terminalId.</param>
        /// <param name="threeDAuthenticated">threeDAuthenticated.</param>
        /// <param name="threeDAuthenticatedResponse">threeDAuthenticatedResponse.</param>
        /// <param name="threeDOffered">threeDOffered.</param>
        /// <param name="threeDOfferedResponse">threeDOfferedResponse.</param>
        /// <param name="threeDSVersion">threeDSVersion.</param>
        /// <param name="visaTransactionId">visaTransactionId.</param>
        /// <param name="xid">xid.</param>
        public ResponseAdditionalDataCommon(
            string acquirerAccountCode = null,
            string acquirerCode = null,
            string acquirerReference = null,
            string mAlias = null,
            string aliasType = null,
            string authCode = null,
            string authorisationMid = null,
            string authorisedAmountCurrency = null,
            string authorisedAmountValue = null,
            string avsResult = null,
            string avsResultRaw = null,
            string bic = null,
            string coBrandedWith = null,
            string cvcResult = null,
            string cvcResultRaw = null,
            string dsTransID = null,
            string eci = null,
            string expiryDate = null,
            string extraCostsCurrency = null,
            string extraCostsValue = null,
            string fraudCheckItemNrFraudCheckname = null,
            string fraudManualReview = null,
            Models.FraudResultTypeEnum? fraudResultType = null,
            string fundingSource = null,
            string fundsAvailability = null,
            string inferredRefusalReason = null,
            string isCardCommercial = null,
            string issuerCountry = null,
            string liabilityShift = null,
            string mcBankNetReferenceNumber = null,
            string merchantAdviceCode = null,
            string merchantReference = null,
            string networkTxReference = null,
            string ownerName = null,
            string paymentAccountReference = null,
            string paymentMethod = null,
            string paymentMethodVariant = null,
            string payoutEligible = null,
            string realtimeAccountUpdaterStatus = null,
            string receiptFreeText = null,
            string recurringContractTypes = null,
            string recurringFirstPspReference = null,
            string recurringRecurringDetailReference = null,
            string recurringShopperReference = null,
            Models.RecurringProcessingModel7Enum? recurringProcessingModel = null,
            string referred = null,
            string refusalReasonRaw = null,
            string requestAmount = null,
            string requestCurrencyCode = null,
            string shopperInteraction = null,
            string shopperReference = null,
            string terminalId = null,
            string threeDAuthenticated = null,
            string threeDAuthenticatedResponse = null,
            string threeDOffered = null,
            string threeDOfferedResponse = null,
            string threeDSVersion = null,
            string visaTransactionId = null,
            string xid = null)
        {
            this.AcquirerAccountCode = acquirerAccountCode;
            this.AcquirerCode = acquirerCode;
            this.AcquirerReference = acquirerReference;
            this.MAlias = mAlias;
            this.AliasType = aliasType;
            this.AuthCode = authCode;
            this.AuthorisationMid = authorisationMid;
            this.AuthorisedAmountCurrency = authorisedAmountCurrency;
            this.AuthorisedAmountValue = authorisedAmountValue;
            this.AvsResult = avsResult;
            this.AvsResultRaw = avsResultRaw;
            this.Bic = bic;
            this.CoBrandedWith = coBrandedWith;
            this.CvcResult = cvcResult;
            this.CvcResultRaw = cvcResultRaw;
            this.DsTransID = dsTransID;
            this.Eci = eci;
            this.ExpiryDate = expiryDate;
            this.ExtraCostsCurrency = extraCostsCurrency;
            this.ExtraCostsValue = extraCostsValue;
            this.FraudCheckItemNrFraudCheckname = fraudCheckItemNrFraudCheckname;
            this.FraudManualReview = fraudManualReview;
            this.FraudResultType = fraudResultType;
            this.FundingSource = fundingSource;
            this.FundsAvailability = fundsAvailability;
            this.InferredRefusalReason = inferredRefusalReason;
            this.IsCardCommercial = isCardCommercial;
            this.IssuerCountry = issuerCountry;
            this.LiabilityShift = liabilityShift;
            this.McBankNetReferenceNumber = mcBankNetReferenceNumber;
            this.MerchantAdviceCode = merchantAdviceCode;
            this.MerchantReference = merchantReference;
            this.NetworkTxReference = networkTxReference;
            this.OwnerName = ownerName;
            this.PaymentAccountReference = paymentAccountReference;
            this.PaymentMethod = paymentMethod;
            this.PaymentMethodVariant = paymentMethodVariant;
            this.PayoutEligible = payoutEligible;
            this.RealtimeAccountUpdaterStatus = realtimeAccountUpdaterStatus;
            this.ReceiptFreeText = receiptFreeText;
            this.RecurringContractTypes = recurringContractTypes;
            this.RecurringFirstPspReference = recurringFirstPspReference;
            this.RecurringRecurringDetailReference = recurringRecurringDetailReference;
            this.RecurringShopperReference = recurringShopperReference;
            this.RecurringProcessingModel = recurringProcessingModel;
            this.Referred = referred;
            this.RefusalReasonRaw = refusalReasonRaw;
            this.RequestAmount = requestAmount;
            this.RequestCurrencyCode = requestCurrencyCode;
            this.ShopperInteraction = shopperInteraction;
            this.ShopperReference = shopperReference;
            this.TerminalId = terminalId;
            this.ThreeDAuthenticated = threeDAuthenticated;
            this.ThreeDAuthenticatedResponse = threeDAuthenticatedResponse;
            this.ThreeDOffered = threeDOffered;
            this.ThreeDOfferedResponse = threeDOfferedResponse;
            this.ThreeDSVersion = threeDSVersion;
            this.VisaTransactionId = visaTransactionId;
            this.Xid = xid;
        }

        /// <summary>
        /// The name of the Adyen acquirer account.
        /// Example: PayPalSandbox_TestAcquirer
        /// > Only relevant for PayPal transactions.
        /// </summary>
        [JsonProperty("acquirerAccountCode", NullValueHandling = NullValueHandling.Ignore)]
        public string AcquirerAccountCode { get; set; }

        /// <summary>
        /// The name of the acquirer processing the payment request.
        /// Example: TestPmmAcquirer
        /// </summary>
        [JsonProperty("acquirerCode", NullValueHandling = NullValueHandling.Ignore)]
        public string AcquirerCode { get; set; }

        /// <summary>
        /// The reference number that can be used for reconciliation in case a non-Adyen acquirer is used for settlement.
        /// Example: 7C9N3FNBKT9
        /// </summary>
        [JsonProperty("acquirerReference", NullValueHandling = NullValueHandling.Ignore)]
        public string AcquirerReference { get; set; }

        /// <summary>
        /// The Adyen alias of the card.
        /// Example: H167852639363479
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string MAlias { get; set; }

        /// <summary>
        /// The type of the card alias.
        /// Example: Default
        /// </summary>
        [JsonProperty("aliasType", NullValueHandling = NullValueHandling.Ignore)]
        public string AliasType { get; set; }

        /// <summary>
        /// Authorisation code:
        /// * When the payment is authorised successfully, this field holds the authorisation code for the payment.
        /// * When the payment is not authorised, this field is empty.
        /// Example: 58747
        /// </summary>
        [JsonProperty("authCode", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthCode { get; set; }

        /// <summary>
        /// Merchant ID known by the acquirer.
        /// </summary>
        [JsonProperty("authorisationMid", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorisationMid { get; set; }

        /// <summary>
        /// The currency of the authorised amount, as a three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes).
        /// </summary>
        [JsonProperty("authorisedAmountCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorisedAmountCurrency { get; set; }

        /// <summary>
        /// Value of the amount authorised.
        /// This amount is represented in minor units according to the [following table](https://docs.adyen.com/development-resources/currency-codes).
        /// </summary>
        [JsonProperty("authorisedAmountValue", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorisedAmountValue { get; set; }

        /// <summary>
        /// The AVS result code of the payment, which provides information about the outcome of the AVS check.
        /// For possible values, see [AVS](https://docs.adyen.com/risk-management/configure-standard-risk-rules/consistency-rules#billing-address-does-not-match-cardholder-address-avs).
        /// </summary>
        [JsonProperty("avsResult", NullValueHandling = NullValueHandling.Ignore)]
        public string AvsResult { get; set; }

        /// <summary>
        /// Raw AVS result received from the acquirer, where available.
        /// Example: D
        /// </summary>
        [JsonProperty("avsResultRaw", NullValueHandling = NullValueHandling.Ignore)]
        public string AvsResultRaw { get; set; }

        /// <summary>
        /// BIC of a bank account.
        /// Example: TESTNL01
        /// > Only relevant for SEPA Direct Debit transactions.
        /// </summary>
        [JsonProperty("bic", NullValueHandling = NullValueHandling.Ignore)]
        public string Bic { get; set; }

        /// <summary>
        /// Includes the co-branded card information.
        /// </summary>
        [JsonProperty("coBrandedWith", NullValueHandling = NullValueHandling.Ignore)]
        public string CoBrandedWith { get; set; }

        /// <summary>
        /// The result of CVC verification.
        /// </summary>
        [JsonProperty("cvcResult", NullValueHandling = NullValueHandling.Ignore)]
        public string CvcResult { get; set; }

        /// <summary>
        /// The raw result of CVC verification.
        /// </summary>
        [JsonProperty("cvcResultRaw", NullValueHandling = NullValueHandling.Ignore)]
        public string CvcResultRaw { get; set; }

        /// <summary>
        /// Supported for 3D Secure 2. The unique transaction identifier assigned by the DS to identify a single transaction.
        /// </summary>
        [JsonProperty("dsTransID", NullValueHandling = NullValueHandling.Ignore)]
        public string DsTransID { get; set; }

        /// <summary>
        /// The Electronic Commerce Indicator returned from the schemes for the 3DS payment session.
        /// Example: 02
        /// </summary>
        [JsonProperty("eci", NullValueHandling = NullValueHandling.Ignore)]
        public string Eci { get; set; }

        /// <summary>
        /// The expiry date on the card.
        /// Example: 6/2016
        /// > Returned only in case of a card payment.
        /// </summary>
        [JsonProperty("expiryDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// The currency of the extra amount charged due to additional amounts set in the skin used in the HPP payment request.
        /// Example: EUR
        /// </summary>
        [JsonProperty("extraCostsCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtraCostsCurrency { get; set; }

        /// <summary>
        /// The value of the extra amount charged due to additional amounts set in the skin used in the HPP payment request. The amount is in minor units.
        /// </summary>
        [JsonProperty("extraCostsValue", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtraCostsValue { get; set; }

        /// <summary>
        /// The fraud score due to a particular fraud check. The fraud check name is found in the key of the key-value pair.
        /// </summary>
        [JsonProperty("fraudCheck-[itemNr]-[FraudCheckname]", NullValueHandling = NullValueHandling.Ignore)]
        public string FraudCheckItemNrFraudCheckname { get; set; }

        /// <summary>
        /// Indicates if the payment is sent to manual review.
        /// </summary>
        [JsonProperty("fraudManualReview", NullValueHandling = NullValueHandling.Ignore)]
        public string FraudManualReview { get; set; }

        /// <summary>
        /// The fraud result properties of the payment.
        /// </summary>
        [JsonProperty("fraudResultType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FraudResultTypeEnum? FraudResultType { get; set; }

        /// <summary>
        /// Information regarding the funding type of the card. The possible return values are:
        /// * CHARGE
        /// * CREDIT
        /// * DEBIT
        /// * PREPAID
        /// * PREPAID_RELOADABLE
        /// * PREPAID_NONRELOADABLE
        /// * DEFFERED_DEBIT
        /// > This functionality requires additional configuration on Adyen's end. To enable it, contact the Support Team.
        /// For receiving this field in the notification, enable **Include Funding Source** in **Notifications** > **Additional settings**.
        /// </summary>
        [JsonProperty("fundingSource", NullValueHandling = NullValueHandling.Ignore)]
        public string FundingSource { get; set; }

        /// <summary>
        /// Indicates availability of funds.
        /// Visa:
        /// * "I" (fast funds are supported)
        /// * "N" (otherwise)
        /// Mastercard:
        /// * "I" (product type is Prepaid or Debit, or issuing country is in CEE/HGEM list)
        /// * "N" (otherwise)
        /// > Returned when you verify a card BIN or estimate costs, and only if payoutEligible is "Y" or "D".
        /// </summary>
        [JsonProperty("fundsAvailability", NullValueHandling = NullValueHandling.Ignore)]
        public string FundsAvailability { get; set; }

        /// <summary>
        /// Provides the more granular indication of why a transaction was refused. When a transaction fails with either "Refused", "Restricted Card", "Transaction Not Permitted", "Not supported" or "DeclinedNon Generic" refusalReason from the issuer, Adyen cross references its PSP-wide data for extra insight into the refusal reason. If an inferred refusal reason is available, the `inferredRefusalReason`, field is populated and the `refusalReason`, is set to "Not Supported".
        /// Possible values:
        /// * 3D Secure Mandated
        /// * Closed Account
        /// * ContAuth Not Supported
        /// * CVC Mandated
        /// * Ecommerce Not Allowed
        /// * Crossborder Not Supported
        /// * Card Updated
        /// * Low Authrate Bin
        /// * Non-reloadable prepaid card
        /// </summary>
        [JsonProperty("inferredRefusalReason", NullValueHandling = NullValueHandling.Ignore)]
        public string InferredRefusalReason { get; set; }

        /// <summary>
        /// Indicates if the card is used for business purposes only.
        /// </summary>
        [JsonProperty("isCardCommercial", NullValueHandling = NullValueHandling.Ignore)]
        public string IsCardCommercial { get; set; }

        /// <summary>
        /// The issuing country of the card based on the BIN list that Adyen maintains.
        /// Example: JP
        /// </summary>
        [JsonProperty("issuerCountry", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerCountry { get; set; }

        /// <summary>
        /// A Boolean value indicating whether a liability shift was offered for this payment.
        /// </summary>
        [JsonProperty("liabilityShift", NullValueHandling = NullValueHandling.Ignore)]
        public string LiabilityShift { get; set; }

        /// <summary>
        /// The `mcBankNetReferenceNumber`, is a minimum of six characters and a maximum of nine characters long.
        /// > Contact Support Team to enable this field.
        /// </summary>
        [JsonProperty("mcBankNetReferenceNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string McBankNetReferenceNumber { get; set; }

        /// <summary>
        /// The Merchant Advice Code (MAC) can be returned by Mastercard issuers for refused payments. If present, the MAC contains information about why the payment failed, and whether it can be retried.
        /// For more information see [Mastercard Merchant Advice Codes](https://docs.adyen.com/development-resources/raw-acquirer-responses#mastercard-merchant-advice-codes).
        /// </summary>
        [JsonProperty("merchantAdviceCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantAdviceCode { get; set; }

        /// <summary>
        /// The reference provided for the transaction.
        /// </summary>
        [JsonProperty("merchantReference", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// Returned in the response if you are not tokenizing with Adyen and are using the Merchant-initiated transactions (MIT) framework from Mastercard or Visa.
        /// This contains either the Mastercard Trace ID or the Visa Transaction ID.
        /// </summary>
        [JsonProperty("networkTxReference", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkTxReference { get; set; }

        /// <summary>
        /// The owner name of a bank account.
        /// Only relevant for SEPA Direct Debit transactions.
        /// </summary>
        [JsonProperty("ownerName", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        /// <summary>
        /// The Payment Account Reference (PAR) value links a network token with the underlying primary account number (PAN). The PAR value consists of 29 uppercase alphanumeric characters.
        /// </summary>
        [JsonProperty("paymentAccountReference", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentAccountReference { get; set; }

        /// <summary>
        /// The payment method used in the transaction.
        /// </summary>
        [JsonProperty("paymentMethod", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The Adyen sub-variant of the payment method used for the payment request.
        /// For more information, refer to [PaymentMethodVariant](https://docs.adyen.com/development-resources/paymentmethodvariant).
        /// Example: mcpro
        /// </summary>
        [JsonProperty("paymentMethodVariant", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentMethodVariant { get; set; }

        /// <summary>
        /// Indicates whether a payout is eligible or not for this card.
        /// Visa:
        /// * "Y"
        /// * "N"
        /// Mastercard:
        /// * "Y" (domestic and cross-border)
        /// * "D" (only domestic)
        /// * "N" (no MoneySend)
        /// * "U" (unknown)
        /// </summary>
        [JsonProperty("payoutEligible", NullValueHandling = NullValueHandling.Ignore)]
        public string PayoutEligible { get; set; }

        /// <summary>
        /// The response code from the Real Time Account Updater service.
        /// Possible return values are:
        /// * CardChanged
        /// * CardExpiryChanged
        /// * CloseAccount
        /// * ContactCardAccountHolder
        /// </summary>
        [JsonProperty("realtimeAccountUpdaterStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string RealtimeAccountUpdaterStatus { get; set; }

        /// <summary>
        /// Message to be displayed on the terminal.
        /// </summary>
        [JsonProperty("receiptFreeText", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiptFreeText { get; set; }

        /// <summary>
        /// The recurring contract types applicable to the transaction.
        /// </summary>
        [JsonProperty("recurring.contractTypes", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurringContractTypes { get; set; }

        /// <summary>
        /// The `pspReference`, of the first recurring payment that created the recurring detail.
        /// This functionality requires additional configuration on Adyen's end. To enable it, contact the Support Team.
        /// </summary>
        [JsonProperty("recurring.firstPspReference", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurringFirstPspReference { get; set; }

        /// <summary>
        /// The reference that uniquely identifies the recurring transaction.
        /// </summary>
        [JsonProperty("recurring.recurringDetailReference", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurringRecurringDetailReference { get; set; }

        /// <summary>
        /// The provided reference of the shopper for a recurring transaction.
        /// </summary>
        [JsonProperty("recurring.shopperReference", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurringShopperReference { get; set; }

        /// <summary>
        /// The processing model used for the recurring transaction.
        /// </summary>
        [JsonProperty("recurringProcessingModel", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RecurringProcessingModel7Enum? RecurringProcessingModel { get; set; }

        /// <summary>
        /// If the payment is referred, this field is set to true.
        /// This field is unavailable if the payment is referred and is usually not returned with ecommerce transactions.
        /// Example: true
        /// </summary>
        [JsonProperty("referred", NullValueHandling = NullValueHandling.Ignore)]
        public string Referred { get; set; }

        /// <summary>
        /// Raw refusal reason received from the acquirer, where available.
        /// Example: AUTHORISED
        /// </summary>
        [JsonProperty("refusalReasonRaw", NullValueHandling = NullValueHandling.Ignore)]
        public string RefusalReasonRaw { get; set; }

        /// <summary>
        /// The amount of the payment request.
        /// </summary>
        [JsonProperty("requestAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestAmount { get; set; }

        /// <summary>
        /// The currency of the payment request.
        /// </summary>
        [JsonProperty("requestCurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestCurrencyCode { get; set; }

        /// <summary>
        /// The shopper interaction type of the payment request.
        /// Example: Ecommerce
        /// </summary>
        [JsonProperty("shopperInteraction", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperInteraction { get; set; }

        /// <summary>
        /// The shopperReference passed in the payment request.
        /// Example: AdyenTestShopperXX
        /// </summary>
        [JsonProperty("shopperReference", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// The terminal ID used in a point-of-sale payment.
        /// Example: 06022622
        /// </summary>
        [JsonProperty("terminalId", NullValueHandling = NullValueHandling.Ignore)]
        public string TerminalId { get; set; }

        /// <summary>
        /// A Boolean value indicating whether 3DS authentication was completed on this payment.
        /// Example: true
        /// </summary>
        [JsonProperty("threeDAuthenticated", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDAuthenticated { get; set; }

        /// <summary>
        /// The raw 3DS authentication result from the card issuer.
        /// Example: N
        /// </summary>
        [JsonProperty("threeDAuthenticatedResponse", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDAuthenticatedResponse { get; set; }

        /// <summary>
        /// A Boolean value indicating whether 3DS was offered for this payment.
        /// Example: true
        /// </summary>
        [JsonProperty("threeDOffered", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDOffered { get; set; }

        /// <summary>
        /// The raw enrollment result from the 3DS directory services of the card schemes.
        /// Example: Y
        /// </summary>
        [JsonProperty("threeDOfferedResponse", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDOfferedResponse { get; set; }

        /// <summary>
        /// The 3D Secure 2 version.
        /// </summary>
        [JsonProperty("threeDSVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSVersion { get; set; }

        /// <summary>
        /// The `visaTransactionId`, has a fixed length of 15 numeric characters.
        /// > Contact Support Team to enable this field.
        /// </summary>
        [JsonProperty("visaTransactionId", NullValueHandling = NullValueHandling.Ignore)]
        public string VisaTransactionId { get; set; }

        /// <summary>
        /// The 3DS transaction ID of the 3DS session sent in notifications. The value is Base64-encoded and is returned for transactions with directoryResponse 'N' or 'Y'. If you want to submit the xid in your 3D Secure 1 request, use the `mpiData.xid`, field.
        /// Example: ODgxNDc2MDg2MDExODk5MAAAAAA=
        /// </summary>
        [JsonProperty("xid", NullValueHandling = NullValueHandling.Ignore)]
        public string Xid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseAdditionalDataCommon : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResponseAdditionalDataCommon other &&                ((this.AcquirerAccountCode == null && other.AcquirerAccountCode == null) || (this.AcquirerAccountCode?.Equals(other.AcquirerAccountCode) == true)) &&
                ((this.AcquirerCode == null && other.AcquirerCode == null) || (this.AcquirerCode?.Equals(other.AcquirerCode) == true)) &&
                ((this.AcquirerReference == null && other.AcquirerReference == null) || (this.AcquirerReference?.Equals(other.AcquirerReference) == true)) &&
                ((this.MAlias == null && other.MAlias == null) || (this.MAlias?.Equals(other.MAlias) == true)) &&
                ((this.AliasType == null && other.AliasType == null) || (this.AliasType?.Equals(other.AliasType) == true)) &&
                ((this.AuthCode == null && other.AuthCode == null) || (this.AuthCode?.Equals(other.AuthCode) == true)) &&
                ((this.AuthorisationMid == null && other.AuthorisationMid == null) || (this.AuthorisationMid?.Equals(other.AuthorisationMid) == true)) &&
                ((this.AuthorisedAmountCurrency == null && other.AuthorisedAmountCurrency == null) || (this.AuthorisedAmountCurrency?.Equals(other.AuthorisedAmountCurrency) == true)) &&
                ((this.AuthorisedAmountValue == null && other.AuthorisedAmountValue == null) || (this.AuthorisedAmountValue?.Equals(other.AuthorisedAmountValue) == true)) &&
                ((this.AvsResult == null && other.AvsResult == null) || (this.AvsResult?.Equals(other.AvsResult) == true)) &&
                ((this.AvsResultRaw == null && other.AvsResultRaw == null) || (this.AvsResultRaw?.Equals(other.AvsResultRaw) == true)) &&
                ((this.Bic == null && other.Bic == null) || (this.Bic?.Equals(other.Bic) == true)) &&
                ((this.CoBrandedWith == null && other.CoBrandedWith == null) || (this.CoBrandedWith?.Equals(other.CoBrandedWith) == true)) &&
                ((this.CvcResult == null && other.CvcResult == null) || (this.CvcResult?.Equals(other.CvcResult) == true)) &&
                ((this.CvcResultRaw == null && other.CvcResultRaw == null) || (this.CvcResultRaw?.Equals(other.CvcResultRaw) == true)) &&
                ((this.DsTransID == null && other.DsTransID == null) || (this.DsTransID?.Equals(other.DsTransID) == true)) &&
                ((this.Eci == null && other.Eci == null) || (this.Eci?.Equals(other.Eci) == true)) &&
                ((this.ExpiryDate == null && other.ExpiryDate == null) || (this.ExpiryDate?.Equals(other.ExpiryDate) == true)) &&
                ((this.ExtraCostsCurrency == null && other.ExtraCostsCurrency == null) || (this.ExtraCostsCurrency?.Equals(other.ExtraCostsCurrency) == true)) &&
                ((this.ExtraCostsValue == null && other.ExtraCostsValue == null) || (this.ExtraCostsValue?.Equals(other.ExtraCostsValue) == true)) &&
                ((this.FraudCheckItemNrFraudCheckname == null && other.FraudCheckItemNrFraudCheckname == null) || (this.FraudCheckItemNrFraudCheckname?.Equals(other.FraudCheckItemNrFraudCheckname) == true)) &&
                ((this.FraudManualReview == null && other.FraudManualReview == null) || (this.FraudManualReview?.Equals(other.FraudManualReview) == true)) &&
                ((this.FraudResultType == null && other.FraudResultType == null) || (this.FraudResultType?.Equals(other.FraudResultType) == true)) &&
                ((this.FundingSource == null && other.FundingSource == null) || (this.FundingSource?.Equals(other.FundingSource) == true)) &&
                ((this.FundsAvailability == null && other.FundsAvailability == null) || (this.FundsAvailability?.Equals(other.FundsAvailability) == true)) &&
                ((this.InferredRefusalReason == null && other.InferredRefusalReason == null) || (this.InferredRefusalReason?.Equals(other.InferredRefusalReason) == true)) &&
                ((this.IsCardCommercial == null && other.IsCardCommercial == null) || (this.IsCardCommercial?.Equals(other.IsCardCommercial) == true)) &&
                ((this.IssuerCountry == null && other.IssuerCountry == null) || (this.IssuerCountry?.Equals(other.IssuerCountry) == true)) &&
                ((this.LiabilityShift == null && other.LiabilityShift == null) || (this.LiabilityShift?.Equals(other.LiabilityShift) == true)) &&
                ((this.McBankNetReferenceNumber == null && other.McBankNetReferenceNumber == null) || (this.McBankNetReferenceNumber?.Equals(other.McBankNetReferenceNumber) == true)) &&
                ((this.MerchantAdviceCode == null && other.MerchantAdviceCode == null) || (this.MerchantAdviceCode?.Equals(other.MerchantAdviceCode) == true)) &&
                ((this.MerchantReference == null && other.MerchantReference == null) || (this.MerchantReference?.Equals(other.MerchantReference) == true)) &&
                ((this.NetworkTxReference == null && other.NetworkTxReference == null) || (this.NetworkTxReference?.Equals(other.NetworkTxReference) == true)) &&
                ((this.OwnerName == null && other.OwnerName == null) || (this.OwnerName?.Equals(other.OwnerName) == true)) &&
                ((this.PaymentAccountReference == null && other.PaymentAccountReference == null) || (this.PaymentAccountReference?.Equals(other.PaymentAccountReference) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.PaymentMethodVariant == null && other.PaymentMethodVariant == null) || (this.PaymentMethodVariant?.Equals(other.PaymentMethodVariant) == true)) &&
                ((this.PayoutEligible == null && other.PayoutEligible == null) || (this.PayoutEligible?.Equals(other.PayoutEligible) == true)) &&
                ((this.RealtimeAccountUpdaterStatus == null && other.RealtimeAccountUpdaterStatus == null) || (this.RealtimeAccountUpdaterStatus?.Equals(other.RealtimeAccountUpdaterStatus) == true)) &&
                ((this.ReceiptFreeText == null && other.ReceiptFreeText == null) || (this.ReceiptFreeText?.Equals(other.ReceiptFreeText) == true)) &&
                ((this.RecurringContractTypes == null && other.RecurringContractTypes == null) || (this.RecurringContractTypes?.Equals(other.RecurringContractTypes) == true)) &&
                ((this.RecurringFirstPspReference == null && other.RecurringFirstPspReference == null) || (this.RecurringFirstPspReference?.Equals(other.RecurringFirstPspReference) == true)) &&
                ((this.RecurringRecurringDetailReference == null && other.RecurringRecurringDetailReference == null) || (this.RecurringRecurringDetailReference?.Equals(other.RecurringRecurringDetailReference) == true)) &&
                ((this.RecurringShopperReference == null && other.RecurringShopperReference == null) || (this.RecurringShopperReference?.Equals(other.RecurringShopperReference) == true)) &&
                ((this.RecurringProcessingModel == null && other.RecurringProcessingModel == null) || (this.RecurringProcessingModel?.Equals(other.RecurringProcessingModel) == true)) &&
                ((this.Referred == null && other.Referred == null) || (this.Referred?.Equals(other.Referred) == true)) &&
                ((this.RefusalReasonRaw == null && other.RefusalReasonRaw == null) || (this.RefusalReasonRaw?.Equals(other.RefusalReasonRaw) == true)) &&
                ((this.RequestAmount == null && other.RequestAmount == null) || (this.RequestAmount?.Equals(other.RequestAmount) == true)) &&
                ((this.RequestCurrencyCode == null && other.RequestCurrencyCode == null) || (this.RequestCurrencyCode?.Equals(other.RequestCurrencyCode) == true)) &&
                ((this.ShopperInteraction == null && other.ShopperInteraction == null) || (this.ShopperInteraction?.Equals(other.ShopperInteraction) == true)) &&
                ((this.ShopperReference == null && other.ShopperReference == null) || (this.ShopperReference?.Equals(other.ShopperReference) == true)) &&
                ((this.TerminalId == null && other.TerminalId == null) || (this.TerminalId?.Equals(other.TerminalId) == true)) &&
                ((this.ThreeDAuthenticated == null && other.ThreeDAuthenticated == null) || (this.ThreeDAuthenticated?.Equals(other.ThreeDAuthenticated) == true)) &&
                ((this.ThreeDAuthenticatedResponse == null && other.ThreeDAuthenticatedResponse == null) || (this.ThreeDAuthenticatedResponse?.Equals(other.ThreeDAuthenticatedResponse) == true)) &&
                ((this.ThreeDOffered == null && other.ThreeDOffered == null) || (this.ThreeDOffered?.Equals(other.ThreeDOffered) == true)) &&
                ((this.ThreeDOfferedResponse == null && other.ThreeDOfferedResponse == null) || (this.ThreeDOfferedResponse?.Equals(other.ThreeDOfferedResponse) == true)) &&
                ((this.ThreeDSVersion == null && other.ThreeDSVersion == null) || (this.ThreeDSVersion?.Equals(other.ThreeDSVersion) == true)) &&
                ((this.VisaTransactionId == null && other.VisaTransactionId == null) || (this.VisaTransactionId?.Equals(other.VisaTransactionId) == true)) &&
                ((this.Xid == null && other.Xid == null) || (this.Xid?.Equals(other.Xid) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AcquirerAccountCode = {(this.AcquirerAccountCode == null ? "null" : this.AcquirerAccountCode)}");
            toStringOutput.Add($"this.AcquirerCode = {(this.AcquirerCode == null ? "null" : this.AcquirerCode)}");
            toStringOutput.Add($"this.AcquirerReference = {(this.AcquirerReference == null ? "null" : this.AcquirerReference)}");
            toStringOutput.Add($"this.MAlias = {(this.MAlias == null ? "null" : this.MAlias)}");
            toStringOutput.Add($"this.AliasType = {(this.AliasType == null ? "null" : this.AliasType)}");
            toStringOutput.Add($"this.AuthCode = {(this.AuthCode == null ? "null" : this.AuthCode)}");
            toStringOutput.Add($"this.AuthorisationMid = {(this.AuthorisationMid == null ? "null" : this.AuthorisationMid)}");
            toStringOutput.Add($"this.AuthorisedAmountCurrency = {(this.AuthorisedAmountCurrency == null ? "null" : this.AuthorisedAmountCurrency)}");
            toStringOutput.Add($"this.AuthorisedAmountValue = {(this.AuthorisedAmountValue == null ? "null" : this.AuthorisedAmountValue)}");
            toStringOutput.Add($"this.AvsResult = {(this.AvsResult == null ? "null" : this.AvsResult)}");
            toStringOutput.Add($"this.AvsResultRaw = {(this.AvsResultRaw == null ? "null" : this.AvsResultRaw)}");
            toStringOutput.Add($"this.Bic = {(this.Bic == null ? "null" : this.Bic)}");
            toStringOutput.Add($"this.CoBrandedWith = {(this.CoBrandedWith == null ? "null" : this.CoBrandedWith)}");
            toStringOutput.Add($"this.CvcResult = {(this.CvcResult == null ? "null" : this.CvcResult)}");
            toStringOutput.Add($"this.CvcResultRaw = {(this.CvcResultRaw == null ? "null" : this.CvcResultRaw)}");
            toStringOutput.Add($"this.DsTransID = {(this.DsTransID == null ? "null" : this.DsTransID)}");
            toStringOutput.Add($"this.Eci = {(this.Eci == null ? "null" : this.Eci)}");
            toStringOutput.Add($"this.ExpiryDate = {(this.ExpiryDate == null ? "null" : this.ExpiryDate)}");
            toStringOutput.Add($"this.ExtraCostsCurrency = {(this.ExtraCostsCurrency == null ? "null" : this.ExtraCostsCurrency)}");
            toStringOutput.Add($"this.ExtraCostsValue = {(this.ExtraCostsValue == null ? "null" : this.ExtraCostsValue)}");
            toStringOutput.Add($"this.FraudCheckItemNrFraudCheckname = {(this.FraudCheckItemNrFraudCheckname == null ? "null" : this.FraudCheckItemNrFraudCheckname)}");
            toStringOutput.Add($"this.FraudManualReview = {(this.FraudManualReview == null ? "null" : this.FraudManualReview)}");
            toStringOutput.Add($"this.FraudResultType = {(this.FraudResultType == null ? "null" : this.FraudResultType.ToString())}");
            toStringOutput.Add($"this.FundingSource = {(this.FundingSource == null ? "null" : this.FundingSource)}");
            toStringOutput.Add($"this.FundsAvailability = {(this.FundsAvailability == null ? "null" : this.FundsAvailability)}");
            toStringOutput.Add($"this.InferredRefusalReason = {(this.InferredRefusalReason == null ? "null" : this.InferredRefusalReason)}");
            toStringOutput.Add($"this.IsCardCommercial = {(this.IsCardCommercial == null ? "null" : this.IsCardCommercial)}");
            toStringOutput.Add($"this.IssuerCountry = {(this.IssuerCountry == null ? "null" : this.IssuerCountry)}");
            toStringOutput.Add($"this.LiabilityShift = {(this.LiabilityShift == null ? "null" : this.LiabilityShift)}");
            toStringOutput.Add($"this.McBankNetReferenceNumber = {(this.McBankNetReferenceNumber == null ? "null" : this.McBankNetReferenceNumber)}");
            toStringOutput.Add($"this.MerchantAdviceCode = {(this.MerchantAdviceCode == null ? "null" : this.MerchantAdviceCode)}");
            toStringOutput.Add($"this.MerchantReference = {(this.MerchantReference == null ? "null" : this.MerchantReference)}");
            toStringOutput.Add($"this.NetworkTxReference = {(this.NetworkTxReference == null ? "null" : this.NetworkTxReference)}");
            toStringOutput.Add($"this.OwnerName = {(this.OwnerName == null ? "null" : this.OwnerName)}");
            toStringOutput.Add($"this.PaymentAccountReference = {(this.PaymentAccountReference == null ? "null" : this.PaymentAccountReference)}");
            toStringOutput.Add($"this.PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod)}");
            toStringOutput.Add($"this.PaymentMethodVariant = {(this.PaymentMethodVariant == null ? "null" : this.PaymentMethodVariant)}");
            toStringOutput.Add($"this.PayoutEligible = {(this.PayoutEligible == null ? "null" : this.PayoutEligible)}");
            toStringOutput.Add($"this.RealtimeAccountUpdaterStatus = {(this.RealtimeAccountUpdaterStatus == null ? "null" : this.RealtimeAccountUpdaterStatus)}");
            toStringOutput.Add($"this.ReceiptFreeText = {(this.ReceiptFreeText == null ? "null" : this.ReceiptFreeText)}");
            toStringOutput.Add($"this.RecurringContractTypes = {(this.RecurringContractTypes == null ? "null" : this.RecurringContractTypes)}");
            toStringOutput.Add($"this.RecurringFirstPspReference = {(this.RecurringFirstPspReference == null ? "null" : this.RecurringFirstPspReference)}");
            toStringOutput.Add($"this.RecurringRecurringDetailReference = {(this.RecurringRecurringDetailReference == null ? "null" : this.RecurringRecurringDetailReference)}");
            toStringOutput.Add($"this.RecurringShopperReference = {(this.RecurringShopperReference == null ? "null" : this.RecurringShopperReference)}");
            toStringOutput.Add($"this.RecurringProcessingModel = {(this.RecurringProcessingModel == null ? "null" : this.RecurringProcessingModel.ToString())}");
            toStringOutput.Add($"this.Referred = {(this.Referred == null ? "null" : this.Referred)}");
            toStringOutput.Add($"this.RefusalReasonRaw = {(this.RefusalReasonRaw == null ? "null" : this.RefusalReasonRaw)}");
            toStringOutput.Add($"this.RequestAmount = {(this.RequestAmount == null ? "null" : this.RequestAmount)}");
            toStringOutput.Add($"this.RequestCurrencyCode = {(this.RequestCurrencyCode == null ? "null" : this.RequestCurrencyCode)}");
            toStringOutput.Add($"this.ShopperInteraction = {(this.ShopperInteraction == null ? "null" : this.ShopperInteraction)}");
            toStringOutput.Add($"this.ShopperReference = {(this.ShopperReference == null ? "null" : this.ShopperReference)}");
            toStringOutput.Add($"this.TerminalId = {(this.TerminalId == null ? "null" : this.TerminalId)}");
            toStringOutput.Add($"this.ThreeDAuthenticated = {(this.ThreeDAuthenticated == null ? "null" : this.ThreeDAuthenticated)}");
            toStringOutput.Add($"this.ThreeDAuthenticatedResponse = {(this.ThreeDAuthenticatedResponse == null ? "null" : this.ThreeDAuthenticatedResponse)}");
            toStringOutput.Add($"this.ThreeDOffered = {(this.ThreeDOffered == null ? "null" : this.ThreeDOffered)}");
            toStringOutput.Add($"this.ThreeDOfferedResponse = {(this.ThreeDOfferedResponse == null ? "null" : this.ThreeDOfferedResponse)}");
            toStringOutput.Add($"this.ThreeDSVersion = {(this.ThreeDSVersion == null ? "null" : this.ThreeDSVersion)}");
            toStringOutput.Add($"this.VisaTransactionId = {(this.VisaTransactionId == null ? "null" : this.VisaTransactionId)}");
            toStringOutput.Add($"this.Xid = {(this.Xid == null ? "null" : this.Xid)}");
        }
    }
}