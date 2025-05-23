// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentPaymentMethodDataP24Options : INestedOptions
    {
        /// <summary>
        /// The customer's bank.
        /// One of: <c>alior_bank</c>, <c>bank_millennium</c>, <c>bank_nowy_bfg_sa</c>,
        /// <c>bank_pekao_sa</c>, <c>banki_spbdzielcze</c>, <c>blik</c>, <c>bnp_paribas</c>,
        /// <c>boz</c>, <c>citi_handlowy</c>, <c>credit_agricole</c>, <c>envelobank</c>,
        /// <c>etransfer_pocztowy24</c>, <c>getin_bank</c>, <c>ideabank</c>, <c>ing</c>,
        /// <c>inteligo</c>, <c>mbank_mtransfer</c>, <c>nest_przelew</c>, <c>noble_pay</c>,
        /// <c>pbac_z_ipko</c>, <c>plus_bank</c>, <c>santander_przelew24</c>,
        /// <c>tmobile_usbugi_bankowe</c>, <c>toyota_bank</c>, <c>velobank</c>, or
        /// <c>volkswagen_bank</c>.
        /// </summary>
        [JsonProperty("bank")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank")]
#endif
        public string Bank { get; set; }
    }
}
