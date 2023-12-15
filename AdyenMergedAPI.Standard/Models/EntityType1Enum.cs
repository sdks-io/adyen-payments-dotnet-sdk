// <copyright file="EntityType1Enum.cs" company="APIMatic">
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
    /// EntityType1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityType1Enum
    {
        /// <summary>
        /// NaturalPerson.
        /// </summary>
        [EnumMember(Value = "NaturalPerson")]
        NaturalPerson,

        /// <summary>
        /// Company.
        /// </summary>
        [EnumMember(Value = "Company")]
        Company
    }
}