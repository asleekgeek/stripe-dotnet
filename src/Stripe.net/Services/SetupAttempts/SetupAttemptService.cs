// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SetupAttemptService : Service,
        IListable<SetupAttempt, SetupAttemptListOptions>
    {
        public SetupAttemptService()
        {
        }

        internal SetupAttemptService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public SetupAttemptService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Returns a list of SetupAttempts that associate with a provided SetupIntent.</p>.
        /// </summary>
        public virtual StripeList<SetupAttempt> List(SetupAttemptListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<SetupAttempt>>(BaseAddress.Api, HttpMethod.Get, $"/v1/setup_attempts", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of SetupAttempts that associate with a provided SetupIntent.</p>.
        /// </summary>
        public virtual Task<StripeList<SetupAttempt>> ListAsync(SetupAttemptListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<SetupAttempt>>(BaseAddress.Api, HttpMethod.Get, $"/v1/setup_attempts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of SetupAttempts that associate with a provided SetupIntent.</p>.
        /// </summary>
        public virtual IEnumerable<SetupAttempt> ListAutoPaging(SetupAttemptListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<SetupAttempt>($"/v1/setup_attempts", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of SetupAttempts that associate with a provided SetupIntent.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<SetupAttempt> ListAutoPagingAsync(SetupAttemptListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<SetupAttempt>($"/v1/setup_attempts", options, requestOptions, cancellationToken);
        }
    }
}
