using AniDb.Api.Infrastracture;
using FluentAssertions;
using Flurl.Http;

namespace AniDb.Api.Test.Infrastracture
{
    [TestClass]
    public class FlurlHttpExtensionsTests
    {
        [TestMethod]
        public void TryConfigureClientForUrl_should_configure_client_if_missing()
        {
            //arrange
            var testUrl = "http://test.com";

            //act 
            var clientName = FlurlHttpExtensions.TryConfigureClientForUrl(testUrl, builder => { });

            //assert
            FlurlHttp.Clients.Get(clientName).Should().NotBeNull();
        }
    }
}
