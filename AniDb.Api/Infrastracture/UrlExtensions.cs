using Flurl;
using Flurl.Http;
using Flurl.Http.Xml;
using AniDb.Api.Models.Common;

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

        //TODO: "Peek" root element in xml to determine if error.
        public static async Task<Response<T>> GetAniDbResponse<T>(this Url url, CancellationToken cancellationToken = default) where T: class
        {
            var response = new FlurlRequest(url).GetAsync(cancellationToken: cancellationToken);

            try
            {
                var error = await response.ReceiveXml<Error>();
                return new Response<T>
                {
                    ErrorMessage = error.Text
                };
            }
            catch
            {
                var data = await response.ReceiveXml<T>();
                return data == null
                    ? throw new InvalidOperationException("AniDB xml data is null")
                    : new Response<T>
                {
                    Data = data
                };
            }

        }
    }
}
