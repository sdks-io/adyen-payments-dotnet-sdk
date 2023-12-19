// <copyright file="Type26Enum.cs" company="APIMatic">
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
    /// Type26Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type26Enum
    {
        /// <summary>
        /// Openinvoice.
        /// </summary>
        [EnumMember(Value = "openinvoice")]
        Openinvoice,

        /// <summary>
        /// AfterpayDirectdebit.
        /// </summary>
        [EnumMember(Value = "afterpay_directdebit")]
        AfterpayDirectdebit,

        /// <summary>
        /// AtomePos.
        /// </summary>
        [EnumMember(Value = "atome_pos")]
        AtomePos
    }
}