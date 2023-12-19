// <copyright file="Type27Enum.cs" company="APIMatic">
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
    /// Type27Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type27Enum
    {
        /// <summary>
        /// Alipay.
        /// </summary>
        [EnumMember(Value = "alipay")]
        Alipay,

        /// <summary>
        /// Multibanco.
        /// </summary>
        [EnumMember(Value = "multibanco")]
        Multibanco,

        /// <summary>
        /// BankTransferIBAN.
        /// </summary>
        [EnumMember(Value = "bankTransfer_IBAN")]
        BankTransferIBAN,

        /// <summary>
        /// Paybright.
        /// </summary>
        [EnumMember(Value = "paybright")]
        Paybright,

        /// <summary>
        /// Paynow.
        /// </summary>
        [EnumMember(Value = "paynow")]
        Paynow,

        /// <summary>
        /// Affirm.
        /// </summary>
        [EnumMember(Value = "affirm")]
        Affirm,

        /// <summary>
        /// AffirmPos.
        /// </summary>
        [EnumMember(Value = "affirm_pos")]
        AffirmPos,

        /// <summary>
        /// Trustly.
        /// </summary>
        [EnumMember(Value = "trustly")]
        Trustly,

        /// <summary>
        /// Trustlyvector.
        /// </summary>
        [EnumMember(Value = "trustlyvector")]
        Trustlyvector,

        /// <summary>
        /// Oney.
        /// </summary>
        [EnumMember(Value = "oney")]
        Oney,

        /// <summary>
        /// Facilypay.
        /// </summary>
        [EnumMember(Value = "facilypay")]
        Facilypay,

        /// <summary>
        /// Facilypay3x.
        /// </summary>
        [EnumMember(Value = "facilypay_3x")]
        Facilypay3x,

        /// <summary>
        /// Facilypay4x.
        /// </summary>
        [EnumMember(Value = "facilypay_4x")]
        Facilypay4x,

        /// <summary>
        /// Facilypay6x.
        /// </summary>
        [EnumMember(Value = "facilypay_6x")]
        Facilypay6x,

        /// <summary>
        /// Facilypay10x.
        /// </summary>
        [EnumMember(Value = "facilypay_10x")]
        Facilypay10x,

        /// <summary>
        /// Facilypay12x.
        /// </summary>
        [EnumMember(Value = "facilypay_12x")]
        Facilypay12x,

        /// <summary>
        /// Unionpay.
        /// </summary>
        [EnumMember(Value = "unionpay")]
        Unionpay,

        /// <summary>
        /// KcpBanktransfer.
        /// </summary>
        [EnumMember(Value = "kcp_banktransfer")]
        KcpBanktransfer,

        /// <summary>
        /// KcpPayco.
        /// </summary>
        [EnumMember(Value = "kcp_payco")]
        KcpPayco,

        /// <summary>
        /// KcpCreditcard.
        /// </summary>
        [EnumMember(Value = "kcp_creditcard")]
        KcpCreditcard,

        /// <summary>
        /// WechatpaySDK.
        /// </summary>
        [EnumMember(Value = "wechatpaySDK")]
        WechatpaySDK,

        /// <summary>
        /// WechatpayQR.
        /// </summary>
        [EnumMember(Value = "wechatpayQR")]
        WechatpayQR,

        /// <summary>
        /// WechatpayWeb.
        /// </summary>
        [EnumMember(Value = "wechatpayWeb")]
        WechatpayWeb,

        /// <summary>
        /// MolpayBoost.
        /// </summary>
        [EnumMember(Value = "molpay_boost")]
        MolpayBoost,

        /// <summary>
        /// WalletIN.
        /// </summary>
        [EnumMember(Value = "wallet_IN")]
        WalletIN,

        /// <summary>
        /// PayuINCashcard.
        /// </summary>
        [EnumMember(Value = "payu_IN_cashcard")]
        PayuINCashcard,

        /// <summary>
        /// PayuINNb.
        /// </summary>
        [EnumMember(Value = "payu_IN_nb")]
        PayuINNb,

        /// <summary>
        /// UpiQr.
        /// </summary>
        [EnumMember(Value = "upi_qr")]
        UpiQr,

        /// <summary>
        /// Paytm.
        /// </summary>
        [EnumMember(Value = "paytm")]
        Paytm,

        /// <summary>
        /// MolpayEbankingVN.
        /// </summary>
        [EnumMember(Value = "molpay_ebanking_VN")]
        MolpayEbankingVN,

        /// <summary>
        /// Paybybank.
        /// </summary>
        [EnumMember(Value = "paybybank")]
        Paybybank,

        /// <summary>
        /// EbankingFI.
        /// </summary>
        [EnumMember(Value = "ebanking_FI")]
        EbankingFI,

        /// <summary>
        /// MolpayEbankingMY.
        /// </summary>
        [EnumMember(Value = "molpay_ebanking_MY")]
        MolpayEbankingMY,

        /// <summary>
        /// MolpayEbankingDirectMY.
        /// </summary>
        [EnumMember(Value = "molpay_ebanking_direct_MY")]
        MolpayEbankingDirectMY,

        /// <summary>
        /// Swish.
        /// </summary>
        [EnumMember(Value = "swish")]
        Swish,

        /// <summary>
        /// Pix.
        /// </summary>
        [EnumMember(Value = "pix")]
        Pix,

        /// <summary>
        /// Walley.
        /// </summary>
        [EnumMember(Value = "walley")]
        Walley,

        /// <summary>
        /// WalleyB2b.
        /// </summary>
        [EnumMember(Value = "walley_b2b")]
        WalleyB2b,

        /// <summary>
        /// Alma.
        /// </summary>
        [EnumMember(Value = "alma")]
        Alma,

        /// <summary>
        /// Paypo.
        /// </summary>
        [EnumMember(Value = "paypo")]
        Paypo,

        /// <summary>
        /// MolpayFpx.
        /// </summary>
        [EnumMember(Value = "molpay_fpx")]
        MolpayFpx,

        /// <summary>
        /// Konbini.
        /// </summary>
        [EnumMember(Value = "konbini")]
        Konbini,

        /// <summary>
        /// DirectEbanking.
        /// </summary>
        [EnumMember(Value = "directEbanking")]
        DirectEbanking,

        /// <summary>
        /// Boletobancario.
        /// </summary>
        [EnumMember(Value = "boletobancario")]
        Boletobancario,

        /// <summary>
        /// Neteller.
        /// </summary>
        [EnumMember(Value = "neteller")]
        Neteller,

        /// <summary>
        /// Paysafecard.
        /// </summary>
        [EnumMember(Value = "paysafecard")]
        Paysafecard,

        /// <summary>
        /// Cashticket.
        /// </summary>
        [EnumMember(Value = "cashticket")]
        Cashticket,

        /// <summary>
        /// Ikano.
        /// </summary>
        [EnumMember(Value = "ikano")]
        Ikano,

        /// <summary>
        /// Karenmillen.
        /// </summary>
        [EnumMember(Value = "karenmillen")]
        Karenmillen,

        /// <summary>
        /// Oasis.
        /// </summary>
        [EnumMember(Value = "oasis")]
        Oasis,

        /// <summary>
        /// Warehouse.
        /// </summary>
        [EnumMember(Value = "warehouse")]
        Warehouse,

        /// <summary>
        /// PrimeiropayBoleto.
        /// </summary>
        [EnumMember(Value = "primeiropay_boleto")]
        PrimeiropayBoleto,

        /// <summary>
        /// Mada.
        /// </summary>
        [EnumMember(Value = "mada")]
        Mada,

        /// <summary>
        /// Benefit.
        /// </summary>
        [EnumMember(Value = "benefit")]
        Benefit,

        /// <summary>
        /// Knet.
        /// </summary>
        [EnumMember(Value = "knet")]
        Knet,

        /// <summary>
        /// Omannet.
        /// </summary>
        [EnumMember(Value = "omannet")]
        Omannet,

        /// <summary>
        /// GopayWallet.
        /// </summary>
        [EnumMember(Value = "gopay_wallet")]
        GopayWallet,

        /// <summary>
        /// KcpNaverpay.
        /// </summary>
        [EnumMember(Value = "kcp_naverpay")]
        KcpNaverpay,

        /// <summary>
        /// OnlinebankingIN.
        /// </summary>
        [EnumMember(Value = "onlinebanking_IN")]
        OnlinebankingIN,

        /// <summary>
        /// Fawry.
        /// </summary>
        [EnumMember(Value = "fawry")]
        Fawry,

        /// <summary>
        /// Atome.
        /// </summary>
        [EnumMember(Value = "atome")]
        Atome,

        /// <summary>
        /// Moneybookers.
        /// </summary>
        [EnumMember(Value = "moneybookers")]
        Moneybookers,

        /// <summary>
        /// Naps.
        /// </summary>
        [EnumMember(Value = "naps")]
        Naps,

        /// <summary>
        /// Nordea.
        /// </summary>
        [EnumMember(Value = "nordea")]
        Nordea,

        /// <summary>
        /// BoletobancarioBradesco.
        /// </summary>
        [EnumMember(Value = "boletobancario_bradesco")]
        BoletobancarioBradesco,

        /// <summary>
        /// BoletobancarioItau.
        /// </summary>
        [EnumMember(Value = "boletobancario_itau")]
        BoletobancarioItau,

        /// <summary>
        /// BoletobancarioSantander.
        /// </summary>
        [EnumMember(Value = "boletobancario_santander")]
        BoletobancarioSantander,

        /// <summary>
        /// BoletobancarioBancodobrasil.
        /// </summary>
        [EnumMember(Value = "boletobancario_bancodobrasil")]
        BoletobancarioBancodobrasil,

        /// <summary>
        /// BoletobancarioHsbc.
        /// </summary>
        [EnumMember(Value = "boletobancario_hsbc")]
        BoletobancarioHsbc,

        /// <summary>
        /// MolpayMaybank2u.
        /// </summary>
        [EnumMember(Value = "molpay_maybank2u")]
        MolpayMaybank2u,

        /// <summary>
        /// MolpayCimb.
        /// </summary>
        [EnumMember(Value = "molpay_cimb")]
        MolpayCimb,

        /// <summary>
        /// MolpayRhb.
        /// </summary>
        [EnumMember(Value = "molpay_rhb")]
        MolpayRhb,

        /// <summary>
        /// MolpayAmb.
        /// </summary>
        [EnumMember(Value = "molpay_amb")]
        MolpayAmb,

        /// <summary>
        /// MolpayHlb.
        /// </summary>
        [EnumMember(Value = "molpay_hlb")]
        MolpayHlb,

        /// <summary>
        /// MolpayAffinEpg.
        /// </summary>
        [EnumMember(Value = "molpay_affin_epg")]
        MolpayAffinEpg,

        /// <summary>
        /// MolpayBankislam.
        /// </summary>
        [EnumMember(Value = "molpay_bankislam")]
        MolpayBankislam,

        /// <summary>
        /// MolpayPublicbank.
        /// </summary>
        [EnumMember(Value = "molpay_publicbank")]
        MolpayPublicbank,

        /// <summary>
        /// FpxAgrobank.
        /// </summary>
        [EnumMember(Value = "fpx_agrobank")]
        FpxAgrobank,

        /// <summary>
        /// Touchngo.
        /// </summary>
        [EnumMember(Value = "touchngo")]
        Touchngo,

        /// <summary>
        /// Maybank2uMae.
        /// </summary>
        [EnumMember(Value = "maybank2u_mae")]
        Maybank2uMae,

        /// <summary>
        /// Duitnow.
        /// </summary>
        [EnumMember(Value = "duitnow")]
        Duitnow,

        /// <summary>
        /// Promptpay.
        /// </summary>
        [EnumMember(Value = "promptpay")]
        Promptpay,

        /// <summary>
        /// TwintPos.
        /// </summary>
        [EnumMember(Value = "twint_pos")]
        TwintPos,

        /// <summary>
        /// AlipayHk.
        /// </summary>
        [EnumMember(Value = "alipay_hk")]
        AlipayHk,

        /// <summary>
        /// AlipayHkWeb.
        /// </summary>
        [EnumMember(Value = "alipay_hk_web")]
        AlipayHkWeb,

        /// <summary>
        /// AlipayHkWap.
        /// </summary>
        [EnumMember(Value = "alipay_hk_wap")]
        AlipayHkWap,

        /// <summary>
        /// AlipayWap.
        /// </summary>
        [EnumMember(Value = "alipay_wap")]
        AlipayWap,

        /// <summary>
        /// Balanceplatform.
        /// </summary>
        [EnumMember(Value = "balanceplatform")]
        Balanceplatform
    }
}