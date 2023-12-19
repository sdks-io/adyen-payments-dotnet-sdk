// <copyright file="Type25Enum.cs" company="APIMatic">
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
    /// Type25Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type25Enum
    {
        /// <summary>
        /// MolpayEbankingFpxMY.
        /// </summary>
        [EnumMember(Value = "molpay_ebanking_fpx_MY")]
        MolpayEbankingFpxMY,

        /// <summary>
        /// MolpayEbankingTH.
        /// </summary>
        [EnumMember(Value = "molpay_ebanking_TH")]
        MolpayEbankingTH
    }
}