// <copyright file="PaymentLinksControllerTest.cs" company="APIMatic">
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
    /// PaymentLinksControllerTest.
    /// </summary>
    [TestFixture]
    public class PaymentLinksControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private PaymentLinksController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.PaymentLinksController;
        }

        /// <summary>
        /// Creates a payment link to our hosted payment form where shoppers can pay. The list of payment methods presented to the shopper depends on the `currency` and `country` parameters sent in the request.
        ///
        ///For more information, refer to [Pay by Link documentation](https://docs.adyen.com/online-payments/pay-by-link#create-payment-links-through-api)..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostPaymentLinks()
        {
            // Parameters for the API call
            string idempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed";
            Standard.Models.PaymentLinkRequest body = ApiHelper.JsonDeserialize<Standard.Models.PaymentLinkRequest>("{\"reference\":\"YOUR_ORDER_NUMBER\",\"amount\":{\"value\":1250,\"currency\":\"BRL\"},\"countryCode\":\"BR\",\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\",\"shopperReference\":\"YOUR_SHOPPER_REFERENCE\",\"shopperEmail\":\"test@email.com\",\"shopperLocale\":\"pt-BR\",\"billingAddress\":{\"street\":\"Roque Petroni Jr\",\"postalCode\":\"59000060\",\"city\":\"São Paulo\",\"houseNumberOrName\":\"999\",\"country\":\"BR\",\"stateOrProvince\":\"SP\"},\"deliveryAddress\":{\"street\":\"Roque Petroni Jr\",\"postalCode\":\"59000060\",\"city\":\"São Paulo\",\"houseNumberOrName\":\"999\",\"country\":\"BR\",\"stateOrProvince\":\"SP\"}}");

            // Perform API call
            Standard.Models.PaymentLinkResponse result = null;
            try
            {
                result = await this.controller.PostPaymentLinksAsync(idempotencyKey, body);
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
                    "{\"amount\":{\"currency\":\"BRL\",\"value\":1250},\"billingAddress\":{\"city\":\"São Paulo\",\"country\":\"BR\",\"houseNumberOrName\":\"999\",\"postalCode\":\"59000060\",\"stateOrProvince\":\"SP\",\"street\":\"Roque Petroni Jr\"},\"countryCode\":\"BR\",\"deliveryAddress\":{\"city\":\"São Paulo\",\"country\":\"BR\",\"houseNumberOrName\":\"999\",\"postalCode\":\"59000060\",\"stateOrProvince\":\"SP\",\"street\":\"Roque Petroni Jr\"},\"expiresAt\":\"2022-10-28T09:16:22Z\",\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\",\"reference\":\"YOUR_ORDER_NUMBER\",\"reusable\":false,\"shopperEmail\":\"test@email.com\",\"shopperLocale\":\"pt-BR\",\"shopperReference\":\"YOUR_SHOPPER_REFERENCE\",\"id\":\"PLE83C39B0A0DE0C1E\",\"status\":\"active\",\"url\":\"https://test.adyen.link/PLE83C39B0A0DE0C1E\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Creates a payment link to our hosted payment form where shoppers can pay. The list of payment methods presented to the shopper depends on the `currency` and `country` parameters sent in the request.
        ///
        ///For more information, refer to [Pay by Link documentation](https://docs.adyen.com/online-payments/pay-by-link#create-payment-links-through-api)..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostPaymentLinks1()
        {
            // Parameters for the API call
            string idempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed";
            Standard.Models.PaymentLinkRequest body = ApiHelper.JsonDeserialize<Standard.Models.PaymentLinkRequest>("{\"reference\":\"YOUR_ORDER_NUMBER\",\"amount\":{\"value\":1250,\"currency\":\"BRL\"},\"countryCode\":\"BR\",\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\",\"shopperReference\":\"YOUR_SHOPPER_REFERENCE\",\"shopperEmail\":\"test@email.com\",\"shopperLocale\":\"pt-BR\",\"billingAddress\":{\"street\":\"Roque Petroni Jr\",\"postalCode\":\"59000060\",\"city\":\"São Paulo\",\"houseNumberOrName\":\"999\",\"country\":\"BR\",\"stateOrProvince\":\"SP\"},\"deliveryAddress\":{\"street\":\"Roque Petroni Jr\",\"postalCode\":\"59000060\",\"city\":\"São Paulo\",\"houseNumberOrName\":\"999\",\"country\":\"BR\",\"stateOrProvince\":\"SP\"}}");

            // Perform API call
            Standard.Models.PaymentLinkResponse result = null;
            try
            {
                result = await this.controller.PostPaymentLinksAsync(idempotencyKey, body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(201, HttpCallBack.Response.StatusCode, "Status should be 201");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Idempotency-Key", null);
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }
    }
}