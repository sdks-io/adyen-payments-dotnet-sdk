// <copyright file="RecurringProcessingModel7Enum.cs" company="APIMatic">
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
    /// RecurringProcessingModel7Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecurringProcessingModel7Enum
    {
        /// <summary>
        /// CardOnFile.
        /// </summary>
        [EnumMember(Value = "CardOnFile")]
        CardOnFile,

        /// <summary>
        /// Subscription.
        /// </summary>
        [EnumMember(Value = "Subscription")]
        Subscription,

        /// <summary>
        /// UnscheduledCardOnFile.
        /// </summary>
        [EnumMember(Value = "UnscheduledCardOnFile")]
        UnscheduledCardOnFile
    }
}