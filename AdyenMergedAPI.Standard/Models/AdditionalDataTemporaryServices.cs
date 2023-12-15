// <copyright file="AdditionalDataTemporaryServices.cs" company="APIMatic">
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
    /// AdditionalDataTemporaryServices.
    /// </summary>
    public class AdditionalDataTemporaryServices
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataTemporaryServices"/> class.
        /// </summary>
        public AdditionalDataTemporaryServices()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataTemporaryServices"/> class.
        /// </summary>
        /// <param name="enhancedSchemeDataCustomerReference">enhancedSchemeData.customerReference.</param>
        /// <param name="enhancedSchemeDataEmployeeName">enhancedSchemeData.employeeName.</param>
        /// <param name="enhancedSchemeDataJobDescription">enhancedSchemeData.jobDescription.</param>
        /// <param name="enhancedSchemeDataRegularHoursRate">enhancedSchemeData.regularHoursRate.</param>
        /// <param name="enhancedSchemeDataRegularHoursWorked">enhancedSchemeData.regularHoursWorked.</param>
        /// <param name="enhancedSchemeDataRequestName">enhancedSchemeData.requestName.</param>
        /// <param name="enhancedSchemeDataTempStartDate">enhancedSchemeData.tempStartDate.</param>
        /// <param name="enhancedSchemeDataTempWeekEnding">enhancedSchemeData.tempWeekEnding.</param>
        /// <param name="enhancedSchemeDataTotalTaxAmount">enhancedSchemeData.totalTaxAmount.</param>
        public AdditionalDataTemporaryServices(
            string enhancedSchemeDataCustomerReference = null,
            string enhancedSchemeDataEmployeeName = null,
            string enhancedSchemeDataJobDescription = null,
            string enhancedSchemeDataRegularHoursRate = null,
            string enhancedSchemeDataRegularHoursWorked = null,
            string enhancedSchemeDataRequestName = null,
            string enhancedSchemeDataTempStartDate = null,
            string enhancedSchemeDataTempWeekEnding = null,
            string enhancedSchemeDataTotalTaxAmount = null)
        {
            this.EnhancedSchemeDataCustomerReference = enhancedSchemeDataCustomerReference;
            this.EnhancedSchemeDataEmployeeName = enhancedSchemeDataEmployeeName;
            this.EnhancedSchemeDataJobDescription = enhancedSchemeDataJobDescription;
            this.EnhancedSchemeDataRegularHoursRate = enhancedSchemeDataRegularHoursRate;
            this.EnhancedSchemeDataRegularHoursWorked = enhancedSchemeDataRegularHoursWorked;
            this.EnhancedSchemeDataRequestName = enhancedSchemeDataRequestName;
            this.EnhancedSchemeDataTempStartDate = enhancedSchemeDataTempStartDate;
            this.EnhancedSchemeDataTempWeekEnding = enhancedSchemeDataTempWeekEnding;
            this.EnhancedSchemeDataTotalTaxAmount = enhancedSchemeDataTotalTaxAmount;
        }

        /// <summary>
        /// The customer code, if supplied by a customer.
        /// * Encoding: ASCII
        /// * maxLength: 25
        /// </summary>
        [JsonProperty("enhancedSchemeData.customerReference", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataCustomerReference { get; set; }

        /// <summary>
        /// The name or ID of the person working in a temporary capacity.
        /// * maxLength: 40.
        /// * Must not be all spaces.
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("enhancedSchemeData.employeeName", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataEmployeeName { get; set; }

        /// <summary>
        /// The job description of the person working in a temporary capacity.
        /// * maxLength: 40
        /// * Must not be all spaces.
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("enhancedSchemeData.jobDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataJobDescription { get; set; }

        /// <summary>
        /// The amount paid for regular hours worked, [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * maxLength: 7
        /// * Must not be empty
        /// * Can be all zeros
        /// </summary>
        [JsonProperty("enhancedSchemeData.regularHoursRate", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataRegularHoursRate { get; set; }

        /// <summary>
        /// The hours worked.
        /// * maxLength: 7
        /// * Must not be empty
        /// * Can be all zeros
        /// </summary>
        [JsonProperty("enhancedSchemeData.regularHoursWorked", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataRegularHoursWorked { get; set; }

        /// <summary>
        /// The name of the person requesting temporary services.
        /// * maxLength: 40
        /// * Must not be all zeros
        /// * Must not be all spaces
        /// </summary>
        [JsonProperty("enhancedSchemeData.requestName", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataRequestName { get; set; }

        /// <summary>
        /// The billing period start date.
        /// * Format: ddMMyy
        /// * maxLength: 6
        /// </summary>
        [JsonProperty("enhancedSchemeData.tempStartDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataTempStartDate { get; set; }

        /// <summary>
        /// The billing period end date.
        /// * Format: ddMMyy
        /// * maxLength: 6
        /// </summary>
        [JsonProperty("enhancedSchemeData.tempWeekEnding", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataTempWeekEnding { get; set; }

        /// <summary>
        /// The total tax amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes). For example, 2000 means USD 20.00
        /// * maxLength: 12
        /// </summary>
        [JsonProperty("enhancedSchemeData.totalTaxAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataTotalTaxAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalDataTemporaryServices : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdditionalDataTemporaryServices other &&                ((this.EnhancedSchemeDataCustomerReference == null && other.EnhancedSchemeDataCustomerReference == null) || (this.EnhancedSchemeDataCustomerReference?.Equals(other.EnhancedSchemeDataCustomerReference) == true)) &&
                ((this.EnhancedSchemeDataEmployeeName == null && other.EnhancedSchemeDataEmployeeName == null) || (this.EnhancedSchemeDataEmployeeName?.Equals(other.EnhancedSchemeDataEmployeeName) == true)) &&
                ((this.EnhancedSchemeDataJobDescription == null && other.EnhancedSchemeDataJobDescription == null) || (this.EnhancedSchemeDataJobDescription?.Equals(other.EnhancedSchemeDataJobDescription) == true)) &&
                ((this.EnhancedSchemeDataRegularHoursRate == null && other.EnhancedSchemeDataRegularHoursRate == null) || (this.EnhancedSchemeDataRegularHoursRate?.Equals(other.EnhancedSchemeDataRegularHoursRate) == true)) &&
                ((this.EnhancedSchemeDataRegularHoursWorked == null && other.EnhancedSchemeDataRegularHoursWorked == null) || (this.EnhancedSchemeDataRegularHoursWorked?.Equals(other.EnhancedSchemeDataRegularHoursWorked) == true)) &&
                ((this.EnhancedSchemeDataRequestName == null && other.EnhancedSchemeDataRequestName == null) || (this.EnhancedSchemeDataRequestName?.Equals(other.EnhancedSchemeDataRequestName) == true)) &&
                ((this.EnhancedSchemeDataTempStartDate == null && other.EnhancedSchemeDataTempStartDate == null) || (this.EnhancedSchemeDataTempStartDate?.Equals(other.EnhancedSchemeDataTempStartDate) == true)) &&
                ((this.EnhancedSchemeDataTempWeekEnding == null && other.EnhancedSchemeDataTempWeekEnding == null) || (this.EnhancedSchemeDataTempWeekEnding?.Equals(other.EnhancedSchemeDataTempWeekEnding) == true)) &&
                ((this.EnhancedSchemeDataTotalTaxAmount == null && other.EnhancedSchemeDataTotalTaxAmount == null) || (this.EnhancedSchemeDataTotalTaxAmount?.Equals(other.EnhancedSchemeDataTotalTaxAmount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EnhancedSchemeDataCustomerReference = {(this.EnhancedSchemeDataCustomerReference == null ? "null" : this.EnhancedSchemeDataCustomerReference)}");
            toStringOutput.Add($"this.EnhancedSchemeDataEmployeeName = {(this.EnhancedSchemeDataEmployeeName == null ? "null" : this.EnhancedSchemeDataEmployeeName)}");
            toStringOutput.Add($"this.EnhancedSchemeDataJobDescription = {(this.EnhancedSchemeDataJobDescription == null ? "null" : this.EnhancedSchemeDataJobDescription)}");
            toStringOutput.Add($"this.EnhancedSchemeDataRegularHoursRate = {(this.EnhancedSchemeDataRegularHoursRate == null ? "null" : this.EnhancedSchemeDataRegularHoursRate)}");
            toStringOutput.Add($"this.EnhancedSchemeDataRegularHoursWorked = {(this.EnhancedSchemeDataRegularHoursWorked == null ? "null" : this.EnhancedSchemeDataRegularHoursWorked)}");
            toStringOutput.Add($"this.EnhancedSchemeDataRequestName = {(this.EnhancedSchemeDataRequestName == null ? "null" : this.EnhancedSchemeDataRequestName)}");
            toStringOutput.Add($"this.EnhancedSchemeDataTempStartDate = {(this.EnhancedSchemeDataTempStartDate == null ? "null" : this.EnhancedSchemeDataTempStartDate)}");
            toStringOutput.Add($"this.EnhancedSchemeDataTempWeekEnding = {(this.EnhancedSchemeDataTempWeekEnding == null ? "null" : this.EnhancedSchemeDataTempWeekEnding)}");
            toStringOutput.Add($"this.EnhancedSchemeDataTotalTaxAmount = {(this.EnhancedSchemeDataTotalTaxAmount == null ? "null" : this.EnhancedSchemeDataTotalTaxAmount)}");
        }
    }
}