// <copyright file="AdditionalDataSubMerchant.cs" company="APIMatic">
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
    /// AdditionalDataSubMerchant.
    /// </summary>
    public class AdditionalDataSubMerchant
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataSubMerchant"/> class.
        /// </summary>
        public AdditionalDataSubMerchant()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataSubMerchant"/> class.
        /// </summary>
        /// <param name="subMerchantNumberOfSubSellers">subMerchant.numberOfSubSellers.</param>
        /// <param name="subMerchantSubSellerSubSellerNrCity">subMerchant.subSeller[subSellerNr].city.</param>
        /// <param name="subMerchantSubSellerSubSellerNrCountry">subMerchant.subSeller[subSellerNr].country.</param>
        /// <param name="subMerchantSubSellerSubSellerNrId">subMerchant.subSeller[subSellerNr].id.</param>
        /// <param name="subMerchantSubSellerSubSellerNrMcc">subMerchant.subSeller[subSellerNr].mcc.</param>
        /// <param name="subMerchantSubSellerSubSellerNrName">subMerchant.subSeller[subSellerNr].name.</param>
        /// <param name="subMerchantSubSellerSubSellerNrPostalCode">subMerchant.subSeller[subSellerNr].postalCode.</param>
        /// <param name="subMerchantSubSellerSubSellerNrState">subMerchant.subSeller[subSellerNr].state.</param>
        /// <param name="subMerchantSubSellerSubSellerNrStreet">subMerchant.subSeller[subSellerNr].street.</param>
        /// <param name="subMerchantSubSellerSubSellerNrTaxId">subMerchant.subSeller[subSellerNr].taxId.</param>
        public AdditionalDataSubMerchant(
            string subMerchantNumberOfSubSellers = null,
            string subMerchantSubSellerSubSellerNrCity = null,
            string subMerchantSubSellerSubSellerNrCountry = null,
            string subMerchantSubSellerSubSellerNrId = null,
            string subMerchantSubSellerSubSellerNrMcc = null,
            string subMerchantSubSellerSubSellerNrName = null,
            string subMerchantSubSellerSubSellerNrPostalCode = null,
            string subMerchantSubSellerSubSellerNrState = null,
            string subMerchantSubSellerSubSellerNrStreet = null,
            string subMerchantSubSellerSubSellerNrTaxId = null)
        {
            this.SubMerchantNumberOfSubSellers = subMerchantNumberOfSubSellers;
            this.SubMerchantSubSellerSubSellerNrCity = subMerchantSubSellerSubSellerNrCity;
            this.SubMerchantSubSellerSubSellerNrCountry = subMerchantSubSellerSubSellerNrCountry;
            this.SubMerchantSubSellerSubSellerNrId = subMerchantSubSellerSubSellerNrId;
            this.SubMerchantSubSellerSubSellerNrMcc = subMerchantSubSellerSubSellerNrMcc;
            this.SubMerchantSubSellerSubSellerNrName = subMerchantSubSellerSubSellerNrName;
            this.SubMerchantSubSellerSubSellerNrPostalCode = subMerchantSubSellerSubSellerNrPostalCode;
            this.SubMerchantSubSellerSubSellerNrState = subMerchantSubSellerSubSellerNrState;
            this.SubMerchantSubSellerSubSellerNrStreet = subMerchantSubSellerSubSellerNrStreet;
            this.SubMerchantSubSellerSubSellerNrTaxId = subMerchantSubSellerSubSellerNrTaxId;
        }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. Indicates the number of sub-merchants contained in the request. For example, **3**.
        /// </summary>
        [JsonProperty("subMerchant.numberOfSubSellers", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantNumberOfSubSellers { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The city of the sub-merchant's address.
        /// * Format: Alphanumeric
        /// * Maximum length: 13 characters
        /// </summary>
        [JsonProperty("subMerchant.subSeller[subSellerNr].city", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantSubSellerSubSellerNrCity { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The three-letter country code of the sub-merchant's address. For example, **BRA** for Brazil.
        /// * Format: [ISO 3166-1 alpha-3](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3)
        /// * Fixed length: 3 characters
        /// </summary>
        [JsonProperty("subMerchant.subSeller[subSellerNr].country", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantSubSellerSubSellerNrCountry { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. A unique identifier that you create for the sub-merchant, used by schemes to identify the sub-merchant.
        /// * Format: Alphanumeric
        /// * Maximum length: 15 characters
        /// </summary>
        [JsonProperty("subMerchant.subSeller[subSellerNr].id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantSubSellerSubSellerNrId { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The sub-merchant's 4-digit Merchant Category Code (MCC).
        /// * Format: Numeric
        /// * Fixed length: 4 digits
        /// </summary>
        [JsonProperty("subMerchant.subSeller[subSellerNr].mcc", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantSubSellerSubSellerNrMcc { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The name of the sub-merchant. Based on scheme specifications, this value will overwrite the shopper statement  that will appear in the card statement.
        /// * Format: Alphanumeric
        /// * Maximum length: 22 characters
        /// </summary>
        [JsonProperty("subMerchant.subSeller[subSellerNr].name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantSubSellerSubSellerNrName { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The postal code of the sub-merchant's address, without dashes.
        /// * Format: Numeric
        /// * Fixed length: 8 digits
        /// </summary>
        [JsonProperty("subMerchant.subSeller[subSellerNr].postalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantSubSellerSubSellerNrPostalCode { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The state code of the sub-merchant's address, if applicable to the country.
        /// * Format: Alphanumeric
        /// * Maximum length: 2 characters
        /// </summary>
        [JsonProperty("subMerchant.subSeller[subSellerNr].state", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantSubSellerSubSellerNrState { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The street name and house number of the sub-merchant's address.
        /// * Format: Alphanumeric
        /// * Maximum length: 60 characters
        /// </summary>
        [JsonProperty("subMerchant.subSeller[subSellerNr].street", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantSubSellerSubSellerNrStreet { get; set; }

        /// <summary>
        /// Required for transactions performed by registered payment facilitators. The tax ID of the sub-merchant.
        /// * Format: Numeric
        /// * Fixed length: 11 digits for the CPF or 14 digits for the CNPJ
        /// </summary>
        [JsonProperty("subMerchant.subSeller[subSellerNr].taxId", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMerchantSubSellerSubSellerNrTaxId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalDataSubMerchant : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdditionalDataSubMerchant other &&                ((this.SubMerchantNumberOfSubSellers == null && other.SubMerchantNumberOfSubSellers == null) || (this.SubMerchantNumberOfSubSellers?.Equals(other.SubMerchantNumberOfSubSellers) == true)) &&
                ((this.SubMerchantSubSellerSubSellerNrCity == null && other.SubMerchantSubSellerSubSellerNrCity == null) || (this.SubMerchantSubSellerSubSellerNrCity?.Equals(other.SubMerchantSubSellerSubSellerNrCity) == true)) &&
                ((this.SubMerchantSubSellerSubSellerNrCountry == null && other.SubMerchantSubSellerSubSellerNrCountry == null) || (this.SubMerchantSubSellerSubSellerNrCountry?.Equals(other.SubMerchantSubSellerSubSellerNrCountry) == true)) &&
                ((this.SubMerchantSubSellerSubSellerNrId == null && other.SubMerchantSubSellerSubSellerNrId == null) || (this.SubMerchantSubSellerSubSellerNrId?.Equals(other.SubMerchantSubSellerSubSellerNrId) == true)) &&
                ((this.SubMerchantSubSellerSubSellerNrMcc == null && other.SubMerchantSubSellerSubSellerNrMcc == null) || (this.SubMerchantSubSellerSubSellerNrMcc?.Equals(other.SubMerchantSubSellerSubSellerNrMcc) == true)) &&
                ((this.SubMerchantSubSellerSubSellerNrName == null && other.SubMerchantSubSellerSubSellerNrName == null) || (this.SubMerchantSubSellerSubSellerNrName?.Equals(other.SubMerchantSubSellerSubSellerNrName) == true)) &&
                ((this.SubMerchantSubSellerSubSellerNrPostalCode == null && other.SubMerchantSubSellerSubSellerNrPostalCode == null) || (this.SubMerchantSubSellerSubSellerNrPostalCode?.Equals(other.SubMerchantSubSellerSubSellerNrPostalCode) == true)) &&
                ((this.SubMerchantSubSellerSubSellerNrState == null && other.SubMerchantSubSellerSubSellerNrState == null) || (this.SubMerchantSubSellerSubSellerNrState?.Equals(other.SubMerchantSubSellerSubSellerNrState) == true)) &&
                ((this.SubMerchantSubSellerSubSellerNrStreet == null && other.SubMerchantSubSellerSubSellerNrStreet == null) || (this.SubMerchantSubSellerSubSellerNrStreet?.Equals(other.SubMerchantSubSellerSubSellerNrStreet) == true)) &&
                ((this.SubMerchantSubSellerSubSellerNrTaxId == null && other.SubMerchantSubSellerSubSellerNrTaxId == null) || (this.SubMerchantSubSellerSubSellerNrTaxId?.Equals(other.SubMerchantSubSellerSubSellerNrTaxId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubMerchantNumberOfSubSellers = {(this.SubMerchantNumberOfSubSellers == null ? "null" : this.SubMerchantNumberOfSubSellers)}");
            toStringOutput.Add($"this.SubMerchantSubSellerSubSellerNrCity = {(this.SubMerchantSubSellerSubSellerNrCity == null ? "null" : this.SubMerchantSubSellerSubSellerNrCity)}");
            toStringOutput.Add($"this.SubMerchantSubSellerSubSellerNrCountry = {(this.SubMerchantSubSellerSubSellerNrCountry == null ? "null" : this.SubMerchantSubSellerSubSellerNrCountry)}");
            toStringOutput.Add($"this.SubMerchantSubSellerSubSellerNrId = {(this.SubMerchantSubSellerSubSellerNrId == null ? "null" : this.SubMerchantSubSellerSubSellerNrId)}");
            toStringOutput.Add($"this.SubMerchantSubSellerSubSellerNrMcc = {(this.SubMerchantSubSellerSubSellerNrMcc == null ? "null" : this.SubMerchantSubSellerSubSellerNrMcc)}");
            toStringOutput.Add($"this.SubMerchantSubSellerSubSellerNrName = {(this.SubMerchantSubSellerSubSellerNrName == null ? "null" : this.SubMerchantSubSellerSubSellerNrName)}");
            toStringOutput.Add($"this.SubMerchantSubSellerSubSellerNrPostalCode = {(this.SubMerchantSubSellerSubSellerNrPostalCode == null ? "null" : this.SubMerchantSubSellerSubSellerNrPostalCode)}");
            toStringOutput.Add($"this.SubMerchantSubSellerSubSellerNrState = {(this.SubMerchantSubSellerSubSellerNrState == null ? "null" : this.SubMerchantSubSellerSubSellerNrState)}");
            toStringOutput.Add($"this.SubMerchantSubSellerSubSellerNrStreet = {(this.SubMerchantSubSellerSubSellerNrStreet == null ? "null" : this.SubMerchantSubSellerSubSellerNrStreet)}");
            toStringOutput.Add($"this.SubMerchantSubSellerSubSellerNrTaxId = {(this.SubMerchantSubSellerSubSellerNrTaxId == null ? "null" : this.SubMerchantSubSellerSubSellerNrTaxId)}");
        }
    }
}