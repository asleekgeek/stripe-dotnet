// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationBbposWiseposEOptions : INestedOptions
    {
        /// <summary>
        /// A File ID representing an image to display on the reader.
        /// </summary>
        [JsonProperty("splashscreen")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("splashscreen")]
#endif
        public string Splashscreen { get; set; }
    }
}
