// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenNetworkDataMastercard : StripeEntity<TokenNetworkDataMastercard>
    {
        /// <summary>
        /// A unique reference ID from MasterCard to represent the card account number.
        /// </summary>
        [JsonProperty("card_reference_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_reference_id")]
#endif
        public string CardReferenceId { get; set; }

        /// <summary>
        /// The network-unique identifier for the token.
        /// </summary>
        [JsonProperty("token_reference_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token_reference_id")]
#endif
        public string TokenReferenceId { get; set; }

        /// <summary>
        /// The ID of the entity requesting tokenization, specific to MasterCard.
        /// </summary>
        [JsonProperty("token_requestor_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token_requestor_id")]
#endif
        public string TokenRequestorId { get; set; }

        /// <summary>
        /// The name of the entity requesting tokenization, if known. This is directly provided from
        /// MasterCard.
        /// </summary>
        [JsonProperty("token_requestor_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token_requestor_name")]
#endif
        public string TokenRequestorName { get; set; }
    }
}
