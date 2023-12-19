// <copyright file="Type31Enum.cs" company="APIMatic">
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
    /// Type31Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type31Enum
    {
        /// <summary>
        /// BcmcMobile.
        /// </summary>
        [EnumMember(Value = "bcmc_mobile")]
        BcmcMobile,

        /// <summary>
        /// BcmcMobileQR.
        /// </summary>
        [EnumMember(Value = "bcmc_mobile_QR")]
        BcmcMobileQR,

        /// <summary>
        /// BcmcMobileApp.
        /// </summary>
        [EnumMember(Value = "bcmc_mobile_app")]
        BcmcMobileApp,

        /// <summary>
        /// MomoWallet.
        /// </summary>
        [EnumMember(Value = "momo_wallet")]
        MomoWallet,

        /// <summary>
        /// MomoWalletApp.
        /// </summary>
        [EnumMember(Value = "momo_wallet_app")]
        MomoWalletApp,

        /// <summary>
        /// Twint.
        /// </summary>
        [EnumMember(Value = "twint")]
        Twint,

        /// <summary>
        /// PaymayaWallet.
        /// </summary>
        [EnumMember(Value = "paymaya_wallet")]
        PaymayaWallet,

        /// <summary>
        /// GrabpaySG.
        /// </summary>
        [EnumMember(Value = "grabpay_SG")]
        GrabpaySG,

        /// <summary>
        /// GrabpayMY.
        /// </summary>
        [EnumMember(Value = "grabpay_MY")]
        GrabpayMY,

        /// <summary>
        /// GrabpayTH.
        /// </summary>
        [EnumMember(Value = "grabpay_TH")]
        GrabpayTH,

        /// <summary>
        /// GrabpayID.
        /// </summary>
        [EnumMember(Value = "grabpay_ID")]
        GrabpayID,

        /// <summary>
        /// GrabpayVN.
        /// </summary>
        [EnumMember(Value = "grabpay_VN")]
        GrabpayVN,

        /// <summary>
        /// GrabpayPH.
        /// </summary>
        [EnumMember(Value = "grabpay_PH")]
        GrabpayPH,

        /// <summary>
        /// Oxxo.
        /// </summary>
        [EnumMember(Value = "oxxo")]
        Oxxo,

        /// <summary>
        /// Gcash.
        /// </summary>
        [EnumMember(Value = "gcash")]
        Gcash,

        /// <summary>
        /// Dana.
        /// </summary>
        [EnumMember(Value = "dana")]
        Dana,

        /// <summary>
        /// Kakaopay.
        /// </summary>
        [EnumMember(Value = "kakaopay")]
        Kakaopay,

        /// <summary>
        /// Truemoney.
        /// </summary>
        [EnumMember(Value = "truemoney")]
        Truemoney
    }
}