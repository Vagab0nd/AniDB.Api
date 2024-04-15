using AniDb.Api.Models.Anime;
using AniDb.Api.Test.Resources;
using FluentAssertions;
using Flurl.Http.Testing;
using Flurl.Http.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AniDb.Api.Test
{
    [TestClass]
    public class AniDbHttpApiTests
    {
        private readonly IAniDbHttpApi target = new AniDbHttpApi();

        public TestContext TestContext { get; set; }

        [TestMethod]
        public async Task GetAnime_should_return_anime()
        {
            //act
            var response = await this.target.GetAnime(17709);

            //assert
            response.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetAnime_should_deserialize_anime_xml()
        {
            //arrange
            using var httpTest = new HttpTest();
            var xmlResponse = ResourcesHelper.GetStringResource("AnimeResponse.txt");
            httpTest.RespondWith(xmlResponse);

            //act
            var response = await this.target.GetAnime(17709);

            //assert
            response.Should().NotBeNull();
        }
    }
}