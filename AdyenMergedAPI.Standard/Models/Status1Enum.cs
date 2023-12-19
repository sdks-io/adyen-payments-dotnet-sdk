// <copyright file="Status1Enum.cs" company="APIMatic">
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
    /// Status1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status1Enum
    {
        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed,

        /// <summary>
        /// Expired.
        /// </summary>
        [EnumMember(Value = "expired")]
        Expired,

        /// <summary>
        /// Paid.
        /// </summary>
        [EnumMember(Value = "paid")]
        Paid,

        /// <summary>
        /// PaymentPending.
        /// </summary>
        [EnumMember(Value = "paymentPending")]
        PaymentPending
    }
}