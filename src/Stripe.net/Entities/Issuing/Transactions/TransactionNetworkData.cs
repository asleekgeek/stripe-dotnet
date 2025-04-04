// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionNetworkData : StripeEntity<TransactionNetworkData>
    {
        /// <summary>
        /// A code created by Stripe which is shared with the merchant to validate the
        /// authorization. This field will be populated if the authorization message was approved.
        /// The code typically starts with the letter "S", followed by a six-digit number. For
        /// example, "S498162". Please note that the code is not guaranteed to be unique across
        /// authorizations.
        /// </summary>
        [JsonProperty("authorization_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization_code")]
#endif
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// The date the transaction was processed by the card network. This can be different from
        /// the date the seller recorded the transaction depending on when the acquirer submits the
        /// transaction to the network.
        /// </summary>
        [JsonProperty("processing_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("processing_date")]
#endif
        public string ProcessingDate { get; set; }

        /// <summary>
        /// Unique identifier for the authorization assigned by the card network used to match
        /// subsequent messages, disputes, and transactions.
        /// </summary>
        [JsonProperty("transaction_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_id")]
#endif
        public string TransactionId { get; set; }
    }
}
