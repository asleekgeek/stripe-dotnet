// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SettingsStatusDetailsPending : StripeEntity<SettingsStatusDetailsPending>
    {
        /// <summary>
        /// The list of missing fields that are required to perform calculations. It includes the
        /// entry <c>head_office</c> when the status is <c>pending</c>. It is recommended to set the
        /// optional values even if they aren't listed as required for calculating taxes.
        /// Calculations can fail if missing fields aren't explicitly provided on every call.
        /// </summary>
        [JsonProperty("missing_fields")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("missing_fields")]
#endif
        public List<string> MissingFields { get; set; }
    }
}
