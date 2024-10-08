// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CustomerPaymentSourceCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Please refer to full <a href="https://stripe.com/docs/api">documentation</a> instead.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("validate")]
        public bool? Validate { get; set; }
    }
}
