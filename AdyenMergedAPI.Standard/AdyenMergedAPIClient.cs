// <copyright file="AdyenMergedAPIClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdyenMergedAPI.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using APIMatic.Core;
    using APIMatic.Core.Authentication;
    using APIMatic.Core.Types;
    using AdyenMergedAPI.Standard.Authentication;
    using AdyenMergedAPI.Standard.Controllers;
    using AdyenMergedAPI.Standard.Http.Client;
    using AdyenMergedAPI.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class AdyenMergedAPIClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://pal-test.adyen.com/pal/servlet/Payment/v68" },
                    { Server.Default1, "https://pal-test.adyen.com/pal/servlet/Payout/v68" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
        private readonly HttpCallBack httpCallBack;
        private readonly BasicAuthManager basicAuthManager;
        private readonly Lazy<PaymentsController> payments;
        private readonly Lazy<ModificationsController> modifications;
        private readonly Lazy<InitializationController> initialization;
        private readonly Lazy<ReviewingController> reviewing;
        private readonly Lazy<InstantPayoutsController> instantPayouts;

        private AdyenMergedAPIClient(
            string xAPIKey,
            Environment environment,
            string basicAuthUserName,
            string basicAuthPassword,
            HttpCallBack httpCallBack,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.XAPIKey = xAPIKey;
            this.Environment = environment;
            this.httpCallBack = httpCallBack;
            this.HttpClientConfiguration = httpClientConfiguration;
            basicAuthManager = new BasicAuthManager(basicAuthUserName, basicAuthPassword);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                        {"global", basicAuthManager}
                })
                .ApiCallback(httpCallBack)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .Parameters(globalParameter => globalParameter
                    .Header(headerParameter => headerParameter.Setup("X-API-Key", this.XAPIKey))
)
                .UserAgent(userAgent)
                .Build();


            this.payments = new Lazy<PaymentsController>(
                () => new PaymentsController(globalConfiguration));
            this.modifications = new Lazy<ModificationsController>(
                () => new ModificationsController(globalConfiguration));
            this.initialization = new Lazy<InitializationController>(
                () => new InitializationController(globalConfiguration));
            this.reviewing = new Lazy<ReviewingController>(
                () => new ReviewingController(globalConfiguration));
            this.instantPayouts = new Lazy<InstantPayoutsController>(
                () => new InstantPayoutsController(globalConfiguration));
        }

        /// <summary>
        /// Gets PaymentsController controller.
        /// </summary>
        public PaymentsController PaymentsController => this.payments.Value;

        /// <summary>
        /// Gets ModificationsController controller.
        /// </summary>
        public ModificationsController ModificationsController => this.modifications.Value;

        /// <summary>
        /// Gets InitializationController controller.
        /// </summary>
        public InitializationController InitializationController => this.initialization.Value;

        /// <summary>
        /// Gets ReviewingController controller.
        /// </summary>
        public ReviewingController ReviewingController => this.reviewing.Value;

        /// <summary>
        /// Gets InstantPayoutsController controller.
        /// </summary>
        public InstantPayoutsController InstantPayoutsController => this.instantPayouts.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets XAPIKey.
        /// API Key.
        /// </summary>
        public string XAPIKey { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        internal HttpCallBack HttpCallBack => this.httpCallBack;

        /// <summary>
        /// Gets the credentials to use with BasicAuth.
        /// </summary>
        public IBasicAuthCredentials BasicAuthCredentials => this.basicAuthManager;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the AdyenMergedAPIClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .XAPIKey(this.XAPIKey)
                .Environment(this.Environment)
                .BasicAuthCredentials(basicAuthManager.BasicAuthUserName, basicAuthManager.BasicAuthPassword)
                .HttpCallBack(httpCallBack)
                .HttpClientConfig(config => config.Build());

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"XAPIKey = {this.XAPIKey}, " +
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> AdyenMergedAPIClient.</returns>
        internal static AdyenMergedAPIClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string xAPIKey = System.Environment.GetEnvironmentVariable("ADYEN_MERGED_API_STANDARD_XAPI_KEY");
            string environment = System.Environment.GetEnvironmentVariable("ADYEN_MERGED_API_STANDARD_ENVIRONMENT");
            string basicAuthUserName = System.Environment.GetEnvironmentVariable("ADYEN_MERGED_API_STANDARD_BASIC_AUTH_USER_NAME");
            string basicAuthPassword = System.Environment.GetEnvironmentVariable("ADYEN_MERGED_API_STANDARD_BASIC_AUTH_PASSWORD");

            if (xAPIKey != null)
            {
                builder.XAPIKey(xAPIKey);
            }

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (basicAuthUserName != null && basicAuthPassword != null)
            {
                builder.BasicAuthCredentials(basicAuthUserName, basicAuthPassword);
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private string xAPIKey = String.Empty;
            private Environment environment = AdyenMergedAPI.Standard.Environment.Production;
            private string basicAuthUserName = "";
            private string basicAuthPassword = "";
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallBack httpCallBack;

            /// <summary>
            /// Sets credentials for BasicAuth.
            /// </summary>
            /// <param name="basicAuthUserName">BasicAuthUserName.</param>
            /// <param name="basicAuthPassword">BasicAuthPassword.</param>
            /// <returns>Builder.</returns>
            public Builder BasicAuthCredentials(string basicAuthUserName, string basicAuthPassword)
            {
                this.basicAuthUserName = basicAuthUserName ?? throw new ArgumentNullException(nameof(basicAuthUserName));
                this.basicAuthPassword = basicAuthPassword ?? throw new ArgumentNullException(nameof(basicAuthPassword));
                return this;
            }

            /// <summary>
            /// Sets XAPIKey.
            /// </summary>
            /// <param name="xAPIKey"> XAPIKey. </param>
            /// <returns> Builder. </returns>
            public Builder XAPIKey(string xAPIKey)
            {
                this.xAPIKey = xAPIKey ?? throw new ArgumentNullException(nameof(xAPIKey));
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }

           

            /// <summary>
            /// Sets the HttpCallBack for the Builder.
            /// </summary>
            /// <param name="httpCallBack"> http callback. </param>
            /// <returns>Builder.</returns>
            internal Builder HttpCallBack(HttpCallBack httpCallBack)
            {
                this.httpCallBack = httpCallBack;
                return this;
            }

            /// <summary>
            /// Creates an object of the AdyenMergedAPIClient using the values provided for the builder.
            /// </summary>
            /// <returns>AdyenMergedAPIClient.</returns>
            public AdyenMergedAPIClient Build()
            {

                return new AdyenMergedAPIClient(
                    xAPIKey,
                    environment,
                    basicAuthUserName,
                    basicAuthPassword,
                    httpCallBack,
                    httpClientConfig.Build());
            }
        }
    }
}
