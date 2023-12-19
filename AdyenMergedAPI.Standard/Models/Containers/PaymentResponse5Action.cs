using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdyenMergedAPI.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<PaymentResponse5Action>),
        new Type[] {
            typeof(CheckoutAwaitActionCase),
            typeof(CheckoutDelegatedAuthenticationActionCase),
            typeof(CheckoutNativeRedirectActionCase),
            typeof(CheckoutQrCodeActionCase),
            typeof(CheckoutRedirectActionCase),
            typeof(CheckoutSDKActionCase),
            typeof(CheckoutThreeDS2ActionCase),
            typeof(CheckoutVoucherActionCase)
        },
        true
    )]
    public abstract class PaymentResponse5Action
    {
        /// <summary>
        /// This is CheckoutAwaitAction case.
        /// </summary>
        /// <returns>
        /// The PaymentResponse5Action instance, wrapping the provided CheckoutAwaitAction value.
        /// </returns>
        public static PaymentResponse5Action FromCheckoutAwaitAction(CheckoutAwaitAction checkoutAwaitAction)
        {
            return new CheckoutAwaitActionCase().Set(checkoutAwaitAction);
        }

        /// <summary>
        /// This is CheckoutDelegatedAuthenticationAction case.
        /// </summary>
        /// <returns>
        /// The PaymentResponse5Action instance, wrapping the provided CheckoutDelegatedAuthenticationAction value.
        /// </returns>
        public static PaymentResponse5Action FromCheckoutDelegatedAuthenticationAction(CheckoutDelegatedAuthenticationAction checkoutDelegatedAuthenticationAction)
        {
            return new CheckoutDelegatedAuthenticationActionCase().Set(checkoutDelegatedAuthenticationAction);
        }

        /// <summary>
        /// This is CheckoutNativeRedirectAction case.
        /// </summary>
        /// <returns>
        /// The PaymentResponse5Action instance, wrapping the provided CheckoutNativeRedirectAction value.
        /// </returns>
        public static PaymentResponse5Action FromCheckoutNativeRedirectAction(CheckoutNativeRedirectAction checkoutNativeRedirectAction)
        {
            return new CheckoutNativeRedirectActionCase().Set(checkoutNativeRedirectAction);
        }

        /// <summary>
        /// This is CheckoutQrCodeAction case.
        /// </summary>
        /// <returns>
        /// The PaymentResponse5Action instance, wrapping the provided CheckoutQrCodeAction value.
        /// </returns>
        public static PaymentResponse5Action FromCheckoutQrCodeAction(CheckoutQrCodeAction checkoutQrCodeAction)
        {
            return new CheckoutQrCodeActionCase().Set(checkoutQrCodeAction);
        }

        /// <summary>
        /// This is CheckoutRedirectAction case.
        /// </summary>
        /// <returns>
        /// The PaymentResponse5Action instance, wrapping the provided CheckoutRedirectAction value.
        /// </returns>
        public static PaymentResponse5Action FromCheckoutRedirectAction(CheckoutRedirectAction checkoutRedirectAction)
        {
            return new CheckoutRedirectActionCase().Set(checkoutRedirectAction);
        }

        /// <summary>
        /// This is CheckoutSDKAction case.
        /// </summary>
        /// <returns>
        /// The PaymentResponse5Action instance, wrapping the provided CheckoutSDKAction value.
        /// </returns>
        public static PaymentResponse5Action FromCheckoutSDKAction(CheckoutSDKAction checkoutSDKAction)
        {
            return new CheckoutSDKActionCase().Set(checkoutSDKAction);
        }

        /// <summary>
        /// This is CheckoutThreeDS2Action case.
        /// </summary>
        /// <returns>
        /// The PaymentResponse5Action instance, wrapping the provided CheckoutThreeDS2Action value.
        /// </returns>
        public static PaymentResponse5Action FromCheckoutThreeDS2Action(CheckoutThreeDS2Action checkoutThreeDS2Action)
        {
            return new CheckoutThreeDS2ActionCase().Set(checkoutThreeDS2Action);
        }

        /// <summary>
        /// This is CheckoutVoucherAction case.
        /// </summary>
        /// <returns>
        /// The PaymentResponse5Action instance, wrapping the provided CheckoutVoucherAction value.
        /// </returns>
        public static PaymentResponse5Action FromCheckoutVoucherAction(CheckoutVoucherAction checkoutVoucherAction)
        {
            return new CheckoutVoucherActionCase().Set(checkoutVoucherAction);
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
            Func<CheckoutAwaitAction, T> checkoutAwaitAction,
            Func<CheckoutDelegatedAuthenticationAction, T> checkoutDelegatedAuthenticationAction,
            Func<CheckoutNativeRedirectAction, T> checkoutNativeRedirectAction,
            Func<CheckoutQrCodeAction, T> checkoutQrCodeAction,
            Func<CheckoutRedirectAction, T> checkoutRedirectAction,
            Func<CheckoutSDKAction, T> checkoutSDKAction,
            Func<CheckoutThreeDS2Action, T> checkoutThreeDS2Action,
            Func<CheckoutVoucherAction, T> checkoutVoucherAction);

        [JsonConverter(typeof(UnionTypeCaseConverter<CheckoutAwaitActionCase, CheckoutAwaitAction>))]
        private sealed class CheckoutAwaitActionCase : PaymentResponse5Action, ICaseValue<CheckoutAwaitActionCase, CheckoutAwaitAction>
        {
            public CheckoutAwaitAction _value;

            public override T Match<T>(
                Func<CheckoutAwaitAction, T> checkoutAwaitAction,
                Func<CheckoutDelegatedAuthenticationAction, T> checkoutDelegatedAuthenticationAction,
                Func<CheckoutNativeRedirectAction, T> checkoutNativeRedirectAction,
                Func<CheckoutQrCodeAction, T> checkoutQrCodeAction,
                Func<CheckoutRedirectAction, T> checkoutRedirectAction,
                Func<CheckoutSDKAction, T> checkoutSDKAction,
                Func<CheckoutThreeDS2Action, T> checkoutThreeDS2Action,
                Func<CheckoutVoucherAction, T> checkoutVoucherAction)
            {
                return checkoutAwaitAction(_value);
            }

            public CheckoutAwaitActionCase Set(CheckoutAwaitAction value)
            {
                _value = value;
                return this;
            }

            public CheckoutAwaitAction Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CheckoutDelegatedAuthenticationActionCase, CheckoutDelegatedAuthenticationAction>))]
        private sealed class CheckoutDelegatedAuthenticationActionCase : PaymentResponse5Action, ICaseValue<CheckoutDelegatedAuthenticationActionCase, CheckoutDelegatedAuthenticationAction>
        {
            public CheckoutDelegatedAuthenticationAction _value;

            public override T Match<T>(
                Func<CheckoutAwaitAction, T> checkoutAwaitAction,
                Func<CheckoutDelegatedAuthenticationAction, T> checkoutDelegatedAuthenticationAction,
                Func<CheckoutNativeRedirectAction, T> checkoutNativeRedirectAction,
                Func<CheckoutQrCodeAction, T> checkoutQrCodeAction,
                Func<CheckoutRedirectAction, T> checkoutRedirectAction,
                Func<CheckoutSDKAction, T> checkoutSDKAction,
                Func<CheckoutThreeDS2Action, T> checkoutThreeDS2Action,
                Func<CheckoutVoucherAction, T> checkoutVoucherAction)
            {
                return checkoutDelegatedAuthenticationAction(_value);
            }

            public CheckoutDelegatedAuthenticationActionCase Set(CheckoutDelegatedAuthenticationAction value)
            {
                _value = value;
                return this;
            }

            public CheckoutDelegatedAuthenticationAction Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CheckoutNativeRedirectActionCase, CheckoutNativeRedirectAction>))]
        private sealed class CheckoutNativeRedirectActionCase : PaymentResponse5Action, ICaseValue<CheckoutNativeRedirectActionCase, CheckoutNativeRedirectAction>
        {
            public CheckoutNativeRedirectAction _value;

            public override T Match<T>(
                Func<CheckoutAwaitAction, T> checkoutAwaitAction,
                Func<CheckoutDelegatedAuthenticationAction, T> checkoutDelegatedAuthenticationAction,
                Func<CheckoutNativeRedirectAction, T> checkoutNativeRedirectAction,
                Func<CheckoutQrCodeAction, T> checkoutQrCodeAction,
                Func<CheckoutRedirectAction, T> checkoutRedirectAction,
                Func<CheckoutSDKAction, T> checkoutSDKAction,
                Func<CheckoutThreeDS2Action, T> checkoutThreeDS2Action,
                Func<CheckoutVoucherAction, T> checkoutVoucherAction)
            {
                return checkoutNativeRedirectAction(_value);
            }

            public CheckoutNativeRedirectActionCase Set(CheckoutNativeRedirectAction value)
            {
                _value = value;
                return this;
            }

            public CheckoutNativeRedirectAction Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CheckoutQrCodeActionCase, CheckoutQrCodeAction>))]
        private sealed class CheckoutQrCodeActionCase : PaymentResponse5Action, ICaseValue<CheckoutQrCodeActionCase, CheckoutQrCodeAction>
        {
            public CheckoutQrCodeAction _value;

            public override T Match<T>(
                Func<CheckoutAwaitAction, T> checkoutAwaitAction,
                Func<CheckoutDelegatedAuthenticationAction, T> checkoutDelegatedAuthenticationAction,
                Func<CheckoutNativeRedirectAction, T> checkoutNativeRedirectAction,
                Func<CheckoutQrCodeAction, T> checkoutQrCodeAction,
                Func<CheckoutRedirectAction, T> checkoutRedirectAction,
                Func<CheckoutSDKAction, T> checkoutSDKAction,
                Func<CheckoutThreeDS2Action, T> checkoutThreeDS2Action,
                Func<CheckoutVoucherAction, T> checkoutVoucherAction)
            {
                return checkoutQrCodeAction(_value);
            }

            public CheckoutQrCodeActionCase Set(CheckoutQrCodeAction value)
            {
                _value = value;
                return this;
            }

            public CheckoutQrCodeAction Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CheckoutRedirectActionCase, CheckoutRedirectAction>))]
        private sealed class CheckoutRedirectActionCase : PaymentResponse5Action, ICaseValue<CheckoutRedirectActionCase, CheckoutRedirectAction>
        {
            public CheckoutRedirectAction _value;

            public override T Match<T>(
                Func<CheckoutAwaitAction, T> checkoutAwaitAction,
                Func<CheckoutDelegatedAuthenticationAction, T> checkoutDelegatedAuthenticationAction,
                Func<CheckoutNativeRedirectAction, T> checkoutNativeRedirectAction,
                Func<CheckoutQrCodeAction, T> checkoutQrCodeAction,
                Func<CheckoutRedirectAction, T> checkoutRedirectAction,
                Func<CheckoutSDKAction, T> checkoutSDKAction,
                Func<CheckoutThreeDS2Action, T> checkoutThreeDS2Action,
                Func<CheckoutVoucherAction, T> checkoutVoucherAction)
            {
                return checkoutRedirectAction(_value);
            }

            public CheckoutRedirectActionCase Set(CheckoutRedirectAction value)
            {
                _value = value;
                return this;
            }

            public CheckoutRedirectAction Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CheckoutSDKActionCase, CheckoutSDKAction>))]
        private sealed class CheckoutSDKActionCase : PaymentResponse5Action, ICaseValue<CheckoutSDKActionCase, CheckoutSDKAction>
        {
            public CheckoutSDKAction _value;

            public override T Match<T>(
                Func<CheckoutAwaitAction, T> checkoutAwaitAction,
                Func<CheckoutDelegatedAuthenticationAction, T> checkoutDelegatedAuthenticationAction,
                Func<CheckoutNativeRedirectAction, T> checkoutNativeRedirectAction,
                Func<CheckoutQrCodeAction, T> checkoutQrCodeAction,
                Func<CheckoutRedirectAction, T> checkoutRedirectAction,
                Func<CheckoutSDKAction, T> checkoutSDKAction,
                Func<CheckoutThreeDS2Action, T> checkoutThreeDS2Action,
                Func<CheckoutVoucherAction, T> checkoutVoucherAction)
            {
                return checkoutSDKAction(_value);
            }

            public CheckoutSDKActionCase Set(CheckoutSDKAction value)
            {
                _value = value;
                return this;
            }

            public CheckoutSDKAction Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CheckoutThreeDS2ActionCase, CheckoutThreeDS2Action>))]
        private sealed class CheckoutThreeDS2ActionCase : PaymentResponse5Action, ICaseValue<CheckoutThreeDS2ActionCase, CheckoutThreeDS2Action>
        {
            public CheckoutThreeDS2Action _value;

            public override T Match<T>(
                Func<CheckoutAwaitAction, T> checkoutAwaitAction,
                Func<CheckoutDelegatedAuthenticationAction, T> checkoutDelegatedAuthenticationAction,
                Func<CheckoutNativeRedirectAction, T> checkoutNativeRedirectAction,
                Func<CheckoutQrCodeAction, T> checkoutQrCodeAction,
                Func<CheckoutRedirectAction, T> checkoutRedirectAction,
                Func<CheckoutSDKAction, T> checkoutSDKAction,
                Func<CheckoutThreeDS2Action, T> checkoutThreeDS2Action,
                Func<CheckoutVoucherAction, T> checkoutVoucherAction)
            {
                return checkoutThreeDS2Action(_value);
            }

            public CheckoutThreeDS2ActionCase Set(CheckoutThreeDS2Action value)
            {
                _value = value;
                return this;
            }

            public CheckoutThreeDS2Action Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CheckoutVoucherActionCase, CheckoutVoucherAction>))]
        private sealed class CheckoutVoucherActionCase : PaymentResponse5Action, ICaseValue<CheckoutVoucherActionCase, CheckoutVoucherAction>
        {
            public CheckoutVoucherAction _value;

            public override T Match<T>(
                Func<CheckoutAwaitAction, T> checkoutAwaitAction,
                Func<CheckoutDelegatedAuthenticationAction, T> checkoutDelegatedAuthenticationAction,
                Func<CheckoutNativeRedirectAction, T> checkoutNativeRedirectAction,
                Func<CheckoutQrCodeAction, T> checkoutQrCodeAction,
                Func<CheckoutRedirectAction, T> checkoutRedirectAction,
                Func<CheckoutSDKAction, T> checkoutSDKAction,
                Func<CheckoutThreeDS2Action, T> checkoutThreeDS2Action,
                Func<CheckoutVoucherAction, T> checkoutVoucherAction)
            {
                return checkoutVoucherAction(_value);
            }

            public CheckoutVoucherActionCase Set(CheckoutVoucherAction value)
            {
                _value = value;
                return this;
            }

            public CheckoutVoucherAction Get()
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