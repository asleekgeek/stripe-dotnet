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
    /// Balance transactions represent funds moving through your Stripe account. Stripe creates
    /// them for every type of transaction that enters or leaves your Stripe account balance.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/docs/reports/balance-transaction-types">Balance transaction
    /// types</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class BalanceTransaction : StripeEntity<BalanceTransaction>, IHasId, IHasObject
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
        /// Gross amount of this transaction (in cents (or local equivalent)). A positive value
        /// represents funds charged to another party, and a negative value represents funds sent to
        /// another party.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// The date that the transaction's net funds become available in the Stripe balance.
        /// </summary>
        [JsonProperty("available_on")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available_on")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime AvailableOn { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The balance that this transaction impacts.
        /// One of: <c>issuing</c>, <c>payments</c>, or <c>refund_and_dispute_prefunding</c>.
        /// </summary>
        [JsonProperty("balance_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance_type")]
#endif
        public string BalanceType { get; set; }

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
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// If applicable, this transaction uses an exchange rate. If money converts from currency A
        /// to currency B, then the <c>amount</c> in currency A, multipled by the
        /// <c>exchange_rate</c>, equals the <c>amount</c> in currency B. For example, if you charge
        /// a customer 10.00 EUR, the PaymentIntent's <c>amount</c> is <c>1000</c> and
        /// <c>currency</c> is <c>eur</c>. If this converts to 12.34 USD in your Stripe account, the
        /// BalanceTransaction's <c>amount</c> is <c>1234</c>, its <c>currency</c> is <c>usd</c>,
        /// and the <c>exchange_rate</c> is <c>1.234</c>.
        /// </summary>
        [JsonProperty("exchange_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exchange_rate")]
#endif
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Fees (in cents (or local equivalent)) paid for this transaction. Represented as a
        /// positive integer when assessed.
        /// </summary>
        [JsonProperty("fee")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fee")]
#endif
        public long Fee { get; set; }

        /// <summary>
        /// Detailed breakdown of fees (in cents (or local equivalent)) paid for this transaction.
        /// </summary>
        [JsonProperty("fee_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fee_details")]
#endif
        public List<BalanceTransactionFeeDetail> FeeDetails { get; set; }

        /// <summary>
        /// Net impact to a Stripe balance (in cents (or local equivalent)). A positive value
        /// represents incrementing a Stripe balance, and a negative value decrementing a Stripe
        /// balance. You can calculate the net impact of a transaction on a balance by <c>amount</c>
        /// - <c>fee</c>.
        /// </summary>
        [JsonProperty("net")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("net")]
#endif
        public long Net { get; set; }

        /// <summary>
        /// Learn more about how <a
        /// href="https://stripe.com/docs/reports/reporting-categories">reporting categories</a> can
        /// help you understand balance transactions from an accounting perspective.
        /// </summary>
        [JsonProperty("reporting_category")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reporting_category")]
#endif
        public string ReportingCategory { get; set; }

        #region Expandable Source

        /// <summary>
        /// (ID of the IBalanceTransactionSource)
        /// This transaction relates to the Stripe object.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string SourceId
        {
            get => this.InternalSource?.Id;
            set => this.InternalSource = SetExpandableFieldId(value, this.InternalSource);
        }

        /// <summary>
        /// (Expanded)
        /// This transaction relates to the Stripe object.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public IBalanceTransactionSource Source
        {
            get => this.InternalSource?.ExpandedObject;
            set => this.InternalSource = SetExpandableFieldObject(value, this.InternalSource);
        }

        [JsonProperty("source")]
        [JsonConverter(typeof(ExpandableFieldConverter<IBalanceTransactionSource>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<IBalanceTransactionSource>))]
#endif
        internal ExpandableField<IBalanceTransactionSource> InternalSource { get; set; }
        #endregion

        /// <summary>
        /// The transaction's net funds status in the Stripe balance, which are either
        /// <c>available</c> or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Transaction type: <c>adjustment</c>, <c>advance</c>, <c>advance_funding</c>,
        /// <c>anticipation_repayment</c>, <c>application_fee</c>, <c>application_fee_refund</c>,
        /// <c>charge</c>, <c>climate_order_purchase</c>, <c>climate_order_refund</c>,
        /// <c>connect_collection_transfer</c>, <c>contribution</c>,
        /// <c>issuing_authorization_hold</c>, <c>issuing_authorization_release</c>,
        /// <c>issuing_dispute</c>, <c>issuing_transaction</c>, <c>obligation_outbound</c>,
        /// <c>obligation_reversal_inbound</c>, <c>payment</c>, <c>payment_failure_refund</c>,
        /// <c>payment_network_reserve_hold</c>, <c>payment_network_reserve_release</c>,
        /// <c>payment_refund</c>, <c>payment_reversal</c>, <c>payment_unreconciled</c>,
        /// <c>payout</c>, <c>payout_cancel</c>, <c>payout_failure</c>,
        /// <c>payout_minimum_balance_hold</c>, <c>payout_minimum_balance_release</c>,
        /// <c>refund</c>, <c>refund_failure</c>, <c>reserve_transaction</c>, <c>reserved_funds</c>,
        /// <c>stripe_fee</c>, <c>stripe_fx_fee</c>, <c>stripe_balance_payment_debit</c>,
        /// <c>stripe_balance_payment_debit_reversal</c>, <c>tax_fee</c>, <c>topup</c>,
        /// <c>topup_reversal</c>, <c>transfer</c>, <c>transfer_cancel</c>, <c>transfer_failure</c>,
        /// or <c>transfer_refund</c>. Learn more about <a
        /// href="https://stripe.com/docs/reports/balance-transaction-types">balance transaction
        /// types and what they represent</a>. To classify transactions for accounting purposes,
        /// consider <c>reporting_category</c> instead.
        /// One of: <c>adjustment</c>, <c>advance</c>, <c>advance_funding</c>,
        /// <c>anticipation_repayment</c>, <c>application_fee</c>, <c>application_fee_refund</c>,
        /// <c>charge</c>, <c>climate_order_purchase</c>, <c>climate_order_refund</c>,
        /// <c>connect_collection_transfer</c>, <c>contribution</c>,
        /// <c>issuing_authorization_hold</c>, <c>issuing_authorization_release</c>,
        /// <c>issuing_dispute</c>, <c>issuing_transaction</c>, <c>obligation_outbound</c>,
        /// <c>obligation_reversal_inbound</c>, <c>payment</c>, <c>payment_failure_refund</c>,
        /// <c>payment_network_reserve_hold</c>, <c>payment_network_reserve_release</c>,
        /// <c>payment_refund</c>, <c>payment_reversal</c>, <c>payment_unreconciled</c>,
        /// <c>payout</c>, <c>payout_cancel</c>, <c>payout_failure</c>,
        /// <c>payout_minimum_balance_hold</c>, <c>payout_minimum_balance_release</c>,
        /// <c>refund</c>, <c>refund_failure</c>, <c>reserve_transaction</c>, <c>reserved_funds</c>,
        /// <c>stripe_balance_payment_debit</c>, <c>stripe_balance_payment_debit_reversal</c>,
        /// <c>stripe_fee</c>, <c>stripe_fx_fee</c>, <c>tax_fee</c>, <c>topup</c>,
        /// <c>topup_reversal</c>, <c>transfer</c>, <c>transfer_cancel</c>, <c>transfer_failure</c>,
        /// or <c>transfer_refund</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
