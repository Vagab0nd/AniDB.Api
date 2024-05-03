using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AniDb.Api.Test
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
        public async Task GetAnime_should_return_anime(int animeId)
        {
            //act
            var response = await this.target.GetAnime(animeId);

            //assert
            response.Data.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetHotAnime_should_return_hot_anime()
        {
            //act
            var response = await this.target.GetHotAnime();

            //assert
            response.Data.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetMainPageData_should_return_main_page_data()
        {
            //act
            var response = await this.target.GetMainPageData();

            //assert
            response.Data.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetUserHints_should_return_hints()
        {
            //act
            var response = await this.target.GetUserHints(
                this.TestContext.Properties["Username"]?.ToString(), 
                this.TestContext.Properties["Password"]?.ToString()
                );

            //assert
            response.Data.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetRandomRecommendationAnime_should_return_recommandations()
        {
            //act
            var response = await this.target.GetRandomRecommendationAnime();

            //assert
            response.Data.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetRandomSimilarAnime_should_return_recommandations()
        {
            //act
            var response = await this.target.GetRandomSimilarAnime();

            //assert
            response.Data.Should().NotBeNull();
        }
    }
}