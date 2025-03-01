// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ConfirmationTokenPaymentMethodPreviewPaypal : StripeEntity<ConfirmationTokenPaymentMethodPreviewPaypal>
    {
        /// <summary>
        /// Two-letter ISO code representing the buyer's country. Values are provided by PayPal
        /// directly (if supported) at the time of authorization or settlement. They cannot be set
        /// or mutated.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Owner's email. Values are provided by PayPal directly (if supported) at the time of
        /// authorization or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("payer_email")]
        public string PayerEmail { get; set; }

        /// <summary>
        /// PayPal account PayerID. This identifier uniquely identifies the PayPal customer.
        /// </summary>
        [JsonProperty("payer_id")]
        public string PayerId { get; set; }
    }
}
