// <copyright file="OrdersControllerTest.cs" company="APIMatic">
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
    /// OrdersControllerTest.
    /// </summary>
    [TestFixture]
    public class OrdersControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private OrdersController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.OrdersController;
        }

        /// <summary>
        /// Creates an order to be used for partial payments. Make a POST `/orders` call before making a `/payments` call when processing payments with different payment methods..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostOrders()
        {
            // Parameters for the API call
            string idempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed";
            Standard.Models.CreateOrderRequest body = ApiHelper.JsonDeserialize<Standard.Models.CreateOrderRequest>("{\"reference\":\"YOUR_ORDER_REFERENCE\",\"amount\":{\"value\":2500,\"currency\":\"EUR\"},\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\"}");

            // Perform API call
            Standard.Models.CreateOrderResponse result = null;
            try
            {
                result = await this.controller.PostOrdersAsync(idempotencyKey, body);
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
                    "{\"pspReference\":\"8616178914061985\",\"resultCode\":\"Success\",\"expiresAt\":\"2021-04-09T14:16:46Z\",\"orderData\":\"Ab02b4c0!BQABAgCxXvknCldOcRElkxY8Za7iyym4Wv8aDzyNwmj/3nh4G6YtwnUIJHaK62NlN4oIsACdkn1FEjBwKlheG40jvXcYGBk4KFV5WvOhTVCpv/KXnkrI7xQv/u2lE7U4wA+HPB6K4Zj2L8xO/ogZi+zGZqFs5m16jmkH7ku6FzXygXLNuUCuOlmlXSZhdkHHTNVQSq1MELDK9OL74y532ETRPTCNxx8WlEiZB+LDqYrPvH9GgigtD5kw8Do45jfFfG72kWBEgfYqp4mbUmBB9ebXFYZKfF0qvW1x7A2Y9+/MFlTIdXfKW484bJeDBCTTrmKGXIj+U4r5imr5fXTyNLcrxyUqwrb9jg+5B4qg1XB6Cgj5UPlSI4O62I7v0s5TTj69dzLwUQRxSQbwLrZVGYavXzeVKI54BVLRV3d/+BbPvTqnTo34UhfZbPlOx9F2eyaS0ZXdOKnHw89uGUgxUpLsMqnbRysi/pxpZaulel+0mExb68wVxb/7Teob5eRG4gp7cfZVZs6tLXOYWL+W0TqIlsa3hWsfM0LeaovzkoDtW/pK5JABXwMtLig9tsxoEh9ONYtIzkXC21LZ8ebiuSIMaPizjF8yca+QxrCZalQsu6uKnBz/mm8nnsflaGU2QS5zcoxk1RudL1Bl36LM9UZGPpFEYWiYA4sUsnNLw7peJjWCGhDepnwMv4TlgsEtoDtz1T54AEp7ImtleSI6IkFGMEFBQTEwM0NBNTM3RUFFRDg3QzI0REQ1MzkwOUI4MEE3OEE5MjNFMzgyM0Q2OERBQ0M5NEI5RkY4MzA1REMifRslOdmfgUHTXl66WPD9xoW2whIeRx/jR++2MqNE16x6zQy+KtDN8/h60crZwmqkjVTQYqQlsYSYDHSIyb4wnnay16/5il1yS7vN3UCLaTXjYBIAyyx6Wr9j4P3CI/etB+PpviHoESC4mV6ZN4whMDQyziQ8s230GtboXbh42qND7rk9phySBogowQlXrtF+l2n2F46nyif0owEgik5fGARfvjZtY2w23s30KMLNwU4gWSvX4H6RMVS8TfZH2fKfNrwB3tZUXwYkELs5ntaHysswq5Mn5aq2BKAMHu/Rh/wureMSI73Qi0avjrzWCwzt3JH4wnzErMnOZwSdgA==\",\"reference\":\"shopper-reference-ekvL83\",\"remainingAmount\":{\"currency\":\"EUR\",\"value\":2500},\"amount\":{\"currency\":\"EUR\",\"value\":300}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Cancels an order. Cancellation of an order results in an automatic rollback of all payments made in the order, either by canceling or refunding the payment, depending on the type of payment method..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostOrdersCancel()
        {
            // Parameters for the API call
            string idempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed";
            Standard.Models.CancelOrderRequest body = ApiHelper.JsonDeserialize<Standard.Models.CancelOrderRequest>("{\"order\":{\"pspReference\":\"8815517812932012\",\"orderData\":\"823fh892f8f18f4...148f13f9f3f\"},\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\"}");

            // Perform API call
            Standard.Models.CancelOrderResponse result = null;
            try
            {
                result = await this.controller.PostOrdersCancelAsync(idempotencyKey, body);
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
                    "{\"pspReference\":\"8816178914079738\",\"resultCode\":\"Received\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves the balance remaining on a shopper's gift card. To check a gift card's balance, make a POST `/paymentMethods/balance` call and include the gift card's details inside a `paymentMethod` object..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostPaymentMethodsBalance()
        {
            // Parameters for the API call
            string idempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed";
            Standard.Models.BalanceCheckRequest body = ApiHelper.JsonDeserialize<Standard.Models.BalanceCheckRequest>("{\"paymentMethod\":{\"type\":\"givex\",\"number\":\"4126491073027401\",\"cvc\":\"737\"},\"amount\":{\"currency\":\"EUR\",\"value\":1000},\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\"}");

            // Perform API call
            Standard.Models.BalanceCheckResponse result = null;
            try
            {
                result = await this.controller.PostPaymentMethodsBalanceAsync(idempotencyKey, body);
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
                    "{\"pspReference\":\"KHQC5N7G84BLNK43\",\"resultCode\":\"Success\",\"balance\":{\"currency\":\"EUR\",\"value\":5000}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}