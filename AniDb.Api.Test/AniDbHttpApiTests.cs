using AniDb.Api.Test.Resources;
using FluentAssertions;
using Flurl.Http.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AniDb.Api.Test
{
    [TestClass]
    public class AniDbHttpApiTests
    {
        private readonly IAniDbHttpApi target = new AniDbHttpApi();

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

        [TestMethod]
        public async Task GetHotAnime_should_deserialize_response_xml()
        {
            //arrange
            using var httpTest = new HttpTest();
            var xmlResponse = ResourcesHelper.GetStringResource("HotAnimeResponse.txt");
            httpTest.RespondWith(xmlResponse);

            //act
            var response = await this.target.GetHotAnime();

            //assert
            response.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetMainPageData_should_deserialize_response_xml()
        {
            //arrange
            using var httpTest = new HttpTest();
            var xmlResponse = ResourcesHelper.GetStringResource("MainPageResponse.txt");
            httpTest.RespondWith(xmlResponse);

            //act
            var response = await this.target.GetMainPageData();

            //assert
            response.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetUserHints_should_deserialize_response_xml()
        {
            //arrange
            using var httpTest = new HttpTest();
            var xmlResponse = ResourcesHelper.GetStringResource("HintsResponse.txt");
            httpTest.RespondWith(xmlResponse);

            //act
            var response = await this.target.GetUserHints("username", "password");

            //assert
            response.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetUserMyListSummmary_should_deserialize_response_xml()
        {
            //arrange
            using var httpTest = new HttpTest();
            var xmlResponse = ResourcesHelper.GetStringResource("MyListSummaryResponse.txt");
            httpTest.RespondWith(xmlResponse);

            //act
            var response = await this.target.GetUserMyListSummmary("username", "password");

            //assert
            response.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetRandomRecommendationAnime_should_deserialize_response_xml()
        {
            //arrange
            using var httpTest = new HttpTest();
            var xmlResponse = ResourcesHelper.GetStringResource("RandomRecommendationResponse.txt");
            httpTest.RespondWith(xmlResponse);

            //act
            var response = await this.target.GetRandomRecommendationAnime();

            //assert
            response.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetRandomSimilarAnime_should_deserialize_response_xml()
        {
            //arrange
            using var httpTest = new HttpTest();
            var xmlResponse = ResourcesHelper.GetStringResource("RandomSimilarResponse.txt");
            httpTest.RespondWith(xmlResponse);

            //act
            var response = await this.target.GetRandomSimilarAnime();

            //assert
            response.Should().NotBeNull();
        }
    }
}
