using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AniDb.Api.Test
{
    [TestClass]
    public class AniDbHttpApiTests
    {
        private IAniDbHttpApi target = new AniDbHttpApi();

        public TestContext TestContext { get; set; }

        [TestMethod]
        public async Task GetAnime_should_return_anime()
        {
            //act
            var response = await this.target.GetAnime(17709);

            //assert
            response.Should().NotBeNull();
        }
    }
}