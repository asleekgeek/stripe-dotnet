// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionAddInvoiceItemOptions : INestedOptions
    {
        /// <summary>
        /// The coupons to redeem into discounts for the item.
        /// </summary>
        [JsonProperty("discounts")]
        public List<SubscriptionAddInvoiceItemDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// The ID of the price object. One of <c>price</c> or <c>price_data</c> is required.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://stripe.com/docs/api/prices">Price</a>
        /// object inline. One of <c>price</c> or <c>price_data</c> is required.
        /// </summary>
        [JsonProperty("price_data")]
        public SubscriptionAddInvoiceItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// Quantity for this item. Defaults to 1.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to the item. When set, the <c>default_tax_rates</c> do not
        /// apply to this item.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
