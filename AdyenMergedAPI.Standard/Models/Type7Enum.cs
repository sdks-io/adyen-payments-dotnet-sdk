// <copyright file="Type7Enum.cs" company="APIMatic">
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
    /// Type7Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type7Enum
    {
        /// <summary>
        /// BilldeskOnline.
        /// </summary>
        [EnumMember(Value = "billdesk_online")]
        BilldeskOnline,

        /// <summary>
        /// BilldeskWallet.
        /// </summary>
        [EnumMember(Value = "billdesk_wallet")]
        BilldeskWallet,

        /// <summary>
        /// OnlinebankingIN.
        /// </summary>
        [EnumMember(Value = "onlinebanking_IN")]
        OnlinebankingIN,

        /// <summary>
        /// WalletIN.
        /// </summary>
        [EnumMember(Value = "wallet_IN")]
        WalletIN
    }
}