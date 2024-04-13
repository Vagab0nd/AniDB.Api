using AniDb.Api.Infrastracture;
using AniDb.Api.Models.Anime;
using AniDb.Api.Models.Hints;
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
        //TODO: Apply for separate registration
        private const string ClientName = "mediabrowser";
        private const int ClientVersion = 1;
        private const int ProtocolVersion = 1;

        public AniDbHttpApi()
        {
            FlurlHttp.ConfigureClientForUrl(BaseUri)
                .WithHeader("Accept-Encoding", "gzip")
                .WithSettings(settings =>
                {
                    //TODO: add logging on debug.
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
                .GetAsync(cancellationToken: cancellationToken)
                .UnpackGzip()
                .ReceiveXml<Anime>()
                .ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public Task<string> GetHotAnime(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<string> GetMainPageData(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<string> GetRandomRecommendationAnime(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
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
                .AppendQueryParam("password", password)
                .GetAsync(cancellationToken: cancellationToken)
                .UnpackGzip()
                .ReceiveXml<HintCollection>()
                .ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<MyListSummary> GetUserMyListSummmary(string username, string password, CancellationToken cancellationToken = default)
        {
            return await BaseUri
                .AppendQueryParam("request", "mylistsummary")
                .AppendQueryParam("user", username)
                .AppendQueryParam("password", password)
                .GetAsync(cancellationToken: cancellationToken)
                .UnpackGzip()
                .ReceiveXml<MyListSummary>()
                .ConfigureAwait(false);
        }
    }
}