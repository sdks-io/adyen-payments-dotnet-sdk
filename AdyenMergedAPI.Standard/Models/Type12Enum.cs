// <copyright file="Type12Enum.cs" company="APIMatic">
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
    /// Type12Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type12Enum
    {
        /// <summary>
        /// DokuMandiriVa.
        /// </summary>
        [EnumMember(Value = "doku_mandiri_va")]
        DokuMandiriVa,

        /// <summary>
        /// DokuCimbVa.
        /// </summary>
        [EnumMember(Value = "doku_cimb_va")]
        DokuCimbVa,

        /// <summary>
        /// DokuDanamonVa.
        /// </summary>
        [EnumMember(Value = "doku_danamon_va")]
        DokuDanamonVa,

        /// <summary>
        /// DokuBniVa.
        /// </summary>
        [EnumMember(Value = "doku_bni_va")]
        DokuBniVa,

        /// <summary>
        /// DokuPermataLiteAtm.
        /// </summary>
        [EnumMember(Value = "doku_permata_lite_atm")]
        DokuPermataLiteAtm,

        /// <summary>
        /// DokuBriVa.
        /// </summary>
        [EnumMember(Value = "doku_bri_va")]
        DokuBriVa,

        /// <summary>
        /// DokuBcaVa.
        /// </summary>
        [EnumMember(Value = "doku_bca_va")]
        DokuBcaVa,

        /// <summary>
        /// DokuAlfamart.
        /// </summary>
        [EnumMember(Value = "doku_alfamart")]
        DokuAlfamart,

        /// <summary>
        /// DokuIndomaret.
        /// </summary>
        [EnumMember(Value = "doku_indomaret")]
        DokuIndomaret,

        /// <summary>
        /// DokuWallet.
        /// </summary>
        [EnumMember(Value = "doku_wallet")]
        DokuWallet,

        /// <summary>
        /// DokuOvo.
        /// </summary>
        [EnumMember(Value = "doku_ovo")]
        DokuOvo
    }
}