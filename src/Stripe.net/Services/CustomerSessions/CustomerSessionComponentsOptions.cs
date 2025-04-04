// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerSessionComponentsOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for buy button.
        /// </summary>
        [JsonProperty("buy_button")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("buy_button")]
#endif
        public CustomerSessionComponentsBuyButtonOptions BuyButton { get; set; }

        /// <summary>
        /// Configuration for the Payment Element.
        /// </summary>
        [JsonProperty("payment_element")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_element")]
#endif
        public CustomerSessionComponentsPaymentElementOptions PaymentElement { get; set; }

        /// <summary>
        /// Configuration for the pricing table.
        /// </summary>
        [JsonProperty("pricing_table")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_table")]
#endif
        public CustomerSessionComponentsPricingTableOptions PricingTable { get; set; }
    }
}
