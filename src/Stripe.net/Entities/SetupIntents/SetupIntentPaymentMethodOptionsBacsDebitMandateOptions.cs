// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsBacsDebitMandateOptions : StripeEntity<SetupIntentPaymentMethodOptionsBacsDebitMandateOptions>
    {
        /// <summary>
        /// Prefix used to generate the Mandate reference. Must be at most 12 characters long. Must
        /// consist of only uppercase letters, numbers, spaces, or the following special characters:
        /// '/', '_', '-', '&amp;', '.'. Cannot begin with 'DDIC' or 'STRIPE'.
        /// </summary>
        [JsonProperty("reference_prefix")]
        public string ReferencePrefix { get; set; }
    }
}
