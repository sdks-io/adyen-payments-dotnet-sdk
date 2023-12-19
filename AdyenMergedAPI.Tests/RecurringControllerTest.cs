// <copyright file="RecurringControllerTest.cs" company="APIMatic">
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
    /// RecurringControllerTest.
    /// </summary>
    [TestFixture]
    public class RecurringControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private RecurringController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.RecurringController;
        }

        /// <summary>
        /// Lists the tokens for stored payment details for the shopper identified in the path, if there are any available. The token ID can be used with payment requests for the shopper's payment. A summary of the stored details is included.
        ///
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetStoredPaymentMethods()
        {
            // Parameters for the API call
            string shopperReference = null;
            string merchantAccount = null;

            // Perform API call
            Standard.Models.ListStoredPaymentMethodsResponse result = null;
            try
            {
                result = await this.controller.GetStoredPaymentMethodsAsync(shopperReference, merchantAccount);
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
                    "{\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\",\"shopperReference\":\"YOUR_SHOPPER_REFERENCE\",\"storedPaymentMethods\":[{\"brand\":\"visa\",\"expiryMonth\":\"10\",\"expiryYear\":\"30\",\"holderName\":\"John Smith\",\"id\":\"7219687191761347\",\"issuerName\":\"ISSUER_NAME\",\"lastFour\":\"1111\",\"name\":\"VISA\",\"shopperEmail\":\"john.smith@example.com\",\"shopperReference\":\"YOUR_SHOPPER_REFERENCE\",\"supportedRecurringProcessingModels\":[\"CardOnFile\",\"Subscription\",\"UnscheduledCardOnFile\"],\"type\":\"scheme\"}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}