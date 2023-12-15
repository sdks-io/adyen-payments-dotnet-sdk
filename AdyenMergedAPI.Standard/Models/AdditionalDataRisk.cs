// <copyright file="AdditionalDataRisk.cs" company="APIMatic">
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
    /// AdditionalDataRisk.
    /// </summary>
    public class AdditionalDataRisk
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataRisk"/> class.
        /// </summary>
        public AdditionalDataRisk()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataRisk"/> class.
        /// </summary>
        /// <param name="riskdataCustomFieldName">riskdata.[customFieldName].</param>
        /// <param name="riskdataBasketItemItemNrAmountPerItem">riskdata.basket.item[itemNr].amountPerItem.</param>
        /// <param name="riskdataBasketItemItemNrBrand">riskdata.basket.item[itemNr].brand.</param>
        /// <param name="riskdataBasketItemItemNrCategory">riskdata.basket.item[itemNr].category.</param>
        /// <param name="riskdataBasketItemItemNrColor">riskdata.basket.item[itemNr].color.</param>
        /// <param name="riskdataBasketItemItemNrCurrency">riskdata.basket.item[itemNr].currency.</param>
        /// <param name="riskdataBasketItemItemNrItemID">riskdata.basket.item[itemNr].itemID.</param>
        /// <param name="riskdataBasketItemItemNrManufacturer">riskdata.basket.item[itemNr].manufacturer.</param>
        /// <param name="riskdataBasketItemItemNrProductTitle">riskdata.basket.item[itemNr].productTitle.</param>
        /// <param name="riskdataBasketItemItemNrQuantity">riskdata.basket.item[itemNr].quantity.</param>
        /// <param name="riskdataBasketItemItemNrReceiverEmail">riskdata.basket.item[itemNr].receiverEmail.</param>
        /// <param name="riskdataBasketItemItemNrSize">riskdata.basket.item[itemNr].size.</param>
        /// <param name="riskdataBasketItemItemNrSku">riskdata.basket.item[itemNr].sku.</param>
        /// <param name="riskdataBasketItemItemNrUpc">riskdata.basket.item[itemNr].upc.</param>
        /// <param name="riskdataPromotionsPromotionItemNrPromotionCode">riskdata.promotions.promotion[itemNr].promotionCode.</param>
        /// <param name="riskdataPromotionsPromotionItemNrPromotionDiscountAmount">riskdata.promotions.promotion[itemNr].promotionDiscountAmount.</param>
        /// <param name="riskdataPromotionsPromotionItemNrPromotionDiscountCurrency">riskdata.promotions.promotion[itemNr].promotionDiscountCurrency.</param>
        /// <param name="riskdataPromotionsPromotionItemNrPromotionDiscountPercentage">riskdata.promotions.promotion[itemNr].promotionDiscountPercentage.</param>
        /// <param name="riskdataPromotionsPromotionItemNrPromotionName">riskdata.promotions.promotion[itemNr].promotionName.</param>
        /// <param name="riskdataRiskProfileReference">riskdata.riskProfileReference.</param>
        /// <param name="riskdataSkipRisk">riskdata.skipRisk.</param>
        public AdditionalDataRisk(
            string riskdataCustomFieldName = null,
            string riskdataBasketItemItemNrAmountPerItem = null,
            string riskdataBasketItemItemNrBrand = null,
            string riskdataBasketItemItemNrCategory = null,
            string riskdataBasketItemItemNrColor = null,
            string riskdataBasketItemItemNrCurrency = null,
            string riskdataBasketItemItemNrItemID = null,
            string riskdataBasketItemItemNrManufacturer = null,
            string riskdataBasketItemItemNrProductTitle = null,
            string riskdataBasketItemItemNrQuantity = null,
            string riskdataBasketItemItemNrReceiverEmail = null,
            string riskdataBasketItemItemNrSize = null,
            string riskdataBasketItemItemNrSku = null,
            string riskdataBasketItemItemNrUpc = null,
            string riskdataPromotionsPromotionItemNrPromotionCode = null,
            string riskdataPromotionsPromotionItemNrPromotionDiscountAmount = null,
            string riskdataPromotionsPromotionItemNrPromotionDiscountCurrency = null,
            string riskdataPromotionsPromotionItemNrPromotionDiscountPercentage = null,
            string riskdataPromotionsPromotionItemNrPromotionName = null,
            string riskdataRiskProfileReference = null,
            string riskdataSkipRisk = null)
        {
            this.RiskdataCustomFieldName = riskdataCustomFieldName;
            this.RiskdataBasketItemItemNrAmountPerItem = riskdataBasketItemItemNrAmountPerItem;
            this.RiskdataBasketItemItemNrBrand = riskdataBasketItemItemNrBrand;
            this.RiskdataBasketItemItemNrCategory = riskdataBasketItemItemNrCategory;
            this.RiskdataBasketItemItemNrColor = riskdataBasketItemItemNrColor;
            this.RiskdataBasketItemItemNrCurrency = riskdataBasketItemItemNrCurrency;
            this.RiskdataBasketItemItemNrItemID = riskdataBasketItemItemNrItemID;
            this.RiskdataBasketItemItemNrManufacturer = riskdataBasketItemItemNrManufacturer;
            this.RiskdataBasketItemItemNrProductTitle = riskdataBasketItemItemNrProductTitle;
            this.RiskdataBasketItemItemNrQuantity = riskdataBasketItemItemNrQuantity;
            this.RiskdataBasketItemItemNrReceiverEmail = riskdataBasketItemItemNrReceiverEmail;
            this.RiskdataBasketItemItemNrSize = riskdataBasketItemItemNrSize;
            this.RiskdataBasketItemItemNrSku = riskdataBasketItemItemNrSku;
            this.RiskdataBasketItemItemNrUpc = riskdataBasketItemItemNrUpc;
            this.RiskdataPromotionsPromotionItemNrPromotionCode = riskdataPromotionsPromotionItemNrPromotionCode;
            this.RiskdataPromotionsPromotionItemNrPromotionDiscountAmount = riskdataPromotionsPromotionItemNrPromotionDiscountAmount;
            this.RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency = riskdataPromotionsPromotionItemNrPromotionDiscountCurrency;
            this.RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage = riskdataPromotionsPromotionItemNrPromotionDiscountPercentage;
            this.RiskdataPromotionsPromotionItemNrPromotionName = riskdataPromotionsPromotionItemNrPromotionName;
            this.RiskdataRiskProfileReference = riskdataRiskProfileReference;
            this.RiskdataSkipRisk = riskdataSkipRisk;
        }

        /// <summary>
        /// The data for your custom risk field. For more information, refer to [Create custom risk fields](https://docs.adyen.com/risk-management/configure-custom-risk-rules#step-1-create-custom-risk-fields).
        /// </summary>
        [JsonProperty("riskdata.[customFieldName]", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataCustomFieldName { get; set; }

        /// <summary>
        /// The price of item in the basket, represented in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// </summary>
        [JsonProperty("riskdata.basket.item[itemNr].amountPerItem", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataBasketItemItemNrAmountPerItem { get; set; }

        /// <summary>
        /// Brand of the item.
        /// </summary>
        [JsonProperty("riskdata.basket.item[itemNr].brand", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataBasketItemItemNrBrand { get; set; }

        /// <summary>
        /// Category of the item.
        /// </summary>
        [JsonProperty("riskdata.basket.item[itemNr].category", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataBasketItemItemNrCategory { get; set; }

        /// <summary>
        /// Color of the item.
        /// </summary>
        [JsonProperty("riskdata.basket.item[itemNr].color", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataBasketItemItemNrColor { get; set; }

        /// <summary>
        /// The three-character [ISO currency code](https://en.wikipedia.org/wiki/ISO_4217).
        /// </summary>
        [JsonProperty("riskdata.basket.item[itemNr].currency", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataBasketItemItemNrCurrency { get; set; }

        /// <summary>
        /// ID of the item.
        /// </summary>
        [JsonProperty("riskdata.basket.item[itemNr].itemID", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataBasketItemItemNrItemID { get; set; }

        /// <summary>
        /// Manufacturer of the item.
        /// </summary>
        [JsonProperty("riskdata.basket.item[itemNr].manufacturer", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataBasketItemItemNrManufacturer { get; set; }

        /// <summary>
        /// A text description of the product the invoice line refers to.
        /// </summary>
        [JsonProperty("riskdata.basket.item[itemNr].productTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataBasketItemItemNrProductTitle { get; set; }

        /// <summary>
        /// Quantity of the item purchased.
        /// </summary>
        [JsonProperty("riskdata.basket.item[itemNr].quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataBasketItemItemNrQuantity { get; set; }

        /// <summary>
        /// Email associated with the given product in the basket (usually in electronic gift cards).
        /// </summary>
        [JsonProperty("riskdata.basket.item[itemNr].receiverEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataBasketItemItemNrReceiverEmail { get; set; }

        /// <summary>
        /// Size of the item.
        /// </summary>
        [JsonProperty("riskdata.basket.item[itemNr].size", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataBasketItemItemNrSize { get; set; }

        /// <summary>
        /// [Stock keeping unit](https://en.wikipedia.org/wiki/Stock_keeping_unit).
        /// </summary>
        [JsonProperty("riskdata.basket.item[itemNr].sku", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataBasketItemItemNrSku { get; set; }

        /// <summary>
        /// [Universal Product Code](https://en.wikipedia.org/wiki/Universal_Product_Code).
        /// </summary>
        [JsonProperty("riskdata.basket.item[itemNr].upc", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataBasketItemItemNrUpc { get; set; }

        /// <summary>
        /// Code of the promotion.
        /// </summary>
        [JsonProperty("riskdata.promotions.promotion[itemNr].promotionCode", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataPromotionsPromotionItemNrPromotionCode { get; set; }

        /// <summary>
        /// The discount amount of the promotion, represented in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// </summary>
        [JsonProperty("riskdata.promotions.promotion[itemNr].promotionDiscountAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataPromotionsPromotionItemNrPromotionDiscountAmount { get; set; }

        /// <summary>
        /// The three-character [ISO currency code](https://en.wikipedia.org/wiki/ISO_4217).
        /// </summary>
        [JsonProperty("riskdata.promotions.promotion[itemNr].promotionDiscountCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency { get; set; }

        /// <summary>
        /// Promotion's percentage discount. It is represented in percentage value and there is no need to include the '%' sign.
        /// e.g. for a promotion discount of 30%, the value of the field should be 30.
        /// </summary>
        [JsonProperty("riskdata.promotions.promotion[itemNr].promotionDiscountPercentage", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage { get; set; }

        /// <summary>
        /// Name of the promotion.
        /// </summary>
        [JsonProperty("riskdata.promotions.promotion[itemNr].promotionName", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataPromotionsPromotionItemNrPromotionName { get; set; }

        /// <summary>
        /// Reference number of the risk profile that you want to apply to the payment. If not provided or left blank, the merchant-level account's default risk profile will be applied to the payment. For more information, see [dynamically assign a risk profile to a payment](https://docs.adyen.com/risk-management/create-and-use-risk-profiles#dynamically-assign-a-risk-profile-to-a-payment).
        /// </summary>
        [JsonProperty("riskdata.riskProfileReference", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataRiskProfileReference { get; set; }

        /// <summary>
        /// If this parameter is provided with the value **true**, risk checks for the payment request are skipped and the transaction will not get a risk score.
        /// </summary>
        [JsonProperty("riskdata.skipRisk", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskdataSkipRisk { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalDataRisk : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdditionalDataRisk other &&                ((this.RiskdataCustomFieldName == null && other.RiskdataCustomFieldName == null) || (this.RiskdataCustomFieldName?.Equals(other.RiskdataCustomFieldName) == true)) &&
                ((this.RiskdataBasketItemItemNrAmountPerItem == null && other.RiskdataBasketItemItemNrAmountPerItem == null) || (this.RiskdataBasketItemItemNrAmountPerItem?.Equals(other.RiskdataBasketItemItemNrAmountPerItem) == true)) &&
                ((this.RiskdataBasketItemItemNrBrand == null && other.RiskdataBasketItemItemNrBrand == null) || (this.RiskdataBasketItemItemNrBrand?.Equals(other.RiskdataBasketItemItemNrBrand) == true)) &&
                ((this.RiskdataBasketItemItemNrCategory == null && other.RiskdataBasketItemItemNrCategory == null) || (this.RiskdataBasketItemItemNrCategory?.Equals(other.RiskdataBasketItemItemNrCategory) == true)) &&
                ((this.RiskdataBasketItemItemNrColor == null && other.RiskdataBasketItemItemNrColor == null) || (this.RiskdataBasketItemItemNrColor?.Equals(other.RiskdataBasketItemItemNrColor) == true)) &&
                ((this.RiskdataBasketItemItemNrCurrency == null && other.RiskdataBasketItemItemNrCurrency == null) || (this.RiskdataBasketItemItemNrCurrency?.Equals(other.RiskdataBasketItemItemNrCurrency) == true)) &&
                ((this.RiskdataBasketItemItemNrItemID == null && other.RiskdataBasketItemItemNrItemID == null) || (this.RiskdataBasketItemItemNrItemID?.Equals(other.RiskdataBasketItemItemNrItemID) == true)) &&
                ((this.RiskdataBasketItemItemNrManufacturer == null && other.RiskdataBasketItemItemNrManufacturer == null) || (this.RiskdataBasketItemItemNrManufacturer?.Equals(other.RiskdataBasketItemItemNrManufacturer) == true)) &&
                ((this.RiskdataBasketItemItemNrProductTitle == null && other.RiskdataBasketItemItemNrProductTitle == null) || (this.RiskdataBasketItemItemNrProductTitle?.Equals(other.RiskdataBasketItemItemNrProductTitle) == true)) &&
                ((this.RiskdataBasketItemItemNrQuantity == null && other.RiskdataBasketItemItemNrQuantity == null) || (this.RiskdataBasketItemItemNrQuantity?.Equals(other.RiskdataBasketItemItemNrQuantity) == true)) &&
                ((this.RiskdataBasketItemItemNrReceiverEmail == null && other.RiskdataBasketItemItemNrReceiverEmail == null) || (this.RiskdataBasketItemItemNrReceiverEmail?.Equals(other.RiskdataBasketItemItemNrReceiverEmail) == true)) &&
                ((this.RiskdataBasketItemItemNrSize == null && other.RiskdataBasketItemItemNrSize == null) || (this.RiskdataBasketItemItemNrSize?.Equals(other.RiskdataBasketItemItemNrSize) == true)) &&
                ((this.RiskdataBasketItemItemNrSku == null && other.RiskdataBasketItemItemNrSku == null) || (this.RiskdataBasketItemItemNrSku?.Equals(other.RiskdataBasketItemItemNrSku) == true)) &&
                ((this.RiskdataBasketItemItemNrUpc == null && other.RiskdataBasketItemItemNrUpc == null) || (this.RiskdataBasketItemItemNrUpc?.Equals(other.RiskdataBasketItemItemNrUpc) == true)) &&
                ((this.RiskdataPromotionsPromotionItemNrPromotionCode == null && other.RiskdataPromotionsPromotionItemNrPromotionCode == null) || (this.RiskdataPromotionsPromotionItemNrPromotionCode?.Equals(other.RiskdataPromotionsPromotionItemNrPromotionCode) == true)) &&
                ((this.RiskdataPromotionsPromotionItemNrPromotionDiscountAmount == null && other.RiskdataPromotionsPromotionItemNrPromotionDiscountAmount == null) || (this.RiskdataPromotionsPromotionItemNrPromotionDiscountAmount?.Equals(other.RiskdataPromotionsPromotionItemNrPromotionDiscountAmount) == true)) &&
                ((this.RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency == null && other.RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency == null) || (this.RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency?.Equals(other.RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency) == true)) &&
                ((this.RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage == null && other.RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage == null) || (this.RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage?.Equals(other.RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage) == true)) &&
                ((this.RiskdataPromotionsPromotionItemNrPromotionName == null && other.RiskdataPromotionsPromotionItemNrPromotionName == null) || (this.RiskdataPromotionsPromotionItemNrPromotionName?.Equals(other.RiskdataPromotionsPromotionItemNrPromotionName) == true)) &&
                ((this.RiskdataRiskProfileReference == null && other.RiskdataRiskProfileReference == null) || (this.RiskdataRiskProfileReference?.Equals(other.RiskdataRiskProfileReference) == true)) &&
                ((this.RiskdataSkipRisk == null && other.RiskdataSkipRisk == null) || (this.RiskdataSkipRisk?.Equals(other.RiskdataSkipRisk) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RiskdataCustomFieldName = {(this.RiskdataCustomFieldName == null ? "null" : this.RiskdataCustomFieldName)}");
            toStringOutput.Add($"this.RiskdataBasketItemItemNrAmountPerItem = {(this.RiskdataBasketItemItemNrAmountPerItem == null ? "null" : this.RiskdataBasketItemItemNrAmountPerItem)}");
            toStringOutput.Add($"this.RiskdataBasketItemItemNrBrand = {(this.RiskdataBasketItemItemNrBrand == null ? "null" : this.RiskdataBasketItemItemNrBrand)}");
            toStringOutput.Add($"this.RiskdataBasketItemItemNrCategory = {(this.RiskdataBasketItemItemNrCategory == null ? "null" : this.RiskdataBasketItemItemNrCategory)}");
            toStringOutput.Add($"this.RiskdataBasketItemItemNrColor = {(this.RiskdataBasketItemItemNrColor == null ? "null" : this.RiskdataBasketItemItemNrColor)}");
            toStringOutput.Add($"this.RiskdataBasketItemItemNrCurrency = {(this.RiskdataBasketItemItemNrCurrency == null ? "null" : this.RiskdataBasketItemItemNrCurrency)}");
            toStringOutput.Add($"this.RiskdataBasketItemItemNrItemID = {(this.RiskdataBasketItemItemNrItemID == null ? "null" : this.RiskdataBasketItemItemNrItemID)}");
            toStringOutput.Add($"this.RiskdataBasketItemItemNrManufacturer = {(this.RiskdataBasketItemItemNrManufacturer == null ? "null" : this.RiskdataBasketItemItemNrManufacturer)}");
            toStringOutput.Add($"this.RiskdataBasketItemItemNrProductTitle = {(this.RiskdataBasketItemItemNrProductTitle == null ? "null" : this.RiskdataBasketItemItemNrProductTitle)}");
            toStringOutput.Add($"this.RiskdataBasketItemItemNrQuantity = {(this.RiskdataBasketItemItemNrQuantity == null ? "null" : this.RiskdataBasketItemItemNrQuantity)}");
            toStringOutput.Add($"this.RiskdataBasketItemItemNrReceiverEmail = {(this.RiskdataBasketItemItemNrReceiverEmail == null ? "null" : this.RiskdataBasketItemItemNrReceiverEmail)}");
            toStringOutput.Add($"this.RiskdataBasketItemItemNrSize = {(this.RiskdataBasketItemItemNrSize == null ? "null" : this.RiskdataBasketItemItemNrSize)}");
            toStringOutput.Add($"this.RiskdataBasketItemItemNrSku = {(this.RiskdataBasketItemItemNrSku == null ? "null" : this.RiskdataBasketItemItemNrSku)}");
            toStringOutput.Add($"this.RiskdataBasketItemItemNrUpc = {(this.RiskdataBasketItemItemNrUpc == null ? "null" : this.RiskdataBasketItemItemNrUpc)}");
            toStringOutput.Add($"this.RiskdataPromotionsPromotionItemNrPromotionCode = {(this.RiskdataPromotionsPromotionItemNrPromotionCode == null ? "null" : this.RiskdataPromotionsPromotionItemNrPromotionCode)}");
            toStringOutput.Add($"this.RiskdataPromotionsPromotionItemNrPromotionDiscountAmount = {(this.RiskdataPromotionsPromotionItemNrPromotionDiscountAmount == null ? "null" : this.RiskdataPromotionsPromotionItemNrPromotionDiscountAmount)}");
            toStringOutput.Add($"this.RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency = {(this.RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency == null ? "null" : this.RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency)}");
            toStringOutput.Add($"this.RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage = {(this.RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage == null ? "null" : this.RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage)}");
            toStringOutput.Add($"this.RiskdataPromotionsPromotionItemNrPromotionName = {(this.RiskdataPromotionsPromotionItemNrPromotionName == null ? "null" : this.RiskdataPromotionsPromotionItemNrPromotionName)}");
            toStringOutput.Add($"this.RiskdataRiskProfileReference = {(this.RiskdataRiskProfileReference == null ? "null" : this.RiskdataRiskProfileReference)}");
            toStringOutput.Add($"this.RiskdataSkipRisk = {(this.RiskdataSkipRisk == null ? "null" : this.RiskdataSkipRisk)}");
        }
    }
}