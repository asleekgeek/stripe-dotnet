// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderInputToggleOptions : INestedOptions
    {
        /// <summary>
        /// The default value of the toggle.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("default_value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_value")]
#endif
        public string DefaultValue { get; set; }

        /// <summary>
        /// The description which will be displayed for the toggle.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The title which will be displayed for the toggle.
        /// </summary>
        [JsonProperty("title")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("title")]
#endif
        public string Title { get; set; }
    }
}
