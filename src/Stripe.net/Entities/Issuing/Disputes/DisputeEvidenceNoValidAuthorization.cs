// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class DisputeEvidenceNoValidAuthorization : StripeEntity<DisputeEvidenceNoValidAuthorization>
    {
        #region Expandable AdditionalDocumentation

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        /// </summary>
        [JsonIgnore]
        public string AdditionalDocumentationId
        {
            get => this.InternalAdditionalDocumentation?.Id;
            set => this.InternalAdditionalDocumentation = SetExpandableFieldId(value, this.InternalAdditionalDocumentation);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>)
        /// Additional documentation supporting the dispute.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public File AdditionalDocumentation
        {
            get => this.InternalAdditionalDocumentation?.ExpandedObject;
            set => this.InternalAdditionalDocumentation = SetExpandableFieldObject(value, this.InternalAdditionalDocumentation);
        }

        [JsonProperty("additional_documentation")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalAdditionalDocumentation { get; set; }
        #endregion

        /// <summary>
        /// Explanation of why the cardholder is disputing this transaction.
        /// </summary>
        [JsonProperty("explanation")]
        public string Explanation { get; set; }
    }
}
