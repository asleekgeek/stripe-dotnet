// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PersonalizationDesignService : Service,
        ICreatable<PersonalizationDesign, PersonalizationDesignCreateOptions>,
        IListable<PersonalizationDesign, PersonalizationDesignListOptions>,
        IRetrievable<PersonalizationDesign, PersonalizationDesignGetOptions>,
        IUpdatable<PersonalizationDesign, PersonalizationDesignUpdateOptions>
    {
        public PersonalizationDesignService()
        {
        }

        internal PersonalizationDesignService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PersonalizationDesignService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a personalization design object.</p>.
        /// </summary>
        public virtual PersonalizationDesign Create(PersonalizationDesignCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PersonalizationDesign>(BaseAddress.Api, HttpMethod.Post, $"/v1/issuing/personalization_designs", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a personalization design object.</p>.
        /// </summary>
        public virtual Task<PersonalizationDesign> CreateAsync(PersonalizationDesignCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PersonalizationDesign>(BaseAddress.Api, HttpMethod.Post, $"/v1/issuing/personalization_designs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a personalization design object.</p>.
        /// </summary>
        public virtual PersonalizationDesign Get(string id, PersonalizationDesignGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PersonalizationDesign>(BaseAddress.Api, HttpMethod.Get, $"/v1/issuing/personalization_designs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a personalization design object.</p>.
        /// </summary>
        public virtual Task<PersonalizationDesign> GetAsync(string id, PersonalizationDesignGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PersonalizationDesign>(BaseAddress.Api, HttpMethod.Get, $"/v1/issuing/personalization_designs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of personalization design objects. The objects are sorted in
        /// descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual StripeList<PersonalizationDesign> List(PersonalizationDesignListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PersonalizationDesign>>(BaseAddress.Api, HttpMethod.Get, $"/v1/issuing/personalization_designs", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of personalization design objects. The objects are sorted in
        /// descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual Task<StripeList<PersonalizationDesign>> ListAsync(PersonalizationDesignListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PersonalizationDesign>>(BaseAddress.Api, HttpMethod.Get, $"/v1/issuing/personalization_designs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of personalization design objects. The objects are sorted in
        /// descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual IEnumerable<PersonalizationDesign> ListAutoPaging(PersonalizationDesignListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PersonalizationDesign>($"/v1/issuing/personalization_designs", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of personalization design objects. The objects are sorted in
        /// descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<PersonalizationDesign> ListAutoPagingAsync(PersonalizationDesignListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PersonalizationDesign>($"/v1/issuing/personalization_designs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a card personalization object.</p>.
        /// </summary>
        public virtual PersonalizationDesign Update(string id, PersonalizationDesignUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PersonalizationDesign>(BaseAddress.Api, HttpMethod.Post, $"/v1/issuing/personalization_designs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a card personalization object.</p>.
        /// </summary>
        public virtual Task<PersonalizationDesign> UpdateAsync(string id, PersonalizationDesignUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PersonalizationDesign>(BaseAddress.Api, HttpMethod.Post, $"/v1/issuing/personalization_designs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
