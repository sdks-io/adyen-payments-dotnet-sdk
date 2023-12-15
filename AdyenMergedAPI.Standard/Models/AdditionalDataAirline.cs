// <copyright file="AdditionalDataAirline.cs" company="APIMatic">
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
    /// AdditionalDataAirline.
    /// </summary>
    public class AdditionalDataAirline
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataAirline"/> class.
        /// </summary>
        public AdditionalDataAirline()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataAirline"/> class.
        /// </summary>
        /// <param name="airlinePassengerName">airline.passenger_name.</param>
        /// <param name="airlineAgencyInvoiceNumber">airline.agency_invoice_number.</param>
        /// <param name="airlineAgencyPlanName">airline.agency_plan_name.</param>
        /// <param name="airlineAirlineCode">airline.airline_code.</param>
        /// <param name="airlineAirlineDesignatorCode">airline.airline_designator_code.</param>
        /// <param name="airlineBoardingFee">airline.boarding_fee.</param>
        /// <param name="airlineComputerizedReservationSystem">airline.computerized_reservation_system.</param>
        /// <param name="airlineCustomerReferenceNumber">airline.customer_reference_number.</param>
        /// <param name="airlineDocumentType">airline.document_type.</param>
        /// <param name="airlineFlightDate">airline.flight_date.</param>
        /// <param name="airlineLegCarrierCode">airline.leg.carrier_code.</param>
        /// <param name="airlineLegClassOfTravel">airline.leg.class_of_travel.</param>
        /// <param name="airlineLegDateOfTravel">airline.leg.date_of_travel.</param>
        /// <param name="airlineLegDepartAirport">airline.leg.depart_airport.</param>
        /// <param name="airlineLegDepartTax">airline.leg.depart_tax.</param>
        /// <param name="airlineLegDestinationCode">airline.leg.destination_code.</param>
        /// <param name="airlineLegFareBaseCode">airline.leg.fare_base_code.</param>
        /// <param name="airlineLegFlightNumber">airline.leg.flight_number.</param>
        /// <param name="airlineLegStopOverCode">airline.leg.stop_over_code.</param>
        /// <param name="airlinePassengerDateOfBirth">airline.passenger.date_of_birth.</param>
        /// <param name="airlinePassengerFirstName">airline.passenger.first_name.</param>
        /// <param name="airlinePassengerLastName">airline.passenger.last_name.</param>
        /// <param name="airlinePassengerTelephoneNumber">airline.passenger.telephone_number.</param>
        /// <param name="airlinePassengerTravellerType">airline.passenger.traveller_type.</param>
        /// <param name="airlineTicketIssueAddress">airline.ticket_issue_address.</param>
        /// <param name="airlineTicketNumber">airline.ticket_number.</param>
        /// <param name="airlineTravelAgencyCode">airline.travel_agency_code.</param>
        /// <param name="airlineTravelAgencyName">airline.travel_agency_name.</param>
        public AdditionalDataAirline(
            string airlinePassengerName,
            string airlineAgencyInvoiceNumber = null,
            string airlineAgencyPlanName = null,
            string airlineAirlineCode = null,
            string airlineAirlineDesignatorCode = null,
            string airlineBoardingFee = null,
            string airlineComputerizedReservationSystem = null,
            string airlineCustomerReferenceNumber = null,
            string airlineDocumentType = null,
            string airlineFlightDate = null,
            string airlineLegCarrierCode = null,
            string airlineLegClassOfTravel = null,
            string airlineLegDateOfTravel = null,
            string airlineLegDepartAirport = null,
            string airlineLegDepartTax = null,
            string airlineLegDestinationCode = null,
            string airlineLegFareBaseCode = null,
            string airlineLegFlightNumber = null,
            string airlineLegStopOverCode = null,
            string airlinePassengerDateOfBirth = null,
            string airlinePassengerFirstName = null,
            string airlinePassengerLastName = null,
            string airlinePassengerTelephoneNumber = null,
            string airlinePassengerTravellerType = null,
            string airlineTicketIssueAddress = null,
            string airlineTicketNumber = null,
            string airlineTravelAgencyCode = null,
            string airlineTravelAgencyName = null)
        {
            this.AirlineAgencyInvoiceNumber = airlineAgencyInvoiceNumber;
            this.AirlineAgencyPlanName = airlineAgencyPlanName;
            this.AirlineAirlineCode = airlineAirlineCode;
            this.AirlineAirlineDesignatorCode = airlineAirlineDesignatorCode;
            this.AirlineBoardingFee = airlineBoardingFee;
            this.AirlineComputerizedReservationSystem = airlineComputerizedReservationSystem;
            this.AirlineCustomerReferenceNumber = airlineCustomerReferenceNumber;
            this.AirlineDocumentType = airlineDocumentType;
            this.AirlineFlightDate = airlineFlightDate;
            this.AirlineLegCarrierCode = airlineLegCarrierCode;
            this.AirlineLegClassOfTravel = airlineLegClassOfTravel;
            this.AirlineLegDateOfTravel = airlineLegDateOfTravel;
            this.AirlineLegDepartAirport = airlineLegDepartAirport;
            this.AirlineLegDepartTax = airlineLegDepartTax;
            this.AirlineLegDestinationCode = airlineLegDestinationCode;
            this.AirlineLegFareBaseCode = airlineLegFareBaseCode;
            this.AirlineLegFlightNumber = airlineLegFlightNumber;
            this.AirlineLegStopOverCode = airlineLegStopOverCode;
            this.AirlinePassengerDateOfBirth = airlinePassengerDateOfBirth;
            this.AirlinePassengerFirstName = airlinePassengerFirstName;
            this.AirlinePassengerLastName = airlinePassengerLastName;
            this.AirlinePassengerTelephoneNumber = airlinePassengerTelephoneNumber;
            this.AirlinePassengerTravellerType = airlinePassengerTravellerType;
            this.AirlinePassengerName = airlinePassengerName;
            this.AirlineTicketIssueAddress = airlineTicketIssueAddress;
            this.AirlineTicketNumber = airlineTicketNumber;
            this.AirlineTravelAgencyCode = airlineTravelAgencyCode;
            this.AirlineTravelAgencyName = airlineTravelAgencyName;
        }

        /// <summary>
        /// The reference number for the invoice, issued by the agency.
        /// * Encoding: ASCII
        /// * minLength: 1 character
        /// * maxLength: 6 characters
        /// </summary>
        [JsonProperty("airline.agency_invoice_number", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineAgencyInvoiceNumber { get; set; }

        /// <summary>
        /// The two-letter agency plan identifier.
        /// * Encoding: ASCII
        /// * minLength: 2 characters
        /// * maxLength: 2 characters
        /// </summary>
        [JsonProperty("airline.agency_plan_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineAgencyPlanName { get; set; }

        /// <summary>
        /// The [IATA](https://www.iata.org/services/pages/codes.aspx) 3-digit accounting code (PAX) that identifies the carrier.
        /// * Format: IATA 3-digit accounting code (PAX)
        /// * Example: KLM = 074
        /// * minLength: 3 characters
        /// * maxLength: 3 characters
        /// * Must not be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("airline.airline_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineAirlineCode { get; set; }

        /// <summary>
        /// The [IATA](https://www.iata.org/services/pages/codes.aspx) 2-letter accounting code (PAX) that identifies the carrier.
        /// * Encoding: ASCII
        /// * Example: KLM = KL
        /// * minLength: 2 characters
        /// * maxLength: 2 characters
        /// * Must not be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("airline.airline_designator_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineAirlineDesignatorCode { get; set; }

        /// <summary>
        /// The amount charged for boarding the plane, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * Encoding: Numeric
        /// * minLength: 1 character
        /// * maxLength: 18 characters
        /// </summary>
        [JsonProperty("airline.boarding_fee", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineBoardingFee { get; set; }

        /// <summary>
        /// The [CRS](https://en.wikipedia.org/wiki/Computer_reservation_system) used to make the reservation and purchase the ticket.
        /// * Encoding: ASCII
        /// * minLength: 4 characters
        /// * maxLength: 4 characters
        /// </summary>
        [JsonProperty("airline.computerized_reservation_system", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineComputerizedReservationSystem { get; set; }

        /// <summary>
        /// The alphanumeric customer reference number.
        /// * Encoding: ASCII
        /// * maxLength: 20 characters
        /// * If you send more than 20 characters, the customer reference number is truncated
        /// * Must not be all spaces
        /// </summary>
        [JsonProperty("airline.customer_reference_number", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineCustomerReferenceNumber { get; set; }

        /// <summary>
        /// A code that identifies the type of item bought. The description of the code can appear on credit card statements.
        /// * Encoding: ASCII
        /// * Example: Passenger ticket = 01
        /// * minLength: 2 characters
        /// * maxLength: 2 characters
        /// </summary>
        [JsonProperty("airline.document_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineDocumentType { get; set; }

        /// <summary>
        /// The flight departure date. Local time `(HH:mm)` is optional.
        /// * Date format: `yyyy-MM-dd`
        /// * Date and time format: `yyyy-MM-dd HH:mm`
        /// * minLength: 10 characters
        /// * maxLength: 16 characters
        /// </summary>
        [JsonProperty("airline.flight_date", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineFlightDate { get; set; }

        /// <summary>
        /// The [IATA](https://www.iata.org/services/pages/codes.aspx) 2-letter accounting code (PAX) that identifies the carrier.
        /// This field is required if the airline data includes leg details.
        /// * Example: KLM = KL
        /// * minLength: 2 characters
        /// * maxLength: 2 characters
        /// * Must not be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("airline.leg.carrier_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineLegCarrierCode { get; set; }

        /// <summary>
        /// A one-letter travel class identifier.
        ///  The following are common:
        ///  * F: first class
        /// * J: business class
        /// * Y: economy class
        /// * W: premium economy
        /// * Encoding: ASCII
        /// * minLength: 1 character
        /// * maxLength: 1 character
        /// * Must not be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("airline.leg.class_of_travel", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineLegClassOfTravel { get; set; }

        /// <summary>
        /// Date and time of travel in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format `yyyy-MM-dd HH:mm`.
        /// * Encoding: ASCII
        /// * minLength: 16 characters
        /// * maxLength: 16 characters
        /// </summary>
        [JsonProperty("airline.leg.date_of_travel", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineLegDateOfTravel { get; set; }

        /// <summary>
        /// The [IATA](https://www.iata.org/services/pages/codes.aspx) three-letter airport code of the departure airport.
        /// This field is required if the airline data includes leg details.
        /// * Encoding: ASCII
        /// * Example: Amsterdam = AMS
        /// * minLength: 3 characters
        /// * maxLength: 3 characters
        /// * Must not be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("airline.leg.depart_airport", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineLegDepartAirport { get; set; }

        /// <summary>
        /// The amount of [departure tax](https://en.wikipedia.org/wiki/Departure_tax) charged, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// * Encoding: Numeric
        /// * minLength: 1
        /// * maxLength: 12
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("airline.leg.depart_tax", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineLegDepartTax { get; set; }

        /// <summary>
        /// The [IATA](https://www.iata.org/services/pages/codes.aspx) 3-letter airport code of the destination airport.
        /// This field is required if the airline data includes leg details.
        /// * Example: Amsterdam = AMS
        /// * Encoding: ASCII
        /// * minLength: 3 characters
        /// * maxLength: 3 characters
        /// * Must not be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("airline.leg.destination_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineLegDestinationCode { get; set; }

        /// <summary>
        /// The [fare basis code](https://en.wikipedia.org/wiki/Fare_basis_code), alphanumeric.
        /// * minLength: 1 character
        /// * maxLength: 6 characters
        /// * Must not be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("airline.leg.fare_base_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineLegFareBaseCode { get; set; }

        /// <summary>
        /// The flight identifier.
        /// * minLength: 1 character
        /// * maxLength: 5 characters
        /// * Must not be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("airline.leg.flight_number", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineLegFlightNumber { get; set; }

        /// <summary>
        /// A one-letter code that indicates whether the passenger is entitled to make a stopover. Can be a space, O if the passenger is entitled to make a stopover, or X if they are not.
        /// * Encoding: ASCII
        /// * minLength: 1 character
        /// * maxLength: 1 character
        /// </summary>
        [JsonProperty("airline.leg.stop_over_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineLegStopOverCode { get; set; }

        /// <summary>
        /// The passenger's date of birth.
        /// Date format: `yyyy-MM-dd`
        /// * minLength: 10
        /// * maxLength: 10
        /// </summary>
        [JsonProperty("airline.passenger.date_of_birth", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlinePassengerDateOfBirth { get; set; }

        /// <summary>
        /// The passenger's first name.
        /// > This field is required if the airline data includes passenger details or leg details.
        /// * Encoding: ASCII
        /// </summary>
        [JsonProperty("airline.passenger.first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlinePassengerFirstName { get; set; }

        /// <summary>
        /// The passenger's last name.
        /// > This field is required if the airline data includes passenger details or leg details.
        /// * Encoding: ASCII
        /// </summary>
        [JsonProperty("airline.passenger.last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlinePassengerLastName { get; set; }

        /// <summary>
        /// The passenger's telephone number, including country code. This is an alphanumeric field that can include the '+' and '-' signs.
        /// * Encoding: ASCII
        /// * minLength: 3 characters
        /// * maxLength: 30 characters
        /// </summary>
        [JsonProperty("airline.passenger.telephone_number", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlinePassengerTelephoneNumber { get; set; }

        /// <summary>
        /// The IATA passenger type code (PTC).
        /// * Encoding: ASCII
        /// * minLength: 3 characters
        /// * maxLength: 6 characters
        /// </summary>
        [JsonProperty("airline.passenger.traveller_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlinePassengerTravellerType { get; set; }

        /// <summary>
        /// The passenger's name, initials, and title.
        /// * Format: last name + first name or initials + title
        /// * Example: *FLYER / MARY MS*
        /// * minLength: 1 character
        /// * maxLength: 20 characters
        /// * If you send more than 20 characters, the name is truncated
        /// * Must not be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("airline.passenger_name")]
        public string AirlinePassengerName { get; set; }

        /// <summary>
        /// The address of the organization that issued the ticket.
        /// * minLength: 0 characters
        /// * maxLength: 16 characters
        /// </summary>
        [JsonProperty("airline.ticket_issue_address", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineTicketIssueAddress { get; set; }

        /// <summary>
        /// The ticket's unique identifier.
        /// * minLength: 1 character
        /// * maxLength: 15 characters
        /// * Must not be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("airline.ticket_number", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineTicketNumber { get; set; }

        /// <summary>
        /// The unique identifier from IATA or ARC for the travel agency that issues the ticket.
        /// * Encoding: ASCII
        /// * minLength: 1 character
        /// * maxLength: 8 characters
        /// * Must not be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("airline.travel_agency_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineTravelAgencyCode { get; set; }

        /// <summary>
        /// The name of the travel agency.
        /// * Encoding: ASCII
        /// * minLength: 1 character
        /// * maxLength: 25 characters
        /// * Must not be all spaces
        /// *Must not be all zeros.
        /// </summary>
        [JsonProperty("airline.travel_agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AirlineTravelAgencyName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalDataAirline : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdditionalDataAirline other &&                ((this.AirlineAgencyInvoiceNumber == null && other.AirlineAgencyInvoiceNumber == null) || (this.AirlineAgencyInvoiceNumber?.Equals(other.AirlineAgencyInvoiceNumber) == true)) &&
                ((this.AirlineAgencyPlanName == null && other.AirlineAgencyPlanName == null) || (this.AirlineAgencyPlanName?.Equals(other.AirlineAgencyPlanName) == true)) &&
                ((this.AirlineAirlineCode == null && other.AirlineAirlineCode == null) || (this.AirlineAirlineCode?.Equals(other.AirlineAirlineCode) == true)) &&
                ((this.AirlineAirlineDesignatorCode == null && other.AirlineAirlineDesignatorCode == null) || (this.AirlineAirlineDesignatorCode?.Equals(other.AirlineAirlineDesignatorCode) == true)) &&
                ((this.AirlineBoardingFee == null && other.AirlineBoardingFee == null) || (this.AirlineBoardingFee?.Equals(other.AirlineBoardingFee) == true)) &&
                ((this.AirlineComputerizedReservationSystem == null && other.AirlineComputerizedReservationSystem == null) || (this.AirlineComputerizedReservationSystem?.Equals(other.AirlineComputerizedReservationSystem) == true)) &&
                ((this.AirlineCustomerReferenceNumber == null && other.AirlineCustomerReferenceNumber == null) || (this.AirlineCustomerReferenceNumber?.Equals(other.AirlineCustomerReferenceNumber) == true)) &&
                ((this.AirlineDocumentType == null && other.AirlineDocumentType == null) || (this.AirlineDocumentType?.Equals(other.AirlineDocumentType) == true)) &&
                ((this.AirlineFlightDate == null && other.AirlineFlightDate == null) || (this.AirlineFlightDate?.Equals(other.AirlineFlightDate) == true)) &&
                ((this.AirlineLegCarrierCode == null && other.AirlineLegCarrierCode == null) || (this.AirlineLegCarrierCode?.Equals(other.AirlineLegCarrierCode) == true)) &&
                ((this.AirlineLegClassOfTravel == null && other.AirlineLegClassOfTravel == null) || (this.AirlineLegClassOfTravel?.Equals(other.AirlineLegClassOfTravel) == true)) &&
                ((this.AirlineLegDateOfTravel == null && other.AirlineLegDateOfTravel == null) || (this.AirlineLegDateOfTravel?.Equals(other.AirlineLegDateOfTravel) == true)) &&
                ((this.AirlineLegDepartAirport == null && other.AirlineLegDepartAirport == null) || (this.AirlineLegDepartAirport?.Equals(other.AirlineLegDepartAirport) == true)) &&
                ((this.AirlineLegDepartTax == null && other.AirlineLegDepartTax == null) || (this.AirlineLegDepartTax?.Equals(other.AirlineLegDepartTax) == true)) &&
                ((this.AirlineLegDestinationCode == null && other.AirlineLegDestinationCode == null) || (this.AirlineLegDestinationCode?.Equals(other.AirlineLegDestinationCode) == true)) &&
                ((this.AirlineLegFareBaseCode == null && other.AirlineLegFareBaseCode == null) || (this.AirlineLegFareBaseCode?.Equals(other.AirlineLegFareBaseCode) == true)) &&
                ((this.AirlineLegFlightNumber == null && other.AirlineLegFlightNumber == null) || (this.AirlineLegFlightNumber?.Equals(other.AirlineLegFlightNumber) == true)) &&
                ((this.AirlineLegStopOverCode == null && other.AirlineLegStopOverCode == null) || (this.AirlineLegStopOverCode?.Equals(other.AirlineLegStopOverCode) == true)) &&
                ((this.AirlinePassengerDateOfBirth == null && other.AirlinePassengerDateOfBirth == null) || (this.AirlinePassengerDateOfBirth?.Equals(other.AirlinePassengerDateOfBirth) == true)) &&
                ((this.AirlinePassengerFirstName == null && other.AirlinePassengerFirstName == null) || (this.AirlinePassengerFirstName?.Equals(other.AirlinePassengerFirstName) == true)) &&
                ((this.AirlinePassengerLastName == null && other.AirlinePassengerLastName == null) || (this.AirlinePassengerLastName?.Equals(other.AirlinePassengerLastName) == true)) &&
                ((this.AirlinePassengerTelephoneNumber == null && other.AirlinePassengerTelephoneNumber == null) || (this.AirlinePassengerTelephoneNumber?.Equals(other.AirlinePassengerTelephoneNumber) == true)) &&
                ((this.AirlinePassengerTravellerType == null && other.AirlinePassengerTravellerType == null) || (this.AirlinePassengerTravellerType?.Equals(other.AirlinePassengerTravellerType) == true)) &&
                ((this.AirlinePassengerName == null && other.AirlinePassengerName == null) || (this.AirlinePassengerName?.Equals(other.AirlinePassengerName) == true)) &&
                ((this.AirlineTicketIssueAddress == null && other.AirlineTicketIssueAddress == null) || (this.AirlineTicketIssueAddress?.Equals(other.AirlineTicketIssueAddress) == true)) &&
                ((this.AirlineTicketNumber == null && other.AirlineTicketNumber == null) || (this.AirlineTicketNumber?.Equals(other.AirlineTicketNumber) == true)) &&
                ((this.AirlineTravelAgencyCode == null && other.AirlineTravelAgencyCode == null) || (this.AirlineTravelAgencyCode?.Equals(other.AirlineTravelAgencyCode) == true)) &&
                ((this.AirlineTravelAgencyName == null && other.AirlineTravelAgencyName == null) || (this.AirlineTravelAgencyName?.Equals(other.AirlineTravelAgencyName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AirlineAgencyInvoiceNumber = {(this.AirlineAgencyInvoiceNumber == null ? "null" : this.AirlineAgencyInvoiceNumber)}");
            toStringOutput.Add($"this.AirlineAgencyPlanName = {(this.AirlineAgencyPlanName == null ? "null" : this.AirlineAgencyPlanName)}");
            toStringOutput.Add($"this.AirlineAirlineCode = {(this.AirlineAirlineCode == null ? "null" : this.AirlineAirlineCode)}");
            toStringOutput.Add($"this.AirlineAirlineDesignatorCode = {(this.AirlineAirlineDesignatorCode == null ? "null" : this.AirlineAirlineDesignatorCode)}");
            toStringOutput.Add($"this.AirlineBoardingFee = {(this.AirlineBoardingFee == null ? "null" : this.AirlineBoardingFee)}");
            toStringOutput.Add($"this.AirlineComputerizedReservationSystem = {(this.AirlineComputerizedReservationSystem == null ? "null" : this.AirlineComputerizedReservationSystem)}");
            toStringOutput.Add($"this.AirlineCustomerReferenceNumber = {(this.AirlineCustomerReferenceNumber == null ? "null" : this.AirlineCustomerReferenceNumber)}");
            toStringOutput.Add($"this.AirlineDocumentType = {(this.AirlineDocumentType == null ? "null" : this.AirlineDocumentType)}");
            toStringOutput.Add($"this.AirlineFlightDate = {(this.AirlineFlightDate == null ? "null" : this.AirlineFlightDate)}");
            toStringOutput.Add($"this.AirlineLegCarrierCode = {(this.AirlineLegCarrierCode == null ? "null" : this.AirlineLegCarrierCode)}");
            toStringOutput.Add($"this.AirlineLegClassOfTravel = {(this.AirlineLegClassOfTravel == null ? "null" : this.AirlineLegClassOfTravel)}");
            toStringOutput.Add($"this.AirlineLegDateOfTravel = {(this.AirlineLegDateOfTravel == null ? "null" : this.AirlineLegDateOfTravel)}");
            toStringOutput.Add($"this.AirlineLegDepartAirport = {(this.AirlineLegDepartAirport == null ? "null" : this.AirlineLegDepartAirport)}");
            toStringOutput.Add($"this.AirlineLegDepartTax = {(this.AirlineLegDepartTax == null ? "null" : this.AirlineLegDepartTax)}");
            toStringOutput.Add($"this.AirlineLegDestinationCode = {(this.AirlineLegDestinationCode == null ? "null" : this.AirlineLegDestinationCode)}");
            toStringOutput.Add($"this.AirlineLegFareBaseCode = {(this.AirlineLegFareBaseCode == null ? "null" : this.AirlineLegFareBaseCode)}");
            toStringOutput.Add($"this.AirlineLegFlightNumber = {(this.AirlineLegFlightNumber == null ? "null" : this.AirlineLegFlightNumber)}");
            toStringOutput.Add($"this.AirlineLegStopOverCode = {(this.AirlineLegStopOverCode == null ? "null" : this.AirlineLegStopOverCode)}");
            toStringOutput.Add($"this.AirlinePassengerDateOfBirth = {(this.AirlinePassengerDateOfBirth == null ? "null" : this.AirlinePassengerDateOfBirth)}");
            toStringOutput.Add($"this.AirlinePassengerFirstName = {(this.AirlinePassengerFirstName == null ? "null" : this.AirlinePassengerFirstName)}");
            toStringOutput.Add($"this.AirlinePassengerLastName = {(this.AirlinePassengerLastName == null ? "null" : this.AirlinePassengerLastName)}");
            toStringOutput.Add($"this.AirlinePassengerTelephoneNumber = {(this.AirlinePassengerTelephoneNumber == null ? "null" : this.AirlinePassengerTelephoneNumber)}");
            toStringOutput.Add($"this.AirlinePassengerTravellerType = {(this.AirlinePassengerTravellerType == null ? "null" : this.AirlinePassengerTravellerType)}");
            toStringOutput.Add($"this.AirlinePassengerName = {(this.AirlinePassengerName == null ? "null" : this.AirlinePassengerName)}");
            toStringOutput.Add($"this.AirlineTicketIssueAddress = {(this.AirlineTicketIssueAddress == null ? "null" : this.AirlineTicketIssueAddress)}");
            toStringOutput.Add($"this.AirlineTicketNumber = {(this.AirlineTicketNumber == null ? "null" : this.AirlineTicketNumber)}");
            toStringOutput.Add($"this.AirlineTravelAgencyCode = {(this.AirlineTravelAgencyCode == null ? "null" : this.AirlineTravelAgencyCode)}");
            toStringOutput.Add($"this.AirlineTravelAgencyName = {(this.AirlineTravelAgencyName == null ? "null" : this.AirlineTravelAgencyName)}");
        }
    }
}