using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AniDb.Api.Test
{
    [TestClass, Ignore("Api rate limitted.")]
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