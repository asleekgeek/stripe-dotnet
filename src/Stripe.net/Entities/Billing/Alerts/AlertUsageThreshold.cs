// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AlertUsageThreshold : StripeEntity<AlertUsageThreshold>
    {
        /// <summary>
        /// The filters allow limiting the scope of this usage alert. You can only specify up to one
        /// filter at this time.
        /// </summary>
        [JsonProperty("filters")]
        public List<AlertUsageThresholdFilter> Filters { get; set; }

        /// <summary>
        /// The value at which this alert will trigger.
        /// </summary>
        [JsonProperty("gte")]
        public long Gte { get; set; }

        #region Expandable Meter

        /// <summary>
        /// (ID of the Meter)
        /// The <a href="https://stripe.com/api/billing/meter">Billing Meter</a> ID whose usage is
        /// monitored.
        /// </summary>
        [JsonIgnore]
        public string MeterId
        {
            get => this.InternalMeter?.Id;
            set => this.InternalMeter = SetExpandableFieldId(value, this.InternalMeter);
        }

        /// <summary>
        /// (Expanded)
        /// The <a href="https://stripe.com/api/billing/meter">Billing Meter</a> ID whose usage is
        /// monitored.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Meter Meter
        {
            get => this.InternalMeter?.ExpandedObject;
            set => this.InternalMeter = SetExpandableFieldObject(value, this.InternalMeter);
        }

        [JsonProperty("meter")]
        [JsonConverter(typeof(ExpandableFieldConverter<Meter>))]
        internal ExpandableField<Meter> InternalMeter { get; set; }
        #endregion

        /// <summary>
        /// Defines how the alert will behave.
        /// </summary>
        [JsonProperty("recurrence")]
        public string Recurrence { get; set; }
    }
}
