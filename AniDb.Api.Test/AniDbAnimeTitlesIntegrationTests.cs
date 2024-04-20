using AniDb.Api.Test.Resources;
using FluentAssertions;
using Flurl.Http.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AniDb.Api.Test
{
    [TestClass]
    public class AniDbAnimeTitlesIntegrationTests
    {
        private readonly IAniDbAnimeTitles target = new AniDbAnimeTitles();

        public TestContext TestContext { get; set; }

        [TestMethod]
        public async Task GetAnimeTitles_should_return_anime_titles()
        {
            //arrange
            using var httpTest = new HttpTest();
            var fileResponse = ResourcesHelper.GetByteResource("anime-titles.xml.gz");
            var headers = new Dictionary<string, string>
            {
                { "Content-Encoding", "gzip" }
            };
            httpTest.RespondWith(fileResponse, headers: headers);

            //act
            try
            {
                var response = await this.target.GetAnimeTitles();

                //assert
                response.Should().NotBeNull();
            }
            catch(Exception) 
            {
                throw new Exception();
            }
        }
    }
}