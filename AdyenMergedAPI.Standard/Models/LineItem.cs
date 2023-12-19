// <copyright file="LineItem.cs" company="APIMatic">
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
    /// LineItem.
    /// </summary>
    public class LineItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItem"/> class.
        /// </summary>
        public LineItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LineItem"/> class.
        /// </summary>
        /// <param name="amountExcludingTax">amountExcludingTax.</param>
        /// <param name="amountIncludingTax">amountIncludingTax.</param>
        /// <param name="brand">brand.</param>
        /// <param name="color">color.</param>
        /// <param name="description">description.</param>
        /// <param name="id">id.</param>
        /// <param name="imageUrl">imageUrl.</param>
        /// <param name="itemCategory">itemCategory.</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="productUrl">productUrl.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="receiverEmail">receiverEmail.</param>
        /// <param name="size">size.</param>
        /// <param name="sku">sku.</param>
        /// <param name="taxAmount">taxAmount.</param>
        /// <param name="taxPercentage">taxPercentage.</param>
        /// <param name="upc">upc.</param>
        public LineItem(
            long? amountExcludingTax = null,
            long? amountIncludingTax = null,
            string brand = null,
            string color = null,
            string description = null,
            string id = null,
            string imageUrl = null,
            string itemCategory = null,
            string manufacturer = null,
            string productUrl = null,
            long? quantity = null,
            string receiverEmail = null,
            string size = null,
            string sku = null,
            long? taxAmount = null,
            long? taxPercentage = null,
            string upc = null)
        {
            this.AmountExcludingTax = amountExcludingTax;
            this.AmountIncludingTax = amountIncludingTax;
            this.Brand = brand;
            this.Color = color;
            this.Description = description;
            this.Id = id;
            this.ImageUrl = imageUrl;
            this.ItemCategory = itemCategory;
            this.Manufacturer = manufacturer;
            this.ProductUrl = productUrl;
            this.Quantity = quantity;
            this.ReceiverEmail = receiverEmail;
            this.Size = size;
            this.Sku = sku;
            this.TaxAmount = taxAmount;
            this.TaxPercentage = taxPercentage;
            this.Upc = upc;
        }

        /// <summary>
        /// Item amount excluding the tax, in minor units.
        /// </summary>
        [JsonProperty("amountExcludingTax", NullValueHandling = NullValueHandling.Ignore)]
        public long? AmountExcludingTax { get; set; }

        /// <summary>
        /// Item amount including the tax, in minor units.
        /// </summary>
        [JsonProperty("amountIncludingTax", NullValueHandling = NullValueHandling.Ignore)]
        public long? AmountIncludingTax { get; set; }

        /// <summary>
        /// Brand of the item.
        /// </summary>
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public string Brand { get; set; }

        /// <summary>
        /// Color of the item.
        /// </summary>
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// Description of the line item.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// ID of the line item.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Link to the picture of the purchased item.
        /// </summary>
        [JsonProperty("imageUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Item category, used by the payment methods PayPal and Ratepay.
        /// </summary>
        [JsonProperty("itemCategory", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemCategory { get; set; }

        /// <summary>
        /// Manufacturer of the item.
        /// </summary>
        [JsonProperty("manufacturer", NullValueHandling = NullValueHandling.Ignore)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Link to the purchased item.
        /// </summary>
        [JsonProperty("productUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductUrl { get; set; }

        /// <summary>
        /// Number of items.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public long? Quantity { get; set; }

        /// <summary>
        /// Email associated with the given product in the basket (usually in electronic gift cards).
        /// </summary>
        [JsonProperty("receiverEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiverEmail { get; set; }

        /// <summary>
        /// Size of the item.
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        /// <summary>
        /// Stock keeping unit.
        /// </summary>
        [JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore)]
        public string Sku { get; set; }

        /// <summary>
        /// Tax amount, in minor units.
        /// </summary>
        [JsonProperty("taxAmount", NullValueHandling = NullValueHandling.Ignore)]
        public long? TaxAmount { get; set; }

        /// <summary>
        /// Tax percentage, in minor units.
        /// </summary>
        [JsonProperty("taxPercentage", NullValueHandling = NullValueHandling.Ignore)]
        public long? TaxPercentage { get; set; }

        /// <summary>
        /// Universal Product Code.
        /// </summary>
        [JsonProperty("upc", NullValueHandling = NullValueHandling.Ignore)]
        public string Upc { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LineItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is LineItem other &&                ((this.AmountExcludingTax == null && other.AmountExcludingTax == null) || (this.AmountExcludingTax?.Equals(other.AmountExcludingTax) == true)) &&
                ((this.AmountIncludingTax == null && other.AmountIncludingTax == null) || (this.AmountIncludingTax?.Equals(other.AmountIncludingTax) == true)) &&
                ((this.Brand == null && other.Brand == null) || (this.Brand?.Equals(other.Brand) == true)) &&
                ((this.Color == null && other.Color == null) || (this.Color?.Equals(other.Color) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.ImageUrl == null && other.ImageUrl == null) || (this.ImageUrl?.Equals(other.ImageUrl) == true)) &&
                ((this.ItemCategory == null && other.ItemCategory == null) || (this.ItemCategory?.Equals(other.ItemCategory) == true)) &&
                ((this.Manufacturer == null && other.Manufacturer == null) || (this.Manufacturer?.Equals(other.Manufacturer) == true)) &&
                ((this.ProductUrl == null && other.ProductUrl == null) || (this.ProductUrl?.Equals(other.ProductUrl) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.ReceiverEmail == null && other.ReceiverEmail == null) || (this.ReceiverEmail?.Equals(other.ReceiverEmail) == true)) &&
                ((this.Size == null && other.Size == null) || (this.Size?.Equals(other.Size) == true)) &&
                ((this.Sku == null && other.Sku == null) || (this.Sku?.Equals(other.Sku) == true)) &&
                ((this.TaxAmount == null && other.TaxAmount == null) || (this.TaxAmount?.Equals(other.TaxAmount) == true)) &&
                ((this.TaxPercentage == null && other.TaxPercentage == null) || (this.TaxPercentage?.Equals(other.TaxPercentage) == true)) &&
                ((this.Upc == null && other.Upc == null) || (this.Upc?.Equals(other.Upc) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AmountExcludingTax = {(this.AmountExcludingTax == null ? "null" : this.AmountExcludingTax.ToString())}");
            toStringOutput.Add($"this.AmountIncludingTax = {(this.AmountIncludingTax == null ? "null" : this.AmountIncludingTax.ToString())}");
            toStringOutput.Add($"this.Brand = {(this.Brand == null ? "null" : this.Brand)}");
            toStringOutput.Add($"this.Color = {(this.Color == null ? "null" : this.Color)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.ImageUrl = {(this.ImageUrl == null ? "null" : this.ImageUrl)}");
            toStringOutput.Add($"this.ItemCategory = {(this.ItemCategory == null ? "null" : this.ItemCategory)}");
            toStringOutput.Add($"this.Manufacturer = {(this.Manufacturer == null ? "null" : this.Manufacturer)}");
            toStringOutput.Add($"this.ProductUrl = {(this.ProductUrl == null ? "null" : this.ProductUrl)}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.ReceiverEmail = {(this.ReceiverEmail == null ? "null" : this.ReceiverEmail)}");
            toStringOutput.Add($"this.Size = {(this.Size == null ? "null" : this.Size)}");
            toStringOutput.Add($"this.Sku = {(this.Sku == null ? "null" : this.Sku)}");
            toStringOutput.Add($"this.TaxAmount = {(this.TaxAmount == null ? "null" : this.TaxAmount.ToString())}");
            toStringOutput.Add($"this.TaxPercentage = {(this.TaxPercentage == null ? "null" : this.TaxPercentage.ToString())}");
            toStringOutput.Add($"this.Upc = {(this.Upc == null ? "null" : this.Upc)}");
        }
    }
}