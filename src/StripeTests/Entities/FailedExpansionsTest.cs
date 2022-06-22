namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Stripe;
    using Xunit;

    public class FailedExpansionsTest : BaseStripeTest
    {
        [Fact]
        public void FailedExpansionTopLevelWithNull()
        {
            var data = GetResourceAsString("api_fixtures.subscription.json");
            var json = JObject.Parse(data);
            json.Add("latest_invoice", JValue.CreateNull());

            var subscription = JsonConvert.DeserializeObject<Subscription>(json.ToString());
            Assert.Null(subscription.LatestInvoice);
        }

        [Fact]
        public void FailedExpansionTopLevelWithId()
        {
            var data = GetResourceAsString("api_fixtures.subscription.json");
            var json = JObject.Parse(data);
            json.Add("latest_invoice", "il_xyz");

            var subscription = JsonConvert.DeserializeObject<Subscription>(json.ToString());
            Assert.Null(subscription.LatestInvoice);
        }

        [Fact]
        public void FailedExpansionTopLevelWithEmptyObject()
        {
            var data = GetResourceAsString("api_fixtures.subscription.json");
            var json = JObject.Parse(data);
            json.Add("latest_invoice", new JObject());

            var subscription = JsonConvert.DeserializeObject<Subscription>(json.ToString());
            Assert.NotNull(subscription.LatestInvoice);
            Assert.Empty(subscription.LatestInvoice.Id);
        }

        [Fact]
        public void FailedExpansionTopLevelWithNonEmptyObject()
        {
            var data = GetResourceAsString("api_fixtures.subscription.json");
            var json = JObject.Parse(data);

            var invoice = new JObject();
            invoice.Add("id", "il_xyz");
            json.Add("latest_invoice", invoice);

            var subscription = JsonConvert.DeserializeObject<Subscription>(json.ToString());
            Assert.NotNull(subscription.LatestInvoice);
            Assert.Equal("il_xyz", subscription.LatestInvoice.Id);
        }

        [Fact]
        public void FailedExpansionArrayWithNull()
        {
            var data = GetResourceAsString("api_fixtures.subscription.json");
            var json = JObject.Parse(data);

            var items = (JObject)json["items"];
            var array = (JArray)items["data"];
            array.Add(JValue.CreateNull());

            var expectedItems = array.Count;

            var subscription = JsonConvert.DeserializeObject<Subscription>(json.ToString());

            var values = Enumerable.ToArray<SubscriptionItem>(subscription.Items);
            Assert.Equal(expectedItems, values.Count());
            Assert.Null(values.Last());
        }

        [Fact]
        public void FailedExpansionArrayWithId()
        {
            var data = GetResourceAsString("api_fixtures.subscription.json");
            var json = JObject.Parse(data);

            var items = (JObject)json["items"];
            var array = (JArray)items["data"];
            array.Add("si_xyz");

            var expectedItems = array.Count;

            Assert.Throws<JsonReaderException>(() => JsonConvert.DeserializeObject<Subscription>(json.ToString()));
        }

        [Fact]
        public void FailedExpansionArrayWithEmptyObject()
        {
            var data = GetResourceAsString("api_fixtures.subscription.json");
            var json = JObject.Parse(data);

            var items = (JObject)json["items"];
            var array = (JArray)items["data"];
            array.Add(new JObject());

            var expectedItems = array.Count;

            var subscription = JsonConvert.DeserializeObject<Subscription>(json.ToString());

            var values = Enumerable.ToArray<SubscriptionItem>(subscription.Items);
            Assert.Equal(expectedItems, values.Count());
            Assert.NotNull(values.Last());
        }
    }
}
