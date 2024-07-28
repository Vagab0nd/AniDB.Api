using System.Net;
using System.Net.Sockets;

namespace AniDb.Api.Udp
{
    public class AniDbUdpClient : IDisposable
    {
        private const string BaseUri = "api.anidb.net";
        private const int RemotePort = 9000;

        private readonly UdpClient client;

        public AniDbUdpClient(int localPort)
        {
            this.client = new UdpClient(new IPEndPoint(IPAddress.Any, localPort));
            this.client.Connect(BaseUri, RemotePort);
        }

        public void Dispose()
        {
            this.client?.Dispose();
        }
    }
}
