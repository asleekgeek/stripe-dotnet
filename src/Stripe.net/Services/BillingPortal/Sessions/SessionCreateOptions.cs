// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of an existing <a
        /// href="https://stripe.com/docs/api/customer_portal/configuration">configuration</a> to
        /// use for this session, describing its functionality and features. If not specified, the
        /// session uses the default configuration.
        /// </summary>
        [JsonProperty("configuration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("configuration")]
#endif
        public string Configuration { get; set; }

        /// <summary>
        /// The ID of an existing customer.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// Information about a specific flow for the customer to go through. See the <a
        /// href="https://stripe.com/docs/customer-management/portal-deep-links">docs</a> to learn
        /// more about using customer portal deep links and flows.
        /// </summary>
        [JsonProperty("flow_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flow_data")]
#endif
        public SessionFlowDataOptions FlowData { get; set; }

        /// <summary>
        /// The IETF language tag of the locale customer portal is displayed in. If blank or auto,
        /// the customer’s <c>preferred_locales</c> or browser’s locale is used.
        /// One of: <c>auto</c>, <c>bg</c>, <c>cs</c>, <c>da</c>, <c>de</c>, <c>el</c>, <c>en</c>,
        /// <c>en-AU</c>, <c>en-CA</c>, <c>en-GB</c>, <c>en-IE</c>, <c>en-IN</c>, <c>en-NZ</c>,
        /// <c>en-SG</c>, <c>es</c>, <c>es-419</c>, <c>et</c>, <c>fi</c>, <c>fil</c>, <c>fr</c>,
        /// <c>fr-CA</c>, <c>hr</c>, <c>hu</c>, <c>id</c>, <c>it</c>, <c>ja</c>, <c>ko</c>,
        /// <c>lt</c>, <c>lv</c>, <c>ms</c>, <c>mt</c>, <c>nb</c>, <c>nl</c>, <c>pl</c>, <c>pt</c>,
        /// <c>pt-BR</c>, <c>ro</c>, <c>ru</c>, <c>sk</c>, <c>sl</c>, <c>sv</c>, <c>th</c>,
        /// <c>tr</c>, <c>vi</c>, <c>zh</c>, <c>zh-HK</c>, or <c>zh-TW</c>.
        /// </summary>
        [JsonProperty("locale")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("locale")]
#endif
        public string Locale { get; set; }

        /// <summary>
        /// The <c>on_behalf_of</c> account to use for this session. When specified, only
        /// subscriptions and invoices with this <c>on_behalf_of</c> account appear in the portal.
        /// For more information, see the <a
        /// href="https://stripe.com/docs/connect/separate-charges-and-transfers#settlement-merchant">docs</a>.
        /// Use the <a
        /// href="https://stripe.com/docs/api/accounts/object#account_object-settings-branding">Accounts
        /// API</a> to modify the <c>on_behalf_of</c> account's branding settings, which the portal
        /// displays.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// The default URL to redirect customers to when they click on the portal's link to return
        /// to your website.
        /// </summary>
        [JsonProperty("return_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_url")]
#endif
        public string ReturnUrl { get; set; }
    }
}
