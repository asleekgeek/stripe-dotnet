// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Each customer has a <a
    /// href="https://stripe.com/docs/api/customers/object#customer_object-balance">Balance</a>
    /// value, which denotes a debit or credit that's automatically applied to their next
    /// invoice upon finalization. You may modify the value directly by using the <a
    /// href="https://stripe.com/docs/api/customers/update">update customer API</a>, or by
    /// creating a Customer Balance Transaction, which increments or decrements the customer's
    /// <c>balance</c> by the specified <c>amount</c>.
    ///
    /// Related guide: <a href="https://stripe.com/docs/billing/customer/balance">Customer
    /// balance</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class CustomerBalanceTransaction : StripeEntity<CustomerBalanceTransaction>, IHasId, IHasMetadata, IHasObject
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

        /// <summary>
        /// The amount of the transaction. A negative value is a credit for the customer's balance,
        /// and a positive value is a debit to the customer's <c>balance</c>.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        #region Expandable CheckoutSession

        /// <summary>
        /// (ID of the Checkout.Session)
        /// The ID of the checkout session (if any) that created the transaction.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string CheckoutSessionId
        {
            get => this.InternalCheckoutSession?.Id;
            set => this.InternalCheckoutSession = SetExpandableFieldId(value, this.InternalCheckoutSession);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the checkout session (if any) that created the transaction.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Checkout.Session CheckoutSession
        {
            get => this.InternalCheckoutSession?.ExpandedObject;
            set => this.InternalCheckoutSession = SetExpandableFieldObject(value, this.InternalCheckoutSession);
        }

        [JsonProperty("checkout_session")]
        [JsonConverter(typeof(ExpandableFieldConverter<Checkout.Session>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("checkout_session")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Checkout.Session>))]
#endif
        internal ExpandableField<Checkout.Session> InternalCheckoutSession { get; set; }
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

        #region Expandable CreditNote

        /// <summary>
        /// (ID of the CreditNote)
        /// The ID of the credit note (if any) related to the transaction.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string CreditNoteId
        {
            get => this.InternalCreditNote?.Id;
            set => this.InternalCreditNote = SetExpandableFieldId(value, this.InternalCreditNote);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the credit note (if any) related to the transaction.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public CreditNote CreditNote
        {
            get => this.InternalCreditNote?.ExpandedObject;
            set => this.InternalCreditNote = SetExpandableFieldObject(value, this.InternalCreditNote);
        }

        [JsonProperty("credit_note")]
        [JsonConverter(typeof(ExpandableFieldConverter<CreditNote>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_note")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<CreditNote>))]
#endif
        internal ExpandableField<CreditNote> InternalCreditNote { get; set; }
        #endregion

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the customer the transaction belongs to.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the customer the transaction belongs to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
#endif
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The customer's <c>balance</c> after the transaction was applied. A negative value
        /// decreases the amount due on the customer's next invoice. A positive value increases the
        /// amount due on the customer's next invoice.
        /// </summary>
        [JsonProperty("ending_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ending_balance")]
#endif
        public long EndingBalance { get; set; }

        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// The ID of the invoice (if any) related to the transaction.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string InvoiceId
        {
            get => this.InternalInvoice?.Id;
            set => this.InternalInvoice = SetExpandableFieldId(value, this.InternalInvoice);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the invoice (if any) related to the transaction.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Invoice Invoice
        {
            get => this.InternalInvoice?.ExpandedObject;
            set => this.InternalInvoice = SetExpandableFieldObject(value, this.InternalInvoice);
        }

        [JsonProperty("invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Invoice>))]
#endif
        internal ExpandableField<Invoice> InternalInvoice { get; set; }
        #endregion

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
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Transaction type: <c>adjustment</c>, <c>applied_to_invoice</c>, <c>credit_note</c>,
        /// <c>initial</c>, <c>invoice_overpaid</c>, <c>invoice_too_large</c>,
        /// <c>invoice_too_small</c>, <c>unspent_receiver_credit</c>, <c>unapplied_from_invoice</c>,
        /// <c>checkout_session_subscription_payment</c>, or
        /// <c>checkout_session_subscription_payment_canceled</c>. See the <a
        /// href="https://stripe.com/docs/billing/customer/balance#types">Customer Balance page</a>
        /// to learn more about transaction types.
        /// One of: <c>adjustment</c>, <c>applied_to_invoice</c>,
        /// <c>checkout_session_subscription_payment</c>,
        /// <c>checkout_session_subscription_payment_canceled</c>, <c>credit_note</c>,
        /// <c>initial</c>, <c>invoice_overpaid</c>, <c>invoice_too_large</c>,
        /// <c>invoice_too_small</c>, <c>migration</c>, <c>unapplied_from_invoice</c>, or
        /// <c>unspent_receiver_credit</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
