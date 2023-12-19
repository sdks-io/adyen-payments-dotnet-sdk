// <copyright file="Type28Enum.cs" company="APIMatic">
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
    /// Type28Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type28Enum
    {
        /// <summary>
        /// Ratepay.
        /// </summary>
        [EnumMember(Value = "ratepay")]
        Ratepay,

        /// <summary>
        /// RatepayDirectdebit.
        /// </summary>
        [EnumMember(Value = "ratepay_directdebit")]
        RatepayDirectdebit
    }
}