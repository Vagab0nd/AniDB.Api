using AniDb.Api.Models.Anime;
using AniDb.Api.Models.Common;
using AniDb.Api.Test.Resources;
using FluentAssertions;
using Flurl.Http.Testing;

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
            response.Data.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetAnime_should_deserialize_anime_titles()
        {
            //arrange
            using var httpTest = new HttpTest();
            string xmlResponse = ResourcesHelper.GetStringResource("AnimeResponse.txt");
            httpTest.RespondWith(xmlResponse);

            //act
            Response<Anime> response = await this.target.GetAnime(17709);

            //assert
            response.Data.Titles.Should().HaveCount(9);
            response.Data.Titles.Should()
                .Contain(
                [
                    new Title
                    {
                        Language = "x-jat",
                        Type = TitleType.Main,
                        Text = "Seikai no Monshou"
                    },
                    new Title
                    {
                        Language = "zh-Hans",
                        Type = TitleType.Synonym,
                        Text = "星界之纹章"
                    },
                    new Title
                    {
                        Language = "en",
                        Type = TitleType.Official,
                        Text = "Crest of the Stars"
                    },
                    new Title
                    {
                        Language = "en",
                        Type = TitleType.Short,
                        Text = "CotS"
                    }
                ]);
        }

        [TestMethod]
        public async Task GetAnime_should_deserialize_error_xml()
        {
            //arrange
            using var httpTest = new HttpTest();
            var xmlResponse = ResourcesHelper.GetStringResource("ErrorResponse.txt");
            httpTest.RespondWith(xmlResponse);

            //act
            var response = await this.target.GetAnime(int.MaxValue, TestContext.CancellationTokenSource.Token);

            //assert
            response.Should().NotBeNull();
            response.ErrorMessage.Should().NotBeNullOrWhiteSpace();
        }

        [TestMethod]
        public async Task GetHotAnime_should_deserialize_response_xml()
        {
            //arrange
            using var httpTest = new HttpTest();
            var xmlResponse = ResourcesHelper.GetStringResource("HotAnimeResponse.txt");
            httpTest.RespondWith(xmlResponse);

            //act
            var response = await this.target.GetHotAnime(TestContext.CancellationTokenSource.Token);

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
            var response = await this.target.GetMainPageData(TestContext.CancellationTokenSource.Token);

            //assert
            response.Data.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetUserHints_should_deserialize_response_xml()
        {
            //arrange
            using var httpTest = new HttpTest();
            var xmlResponse = ResourcesHelper.GetStringResource("HintsResponse.txt");
            httpTest.RespondWith(xmlResponse);

            //act
            var response = await this.target.GetUserHints("username", "password", TestContext.CancellationTokenSource.Token);

            //assert
            response.Data.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetUserMyListSummary_should_deserialize_response_xml()
        {
            //arrange
            using var httpTest = new HttpTest();
            var xmlResponse = ResourcesHelper.GetStringResource("MyListSummaryResponse.txt");
            httpTest.RespondWith(xmlResponse);

            //act
            var response = await this.target.GetUserMyListSummmary("username", "password");

            //assert
            response.Data.Should().NotBeNull();
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
            response.Data.Should().NotBeNull();
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
            response.Data.Should().NotBeNull();
        }

        public TestContext TestContext { get; set; }
    }
}
