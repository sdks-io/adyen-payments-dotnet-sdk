// <copyright file="AdditionalData3DSecure.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdyenMergedAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using AdyenMergedAPI.Standard;
    using AdyenMergedAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// AdditionalData3DSecure.
    /// </summary>
    public class AdditionalData3DSecure
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalData3DSecure"/> class.
        /// </summary>
        public AdditionalData3DSecure()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalData3DSecure"/> class.
        /// </summary>
        /// <param name="allow3DS2">allow3DS2.</param>
        /// <param name="challengeWindowSize">challengeWindowSize.</param>
        /// <param name="executeThreeD">executeThreeD.</param>
        /// <param name="mpiImplementationType">mpiImplementationType.</param>
        /// <param name="scaExemption">scaExemption.</param>
        /// <param name="threeDSVersion">threeDSVersion.</param>
        public AdditionalData3DSecure(
            string allow3DS2 = null,
            Models.ChallengeWindowSizeEnum? challengeWindowSize = null,
            string executeThreeD = null,
            string mpiImplementationType = null,
            string scaExemption = null,
            string threeDSVersion = null)
        {
            this.Allow3DS2 = allow3DS2;
            this.ChallengeWindowSize = challengeWindowSize;
            this.ExecuteThreeD = executeThreeD;
            this.MpiImplementationType = mpiImplementationType;
            this.ScaExemption = scaExemption;
            this.ThreeDSVersion = threeDSVersion;
        }

        /// <summary>
        /// Indicates if you are able to process 3D Secure 2 transactions natively on your payment page. Send this parameter when you are using `/payments` endpoint with any of our [native 3D Secure 2 solutions](https://docs.adyen.com/online-payments/3d-secure/native-3ds2).
        ///  > This parameter only indicates readiness to support native 3D Secure 2 authentication. To specify if you _want_ to perform 3D Secure, use [Dynamic 3D Secure](/risk-management/dynamic-3d-secure) or send the `executeThreeD` parameter.
        /// Possible values:
        /// * **true** - Ready to support native 3D Secure 2 authentication. Setting this to true does not mean always applying 3D Secure 2. Adyen still selects the version of 3D Secure based on configuration to optimize authorisation rates and improve the shopper's experience.
        /// * **false** – Not ready to support native 3D Secure 2 authentication. Adyen will not offer 3D Secure 2 to your shopper regardless of your configuration.
        /// </summary>
        [JsonProperty("allow3DS2", NullValueHandling = NullValueHandling.Ignore)]
        public string Allow3DS2 { get; set; }

        /// <summary>
        /// Dimensions of the 3DS2 challenge window to be displayed to the cardholder.
        /// Possible values:
        /// * **01** - size of 250x400
        /// * **02** - size of 390x400
        /// * **03** - size of 500x600
        /// * **04** - size of 600x400
        /// * **05** - Fullscreen
        /// </summary>
        [JsonProperty("challengeWindowSize", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChallengeWindowSizeEnum? ChallengeWindowSize { get; set; }

        /// <summary>
        /// Indicates if you want to perform 3D Secure authentication on a transaction.
        ///  > Alternatively, you can use [Dynamic 3D Secure](/risk-management/dynamic-3d-secure) to configure rules for applying 3D Secure.
        /// Possible values:
        /// * **true** – Perform 3D Secure authentication.
        /// * **false** – Don't perform 3D Secure authentication. Note that this setting results in refusals if the issuer mandates 3D Secure because of the PSD2 directive  or other, national regulations.
        /// </summary>
        [JsonProperty("executeThreeD", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteThreeD { get; set; }

        /// <summary>
        /// In case of Secure+, this field must be set to **CUPSecurePlus**.
        /// </summary>
        [JsonProperty("mpiImplementationType", NullValueHandling = NullValueHandling.Ignore)]
        public string MpiImplementationType { get; set; }

        /// <summary>
        /// Indicates the [exemption type](https://docs.adyen.com/payments-fundamentals/psd2-sca-compliance-and-implementation-guide#specifypreferenceinyourapirequest) that you want to request for the transaction.
        ///  Possible values:
        /// * **lowValue**
        /// * **secureCorporate**
        /// * **trustedBeneficiary**
        /// * **transactionRiskAnalysis**
        /// </summary>
        [JsonProperty("scaExemption", NullValueHandling = NullValueHandling.Ignore)]
        public string ScaExemption { get; set; }

        /// <summary>
        /// Indicates your preference for the 3D Secure version.
        /// > If you use this parameter, you override the checks from Adyen's Authentication Engine. We recommend to use this field only if you have an extensive knowledge of 3D Secure.
        /// Possible values:
        /// * **1.0.2**: Apply 3D Secure version 1.0.2.
        /// * **2.1.0**: Apply 3D Secure version 2.1.0.
        /// * **2.2.0**: Apply 3D Secure version 2.2.0. If the issuer does not support version 2.2.0, we will fall back to 2.1.0.
        /// The following rules apply:
        /// * If you prefer 2.1.0 or 2.2.0 but we receive a negative `transStatus` in the `ARes`, we will apply the fallback policy configured in your account. For example, if the configuration is to fall back to 3D Secure 1, we will apply version 1.0.2.
        /// * If you prefer 2.1.0 or 2.2.0 but the BIN is not enrolled, you will receive an error.
        /// </summary>
        [JsonProperty("threeDSVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSVersion { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalData3DSecure : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is AdditionalData3DSecure other &&                ((this.Allow3DS2 == null && other.Allow3DS2 == null) || (this.Allow3DS2?.Equals(other.Allow3DS2) == true)) &&
                ((this.ChallengeWindowSize == null && other.ChallengeWindowSize == null) || (this.ChallengeWindowSize?.Equals(other.ChallengeWindowSize) == true)) &&
                ((this.ExecuteThreeD == null && other.ExecuteThreeD == null) || (this.ExecuteThreeD?.Equals(other.ExecuteThreeD) == true)) &&
                ((this.MpiImplementationType == null && other.MpiImplementationType == null) || (this.MpiImplementationType?.Equals(other.MpiImplementationType) == true)) &&
                ((this.ScaExemption == null && other.ScaExemption == null) || (this.ScaExemption?.Equals(other.ScaExemption) == true)) &&
                ((this.ThreeDSVersion == null && other.ThreeDSVersion == null) || (this.ThreeDSVersion?.Equals(other.ThreeDSVersion) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Allow3DS2 = {(this.Allow3DS2 == null ? "null" : this.Allow3DS2)}");
            toStringOutput.Add($"this.ChallengeWindowSize = {(this.ChallengeWindowSize == null ? "null" : this.ChallengeWindowSize.ToString())}");
            toStringOutput.Add($"this.ExecuteThreeD = {(this.ExecuteThreeD == null ? "null" : this.ExecuteThreeD)}");
            toStringOutput.Add($"this.MpiImplementationType = {(this.MpiImplementationType == null ? "null" : this.MpiImplementationType)}");
            toStringOutput.Add($"this.ScaExemption = {(this.ScaExemption == null ? "null" : this.ScaExemption)}");
            toStringOutput.Add($"this.ThreeDSVersion = {(this.ThreeDSVersion == null ? "null" : this.ThreeDSVersion)}");
        }
    }
}