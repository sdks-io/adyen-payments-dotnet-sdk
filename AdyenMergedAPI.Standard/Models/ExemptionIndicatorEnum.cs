// <copyright file="ExemptionIndicatorEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdyenMergedAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using AdyenMergedAPI.Standard;
    using AdyenMergedAPI.Standard.Utilities;
    using Newtonsoft.Json;

    /// <summary>
    /// ExemptionIndicatorEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExemptionIndicatorEnum
    {
        /// <summary>
        /// LowValue.
        /// </summary>
        [EnumMember(Value = "lowValue")]
        LowValue,

        /// <summary>
        /// SecureCorporate.
        /// </summary>
        [EnumMember(Value = "secureCorporate")]
        SecureCorporate,

        /// <summary>
        /// TrustedBeneficiary.
        /// </summary>
        [EnumMember(Value = "trustedBeneficiary")]
        TrustedBeneficiary,

        /// <summary>
        /// TransactionRiskAnalysis.
        /// </summary>
        [EnumMember(Value = "transactionRiskAnalysis")]
        TransactionRiskAnalysis
    }
}