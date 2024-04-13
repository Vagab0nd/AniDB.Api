using AniDb.Api.Models.Anime;
using AniDb.Api.Models.Hints;
using Flurl.Http;

namespace AniDb.Api
{
    public class AniDbHttpApi : IAniDbHttpApi
    {

        private const string BaseUrl = "http://api.anidb.net:9001/httpapi";
        //TODO: Apply for separate registration
        private const string ClientName = "mediabrowser";
        private const int ClientVersion = 1;
        private const int ProtocolVersion = 1;

        public AniDbHttpApi()
        {
            FlurlHttp.Clients.GetOrAdd(nameof(AniDbHttpApi), BaseUrl, builder =>
            {

                //TODO: Error logging on debug            
            });
        }

        public void Dispose()
        {
            FlurlHttp.Clients.Clear();
        }

        public Task<Anime> GetAnime(int animeId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetHotAnime(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetMainPageData(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRandomRecommendationAnime(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRandomSimilarAnime(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<HintContainer> GetUserHints(string username, string password, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserMyListSummmary(string username, string password, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}