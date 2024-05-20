namespace AniDb.Api.Core
{
    public static class ClientInfo
    {
        public const string ClientName = "anidbapidotnet";
        public const int ClientVersion = 1;
        /// <summary>
        /// https://wiki.anidb.net/HTTP_API_Definition#Parameters
        /// </summary>
        public const int HttpProtocolVersion = 1;
        /// <summary>
        /// https://wiki.anidb.net/UDP_API_Definition#General_Informations
        /// </summary>
        public const int UdpProtocolVersion = 3;
    }
}
