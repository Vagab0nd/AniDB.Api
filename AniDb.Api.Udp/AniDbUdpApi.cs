namespace AniDb.Api.Udp
{
    public class AniDbUdpApi : IAniDbUdpApi
    {
        public object Auth(string username, string password, bool nat = false, bool comp = false, bool imgServer = false, int? mtu = null)
        {
            throw new NotImplementedException();
        }

        public object Encrypt()
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public object Notify(bool? buddy)
        {
            throw new NotImplementedException();
        }

        public object NotifyGet(string type, int id)
        {
            throw new NotImplementedException();
        }

        public object NotifyList()
        {
            throw new NotImplementedException();
        }

        public void Push(bool notify, bool message, bool? buddy)
        {
            throw new NotImplementedException();
        }
    }
}
