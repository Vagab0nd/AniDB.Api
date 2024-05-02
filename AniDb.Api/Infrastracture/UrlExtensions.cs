using Flurl;
using Flurl.Http;
using Flurl.Http.Xml;
using AniDb.Api.Models.Common;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Serialization;

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

        //TODO: Improve deserialization performance.
        public static async Task<Response<T>> GetAniDbResponse<T>(this Url url, CancellationToken cancellationToken = default) where T: class
        {
            var responseXmlDoc = await new FlurlRequest(url)
                .GetXDocumentAsync(cancellationToken: cancellationToken);            

            using XmlReader reader = responseXmlDoc.CreateReader();
            if(IsErrorModel(responseXmlDoc))
            {
                var error = MicrosoftXmlSerializer.Default.Deserialize<Error>(responseXmlDoc.ToString());
                return new Response<T>
                {
                    ErrorMessage = error.Text
                };
            }
            else
            {
                var data = MicrosoftXmlSerializer.Default.Deserialize<T>(responseXmlDoc.ToString());
                return new Response<T>
                {
                    Data = data
                };
            };
        }

        private static bool IsErrorModel(XDocument xmlDoc)
        {
            if (xmlDoc == null)
            {
                throw new ArgumentNullException(nameof(xmlDoc));
            }

            return xmlDoc.Root?.Name == "error" || xmlDoc.Descendants("error").Any();
        }
    }
}
