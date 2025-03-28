// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceSubscriptionDetails : StripeEntity<InvoiceSubscriptionDetails>, IHasMetadata
    {
        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> defined as
        /// subscription metadata when an invoice is created. Becomes an immutable snapshot of the
        /// subscription metadata at the time of invoice finalization. <em>Note: This attribute is
        /// populated only for invoices created on or after June 29, 2023.</em>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }
    }
}
