// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class MeterEventCreateOptions : BaseOptions
    {
        /// <summary>
        /// The name of the meter event. Corresponds with the <c>event_name</c> field on a meter.
        /// </summary>
        [JsonProperty("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// A unique identifier for the event. If not provided, one will be generated. We recommend
        /// using a globally unique identifier for this. We’ll enforce uniqueness within a rolling
        /// 24 hour period.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// The payload of the event. This must contain the fields corresponding to a meter’s
        /// <c>customer_mapping.event_payload_key</c> (default is <c>stripe_customer_id</c>) and
        /// <c>value_settings.event_payload_key</c> (default is <c>value</c>). Read more about the
        /// <a
        /// href="https://docs.stripe.com/billing/subscriptions/usage-based/recording-usage#payload-key-overrides">payload</a>.
        /// </summary>
        [JsonProperty("payload")]
        public Dictionary<string, string> Payload { get; set; }

        /// <summary>
        /// The time of the event. Must be within the past 35 calendar days or up to 5 minutes in
        /// the future. Defaults to current timestamp if not specified.
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }
    }
}
