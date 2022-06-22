namespace StripeTests.Treasury
{
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Treasury;
    using Xunit;

    public class OutboundPaymentTest : BaseStripeTest
    {
        public OutboundPaymentTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = @"
              {
                ""amount"": 10000,
                ""cancelable"": true,
                ""created"": 1234567890,
                ""currency"": ""usd"",
                ""customer"": null,
                ""description"": ""OutboundPayment to a 3rd party"",
                ""destination_payment_method"": null,
                ""destination_payment_method_details"": {
                  ""type"": ""us_bank_account""
                },
                ""end_user_details"": {
                  ""ip_address"": null,
                  ""present"": false
                },
                ""financial_account"": ""fa_1L9BbUDB2049DZga7dHs1QaX"",
                ""hosted_regulatory_receipt_url"": ""https://jessej-agrippa-mydev.dev.stripe.me/regulatory-receipt/obp_test_YWNjdF8xTDgwSTFEQjIwNDlEWmdhLG91dHBiX0xxdE9XZ2xtT3FzaTdiRUNrUTBoVzJ0eG9GakRKa3k0000R3VUiejM"",
                ""id"": ""obp_1L9BbWDB2049DZgaDFI0rdIi"",
                ""livemode"": false,
                ""metadata"": {},
                ""object"": ""treasury.outbound_payment"",
                ""returned_details"": null,
                ""statement_descriptor"": ""payment"",
                ""status"": ""processing"",
                ""status_transitions"": {
                  ""canceled_at"": null,
                  ""failed_at"": null,
                  ""posted_at"": null,
                  ""returned_at"": null
                },
                ""transaction"": ""trxn_1L9BbUDB2049DZgal62Am7Md""
              }";

            var ob = JsonConvert.DeserializeObject<OutboundPayment>(json);
            Assert.NotNull(ob);
            Assert.IsType<OutboundPayment>(ob);
            Assert.NotNull(ob.Id);
            Assert.Equal(System.DateTime.Now, ob.ExpectedArrivalDate);
            Assert.Equal("treasury.outbound_payment", ob.Object);
        }
    }
}
