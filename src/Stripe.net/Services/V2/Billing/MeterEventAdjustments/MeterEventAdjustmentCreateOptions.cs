// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;

    public class MeterEventAdjustmentCreateOptions : BaseOptions
    {
        /// <summary>
        /// Specifies which event to cancel.
        /// </summary>
        [JsonProperty("cancel")]
        public MeterEventAdjustmentCreateCancelOptions Cancel { get; set; }

        /// <summary>
        /// The name of the meter event. Corresponds with the <c>event_name</c> field on a meter.
        /// </summary>
        [JsonProperty("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// Specifies whether to cancel a single event or a range of events for a time period. Time
        /// period cancellation is not supported yet.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
