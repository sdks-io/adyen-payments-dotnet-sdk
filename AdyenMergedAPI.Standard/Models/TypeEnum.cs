// <copyright file="TypeEnum.cs" company="APIMatic">
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
    /// TypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// BalanceAccount.
        /// </summary>
        [EnumMember(Value = "BalanceAccount")]
        BalanceAccount,

        /// <summary>
        /// Commission.
        /// </summary>
        [EnumMember(Value = "Commission")]
        Commission,

        /// <summary>
        /// Default.
        /// </summary>
        [EnumMember(Value = "Default")]
        Default,

        /// <summary>
        /// MarketPlace.
        /// </summary>
        [EnumMember(Value = "MarketPlace")]
        MarketPlace,

        /// <summary>
        /// PaymentFee.
        /// </summary>
        [EnumMember(Value = "PaymentFee")]
        PaymentFee,

        /// <summary>
        /// Remainder.
        /// </summary>
        [EnumMember(Value = "Remainder")]
        Remainder,

        /// <summary>
        /// Surcharge.
        /// </summary>
        [EnumMember(Value = "Surcharge")]
        Surcharge,

        /// <summary>
        /// Tip.
        /// </summary>
        [EnumMember(Value = "Tip")]
        Tip,

        /// <summary>
        /// VAT.
        /// </summary>
        [EnumMember(Value = "VAT")]
        VAT
    }
}