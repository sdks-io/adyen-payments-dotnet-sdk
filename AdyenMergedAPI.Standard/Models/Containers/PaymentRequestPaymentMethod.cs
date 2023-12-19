using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdyenMergedAPI.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<PaymentRequestPaymentMethod>),
        new Type[] {
            typeof(ACHDirectDebitCase),
            typeof(AfterpayCase),
            typeof(AmazonPayCase),
            typeof(AndroidPayCase),
            typeof(ApplePayCase),
            typeof(BACSDirectDebitCase),
            typeof(BillDeskCase),
            typeof(BLIKCase),
            typeof(Card1Case),
            typeof(CellulantCase),
            typeof(DokuCase),
            typeof(DotpayCase),
            typeof(DragonpayCase),
            typeof(VoucherCase),
            typeof(GenericPaymentMethodCase),
            typeof(GiropayCase),
            typeof(GooglePayDetailsCase),
            typeof(IDEALCase),
            typeof(KlarnaCase),
            typeof(MasterpassCase),
            typeof(MBWayCase),
            typeof(MobilePayCase),
            typeof(MOLPayCase),
            typeof(OpenInvoiceCase),
            typeof(PayPalCase),
            typeof(PayUCase),
            typeof(GooglePayCase),
            typeof(PaymentDetailsCase),
            typeof(RatepayCase),
            typeof(SamsungPayCase),
            typeof(SEPADirectDebitCase),
            typeof(StoredPaymentMethod1Case),
            typeof(UPICollectCase),
            typeof(UPIIntentCase),
            typeof(VippsCase),
            typeof(VisaCheckoutCase),
            typeof(WeChatPayCase),
            typeof(WeChatPayMiniProgramCase),
            typeof(ZipCase)
        },
        true
    )]
    public abstract class PaymentRequestPaymentMethod
    {
        /// <summary>
        /// This is ACH Direct Debit case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided ACHDirectDebit value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromACHDirectDebit(ACHDirectDebit aCHDirectDebit)
        {
            return new ACHDirectDebitCase().Set(aCHDirectDebit);
        }

        /// <summary>
        /// This is Afterpay case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided Afterpay value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromAfterpay(Afterpay afterpay)
        {
            return new AfterpayCase().Set(afterpay);
        }

        /// <summary>
        /// This is Amazon Pay case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided AmazonPay value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromAmazonPay(AmazonPay amazonPay)
        {
            return new AmazonPayCase().Set(amazonPay);
        }

        /// <summary>
        /// This is Android Pay case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided AndroidPay value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromAndroidPay(AndroidPay androidPay)
        {
            return new AndroidPayCase().Set(androidPay);
        }

        /// <summary>
        /// This is Apple Pay case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided ApplePay value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromApplePay(ApplePay applePay)
        {
            return new ApplePayCase().Set(applePay);
        }

        /// <summary>
        /// This is BACS Direct Debit case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided BACSDirectDebit value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromBACSDirectDebit(BACSDirectDebit bACSDirectDebit)
        {
            return new BACSDirectDebitCase().Set(bACSDirectDebit);
        }

        /// <summary>
        /// This is BillDesk case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided BillDesk value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromBillDesk(BillDesk billDesk)
        {
            return new BillDeskCase().Set(billDesk);
        }

        /// <summary>
        /// This is BLIK case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided BLIK value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromBLIK(BLIK bLIK)
        {
            return new BLIKCase().Set(bLIK);
        }

        /// <summary>
        /// This is Card1 case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided Card1 value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromCard1(Card1 card1)
        {
            return new Card1Case().Set(card1);
        }

        /// <summary>
        /// This is Cellulant case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided Cellulant value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromCellulant(Cellulant cellulant)
        {
            return new CellulantCase().Set(cellulant);
        }

        /// <summary>
        /// This is Doku case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided Doku value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromDoku(Doku doku)
        {
            return new DokuCase().Set(doku);
        }

        /// <summary>
        /// This is Dotpay case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided Dotpay value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromDotpay(Dotpay dotpay)
        {
            return new DotpayCase().Set(dotpay);
        }

        /// <summary>
        /// This is Dragonpay case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided Dragonpay value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromDragonpay(Dragonpay dragonpay)
        {
            return new DragonpayCase().Set(dragonpay);
        }

        /// <summary>
        /// This is Voucher case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided Voucher value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromVoucher(Voucher voucher)
        {
            return new VoucherCase().Set(voucher);
        }

        /// <summary>
        /// This is Generic Payment Method case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided GenericPaymentMethod value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromGenericPaymentMethod(GenericPaymentMethod genericPaymentMethod)
        {
            return new GenericPaymentMethodCase().Set(genericPaymentMethod);
        }

        /// <summary>
        /// This is Giropay case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided Giropay value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromGiropay(Giropay giropay)
        {
            return new GiropayCase().Set(giropay);
        }

        /// <summary>
        /// This is Google Pay Details case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided GooglePayDetails value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromGooglePayDetails(GooglePayDetails googlePayDetails)
        {
            return new GooglePayDetailsCase().Set(googlePayDetails);
        }

        /// <summary>
        /// This is iDEAL case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided IDEAL value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromIDEAL(IDEAL iDEAL)
        {
            return new IDEALCase().Set(iDEAL);
        }

        /// <summary>
        /// This is Klarna case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided Klarna value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromKlarna(Klarna klarna)
        {
            return new KlarnaCase().Set(klarna);
        }

        /// <summary>
        /// This is Masterpass case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided Masterpass value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromMasterpass(Masterpass masterpass)
        {
            return new MasterpassCase().Set(masterpass);
        }

        /// <summary>
        /// This is MBWay case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided MBWay value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromMBWay(MBWay mBWay)
        {
            return new MBWayCase().Set(mBWay);
        }

        /// <summary>
        /// This is MobilePay case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided MobilePay value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromMobilePay(MobilePay mobilePay)
        {
            return new MobilePayCase().Set(mobilePay);
        }

        /// <summary>
        /// This is MOLPay case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided MOLPay value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromMOLPay(MOLPay mOLPay)
        {
            return new MOLPayCase().Set(mOLPay);
        }

        /// <summary>
        /// This is Open Invoice case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided OpenInvoice value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromOpenInvoice(OpenInvoice openInvoice)
        {
            return new OpenInvoiceCase().Set(openInvoice);
        }

        /// <summary>
        /// This is PayPal case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided PayPal value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromPayPal(PayPal payPal)
        {
            return new PayPalCase().Set(payPal);
        }

        /// <summary>
        /// This is PayU case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided PayU value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromPayU(PayU payU)
        {
            return new PayUCase().Set(payU);
        }

        /// <summary>
        /// This is Google Pay case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided GooglePay value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromGooglePay(GooglePay googlePay)
        {
            return new GooglePayCase().Set(googlePay);
        }

        /// <summary>
        /// This is Payment Details case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided PaymentDetails value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromPaymentDetails(PaymentDetails paymentDetails)
        {
            return new PaymentDetailsCase().Set(paymentDetails);
        }

        /// <summary>
        /// This is Ratepay case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided Ratepay value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromRatepay(Ratepay ratepay)
        {
            return new RatepayCase().Set(ratepay);
        }

        /// <summary>
        /// This is Samsung Pay case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided SamsungPay value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromSamsungPay(SamsungPay samsungPay)
        {
            return new SamsungPayCase().Set(samsungPay);
        }

        /// <summary>
        /// This is SEPA Direct Debit case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided SEPADirectDebit value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromSEPADirectDebit(SEPADirectDebit sEPADirectDebit)
        {
            return new SEPADirectDebitCase().Set(sEPADirectDebit);
        }

        /// <summary>
        /// This is Stored Payment Method1 case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided StoredPaymentMethod1 value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromStoredPaymentMethod1(StoredPaymentMethod1 storedPaymentMethod1)
        {
            return new StoredPaymentMethod1Case().Set(storedPaymentMethod1);
        }

        /// <summary>
        /// This is UPI Collect case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided UPICollect value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromUPICollect(UPICollect uPICollect)
        {
            return new UPICollectCase().Set(uPICollect);
        }

        /// <summary>
        /// This is UPI Intent case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided UPIIntent value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromUPIIntent(UPIIntent uPIIntent)
        {
            return new UPIIntentCase().Set(uPIIntent);
        }

        /// <summary>
        /// This is Vipps case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided Vipps value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromVipps(Vipps vipps)
        {
            return new VippsCase().Set(vipps);
        }

        /// <summary>
        /// This is Visa Checkout case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided VisaCheckout value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromVisaCheckout(VisaCheckout visaCheckout)
        {
            return new VisaCheckoutCase().Set(visaCheckout);
        }

        /// <summary>
        /// This is WeChat Pay case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided WeChatPay value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromWeChatPay(WeChatPay weChatPay)
        {
            return new WeChatPayCase().Set(weChatPay);
        }

        /// <summary>
        /// This is WeChat Pay - Mini Program case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided WeChatPayMiniProgram value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromWeChatPayMiniProgram(WeChatPayMiniProgram weChatPayMiniProgram)
        {
            return new WeChatPayMiniProgramCase().Set(weChatPayMiniProgram);
        }

        /// <summary>
        /// This is Zip case.
        /// </summary>
        /// <returns>
        /// The PaymentRequestPaymentMethod instance, wrapping the provided Zip value.
        /// </returns>
        public static PaymentRequestPaymentMethod FromZip(Zip zip)
        {
            return new ZipCase().Set(zip);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<ACHDirectDebit, T> aCHDirectDebit,
            Func<Afterpay, T> afterpay,
            Func<AmazonPay, T> amazonPay,
            Func<AndroidPay, T> androidPay,
            Func<ApplePay, T> applePay,
            Func<BACSDirectDebit, T> bACSDirectDebit,
            Func<BillDesk, T> billDesk,
            Func<BLIK, T> bLIK,
            Func<Card1, T> card1,
            Func<Cellulant, T> cellulant,
            Func<Doku, T> doku,
            Func<Dotpay, T> dotpay,
            Func<Dragonpay, T> dragonpay,
            Func<Voucher, T> voucher,
            Func<GenericPaymentMethod, T> genericPaymentMethod,
            Func<Giropay, T> giropay,
            Func<GooglePayDetails, T> googlePayDetails,
            Func<IDEAL, T> iDEAL,
            Func<Klarna, T> klarna,
            Func<Masterpass, T> masterpass,
            Func<MBWay, T> mBWay,
            Func<MobilePay, T> mobilePay,
            Func<MOLPay, T> mOLPay,
            Func<OpenInvoice, T> openInvoice,
            Func<PayPal, T> payPal,
            Func<PayU, T> payU,
            Func<GooglePay, T> googlePay,
            Func<PaymentDetails, T> paymentDetails,
            Func<Ratepay, T> ratepay,
            Func<SamsungPay, T> samsungPay,
            Func<SEPADirectDebit, T> sEPADirectDebit,
            Func<StoredPaymentMethod1, T> storedPaymentMethod1,
            Func<UPICollect, T> uPICollect,
            Func<UPIIntent, T> uPIIntent,
            Func<Vipps, T> vipps,
            Func<VisaCheckout, T> visaCheckout,
            Func<WeChatPay, T> weChatPay,
            Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
            Func<Zip, T> zip);

        [JsonConverter(typeof(UnionTypeCaseConverter<ACHDirectDebitCase, ACHDirectDebit>))]
        private sealed class ACHDirectDebitCase : PaymentRequestPaymentMethod, ICaseValue<ACHDirectDebitCase, ACHDirectDebit>
        {
            public ACHDirectDebit _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return aCHDirectDebit(_value);
            }

            public ACHDirectDebitCase Set(ACHDirectDebit value)
            {
                _value = value;
                return this;
            }

            public ACHDirectDebit Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<AfterpayCase, Afterpay>))]
        private sealed class AfterpayCase : PaymentRequestPaymentMethod, ICaseValue<AfterpayCase, Afterpay>
        {
            public Afterpay _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return afterpay(_value);
            }

            public AfterpayCase Set(Afterpay value)
            {
                _value = value;
                return this;
            }

            public Afterpay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<AmazonPayCase, AmazonPay>))]
        private sealed class AmazonPayCase : PaymentRequestPaymentMethod, ICaseValue<AmazonPayCase, AmazonPay>
        {
            public AmazonPay _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return amazonPay(_value);
            }

            public AmazonPayCase Set(AmazonPay value)
            {
                _value = value;
                return this;
            }

            public AmazonPay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<AndroidPayCase, AndroidPay>))]
        private sealed class AndroidPayCase : PaymentRequestPaymentMethod, ICaseValue<AndroidPayCase, AndroidPay>
        {
            public AndroidPay _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return androidPay(_value);
            }

            public AndroidPayCase Set(AndroidPay value)
            {
                _value = value;
                return this;
            }

            public AndroidPay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ApplePayCase, ApplePay>))]
        private sealed class ApplePayCase : PaymentRequestPaymentMethod, ICaseValue<ApplePayCase, ApplePay>
        {
            public ApplePay _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return applePay(_value);
            }

            public ApplePayCase Set(ApplePay value)
            {
                _value = value;
                return this;
            }

            public ApplePay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<BACSDirectDebitCase, BACSDirectDebit>))]
        private sealed class BACSDirectDebitCase : PaymentRequestPaymentMethod, ICaseValue<BACSDirectDebitCase, BACSDirectDebit>
        {
            public BACSDirectDebit _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return bACSDirectDebit(_value);
            }

            public BACSDirectDebitCase Set(BACSDirectDebit value)
            {
                _value = value;
                return this;
            }

            public BACSDirectDebit Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<BillDeskCase, BillDesk>))]
        private sealed class BillDeskCase : PaymentRequestPaymentMethod, ICaseValue<BillDeskCase, BillDesk>
        {
            public BillDesk _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return billDesk(_value);
            }

            public BillDeskCase Set(BillDesk value)
            {
                _value = value;
                return this;
            }

            public BillDesk Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<BLIKCase, BLIK>))]
        private sealed class BLIKCase : PaymentRequestPaymentMethod, ICaseValue<BLIKCase, BLIK>
        {
            public BLIK _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return bLIK(_value);
            }

            public BLIKCase Set(BLIK value)
            {
                _value = value;
                return this;
            }

            public BLIK Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<Card1Case, Card1>))]
        private sealed class Card1Case : PaymentRequestPaymentMethod, ICaseValue<Card1Case, Card1>
        {
            public Card1 _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return card1(_value);
            }

            public Card1Case Set(Card1 value)
            {
                _value = value;
                return this;
            }

            public Card1 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CellulantCase, Cellulant>))]
        private sealed class CellulantCase : PaymentRequestPaymentMethod, ICaseValue<CellulantCase, Cellulant>
        {
            public Cellulant _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return cellulant(_value);
            }

            public CellulantCase Set(Cellulant value)
            {
                _value = value;
                return this;
            }

            public Cellulant Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DokuCase, Doku>))]
        private sealed class DokuCase : PaymentRequestPaymentMethod, ICaseValue<DokuCase, Doku>
        {
            public Doku _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return doku(_value);
            }

            public DokuCase Set(Doku value)
            {
                _value = value;
                return this;
            }

            public Doku Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DotpayCase, Dotpay>))]
        private sealed class DotpayCase : PaymentRequestPaymentMethod, ICaseValue<DotpayCase, Dotpay>
        {
            public Dotpay _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return dotpay(_value);
            }

            public DotpayCase Set(Dotpay value)
            {
                _value = value;
                return this;
            }

            public Dotpay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DragonpayCase, Dragonpay>))]
        private sealed class DragonpayCase : PaymentRequestPaymentMethod, ICaseValue<DragonpayCase, Dragonpay>
        {
            public Dragonpay _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return dragonpay(_value);
            }

            public DragonpayCase Set(Dragonpay value)
            {
                _value = value;
                return this;
            }

            public Dragonpay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<VoucherCase, Voucher>))]
        private sealed class VoucherCase : PaymentRequestPaymentMethod, ICaseValue<VoucherCase, Voucher>
        {
            public Voucher _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return voucher(_value);
            }

            public VoucherCase Set(Voucher value)
            {
                _value = value;
                return this;
            }

            public Voucher Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<GenericPaymentMethodCase, GenericPaymentMethod>))]
        private sealed class GenericPaymentMethodCase : PaymentRequestPaymentMethod, ICaseValue<GenericPaymentMethodCase, GenericPaymentMethod>
        {
            public GenericPaymentMethod _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return genericPaymentMethod(_value);
            }

            public GenericPaymentMethodCase Set(GenericPaymentMethod value)
            {
                _value = value;
                return this;
            }

            public GenericPaymentMethod Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<GiropayCase, Giropay>))]
        private sealed class GiropayCase : PaymentRequestPaymentMethod, ICaseValue<GiropayCase, Giropay>
        {
            public Giropay _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return giropay(_value);
            }

            public GiropayCase Set(Giropay value)
            {
                _value = value;
                return this;
            }

            public Giropay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<GooglePayDetailsCase, GooglePayDetails>))]
        private sealed class GooglePayDetailsCase : PaymentRequestPaymentMethod, ICaseValue<GooglePayDetailsCase, GooglePayDetails>
        {
            public GooglePayDetails _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return googlePayDetails(_value);
            }

            public GooglePayDetailsCase Set(GooglePayDetails value)
            {
                _value = value;
                return this;
            }

            public GooglePayDetails Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<IDEALCase, IDEAL>))]
        private sealed class IDEALCase : PaymentRequestPaymentMethod, ICaseValue<IDEALCase, IDEAL>
        {
            public IDEAL _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return iDEAL(_value);
            }

            public IDEALCase Set(IDEAL value)
            {
                _value = value;
                return this;
            }

            public IDEAL Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<KlarnaCase, Klarna>))]
        private sealed class KlarnaCase : PaymentRequestPaymentMethod, ICaseValue<KlarnaCase, Klarna>
        {
            public Klarna _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return klarna(_value);
            }

            public KlarnaCase Set(Klarna value)
            {
                _value = value;
                return this;
            }

            public Klarna Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MasterpassCase, Masterpass>))]
        private sealed class MasterpassCase : PaymentRequestPaymentMethod, ICaseValue<MasterpassCase, Masterpass>
        {
            public Masterpass _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return masterpass(_value);
            }

            public MasterpassCase Set(Masterpass value)
            {
                _value = value;
                return this;
            }

            public Masterpass Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MBWayCase, MBWay>))]
        private sealed class MBWayCase : PaymentRequestPaymentMethod, ICaseValue<MBWayCase, MBWay>
        {
            public MBWay _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return mBWay(_value);
            }

            public MBWayCase Set(MBWay value)
            {
                _value = value;
                return this;
            }

            public MBWay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MobilePayCase, MobilePay>))]
        private sealed class MobilePayCase : PaymentRequestPaymentMethod, ICaseValue<MobilePayCase, MobilePay>
        {
            public MobilePay _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return mobilePay(_value);
            }

            public MobilePayCase Set(MobilePay value)
            {
                _value = value;
                return this;
            }

            public MobilePay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MOLPayCase, MOLPay>))]
        private sealed class MOLPayCase : PaymentRequestPaymentMethod, ICaseValue<MOLPayCase, MOLPay>
        {
            public MOLPay _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return mOLPay(_value);
            }

            public MOLPayCase Set(MOLPay value)
            {
                _value = value;
                return this;
            }

            public MOLPay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<OpenInvoiceCase, OpenInvoice>))]
        private sealed class OpenInvoiceCase : PaymentRequestPaymentMethod, ICaseValue<OpenInvoiceCase, OpenInvoice>
        {
            public OpenInvoice _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return openInvoice(_value);
            }

            public OpenInvoiceCase Set(OpenInvoice value)
            {
                _value = value;
                return this;
            }

            public OpenInvoice Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PayPalCase, PayPal>))]
        private sealed class PayPalCase : PaymentRequestPaymentMethod, ICaseValue<PayPalCase, PayPal>
        {
            public PayPal _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return payPal(_value);
            }

            public PayPalCase Set(PayPal value)
            {
                _value = value;
                return this;
            }

            public PayPal Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PayUCase, PayU>))]
        private sealed class PayUCase : PaymentRequestPaymentMethod, ICaseValue<PayUCase, PayU>
        {
            public PayU _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return payU(_value);
            }

            public PayUCase Set(PayU value)
            {
                _value = value;
                return this;
            }

            public PayU Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<GooglePayCase, GooglePay>))]
        private sealed class GooglePayCase : PaymentRequestPaymentMethod, ICaseValue<GooglePayCase, GooglePay>
        {
            public GooglePay _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return googlePay(_value);
            }

            public GooglePayCase Set(GooglePay value)
            {
                _value = value;
                return this;
            }

            public GooglePay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentDetailsCase, PaymentDetails>))]
        private sealed class PaymentDetailsCase : PaymentRequestPaymentMethod, ICaseValue<PaymentDetailsCase, PaymentDetails>
        {
            public PaymentDetails _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return paymentDetails(_value);
            }

            public PaymentDetailsCase Set(PaymentDetails value)
            {
                _value = value;
                return this;
            }

            public PaymentDetails Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<RatepayCase, Ratepay>))]
        private sealed class RatepayCase : PaymentRequestPaymentMethod, ICaseValue<RatepayCase, Ratepay>
        {
            public Ratepay _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return ratepay(_value);
            }

            public RatepayCase Set(Ratepay value)
            {
                _value = value;
                return this;
            }

            public Ratepay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SamsungPayCase, SamsungPay>))]
        private sealed class SamsungPayCase : PaymentRequestPaymentMethod, ICaseValue<SamsungPayCase, SamsungPay>
        {
            public SamsungPay _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return samsungPay(_value);
            }

            public SamsungPayCase Set(SamsungPay value)
            {
                _value = value;
                return this;
            }

            public SamsungPay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SEPADirectDebitCase, SEPADirectDebit>))]
        private sealed class SEPADirectDebitCase : PaymentRequestPaymentMethod, ICaseValue<SEPADirectDebitCase, SEPADirectDebit>
        {
            public SEPADirectDebit _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return sEPADirectDebit(_value);
            }

            public SEPADirectDebitCase Set(SEPADirectDebit value)
            {
                _value = value;
                return this;
            }

            public SEPADirectDebit Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<StoredPaymentMethod1Case, StoredPaymentMethod1>))]
        private sealed class StoredPaymentMethod1Case : PaymentRequestPaymentMethod, ICaseValue<StoredPaymentMethod1Case, StoredPaymentMethod1>
        {
            public StoredPaymentMethod1 _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return storedPaymentMethod1(_value);
            }

            public StoredPaymentMethod1Case Set(StoredPaymentMethod1 value)
            {
                _value = value;
                return this;
            }

            public StoredPaymentMethod1 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<UPICollectCase, UPICollect>))]
        private sealed class UPICollectCase : PaymentRequestPaymentMethod, ICaseValue<UPICollectCase, UPICollect>
        {
            public UPICollect _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return uPICollect(_value);
            }

            public UPICollectCase Set(UPICollect value)
            {
                _value = value;
                return this;
            }

            public UPICollect Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<UPIIntentCase, UPIIntent>))]
        private sealed class UPIIntentCase : PaymentRequestPaymentMethod, ICaseValue<UPIIntentCase, UPIIntent>
        {
            public UPIIntent _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return uPIIntent(_value);
            }

            public UPIIntentCase Set(UPIIntent value)
            {
                _value = value;
                return this;
            }

            public UPIIntent Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<VippsCase, Vipps>))]
        private sealed class VippsCase : PaymentRequestPaymentMethod, ICaseValue<VippsCase, Vipps>
        {
            public Vipps _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return vipps(_value);
            }

            public VippsCase Set(Vipps value)
            {
                _value = value;
                return this;
            }

            public Vipps Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<VisaCheckoutCase, VisaCheckout>))]
        private sealed class VisaCheckoutCase : PaymentRequestPaymentMethod, ICaseValue<VisaCheckoutCase, VisaCheckout>
        {
            public VisaCheckout _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return visaCheckout(_value);
            }

            public VisaCheckoutCase Set(VisaCheckout value)
            {
                _value = value;
                return this;
            }

            public VisaCheckout Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<WeChatPayCase, WeChatPay>))]
        private sealed class WeChatPayCase : PaymentRequestPaymentMethod, ICaseValue<WeChatPayCase, WeChatPay>
        {
            public WeChatPay _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return weChatPay(_value);
            }

            public WeChatPayCase Set(WeChatPay value)
            {
                _value = value;
                return this;
            }

            public WeChatPay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<WeChatPayMiniProgramCase, WeChatPayMiniProgram>))]
        private sealed class WeChatPayMiniProgramCase : PaymentRequestPaymentMethod, ICaseValue<WeChatPayMiniProgramCase, WeChatPayMiniProgram>
        {
            public WeChatPayMiniProgram _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return weChatPayMiniProgram(_value);
            }

            public WeChatPayMiniProgramCase Set(WeChatPayMiniProgram value)
            {
                _value = value;
                return this;
            }

            public WeChatPayMiniProgram Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ZipCase, Zip>))]
        private sealed class ZipCase : PaymentRequestPaymentMethod, ICaseValue<ZipCase, Zip>
        {
            public Zip _value;

            public override T Match<T>(
                Func<ACHDirectDebit, T> aCHDirectDebit,
                Func<Afterpay, T> afterpay,
                Func<AmazonPay, T> amazonPay,
                Func<AndroidPay, T> androidPay,
                Func<ApplePay, T> applePay,
                Func<BACSDirectDebit, T> bACSDirectDebit,
                Func<BillDesk, T> billDesk,
                Func<BLIK, T> bLIK,
                Func<Card1, T> card1,
                Func<Cellulant, T> cellulant,
                Func<Doku, T> doku,
                Func<Dotpay, T> dotpay,
                Func<Dragonpay, T> dragonpay,
                Func<Voucher, T> voucher,
                Func<GenericPaymentMethod, T> genericPaymentMethod,
                Func<Giropay, T> giropay,
                Func<GooglePayDetails, T> googlePayDetails,
                Func<IDEAL, T> iDEAL,
                Func<Klarna, T> klarna,
                Func<Masterpass, T> masterpass,
                Func<MBWay, T> mBWay,
                Func<MobilePay, T> mobilePay,
                Func<MOLPay, T> mOLPay,
                Func<OpenInvoice, T> openInvoice,
                Func<PayPal, T> payPal,
                Func<PayU, T> payU,
                Func<GooglePay, T> googlePay,
                Func<PaymentDetails, T> paymentDetails,
                Func<Ratepay, T> ratepay,
                Func<SamsungPay, T> samsungPay,
                Func<SEPADirectDebit, T> sEPADirectDebit,
                Func<StoredPaymentMethod1, T> storedPaymentMethod1,
                Func<UPICollect, T> uPICollect,
                Func<UPIIntent, T> uPIIntent,
                Func<Vipps, T> vipps,
                Func<VisaCheckout, T> visaCheckout,
                Func<WeChatPay, T> weChatPay,
                Func<WeChatPayMiniProgram, T> weChatPayMiniProgram,
                Func<Zip, T> zip)
            {
                return zip(_value);
            }

            public ZipCase Set(Zip value)
            {
                _value = value;
                return this;
            }

            public Zip Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }
    }
}