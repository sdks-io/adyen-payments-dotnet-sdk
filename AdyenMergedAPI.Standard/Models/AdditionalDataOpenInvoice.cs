// <copyright file="AdditionalDataOpenInvoice.cs" company="APIMatic">
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
    /// AdditionalDataOpenInvoice.
    /// </summary>
    public class AdditionalDataOpenInvoice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataOpenInvoice"/> class.
        /// </summary>
        public AdditionalDataOpenInvoice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataOpenInvoice"/> class.
        /// </summary>
        /// <param name="openinvoicedataMerchantData">openinvoicedata.merchantData.</param>
        /// <param name="openinvoicedataNumberOfLines">openinvoicedata.numberOfLines.</param>
        /// <param name="openinvoicedataRecipientFirstName">openinvoicedata.recipientFirstName.</param>
        /// <param name="openinvoicedataRecipientLastName">openinvoicedata.recipientLastName.</param>
        /// <param name="openinvoicedataLineItemNrCurrencyCode">openinvoicedataLine[itemNr].currencyCode.</param>
        /// <param name="openinvoicedataLineItemNrDescription">openinvoicedataLine[itemNr].description.</param>
        /// <param name="openinvoicedataLineItemNrItemAmount">openinvoicedataLine[itemNr].itemAmount.</param>
        /// <param name="openinvoicedataLineItemNrItemId">openinvoicedataLine[itemNr].itemId.</param>
        /// <param name="openinvoicedataLineItemNrItemVatAmount">openinvoicedataLine[itemNr].itemVatAmount.</param>
        /// <param name="openinvoicedataLineItemNrItemVatPercentage">openinvoicedataLine[itemNr].itemVatPercentage.</param>
        /// <param name="openinvoicedataLineItemNrNumberOfItems">openinvoicedataLine[itemNr].numberOfItems.</param>
        /// <param name="openinvoicedataLineItemNrReturnShippingCompany">openinvoicedataLine[itemNr].returnShippingCompany.</param>
        /// <param name="openinvoicedataLineItemNrReturnTrackingNumber">openinvoicedataLine[itemNr].returnTrackingNumber.</param>
        /// <param name="openinvoicedataLineItemNrReturnTrackingUri">openinvoicedataLine[itemNr].returnTrackingUri.</param>
        /// <param name="openinvoicedataLineItemNrShippingCompany">openinvoicedataLine[itemNr].shippingCompany.</param>
        /// <param name="openinvoicedataLineItemNrShippingMethod">openinvoicedataLine[itemNr].shippingMethod.</param>
        /// <param name="openinvoicedataLineItemNrTrackingNumber">openinvoicedataLine[itemNr].trackingNumber.</param>
        /// <param name="openinvoicedataLineItemNrTrackingUri">openinvoicedataLine[itemNr].trackingUri.</param>
        public AdditionalDataOpenInvoice(
            string openinvoicedataMerchantData = null,
            string openinvoicedataNumberOfLines = null,
            string openinvoicedataRecipientFirstName = null,
            string openinvoicedataRecipientLastName = null,
            string openinvoicedataLineItemNrCurrencyCode = null,
            string openinvoicedataLineItemNrDescription = null,
            string openinvoicedataLineItemNrItemAmount = null,
            string openinvoicedataLineItemNrItemId = null,
            string openinvoicedataLineItemNrItemVatAmount = null,
            string openinvoicedataLineItemNrItemVatPercentage = null,
            string openinvoicedataLineItemNrNumberOfItems = null,
            string openinvoicedataLineItemNrReturnShippingCompany = null,
            string openinvoicedataLineItemNrReturnTrackingNumber = null,
            string openinvoicedataLineItemNrReturnTrackingUri = null,
            string openinvoicedataLineItemNrShippingCompany = null,
            string openinvoicedataLineItemNrShippingMethod = null,
            string openinvoicedataLineItemNrTrackingNumber = null,
            string openinvoicedataLineItemNrTrackingUri = null)
        {
            this.OpeninvoicedataMerchantData = openinvoicedataMerchantData;
            this.OpeninvoicedataNumberOfLines = openinvoicedataNumberOfLines;
            this.OpeninvoicedataRecipientFirstName = openinvoicedataRecipientFirstName;
            this.OpeninvoicedataRecipientLastName = openinvoicedataRecipientLastName;
            this.OpeninvoicedataLineItemNrCurrencyCode = openinvoicedataLineItemNrCurrencyCode;
            this.OpeninvoicedataLineItemNrDescription = openinvoicedataLineItemNrDescription;
            this.OpeninvoicedataLineItemNrItemAmount = openinvoicedataLineItemNrItemAmount;
            this.OpeninvoicedataLineItemNrItemId = openinvoicedataLineItemNrItemId;
            this.OpeninvoicedataLineItemNrItemVatAmount = openinvoicedataLineItemNrItemVatAmount;
            this.OpeninvoicedataLineItemNrItemVatPercentage = openinvoicedataLineItemNrItemVatPercentage;
            this.OpeninvoicedataLineItemNrNumberOfItems = openinvoicedataLineItemNrNumberOfItems;
            this.OpeninvoicedataLineItemNrReturnShippingCompany = openinvoicedataLineItemNrReturnShippingCompany;
            this.OpeninvoicedataLineItemNrReturnTrackingNumber = openinvoicedataLineItemNrReturnTrackingNumber;
            this.OpeninvoicedataLineItemNrReturnTrackingUri = openinvoicedataLineItemNrReturnTrackingUri;
            this.OpeninvoicedataLineItemNrShippingCompany = openinvoicedataLineItemNrShippingCompany;
            this.OpeninvoicedataLineItemNrShippingMethod = openinvoicedataLineItemNrShippingMethod;
            this.OpeninvoicedataLineItemNrTrackingNumber = openinvoicedataLineItemNrTrackingNumber;
            this.OpeninvoicedataLineItemNrTrackingUri = openinvoicedataLineItemNrTrackingUri;
        }

        /// <summary>
        /// Holds different merchant data points like product, purchase, customer, and so on. It takes data in a Base64 encoded string.
        /// The `merchantData` parameter needs to be added to the `openinvoicedata` signature at the end.
        /// Since the field is optional, if it's not included it does not impact computing the merchant signature.
        /// Applies only to Klarna.
        /// You can contact Klarna for the format and structure of the string.
        /// </summary>
        [JsonProperty("openinvoicedata.merchantData", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataMerchantData { get; set; }

        /// <summary>
        /// The number of invoice lines included in `openinvoicedata`.
        /// There needs to be at least one line, so `numberOfLines` needs to be at least 1.
        /// </summary>
        [JsonProperty("openinvoicedata.numberOfLines", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataNumberOfLines { get; set; }

        /// <summary>
        /// First name of the recipient. If the delivery address and the billing address are different, specify the `recipientFirstName` and `recipientLastName` to share the delivery address with Klarna. Otherwise, only the billing address is shared with Klarna.
        /// </summary>
        [JsonProperty("openinvoicedata.recipientFirstName", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataRecipientFirstName { get; set; }

        /// <summary>
        /// Last name of the recipient. If the delivery address and the billing address are different, specify the `recipientFirstName` and `recipientLastName` to share the delivery address with Klarna. Otherwise, only the billing address is shared with Klarna.
        /// </summary>
        [JsonProperty("openinvoicedata.recipientLastName", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataRecipientLastName { get; set; }

        /// <summary>
        /// The three-character ISO currency code.
        /// </summary>
        [JsonProperty("openinvoicedataLine[itemNr].currencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataLineItemNrCurrencyCode { get; set; }

        /// <summary>
        /// A text description of the product the invoice line refers to.
        /// </summary>
        [JsonProperty("openinvoicedataLine[itemNr].description", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataLineItemNrDescription { get; set; }

        /// <summary>
        /// The price for one item in the invoice line, represented in minor units.
        /// The due amount for the item, VAT excluded.
        /// </summary>
        [JsonProperty("openinvoicedataLine[itemNr].itemAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataLineItemNrItemAmount { get; set; }

        /// <summary>
        /// A unique id for this item. Required for RatePay if the description of each item is not unique.
        /// </summary>
        [JsonProperty("openinvoicedataLine[itemNr].itemId", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataLineItemNrItemId { get; set; }

        /// <summary>
        /// The VAT due for one item in the invoice line, represented in minor units.
        /// </summary>
        [JsonProperty("openinvoicedataLine[itemNr].itemVatAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataLineItemNrItemVatAmount { get; set; }

        /// <summary>
        /// The VAT percentage for one item in the invoice line, represented in minor units.
        /// For example, 19% VAT is specified as 1900.
        /// </summary>
        [JsonProperty("openinvoicedataLine[itemNr].itemVatPercentage", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataLineItemNrItemVatPercentage { get; set; }

        /// <summary>
        /// The number of units purchased of a specific product.
        /// </summary>
        [JsonProperty("openinvoicedataLine[itemNr].numberOfItems", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataLineItemNrNumberOfItems { get; set; }

        /// <summary>
        /// Name of the shipping company handling the the return shipment.
        /// </summary>
        [JsonProperty("openinvoicedataLine[itemNr].returnShippingCompany", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataLineItemNrReturnShippingCompany { get; set; }

        /// <summary>
        /// The tracking number for the return of the shipment.
        /// </summary>
        [JsonProperty("openinvoicedataLine[itemNr].returnTrackingNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataLineItemNrReturnTrackingNumber { get; set; }

        /// <summary>
        /// URI where the customer can track the return of their shipment.
        /// </summary>
        [JsonProperty("openinvoicedataLine[itemNr].returnTrackingUri", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataLineItemNrReturnTrackingUri { get; set; }

        /// <summary>
        /// Name of the shipping company handling the delivery.
        /// </summary>
        [JsonProperty("openinvoicedataLine[itemNr].shippingCompany", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataLineItemNrShippingCompany { get; set; }

        /// <summary>
        /// Shipping method.
        /// </summary>
        [JsonProperty("openinvoicedataLine[itemNr].shippingMethod", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataLineItemNrShippingMethod { get; set; }

        /// <summary>
        /// The tracking number for the shipment.
        /// </summary>
        [JsonProperty("openinvoicedataLine[itemNr].trackingNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataLineItemNrTrackingNumber { get; set; }

        /// <summary>
        /// URI where the customer can track their shipment.
        /// </summary>
        [JsonProperty("openinvoicedataLine[itemNr].trackingUri", NullValueHandling = NullValueHandling.Ignore)]
        public string OpeninvoicedataLineItemNrTrackingUri { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalDataOpenInvoice : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdditionalDataOpenInvoice other &&                ((this.OpeninvoicedataMerchantData == null && other.OpeninvoicedataMerchantData == null) || (this.OpeninvoicedataMerchantData?.Equals(other.OpeninvoicedataMerchantData) == true)) &&
                ((this.OpeninvoicedataNumberOfLines == null && other.OpeninvoicedataNumberOfLines == null) || (this.OpeninvoicedataNumberOfLines?.Equals(other.OpeninvoicedataNumberOfLines) == true)) &&
                ((this.OpeninvoicedataRecipientFirstName == null && other.OpeninvoicedataRecipientFirstName == null) || (this.OpeninvoicedataRecipientFirstName?.Equals(other.OpeninvoicedataRecipientFirstName) == true)) &&
                ((this.OpeninvoicedataRecipientLastName == null && other.OpeninvoicedataRecipientLastName == null) || (this.OpeninvoicedataRecipientLastName?.Equals(other.OpeninvoicedataRecipientLastName) == true)) &&
                ((this.OpeninvoicedataLineItemNrCurrencyCode == null && other.OpeninvoicedataLineItemNrCurrencyCode == null) || (this.OpeninvoicedataLineItemNrCurrencyCode?.Equals(other.OpeninvoicedataLineItemNrCurrencyCode) == true)) &&
                ((this.OpeninvoicedataLineItemNrDescription == null && other.OpeninvoicedataLineItemNrDescription == null) || (this.OpeninvoicedataLineItemNrDescription?.Equals(other.OpeninvoicedataLineItemNrDescription) == true)) &&
                ((this.OpeninvoicedataLineItemNrItemAmount == null && other.OpeninvoicedataLineItemNrItemAmount == null) || (this.OpeninvoicedataLineItemNrItemAmount?.Equals(other.OpeninvoicedataLineItemNrItemAmount) == true)) &&
                ((this.OpeninvoicedataLineItemNrItemId == null && other.OpeninvoicedataLineItemNrItemId == null) || (this.OpeninvoicedataLineItemNrItemId?.Equals(other.OpeninvoicedataLineItemNrItemId) == true)) &&
                ((this.OpeninvoicedataLineItemNrItemVatAmount == null && other.OpeninvoicedataLineItemNrItemVatAmount == null) || (this.OpeninvoicedataLineItemNrItemVatAmount?.Equals(other.OpeninvoicedataLineItemNrItemVatAmount) == true)) &&
                ((this.OpeninvoicedataLineItemNrItemVatPercentage == null && other.OpeninvoicedataLineItemNrItemVatPercentage == null) || (this.OpeninvoicedataLineItemNrItemVatPercentage?.Equals(other.OpeninvoicedataLineItemNrItemVatPercentage) == true)) &&
                ((this.OpeninvoicedataLineItemNrNumberOfItems == null && other.OpeninvoicedataLineItemNrNumberOfItems == null) || (this.OpeninvoicedataLineItemNrNumberOfItems?.Equals(other.OpeninvoicedataLineItemNrNumberOfItems) == true)) &&
                ((this.OpeninvoicedataLineItemNrReturnShippingCompany == null && other.OpeninvoicedataLineItemNrReturnShippingCompany == null) || (this.OpeninvoicedataLineItemNrReturnShippingCompany?.Equals(other.OpeninvoicedataLineItemNrReturnShippingCompany) == true)) &&
                ((this.OpeninvoicedataLineItemNrReturnTrackingNumber == null && other.OpeninvoicedataLineItemNrReturnTrackingNumber == null) || (this.OpeninvoicedataLineItemNrReturnTrackingNumber?.Equals(other.OpeninvoicedataLineItemNrReturnTrackingNumber) == true)) &&
                ((this.OpeninvoicedataLineItemNrReturnTrackingUri == null && other.OpeninvoicedataLineItemNrReturnTrackingUri == null) || (this.OpeninvoicedataLineItemNrReturnTrackingUri?.Equals(other.OpeninvoicedataLineItemNrReturnTrackingUri) == true)) &&
                ((this.OpeninvoicedataLineItemNrShippingCompany == null && other.OpeninvoicedataLineItemNrShippingCompany == null) || (this.OpeninvoicedataLineItemNrShippingCompany?.Equals(other.OpeninvoicedataLineItemNrShippingCompany) == true)) &&
                ((this.OpeninvoicedataLineItemNrShippingMethod == null && other.OpeninvoicedataLineItemNrShippingMethod == null) || (this.OpeninvoicedataLineItemNrShippingMethod?.Equals(other.OpeninvoicedataLineItemNrShippingMethod) == true)) &&
                ((this.OpeninvoicedataLineItemNrTrackingNumber == null && other.OpeninvoicedataLineItemNrTrackingNumber == null) || (this.OpeninvoicedataLineItemNrTrackingNumber?.Equals(other.OpeninvoicedataLineItemNrTrackingNumber) == true)) &&
                ((this.OpeninvoicedataLineItemNrTrackingUri == null && other.OpeninvoicedataLineItemNrTrackingUri == null) || (this.OpeninvoicedataLineItemNrTrackingUri?.Equals(other.OpeninvoicedataLineItemNrTrackingUri) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OpeninvoicedataMerchantData = {(this.OpeninvoicedataMerchantData == null ? "null" : this.OpeninvoicedataMerchantData)}");
            toStringOutput.Add($"this.OpeninvoicedataNumberOfLines = {(this.OpeninvoicedataNumberOfLines == null ? "null" : this.OpeninvoicedataNumberOfLines)}");
            toStringOutput.Add($"this.OpeninvoicedataRecipientFirstName = {(this.OpeninvoicedataRecipientFirstName == null ? "null" : this.OpeninvoicedataRecipientFirstName)}");
            toStringOutput.Add($"this.OpeninvoicedataRecipientLastName = {(this.OpeninvoicedataRecipientLastName == null ? "null" : this.OpeninvoicedataRecipientLastName)}");
            toStringOutput.Add($"this.OpeninvoicedataLineItemNrCurrencyCode = {(this.OpeninvoicedataLineItemNrCurrencyCode == null ? "null" : this.OpeninvoicedataLineItemNrCurrencyCode)}");
            toStringOutput.Add($"this.OpeninvoicedataLineItemNrDescription = {(this.OpeninvoicedataLineItemNrDescription == null ? "null" : this.OpeninvoicedataLineItemNrDescription)}");
            toStringOutput.Add($"this.OpeninvoicedataLineItemNrItemAmount = {(this.OpeninvoicedataLineItemNrItemAmount == null ? "null" : this.OpeninvoicedataLineItemNrItemAmount)}");
            toStringOutput.Add($"this.OpeninvoicedataLineItemNrItemId = {(this.OpeninvoicedataLineItemNrItemId == null ? "null" : this.OpeninvoicedataLineItemNrItemId)}");
            toStringOutput.Add($"this.OpeninvoicedataLineItemNrItemVatAmount = {(this.OpeninvoicedataLineItemNrItemVatAmount == null ? "null" : this.OpeninvoicedataLineItemNrItemVatAmount)}");
            toStringOutput.Add($"this.OpeninvoicedataLineItemNrItemVatPercentage = {(this.OpeninvoicedataLineItemNrItemVatPercentage == null ? "null" : this.OpeninvoicedataLineItemNrItemVatPercentage)}");
            toStringOutput.Add($"this.OpeninvoicedataLineItemNrNumberOfItems = {(this.OpeninvoicedataLineItemNrNumberOfItems == null ? "null" : this.OpeninvoicedataLineItemNrNumberOfItems)}");
            toStringOutput.Add($"this.OpeninvoicedataLineItemNrReturnShippingCompany = {(this.OpeninvoicedataLineItemNrReturnShippingCompany == null ? "null" : this.OpeninvoicedataLineItemNrReturnShippingCompany)}");
            toStringOutput.Add($"this.OpeninvoicedataLineItemNrReturnTrackingNumber = {(this.OpeninvoicedataLineItemNrReturnTrackingNumber == null ? "null" : this.OpeninvoicedataLineItemNrReturnTrackingNumber)}");
            toStringOutput.Add($"this.OpeninvoicedataLineItemNrReturnTrackingUri = {(this.OpeninvoicedataLineItemNrReturnTrackingUri == null ? "null" : this.OpeninvoicedataLineItemNrReturnTrackingUri)}");
            toStringOutput.Add($"this.OpeninvoicedataLineItemNrShippingCompany = {(this.OpeninvoicedataLineItemNrShippingCompany == null ? "null" : this.OpeninvoicedataLineItemNrShippingCompany)}");
            toStringOutput.Add($"this.OpeninvoicedataLineItemNrShippingMethod = {(this.OpeninvoicedataLineItemNrShippingMethod == null ? "null" : this.OpeninvoicedataLineItemNrShippingMethod)}");
            toStringOutput.Add($"this.OpeninvoicedataLineItemNrTrackingNumber = {(this.OpeninvoicedataLineItemNrTrackingNumber == null ? "null" : this.OpeninvoicedataLineItemNrTrackingNumber)}");
            toStringOutput.Add($"this.OpeninvoicedataLineItemNrTrackingUri = {(this.OpeninvoicedataLineItemNrTrackingUri == null ? "null" : this.OpeninvoicedataLineItemNrTrackingUri)}");
        }
    }
}