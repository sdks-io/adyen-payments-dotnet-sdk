// <copyright file="Type19Enum.cs" company="APIMatic">
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
    /// Type19Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type19Enum
    {
        /// <summary>
        /// OnlineBankingPL.
        /// </summary>
        [EnumMember(Value = "onlineBanking_PL")]
        OnlineBankingPL,

        /// <summary>
        /// Eps.
        /// </summary>
        [EnumMember(Value = "eps")]
        Eps,

        /// <summary>
        /// OnlineBankingSK.
        /// </summary>
        [EnumMember(Value = "onlineBanking_SK")]
        OnlineBankingSK,

        /// <summary>
        /// OnlineBankingCZ.
        /// </summary>
        [EnumMember(Value = "onlineBanking_CZ")]
        OnlineBankingCZ
    }
}