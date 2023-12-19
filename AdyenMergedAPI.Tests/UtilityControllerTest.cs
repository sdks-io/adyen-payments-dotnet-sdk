// <copyright file="UtilityControllerTest.cs" company="APIMatic">
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
    /// UtilityControllerTest.
    /// </summary>
    [TestFixture]
    public class UtilityControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private UtilityController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.UtilityController;
        }

        /// <summary>
        /// You need to use this endpoint if you have an API-only integration with Apple Pay which uses Adyen's Apple Pay certificate.
        ///
        ///The endpoint returns the Apple Pay session data which you need to complete the [Apple Pay session validation](https://docs.adyen.com/payment-methods/apple-pay/api-only?tab=adyen-certificate-validation_1#complete-apple-pay-session-validation)..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostApplePaySessions()
        {
            // Parameters for the API call
            string idempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed";
            Standard.Models.ApplePaySessionRequest body = ApiHelper.JsonDeserialize<Standard.Models.ApplePaySessionRequest>("{\"displayName\":\"YOUR_MERCHANT_NAME\",\"domainName\":\"YOUR_DOMAIN_NAME\",\"merchantIdentifier\":\"YOUR_MERCHANT_ID\"}");

            // Perform API call
            Standard.Models.ApplePaySessionResponse result = null;
            try
            {
                result = await this.controller.PostApplePaySessionsAsync(idempotencyKey, body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Idempotency-Key", null);
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
                    "{\"data\":\"eyJ2Z...\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// This operation takes the origin domains and returns a JSON object containing the corresponding origin keys for the domains. 
        ///> If you're still using origin key for your Web Drop-in or Components integration, we recommend [switching to client key](https://docs.adyen.com/development-resources/client-side-authentication/migrate-from-origin-key-to-client-key). This allows you to use a single key for all origins, add or remove origins without generating a new key, and detect the card type from the number entered in your payment form. .
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostOriginKeys()
        {
            // Parameters for the API call
            string idempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed";
            Standard.Models.UtilityRequest body = ApiHelper.JsonDeserialize<Standard.Models.UtilityRequest>("{\"originDomains\":[\"https://www.your-domain1.com\",\"https://www.your-domain2.com\",\"https://www.your-domain3.com\"]}");

            // Perform API call
            Standard.Models.UtilityResponse result = null;
            try
            {
                result = await this.controller.PostOriginKeysAsync(idempotencyKey, body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Idempotency-Key", null);
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
                    "{\"originKeys\":{\"https://www.your-domain1.com\":\"pub.v2.8116178901076090.aHR0cHM6Ly93d3cueW91ci1kb21haW4xLmNvbQ.pvbYlrXz0ICP4kwMJXDGDLVMqALhwXr1MSRjT-fkhvw\",\"https://www.your-domain3.com\":\"pub.v2.8116178901076090.aHR0cHM6Ly93d3cueW91ci1kb21haW4zLmNvbQ.FrTpVz7_RzAywKasM0kXCRoMfoMkKIKaxjFymRGORIc\",\"https://www.your-domain2.com\":\"pub.v2.8116178901076090.aHR0cHM6Ly93d3cueW91ci1kb21haW4yLmNvbQ.LdN9kvJ35fYFFiBSJA4idMnwwxJ5_yXpeNS__Ap5wkg\"}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}