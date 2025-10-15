using System.Net;
using AniDb.Api.Infrastracture;
using FluentAssertions;
using Flurl.Http;
using Flurl.Http.Testing;

namespace AniDb.Api.Http.Test.Infrastructure 
{
    [TestClass]
    public class RateLimitingHandlerTests
    {
        private RateLimitingHandler rateLimitingHandler = null!;
        private HttpTest httpTest = null!;

        [TestInitialize]
        public void TestInitialize()
        {
            this.rateLimitingHandler = new RateLimitingHandler(TimeSpan.FromSeconds(1), 2); // Allow 2 requests per second
            this.httpTest = new HttpTest();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.httpTest.Dispose();
        }

        [TestMethod]
        public async Task RateLimitingHandler_should_allow_requests_within_rate_limit()
        {
            // arrange
            this.httpTest.RespondWith("OK", status: 200);
            this.httpTest.RespondWith("OK", status: 200);

            // act
            var response1 = await this.SendRequest();
            var response2 = await this.SendRequest();

            // assert
            response1.StatusCode.Should().Be((int)HttpStatusCode.OK);
            response2.StatusCode.Should().Be((int)HttpStatusCode.OK);
        }

        [TestMethod]
        public async Task RateLimitingHandler_should_enforce_rate_limit()
        {
            // arrange
            this.httpTest.RespondWith("OK", status: 200);
            this.httpTest.RespondWith("OK", status: 200);
            this.httpTest.RespondWith("OK", status: 200);

            // act
            var response1 = await this.SendRequest();
            var response2 = await this.SendRequest();
            var response3 = await this.SendRequest();

            // assert
            response1.StatusCode.Should().Be((int)HttpStatusCode.OK);
            response2.StatusCode.Should().Be((int)HttpStatusCode.OK);
            response3.StatusCode.Should().Be((int)HttpStatusCode.OK);
        }

        private async Task<IFlurlResponse> SendRequest()
        {
            FlurlHttp.Clients.WithDefaults(builder => builder.AddMiddleware(() => this.rateLimitingHandler));
            return await "https://api.example.com/data".GetAsync();
        }
    }
}
