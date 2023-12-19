using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdyenMergedAPI.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<DonationPaymentRequestPaymentMethod>),
        new Type[] {
            typeof(ApplePayCase),
            typeof(Card1Case),
            typeof(GooglePayDetailsCase),
            typeof(IDEALCase),
            typeof(GooglePayCase)
        },
        true
    )]
    public abstract class DonationPaymentRequestPaymentMethod
    {
        /// <summary>
        /// This is Apple Pay case.
        /// </summary>
        /// <returns>
        /// The DonationPaymentRequestPaymentMethod instance, wrapping the provided ApplePay value.
        /// </returns>
        public static DonationPaymentRequestPaymentMethod FromApplePay(ApplePay applePay)
        {
            return new ApplePayCase().Set(applePay);
        }

        /// <summary>
        /// This is Card1 case.
        /// </summary>
        /// <returns>
        /// The DonationPaymentRequestPaymentMethod instance, wrapping the provided Card1 value.
        /// </returns>
        public static DonationPaymentRequestPaymentMethod FromCard1(Card1 card1)
        {
            return new Card1Case().Set(card1);
        }

        /// <summary>
        /// This is Google Pay Details case.
        /// </summary>
        /// <returns>
        /// The DonationPaymentRequestPaymentMethod instance, wrapping the provided GooglePayDetails value.
        /// </returns>
        public static DonationPaymentRequestPaymentMethod FromGooglePayDetails(GooglePayDetails googlePayDetails)
        {
            return new GooglePayDetailsCase().Set(googlePayDetails);
        }

        /// <summary>
        /// This is iDEAL case.
        /// </summary>
        /// <returns>
        /// The DonationPaymentRequestPaymentMethod instance, wrapping the provided IDEAL value.
        /// </returns>
        public static DonationPaymentRequestPaymentMethod FromIDEAL(IDEAL iDEAL)
        {
            return new IDEALCase().Set(iDEAL);
        }

        /// <summary>
        /// This is Google Pay case.
        /// </summary>
        /// <returns>
        /// The DonationPaymentRequestPaymentMethod instance, wrapping the provided GooglePay value.
        /// </returns>
        public static DonationPaymentRequestPaymentMethod FromGooglePay(GooglePay googlePay)
        {
            return new GooglePayCase().Set(googlePay);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<ApplePay, T> applePay,
            Func<Card1, T> card1,
            Func<GooglePayDetails, T> googlePayDetails,
            Func<IDEAL, T> iDEAL,
            Func<GooglePay, T> googlePay);

        [JsonConverter(typeof(UnionTypeCaseConverter<ApplePayCase, ApplePay>))]
        private sealed class ApplePayCase : DonationPaymentRequestPaymentMethod, ICaseValue<ApplePayCase, ApplePay>
        {
            public ApplePay _value;

            public override T Match<T>(
                Func<ApplePay, T> applePay,
                Func<Card1, T> card1,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<GooglePay, T> googlePay)
            {
                return applePay(_value);
            }

            public ApplePayCase Set(ApplePay value)
            {
                _value = value;
                return this;
            }

            public ApplePay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<Card1Case, Card1>))]
        private sealed class Card1Case : DonationPaymentRequestPaymentMethod, ICaseValue<Card1Case, Card1>
        {
            public Card1 _value;

            public override T Match<T>(
                Func<ApplePay, T> applePay,
                Func<Card1, T> card1,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<GooglePay, T> googlePay)
            {
                return card1(_value);
            }

            public Card1Case Set(Card1 value)
            {
                _value = value;
                return this;
            }

            public Card1 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<GooglePayDetailsCase, GooglePayDetails>))]
        private sealed class GooglePayDetailsCase : DonationPaymentRequestPaymentMethod, ICaseValue<GooglePayDetailsCase, GooglePayDetails>
        {
            public GooglePayDetails _value;

            public override T Match<T>(
                Func<ApplePay, T> applePay,
                Func<Card1, T> card1,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<GooglePay, T> googlePay)
            {
                return googlePayDetails(_value);
            }

            public GooglePayDetailsCase Set(GooglePayDetails value)
            {
                _value = value;
                return this;
            }

            public GooglePayDetails Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<IDEALCase, IDEAL>))]
        private sealed class IDEALCase : DonationPaymentRequestPaymentMethod, ICaseValue<IDEALCase, IDEAL>
        {
            public IDEAL _value;

            public override T Match<T>(
                Func<ApplePay, T> applePay,
                Func<Card1, T> card1,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<GooglePay, T> googlePay)
            {
                return iDEAL(_value);
            }

            public IDEALCase Set(IDEAL value)
            {
                _value = value;
                return this;
            }

            public IDEAL Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<GooglePayCase, GooglePay>))]
        private sealed class GooglePayCase : DonationPaymentRequestPaymentMethod, ICaseValue<GooglePayCase, GooglePay>
        {
            public GooglePay _value;

            public override T Match<T>(
                Func<ApplePay, T> applePay,
                Func<Card1, T> card1,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<GooglePay, T> googlePay)
            {
                return googlePay(_value);
            }

            public GooglePayCase Set(GooglePay value)
            {
                _value = value;
                return this;
            }

            public GooglePay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }
    }
}