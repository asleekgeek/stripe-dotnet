// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class VerificationSessionLastError : StripeEntity<VerificationSessionLastError>
    {
        /// <summary>
        /// A short machine-readable string giving the reason for the verification or user-session
        /// failure.
        /// One of: <c>abandoned</c>, <c>consent_declined</c>, <c>country_not_supported</c>,
        /// <c>device_not_supported</c>, <c>document_expired</c>,
        /// <c>document_type_not_supported</c>, <c>document_unverified_other</c>,
        /// <c>email_unverified_other</c>, <c>email_verification_declined</c>,
        /// <c>id_number_insufficient_document_data</c>, <c>id_number_mismatch</c>,
        /// <c>id_number_unverified_other</c>, <c>phone_unverified_other</c>,
        /// <c>phone_verification_declined</c>, <c>selfie_document_missing_photo</c>,
        /// <c>selfie_face_mismatch</c>, <c>selfie_manipulated</c>, <c>selfie_unverified_other</c>,
        /// or <c>under_supported_age</c>.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif
        public string Code { get; set; }

        /// <summary>
        /// A message that explains the reason for verification or user-session failure.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }
    }
}
