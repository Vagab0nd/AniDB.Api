using AniDb.Api.Models.Anime;
using AniDb.Api.Models.Hints;
using AniDb.Api.Models.MainPage;
using FluentAssertions;

namespace AniDb.Api.Http.Test
{
    [TestClass]
    public class AniDbHttpApiIntegrationTests
    {
        private readonly IAniDbHttpApi target = new AniDbHttpApi();

        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataRow(17709)]
        [DataRow(12519)]
        [DataRow(4521)]
        [DataRow(584)]
        [DataRow(2369)]
        [DataRow(979)]
        [DataRow(17873)]
        public async Task GetAnime_should_return_anime(int animeId)
        {
            //act
            Response<Anime> response = await this.target.GetAnime(animeId, this.TestContext.CancellationTokenSource.Token);

            //assert
            response.Data.Should().NotBeNull();
            response.ErrorMessage.Should().BeNullOrEmpty();
        }

        [TestMethod]
        public async Task GetHotAnime_should_return_hot_anime()
        {
            //act
            Response<HotAnimeCollection> response = await this.target.GetHotAnime(this.TestContext.CancellationTokenSource.Token);

            //assert
            response.Data.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetMainPageData_should_return_main_page_data()
        {
            //act
            Response<MainPage> response = await this.target.GetMainPageData();

            //assert
            response.Data.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetRandomRecommendationAnime_should_return_recommendations()
        {
            //act
            Response<RandomRecommendations> response = await this.target.GetRandomRecommendationAnime(this.TestContext.CancellationTokenSource.Token);

            //assert
            response.Data.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetRandomSimilarAnime_should_return_recommendations()
        {
            //act
            Response<RandomSimilar> response = await this.target.GetRandomSimilarAnime(this.TestContext.CancellationTokenSource.Token);

            //assert
            response.Data.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetUserHints_should_return_hints()
        {
            //act
            Response<HintCollection> response = await this.target.GetUserHints(
                TestSecrets.Username ?? TestContext.Properties["Username"]?.ToString() ?? throw new InvalidOperationException(),
                TestSecrets.Password ?? TestContext.Properties["Password"]?.ToString() ?? throw new InvalidOperationException(),
                this.TestContext.CancellationTokenSource.Token);

            //assert
            response.Data.Should().NotBeNull();
        }
    }
}