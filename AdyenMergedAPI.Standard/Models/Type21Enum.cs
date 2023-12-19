// <copyright file="Type21Enum.cs" company="APIMatic">
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
    /// Type21Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type21Enum
    {
        /// <summary>
        /// Klarna.
        /// </summary>
        [EnumMember(Value = "klarna")]
        Klarna,

        /// <summary>
        /// Klarnapayments.
        /// </summary>
        [EnumMember(Value = "klarnapayments")]
        Klarnapayments,

        /// <summary>
        /// KlarnapaymentsAccount.
        /// </summary>
        [EnumMember(Value = "klarnapayments_account")]
        KlarnapaymentsAccount,

        /// <summary>
        /// KlarnapaymentsB2b.
        /// </summary>
        [EnumMember(Value = "klarnapayments_b2b")]
        KlarnapaymentsB2b,

        /// <summary>
        /// KlarnaPaynow.
        /// </summary>
        [EnumMember(Value = "klarna_paynow")]
        KlarnaPaynow,

        /// <summary>
        /// KlarnaAccount.
        /// </summary>
        [EnumMember(Value = "klarna_account")]
        KlarnaAccount,

        /// <summary>
        /// KlarnaB2b.
        /// </summary>
        [EnumMember(Value = "klarna_b2b")]
        KlarnaB2b
    }
}