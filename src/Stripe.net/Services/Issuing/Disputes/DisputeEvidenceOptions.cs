// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeEvidenceOptions : INestedOptions
    {
        /// <summary>
        /// Evidence provided when <c>reason</c> is 'canceled'.
        /// </summary>
        [JsonProperty("canceled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("canceled")]
#endif
        public DisputeEvidenceCanceledOptions Canceled { get; set; }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'duplicate'.
        /// </summary>
        [JsonProperty("duplicate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("duplicate")]
#endif
        public DisputeEvidenceDuplicateOptions Duplicate { get; set; }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'fraudulent'.
        /// </summary>
        [JsonProperty("fraudulent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fraudulent")]
#endif
        public DisputeEvidenceFraudulentOptions Fraudulent { get; set; }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'merchandise_not_as_described'.
        /// </summary>
        [JsonProperty("merchandise_not_as_described")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchandise_not_as_described")]
#endif
        public DisputeEvidenceMerchandiseNotAsDescribedOptions MerchandiseNotAsDescribed { get; set; }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'no_valid_authorization'.
        /// </summary>
        [JsonProperty("no_valid_authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("no_valid_authorization")]
#endif
        public DisputeEvidenceNoValidAuthorizationOptions NoValidAuthorization { get; set; }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'not_received'.
        /// </summary>
        [JsonProperty("not_received")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("not_received")]
#endif
        public DisputeEvidenceNotReceivedOptions NotReceived { get; set; }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'other'.
        /// </summary>
        [JsonProperty("other")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("other")]
#endif
        public DisputeEvidenceOtherOptions Other { get; set; }

        /// <summary>
        /// The reason for filing the dispute. The evidence should be submitted in the field of the
        /// same name.
        /// One of: <c>canceled</c>, <c>duplicate</c>, <c>fraudulent</c>,
        /// <c>merchandise_not_as_described</c>, <c>no_valid_authorization</c>, <c>not_received</c>,
        /// <c>other</c>, or <c>service_not_as_described</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }

        /// <summary>
        /// Evidence provided when <c>reason</c> is 'service_not_as_described'.
        /// </summary>
        [JsonProperty("service_not_as_described")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service_not_as_described")]
#endif
        public DisputeEvidenceServiceNotAsDescribedOptions ServiceNotAsDescribed { get; set; }
    }
}
