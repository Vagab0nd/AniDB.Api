﻿using Flurl.Http.Configuration;
using Flurl.Http;

namespace AniDb.Api.Infrastracture
{
    internal static class FlurlHttpExtensions
    {
        public static string TryConfigureClientForUrl(string url, Action<IFlurlClientBuilder> configure)
        {
            var clientName = FlurlHttp.BuildClientNameByHost(new FlurlRequest(url));
            FlurlHttp.Clients.GetOrAdd(clientName, null, configure);    
            return clientName;
        }
    }
}
