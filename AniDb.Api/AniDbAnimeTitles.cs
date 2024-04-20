﻿using AniDb.Api.Infrastracture;
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
           FlurlHttp.Clients
                .GetOrAdd(nameof(AniDbAnimeTitles), BaseUri, builder =>
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
            return await BaseUri                
                .AppendPathSegment("anime-titles.dat.gz")
                .GetXmlAsync<AnimeTitlesCollection>(cancellationToken)
                .ConfigureAwait(false);
        }
    }
}