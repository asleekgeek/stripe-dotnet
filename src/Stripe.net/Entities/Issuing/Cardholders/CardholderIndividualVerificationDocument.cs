// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class CardholderIndividualVerificationDocument : StripeEntity<CardholderIndividualVerificationDocument>
    {
        #region Expandable Back

        /// <summary>
        /// (ID of the File)
        /// The back of a document returned by a <a
        /// href="https://stripe.com/docs/api#create_file">file upload</a> with a <c>purpose</c>
        /// value of <c>identity_document</c>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string BackId
        {
            get => this.InternalBack?.Id;
            set => this.InternalBack = SetExpandableFieldId(value, this.InternalBack);
        }

        /// <summary>
        /// (Expanded)
        /// The back of a document returned by a <a
        /// href="https://stripe.com/docs/api#create_file">file upload</a> with a <c>purpose</c>
        /// value of <c>identity_document</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public File Back
        {
            get => this.InternalBack?.ExpandedObject;
            set => this.InternalBack = SetExpandableFieldObject(value, this.InternalBack);
        }

        [JsonProperty("back")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("back")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<File>))]
#endif
        internal ExpandableField<File> InternalBack { get; set; }
        #endregion

        #region Expandable Front

        /// <summary>
        /// (ID of the File)
        /// The front of a document returned by a <a
        /// href="https://stripe.com/docs/api#create_file">file upload</a> with a <c>purpose</c>
        /// value of <c>identity_document</c>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string FrontId
        {
            get => this.InternalFront?.Id;
            set => this.InternalFront = SetExpandableFieldId(value, this.InternalFront);
        }

        /// <summary>
        /// (Expanded)
        /// The front of a document returned by a <a
        /// href="https://stripe.com/docs/api#create_file">file upload</a> with a <c>purpose</c>
        /// value of <c>identity_document</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public File Front
        {
            get => this.InternalFront?.ExpandedObject;
            set => this.InternalFront = SetExpandableFieldObject(value, this.InternalFront);
        }

        [JsonProperty("front")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("front")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<File>))]
#endif
        internal ExpandableField<File> InternalFront { get; set; }
        #endregion
    }
}
