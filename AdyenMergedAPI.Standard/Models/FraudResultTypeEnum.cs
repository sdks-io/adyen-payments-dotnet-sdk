// <copyright file="FraudResultTypeEnum.cs" company="APIMatic">
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
    /// FraudResultTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FraudResultTypeEnum
    {
        /// <summary>
        /// GREEN.
        /// </summary>
        [EnumMember(Value = "GREEN")]
        GREEN,

        /// <summary>
        /// FRAUD.
        /// </summary>
        [EnumMember(Value = "FRAUD")]
        FRAUD
    }
}