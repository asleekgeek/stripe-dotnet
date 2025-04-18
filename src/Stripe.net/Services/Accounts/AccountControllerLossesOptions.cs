// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountControllerLossesOptions : INestedOptions
    {
        /// <summary>
        /// A value indicating who is liable when this account can't pay back negative balances
        /// resulting from payments. Defaults to <c>stripe</c>.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments")]
#endif
        public string Payments { get; set; }
    }
}
