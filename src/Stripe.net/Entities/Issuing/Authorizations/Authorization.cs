// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// When an <a href="https://stripe.com/docs/issuing">issued card</a> is used to make a
    /// purchase, an Issuing <c>Authorization</c> object is created. <a
    /// href="https://stripe.com/docs/issuing/purchases/authorizations">Authorizations</a> must
    /// be approved for the purchase to be completed successfully.
    ///
    /// Related guide: <a href="https://stripe.com/docs/issuing/purchases/authorizations">Issued
    /// card authorizations</a>.
    /// </summary>
    public class Authorization : StripeEntity<Authorization>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The total amount that was authorized or rejected. This amount is in <c>currency</c> and
        /// in the <a href="https://stripe.com/docs/currencies#zero-decimal">smallest currency
        /// unit</a>. <c>amount</c> should be the same as <c>merchant_amount</c>, unless
        /// <c>currency</c> and <c>merchant_currency</c> are different.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Detailed breakdown of amount components. These amounts are denominated in
        /// <c>currency</c> and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount_details")]
        public AuthorizationAmountDetails AmountDetails { get; set; }

        /// <summary>
        /// Whether the authorization has been approved.
        /// </summary>
        [JsonProperty("approved")]
        public bool Approved { get; set; }

        /// <summary>
        /// How the card details were provided.
        /// One of: <c>chip</c>, <c>contactless</c>, <c>keyed_in</c>, <c>online</c>, or
        /// <c>swipe</c>.
        /// </summary>
        [JsonProperty("authorization_method")]
        public string AuthorizationMethod { get; set; }

        /// <summary>
        /// List of balance transactions associated with this authorization.
        /// </summary>
        [JsonProperty("balance_transactions")]
        public List<BalanceTransaction> BalanceTransactions { get; set; }

        /// <summary>
        /// You can <a href="https://stripe.com/docs/issuing">create physical or virtual cards</a>
        /// that are issued to cardholders.
        /// </summary>
        [JsonProperty("card")]
        public Card Card { get; set; }

        #region Expandable Cardholder

        /// <summary>
        /// (ID of the Cardholder)
        /// The cardholder to whom this authorization belongs.
        /// </summary>
        [JsonIgnore]
        public string CardholderId
        {
            get => this.InternalCardholder?.Id;
            set => this.InternalCardholder = SetExpandableFieldId(value, this.InternalCardholder);
        }

        /// <summary>
        /// (Expanded)
        /// The cardholder to whom this authorization belongs.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Cardholder Cardholder
        {
            get => this.InternalCardholder?.ExpandedObject;
            set => this.InternalCardholder = SetExpandableFieldObject(value, this.InternalCardholder);
        }

        [JsonProperty("cardholder")]
        [JsonConverter(typeof(ExpandableFieldConverter<Cardholder>))]
        internal ExpandableField<Cardholder> InternalCardholder { get; set; }
        #endregion

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The currency of the cardholder. This currency can be different from the currency
        /// presented at authorization and the <c>merchant_currency</c> field on this authorization.
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Fleet-specific information for authorizations using Fleet cards.
        /// </summary>
        [JsonProperty("fleet")]
        public AuthorizationFleet Fleet { get; set; }

        /// <summary>
        /// Fraud challenges sent to the cardholder, if this authorization was declined for fraud
        /// risk reasons.
        /// </summary>
        [JsonProperty("fraud_challenges")]
        public List<AuthorizationFraudChallenge> FraudChallenges { get; set; }

        /// <summary>
        /// Information about fuel that was purchased with this transaction. Typically this
        /// information is received from the merchant after the authorization has been approved and
        /// the fuel dispensed.
        /// </summary>
        [JsonProperty("fuel")]
        public AuthorizationFuel Fuel { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The total amount that was authorized or rejected. This amount is in the
        /// <c>merchant_currency</c> and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// <c>merchant_amount</c> should be the same as <c>amount</c>, unless
        /// <c>merchant_currency</c> and <c>currency</c> are different.
        /// </summary>
        [JsonProperty("merchant_amount")]
        public long MerchantAmount { get; set; }

        /// <summary>
        /// The local currency that was presented to the cardholder for the authorization. This
        /// currency can be different from the cardholder currency and the <c>currency</c> field on
        /// this authorization. Three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a>, in
        /// lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("merchant_currency")]
        public string MerchantCurrency { get; set; }

        [JsonProperty("merchant_data")]
        public AuthorizationMerchantData MerchantData { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Details about the authorization, such as identifiers, set by the card network.
        /// </summary>
        [JsonProperty("network_data")]
        public AuthorizationNetworkData NetworkData { get; set; }

        /// <summary>
        /// The pending authorization request. This field will only be non-null during an
        /// <c>issuing_authorization.request</c> webhook.
        /// </summary>
        [JsonProperty("pending_request")]
        public AuthorizationPendingRequest PendingRequest { get; set; }

        /// <summary>
        /// History of every time a <c>pending_request</c> authorization was approved/declined,
        /// either by you directly or by Stripe (e.g. based on your spending_controls). If the
        /// merchant changes the authorization by performing an incremental authorization, you can
        /// look at this field to see the previous requests for the authorization. This field can be
        /// helpful in determining why a given authorization was approved/declined.
        /// </summary>
        [JsonProperty("request_history")]
        public List<AuthorizationRequestHistory> RequestHistory { get; set; }

        /// <summary>
        /// The current status of the authorization in its lifecycle.
        /// One of: <c>closed</c>, <c>pending</c>, or <c>reversed</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        #region Expandable Token

        /// <summary>
        /// (ID of the Token)
        /// <a href="https://stripe.com/docs/api/issuing/tokens/object">Token</a> object used for
        /// this authorization. If a network token was not used for this authorization, this field
        /// will be null.
        /// </summary>
        [JsonIgnore]
        public string TokenId
        {
            get => this.InternalToken?.Id;
            set => this.InternalToken = SetExpandableFieldId(value, this.InternalToken);
        }

        /// <summary>
        /// (Expanded)
        /// <a href="https://stripe.com/docs/api/issuing/tokens/object">Token</a> object used for
        /// this authorization. If a network token was not used for this authorization, this field
        /// will be null.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Token Token
        {
            get => this.InternalToken?.ExpandedObject;
            set => this.InternalToken = SetExpandableFieldObject(value, this.InternalToken);
        }

        [JsonProperty("token")]
        [JsonConverter(typeof(ExpandableFieldConverter<Token>))]
        internal ExpandableField<Token> InternalToken { get; set; }
        #endregion

        /// <summary>
        /// List of <a href="https://stripe.com/docs/api/issuing/transactions">transactions</a>
        /// associated with this authorization.
        /// </summary>
        [JsonProperty("transactions")]
        public List<Transaction> Transactions { get; set; }

        /// <summary>
        /// <a href="https://stripe.com/docs/api/treasury">Treasury</a> details related to this
        /// authorization if it was created on a <a
        /// href="https://stripe.com/docs/api/treasury/financial_accounts">FinancialAccount</a>.
        /// </summary>
        [JsonProperty("treasury")]
        public AuthorizationTreasury Treasury { get; set; }

        [JsonProperty("verification_data")]
        public AuthorizationVerificationData VerificationData { get; set; }

        /// <summary>
        /// Whether the authorization bypassed fraud risk checks because the cardholder has
        /// previously completed a fraud challenge on a similar high-risk authorization from the
        /// same merchant.
        /// </summary>
        [JsonProperty("verified_by_fraud_challenge")]
        public bool? VerifiedByFraudChallenge { get; set; }

        /// <summary>
        /// The digital wallet used for this transaction. One of <c>apple_pay</c>,
        /// <c>google_pay</c>, or <c>samsung_pay</c>. Will populate as <c>null</c> when no digital
        /// wallet was utilized.
        /// </summary>
        [JsonProperty("wallet")]
        public string Wallet { get; set; }
    }
}
