// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceUpcomingLinesSubscriptionItemOptions : INestedOptions, IHasId, IHasMetadata
    {
        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period. When updating, pass an empty string to remove previously-defined
        /// thresholds.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public InvoiceUpcomingLinesSubscriptionItemBillingThresholdsOptions BillingThresholds { get; set; }

        /// <summary>
        /// Delete all usage for a given subscription item. You must pass this when deleting a usage
        /// records subscription item. <c>clear_usage</c> has no effect if the plan has a billing
        /// meter attached.
        /// </summary>
        [JsonProperty("clear_usage")]
        public bool? ClearUsage { get; set; }

        /// <summary>
        /// A flag that, if set to <c>true</c>, will delete the specified item.
        /// </summary>
        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// The coupons to redeem into discounts for the subscription item.
        /// </summary>
        [JsonProperty("discounts")]
        public List<InvoiceUpcomingLinesSubscriptionItemDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// Subscription item to update.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Plan ID for this item, as a string.
        /// </summary>
        [JsonProperty("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// The ID of the price object. One of <c>price</c> or <c>price_data</c> is required. When
        /// changing a subscription item's price, <c>quantity</c> is set to 1 unless a
        /// <c>quantity</c> parameter is provided.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://stripe.com/docs/api/prices">Price</a>
        /// object inline. One of <c>price</c> or <c>price_data</c> is required.
        /// </summary>
        [JsonProperty("price_data")]
        public InvoiceUpcomingLinesSubscriptionItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// Quantity for this item.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// A list of <a href="https://stripe.com/docs/api/tax_rates">Tax Rate</a> ids. These Tax
        /// Rates will override the <a
        /// href="https://stripe.com/docs/api/subscriptions/create#create_subscription-default_tax_rates"><c>default_tax_rates</c></a>
        /// on the Subscription. When updating, pass an empty string to remove previously-defined
        /// tax rates.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
