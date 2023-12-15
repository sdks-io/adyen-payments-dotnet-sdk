// <copyright file="ShipAddressUsageIndEnum.cs" company="APIMatic">
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
    /// ShipAddressUsageIndEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShipAddressUsageIndEnum
    {
        /// <summary>
        /// Enum01.
        /// </summary>
        [EnumMember(Value = "01")]
        Enum01,

        /// <summary>
        /// Enum02.
        /// </summary>
        [EnumMember(Value = "02")]
        Enum02,

        /// <summary>
        /// Enum03.
        /// </summary>
        [EnumMember(Value = "03")]
        Enum03,

        /// <summary>
        /// Enum04.
        /// </summary>
        [EnumMember(Value = "04")]
        Enum04
    }
}