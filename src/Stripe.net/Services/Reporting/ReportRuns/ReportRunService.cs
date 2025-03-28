// File generated from our OpenAPI spec
namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReportRunService : Service,
        ICreatable<ReportRun, ReportRunCreateOptions>,
        IListable<ReportRun, ReportRunListOptions>,
        IRetrievable<ReportRun, ReportRunGetOptions>
    {
        public ReportRunService()
        {
        }

        internal ReportRunService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ReportRunService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a new object and begin running the report. (Certain report types require a <a
        /// href="https://stripe.com/docs/keys#test-live-modes">live-mode API key</a>.)</p>.
        /// </summary>
        public virtual ReportRun Create(ReportRunCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ReportRun>(BaseAddress.Api, HttpMethod.Post, $"/v1/reporting/report_runs", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new object and begin running the report. (Certain report types require a <a
        /// href="https://stripe.com/docs/keys#test-live-modes">live-mode API key</a>.)</p>.
        /// </summary>
        public virtual Task<ReportRun> CreateAsync(ReportRunCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReportRun>(BaseAddress.Api, HttpMethod.Post, $"/v1/reporting/report_runs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing Report Run.</p>.
        /// </summary>
        public virtual ReportRun Get(string id, ReportRunGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ReportRun>(BaseAddress.Api, HttpMethod.Get, $"/v1/reporting/report_runs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing Report Run.</p>.
        /// </summary>
        public virtual Task<ReportRun> GetAsync(string id, ReportRunGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReportRun>(BaseAddress.Api, HttpMethod.Get, $"/v1/reporting/report_runs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Report Runs, with the most recent appearing first.</p>.
        /// </summary>
        public virtual StripeList<ReportRun> List(ReportRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ReportRun>>(BaseAddress.Api, HttpMethod.Get, $"/v1/reporting/report_runs", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Report Runs, with the most recent appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<ReportRun>> ListAsync(ReportRunListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ReportRun>>(BaseAddress.Api, HttpMethod.Get, $"/v1/reporting/report_runs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Report Runs, with the most recent appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<ReportRun> ListAutoPaging(ReportRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ReportRun>($"/v1/reporting/report_runs", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Report Runs, with the most recent appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<ReportRun> ListAutoPagingAsync(ReportRunListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ReportRun>($"/v1/reporting/report_runs", options, requestOptions, cancellationToken);
        }
    }
}
