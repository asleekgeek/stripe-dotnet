// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ConnectionTokenService : Service,
        ICreatable<ConnectionToken, ConnectionTokenCreateOptions>
    {
        public ConnectionTokenService()
        {
        }

        internal ConnectionTokenService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ConnectionTokenService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>To connect to a reader the Stripe Terminal SDK needs to retrieve a short-lived
        /// connection token from Stripe, proxied through your server. On your backend, add an
        /// endpoint that creates and returns a connection token.</p>.
        /// </summary>
        public virtual ConnectionToken Create(ConnectionTokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ConnectionToken>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/connection_tokens", options, requestOptions);
        }

        /// <summary>
        /// <p>To connect to a reader the Stripe Terminal SDK needs to retrieve a short-lived
        /// connection token from Stripe, proxied through your server. On your backend, add an
        /// endpoint that creates and returns a connection token.</p>.
        /// </summary>
        public virtual Task<ConnectionToken> CreateAsync(ConnectionTokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ConnectionToken>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/connection_tokens", options, requestOptions, cancellationToken);
        }
    }
}
