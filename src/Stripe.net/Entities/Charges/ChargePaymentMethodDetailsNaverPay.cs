// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsNaverPay : StripeEntity<ChargePaymentMethodDetailsNaverPay>
    {
        /// <summary>
        /// A unique identifier for the buyer as determined by the local payment processor.
        /// </summary>
        [JsonProperty("buyer_id")]
        public string BuyerId { get; set; }
    }
}
