using AniDb.Api.Infrastracture;
using AniDb.Api.Models.Anime;
using AniDb.Api.Models.Hints;
using AniDb.Api.Models.MainPage;
using AniDb.Api.Models.MyListSummary;
using Flurl;
using Flurl.Http;
using Flurl.Http.Xml;

namespace AniDb.Api
{
    /// <inheritdoc/>
    public class AniDbHttpApi : IAniDbHttpApi
    {

        private const string BaseUri = "http://api.anidb.net:9001/httpapi";

        public AniDbHttpApi()
        {
            FlurlHttpExtensions.TryConfigureClientForUrl(BaseUri, builder => {
                static RateLimitingHandler rateLimittingHandlerFactory() => new(TimeSpan.FromSeconds(2), 1); // 1req/2s
                builder
                    .AddMiddleware(rateLimittingHandlerFactory)
                    .WithHeader("Accept-Encoding", "gzip")
                    .WithSettings(settings =>
                    {
                        //TODO: add logging on debug.
                    });               
            });
        }

        public void Dispose()
        {
        }

        /// <inheritdoc/>
        public async Task<Anime> GetAnime(int animeId, CancellationToken cancellationToken = default)
        {
            return await BaseUri
                .AppendQueryParam("request", "anime")
                .AppendQueryParam("aid", animeId)    
                .AppendAniDbQueryParams()
                .GetXmlAsync<Anime>(cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<HotAnimeCollection> GetHotAnime(CancellationToken cancellationToken = default)
        {
            return await BaseUri
                .AppendQueryParam("request", "hotanime")
                .AppendAniDbQueryParams()
                .GetXmlAsync<HotAnimeCollection>(cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public Task<string> GetMainPageData(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public async Task<RandomRecommendations> GetRandomRecommendationAnime(CancellationToken cancellationToken = default)
        {
            return await BaseUri
                .AppendQueryParam("request", "randomrecommendation")
                .AppendAniDbQueryParams()
                .GetXmlAsync<RandomRecommendations>(cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public Task<string> GetRandomSimilarAnime(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public async Task<HintCollection> GetUserHints(string username, string password, CancellationToken cancellationToken = default)
        {
            return await BaseUri
                .AppendQueryParam("request", "hints")
                .AppendQueryParam("user", username)
                .AppendQueryParam("pass", password)
                .AppendQueryParam("type", 1)
                .AppendQueryParam("output", "xml")
                .AppendAniDbQueryParams()
                .GetXmlAsync<HintCollection>(cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<MyListSummary> GetUserMyListSummmary(string username, string password, CancellationToken cancellationToken = default)
        {
            return await BaseUri
                .AppendQueryParam("request", "mylistsummary")
                .AppendQueryParam("user", username)
                .AppendQueryParam("password", password)
                .AppendAniDbQueryParams()
                .GetXmlAsync<MyListSummary>(cancellationToken)
                .ConfigureAwait(false);
        }
    }
}