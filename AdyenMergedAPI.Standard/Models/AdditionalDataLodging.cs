// <copyright file="AdditionalDataLodging.cs" company="APIMatic">
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
    /// AdditionalDataLodging.
    /// </summary>
    public class AdditionalDataLodging
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataLodging"/> class.
        /// </summary>
        public AdditionalDataLodging()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataLodging"/> class.
        /// </summary>
        /// <param name="lodgingCheckInDate">lodging.checkInDate.</param>
        /// <param name="lodgingCheckOutDate">lodging.checkOutDate.</param>
        /// <param name="lodgingCustomerServiceTollFreeNumber">lodging.customerServiceTollFreeNumber.</param>
        /// <param name="lodgingFireSafetyActIndicator">lodging.fireSafetyActIndicator.</param>
        /// <param name="lodgingFolioCashAdvances">lodging.folioCashAdvances.</param>
        /// <param name="lodgingFolioNumber">lodging.folioNumber.</param>
        /// <param name="lodgingFoodBeverageCharges">lodging.foodBeverageCharges.</param>
        /// <param name="lodgingNoShowIndicator">lodging.noShowIndicator.</param>
        /// <param name="lodgingPrepaidExpenses">lodging.prepaidExpenses.</param>
        /// <param name="lodgingPropertyPhoneNumber">lodging.propertyPhoneNumber.</param>
        /// <param name="lodgingRoom1NumberOfNights">lodging.room1.numberOfNights.</param>
        /// <param name="lodgingRoom1Rate">lodging.room1.rate.</param>
        /// <param name="lodgingTotalRoomTax">lodging.totalRoomTax.</param>
        /// <param name="lodgingTotalTax">lodging.totalTax.</param>
        /// <param name="travelEntertainmentAuthDataDuration">travelEntertainmentAuthData.duration.</param>
        /// <param name="travelEntertainmentAuthDataMarket">travelEntertainmentAuthData.market.</param>
        public AdditionalDataLodging(
            string lodgingCheckInDate = null,
            string lodgingCheckOutDate = null,
            string lodgingCustomerServiceTollFreeNumber = null,
            string lodgingFireSafetyActIndicator = null,
            string lodgingFolioCashAdvances = null,
            string lodgingFolioNumber = null,
            string lodgingFoodBeverageCharges = null,
            string lodgingNoShowIndicator = null,
            string lodgingPrepaidExpenses = null,
            string lodgingPropertyPhoneNumber = null,
            string lodgingRoom1NumberOfNights = null,
            string lodgingRoom1Rate = null,
            string lodgingTotalRoomTax = null,
            string lodgingTotalTax = null,
            string travelEntertainmentAuthDataDuration = null,
            string travelEntertainmentAuthDataMarket = null)
        {
            this.LodgingCheckInDate = lodgingCheckInDate;
            this.LodgingCheckOutDate = lodgingCheckOutDate;
            this.LodgingCustomerServiceTollFreeNumber = lodgingCustomerServiceTollFreeNumber;
            this.LodgingFireSafetyActIndicator = lodgingFireSafetyActIndicator;
            this.LodgingFolioCashAdvances = lodgingFolioCashAdvances;
            this.LodgingFolioNumber = lodgingFolioNumber;
            this.LodgingFoodBeverageCharges = lodgingFoodBeverageCharges;
            this.LodgingNoShowIndicator = lodgingNoShowIndicator;
            this.LodgingPrepaidExpenses = lodgingPrepaidExpenses;
            this.LodgingPropertyPhoneNumber = lodgingPropertyPhoneNumber;
            this.LodgingRoom1NumberOfNights = lodgingRoom1NumberOfNights;
            this.LodgingRoom1Rate = lodgingRoom1Rate;
            this.LodgingTotalRoomTax = lodgingTotalRoomTax;
            this.LodgingTotalTax = lodgingTotalTax;
            this.TravelEntertainmentAuthDataDuration = travelEntertainmentAuthDataDuration;
            this.TravelEntertainmentAuthDataMarket = travelEntertainmentAuthDataMarket;
        }

        /// <summary>
        /// The arrival date.
        /// * Date format: **yyyyMmDd**. For example, for 2023 April 22, **20230422**.
        /// </summary>
        [JsonProperty("lodging.checkInDate", NullValueHandling = NullValueHandling.Ignore)]
        public string LodgingCheckInDate { get; set; }

        /// <summary>
        /// The departure date.
        /// * Date format: **yyyyMmDd**. For example, for 2023 April 22, **20230422**.
        /// </summary>
        [JsonProperty("lodging.checkOutDate", NullValueHandling = NullValueHandling.Ignore)]
        public string LodgingCheckOutDate { get; set; }

        /// <summary>
        /// The toll-free phone number for the lodging.
        /// * Format: numeric
        /// * Max length: 17 characters.
        /// * For US and CA numbers must be 10 characters in length
        /// * Must not start with a space
        /// * Must not contain any special characters such as + or -
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("lodging.customerServiceTollFreeNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string LodgingCustomerServiceTollFreeNumber { get; set; }

        /// <summary>
        /// Identifies that the facility complies with the Hotel and Motel Fire Safety Act of 1990. Must be 'Y' or 'N'.
        /// * Format: alphabetic
        /// * Max length: 1 character
        /// </summary>
        [JsonProperty("lodging.fireSafetyActIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public string LodgingFireSafetyActIndicator { get; set; }

        /// <summary>
        /// The folio cash advances, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * Format: numeric
        /// * Max length: 12 characters
        /// </summary>
        [JsonProperty("lodging.folioCashAdvances", NullValueHandling = NullValueHandling.Ignore)]
        public string LodgingFolioCashAdvances { get; set; }

        /// <summary>
        /// The card acceptor’s internal invoice or billing ID reference number.
        /// * Max length: 25 characters.
        /// * Must not start with a space
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("lodging.folioNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string LodgingFolioNumber { get; set; }

        /// <summary>
        /// Any charges for food and beverages associated with the booking, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * Format: numeric
        /// * Max length: 12 characters
        /// </summary>
        [JsonProperty("lodging.foodBeverageCharges", NullValueHandling = NullValueHandling.Ignore)]
        public string LodgingFoodBeverageCharges { get; set; }

        /// <summary>
        /// Indicates if the customer didn't check in for their booking.
        ///  Possible values:
        /// * **Y**: the customer didn't check in
        /// * **N**: the customer checked in
        /// </summary>
        [JsonProperty("lodging.noShowIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public string LodgingNoShowIndicator { get; set; }

        /// <summary>
        /// The prepaid expenses for the booking.
        /// * Format: numeric
        /// * Max length: 12 characters
        /// </summary>
        [JsonProperty("lodging.prepaidExpenses", NullValueHandling = NullValueHandling.Ignore)]
        public string LodgingPrepaidExpenses { get; set; }

        /// <summary>
        /// The lodging property location's phone number.
        /// * Format: numeric.
        /// * Min length: 10 characters
        /// * Max length: 17 characters
        /// * For US and CA numbers must be 10 characters in length
        /// * Must not start with a space
        /// * Must not contain any special characters such as + or -
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("lodging.propertyPhoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string LodgingPropertyPhoneNumber { get; set; }

        /// <summary>
        /// The total number of nights the room is booked for.
        /// * Format: numeric
        /// * Must be a number between 0 and 99
        /// * Max length: 4 characters
        /// </summary>
        [JsonProperty("lodging.room1.numberOfNights", NullValueHandling = NullValueHandling.Ignore)]
        public string LodgingRoom1NumberOfNights { get; set; }

        /// <summary>
        /// The rate for the room, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * Format: numeric
        /// * Max length: 12 characters
        /// * Must not be a negative number
        /// </summary>
        [JsonProperty("lodging.room1.rate", NullValueHandling = NullValueHandling.Ignore)]
        public string LodgingRoom1Rate { get; set; }

        /// <summary>
        /// The total room tax amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * Format: numeric
        /// * Max length: 12 characters
        /// * Must not be a negative number
        /// </summary>
        [JsonProperty("lodging.totalRoomTax", NullValueHandling = NullValueHandling.Ignore)]
        public string LodgingTotalRoomTax { get; set; }

        /// <summary>
        /// The total tax amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * Format: numeric
        /// * Max length: 12 characters
        /// * Must not be a negative number
        /// </summary>
        [JsonProperty("lodging.totalTax", NullValueHandling = NullValueHandling.Ignore)]
        public string LodgingTotalTax { get; set; }

        /// <summary>
        /// The number of nights. This should be included in the auth message.
        /// * Format: numeric
        /// * Max length: 4 characters
        /// </summary>
        [JsonProperty("travelEntertainmentAuthData.duration", NullValueHandling = NullValueHandling.Ignore)]
        public string TravelEntertainmentAuthDataDuration { get; set; }

        /// <summary>
        /// Indicates what market-specific dataset will be submitted. Must be 'H' for Hotel. This should be included in the auth message.
        /// * Format: alphanumeric
        /// * Max length: 1 character
        /// </summary>
        [JsonProperty("travelEntertainmentAuthData.market", NullValueHandling = NullValueHandling.Ignore)]
        public string TravelEntertainmentAuthDataMarket { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalDataLodging : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdditionalDataLodging other &&                ((this.LodgingCheckInDate == null && other.LodgingCheckInDate == null) || (this.LodgingCheckInDate?.Equals(other.LodgingCheckInDate) == true)) &&
                ((this.LodgingCheckOutDate == null && other.LodgingCheckOutDate == null) || (this.LodgingCheckOutDate?.Equals(other.LodgingCheckOutDate) == true)) &&
                ((this.LodgingCustomerServiceTollFreeNumber == null && other.LodgingCustomerServiceTollFreeNumber == null) || (this.LodgingCustomerServiceTollFreeNumber?.Equals(other.LodgingCustomerServiceTollFreeNumber) == true)) &&
                ((this.LodgingFireSafetyActIndicator == null && other.LodgingFireSafetyActIndicator == null) || (this.LodgingFireSafetyActIndicator?.Equals(other.LodgingFireSafetyActIndicator) == true)) &&
                ((this.LodgingFolioCashAdvances == null && other.LodgingFolioCashAdvances == null) || (this.LodgingFolioCashAdvances?.Equals(other.LodgingFolioCashAdvances) == true)) &&
                ((this.LodgingFolioNumber == null && other.LodgingFolioNumber == null) || (this.LodgingFolioNumber?.Equals(other.LodgingFolioNumber) == true)) &&
                ((this.LodgingFoodBeverageCharges == null && other.LodgingFoodBeverageCharges == null) || (this.LodgingFoodBeverageCharges?.Equals(other.LodgingFoodBeverageCharges) == true)) &&
                ((this.LodgingNoShowIndicator == null && other.LodgingNoShowIndicator == null) || (this.LodgingNoShowIndicator?.Equals(other.LodgingNoShowIndicator) == true)) &&
                ((this.LodgingPrepaidExpenses == null && other.LodgingPrepaidExpenses == null) || (this.LodgingPrepaidExpenses?.Equals(other.LodgingPrepaidExpenses) == true)) &&
                ((this.LodgingPropertyPhoneNumber == null && other.LodgingPropertyPhoneNumber == null) || (this.LodgingPropertyPhoneNumber?.Equals(other.LodgingPropertyPhoneNumber) == true)) &&
                ((this.LodgingRoom1NumberOfNights == null && other.LodgingRoom1NumberOfNights == null) || (this.LodgingRoom1NumberOfNights?.Equals(other.LodgingRoom1NumberOfNights) == true)) &&
                ((this.LodgingRoom1Rate == null && other.LodgingRoom1Rate == null) || (this.LodgingRoom1Rate?.Equals(other.LodgingRoom1Rate) == true)) &&
                ((this.LodgingTotalRoomTax == null && other.LodgingTotalRoomTax == null) || (this.LodgingTotalRoomTax?.Equals(other.LodgingTotalRoomTax) == true)) &&
                ((this.LodgingTotalTax == null && other.LodgingTotalTax == null) || (this.LodgingTotalTax?.Equals(other.LodgingTotalTax) == true)) &&
                ((this.TravelEntertainmentAuthDataDuration == null && other.TravelEntertainmentAuthDataDuration == null) || (this.TravelEntertainmentAuthDataDuration?.Equals(other.TravelEntertainmentAuthDataDuration) == true)) &&
                ((this.TravelEntertainmentAuthDataMarket == null && other.TravelEntertainmentAuthDataMarket == null) || (this.TravelEntertainmentAuthDataMarket?.Equals(other.TravelEntertainmentAuthDataMarket) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LodgingCheckInDate = {(this.LodgingCheckInDate == null ? "null" : this.LodgingCheckInDate)}");
            toStringOutput.Add($"this.LodgingCheckOutDate = {(this.LodgingCheckOutDate == null ? "null" : this.LodgingCheckOutDate)}");
            toStringOutput.Add($"this.LodgingCustomerServiceTollFreeNumber = {(this.LodgingCustomerServiceTollFreeNumber == null ? "null" : this.LodgingCustomerServiceTollFreeNumber)}");
            toStringOutput.Add($"this.LodgingFireSafetyActIndicator = {(this.LodgingFireSafetyActIndicator == null ? "null" : this.LodgingFireSafetyActIndicator)}");
            toStringOutput.Add($"this.LodgingFolioCashAdvances = {(this.LodgingFolioCashAdvances == null ? "null" : this.LodgingFolioCashAdvances)}");
            toStringOutput.Add($"this.LodgingFolioNumber = {(this.LodgingFolioNumber == null ? "null" : this.LodgingFolioNumber)}");
            toStringOutput.Add($"this.LodgingFoodBeverageCharges = {(this.LodgingFoodBeverageCharges == null ? "null" : this.LodgingFoodBeverageCharges)}");
            toStringOutput.Add($"this.LodgingNoShowIndicator = {(this.LodgingNoShowIndicator == null ? "null" : this.LodgingNoShowIndicator)}");
            toStringOutput.Add($"this.LodgingPrepaidExpenses = {(this.LodgingPrepaidExpenses == null ? "null" : this.LodgingPrepaidExpenses)}");
            toStringOutput.Add($"this.LodgingPropertyPhoneNumber = {(this.LodgingPropertyPhoneNumber == null ? "null" : this.LodgingPropertyPhoneNumber)}");
            toStringOutput.Add($"this.LodgingRoom1NumberOfNights = {(this.LodgingRoom1NumberOfNights == null ? "null" : this.LodgingRoom1NumberOfNights)}");
            toStringOutput.Add($"this.LodgingRoom1Rate = {(this.LodgingRoom1Rate == null ? "null" : this.LodgingRoom1Rate)}");
            toStringOutput.Add($"this.LodgingTotalRoomTax = {(this.LodgingTotalRoomTax == null ? "null" : this.LodgingTotalRoomTax)}");
            toStringOutput.Add($"this.LodgingTotalTax = {(this.LodgingTotalTax == null ? "null" : this.LodgingTotalTax)}");
            toStringOutput.Add($"this.TravelEntertainmentAuthDataDuration = {(this.TravelEntertainmentAuthDataDuration == null ? "null" : this.TravelEntertainmentAuthDataDuration)}");
            toStringOutput.Add($"this.TravelEntertainmentAuthDataMarket = {(this.TravelEntertainmentAuthDataMarket == null ? "null" : this.TravelEntertainmentAuthDataMarket)}");
        }
    }
}