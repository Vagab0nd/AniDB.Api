using FluentAssertions;

namespace AniDb.Api.Http.Test
{
    [TestClass, Ignore("Api rate limited.")]
    public class AniDbAnimeTitlesIntegrationTests
    {
        private readonly IAniDbAnimeTitles target = new AniDbAnimeTitles();

        public TestContext TestContext { get; set; }

        [TestMethod]
        public async Task GetAnimeTitles_should_return_anime_titles()
        {
            //arrange

            //act
            var response = await this.target.GetAnimeTitles();

            //assert
            response.Should().NotBeNull();
        }
    }
}