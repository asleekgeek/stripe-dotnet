// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class DisputeService : Service,
        ICreatable<Dispute, DisputeCreateOptions>,
        IListable<Dispute, DisputeListOptions>,
        IRetrievable<Dispute, DisputeGetOptions>,
        IUpdatable<Dispute, DisputeUpdateOptions>
    {
        public DisputeService()
        {
        }

        internal DisputeService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public DisputeService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates an Issuing <c>Dispute</c> object. Individual pieces of evidence within the
        /// <c>evidence</c> object are optional at this point. Stripe only validates that required
        /// evidence is present during submission. Refer to <a
        /// href="https://stripe.com/docs/issuing/purchases/disputes#dispute-reasons-and-evidence">Dispute
        /// reasons and evidence</a> for more details about evidence requirements.</p>.
        /// </summary>
        public virtual Dispute Create(DisputeCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v1/issuing/disputes", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates an Issuing <c>Dispute</c> object. Individual pieces of evidence within the
        /// <c>evidence</c> object are optional at this point. Stripe only validates that required
        /// evidence is present during submission. Refer to <a
        /// href="https://stripe.com/docs/issuing/purchases/disputes#dispute-reasons-and-evidence">Dispute
        /// reasons and evidence</a> for more details about evidence requirements.</p>.
        /// </summary>
        public virtual Task<Dispute> CreateAsync(DisputeCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v1/issuing/disputes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves an Issuing <c>Dispute</c> object.</p>.
        /// </summary>
        public virtual Dispute Get(string id, DisputeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Dispute>(BaseAddress.Api, HttpMethod.Get, $"/v1/issuing/disputes/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves an Issuing <c>Dispute</c> object.</p>.
        /// </summary>
        public virtual Task<Dispute> GetAsync(string id, DisputeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Dispute>(BaseAddress.Api, HttpMethod.Get, $"/v1/issuing/disputes/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>Dispute</c> objects. The objects are sorted in
        /// descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual StripeList<Dispute> List(DisputeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Dispute>>(BaseAddress.Api, HttpMethod.Get, $"/v1/issuing/disputes", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>Dispute</c> objects. The objects are sorted in
        /// descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual Task<StripeList<Dispute>> ListAsync(DisputeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Dispute>>(BaseAddress.Api, HttpMethod.Get, $"/v1/issuing/disputes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>Dispute</c> objects. The objects are sorted in
        /// descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual IEnumerable<Dispute> ListAutoPaging(DisputeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Dispute>($"/v1/issuing/disputes", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>Dispute</c> objects. The objects are sorted in
        /// descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Dispute> ListAutoPagingAsync(DisputeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Dispute>($"/v1/issuing/disputes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Submits an Issuing <c>Dispute</c> to the card network. Stripe validates that all
        /// evidence fields required for the dispute’s reason are present. For more details, see <a
        /// href="https://stripe.com/docs/issuing/purchases/disputes#dispute-reasons-and-evidence">Dispute
        /// reasons and evidence</a>.</p>.
        /// </summary>
        public virtual Dispute Submit(string id, DisputeSubmitOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v1/issuing/disputes/{WebUtility.UrlEncode(id)}/submit", options, requestOptions);
        }

        /// <summary>
        /// <p>Submits an Issuing <c>Dispute</c> to the card network. Stripe validates that all
        /// evidence fields required for the dispute’s reason are present. For more details, see <a
        /// href="https://stripe.com/docs/issuing/purchases/disputes#dispute-reasons-and-evidence">Dispute
        /// reasons and evidence</a>.</p>.
        /// </summary>
        public virtual Task<Dispute> SubmitAsync(string id, DisputeSubmitOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v1/issuing/disputes/{WebUtility.UrlEncode(id)}/submit", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the specified Issuing <c>Dispute</c> object by setting the values of the
        /// parameters passed. Any parameters not provided will be left unchanged. Properties on the
        /// <c>evidence</c> object can be unset by passing in an empty string.</p>.
        /// </summary>
        public virtual Dispute Update(string id, DisputeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v1/issuing/disputes/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the specified Issuing <c>Dispute</c> object by setting the values of the
        /// parameters passed. Any parameters not provided will be left unchanged. Properties on the
        /// <c>evidence</c> object can be unset by passing in an empty string.</p>.
        /// </summary>
        public virtual Task<Dispute> UpdateAsync(string id, DisputeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v1/issuing/disputes/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
