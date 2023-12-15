// <copyright file="AdditionalDataLevel23.cs" company="APIMatic">
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
    /// AdditionalDataLevel23.
    /// </summary>
    public class AdditionalDataLevel23
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataLevel23"/> class.
        /// </summary>
        public AdditionalDataLevel23()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataLevel23"/> class.
        /// </summary>
        /// <param name="enhancedSchemeDataCustomerReference">enhancedSchemeData.customerReference.</param>
        /// <param name="enhancedSchemeDataDestinationCountryCode">enhancedSchemeData.destinationCountryCode.</param>
        /// <param name="enhancedSchemeDataDestinationPostalCode">enhancedSchemeData.destinationPostalCode.</param>
        /// <param name="enhancedSchemeDataDestinationStateProvinceCode">enhancedSchemeData.destinationStateProvinceCode.</param>
        /// <param name="enhancedSchemeDataDutyAmount">enhancedSchemeData.dutyAmount.</param>
        /// <param name="enhancedSchemeDataFreightAmount">enhancedSchemeData.freightAmount.</param>
        /// <param name="enhancedSchemeDataItemDetailLineItemNrCommodityCode">enhancedSchemeData.itemDetailLine[itemNr].commodityCode.</param>
        /// <param name="enhancedSchemeDataItemDetailLineItemNrDescription">enhancedSchemeData.itemDetailLine[itemNr].description.</param>
        /// <param name="enhancedSchemeDataItemDetailLineItemNrDiscountAmount">enhancedSchemeData.itemDetailLine[itemNr].discountAmount.</param>
        /// <param name="enhancedSchemeDataItemDetailLineItemNrProductCode">enhancedSchemeData.itemDetailLine[itemNr].productCode.</param>
        /// <param name="enhancedSchemeDataItemDetailLineItemNrQuantity">enhancedSchemeData.itemDetailLine[itemNr].quantity.</param>
        /// <param name="enhancedSchemeDataItemDetailLineItemNrTotalAmount">enhancedSchemeData.itemDetailLine[itemNr].totalAmount.</param>
        /// <param name="enhancedSchemeDataItemDetailLineItemNrUnitOfMeasure">enhancedSchemeData.itemDetailLine[itemNr].unitOfMeasure.</param>
        /// <param name="enhancedSchemeDataItemDetailLineItemNrUnitPrice">enhancedSchemeData.itemDetailLine[itemNr].unitPrice.</param>
        /// <param name="enhancedSchemeDataOrderDate">enhancedSchemeData.orderDate.</param>
        /// <param name="enhancedSchemeDataShipFromPostalCode">enhancedSchemeData.shipFromPostalCode.</param>
        /// <param name="enhancedSchemeDataTotalTaxAmount">enhancedSchemeData.totalTaxAmount.</param>
        public AdditionalDataLevel23(
            string enhancedSchemeDataCustomerReference = null,
            string enhancedSchemeDataDestinationCountryCode = null,
            string enhancedSchemeDataDestinationPostalCode = null,
            string enhancedSchemeDataDestinationStateProvinceCode = null,
            string enhancedSchemeDataDutyAmount = null,
            string enhancedSchemeDataFreightAmount = null,
            string enhancedSchemeDataItemDetailLineItemNrCommodityCode = null,
            string enhancedSchemeDataItemDetailLineItemNrDescription = null,
            string enhancedSchemeDataItemDetailLineItemNrDiscountAmount = null,
            string enhancedSchemeDataItemDetailLineItemNrProductCode = null,
            string enhancedSchemeDataItemDetailLineItemNrQuantity = null,
            string enhancedSchemeDataItemDetailLineItemNrTotalAmount = null,
            string enhancedSchemeDataItemDetailLineItemNrUnitOfMeasure = null,
            string enhancedSchemeDataItemDetailLineItemNrUnitPrice = null,
            string enhancedSchemeDataOrderDate = null,
            string enhancedSchemeDataShipFromPostalCode = null,
            string enhancedSchemeDataTotalTaxAmount = null)
        {
            this.EnhancedSchemeDataCustomerReference = enhancedSchemeDataCustomerReference;
            this.EnhancedSchemeDataDestinationCountryCode = enhancedSchemeDataDestinationCountryCode;
            this.EnhancedSchemeDataDestinationPostalCode = enhancedSchemeDataDestinationPostalCode;
            this.EnhancedSchemeDataDestinationStateProvinceCode = enhancedSchemeDataDestinationStateProvinceCode;
            this.EnhancedSchemeDataDutyAmount = enhancedSchemeDataDutyAmount;
            this.EnhancedSchemeDataFreightAmount = enhancedSchemeDataFreightAmount;
            this.EnhancedSchemeDataItemDetailLineItemNrCommodityCode = enhancedSchemeDataItemDetailLineItemNrCommodityCode;
            this.EnhancedSchemeDataItemDetailLineItemNrDescription = enhancedSchemeDataItemDetailLineItemNrDescription;
            this.EnhancedSchemeDataItemDetailLineItemNrDiscountAmount = enhancedSchemeDataItemDetailLineItemNrDiscountAmount;
            this.EnhancedSchemeDataItemDetailLineItemNrProductCode = enhancedSchemeDataItemDetailLineItemNrProductCode;
            this.EnhancedSchemeDataItemDetailLineItemNrQuantity = enhancedSchemeDataItemDetailLineItemNrQuantity;
            this.EnhancedSchemeDataItemDetailLineItemNrTotalAmount = enhancedSchemeDataItemDetailLineItemNrTotalAmount;
            this.EnhancedSchemeDataItemDetailLineItemNrUnitOfMeasure = enhancedSchemeDataItemDetailLineItemNrUnitOfMeasure;
            this.EnhancedSchemeDataItemDetailLineItemNrUnitPrice = enhancedSchemeDataItemDetailLineItemNrUnitPrice;
            this.EnhancedSchemeDataOrderDate = enhancedSchemeDataOrderDate;
            this.EnhancedSchemeDataShipFromPostalCode = enhancedSchemeDataShipFromPostalCode;
            this.EnhancedSchemeDataTotalTaxAmount = enhancedSchemeDataTotalTaxAmount;
        }

        /// <summary>
        /// The customer code.
        /// * Encoding: ASCII
        /// * Max length: 25 characters
        /// * Must not start with a space or be all spaces
        /// * Must not be all zeros.
        /// </summary>
        [JsonProperty("enhancedSchemeData.customerReference", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataCustomerReference { get; set; }

        /// <summary>
        /// The three-letter [ISO 3166-1 alpha-3 country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) for the destination address.
        /// * Encoding: ASCII
        /// * Fixed length: 3 characters
        /// </summary>
        [JsonProperty("enhancedSchemeData.destinationCountryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataDestinationCountryCode { get; set; }

        /// <summary>
        /// The postal code of the destination address.
        /// * Encoding: ASCII
        /// * Max length: 10 characters
        /// * Must not start with a space
        /// </summary>
        [JsonProperty("enhancedSchemeData.destinationPostalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataDestinationPostalCode { get; set; }

        /// <summary>
        /// Destination state or province code.
        /// * Encoding: ASCII
        /// * Max length: 3 characters
        /// * Must not start with a space
        /// </summary>
        [JsonProperty("enhancedSchemeData.destinationStateProvinceCode", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataDestinationStateProvinceCode { get; set; }

        /// <summary>
        /// The duty amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * For example, 2000 means USD 20.00.
        /// * Encoding: Numeric
        /// * Max length: 12 characters
        /// </summary>
        [JsonProperty("enhancedSchemeData.dutyAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataDutyAmount { get; set; }

        /// <summary>
        /// The shipping amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * For example, 2000 means USD 20.00.
        /// * Encoding: Numeric
        /// *Max length: 12 characters
        /// </summary>
        [JsonProperty("enhancedSchemeData.freightAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataFreightAmount { get; set; }

        /// <summary>
        /// The [UNSPC commodity code](https://www.unspsc.org/) of the item.
        /// * Encoding: ASCII
        /// * Max length: 12 characters
        /// * Must not start with a space or be all spaces
        /// * Must not be all zeros.
        /// </summary>
        [JsonProperty("enhancedSchemeData.itemDetailLine[itemNr].commodityCode", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataItemDetailLineItemNrCommodityCode { get; set; }

        /// <summary>
        /// A description of the item.
        /// * Encoding: ASCII
        /// * Max length: 26 characters
        /// * Must not start with a space or be all spaces
        /// * Must not be all zeros.
        /// </summary>
        [JsonProperty("enhancedSchemeData.itemDetailLine[itemNr].description", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataItemDetailLineItemNrDescription { get; set; }

        /// <summary>
        /// The discount amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * For example, 2000 means USD 20.00.
        /// * Encoding: Numeric
        /// * Max length: 12 characters
        /// </summary>
        [JsonProperty("enhancedSchemeData.itemDetailLine[itemNr].discountAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataItemDetailLineItemNrDiscountAmount { get; set; }

        /// <summary>
        /// The product code.
        /// * Encoding: ASCII.
        /// * Max length: 12 characters
        /// * Must not start with a space or be all spaces
        /// * Must not be all zeros.
        /// </summary>
        [JsonProperty("enhancedSchemeData.itemDetailLine[itemNr].productCode", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataItemDetailLineItemNrProductCode { get; set; }

        /// <summary>
        /// The number of items. Must be an integer greater than zero.
        /// * Encoding: Numeric
        /// * Max length: 12 characters
        /// * Must not start with a space or be all spaces
        /// </summary>
        [JsonProperty("enhancedSchemeData.itemDetailLine[itemNr].quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataItemDetailLineItemNrQuantity { get; set; }

        /// <summary>
        /// The total amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * For example, 2000 means USD 20.00.
        /// * Max length: 12 characters
        /// * Must not start with a space or be all spaces
        /// * Must not be all zeros.
        /// </summary>
        [JsonProperty("enhancedSchemeData.itemDetailLine[itemNr].totalAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataItemDetailLineItemNrTotalAmount { get; set; }

        /// <summary>
        /// The unit of measurement for an item.
        /// * Encoding: ASCII
        /// Max length: 3 characters
        /// * Must not start with a space or be all spaces
        /// * Must not be all zeros.
        /// </summary>
        [JsonProperty("enhancedSchemeData.itemDetailLine[itemNr].unitOfMeasure", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataItemDetailLineItemNrUnitOfMeasure { get; set; }

        /// <summary>
        /// The unit price in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * For example, 2000 means USD 20.00.
        /// * Encoding: Numeric
        /// * Max length: 12 characters
        /// * Must not be all zeros.
        /// </summary>
        [JsonProperty("enhancedSchemeData.itemDetailLine[itemNr].unitPrice", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataItemDetailLineItemNrUnitPrice { get; set; }

        /// <summary>
        /// The order date.
        /// * Format: `ddMMyy`
        /// * Encoding: ASCII
        /// * Max length: 6 characters
        /// </summary>
        [JsonProperty("enhancedSchemeData.orderDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataOrderDate { get; set; }

        /// <summary>
        /// The postal code of the address the item is shipped from.
        /// * Encoding: ASCII
        /// * Max length: 10 characters
        /// * Must not start with a space or be all spaces
        /// * Must not be all zeros.
        /// </summary>
        [JsonProperty("enhancedSchemeData.shipFromPostalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataShipFromPostalCode { get; set; }

        /// <summary>
        /// The total tax amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * For example, 2000 means USD 20.00.
        /// *Encoding: Numeric
        /// *Max length: 12 characters
        /// * Must not be all zeros.
        /// </summary>
        [JsonProperty("enhancedSchemeData.totalTaxAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string EnhancedSchemeDataTotalTaxAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalDataLevel23 : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdditionalDataLevel23 other &&                ((this.EnhancedSchemeDataCustomerReference == null && other.EnhancedSchemeDataCustomerReference == null) || (this.EnhancedSchemeDataCustomerReference?.Equals(other.EnhancedSchemeDataCustomerReference) == true)) &&
                ((this.EnhancedSchemeDataDestinationCountryCode == null && other.EnhancedSchemeDataDestinationCountryCode == null) || (this.EnhancedSchemeDataDestinationCountryCode?.Equals(other.EnhancedSchemeDataDestinationCountryCode) == true)) &&
                ((this.EnhancedSchemeDataDestinationPostalCode == null && other.EnhancedSchemeDataDestinationPostalCode == null) || (this.EnhancedSchemeDataDestinationPostalCode?.Equals(other.EnhancedSchemeDataDestinationPostalCode) == true)) &&
                ((this.EnhancedSchemeDataDestinationStateProvinceCode == null && other.EnhancedSchemeDataDestinationStateProvinceCode == null) || (this.EnhancedSchemeDataDestinationStateProvinceCode?.Equals(other.EnhancedSchemeDataDestinationStateProvinceCode) == true)) &&
                ((this.EnhancedSchemeDataDutyAmount == null && other.EnhancedSchemeDataDutyAmount == null) || (this.EnhancedSchemeDataDutyAmount?.Equals(other.EnhancedSchemeDataDutyAmount) == true)) &&
                ((this.EnhancedSchemeDataFreightAmount == null && other.EnhancedSchemeDataFreightAmount == null) || (this.EnhancedSchemeDataFreightAmount?.Equals(other.EnhancedSchemeDataFreightAmount) == true)) &&
                ((this.EnhancedSchemeDataItemDetailLineItemNrCommodityCode == null && other.EnhancedSchemeDataItemDetailLineItemNrCommodityCode == null) || (this.EnhancedSchemeDataItemDetailLineItemNrCommodityCode?.Equals(other.EnhancedSchemeDataItemDetailLineItemNrCommodityCode) == true)) &&
                ((this.EnhancedSchemeDataItemDetailLineItemNrDescription == null && other.EnhancedSchemeDataItemDetailLineItemNrDescription == null) || (this.EnhancedSchemeDataItemDetailLineItemNrDescription?.Equals(other.EnhancedSchemeDataItemDetailLineItemNrDescription) == true)) &&
                ((this.EnhancedSchemeDataItemDetailLineItemNrDiscountAmount == null && other.EnhancedSchemeDataItemDetailLineItemNrDiscountAmount == null) || (this.EnhancedSchemeDataItemDetailLineItemNrDiscountAmount?.Equals(other.EnhancedSchemeDataItemDetailLineItemNrDiscountAmount) == true)) &&
                ((this.EnhancedSchemeDataItemDetailLineItemNrProductCode == null && other.EnhancedSchemeDataItemDetailLineItemNrProductCode == null) || (this.EnhancedSchemeDataItemDetailLineItemNrProductCode?.Equals(other.EnhancedSchemeDataItemDetailLineItemNrProductCode) == true)) &&
                ((this.EnhancedSchemeDataItemDetailLineItemNrQuantity == null && other.EnhancedSchemeDataItemDetailLineItemNrQuantity == null) || (this.EnhancedSchemeDataItemDetailLineItemNrQuantity?.Equals(other.EnhancedSchemeDataItemDetailLineItemNrQuantity) == true)) &&
                ((this.EnhancedSchemeDataItemDetailLineItemNrTotalAmount == null && other.EnhancedSchemeDataItemDetailLineItemNrTotalAmount == null) || (this.EnhancedSchemeDataItemDetailLineItemNrTotalAmount?.Equals(other.EnhancedSchemeDataItemDetailLineItemNrTotalAmount) == true)) &&
                ((this.EnhancedSchemeDataItemDetailLineItemNrUnitOfMeasure == null && other.EnhancedSchemeDataItemDetailLineItemNrUnitOfMeasure == null) || (this.EnhancedSchemeDataItemDetailLineItemNrUnitOfMeasure?.Equals(other.EnhancedSchemeDataItemDetailLineItemNrUnitOfMeasure) == true)) &&
                ((this.EnhancedSchemeDataItemDetailLineItemNrUnitPrice == null && other.EnhancedSchemeDataItemDetailLineItemNrUnitPrice == null) || (this.EnhancedSchemeDataItemDetailLineItemNrUnitPrice?.Equals(other.EnhancedSchemeDataItemDetailLineItemNrUnitPrice) == true)) &&
                ((this.EnhancedSchemeDataOrderDate == null && other.EnhancedSchemeDataOrderDate == null) || (this.EnhancedSchemeDataOrderDate?.Equals(other.EnhancedSchemeDataOrderDate) == true)) &&
                ((this.EnhancedSchemeDataShipFromPostalCode == null && other.EnhancedSchemeDataShipFromPostalCode == null) || (this.EnhancedSchemeDataShipFromPostalCode?.Equals(other.EnhancedSchemeDataShipFromPostalCode) == true)) &&
                ((this.EnhancedSchemeDataTotalTaxAmount == null && other.EnhancedSchemeDataTotalTaxAmount == null) || (this.EnhancedSchemeDataTotalTaxAmount?.Equals(other.EnhancedSchemeDataTotalTaxAmount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EnhancedSchemeDataCustomerReference = {(this.EnhancedSchemeDataCustomerReference == null ? "null" : this.EnhancedSchemeDataCustomerReference)}");
            toStringOutput.Add($"this.EnhancedSchemeDataDestinationCountryCode = {(this.EnhancedSchemeDataDestinationCountryCode == null ? "null" : this.EnhancedSchemeDataDestinationCountryCode)}");
            toStringOutput.Add($"this.EnhancedSchemeDataDestinationPostalCode = {(this.EnhancedSchemeDataDestinationPostalCode == null ? "null" : this.EnhancedSchemeDataDestinationPostalCode)}");
            toStringOutput.Add($"this.EnhancedSchemeDataDestinationStateProvinceCode = {(this.EnhancedSchemeDataDestinationStateProvinceCode == null ? "null" : this.EnhancedSchemeDataDestinationStateProvinceCode)}");
            toStringOutput.Add($"this.EnhancedSchemeDataDutyAmount = {(this.EnhancedSchemeDataDutyAmount == null ? "null" : this.EnhancedSchemeDataDutyAmount)}");
            toStringOutput.Add($"this.EnhancedSchemeDataFreightAmount = {(this.EnhancedSchemeDataFreightAmount == null ? "null" : this.EnhancedSchemeDataFreightAmount)}");
            toStringOutput.Add($"this.EnhancedSchemeDataItemDetailLineItemNrCommodityCode = {(this.EnhancedSchemeDataItemDetailLineItemNrCommodityCode == null ? "null" : this.EnhancedSchemeDataItemDetailLineItemNrCommodityCode)}");
            toStringOutput.Add($"this.EnhancedSchemeDataItemDetailLineItemNrDescription = {(this.EnhancedSchemeDataItemDetailLineItemNrDescription == null ? "null" : this.EnhancedSchemeDataItemDetailLineItemNrDescription)}");
            toStringOutput.Add($"this.EnhancedSchemeDataItemDetailLineItemNrDiscountAmount = {(this.EnhancedSchemeDataItemDetailLineItemNrDiscountAmount == null ? "null" : this.EnhancedSchemeDataItemDetailLineItemNrDiscountAmount)}");
            toStringOutput.Add($"this.EnhancedSchemeDataItemDetailLineItemNrProductCode = {(this.EnhancedSchemeDataItemDetailLineItemNrProductCode == null ? "null" : this.EnhancedSchemeDataItemDetailLineItemNrProductCode)}");
            toStringOutput.Add($"this.EnhancedSchemeDataItemDetailLineItemNrQuantity = {(this.EnhancedSchemeDataItemDetailLineItemNrQuantity == null ? "null" : this.EnhancedSchemeDataItemDetailLineItemNrQuantity)}");
            toStringOutput.Add($"this.EnhancedSchemeDataItemDetailLineItemNrTotalAmount = {(this.EnhancedSchemeDataItemDetailLineItemNrTotalAmount == null ? "null" : this.EnhancedSchemeDataItemDetailLineItemNrTotalAmount)}");
            toStringOutput.Add($"this.EnhancedSchemeDataItemDetailLineItemNrUnitOfMeasure = {(this.EnhancedSchemeDataItemDetailLineItemNrUnitOfMeasure == null ? "null" : this.EnhancedSchemeDataItemDetailLineItemNrUnitOfMeasure)}");
            toStringOutput.Add($"this.EnhancedSchemeDataItemDetailLineItemNrUnitPrice = {(this.EnhancedSchemeDataItemDetailLineItemNrUnitPrice == null ? "null" : this.EnhancedSchemeDataItemDetailLineItemNrUnitPrice)}");
            toStringOutput.Add($"this.EnhancedSchemeDataOrderDate = {(this.EnhancedSchemeDataOrderDate == null ? "null" : this.EnhancedSchemeDataOrderDate)}");
            toStringOutput.Add($"this.EnhancedSchemeDataShipFromPostalCode = {(this.EnhancedSchemeDataShipFromPostalCode == null ? "null" : this.EnhancedSchemeDataShipFromPostalCode)}");
            toStringOutput.Add($"this.EnhancedSchemeDataTotalTaxAmount = {(this.EnhancedSchemeDataTotalTaxAmount == null ? "null" : this.EnhancedSchemeDataTotalTaxAmount)}");
        }
    }
}