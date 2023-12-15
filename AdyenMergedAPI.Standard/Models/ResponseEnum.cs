// <copyright file="ResponseEnum.cs" company="APIMatic">
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
    /// ResponseEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResponseEnum
    {
        /// <summary>
        /// EnumCapturereceived.
        /// </summary>
        [EnumMember(Value = "[capture-received]")]
        EnumCapturereceived,

        /// <summary>
        /// EnumCancelreceived.
        /// </summary>
        [EnumMember(Value = "[cancel-received]")]
        EnumCancelreceived,

        /// <summary>
        /// EnumRefundreceived.
        /// </summary>
        [EnumMember(Value = "[refund-received]")]
        EnumRefundreceived,

        /// <summary>
        /// EnumCancelOrRefundreceived.
        /// </summary>
        [EnumMember(Value = "[cancelOrRefund-received]")]
        EnumCancelOrRefundreceived,

        /// <summary>
        /// EnumAdjustAuthorisationreceived.
        /// </summary>
        [EnumMember(Value = "[adjustAuthorisation-received]")]
        EnumAdjustAuthorisationreceived,

        /// <summary>
        /// EnumDonationreceived.
        /// </summary>
        [EnumMember(Value = "[donation-received]")]
        EnumDonationreceived,

        /// <summary>
        /// EnumTechnicalcancelreceived.
        /// </summary>
        [EnumMember(Value = "[technical-cancel-received]")]
        EnumTechnicalcancelreceived,

        /// <summary>
        /// EnumVoidPendingRefundreceived.
        /// </summary>
        [EnumMember(Value = "[voidPendingRefund-received]")]
        EnumVoidPendingRefundreceived
    }
}