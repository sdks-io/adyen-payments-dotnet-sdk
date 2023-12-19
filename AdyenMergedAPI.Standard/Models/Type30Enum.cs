// <copyright file="Type30Enum.cs" company="APIMatic">
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
    /// Type30Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type30Enum
    {
        /// <summary>
        /// Sepadirectdebit.
        /// </summary>
        [EnumMember(Value = "sepadirectdebit")]
        Sepadirectdebit,

        /// <summary>
        /// SepadirectdebitAmazonpay.
        /// </summary>
        [EnumMember(Value = "sepadirectdebit_amazonpay")]
        SepadirectdebitAmazonpay
    }
}