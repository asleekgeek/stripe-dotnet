// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class CustomerService : Service,
        ICreatable<Customer, CustomerCreateOptions>,
        IDeletable<Customer, CustomerDeleteOptions>,
        IListable<Customer, CustomerListOptions>,
        IRetrievable<Customer, CustomerGetOptions>,
        ISearchable<Customer, CustomerSearchOptions>,
        IUpdatable<Customer, CustomerUpdateOptions>
    {
        private CustomerCashBalanceService cashBalance;
        private CustomerBalanceTransactionService balanceTransactions;
        private CustomerCashBalanceTransactionService cashBalanceTransactions;
        private CustomerPaymentSourceService paymentSources;
        private CustomerTaxIdService taxIds;
        private CustomerPaymentMethodService paymentMethods;
        private CustomerFundingInstructionsService fundingInstructions;

        public CustomerService()
        {
        }

        internal CustomerService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CustomerService(IStripeClient client)
            : base(client)
        {
        }

        public virtual CustomerCashBalanceService CashBalance => this.cashBalance ??= new CustomerCashBalanceService(
            this.Requestor);

        public virtual CustomerBalanceTransactionService BalanceTransactions => this.balanceTransactions ??= new CustomerBalanceTransactionService(
            this.Requestor);

        public virtual CustomerCashBalanceTransactionService CashBalanceTransactions => this.cashBalanceTransactions ??= new CustomerCashBalanceTransactionService(
            this.Requestor);

        public virtual CustomerPaymentSourceService PaymentSources => this.paymentSources ??= new CustomerPaymentSourceService(
            this.Requestor);

        public virtual CustomerTaxIdService TaxIds => this.taxIds ??= new CustomerTaxIdService(
            this.Requestor);

        public virtual CustomerPaymentMethodService PaymentMethods => this.paymentMethods ??= new CustomerPaymentMethodService(
            this.Requestor);

        public virtual CustomerFundingInstructionsService FundingInstructions => this.fundingInstructions ??= new CustomerFundingInstructionsService(
            this.Requestor);

        /// <summary>
        /// <p>Creates a new customer object.</p>.
        /// </summary>
        public virtual Customer Create(CustomerCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Customer>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new customer object.</p>.
        /// </summary>
        public virtual Task<Customer> CreateAsync(CustomerCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Customer>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Permanently deletes a customer. It cannot be undone. Also immediately cancels any
        /// active subscriptions on the customer.</p>.
        /// </summary>
        public virtual Customer Delete(string id, CustomerDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Customer>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Permanently deletes a customer. It cannot be undone. Also immediately cancels any
        /// active subscriptions on the customer.</p>.
        /// </summary>
        public virtual Task<Customer> DeleteAsync(string id, CustomerDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Customer>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Removes the currently applied discount on a customer.</p>.
        /// </summary>
        public virtual Discount DeleteDiscount(string id, CustomerDeleteDiscountOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Discount>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{WebUtility.UrlEncode(id)}/discount", options, requestOptions);
        }

        /// <summary>
        /// <p>Removes the currently applied discount on a customer.</p>.
        /// </summary>
        public virtual Task<Discount> DeleteDiscountAsync(string id, CustomerDeleteDiscountOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Discount>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{WebUtility.UrlEncode(id)}/discount", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a Customer object.</p>.
        /// </summary>
        public virtual Customer Get(string id, CustomerGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Customer>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a Customer object.</p>.
        /// </summary>
        public virtual Task<Customer> GetAsync(string id, CustomerGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Customer>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your customers. The customers are returned sorted by creation date,
        /// with the most recent customers appearing first.</p>.
        /// </summary>
        public virtual StripeList<Customer> List(CustomerListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Customer>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your customers. The customers are returned sorted by creation date,
        /// with the most recent customers appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<Customer>> ListAsync(CustomerListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Customer>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your customers. The customers are returned sorted by creation date,
        /// with the most recent customers appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<Customer> ListAutoPaging(CustomerListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Customer>($"/v1/customers", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your customers. The customers are returned sorted by creation date,
        /// with the most recent customers appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Customer> ListAutoPagingAsync(CustomerListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Customer>($"/v1/customers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Search for customers you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual StripeSearchResult<Customer> Search(CustomerSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeSearchResult<Customer>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/search", options, requestOptions);
        }

        /// <summary>
        /// <p>Search for customers you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual Task<StripeSearchResult<Customer>> SearchAsync(CustomerSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeSearchResult<Customer>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/search", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Search for customers you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual IEnumerable<Customer> SearchAutoPaging(CustomerSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.SearchRequestAutoPaging<Customer>($"/v1/customers/search", options, requestOptions);
        }

        /// <summary>
        /// <p>Search for customers you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Customer> SearchAutoPagingAsync(CustomerSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.SearchRequestAutoPagingAsync<Customer>($"/v1/customers/search", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the specified customer by setting the values of the parameters passed. Any
        /// parameters not provided will be left unchanged. For example, if you pass the
        /// <strong>source</strong> parameter, that becomes the customer’s active source (e.g., a
        /// card) to be used for all charges in the future. When you update a customer to a new
        /// valid card source by passing the <strong>source</strong> parameter: for each of the
        /// customer’s current subscriptions, if the subscription bills automatically and is in the
        /// <c>past_due</c> state, then the latest open invoice for the subscription with automatic
        /// collection enabled will be retried. This retry will not count as an automatic retry, and
        /// will not affect the next regularly scheduled payment for the invoice. Changing the
        /// <strong>default_source</strong> for a customer will not trigger this behavior.</p>.
        ///
        /// <p>This request accepts mostly the same arguments as the customer creation call.</p>.
        /// </summary>
        public virtual Customer Update(string id, CustomerUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Customer>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the specified customer by setting the values of the parameters passed. Any
        /// parameters not provided will be left unchanged. For example, if you pass the
        /// <strong>source</strong> parameter, that becomes the customer’s active source (e.g., a
        /// card) to be used for all charges in the future. When you update a customer to a new
        /// valid card source by passing the <strong>source</strong> parameter: for each of the
        /// customer’s current subscriptions, if the subscription bills automatically and is in the
        /// <c>past_due</c> state, then the latest open invoice for the subscription with automatic
        /// collection enabled will be retried. This retry will not count as an automatic retry, and
        /// will not affect the next regularly scheduled payment for the invoice. Changing the
        /// <strong>default_source</strong> for a customer will not trigger this behavior.</p>.
        ///
        /// <p>This request accepts mostly the same arguments as the customer creation call.</p>.
        /// </summary>
        public virtual Task<Customer> UpdateAsync(string id, CustomerUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Customer>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
