using AniDb.Api.Models.Titles;
using Flurl;
using Flurl.Http;
using Flurl.Http.Xml;

namespace AniDb.Api
{
    public class AniDbAnimeTitles : IAniDbAnimeTitles
    {
        private const string BaseUri = "http://anidb.net/api";

        public AniDbAnimeTitles()
        {
           FlurlHttp.Clients.GetOrAdd(nameof(AniDbAnimeTitles), BaseUri)               
                .WithHeader("Accept-Encoding", "gzip")
                .WithSettings(settings =>
                {
                    //TODO: add logging on debug.
                    //TODO: rate limitting - 1 per day
                });
        }

        public async Task<AnimeTitlesCollection> GetAnimeTitles(CancellationToken cancellationToken = default)
        {
            return await BaseUri                
                .AppendPathSegment("anime-titles.dat.gz")
                .GetXmlAsync<AnimeTitlesCollection>(cancellationToken)
                .ConfigureAwait(false);
        }
    }
}
