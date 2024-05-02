using AniDb.Api.Infrastracture;
using AniDb.Api.Models.Anime;
using AniDb.Api.Models.Hints;
using AniDb.Api.Models.MainPage;
using AniDb.Api.Models.MyListSummary;
using Flurl;
using Flurl.Http;

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
        public async Task<Response<Anime>> GetAnime(int animeId, CancellationToken cancellationToken = default)
        {
            return await BaseUri
                .AppendQueryParam("request", "anime")
                .AppendQueryParam("aid", animeId)    
                .AppendAniDbQueryParams()
                .GetAniDbResponse<Anime>(cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<Response<HotAnimeCollection>> GetHotAnime(CancellationToken cancellationToken = default)
        {
            return await BaseUri
                .AppendQueryParam("request", "hotanime")
                .AppendAniDbQueryParams()
                .GetAniDbResponse<HotAnimeCollection>(cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<Response<MainPage>> GetMainPageData(CancellationToken cancellationToken = default)
        {
            return await BaseUri
                .AppendQueryParam("request", "main")
                .AppendAniDbQueryParams()
                .GetAniDbResponse<MainPage>(cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<Response<RandomRecommendations>> GetRandomRecommendationAnime(CancellationToken cancellationToken = default)
        {
            return await BaseUri
                .AppendQueryParam("request", "randomrecommendation")
                .AppendAniDbQueryParams()
                .GetAniDbResponse<RandomRecommendations>(cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<Response<RandomSimilar>> GetRandomSimilarAnime(CancellationToken cancellationToken = default)
        {
            return await BaseUri
                .AppendQueryParam("request", "randomsimilar")
                .AppendAniDbQueryParams()
                .GetAniDbResponse<RandomSimilar>(cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<Response<HintCollection>> GetUserHints(string username, string password, CancellationToken cancellationToken = default)
        {
            return await BaseUri
                .AppendQueryParam("request", "hints")
                .AppendQueryParam("user", username)
                .AppendQueryParam("pass", password)
                .AppendQueryParam("type", 1)
                .AppendQueryParam("output", "xml")
                .AppendAniDbQueryParams()
                .GetAniDbResponse<HintCollection>(cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<Response<MyListSummary>> GetUserMyListSummmary(string username, string password, CancellationToken cancellationToken = default)
        {
            return await BaseUri
                .AppendQueryParam("request", "mylistsummary")
                .AppendQueryParam("user", username)
                .AppendQueryParam("password", password)
                .AppendAniDbQueryParams()
                .GetAniDbResponse<MyListSummary>(cancellationToken)
                .ConfigureAwait(false);
        }
    }
}