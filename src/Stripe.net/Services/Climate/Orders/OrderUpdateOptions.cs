// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Publicly sharable reference for the end beneficiary of carbon removal. Assumed to be the
        /// Stripe account if not set.
        /// </summary>
        [JsonProperty("beneficiary")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("beneficiary")]
#endif
        public OrderBeneficiaryOptions Beneficiary { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }
    }
}
