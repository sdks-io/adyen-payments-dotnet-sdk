// <copyright file="PlanEnum.cs" company="APIMatic">
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
    /// PlanEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PlanEnum
    {
        /// <summary>
        /// Regular.
        /// </summary>
        [EnumMember(Value = "regular")]
        Regular,

        /// <summary>
        /// Revolving.
        /// </summary>
        [EnumMember(Value = "revolving")]
        Revolving
    }
}