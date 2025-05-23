// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteComputedUpfront : StripeEntity<QuoteComputedUpfront>
    {
        /// <summary>
        /// Total before any discounts or taxes are applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_subtotal")]
#endif
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total after discounts and taxes are applied.
        /// </summary>
        [JsonProperty("amount_total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_total")]
#endif
        public long AmountTotal { get; set; }

        /// <summary>
        /// The line items that will appear on the next invoice after this quote is accepted. This
        /// does not include pending invoice items that exist on the customer but may still be
        /// included in the next invoice.
        /// </summary>
        [JsonProperty("line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_items")]
#endif
        public StripeList<LineItem> LineItems { get; set; }

        [JsonProperty("total_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total_details")]
#endif
        public QuoteComputedUpfrontTotalDetails TotalDetails { get; set; }
    }
}
