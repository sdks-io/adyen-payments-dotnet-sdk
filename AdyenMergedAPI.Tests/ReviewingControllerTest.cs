// <copyright file="ReviewingControllerTest.cs" company="APIMatic">
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
    /// ReviewingControllerTest.
    /// </summary>
    [TestFixture]
    public class ReviewingControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ReviewingController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ReviewingController;
        }

        /// <summary>
        /// Confirms a previously submitted payout.
        ///
        ///To cancel a payout, use the `/declineThirdParty` endpoint..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostConfirmThirdParty()
        {
            // Parameters for the API call
            Standard.Models.ModifyRequest body = ApiHelper.JsonDeserialize<Standard.Models.ModifyRequest>("{\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\",\"originalReference\":\"9913140798220028\"}");

            // Perform API call
            Standard.Models.ModifyResponse result = null;
            try
            {
                result = await this.controller.PostConfirmThirdPartyAsync(body);
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
                    "{\"pspReference\":\"991617894325358C\",\"response\":\"[payout-confirm-received]\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Cancels a previously submitted payout.
        ///
        ///To confirm and send a payout, use the `/confirmThirdParty` endpoint..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostDeclineThirdParty()
        {
            // Parameters for the API call
            Standard.Models.ModifyRequest body = ApiHelper.JsonDeserialize<Standard.Models.ModifyRequest>("{\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\",\"originalReference\":\"9913140798220028\"}");

            // Perform API call
            Standard.Models.ModifyResponse result = null;
            try
            {
                result = await this.controller.PostDeclineThirdPartyAsync(body);
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
                    "{\"pspReference\":\"991617894325360J\",\"response\":\"[payout-decline-received]\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}