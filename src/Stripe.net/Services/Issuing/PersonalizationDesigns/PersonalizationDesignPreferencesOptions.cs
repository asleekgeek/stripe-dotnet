// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonalizationDesignPreferencesOptions : INestedOptions
    {
        /// <summary>
        /// Whether we use this personalization design to create cards when one isn't specified. A
        /// connected account uses the Connect platform's default design if no personalization
        /// design is set as the default design.
        /// </summary>
        [JsonProperty("is_default")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_default")]
#endif
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Only return the personalization design that is set as the Connect platform's default.
        /// This parameter is only applicable to connected accounts.
        /// </summary>
        [JsonProperty("is_platform_default")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_platform_default")]
#endif
        public bool? IsPlatformDefault { get; set; }
    }
}
