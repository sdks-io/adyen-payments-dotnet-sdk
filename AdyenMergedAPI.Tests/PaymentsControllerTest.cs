// <copyright file="PaymentsControllerTest.cs" company="APIMatic">
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
    /// PaymentsControllerTest.
    /// </summary>
    [TestFixture]
    public class PaymentsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private PaymentsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.PaymentsController;
        }

        /// <summary>
        /// Creates a payment with a unique reference (`pspReference`) and attempts to obtain an authorisation hold. For cards, this amount can be captured or cancelled later. Non-card payment methods typically don't support this and will automatically capture as part of the authorisation.
        ///> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments) endpoint under Checkout API instead..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostAuthorise()
        {
            // Parameters for the API call
            Standard.Models.PaymentRequest body = ApiHelper.JsonDeserialize<Standard.Models.PaymentRequest>("{\"amount\":{\"currency\":\"USD\",\"value\":1500},\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\",\"reference\":\"YOUR_REFERENCE_NUMBER\",\"threeDS2RequestData\":{\"deviceChannel\":\"browser\",\"notificationURL\":\"https://www.example.com/YOUR_3DS_NOTIFICATION_URL\"},\"browserInfo\":{\"userAgent\":\"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.110 Safari/537.36\",\"acceptHeader\":\"text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8\",\"language\":\"en\",\"colorDepth\":24,\"screenHeight\":723,\"screenWidth\":1536,\"timeZoneOffset\":0,\"javaEnabled\":false},\"billingAddress\":{\"country\":\"US\",\"city\":\"New York\",\"street\":\"Redwood Block\",\"houseNumberOrName\":\"37C\",\"stateOrProvince\":\"NY\",\"postalCode\":\"10039\"},\"accountInfo\":{\"accountCreationDate\":\"2019-01-17T13:42:40+01:00\"},\"shopperEmail\":\"s.hopper@test.com\",\"shopperIP\":\"192.0.2.1\",\"card\":{\"cvc\":\"737\",\"expiryMonth\":\"03\",\"expiryYear\":\"2030\",\"holderName\":\"John Smith\",\"number\":\"4917610000000000\"}}");

            // Perform API call
            Standard.Models.PaymentResult result = null;
            try
            {
                result = await this.controller.PostAuthoriseAsync(body);
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
        /// For an authenticated 3D Secure session, completes the payment authorisation. This endpoint must receive the `md` and `paResponse` parameters that you get from the card issuer after a shopper pays via 3D Secure.
        ///
        ///> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce/3d-secure). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/details`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments/details) endpoint under Checkout API instead..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostAuthorise3d()
        {
            // Parameters for the API call
            Standard.Models.PaymentRequest3d body = ApiHelper.JsonDeserialize<Standard.Models.PaymentRequest3d>("{\"md\":\"31h..........vOXek7w\",\"paResponse\":\"eNqtmF........wGVA4Ch\",\"shopperIP\":\"61.294.12.12\",\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\"}");

            // Perform API call
            Standard.Models.PaymentResult result = null;
            try
            {
                result = await this.controller.PostAuthorise3dAsync(body);
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
        /// For an authenticated 3D Secure 2 session, completes the payment authorisation. This endpoint must receive the `threeDS2Token` and `threeDS2Result` parameters.
        ///
        ///> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce/3d-secure). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/details`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments/details) endpoint under Checkout API instead..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostAuthorise3ds2()
        {
            // Parameters for the API call
            Standard.Models.PaymentRequest3ds2 body = ApiHelper.JsonDeserialize<Standard.Models.PaymentRequest3ds2>("{\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\",\"amount\":{\"currency\":\"EUR\",\"value\":1000},\"reference\":\"YOUR_ORDER_NUMBER\",\"threeDS2RequestData\":{\"deviceChannel\":\"app\",\"threeDSCompInd\":\"Y\"},\"threeDS2Token\":\"— - BINARY DATA - -\"}");

            // Perform API call
            Standard.Models.PaymentResult result = null;
            try
            {
                result = await this.controller.PostAuthorise3ds2Async(body);
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
        /// Return the authentication result after doing a 3D Secure authentication only..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostGetAuthenticationResult()
        {
            // Parameters for the API call
            Standard.Models.AuthenticationResultRequest body = ApiHelper.JsonDeserialize<Standard.Models.AuthenticationResultRequest>("{\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\",\"pspReference\":\"9935272408535455\"}");

            // Perform API call
            Standard.Models.AuthenticationResultResponse result = null;
            try
            {
                result = await this.controller.PostGetAuthenticationResultAsync(body);
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
        /// Retrieves the `threeDS2Result` after doing a 3D Secure 2 authentication only..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostRetrieve3ds2Result()
        {
            // Parameters for the API call
            Standard.Models.ThreeDS2ResultRequest body = ApiHelper.JsonDeserialize<Standard.Models.ThreeDS2ResultRequest>("{\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\",\"pspReference\":\"9935272408535455\"}");

            // Perform API call
            Standard.Models.ThreeDS2ResultResponse result = null;
            try
            {
                result = await this.controller.PostRetrieve3ds2ResultAsync(body);
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