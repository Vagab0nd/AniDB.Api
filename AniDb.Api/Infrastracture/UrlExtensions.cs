using Flurl;

namespace AniDb.Api.Infrastracture
{
    internal static class UrlExtensions
    {
        private const string ClientName = "anidbapidotnet";
        private const int ClientVersion = 1;
        private const int ProtocolVersion = 1;

        public static Url AppendAniDbQueryParams(this Url url)
        {
            url.AppendQueryParam("client", ClientName);
            url.AppendQueryParam("clientver", ClientVersion);
            url.AppendQueryParam("protover", ProtocolVersion);
            return url;
        }
    }
}
