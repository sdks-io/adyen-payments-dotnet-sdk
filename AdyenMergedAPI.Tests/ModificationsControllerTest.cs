// <copyright file="ModificationsControllerTest.cs" company="APIMatic">
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
    /// ModificationsControllerTest.
    /// </summary>
    [TestFixture]
    public class ModificationsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ModificationsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ModificationsController;
        }

        /// <summary>
        /// Allows you to increase or decrease the authorised amount after the initial authorisation has taken place. This functionality enables for example tipping, improving the chances your authorisation will be valid, or charging the shopper when they have already left the merchant premises.
        ///
        ///> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce).
        ///> If you have a [newer integration](https://docs.adyen.com/online-payments), and are doing:
        ///> * [Asynchronous adjustments](https://docs.adyen.com/online-payments/adjust-authorisation#asynchronous-or-synchronous-adjustment), use the [`/payments/{paymentPspReference}/amountUpdates`](https://docs.adyen.com/api-explorer/#/CheckoutService/v67/post/payments/{paymentPspReference}/amountUpdates) endpoint on Checkout API.
        ///> * [Synchronous adjustments](https://docs.adyen.com/online-payments/adjust-authorisation#asynchronous-or-synchronous-adjustment), use this endpoint..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostAdjustAuthorisation()
        {
            // Parameters for the API call
            Standard.Models.AdjustAuthorisationRequest body = ApiHelper.JsonDeserialize<Standard.Models.AdjustAuthorisationRequest>("{\"originalReference\":\"COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE\",\"modificationAmount\":{\"currency\":\"USD\",\"value\":1700},\"reference\":\"YourModificationReference\",\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\"}");

            // Perform API call
            Standard.Models.ModificationResult result = null;
            try
            {
                result = await this.controller.PostAdjustAuthorisationAsync(body);
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
                    "{\"pspReference\":\"851617892360718D\",\"response\":\"[adjustAuthorisation-received]\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Cancels the authorisation hold on a payment, returning a unique reference for this request. You can cancel payments after authorisation only for payment methods that support distinct authorisations and captures.
        ///
        ///For more information, refer to [Cancel](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel).
        ///
        ///> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/{paymentPspReference}/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments/{paymentPspReference}/cancels) endpoint under Checkout API instead..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostCancel()
        {
            // Parameters for the API call
            Standard.Models.CancelRequest body = ApiHelper.JsonDeserialize<Standard.Models.CancelRequest>("{\"originalReference\":\"COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE\",\"reference\":\"YourModificationReference\",\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\"}");

            // Perform API call
            Standard.Models.ModificationResult result = null;
            try
            {
                result = await this.controller.PostCancelAsync(body);
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
        /// Cancels a payment if it has not been captured yet, or refunds it if it has already been captured. This is useful when it is not certain if the payment has been captured or not (for example, when using auto-capture).
        ///
        ///Do not use this endpoint for payments that involve:
        /// * [Multiple partial captures](https://docs.adyen.com/online-payments/capture).
        /// * [Split data](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information) either at time of payment or capture for Adyen for Platforms.
        ///
        /// Instead, check if the payment has been captured and make a corresponding [`/refund`](https://docs.adyen.com/api-explorer/#/Payment/refund) or [`/cancel`](https://docs.adyen.com/api-explorer/#/Payment/cancel) call.
        ///
        ///For more information, refer to [Cancel or refund](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel-or-refund).
        ///
        ///> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments/{paymentPspReference}/reversals) endpoint under Checkout API instead..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostCancelOrRefund()
        {
            // Parameters for the API call
            Standard.Models.CancelOrRefundRequest body = ApiHelper.JsonDeserialize<Standard.Models.CancelOrRefundRequest>("{\"originalReference\":\"COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE\",\"reference\":\"YourModificationReference\",\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\"}");

            // Perform API call
            Standard.Models.ModificationResult result = null;
            try
            {
                result = await this.controller.PostCancelOrRefundAsync(body);
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
                    "{\"pspReference\":\"851617892359708H\",\"response\":\"[cancelOrRefund-received]\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Captures the authorisation hold on a payment, returning a unique reference for this request. Usually the full authorisation amount is captured, however it's also possible to capture a smaller amount, which results in cancelling the remaining authorisation balance.
        ///
        ///Payment methods that are captured automatically after authorisation don't need to be captured. However, submitting a capture request on these transactions will not result in double charges. If immediate or delayed auto-capture is enabled, calling the capture method is not neccessary.
        ///
        ///For more information refer to [Capture](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/capture).
        ///
        ///> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/{paymentPspReference}/captures`](https://docs.adyen.com/api-explorer/#/CheckoutService/v67/post/payments/{paymentPspReference}/captures) endpoint on Checkout API instead.
        ///
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostCapture()
        {
            // Parameters for the API call
            Standard.Models.CaptureRequest body = ApiHelper.JsonDeserialize<Standard.Models.CaptureRequest>("{\"originalReference\":\"COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE\",\"modificationAmount\":{\"value\":500,\"currency\":\"EUR\"},\"reference\":\"YOUR_REFERENCE\",\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\"}");

            // Perform API call
            Standard.Models.ModificationResult result = null;
            try
            {
                result = await this.controller.PostCaptureAsync(body);
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
                    "{\"pspReference\":\"861617892359057J\",\"response\":\"[capture-received]\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Schedules a new payment to be created (including a new authorisation request) for the specified donation using the payment details of the original payment.
        ///
        ///> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/donations`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/donations) endpoint under Checkout API instead..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostDonate()
        {
            // Parameters for the API call
            Standard.Models.DonationRequest body = ApiHelper.JsonDeserialize<Standard.Models.DonationRequest>("{\"originalReference\":\"COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE\",\"modificationAmount\":{\"value\":500,\"currency\":\"EUR\"},\"reference\":\"YOUR_DONATION_REFERENCE\",\"donationAccount\":\"AdyenGivingDemo\",\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\"}");

            // Perform API call
            Standard.Models.ModificationResult result = null;
            try
            {
                result = await this.controller.PostDonateAsync(body);
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
        /// Refunds a payment that has previously been captured, returning a unique reference for this request. Refunding can be done on the full captured amount or a partial amount. Multiple (partial) refunds will be accepted as long as their sum doesn't exceed the captured amount. Payments which have been authorised, but not captured, cannot be refunded, use the /cancel method instead.
        ///
        ///Some payment methods/gateways do not support partial/multiple refunds.
        ///A margin above the captured limit can be configured to cover shipping/handling costs.
        ///
        ///For more information, refer to [Refund](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/refund).
        ///
        ///> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/{paymentPspReference}/refunds`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments/{paymentPspReference}/refunds) endpoint under Checkout API instead..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostRefund()
        {
            // Parameters for the API call
            Standard.Models.RefundRequest body = ApiHelper.JsonDeserialize<Standard.Models.RefundRequest>("{\"originalReference\":\"COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE\",\"modificationAmount\":{\"value\":500,\"currency\":\"EUR\"},\"reference\":\"YOUR_REFERENCE\",\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\"}");

            // Perform API call
            Standard.Models.ModificationResult result = null;
            try
            {
                result = await this.controller.PostRefundAsync(body);
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
                    "{\"pspReference\":\"861617892360059B\",\"response\":\"[refund-received]\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// This endpoint allows you to cancel a payment if you do not have the PSP reference of the original payment request available.
        ///
        ///In your call, refer to the original payment by using the `reference` that you specified in your payment request.
        ///
        ///For more information, see [Technical cancel](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel#technical-cancel). 
        ///
        ///> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/cancels) endpoint under Checkout API instead..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostTechnicalCancel()
        {
            // Parameters for the API call
            Standard.Models.TechnicalCancelRequest body = ApiHelper.JsonDeserialize<Standard.Models.TechnicalCancelRequest>("{\"originalMerchantReference\":\"YOUR_MERCHANT_REFERENCE\",\"reference\":\"YOUR_MODIFICATION_REFERENCE\",\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\"}");

            // Perform API call
            Standard.Models.ModificationResult result = null;
            try
            {
                result = await this.controller.PostTechnicalCancelAsync(body);
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
                    "{\"pspReference\":\"881617892361436J\",\"response\":\"[technical-cancel-received]\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// This endpoint allows you to cancel an unreferenced refund request before it has been completed.
        ///
        ///In your call, you can refer to the original refund request either by using the `tenderReference`, or the `pspReference`. We recommend implementing based on the `tenderReference`, as this is generated for both offline and online transactions.
        ///
        ///For more information, refer to [Cancel an unreferenced refund](https://docs.adyen.com/point-of-sale/refund-payment/cancel-unreferenced)..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostVoidPendingRefund()
        {
            // Parameters for the API call
            Standard.Models.VoidPendingRefundRequest body = ApiHelper.JsonDeserialize<Standard.Models.VoidPendingRefundRequest>("{\"merchantAccount\":\"YOUR_MERCHANT_ACCOUNT\",\"originalReference\":\"9914748988390044\"}");

            // Perform API call
            Standard.Models.ModificationResult result = null;
            try
            {
                result = await this.controller.PostVoidPendingRefundAsync(body);
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
                    "{\"pspReference\":\"861617892360062F\",\"response\":\"[voidPendingRefund-received]\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}