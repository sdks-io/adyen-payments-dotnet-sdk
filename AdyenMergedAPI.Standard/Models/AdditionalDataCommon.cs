// <copyright file="AdditionalDataCommon.cs" company="APIMatic">
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
    /// AdditionalDataCommon.
    /// </summary>
    public class AdditionalDataCommon
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataCommon"/> class.
        /// </summary>
        public AdditionalDataCommon()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataCommon"/> class.
        /// </summary>
        /// <param name="requestedTestErrorResponseCode">RequestedTestErrorResponseCode.</param>
        /// <param name="allowPartialAuth">allowPartialAuth.</param>
        /// <param name="authorisationType">authorisationType.</param>
        /// <param name="customRoutingFlag">customRoutingFlag.</param>
        /// <param name="industryUsage">industryUsage.</param>
        /// <param name="manualCapture">manualCapture.</param>
        /// <param name="networkTxReference">networkTxReference.</param>
        /// <param name="overwriteBrand">overwriteBrand.</param>
        /// <param name="subMerchantCity">subMerchantCity.</param>
        /// <param name="subMerchantCountry">subMerchantCountry.</param>
        /// <param name="subMerchantID">subMerchantID.</param>
        /// <param name="subMerchantName">subMerchantName.</param>
        /// <param name="subMerchantPostalCode">subMerchantPostalCode.</param>
        /// <param name="subMerchantState">subMerchantState.</param>
        /// <param name="subMerchantStreet">subMerchantStreet.</param>
        /// <param name="subMerchantTaxId">subMerchantTaxId.</param>
        public AdditionalDataCommon(
            string requestedTestErrorResponseCode = null,
            string allowPartialAuth = null,
            string authorisationType = null,
            string customRoutingFlag = null,
            Models.IndustryUsageEnum? industryUsage = null,
            string manualCapture = null,
            string networkTxReference = null,
            string overwriteBrand = null,
            string subMerchantCity = null,
            string subMerchantCountry = null,
            string subMerchantID = null,
            string subMerchantName = null,
            string subMerchantPostalCode = null,
            string subMerchantState = null,
            string subMerchantStreet = null,
            string subMerchantTaxId = null)
        {
            this.RequestedTestErrorResponseCode = requestedTestErrorResponseCode;
            this.AllowPartialAuth = allowPartialAuth;
            this.AuthorisationType = authorisationType;
            this.CustomRoutingFlag = customRoutingFlag;
            this.IndustryUsage = industryUsage;
            this.ManualCapture = manualCapture;
            this.NetworkTxReference = networkTxReference;
            this.OverwriteBrand = overwriteBrand;
            this.SubMerchantCity = subMerchantCity;
            this.SubMerchantCountry = subMerchantCountry;
            this.SubMerchantID = subMerchantID;
            this.SubMerchantName = subMerchantName;
            this.SubMerchantPostalCode = subMerchantPostalCode;
            this.SubMerchantState = subMerchantState;
            this.SubMerchantStreet = subMerchantStreet;
            this.SubMerchantTaxId = subMerchantTaxId;
        }

        /// <summary>
        /// Triggers test scenarios that allow to replicate certain communication errors.
        /// Allowed values:
        /// * **NO_CONNECTION_AVAILABLE** – There wasn't a connection available to service the outgoing communication.
        /// This is a transient, retriable error since no messaging could be initiated to an issuing system (or third-party acquiring system). Therefore, the header Transient-Error: true is returned in the response. A subsequent request using the same idempotency key will be processed as if it was the first request.
        /// * **IOEXCEPTION_RECEIVED** – Something went wrong during transmission of the message or receiving the response.
        /// This is a classified as non-transient because the message could have been received by the issuing party and been acted upon. No transient error header is returned. If using idempotency, the (error) response is stored as the final result for the idempotency key. Subsequent messages with the same idempotency key not be processed beyond returning the stored response.
        /// </summary>
        [JsonProperty("RequestedTestErrorResponseCode", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestedTestErrorResponseCode { get; set; }

        /// <summary>
        /// Set to true to authorise a part of the requested amount in case the cardholder does not have enough funds on their account.
        /// If a payment was partially authorised, the response includes resultCode: PartiallyAuthorised and the authorised amount in additionalData.authorisedAmountValue.
        /// To enable this functionality, contact our Support Team.
        /// </summary>
        [JsonProperty("allowPartialAuth", NullValueHandling = NullValueHandling.Ignore)]
        public string AllowPartialAuth { get; set; }

        /// <summary>
        /// Flags a card payment request for either pre-authorisation or final authorisation. For more information, refer to [Authorisation types](https://docs.adyen.com/online-payments/adjust-authorisation#authorisation-types).
        /// Allowed values:
        /// * **PreAuth** – flags the payment request to be handled as a pre-authorisation.
        /// * **FinalAuth** – flags the payment request to be handled as a final authorisation.
        /// </summary>
        [JsonProperty("authorisationType", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorisationType { get; set; }

        /// <summary>
        /// Allows you to determine or override the acquirer account that should be used for the transaction.
        /// If you need to process a payment with an acquirer different from a default one, you can set up a corresponding configuration on the Adyen payments platform. Then you can pass a custom routing flag in a payment request's additional data to target a specific acquirer.
        /// To enable this functionality, contact [Support](https://www.adyen.help/hc/en-us/requests/new).
        /// </summary>
        [JsonProperty("customRoutingFlag", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomRoutingFlag { get; set; }

        /// <summary>
        /// In case of [asynchronous authorisation adjustment](https://docs.adyen.com/online-payments/adjust-authorisation#adjust-authorisation), this field denotes why the additional payment is made.
        /// Possible values:
        ///  * **NoShow**: An incremental charge is carried out because of a no-show for a guaranteed reservation.
        ///  * **DelayedCharge**: An incremental charge is carried out to process an additional payment after the original services have been rendered and the respective payment has been processed.
        /// </summary>
        [JsonProperty("industryUsage", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IndustryUsageEnum? IndustryUsage { get; set; }

        /// <summary>
        /// Set to **true** to require [manual capture](https://docs.adyen.com/online-payments/capture) for the transaction.
        /// </summary>
        [JsonProperty("manualCapture", NullValueHandling = NullValueHandling.Ignore)]
        public string ManualCapture { get; set; }

        /// <summary>
        /// Allows you to link the transaction to the original or previous one in a subscription/card-on-file chain. This field is required for token-based transactions where Adyen does not tokenize the card.
        /// Transaction identifier from card schemes, for example, Mastercard Trace ID or the Visa Transaction ID.
        /// Submit the original transaction ID of the contract in your payment request if you are not tokenizing card details with Adyen and are making a merchant-initiated transaction (MIT) for subsequent charges.
        /// Make sure you are sending `shopperInteraction` **ContAuth** and `recurringProcessingModel` **Subscription** or **UnscheduledCardOnFile** to ensure that the transaction is classified as MIT.
        /// </summary>
        [JsonProperty("networkTxReference", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkTxReference { get; set; }

        /// <summary>
        /// Boolean indicator that can be optionally used for performing debit transactions on combo cards (for example, combo cards in Brazil). This is not mandatory but we recommend that you set this to true if you want to use the `selectedBrand` value to specify how to process the transaction.
        /// </summary>
        [JsonProperty("overwriteBrand", NullValueHandling = NullValueHandling.Ignore)]
        public string OverwriteBrand { get; set; }

        /// <summary>
        /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the city of the actual merchant's address.
        /// * Format: alpha-numeric.
        /// * Maximum length: 13 characters.
        /// </summary>
        [JsonProperty("subMerchantCity", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantCity { get; set; }

        /// <summary>
        /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the three-letter country code of the actual merchant's address.
        /// * Format: alpha-numeric.
        /// * Fixed length: 3 characters.
        /// </summary>
        [JsonProperty("subMerchantCountry", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantCountry { get; set; }

        /// <summary>
        /// This field contains an identifier of the actual merchant when a transaction is submitted via a payment facilitator. The payment facilitator must send in this unique ID.
        /// A unique identifier per submerchant that is required if the transaction is performed by a registered payment facilitator.
        /// * Format: alpha-numeric.
        /// * Fixed length: 15 characters.
        /// </summary>
        [JsonProperty("subMerchantID", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantID { get; set; }

        /// <summary>
        /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the name of the actual merchant.
        /// * Format: alpha-numeric.
        /// * Maximum length: 22 characters.
        /// </summary>
        [JsonProperty("subMerchantName", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantName { get; set; }

        /// <summary>
        /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the postal code of the actual merchant's address.
        /// * Format: alpha-numeric.
        /// * Maximum length: 10 characters.
        /// </summary>
        [JsonProperty("subMerchantPostalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantPostalCode { get; set; }

        /// <summary>
        /// This field is required if the transaction is performed by a registered payment facilitator, and if applicable to the country. This field must contain the state code of the actual merchant's address.
        /// * Format: alpha-numeric.
        /// * Maximum length: 3 characters.
        /// </summary>
        [JsonProperty("subMerchantState", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantState { get; set; }

        /// <summary>
        /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the street of the actual merchant's address.
        /// * Format: alpha-numeric.
        /// * Maximum length: 60 characters.
        /// </summary>
        [JsonProperty("subMerchantStreet", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantStreet { get; set; }

        /// <summary>
        /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the tax ID of the actual merchant.
        /// * Format: alpha-numeric.
        /// * Fixed length: 11 or 14 characters.
        /// </summary>
        [JsonProperty("subMerchantTaxId", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantTaxId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalDataCommon : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdditionalDataCommon other &&                ((this.RequestedTestErrorResponseCode == null && other.RequestedTestErrorResponseCode == null) || (this.RequestedTestErrorResponseCode?.Equals(other.RequestedTestErrorResponseCode) == true)) &&
                ((this.AllowPartialAuth == null && other.AllowPartialAuth == null) || (this.AllowPartialAuth?.Equals(other.AllowPartialAuth) == true)) &&
                ((this.AuthorisationType == null && other.AuthorisationType == null) || (this.AuthorisationType?.Equals(other.AuthorisationType) == true)) &&
                ((this.CustomRoutingFlag == null && other.CustomRoutingFlag == null) || (this.CustomRoutingFlag?.Equals(other.CustomRoutingFlag) == true)) &&
                ((this.IndustryUsage == null && other.IndustryUsage == null) || (this.IndustryUsage?.Equals(other.IndustryUsage) == true)) &&
                ((this.ManualCapture == null && other.ManualCapture == null) || (this.ManualCapture?.Equals(other.ManualCapture) == true)) &&
                ((this.NetworkTxReference == null && other.NetworkTxReference == null) || (this.NetworkTxReference?.Equals(other.NetworkTxReference) == true)) &&
                ((this.OverwriteBrand == null && other.OverwriteBrand == null) || (this.OverwriteBrand?.Equals(other.OverwriteBrand) == true)) &&
                ((this.SubMerchantCity == null && other.SubMerchantCity == null) || (this.SubMerchantCity?.Equals(other.SubMerchantCity) == true)) &&
                ((this.SubMerchantCountry == null && other.SubMerchantCountry == null) || (this.SubMerchantCountry?.Equals(other.SubMerchantCountry) == true)) &&
                ((this.SubMerchantID == null && other.SubMerchantID == null) || (this.SubMerchantID?.Equals(other.SubMerchantID) == true)) &&
                ((this.SubMerchantName == null && other.SubMerchantName == null) || (this.SubMerchantName?.Equals(other.SubMerchantName) == true)) &&
                ((this.SubMerchantPostalCode == null && other.SubMerchantPostalCode == null) || (this.SubMerchantPostalCode?.Equals(other.SubMerchantPostalCode) == true)) &&
                ((this.SubMerchantState == null && other.SubMerchantState == null) || (this.SubMerchantState?.Equals(other.SubMerchantState) == true)) &&
                ((this.SubMerchantStreet == null && other.SubMerchantStreet == null) || (this.SubMerchantStreet?.Equals(other.SubMerchantStreet) == true)) &&
                ((this.SubMerchantTaxId == null && other.SubMerchantTaxId == null) || (this.SubMerchantTaxId?.Equals(other.SubMerchantTaxId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestedTestErrorResponseCode = {(this.RequestedTestErrorResponseCode == null ? "null" : this.RequestedTestErrorResponseCode)}");
            toStringOutput.Add($"this.AllowPartialAuth = {(this.AllowPartialAuth == null ? "null" : this.AllowPartialAuth)}");
            toStringOutput.Add($"this.AuthorisationType = {(this.AuthorisationType == null ? "null" : this.AuthorisationType)}");
            toStringOutput.Add($"this.CustomRoutingFlag = {(this.CustomRoutingFlag == null ? "null" : this.CustomRoutingFlag)}");
            toStringOutput.Add($"this.IndustryUsage = {(this.IndustryUsage == null ? "null" : this.IndustryUsage.ToString())}");
            toStringOutput.Add($"this.ManualCapture = {(this.ManualCapture == null ? "null" : this.ManualCapture)}");
            toStringOutput.Add($"this.NetworkTxReference = {(this.NetworkTxReference == null ? "null" : this.NetworkTxReference)}");
            toStringOutput.Add($"this.OverwriteBrand = {(this.OverwriteBrand == null ? "null" : this.OverwriteBrand)}");
            toStringOutput.Add($"this.SubMerchantCity = {(this.SubMerchantCity == null ? "null" : this.SubMerchantCity)}");
            toStringOutput.Add($"this.SubMerchantCountry = {(this.SubMerchantCountry == null ? "null" : this.SubMerchantCountry)}");
            toStringOutput.Add($"this.SubMerchantID = {(this.SubMerchantID == null ? "null" : this.SubMerchantID)}");
            toStringOutput.Add($"this.SubMerchantName = {(this.SubMerchantName == null ? "null" : this.SubMerchantName)}");
            toStringOutput.Add($"this.SubMerchantPostalCode = {(this.SubMerchantPostalCode == null ? "null" : this.SubMerchantPostalCode)}");
            toStringOutput.Add($"this.SubMerchantState = {(this.SubMerchantState == null ? "null" : this.SubMerchantState)}");
            toStringOutput.Add($"this.SubMerchantStreet = {(this.SubMerchantStreet == null ? "null" : this.SubMerchantStreet)}");
            toStringOutput.Add($"this.SubMerchantTaxId = {(this.SubMerchantTaxId == null ? "null" : this.SubMerchantTaxId)}");
        }
    }
}