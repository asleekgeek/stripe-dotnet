// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenCardNetworksOptions : INestedOptions
    {
        /// <summary>
        /// The customer's preferred card network for co-branded cards. Supports
        /// <c>cartes_bancaires</c>, <c>mastercard</c>, or <c>visa</c>. Selection of a network that
        /// does not apply to the card will be stored as <c>invalid_preference</c> on the card.
        /// One of: <c>cartes_bancaires</c>, <c>mastercard</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("preferred")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preferred")]
#endif
        public string Preferred { get; set; }
    }
}
