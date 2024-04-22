using AniDb.Api.Infrastracture;
using AniDb.Api.Models.Titles;
using Flurl;
using Flurl.Http;
using Flurl.Http.Xml;

namespace AniDb.Api
{
    public class AniDbAnimeTitles : IAniDbAnimeTitles
    {
        private const string BaseUri = "https://anidb.net/api";

        public AniDbAnimeTitles()
        {
            FlurlHttpExtensions.TryConfigureClientForUrl(BaseUri, builder =>
            {
                static RateLimitingHandler rateLimittingHandlerFactory() => new(TimeSpan.FromDays(1), 1); // 1req/1day
                builder
                    .AddMiddleware(rateLimittingHandlerFactory)
                    .WithHeaders(new
                    {
                        Accept_Encoding = "gzip",
                        User_Agent = "Flurl"
                    })
                    .WithSettings(settings =>
                    {
                        //TODO: add logging on debug.
                    });
            });
        }

        public async Task<AnimeTitlesCollection> GetAnimeTitles(CancellationToken cancellationToken = default)
        {
            return await this.BaseUri      
                //TODO: Switch to gzip endpoint.
                .AppendPathSegment("animetitles.xml")
                .GetXmlAsync<AnimeTitlesCollection>(cancellationToken)
                .ConfigureAwait(false);
        }
    }
}
