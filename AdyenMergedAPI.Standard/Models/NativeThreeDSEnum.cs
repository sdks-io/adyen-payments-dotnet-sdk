// <copyright file="NativeThreeDSEnum.cs" company="APIMatic">
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
    /// NativeThreeDSEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NativeThreeDSEnum
    {
        /// <summary>
        /// Preferred.
        /// </summary>
        [EnumMember(Value = "preferred")]
        Preferred
    }
}