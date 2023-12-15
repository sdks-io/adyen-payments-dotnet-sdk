// <copyright file="AccountInfo.cs" company="APIMatic">
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
    /// AccountInfo.
    /// </summary>
    public class AccountInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInfo"/> class.
        /// </summary>
        public AccountInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInfo"/> class.
        /// </summary>
        /// <param name="accountAgeIndicator">accountAgeIndicator.</param>
        /// <param name="accountChangeDate">accountChangeDate.</param>
        /// <param name="accountChangeIndicator">accountChangeIndicator.</param>
        /// <param name="accountCreationDate">accountCreationDate.</param>
        /// <param name="accountType">accountType.</param>
        /// <param name="addCardAttemptsDay">addCardAttemptsDay.</param>
        /// <param name="deliveryAddressUsageDate">deliveryAddressUsageDate.</param>
        /// <param name="deliveryAddressUsageIndicator">deliveryAddressUsageIndicator.</param>
        /// <param name="homePhone">homePhone.</param>
        /// <param name="mobilePhone">mobilePhone.</param>
        /// <param name="passwordChangeDate">passwordChangeDate.</param>
        /// <param name="passwordChangeIndicator">passwordChangeIndicator.</param>
        /// <param name="pastTransactionsDay">pastTransactionsDay.</param>
        /// <param name="pastTransactionsYear">pastTransactionsYear.</param>
        /// <param name="paymentAccountAge">paymentAccountAge.</param>
        /// <param name="paymentAccountIndicator">paymentAccountIndicator.</param>
        /// <param name="purchasesLast6Months">purchasesLast6Months.</param>
        /// <param name="suspiciousActivity">suspiciousActivity.</param>
        /// <param name="workPhone">workPhone.</param>
        public AccountInfo(
            Models.AccountAgeIndicatorEnum? accountAgeIndicator = null,
            DateTime? accountChangeDate = null,
            Models.AccountChangeIndicatorEnum? accountChangeIndicator = null,
            DateTime? accountCreationDate = null,
            Models.AccountTypeEnum? accountType = null,
            int? addCardAttemptsDay = null,
            DateTime? deliveryAddressUsageDate = null,
            Models.DeliveryAddressUsageIndicatorEnum? deliveryAddressUsageIndicator = null,
            string homePhone = null,
            string mobilePhone = null,
            DateTime? passwordChangeDate = null,
            Models.PasswordChangeIndicatorEnum? passwordChangeIndicator = null,
            int? pastTransactionsDay = null,
            int? pastTransactionsYear = null,
            DateTime? paymentAccountAge = null,
            Models.PaymentAccountIndicatorEnum? paymentAccountIndicator = null,
            int? purchasesLast6Months = null,
            bool? suspiciousActivity = null,
            string workPhone = null)
        {
            this.AccountAgeIndicator = accountAgeIndicator;
            this.AccountChangeDate = accountChangeDate;
            this.AccountChangeIndicator = accountChangeIndicator;
            this.AccountCreationDate = accountCreationDate;
            this.AccountType = accountType;
            this.AddCardAttemptsDay = addCardAttemptsDay;
            this.DeliveryAddressUsageDate = deliveryAddressUsageDate;
            this.DeliveryAddressUsageIndicator = deliveryAddressUsageIndicator;
            this.HomePhone = homePhone;
            this.MobilePhone = mobilePhone;
            this.PasswordChangeDate = passwordChangeDate;
            this.PasswordChangeIndicator = passwordChangeIndicator;
            this.PastTransactionsDay = pastTransactionsDay;
            this.PastTransactionsYear = pastTransactionsYear;
            this.PaymentAccountAge = paymentAccountAge;
            this.PaymentAccountIndicator = paymentAccountIndicator;
            this.PurchasesLast6Months = purchasesLast6Months;
            this.SuspiciousActivity = suspiciousActivity;
            this.WorkPhone = workPhone;
        }

        /// <summary>
        /// Indicator for the length of time since this shopper account was created in the merchant's environment.
        /// Allowed values:
        /// * notApplicable
        /// * thisTransaction
        /// * lessThan30Days
        /// * from30To60Days
        /// * moreThan60Days
        /// </summary>
        [JsonProperty("accountAgeIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountAgeIndicatorEnum? AccountAgeIndicator { get; set; }

        /// <summary>
        /// Date when the shopper's account was last changed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("accountChangeDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AccountChangeDate { get; set; }

        /// <summary>
        /// Indicator for the length of time since the shopper's account was last updated.
        /// Allowed values:
        /// * thisTransaction
        /// * lessThan30Days
        /// * from30To60Days
        /// * moreThan60Days
        /// </summary>
        [JsonProperty("accountChangeIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountChangeIndicatorEnum? AccountChangeIndicator { get; set; }

        /// <summary>
        /// Date when the shopper's account was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("accountCreationDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AccountCreationDate { get; set; }

        /// <summary>
        /// Indicates the type of account. For example, for a multi-account card product.
        /// Allowed values:
        /// * notApplicable
        /// * credit
        /// * debit
        /// </summary>
        [JsonProperty("accountType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountTypeEnum? AccountType { get; set; }

        /// <summary>
        /// Number of attempts the shopper tried to add a card to their account in the last day.
        /// </summary>
        [JsonProperty("addCardAttemptsDay", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddCardAttemptsDay { get; set; }

        /// <summary>
        /// Date the selected delivery address was first used.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deliveryAddressUsageDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DeliveryAddressUsageDate { get; set; }

        /// <summary>
        /// Indicator for the length of time since this delivery address was first used.
        /// Allowed values:
        /// * thisTransaction
        /// * lessThan30Days
        /// * from30To60Days
        /// * moreThan60Days
        /// </summary>
        [JsonProperty("deliveryAddressUsageIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeliveryAddressUsageIndicatorEnum? DeliveryAddressUsageIndicator { get; set; }

        /// <summary>
        /// Shopper's home phone number (including the country code).
        /// </summary>
        [JsonProperty("homePhone", NullValueHandling = NullValueHandling.Ignore)]
        public string HomePhone { get; set; }

        /// <summary>
        /// Shopper's mobile phone number (including the country code).
        /// </summary>
        [JsonProperty("mobilePhone", NullValueHandling = NullValueHandling.Ignore)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Date when the shopper last changed their password.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("passwordChangeDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PasswordChangeDate { get; set; }

        /// <summary>
        /// Indicator when the shopper has changed their password.
        /// Allowed values:
        /// * notApplicable
        /// * thisTransaction
        /// * lessThan30Days
        /// * from30To60Days
        /// * moreThan60Days
        /// </summary>
        [JsonProperty("passwordChangeIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PasswordChangeIndicatorEnum? PasswordChangeIndicator { get; set; }

        /// <summary>
        /// Number of all transactions (successful and abandoned) from this shopper in the past 24 hours.
        /// </summary>
        [JsonProperty("pastTransactionsDay", NullValueHandling = NullValueHandling.Ignore)]
        public int? PastTransactionsDay { get; set; }

        /// <summary>
        /// Number of all transactions (successful and abandoned) from this shopper in the past year.
        /// </summary>
        [JsonProperty("pastTransactionsYear", NullValueHandling = NullValueHandling.Ignore)]
        public int? PastTransactionsYear { get; set; }

        /// <summary>
        /// Date this payment method was added to the shopper's account.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("paymentAccountAge", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PaymentAccountAge { get; set; }

        /// <summary>
        /// Indicator for the length of time since this payment method was added to this shopper's account.
        /// Allowed values:
        /// * notApplicable
        /// * thisTransaction
        /// * lessThan30Days
        /// * from30To60Days
        /// * moreThan60Days
        /// </summary>
        [JsonProperty("paymentAccountIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentAccountIndicatorEnum? PaymentAccountIndicator { get; set; }

        /// <summary>
        /// Number of successful purchases in the last six months.
        /// </summary>
        [JsonProperty("purchasesLast6Months", NullValueHandling = NullValueHandling.Ignore)]
        public int? PurchasesLast6Months { get; set; }

        /// <summary>
        /// Whether suspicious activity was recorded on this account.
        /// </summary>
        [JsonProperty("suspiciousActivity", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SuspiciousActivity { get; set; }

        /// <summary>
        /// Shopper's work phone number (including the country code).
        /// </summary>
        [JsonProperty("workPhone", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkPhone { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountInfo : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountInfo other &&                ((this.AccountAgeIndicator == null && other.AccountAgeIndicator == null) || (this.AccountAgeIndicator?.Equals(other.AccountAgeIndicator) == true)) &&
                ((this.AccountChangeDate == null && other.AccountChangeDate == null) || (this.AccountChangeDate?.Equals(other.AccountChangeDate) == true)) &&
                ((this.AccountChangeIndicator == null && other.AccountChangeIndicator == null) || (this.AccountChangeIndicator?.Equals(other.AccountChangeIndicator) == true)) &&
                ((this.AccountCreationDate == null && other.AccountCreationDate == null) || (this.AccountCreationDate?.Equals(other.AccountCreationDate) == true)) &&
                ((this.AccountType == null && other.AccountType == null) || (this.AccountType?.Equals(other.AccountType) == true)) &&
                ((this.AddCardAttemptsDay == null && other.AddCardAttemptsDay == null) || (this.AddCardAttemptsDay?.Equals(other.AddCardAttemptsDay) == true)) &&
                ((this.DeliveryAddressUsageDate == null && other.DeliveryAddressUsageDate == null) || (this.DeliveryAddressUsageDate?.Equals(other.DeliveryAddressUsageDate) == true)) &&
                ((this.DeliveryAddressUsageIndicator == null && other.DeliveryAddressUsageIndicator == null) || (this.DeliveryAddressUsageIndicator?.Equals(other.DeliveryAddressUsageIndicator) == true)) &&
                ((this.HomePhone == null && other.HomePhone == null) || (this.HomePhone?.Equals(other.HomePhone) == true)) &&
                ((this.MobilePhone == null && other.MobilePhone == null) || (this.MobilePhone?.Equals(other.MobilePhone) == true)) &&
                ((this.PasswordChangeDate == null && other.PasswordChangeDate == null) || (this.PasswordChangeDate?.Equals(other.PasswordChangeDate) == true)) &&
                ((this.PasswordChangeIndicator == null && other.PasswordChangeIndicator == null) || (this.PasswordChangeIndicator?.Equals(other.PasswordChangeIndicator) == true)) &&
                ((this.PastTransactionsDay == null && other.PastTransactionsDay == null) || (this.PastTransactionsDay?.Equals(other.PastTransactionsDay) == true)) &&
                ((this.PastTransactionsYear == null && other.PastTransactionsYear == null) || (this.PastTransactionsYear?.Equals(other.PastTransactionsYear) == true)) &&
                ((this.PaymentAccountAge == null && other.PaymentAccountAge == null) || (this.PaymentAccountAge?.Equals(other.PaymentAccountAge) == true)) &&
                ((this.PaymentAccountIndicator == null && other.PaymentAccountIndicator == null) || (this.PaymentAccountIndicator?.Equals(other.PaymentAccountIndicator) == true)) &&
                ((this.PurchasesLast6Months == null && other.PurchasesLast6Months == null) || (this.PurchasesLast6Months?.Equals(other.PurchasesLast6Months) == true)) &&
                ((this.SuspiciousActivity == null && other.SuspiciousActivity == null) || (this.SuspiciousActivity?.Equals(other.SuspiciousActivity) == true)) &&
                ((this.WorkPhone == null && other.WorkPhone == null) || (this.WorkPhone?.Equals(other.WorkPhone) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountAgeIndicator = {(this.AccountAgeIndicator == null ? "null" : this.AccountAgeIndicator.ToString())}");
            toStringOutput.Add($"this.AccountChangeDate = {(this.AccountChangeDate == null ? "null" : this.AccountChangeDate.ToString())}");
            toStringOutput.Add($"this.AccountChangeIndicator = {(this.AccountChangeIndicator == null ? "null" : this.AccountChangeIndicator.ToString())}");
            toStringOutput.Add($"this.AccountCreationDate = {(this.AccountCreationDate == null ? "null" : this.AccountCreationDate.ToString())}");
            toStringOutput.Add($"this.AccountType = {(this.AccountType == null ? "null" : this.AccountType.ToString())}");
            toStringOutput.Add($"this.AddCardAttemptsDay = {(this.AddCardAttemptsDay == null ? "null" : this.AddCardAttemptsDay.ToString())}");
            toStringOutput.Add($"this.DeliveryAddressUsageDate = {(this.DeliveryAddressUsageDate == null ? "null" : this.DeliveryAddressUsageDate.ToString())}");
            toStringOutput.Add($"this.DeliveryAddressUsageIndicator = {(this.DeliveryAddressUsageIndicator == null ? "null" : this.DeliveryAddressUsageIndicator.ToString())}");
            toStringOutput.Add($"this.HomePhone = {(this.HomePhone == null ? "null" : this.HomePhone)}");
            toStringOutput.Add($"this.MobilePhone = {(this.MobilePhone == null ? "null" : this.MobilePhone)}");
            toStringOutput.Add($"this.PasswordChangeDate = {(this.PasswordChangeDate == null ? "null" : this.PasswordChangeDate.ToString())}");
            toStringOutput.Add($"this.PasswordChangeIndicator = {(this.PasswordChangeIndicator == null ? "null" : this.PasswordChangeIndicator.ToString())}");
            toStringOutput.Add($"this.PastTransactionsDay = {(this.PastTransactionsDay == null ? "null" : this.PastTransactionsDay.ToString())}");
            toStringOutput.Add($"this.PastTransactionsYear = {(this.PastTransactionsYear == null ? "null" : this.PastTransactionsYear.ToString())}");
            toStringOutput.Add($"this.PaymentAccountAge = {(this.PaymentAccountAge == null ? "null" : this.PaymentAccountAge.ToString())}");
            toStringOutput.Add($"this.PaymentAccountIndicator = {(this.PaymentAccountIndicator == null ? "null" : this.PaymentAccountIndicator.ToString())}");
            toStringOutput.Add($"this.PurchasesLast6Months = {(this.PurchasesLast6Months == null ? "null" : this.PurchasesLast6Months.ToString())}");
            toStringOutput.Add($"this.SuspiciousActivity = {(this.SuspiciousActivity == null ? "null" : this.SuspiciousActivity.ToString())}");
            toStringOutput.Add($"this.WorkPhone = {(this.WorkPhone == null ? "null" : this.WorkPhone)}");
        }
    }
}