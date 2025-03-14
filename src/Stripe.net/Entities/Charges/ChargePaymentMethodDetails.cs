// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetails : StripeEntity<ChargePaymentMethodDetails>
    {
        [JsonProperty("ach_credit_transfer")]
        public ChargePaymentMethodDetailsAchCreditTransfer AchCreditTransfer { get; set; }

        [JsonProperty("ach_debit")]
        public ChargePaymentMethodDetailsAchDebit AchDebit { get; set; }

        [JsonProperty("acss_debit")]
        public ChargePaymentMethodDetailsAcssDebit AcssDebit { get; set; }

        [JsonProperty("affirm")]
        public ChargePaymentMethodDetailsAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
        public ChargePaymentMethodDetailsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        public ChargePaymentMethodDetailsAlipay Alipay { get; set; }

        [JsonProperty("alma")]
        public ChargePaymentMethodDetailsAlma Alma { get; set; }

        [JsonProperty("amazon_pay")]
        public ChargePaymentMethodDetailsAmazonPay AmazonPay { get; set; }

        [JsonProperty("au_becs_debit")]
        public ChargePaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        public ChargePaymentMethodDetailsBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        public ChargePaymentMethodDetailsBancontact Bancontact { get; set; }

        [JsonProperty("blik")]
        public ChargePaymentMethodDetailsBlik Blik { get; set; }

        [JsonProperty("boleto")]
        public ChargePaymentMethodDetailsBoleto Boleto { get; set; }

        [JsonProperty("card")]
        public ChargePaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("card_present")]
        public ChargePaymentMethodDetailsCardPresent CardPresent { get; set; }

        [JsonProperty("cashapp")]
        public ChargePaymentMethodDetailsCashapp Cashapp { get; set; }

        [JsonProperty("customer_balance")]
        public ChargePaymentMethodDetailsCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
        public ChargePaymentMethodDetailsEps Eps { get; set; }

        [JsonProperty("fpx")]
        public ChargePaymentMethodDetailsFpx Fpx { get; set; }

        [JsonProperty("giropay")]
        public ChargePaymentMethodDetailsGiropay Giropay { get; set; }

        [JsonProperty("grabpay")]
        public ChargePaymentMethodDetailsGrabpay Grabpay { get; set; }

        [JsonProperty("ideal")]
        public ChargePaymentMethodDetailsIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
        public ChargePaymentMethodDetailsInteracPresent InteracPresent { get; set; }

        [JsonProperty("kakao_pay")]
        public ChargePaymentMethodDetailsKakaoPay KakaoPay { get; set; }

        [JsonProperty("klarna")]
        public ChargePaymentMethodDetailsKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
        public ChargePaymentMethodDetailsKonbini Konbini { get; set; }

        [JsonProperty("kr_card")]
        public ChargePaymentMethodDetailsKrCard KrCard { get; set; }

        [JsonProperty("link")]
        public ChargePaymentMethodDetailsLink Link { get; set; }

        [JsonProperty("mobilepay")]
        public ChargePaymentMethodDetailsMobilepay Mobilepay { get; set; }

        [JsonProperty("multibanco")]
        public ChargePaymentMethodDetailsMultibanco Multibanco { get; set; }

        [JsonProperty("naver_pay")]
        public ChargePaymentMethodDetailsNaverPay NaverPay { get; set; }

        [JsonProperty("oxxo")]
        public ChargePaymentMethodDetailsOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
        public ChargePaymentMethodDetailsP24 P24 { get; set; }

        [JsonProperty("pay_by_bank")]
        public ChargePaymentMethodDetailsPayByBank PayByBank { get; set; }

        [JsonProperty("payco")]
        public ChargePaymentMethodDetailsPayco Payco { get; set; }

        [JsonProperty("paynow")]
        public ChargePaymentMethodDetailsPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
        public ChargePaymentMethodDetailsPaypal Paypal { get; set; }

        [JsonProperty("pix")]
        public ChargePaymentMethodDetailsPix Pix { get; set; }

        [JsonProperty("promptpay")]
        public ChargePaymentMethodDetailsPromptpay Promptpay { get; set; }

        [JsonProperty("revolut_pay")]
        public ChargePaymentMethodDetailsRevolutPay RevolutPay { get; set; }

        [JsonProperty("samsung_pay")]
        public ChargePaymentMethodDetailsSamsungPay SamsungPay { get; set; }

        [JsonProperty("sepa_debit")]
        public ChargePaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
        public ChargePaymentMethodDetailsSofort Sofort { get; set; }

        [JsonProperty("stripe_account")]
        public ChargePaymentMethodDetailsStripeAccount StripeAccount { get; set; }

        [JsonProperty("swish")]
        public ChargePaymentMethodDetailsSwish Swish { get; set; }

        [JsonProperty("twint")]
        public ChargePaymentMethodDetailsTwint Twint { get; set; }

        /// <summary>
        /// The type of transaction-specific details of the payment method used in the payment. See
        /// <a
        /// href="https://stripe.com/docs/api/payment_methods/object#payment_method_object-type">PaymentMethod.type</a>
        /// for the full list of possible types. An additional hash is included on
        /// <c>payment_method_details</c> with a name matching this value. It contains information
        /// specific to the payment method.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
        public ChargePaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }

        [JsonProperty("wechat")]
        public ChargePaymentMethodDetailsWechat Wechat { get; set; }

        [JsonProperty("wechat_pay")]
        public ChargePaymentMethodDetailsWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
        public ChargePaymentMethodDetailsZip Zip { get; set; }
    }
}
