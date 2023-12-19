// <copyright file="InitializationControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdyenMergedAPI.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using AdyenMergedAPI.Standard;
    using AdyenMergedAPI.Standard.Controllers;
    using AdyenMergedAPI.Standard.Exceptions;
    using AdyenMergedAPI.Standard.Http.Client;
    using AdyenMergedAPI.Standard.Http.Response;
    using AdyenMergedAPI.Standard.Models.Containers;
    using AdyenMergedAPI.Standard.Utilities;
    using APIMatic.Core.Utilities;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;

    /// <summary>
    /// InitializationControllerTest.
    /// </summary>
    [TestFixture]
    public class InitializationControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private InitializationController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.InitializationController;
        }

        /// <summary>
        /// Stores payment details under the `PAYOUT` recurring contract. These payment details can be used later to submit a payout via the `/submitThirdParty` call..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostStoreDetail()
        {
            // Parameters for the API call
            Standard.Models.StoreDetailRequest body = ApiHelper.JsonDeserialize<Standard.Models.StoreDetailRequest>("{\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\",\"recurring\":{\"contract\":\"PAYOUT\"},\"bank\":{\"bankName\":\"AbnAmro\",\"bic\":\"ABNANL2A\",\"countryCode\":\"NL\",\"iban\":\"NL32ABNA0515071439\",\"ownerName\":\"Adyen\",\"bankCity\":\"Amsterdam\",\"taxId\":\"bankTaxId\"},\"shopperEmail\":\"shopper@email.com\",\"shopperReference\":\"YOUR_UNIQUE_SHOPPER_ID\",\"shopperName\":{\"firstName\":\"Adyen\",\"gender\":\"MALE\",\"lastName\":\"Test\"},\"dateOfBirth\":\"1990-01-01\",\"entityType\":\"Company\",\"nationality\":\"NL\",\"billingAddress\":{\"houseNumberOrName\":\"17\",\"street\":\"Teststreet 1\",\"city\":\"Amsterdam\",\"stateOrProvince\":\"NY\",\"country\":\"US\",\"postalCode\":\"12345\"}}");

            // Perform API call
            Standard.Models.StoreDetailResponse result = null;
            try
            {
                result = await this.controller.PostStoreDetailAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"pspReference\":\"991617894326362D\",\"recurringDetailReference\":\"9916178936754752\",\"resultCode\":\"Success\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Submits a payout and stores its details for subsequent payouts.
        ///
        ///The submitted payout must be confirmed or declined either by a reviewer or via `/confirmThirdParty` or `/declineThirdParty` calls..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostStoreDetailAndSubmitThirdParty()
        {
            // Parameters for the API call
            Standard.Models.StoreDetailAndSubmitRequest body = ApiHelper.JsonDeserialize<Standard.Models.StoreDetailAndSubmitRequest>("{\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\",\"recurring\":{\"contract\":\"PAYOUT\"},\"amount\":{\"value\":2000,\"currency\":\"EUR\"},\"bank\":{\"bankName\":\"Commerzbank\",\"iban\":\"DE87123456781234567890\",\"countryCode\":\"DE\",\"ownerName\":\"Simon Hopper\"},\"reference\":\"Your Reference Here\",\"shopperEmail\":\"s.hopper@test.com\",\"shopperIP\":\"61.294.12.12\",\"shopperReference\":\"YOUR_SHOPPER_REFERENCE\",\"shopperName\":{\"firstName\":\"Adyen\",\"gender\":\"MALE\",\"lastName\":\"Test\"},\"dateOfBirth\":\"1990-01-01\",\"entityType\":\"Company\",\"nationality\":\"NL\"}");

            // Perform API call
            Standard.Models.StoreDetailAndSubmitResponse result = null;
            try
            {
                result = await this.controller.PostStoreDetailAndSubmitThirdPartyAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// Submits a payout using the previously stored payment details. To store payment details, use the `/storeDetail` API call.
        ///
        ///The submitted payout must be confirmed or declined either by a reviewer or via `/confirmThirdParty` or `/declineThirdParty` calls..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostSubmitThirdParty()
        {
            // Parameters for the API call
            Standard.Models.SubmitRequest body = ApiHelper.JsonDeserialize<Standard.Models.SubmitRequest>("{\"amount\":{\"currency\":\"EUR\",\"value\":1000},\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\",\"recurring\":{\"contract\":\"PAYOUT\"},\"reference\":\"PayoutPayment-0001\",\"shopperEmail\":\"shopper@email.com\",\"shopperReference\":\"YOUR_UNIQUE_SHOPPER_ID\",\"shopperName\":{\"firstName\":\"Adyen\",\"gender\":\"MALE\",\"lastName\":\"Test\"},\"dateOfBirth\":\"1990-01-01\",\"entityType\":\"Company\",\"nationality\":\"NL\",\"selectedRecurringDetailReference\":\"LATEST\"}");

            // Perform API call
            Standard.Models.SubmitResponse result = null;
            try
            {
                result = await this.controller.PostSubmitThirdPartyAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }
    }
}