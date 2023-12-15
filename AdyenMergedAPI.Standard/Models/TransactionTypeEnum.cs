// <copyright file="TransactionTypeEnum.cs" company="APIMatic">
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
    /// TransactionTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionTypeEnum
    {
        /// <summary>
        /// GoodsOrServicePurchase.
        /// </summary>
        [EnumMember(Value = "goodsOrServicePurchase")]
        GoodsOrServicePurchase,

        /// <summary>
        /// CheckAcceptance.
        /// </summary>
        [EnumMember(Value = "checkAcceptance")]
        CheckAcceptance,

        /// <summary>
        /// AccountFunding.
        /// </summary>
        [EnumMember(Value = "accountFunding")]
        AccountFunding,

        /// <summary>
        /// QuasiCashTransaction.
        /// </summary>
        [EnumMember(Value = "quasiCashTransaction")]
        QuasiCashTransaction,

        /// <summary>
        /// PrepaidActivationAndLoad.
        /// </summary>
        [EnumMember(Value = "prepaidActivationAndLoad")]
        PrepaidActivationAndLoad
    }
}