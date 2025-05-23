// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// The Billing customer portal is a Stripe-hosted UI for subscription and billing
    /// management.
    ///
    /// A portal configuration describes the functionality and features that you want to provide
    /// to your customers through the portal.
    ///
    /// A portal session describes the instantiation of the customer portal for a particular
    /// customer. By visiting the session's URL, the customer can manage their subscriptions and
    /// billing details. For security reasons, sessions are short-lived and will expire if the
    /// customer does not visit the URL. Create sessions on-demand when customers intend to
    /// manage their subscriptions and billing details.
    ///
    /// Related guide: <a href="https://stripe.com/customer-management">Customer management</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class Session : StripeEntity<Session>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        #region Expandable Configuration

        /// <summary>
        /// (ID of the Configuration)
        /// The configuration used by this session, describing the features available.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string ConfigurationId
        {
            get => this.InternalConfiguration?.Id;
            set => this.InternalConfiguration = SetExpandableFieldId(value, this.InternalConfiguration);
        }

        /// <summary>
        /// (Expanded)
        /// The configuration used by this session, describing the features available.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Configuration Configuration
        {
            get => this.InternalConfiguration?.ExpandedObject;
            set => this.InternalConfiguration = SetExpandableFieldObject(value, this.InternalConfiguration);
        }

        [JsonProperty("configuration")]
        [JsonConverter(typeof(ExpandableFieldConverter<Configuration>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("configuration")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Configuration>))]
#endif
        internal ExpandableField<Configuration> InternalConfiguration { get; set; }
        #endregion

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The ID of the customer for this session.
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
        [JsonProperty("flow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flow")]
#endif
        public SessionFlow Flow { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// The IETF language tag of the locale Customer Portal is displayed in. If blank or auto,
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
        /// The account for which the session was created on behalf of. When specified, only
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
        /// The URL to redirect customers to when they click on the portal's link to return to your
        /// website.
        /// </summary>
        [JsonProperty("return_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_url")]
#endif
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The short-lived URL of the session that gives customers access to the customer portal.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }
    }
}
