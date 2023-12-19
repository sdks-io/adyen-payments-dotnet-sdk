// <copyright file="CardHolderNameEnum.cs" company="APIMatic">
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
    /// CardHolderNameEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardHolderNameEnum
    {
        /// <summary>
        /// NONE.
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// OPTIONAL.
        /// </summary>
        [EnumMember(Value = "OPTIONAL")]
        OPTIONAL,

        /// <summary>
        /// REQUIRED.
        /// </summary>
        [EnumMember(Value = "REQUIRED")]
        REQUIRED
    }
}