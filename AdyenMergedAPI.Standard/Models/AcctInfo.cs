// <copyright file="AcctInfo.cs" company="APIMatic">
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
    /// AcctInfo.
    /// </summary>
    public class AcctInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcctInfo"/> class.
        /// </summary>
        public AcctInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcctInfo"/> class.
        /// </summary>
        /// <param name="chAccAgeInd">chAccAgeInd.</param>
        /// <param name="chAccChange">chAccChange.</param>
        /// <param name="chAccChangeInd">chAccChangeInd.</param>
        /// <param name="chAccPwChange">chAccPwChange.</param>
        /// <param name="chAccPwChangeInd">chAccPwChangeInd.</param>
        /// <param name="chAccString">chAccString.</param>
        /// <param name="nbPurchaseAccount">nbPurchaseAccount.</param>
        /// <param name="paymentAccAge">paymentAccAge.</param>
        /// <param name="paymentAccInd">paymentAccInd.</param>
        /// <param name="provisionAttemptsDay">provisionAttemptsDay.</param>
        /// <param name="shipAddressUsage">shipAddressUsage.</param>
        /// <param name="shipAddressUsageInd">shipAddressUsageInd.</param>
        /// <param name="shipNameIndicator">shipNameIndicator.</param>
        /// <param name="suspiciousAccActivity">suspiciousAccActivity.</param>
        /// <param name="txnActivityDay">txnActivityDay.</param>
        /// <param name="txnActivityYear">txnActivityYear.</param>
        public AcctInfo(
            Models.ChAccAgeIndEnum? chAccAgeInd = null,
            string chAccChange = null,
            Models.ChAccChangeIndEnum? chAccChangeInd = null,
            string chAccPwChange = null,
            Models.ChAccPwChangeIndEnum? chAccPwChangeInd = null,
            string chAccString = null,
            string nbPurchaseAccount = null,
            string paymentAccAge = null,
            Models.PaymentAccIndEnum? paymentAccInd = null,
            string provisionAttemptsDay = null,
            string shipAddressUsage = null,
            Models.ShipAddressUsageIndEnum? shipAddressUsageInd = null,
            Models.ShipNameIndicatorEnum? shipNameIndicator = null,
            Models.SuspiciousAccActivityEnum? suspiciousAccActivity = null,
            string txnActivityDay = null,
            string txnActivityYear = null)
        {
            this.ChAccAgeInd = chAccAgeInd;
            this.ChAccChange = chAccChange;
            this.ChAccChangeInd = chAccChangeInd;
            this.ChAccPwChange = chAccPwChange;
            this.ChAccPwChangeInd = chAccPwChangeInd;
            this.ChAccString = chAccString;
            this.NbPurchaseAccount = nbPurchaseAccount;
            this.PaymentAccAge = paymentAccAge;
            this.PaymentAccInd = paymentAccInd;
            this.ProvisionAttemptsDay = provisionAttemptsDay;
            this.ShipAddressUsage = shipAddressUsage;
            this.ShipAddressUsageInd = shipAddressUsageInd;
            this.ShipNameIndicator = shipNameIndicator;
            this.SuspiciousAccActivity = suspiciousAccActivity;
            this.TxnActivityDay = txnActivityDay;
            this.TxnActivityYear = txnActivityYear;
        }

        /// <summary>
        /// Length of time that the cardholder has had the account with the 3DS Requestor.
        /// Allowed values:
        /// * **01** — No account
        /// * **02** — Created during this transaction
        /// * **03** — Less than 30 days
        /// * **04** — 30–60 days
        /// * **05** — More than 60 days
        /// </summary>
        [JsonProperty("chAccAgeInd", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChAccAgeIndEnum? ChAccAgeInd { get; set; }

        /// <summary>
        /// Date that the cardholder’s account with the 3DS Requestor was last changed, including Billing or Shipping address, new payment account, or new user(s) added.
        /// Format: **YYYYMMDD**
        /// </summary>
        [JsonProperty("chAccChange", NullValueHandling = NullValueHandling.Ignore)]
        public string ChAccChange { get; set; }

        /// <summary>
        /// Length of time since the cardholder’s account information with the 3DS Requestor was last changed, including Billing or Shipping address, new payment account, or new user(s) added.
        /// Allowed values:
        /// * **01** — Changed during this transaction
        /// * **02** — Less than 30 days
        /// * **03** — 30–60 days
        /// * **04** — More than 60 days
        /// </summary>
        [JsonProperty("chAccChangeInd", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChAccChangeIndEnum? ChAccChangeInd { get; set; }

        /// <summary>
        /// Date that cardholder’s account with the 3DS Requestor had a password change or account reset.
        /// Format: **YYYYMMDD**
        /// </summary>
        [JsonProperty("chAccPwChange", NullValueHandling = NullValueHandling.Ignore)]
        public string ChAccPwChange { get; set; }

        /// <summary>
        /// Indicates the length of time since the cardholder’s account with the 3DS Requestor had a password change or account reset.
        /// Allowed values:
        /// * **01** — No change
        /// * **02** — Changed during this transaction
        /// * **03** — Less than 30 days
        /// * **04** — 30–60 days
        /// * **05** — More than 60 days
        /// </summary>
        [JsonProperty("chAccPwChangeInd", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChAccPwChangeIndEnum? ChAccPwChangeInd { get; set; }

        /// <summary>
        /// Date that the cardholder opened the account with the 3DS Requestor.
        /// Format: **YYYYMMDD**
        /// </summary>
        [JsonProperty("chAccString", NullValueHandling = NullValueHandling.Ignore)]
        public string ChAccString { get; set; }

        /// <summary>
        /// Number of purchases with this cardholder account during the previous six months. Max length: 4 characters.
        /// </summary>
        [JsonProperty("nbPurchaseAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string NbPurchaseAccount { get; set; }

        /// <summary>
        /// String that the payment account was enrolled in the cardholder’s account with the 3DS Requestor.
        /// Format: **YYYYMMDD**
        /// </summary>
        [JsonProperty("paymentAccAge", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentAccAge { get; set; }

        /// <summary>
        /// Indicates the length of time that the payment account was enrolled in the cardholder’s account with the 3DS Requestor.
        /// Allowed values:
        /// * **01** — No account (guest checkout)
        /// * **02** — During this transaction
        /// * **03** — Less than 30 days
        /// * **04** — 30–60 days
        /// * **05** — More than 60 days
        /// </summary>
        [JsonProperty("paymentAccInd", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentAccIndEnum? PaymentAccInd { get; set; }

        /// <summary>
        /// Number of Add Card attempts in the last 24 hours. Max length: 3 characters.
        /// </summary>
        [JsonProperty("provisionAttemptsDay", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisionAttemptsDay { get; set; }

        /// <summary>
        /// String when the shipping address used for this transaction was first used with the 3DS Requestor.
        /// Format: **YYYYMMDD**
        /// </summary>
        [JsonProperty("shipAddressUsage", NullValueHandling = NullValueHandling.Ignore)]
        public string ShipAddressUsage { get; set; }

        /// <summary>
        /// Indicates when the shipping address used for this transaction was first used with the 3DS Requestor.
        /// Allowed values:
        /// * **01** — This transaction
        /// * **02** — Less than 30 days
        /// * **03** — 30–60 days
        /// * **04** — More than 60 days
        /// </summary>
        [JsonProperty("shipAddressUsageInd", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ShipAddressUsageIndEnum? ShipAddressUsageInd { get; set; }

        /// <summary>
        /// Indicates if the Cardholder Name on the account is identical to the shipping Name used for this transaction.
        /// Allowed values:
        /// * **01** — Account Name identical to shipping Name
        /// * **02** — Account Name different to shipping Name
        /// </summary>
        [JsonProperty("shipNameIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ShipNameIndicatorEnum? ShipNameIndicator { get; set; }

        /// <summary>
        /// Indicates whether the 3DS Requestor has experienced suspicious activity (including previous fraud) on the cardholder account.
        /// Allowed values:
        /// * **01** — No suspicious activity has been observed
        /// * **02** — Suspicious activity has been observed
        /// </summary>
        [JsonProperty("suspiciousAccActivity", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SuspiciousAccActivityEnum? SuspiciousAccActivity { get; set; }

        /// <summary>
        /// Number of transactions (successful and abandoned) for this cardholder account with the 3DS Requestor across all payment accounts in the previous 24 hours. Max length: 3 characters.
        /// </summary>
        [JsonProperty("txnActivityDay", NullValueHandling = NullValueHandling.Ignore)]
        public string TxnActivityDay { get; set; }

        /// <summary>
        /// Number of transactions (successful and abandoned) for this cardholder account with the 3DS Requestor across all payment accounts in the previous year. Max length: 3 characters.
        /// </summary>
        [JsonProperty("txnActivityYear", NullValueHandling = NullValueHandling.Ignore)]
        public string TxnActivityYear { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AcctInfo : ({string.Join(", ", toStringOutput)})";
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
            return obj is AcctInfo other &&                ((this.ChAccAgeInd == null && other.ChAccAgeInd == null) || (this.ChAccAgeInd?.Equals(other.ChAccAgeInd) == true)) &&
                ((this.ChAccChange == null && other.ChAccChange == null) || (this.ChAccChange?.Equals(other.ChAccChange) == true)) &&
                ((this.ChAccChangeInd == null && other.ChAccChangeInd == null) || (this.ChAccChangeInd?.Equals(other.ChAccChangeInd) == true)) &&
                ((this.ChAccPwChange == null && other.ChAccPwChange == null) || (this.ChAccPwChange?.Equals(other.ChAccPwChange) == true)) &&
                ((this.ChAccPwChangeInd == null && other.ChAccPwChangeInd == null) || (this.ChAccPwChangeInd?.Equals(other.ChAccPwChangeInd) == true)) &&
                ((this.ChAccString == null && other.ChAccString == null) || (this.ChAccString?.Equals(other.ChAccString) == true)) &&
                ((this.NbPurchaseAccount == null && other.NbPurchaseAccount == null) || (this.NbPurchaseAccount?.Equals(other.NbPurchaseAccount) == true)) &&
                ((this.PaymentAccAge == null && other.PaymentAccAge == null) || (this.PaymentAccAge?.Equals(other.PaymentAccAge) == true)) &&
                ((this.PaymentAccInd == null && other.PaymentAccInd == null) || (this.PaymentAccInd?.Equals(other.PaymentAccInd) == true)) &&
                ((this.ProvisionAttemptsDay == null && other.ProvisionAttemptsDay == null) || (this.ProvisionAttemptsDay?.Equals(other.ProvisionAttemptsDay) == true)) &&
                ((this.ShipAddressUsage == null && other.ShipAddressUsage == null) || (this.ShipAddressUsage?.Equals(other.ShipAddressUsage) == true)) &&
                ((this.ShipAddressUsageInd == null && other.ShipAddressUsageInd == null) || (this.ShipAddressUsageInd?.Equals(other.ShipAddressUsageInd) == true)) &&
                ((this.ShipNameIndicator == null && other.ShipNameIndicator == null) || (this.ShipNameIndicator?.Equals(other.ShipNameIndicator) == true)) &&
                ((this.SuspiciousAccActivity == null && other.SuspiciousAccActivity == null) || (this.SuspiciousAccActivity?.Equals(other.SuspiciousAccActivity) == true)) &&
                ((this.TxnActivityDay == null && other.TxnActivityDay == null) || (this.TxnActivityDay?.Equals(other.TxnActivityDay) == true)) &&
                ((this.TxnActivityYear == null && other.TxnActivityYear == null) || (this.TxnActivityYear?.Equals(other.TxnActivityYear) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ChAccAgeInd = {(this.ChAccAgeInd == null ? "null" : this.ChAccAgeInd.ToString())}");
            toStringOutput.Add($"this.ChAccChange = {(this.ChAccChange == null ? "null" : this.ChAccChange)}");
            toStringOutput.Add($"this.ChAccChangeInd = {(this.ChAccChangeInd == null ? "null" : this.ChAccChangeInd.ToString())}");
            toStringOutput.Add($"this.ChAccPwChange = {(this.ChAccPwChange == null ? "null" : this.ChAccPwChange)}");
            toStringOutput.Add($"this.ChAccPwChangeInd = {(this.ChAccPwChangeInd == null ? "null" : this.ChAccPwChangeInd.ToString())}");
            toStringOutput.Add($"this.ChAccString = {(this.ChAccString == null ? "null" : this.ChAccString)}");
            toStringOutput.Add($"this.NbPurchaseAccount = {(this.NbPurchaseAccount == null ? "null" : this.NbPurchaseAccount)}");
            toStringOutput.Add($"this.PaymentAccAge = {(this.PaymentAccAge == null ? "null" : this.PaymentAccAge)}");
            toStringOutput.Add($"this.PaymentAccInd = {(this.PaymentAccInd == null ? "null" : this.PaymentAccInd.ToString())}");
            toStringOutput.Add($"this.ProvisionAttemptsDay = {(this.ProvisionAttemptsDay == null ? "null" : this.ProvisionAttemptsDay)}");
            toStringOutput.Add($"this.ShipAddressUsage = {(this.ShipAddressUsage == null ? "null" : this.ShipAddressUsage)}");
            toStringOutput.Add($"this.ShipAddressUsageInd = {(this.ShipAddressUsageInd == null ? "null" : this.ShipAddressUsageInd.ToString())}");
            toStringOutput.Add($"this.ShipNameIndicator = {(this.ShipNameIndicator == null ? "null" : this.ShipNameIndicator.ToString())}");
            toStringOutput.Add($"this.SuspiciousAccActivity = {(this.SuspiciousAccActivity == null ? "null" : this.SuspiciousAccActivity.ToString())}");
            toStringOutput.Add($"this.TxnActivityDay = {(this.TxnActivityDay == null ? "null" : this.TxnActivityDay)}");
            toStringOutput.Add($"this.TxnActivityYear = {(this.TxnActivityYear == null ? "null" : this.TxnActivityYear)}");
        }
    }
}