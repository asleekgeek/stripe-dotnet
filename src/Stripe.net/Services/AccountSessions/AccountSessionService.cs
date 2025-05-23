// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountSessionService : Service,
        ICreatable<AccountSession, AccountSessionCreateOptions>
    {
        public AccountSessionService()
        {
        }

        internal AccountSessionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public AccountSessionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a AccountSession object that includes a single-use token that the platform
        /// can use on their front-end to grant client-side API access.</p>.
        /// </summary>
        public virtual AccountSession Create(AccountSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AccountSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/account_sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a AccountSession object that includes a single-use token that the platform
        /// can use on their front-end to grant client-side API access.</p>.
        /// </summary>
        public virtual Task<AccountSession> CreateAsync(AccountSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountSession>(BaseAddress.Api, HttpMethod.Post, $"/v1/account_sessions", options, requestOptions, cancellationToken);
        }
    }
}
