// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The customer's address.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public AddressOptions Address { get; set; }

        /// <summary>
        /// An integer amount in cents (or local equivalent) that represents the customer's current
        /// balance, which affect the customer's future invoices. A negative amount represents a
        /// credit that decreases the amount due on an invoice; a positive amount increases the
        /// amount due on an invoice.
        /// </summary>
        [JsonProperty("balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance")]
#endif
        public long? Balance { get; set; }

        /// <summary>
        /// Balance information and default balance settings for this customer.
        /// </summary>
        [JsonProperty("cash_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cash_balance")]
#endif
        public CustomerCashBalanceOptions CashBalance { get; set; }

        /// <summary>
        /// If you are using payment methods created via the PaymentMethods API, see the <a
        /// href="https://stripe.com/docs/api/customers/update#update_customer-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a>
        /// parameter.
        ///
        /// Provide the ID of a payment source already attached to this customer to make it this
        /// customer's default payment source.
        ///
        /// If you want to add a new payment source and make it the default, see the <a
        /// href="https://stripe.com/docs/api/customers/update#update_customer-source">source</a>
        /// property.
        /// </summary>
        [JsonProperty("default_source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_source")]
#endif
        public string DefaultSource { get; set; }

        /// <summary>
        /// An arbitrary string that you can attach to a customer object. It is displayed alongside
        /// the customer in the dashboard.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Customer's email address. It's displayed alongside the customer in your dashboard and
        /// can be useful for searching and tracking. This may be up to <em>512 characters</em>.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public string Email { get; set; }

        /// <summary>
        /// The prefix for the customer used to generate unique invoice numbers. Must be 3–12
        /// uppercase letters or numbers.
        /// </summary>
        [JsonProperty("invoice_prefix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_prefix")]
#endif
        public string InvoicePrefix { get; set; }

        /// <summary>
        /// Default invoice settings for this customer.
        /// </summary>
        [JsonProperty("invoice_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_settings")]
#endif
        public CustomerInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The customer's full name or business name.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// The sequence to be used on the customer's next invoice. Defaults to 1.
        /// </summary>
        [JsonProperty("next_invoice_sequence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("next_invoice_sequence")]
#endif
        public long? NextInvoiceSequence { get; set; }

        /// <summary>
        /// The customer's phone number.
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public string Phone { get; set; }

        /// <summary>
        /// Customer's preferred languages, ordered by preference.
        /// </summary>
        [JsonProperty("preferred_locales")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preferred_locales")]
#endif
        public List<string> PreferredLocales { get; set; }

        /// <summary>
        /// The customer's shipping information. Appears on invoices emailed to this customer.
        /// </summary>
        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif
        public ShippingOptions Shipping { get; set; }

        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<string, CardCreateNestedOptions> Source { get; set; }

        /// <summary>
        /// Tax details about the customer.
        /// </summary>
        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif
        public CustomerTaxOptions Tax { get; set; }

        /// <summary>
        /// The customer's tax exemption. One of <c>none</c>, <c>exempt</c>, or <c>reverse</c>.
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonProperty("tax_exempt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_exempt")]
#endif
        public string TaxExempt { get; set; }

        [JsonProperty("validate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validate")]
#endif
        public bool? Validate { get; set; }
    }
}
