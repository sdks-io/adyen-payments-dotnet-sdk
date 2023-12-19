// <copyright file="MerchantRefundReasonEnum.cs" company="APIMatic">
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
    /// MerchantRefundReasonEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MerchantRefundReasonEnum
    {
        /// <summary>
        /// FRAUD.
        /// </summary>
        [EnumMember(Value = "FRAUD")]
        FRAUD,

        /// <summary>
        /// EnumCUSTOMERREQUEST.
        /// </summary>
        [EnumMember(Value = "CUSTOMER REQUEST")]
        EnumCUSTOMERREQUEST,

        /// <summary>
        /// RETURN.
        /// </summary>
        [EnumMember(Value = "RETURN")]
        RETURN,

        /// <summary>
        /// DUPLICATE.
        /// </summary>
        [EnumMember(Value = "DUPLICATE")]
        DUPLICATE,

        /// <summary>
        /// OTHER.
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER
    }
}