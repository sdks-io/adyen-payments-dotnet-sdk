// <copyright file="AdditionalDataCarRental.cs" company="APIMatic">
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
    /// AdditionalDataCarRental.
    /// </summary>
    public class AdditionalDataCarRental
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataCarRental"/> class.
        /// </summary>
        public AdditionalDataCarRental()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataCarRental"/> class.
        /// </summary>
        /// <param name="carRentalCheckOutDate">carRental.checkOutDate.</param>
        /// <param name="carRentalCustomerServiceTollFreeNumber">carRental.customerServiceTollFreeNumber.</param>
        /// <param name="carRentalDaysRented">carRental.daysRented.</param>
        /// <param name="carRentalFuelCharges">carRental.fuelCharges.</param>
        /// <param name="carRentalInsuranceCharges">carRental.insuranceCharges.</param>
        /// <param name="carRentalLocationCity">carRental.locationCity.</param>
        /// <param name="carRentalLocationCountry">carRental.locationCountry.</param>
        /// <param name="carRentalLocationStateProvince">carRental.locationStateProvince.</param>
        /// <param name="carRentalNoShowIndicator">carRental.noShowIndicator.</param>
        /// <param name="carRentalOneWayDropOffCharges">carRental.oneWayDropOffCharges.</param>
        /// <param name="carRentalRate">carRental.rate.</param>
        /// <param name="carRentalRateIndicator">carRental.rateIndicator.</param>
        /// <param name="carRentalRentalAgreementNumber">carRental.rentalAgreementNumber.</param>
        /// <param name="carRentalRentalClassId">carRental.rentalClassId.</param>
        /// <param name="carRentalRenterName">carRental.renterName.</param>
        /// <param name="carRentalReturnCity">carRental.returnCity.</param>
        /// <param name="carRentalReturnCountry">carRental.returnCountry.</param>
        /// <param name="carRentalReturnDate">carRental.returnDate.</param>
        /// <param name="carRentalReturnLocationId">carRental.returnLocationId.</param>
        /// <param name="carRentalReturnStateProvince">carRental.returnStateProvince.</param>
        /// <param name="carRentalTaxExemptIndicator">carRental.taxExemptIndicator.</param>
        /// <param name="travelEntertainmentAuthDataDuration">travelEntertainmentAuthData.duration.</param>
        /// <param name="travelEntertainmentAuthDataMarket">travelEntertainmentAuthData.market.</param>
        public AdditionalDataCarRental(
            string carRentalCheckOutDate = null,
            string carRentalCustomerServiceTollFreeNumber = null,
            string carRentalDaysRented = null,
            string carRentalFuelCharges = null,
            string carRentalInsuranceCharges = null,
            string carRentalLocationCity = null,
            string carRentalLocationCountry = null,
            string carRentalLocationStateProvince = null,
            string carRentalNoShowIndicator = null,
            string carRentalOneWayDropOffCharges = null,
            string carRentalRate = null,
            string carRentalRateIndicator = null,
            string carRentalRentalAgreementNumber = null,
            string carRentalRentalClassId = null,
            string carRentalRenterName = null,
            string carRentalReturnCity = null,
            string carRentalReturnCountry = null,
            string carRentalReturnDate = null,
            string carRentalReturnLocationId = null,
            string carRentalReturnStateProvince = null,
            string carRentalTaxExemptIndicator = null,
            string travelEntertainmentAuthDataDuration = null,
            string travelEntertainmentAuthDataMarket = null)
        {
            this.CarRentalCheckOutDate = carRentalCheckOutDate;
            this.CarRentalCustomerServiceTollFreeNumber = carRentalCustomerServiceTollFreeNumber;
            this.CarRentalDaysRented = carRentalDaysRented;
            this.CarRentalFuelCharges = carRentalFuelCharges;
            this.CarRentalInsuranceCharges = carRentalInsuranceCharges;
            this.CarRentalLocationCity = carRentalLocationCity;
            this.CarRentalLocationCountry = carRentalLocationCountry;
            this.CarRentalLocationStateProvince = carRentalLocationStateProvince;
            this.CarRentalNoShowIndicator = carRentalNoShowIndicator;
            this.CarRentalOneWayDropOffCharges = carRentalOneWayDropOffCharges;
            this.CarRentalRate = carRentalRate;
            this.CarRentalRateIndicator = carRentalRateIndicator;
            this.CarRentalRentalAgreementNumber = carRentalRentalAgreementNumber;
            this.CarRentalRentalClassId = carRentalRentalClassId;
            this.CarRentalRenterName = carRentalRenterName;
            this.CarRentalReturnCity = carRentalReturnCity;
            this.CarRentalReturnCountry = carRentalReturnCountry;
            this.CarRentalReturnDate = carRentalReturnDate;
            this.CarRentalReturnLocationId = carRentalReturnLocationId;
            this.CarRentalReturnStateProvince = carRentalReturnStateProvince;
            this.CarRentalTaxExemptIndicator = carRentalTaxExemptIndicator;
            this.TravelEntertainmentAuthDataDuration = travelEntertainmentAuthDataDuration;
            this.TravelEntertainmentAuthDataMarket = travelEntertainmentAuthDataMarket;
        }

        /// <summary>
        /// The pick-up date.
        /// * Date format: `yyyyMMdd`
        /// </summary>
        [JsonProperty("carRental.checkOutDate", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalCheckOutDate { get; set; }

        /// <summary>
        /// The customer service phone number of the car rental company.
        /// * Format: Alphanumeric
        /// * maxLength: 17
        /// * For US and CA numbers must be 10 characters in length
        /// * Must not start with a space
        /// * Must not contain any special characters such as + or -
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("carRental.customerServiceTollFreeNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalCustomerServiceTollFreeNumber { get; set; }

        /// <summary>
        /// Number of days for which the car is being rented.
        /// * Format: Numeric
        /// * maxLength: 4
        /// * Must not be all spaces
        /// </summary>
        [JsonProperty("carRental.daysRented", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalDaysRented { get; set; }

        /// <summary>
        /// Any fuel charges associated with the rental, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * Format: Numeric
        /// * maxLength: 12
        /// </summary>
        [JsonProperty("carRental.fuelCharges", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalFuelCharges { get; set; }

        /// <summary>
        /// Any insurance charges associated with the rental, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * Format: Numeric
        /// * maxLength: 12
        /// * Must not be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("carRental.insuranceCharges", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalInsuranceCharges { get; set; }

        /// <summary>
        /// The city where the car is rented.
        /// * Format: Alphanumeric
        /// * maxLength: 18
        /// * Must not start with a space or be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("carRental.locationCity", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalLocationCity { get; set; }

        /// <summary>
        /// The country where the car is rented, in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format.
        /// * Format: Alphanumeric
        /// * maxLength: 2
        /// </summary>
        [JsonProperty("carRental.locationCountry", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalLocationCountry { get; set; }

        /// <summary>
        /// The state or province where the car is rented.
        /// * Format: Alphanumeric
        /// * maxLength: 2
        /// * Must not start with a space or be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("carRental.locationStateProvince", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalLocationStateProvince { get; set; }

        /// <summary>
        /// Indicates if the customer didn't pick up their rental car.
        /// * Y - Customer did not pick up their car
        /// * N - Not applicable
        /// </summary>
        [JsonProperty("carRental.noShowIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalNoShowIndicator { get; set; }

        /// <summary>
        /// The charge for not returning a car to the original rental location, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * maxLength: 12
        /// </summary>
        [JsonProperty("carRental.oneWayDropOffCharges", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalOneWayDropOffCharges { get; set; }

        /// <summary>
        /// The daily rental rate, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * Format: Alphanumeric
        /// * maxLength: 12
        /// </summary>
        [JsonProperty("carRental.rate", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalRate { get; set; }

        /// <summary>
        /// Specifies whether the given rate is applied daily or weekly.
        /// * D - Daily rate
        /// * W - Weekly rate
        /// </summary>
        [JsonProperty("carRental.rateIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalRateIndicator { get; set; }

        /// <summary>
        /// The rental agreement number for the car rental.
        /// * Format: Alphanumeric
        /// * maxLength: 9
        /// * Must not start with a space or be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("carRental.rentalAgreementNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalRentalAgreementNumber { get; set; }

        /// <summary>
        /// The classification of the rental car.
        /// * Format: Alphanumeric
        /// * maxLength: 4
        /// * Must not start with a space or be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("carRental.rentalClassId", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalRentalClassId { get; set; }

        /// <summary>
        /// The name of the person renting the car.
        /// * Format: Alphanumeric
        /// * maxLength: 26
        /// * If you send more than 26 characters, the name is truncated
        /// * Must not start with a space or be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("carRental.renterName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalRenterName { get; set; }

        /// <summary>
        /// The city where the car must be returned.
        /// * Format: Alphanumeric
        /// * maxLength: 18
        /// * Must not start with a space or be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("carRental.returnCity", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalReturnCity { get; set; }

        /// <summary>
        /// The country where the car must be returned, in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format.
        /// * Format: Alphanumeric
        /// * maxLength: 2
        /// </summary>
        [JsonProperty("carRental.returnCountry", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalReturnCountry { get; set; }

        /// <summary>
        /// The last date to return the car by.
        /// * Date format: `yyyyMMdd`
        /// * maxLength: 8
        /// </summary>
        [JsonProperty("carRental.returnDate", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalReturnDate { get; set; }

        /// <summary>
        /// The agency code, phone number, or address abbreviation
        /// * Format: Alphanumeric
        /// * maxLength: 10
        /// * Must not start with a space or be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("carRental.returnLocationId", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalReturnLocationId { get; set; }

        /// <summary>
        /// The state or province where the car must be returned.
        /// * Format: Alphanumeric
        /// * maxLength: 3
        /// * Must not start with a space or be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("carRental.returnStateProvince", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalReturnStateProvince { get; set; }

        /// <summary>
        /// Indicates if the goods or services were tax-exempt, or if tax was not paid on them.
        /// Values:
        /// * Y - Goods or services were tax exempt
        /// * N - Tax was not collected
        /// </summary>
        [JsonProperty("carRental.taxExemptIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public string CarRentalTaxExemptIndicator { get; set; }

        /// <summary>
        /// Number of days the car is rented for. This should be included in the auth message.
        /// * Format: Numeric
        /// * maxLength: 4
        /// </summary>
        [JsonProperty("travelEntertainmentAuthData.duration", NullValueHandling = NullValueHandling.Ignore)]
        public string TravelEntertainmentAuthDataDuration { get; set; }

        /// <summary>
        /// Indicates what market-specific dataset will be submitted or is being submitted. Value should be 'A' for car rental. This should be included in the auth message.
        /// * Format: Alphanumeric
        /// * maxLength: 1
        /// </summary>
        [JsonProperty("travelEntertainmentAuthData.market", NullValueHandling = NullValueHandling.Ignore)]
        public string TravelEntertainmentAuthDataMarket { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalDataCarRental : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdditionalDataCarRental other &&                ((this.CarRentalCheckOutDate == null && other.CarRentalCheckOutDate == null) || (this.CarRentalCheckOutDate?.Equals(other.CarRentalCheckOutDate) == true)) &&
                ((this.CarRentalCustomerServiceTollFreeNumber == null && other.CarRentalCustomerServiceTollFreeNumber == null) || (this.CarRentalCustomerServiceTollFreeNumber?.Equals(other.CarRentalCustomerServiceTollFreeNumber) == true)) &&
                ((this.CarRentalDaysRented == null && other.CarRentalDaysRented == null) || (this.CarRentalDaysRented?.Equals(other.CarRentalDaysRented) == true)) &&
                ((this.CarRentalFuelCharges == null && other.CarRentalFuelCharges == null) || (this.CarRentalFuelCharges?.Equals(other.CarRentalFuelCharges) == true)) &&
                ((this.CarRentalInsuranceCharges == null && other.CarRentalInsuranceCharges == null) || (this.CarRentalInsuranceCharges?.Equals(other.CarRentalInsuranceCharges) == true)) &&
                ((this.CarRentalLocationCity == null && other.CarRentalLocationCity == null) || (this.CarRentalLocationCity?.Equals(other.CarRentalLocationCity) == true)) &&
                ((this.CarRentalLocationCountry == null && other.CarRentalLocationCountry == null) || (this.CarRentalLocationCountry?.Equals(other.CarRentalLocationCountry) == true)) &&
                ((this.CarRentalLocationStateProvince == null && other.CarRentalLocationStateProvince == null) || (this.CarRentalLocationStateProvince?.Equals(other.CarRentalLocationStateProvince) == true)) &&
                ((this.CarRentalNoShowIndicator == null && other.CarRentalNoShowIndicator == null) || (this.CarRentalNoShowIndicator?.Equals(other.CarRentalNoShowIndicator) == true)) &&
                ((this.CarRentalOneWayDropOffCharges == null && other.CarRentalOneWayDropOffCharges == null) || (this.CarRentalOneWayDropOffCharges?.Equals(other.CarRentalOneWayDropOffCharges) == true)) &&
                ((this.CarRentalRate == null && other.CarRentalRate == null) || (this.CarRentalRate?.Equals(other.CarRentalRate) == true)) &&
                ((this.CarRentalRateIndicator == null && other.CarRentalRateIndicator == null) || (this.CarRentalRateIndicator?.Equals(other.CarRentalRateIndicator) == true)) &&
                ((this.CarRentalRentalAgreementNumber == null && other.CarRentalRentalAgreementNumber == null) || (this.CarRentalRentalAgreementNumber?.Equals(other.CarRentalRentalAgreementNumber) == true)) &&
                ((this.CarRentalRentalClassId == null && other.CarRentalRentalClassId == null) || (this.CarRentalRentalClassId?.Equals(other.CarRentalRentalClassId) == true)) &&
                ((this.CarRentalRenterName == null && other.CarRentalRenterName == null) || (this.CarRentalRenterName?.Equals(other.CarRentalRenterName) == true)) &&
                ((this.CarRentalReturnCity == null && other.CarRentalReturnCity == null) || (this.CarRentalReturnCity?.Equals(other.CarRentalReturnCity) == true)) &&
                ((this.CarRentalReturnCountry == null && other.CarRentalReturnCountry == null) || (this.CarRentalReturnCountry?.Equals(other.CarRentalReturnCountry) == true)) &&
                ((this.CarRentalReturnDate == null && other.CarRentalReturnDate == null) || (this.CarRentalReturnDate?.Equals(other.CarRentalReturnDate) == true)) &&
                ((this.CarRentalReturnLocationId == null && other.CarRentalReturnLocationId == null) || (this.CarRentalReturnLocationId?.Equals(other.CarRentalReturnLocationId) == true)) &&
                ((this.CarRentalReturnStateProvince == null && other.CarRentalReturnStateProvince == null) || (this.CarRentalReturnStateProvince?.Equals(other.CarRentalReturnStateProvince) == true)) &&
                ((this.CarRentalTaxExemptIndicator == null && other.CarRentalTaxExemptIndicator == null) || (this.CarRentalTaxExemptIndicator?.Equals(other.CarRentalTaxExemptIndicator) == true)) &&
                ((this.TravelEntertainmentAuthDataDuration == null && other.TravelEntertainmentAuthDataDuration == null) || (this.TravelEntertainmentAuthDataDuration?.Equals(other.TravelEntertainmentAuthDataDuration) == true)) &&
                ((this.TravelEntertainmentAuthDataMarket == null && other.TravelEntertainmentAuthDataMarket == null) || (this.TravelEntertainmentAuthDataMarket?.Equals(other.TravelEntertainmentAuthDataMarket) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CarRentalCheckOutDate = {(this.CarRentalCheckOutDate == null ? "null" : this.CarRentalCheckOutDate)}");
            toStringOutput.Add($"this.CarRentalCustomerServiceTollFreeNumber = {(this.CarRentalCustomerServiceTollFreeNumber == null ? "null" : this.CarRentalCustomerServiceTollFreeNumber)}");
            toStringOutput.Add($"this.CarRentalDaysRented = {(this.CarRentalDaysRented == null ? "null" : this.CarRentalDaysRented)}");
            toStringOutput.Add($"this.CarRentalFuelCharges = {(this.CarRentalFuelCharges == null ? "null" : this.CarRentalFuelCharges)}");
            toStringOutput.Add($"this.CarRentalInsuranceCharges = {(this.CarRentalInsuranceCharges == null ? "null" : this.CarRentalInsuranceCharges)}");
            toStringOutput.Add($"this.CarRentalLocationCity = {(this.CarRentalLocationCity == null ? "null" : this.CarRentalLocationCity)}");
            toStringOutput.Add($"this.CarRentalLocationCountry = {(this.CarRentalLocationCountry == null ? "null" : this.CarRentalLocationCountry)}");
            toStringOutput.Add($"this.CarRentalLocationStateProvince = {(this.CarRentalLocationStateProvince == null ? "null" : this.CarRentalLocationStateProvince)}");
            toStringOutput.Add($"this.CarRentalNoShowIndicator = {(this.CarRentalNoShowIndicator == null ? "null" : this.CarRentalNoShowIndicator)}");
            toStringOutput.Add($"this.CarRentalOneWayDropOffCharges = {(this.CarRentalOneWayDropOffCharges == null ? "null" : this.CarRentalOneWayDropOffCharges)}");
            toStringOutput.Add($"this.CarRentalRate = {(this.CarRentalRate == null ? "null" : this.CarRentalRate)}");
            toStringOutput.Add($"this.CarRentalRateIndicator = {(this.CarRentalRateIndicator == null ? "null" : this.CarRentalRateIndicator)}");
            toStringOutput.Add($"this.CarRentalRentalAgreementNumber = {(this.CarRentalRentalAgreementNumber == null ? "null" : this.CarRentalRentalAgreementNumber)}");
            toStringOutput.Add($"this.CarRentalRentalClassId = {(this.CarRentalRentalClassId == null ? "null" : this.CarRentalRentalClassId)}");
            toStringOutput.Add($"this.CarRentalRenterName = {(this.CarRentalRenterName == null ? "null" : this.CarRentalRenterName)}");
            toStringOutput.Add($"this.CarRentalReturnCity = {(this.CarRentalReturnCity == null ? "null" : this.CarRentalReturnCity)}");
            toStringOutput.Add($"this.CarRentalReturnCountry = {(this.CarRentalReturnCountry == null ? "null" : this.CarRentalReturnCountry)}");
            toStringOutput.Add($"this.CarRentalReturnDate = {(this.CarRentalReturnDate == null ? "null" : this.CarRentalReturnDate)}");
            toStringOutput.Add($"this.CarRentalReturnLocationId = {(this.CarRentalReturnLocationId == null ? "null" : this.CarRentalReturnLocationId)}");
            toStringOutput.Add($"this.CarRentalReturnStateProvince = {(this.CarRentalReturnStateProvince == null ? "null" : this.CarRentalReturnStateProvince)}");
            toStringOutput.Add($"this.CarRentalTaxExemptIndicator = {(this.CarRentalTaxExemptIndicator == null ? "null" : this.CarRentalTaxExemptIndicator)}");
            toStringOutput.Add($"this.TravelEntertainmentAuthDataDuration = {(this.TravelEntertainmentAuthDataDuration == null ? "null" : this.TravelEntertainmentAuthDataDuration)}");
            toStringOutput.Add($"this.TravelEntertainmentAuthDataMarket = {(this.TravelEntertainmentAuthDataMarket == null ? "null" : this.TravelEntertainmentAuthDataMarket)}");
        }
    }
}