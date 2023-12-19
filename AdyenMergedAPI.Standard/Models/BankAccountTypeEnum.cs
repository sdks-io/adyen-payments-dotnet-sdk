// <copyright file="BankAccountTypeEnum.cs" company="APIMatic">
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
    /// BankAccountTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BankAccountTypeEnum
    {
        /// <summary>
        /// Balance.
        /// </summary>
        [EnumMember(Value = "balance")]
        Balance,

        /// <summary>
        /// Checking.
        /// </summary>
        [EnumMember(Value = "checking")]
        Checking,

        /// <summary>
        /// Deposit.
        /// </summary>
        [EnumMember(Value = "deposit")]
        Deposit,

        /// <summary>
        /// General.
        /// </summary>
        [EnumMember(Value = "general")]
        General,

        /// <summary>
        /// Other.
        /// </summary>
        [EnumMember(Value = "other")]
        Other,

        /// <summary>
        /// Payment.
        /// </summary>
        [EnumMember(Value = "payment")]
        Payment,

        /// <summary>
        /// Savings.
        /// </summary>
        [EnumMember(Value = "savings")]
        Savings
    }
}