// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionItemTrialOptions : INestedOptions
    {
        /// <summary>
        /// Determines the type of trial for this item.
        /// One of: <c>free</c>, or <c>paid</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}