using AniDb.Api.Infrastracture;
using AniDb.Api.Models.Titles;
using Flurl;
using Flurl.Http;
using Flurl.Http.Xml;

namespace AniDb.Api
{
    public class AniDbAnimeTitles : IAniDbAnimeTitles
    {
        private readonly string BaseUri = "http://anidb.net/api";

        /// <summary>
        /// Constructor for testing purposes. AniDB limits heavilly number of calls to anime titles dump.
        /// </summary>
        /// <param name="baseUri"></param>
        internal AniDbAnimeTitles(string baseUri) : this()
        {
            this.BaseUri = baseUri;
        }

        public AniDbAnimeTitles()
        {
           FlurlHttp.Clients
                .GetOrAdd(nameof(AniDbAnimeTitles), this.BaseUri, builder =>
                {
                    static RateLimitingHandler rateLimittingHandlerFactory() => new(TimeSpan.FromDays(1), 1); // 1req/1day
                    builder.AddMiddleware(rateLimittingHandlerFactory);
                })             
                .WithHeader("Accept-Encoding", "gzip")
                .WithSettings(settings =>
                {
                    //TODO: add logging on debug.
                });
        }

        public async Task<AnimeTitlesCollection> GetAnimeTitles(CancellationToken cancellationToken = default)
        {
            return await this.BaseUri                
                .AppendPathSegment("anime-titles.xml.gz")
                .GetXmlAsync<AnimeTitlesCollection>(cancellationToken)
                .ConfigureAwait(false);
        }
    }
}
