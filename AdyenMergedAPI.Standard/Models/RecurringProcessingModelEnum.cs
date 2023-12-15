// <copyright file="RecurringProcessingModelEnum.cs" company="APIMatic">
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
    /// RecurringProcessingModelEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecurringProcessingModelEnum
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