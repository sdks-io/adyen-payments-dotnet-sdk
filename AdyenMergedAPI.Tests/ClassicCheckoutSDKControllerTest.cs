// <copyright file="ClassicCheckoutSDKControllerTest.cs" company="APIMatic">
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
    /// ClassicCheckoutSDKControllerTest.
    /// </summary>
    [TestFixture]
    public class ClassicCheckoutSDKControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ClassicCheckoutSDKController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ClassicCheckoutSDKController;
        }

        /// <summary>
        /// Provides the data object that can be used to start the Checkout SDK. To set up the payment, pass its amount, currency, and other required parameters. We use this to optimise the payment flow and perform better risk assessment of the transaction.
        ///
        ///For more information, refer to [How it works](https://docs.adyen.com/online-payments#howitworks)..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostPaymentSession()
        {
            // Parameters for the API call
            string idempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed";
            Standard.Models.PaymentSetupRequest body = ApiHelper.JsonDeserialize<Standard.Models.PaymentSetupRequest>("{\"amount\":{\"currency\":\"EUR\",\"value\":17408},\"reference\":\"Your order number\",\"shopperReference\":\"YOUR_SHOPPER_REFERENCE\",\"channel\":\"Android\",\"token\":\"TOKEN_YOU_GET_FROM_CHECKOUT_SDK\",\"returnUrl\":\"app://\",\"countryCode\":\"NL\",\"shopperLocale\":\"nl_NL\",\"sessionValidity\":\"2017-04-06T13:09:13Z\",\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\"}");

            // Perform API call
            Standard.Models.PaymentSetupResponse result = null;
            try
            {
                result = await this.controller.PostPaymentSessionAsync(idempotencyKey, body);
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
                    "{\"paymentSession\":\"eyJjaGVja291dHNob3BwZXJCYXN...\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Verifies the payment result using the payload returned from the Checkout SDK.
        ///
        ///For more information, refer to [How it works](https://docs.adyen.com/online-payments#howitworks)..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostPaymentsResult()
        {
            // Parameters for the API call
            string idempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed";
            Standard.Models.PaymentVerificationRequest body = ApiHelper.JsonDeserialize<Standard.Models.PaymentVerificationRequest>("{\"payload\":\"VALUE_YOU_GET_FROM_CHECKOUT_SDK\"}");

            // Perform API call
            Standard.Models.PaymentVerificationResponse result = null;
            try
            {
                result = await this.controller.PostPaymentsResultAsync(idempotencyKey, body);
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
                    "{\"authResponse\":\"Authorised\",\"pspReference\":\"V4HZ4RBFJGXXGN82\",\"merchantReference\":\"Your order number\",\"shopperLocale\":\"nl_NL\",\"paymentMethod\":\"ideal\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}