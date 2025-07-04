// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SubscriptionService : Service,
        ICreatable<Subscription, SubscriptionCreateOptions>,
        IListable<Subscription, SubscriptionListOptions>,
        IRetrievable<Subscription, SubscriptionGetOptions>,
        ISearchable<Subscription, SubscriptionSearchOptions>,
        IUpdatable<Subscription, SubscriptionUpdateOptions>
    {
        public SubscriptionService()
        {
        }

        internal SubscriptionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public SubscriptionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Cancels a customer’s subscription immediately. The customer won’t be charged again
        /// for the subscription. After it’s canceled, you can no longer update the subscription or
        /// its <a href="https://stripe.com/metadata">metadata</a>.</p>.
        ///
        /// <p>Any pending invoice items that you’ve created are still charged at the end of the
        /// period, unless manually <a
        /// href="https://stripe.com/docs/api#delete_invoiceitem">deleted</a>. If you’ve set the
        /// subscription to cancel at the end of the period, any pending prorations are also left in
        /// place and collected at the end of the period. But if the subscription is set to cancel
        /// immediately, pending prorations are removed if <c>invoice_now</c> and <c>prorate</c> are
        /// both set to true.</p>.
        ///
        /// <p>By default, upon subscription cancellation, Stripe stops automatic collection of all
        /// finalized invoices for the customer. This is intended to prevent unexpected payment
        /// attempts after the customer has canceled a subscription. However, you can resume
        /// automatic collection of the invoices manually after subscription cancellation to have us
        /// proceed. Or, you could check for unpaid invoices before allowing the customer to cancel
        /// the subscription at all.</p>.
        /// </summary>
        public virtual Subscription Cancel(string id, SubscriptionCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Subscription>(BaseAddress.Api, HttpMethod.Delete, $"/v1/subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Cancels a customer’s subscription immediately. The customer won’t be charged again
        /// for the subscription. After it’s canceled, you can no longer update the subscription or
        /// its <a href="https://stripe.com/metadata">metadata</a>.</p>.
        ///
        /// <p>Any pending invoice items that you’ve created are still charged at the end of the
        /// period, unless manually <a
        /// href="https://stripe.com/docs/api#delete_invoiceitem">deleted</a>. If you’ve set the
        /// subscription to cancel at the end of the period, any pending prorations are also left in
        /// place and collected at the end of the period. But if the subscription is set to cancel
        /// immediately, pending prorations are removed if <c>invoice_now</c> and <c>prorate</c> are
        /// both set to true.</p>.
        ///
        /// <p>By default, upon subscription cancellation, Stripe stops automatic collection of all
        /// finalized invoices for the customer. This is intended to prevent unexpected payment
        /// attempts after the customer has canceled a subscription. However, you can resume
        /// automatic collection of the invoices manually after subscription cancellation to have us
        /// proceed. Or, you could check for unpaid invoices before allowing the customer to cancel
        /// the subscription at all.</p>.
        /// </summary>
        public virtual Task<Subscription> CancelAsync(string id, SubscriptionCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Subscription>(BaseAddress.Api, HttpMethod.Delete, $"/v1/subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a new subscription on an existing customer. Each customer can have up to 500
        /// active or scheduled subscriptions.</p>.
        ///
        /// <p>When you create a subscription with <c>collection_method=charge_automatically</c>,
        /// the first invoice is finalized as part of the request. The <c>payment_behavior</c>
        /// parameter determines the exact behavior of the initial payment.</p>.
        ///
        /// <p>To start subscriptions where the first invoice always begins in a <c>draft</c>
        /// status, use <a
        /// href="https://stripe.com/docs/billing/subscriptions/subscription-schedules#managing">subscription
        /// schedules</a> instead. Schedules provide the flexibility to model more complex billing
        /// configurations that change over time.</p>.
        /// </summary>
        public virtual Subscription Create(SubscriptionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Subscription>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscriptions", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new subscription on an existing customer. Each customer can have up to 500
        /// active or scheduled subscriptions.</p>.
        ///
        /// <p>When you create a subscription with <c>collection_method=charge_automatically</c>,
        /// the first invoice is finalized as part of the request. The <c>payment_behavior</c>
        /// parameter determines the exact behavior of the initial payment.</p>.
        ///
        /// <p>To start subscriptions where the first invoice always begins in a <c>draft</c>
        /// status, use <a
        /// href="https://stripe.com/docs/billing/subscriptions/subscription-schedules#managing">subscription
        /// schedules</a> instead. Schedules provide the flexibility to model more complex billing
        /// configurations that change over time.</p>.
        /// </summary>
        public virtual Task<Subscription> CreateAsync(SubscriptionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Subscription>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscriptions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Removes the currently applied discount on a subscription.</p>.
        /// </summary>
        public virtual Discount DeleteDiscount(string id, SubscriptionDeleteDiscountOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Discount>(BaseAddress.Api, HttpMethod.Delete, $"/v1/subscriptions/{WebUtility.UrlEncode(id)}/discount", options, requestOptions);
        }

        /// <summary>
        /// <p>Removes the currently applied discount on a subscription.</p>.
        /// </summary>
        public virtual Task<Discount> DeleteDiscountAsync(string id, SubscriptionDeleteDiscountOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Discount>(BaseAddress.Api, HttpMethod.Delete, $"/v1/subscriptions/{WebUtility.UrlEncode(id)}/discount", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the subscription with the given ID.</p>.
        /// </summary>
        public virtual Subscription Get(string id, SubscriptionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Subscription>(BaseAddress.Api, HttpMethod.Get, $"/v1/subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the subscription with the given ID.</p>.
        /// </summary>
        public virtual Task<Subscription> GetAsync(string id, SubscriptionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Subscription>(BaseAddress.Api, HttpMethod.Get, $"/v1/subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>By default, returns a list of subscriptions that have not been canceled. In order to
        /// list canceled subscriptions, specify <c>status=canceled</c>.</p>.
        /// </summary>
        public virtual StripeList<Subscription> List(SubscriptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Subscription>>(BaseAddress.Api, HttpMethod.Get, $"/v1/subscriptions", options, requestOptions);
        }

        /// <summary>
        /// <p>By default, returns a list of subscriptions that have not been canceled. In order to
        /// list canceled subscriptions, specify <c>status=canceled</c>.</p>.
        /// </summary>
        public virtual Task<StripeList<Subscription>> ListAsync(SubscriptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Subscription>>(BaseAddress.Api, HttpMethod.Get, $"/v1/subscriptions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>By default, returns a list of subscriptions that have not been canceled. In order to
        /// list canceled subscriptions, specify <c>status=canceled</c>.</p>.
        /// </summary>
        public virtual IEnumerable<Subscription> ListAutoPaging(SubscriptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Subscription>($"/v1/subscriptions", options, requestOptions);
        }

        /// <summary>
        /// <p>By default, returns a list of subscriptions that have not been canceled. In order to
        /// list canceled subscriptions, specify <c>status=canceled</c>.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Subscription> ListAutoPagingAsync(SubscriptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Subscription>($"/v1/subscriptions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Upgrade the billing_mode of an existing subscription.</p>.
        /// </summary>
        public virtual Subscription Migrate(string id, SubscriptionMigrateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Subscription>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscriptions/{WebUtility.UrlEncode(id)}/migrate", options, requestOptions);
        }

        /// <summary>
        /// <p>Upgrade the billing_mode of an existing subscription.</p>.
        /// </summary>
        public virtual Task<Subscription> MigrateAsync(string id, SubscriptionMigrateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Subscription>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscriptions/{WebUtility.UrlEncode(id)}/migrate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Initiates resumption of a paused subscription, optionally resetting the billing cycle
        /// anchor and creating prorations. If a resumption invoice is generated, it must be paid or
        /// marked uncollectible before the subscription will be unpaused. If payment succeeds the
        /// subscription will become <c>active</c>, and if payment fails the subscription will be
        /// <c>past_due</c>. The resumption invoice will void automatically if not paid by the
        /// expiration date.</p>.
        /// </summary>
        public virtual Subscription Resume(string id, SubscriptionResumeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Subscription>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscriptions/{WebUtility.UrlEncode(id)}/resume", options, requestOptions);
        }

        /// <summary>
        /// <p>Initiates resumption of a paused subscription, optionally resetting the billing cycle
        /// anchor and creating prorations. If a resumption invoice is generated, it must be paid or
        /// marked uncollectible before the subscription will be unpaused. If payment succeeds the
        /// subscription will become <c>active</c>, and if payment fails the subscription will be
        /// <c>past_due</c>. The resumption invoice will void automatically if not paid by the
        /// expiration date.</p>.
        /// </summary>
        public virtual Task<Subscription> ResumeAsync(string id, SubscriptionResumeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Subscription>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscriptions/{WebUtility.UrlEncode(id)}/resume", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Search for subscriptions you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual StripeSearchResult<Subscription> Search(SubscriptionSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeSearchResult<Subscription>>(BaseAddress.Api, HttpMethod.Get, $"/v1/subscriptions/search", options, requestOptions);
        }

        /// <summary>
        /// <p>Search for subscriptions you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual Task<StripeSearchResult<Subscription>> SearchAsync(SubscriptionSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeSearchResult<Subscription>>(BaseAddress.Api, HttpMethod.Get, $"/v1/subscriptions/search", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Search for subscriptions you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual IEnumerable<Subscription> SearchAutoPaging(SubscriptionSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.SearchRequestAutoPaging<Subscription>($"/v1/subscriptions/search", options, requestOptions);
        }

        /// <summary>
        /// <p>Search for subscriptions you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Subscription> SearchAutoPagingAsync(SubscriptionSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.SearchRequestAutoPagingAsync<Subscription>($"/v1/subscriptions/search", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates an existing subscription to match the specified parameters. When changing
        /// prices or quantities, we optionally prorate the price we charge next month to make up
        /// for any price changes. To preview how the proration is calculated, use the <a
        /// href="https://stripe.com/docs/api/invoices/create_preview">create preview</a>
        /// endpoint.</p>.
        ///
        /// <p>By default, we prorate subscription changes. For example, if a customer signs up on
        /// May 1 for a <currency>100</currency> price, they’ll be billed <currency>100</currency>
        /// immediately. If on May 15 they switch to a <currency>200</currency> price, then on June
        /// 1 they’ll be billed <currency>250</currency> (<currency>200</currency> for a renewal of
        /// her subscription, plus a <currency>50</currency> prorating adjustment for half of the
        /// previous month’s <currency>100</currency> difference). Similarly, a downgrade generates
        /// a credit that is applied to the next invoice. We also prorate when you make quantity
        /// changes.</p>.
        ///
        /// <p>Switching prices does not normally change the billing date or generate an immediate
        /// charge unless:</p>.
        ///
        /// <ul> <li>The billing interval is changed (for example, from monthly to yearly).</li>
        /// <li>The subscription moves from free to paid.</li> <li>A trial starts or ends.</li>
        /// </ul>.
        ///
        /// <p>In these cases, we apply a credit for the unused time on the previous price,
        /// immediately charge the customer using the new price, and reset the billing date. Learn
        /// about how <a
        /// href="https://stripe.com/docs/billing/subscriptions/upgrade-downgrade#immediate-payment">Stripe
        /// immediately attempts payment for subscription changes</a>.</p>.
        ///
        /// <p>If you want to charge for an upgrade immediately, pass <c>proration_behavior</c> as
        /// <c>always_invoice</c> to create prorations, automatically invoice the customer for those
        /// proration adjustments, and attempt to collect payment. If you pass
        /// <c>create_prorations</c>, the prorations are created but not automatically invoiced. If
        /// you want to bill the customer for the prorations before the subscription’s renewal date,
        /// you need to manually <a href="https://stripe.com/docs/api/invoices/create">invoice the
        /// customer</a>.</p>.
        ///
        /// <p>If you don’t want to prorate, set the <c>proration_behavior</c> option to
        /// <c>none</c>. With this option, the customer is billed <currency>100</currency> on May 1
        /// and <currency>200</currency> on June 1. Similarly, if you set <c>proration_behavior</c>
        /// to <c>none</c> when switching between different billing intervals (for example, from
        /// monthly to yearly), we don’t generate any credits for the old subscription’s unused
        /// time. We still reset the billing date and bill immediately for the new subscription.</p>.
        ///
        /// <p>Updating the quantity on a subscription many times in an hour may result in <a
        /// href="https://stripe.com/docs/rate-limits">rate limiting</a>. If you need to bill for a
        /// frequently changing quantity, consider integrating <a
        /// href="https://stripe.com/docs/billing/subscriptions/usage-based">usage-based billing</a>
        /// instead.</p>.
        /// </summary>
        public virtual Subscription Update(string id, SubscriptionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Subscription>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates an existing subscription to match the specified parameters. When changing
        /// prices or quantities, we optionally prorate the price we charge next month to make up
        /// for any price changes. To preview how the proration is calculated, use the <a
        /// href="https://stripe.com/docs/api/invoices/create_preview">create preview</a>
        /// endpoint.</p>.
        ///
        /// <p>By default, we prorate subscription changes. For example, if a customer signs up on
        /// May 1 for a <currency>100</currency> price, they’ll be billed <currency>100</currency>
        /// immediately. If on May 15 they switch to a <currency>200</currency> price, then on June
        /// 1 they’ll be billed <currency>250</currency> (<currency>200</currency> for a renewal of
        /// her subscription, plus a <currency>50</currency> prorating adjustment for half of the
        /// previous month’s <currency>100</currency> difference). Similarly, a downgrade generates
        /// a credit that is applied to the next invoice. We also prorate when you make quantity
        /// changes.</p>.
        ///
        /// <p>Switching prices does not normally change the billing date or generate an immediate
        /// charge unless:</p>.
        ///
        /// <ul> <li>The billing interval is changed (for example, from monthly to yearly).</li>
        /// <li>The subscription moves from free to paid.</li> <li>A trial starts or ends.</li>
        /// </ul>.
        ///
        /// <p>In these cases, we apply a credit for the unused time on the previous price,
        /// immediately charge the customer using the new price, and reset the billing date. Learn
        /// about how <a
        /// href="https://stripe.com/docs/billing/subscriptions/upgrade-downgrade#immediate-payment">Stripe
        /// immediately attempts payment for subscription changes</a>.</p>.
        ///
        /// <p>If you want to charge for an upgrade immediately, pass <c>proration_behavior</c> as
        /// <c>always_invoice</c> to create prorations, automatically invoice the customer for those
        /// proration adjustments, and attempt to collect payment. If you pass
        /// <c>create_prorations</c>, the prorations are created but not automatically invoiced. If
        /// you want to bill the customer for the prorations before the subscription’s renewal date,
        /// you need to manually <a href="https://stripe.com/docs/api/invoices/create">invoice the
        /// customer</a>.</p>.
        ///
        /// <p>If you don’t want to prorate, set the <c>proration_behavior</c> option to
        /// <c>none</c>. With this option, the customer is billed <currency>100</currency> on May 1
        /// and <currency>200</currency> on June 1. Similarly, if you set <c>proration_behavior</c>
        /// to <c>none</c> when switching between different billing intervals (for example, from
        /// monthly to yearly), we don’t generate any credits for the old subscription’s unused
        /// time. We still reset the billing date and bill immediately for the new subscription.</p>.
        ///
        /// <p>Updating the quantity on a subscription many times in an hour may result in <a
        /// href="https://stripe.com/docs/rate-limits">rate limiting</a>. If you need to bill for a
        /// frequently changing quantity, consider integrating <a
        /// href="https://stripe.com/docs/billing/subscriptions/usage-based">usage-based billing</a>
        /// instead.</p>.
        /// </summary>
        public virtual Task<Subscription> UpdateAsync(string id, SubscriptionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Subscription>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscriptions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
