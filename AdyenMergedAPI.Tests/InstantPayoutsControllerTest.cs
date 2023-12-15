// <copyright file="InstantPayoutsControllerTest.cs" company="APIMatic">
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
    using AdyenMergedAPI.Standard.Utilities;
    using APIMatic.Core.Utilities;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;

    /// <summary>
    /// InstantPayoutsControllerTest.
    /// </summary>
    [TestFixture]
    public class InstantPayoutsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private InstantPayoutsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.InstantPayoutsController;
        }

        /// <summary>
        /// With this call, you can pay out to your customers, and funds will be made available within 30 minutes on the cardholder's bank account (this is dependent on whether the issuer supports this functionality). Instant card payouts are only supported for Visa and Mastercard cards..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostPayout()
        {
            // Parameters for the API call
            Standard.Models.PayoutRequest body = ApiHelper.JsonDeserialize<Standard.Models.PayoutRequest>("{\"amount\":{\"value\":2500,\"currency\":\"USD\"},\"card\":{\"number\":\"4111111111111111\",\"expiryMonth\":\"03\",\"expiryYear\":\"2030\",\"holderName\":\"John Smith\"},\"billingAddress\":{\"houseNumberOrName\":\"121\",\"street\":\"Brannan Street\",\"city\":\"Beverly Hills\",\"postalCode\":\"90210\",\"stateOrProvince\":\"CA\",\"country\":\"US\"},\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\",\"reference\":\"P9999999999999999\",\"shopperName\":{\"firstName\":\"John\",\"lastName\":\"Smith\"},\"dateOfBirth\":\"1990-01-01\",\"nationality\":\"NL\"}");

            // Perform API call
            Standard.Models.PayoutResponse result = null;
            try
            {
                result = await this.controller.PostPayoutAsync(body);
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