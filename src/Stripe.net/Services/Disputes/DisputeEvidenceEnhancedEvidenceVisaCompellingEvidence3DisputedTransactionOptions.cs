// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3DisputedTransactionOptions : INestedOptions
    {
        /// <summary>
        /// User Account ID used to log into business platform. Must be recognizable by the user.
        /// </summary>
        [JsonProperty("customer_account_id")]
        public string CustomerAccountId { get; set; }

        /// <summary>
        /// Unique identifier of the cardholder’s device derived from a combination of at least two
        /// hardware and software attributes. Must be at least 20 characters.
        /// </summary>
        [JsonProperty("customer_device_fingerprint")]
        public string CustomerDeviceFingerprint { get; set; }

        /// <summary>
        /// Unique identifier of the cardholder’s device such as a device serial number (e.g.,
        /// International Mobile Equipment Identity [IMEI]). Must be at least 15 characters.
        /// </summary>
        [JsonProperty("customer_device_id")]
        public string CustomerDeviceId { get; set; }

        /// <summary>
        /// The email address of the customer.
        /// </summary>
        [JsonProperty("customer_email_address")]
        public string CustomerEmailAddress { get; set; }

        /// <summary>
        /// The IP address that the customer used when making the purchase.
        /// </summary>
        [JsonProperty("customer_purchase_ip")]
        public string CustomerPurchaseIp { get; set; }

        /// <summary>
        /// Categorization of disputed payment.
        /// One of: <c>merchandise</c>, or <c>services</c>.
        /// </summary>
        [JsonProperty("merchandise_or_services")]
        public string MerchandiseOrServices { get; set; }

        /// <summary>
        /// A description of the product or service that was sold.
        /// </summary>
        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// The address to which a physical product was shipped. All fields are required for Visa
        /// Compelling Evidence 3.0 evidence submission.
        /// </summary>
        [JsonProperty("shipping_address")]
        public AddressOptions ShippingAddress { get; set; }
    }
}
