namespace AniDb.Api.Udp
{
    public class AniDbUdpApi(int localPort) : AniDbUdpClient(localPort), IAniDbUdpApi
    {
        public object Auth(string username, string password, bool nat = false, bool comp = false, bool imgServer = false, int? mtu = null)
        {
            throw new NotImplementedException();
        }

        public object BuddyAccept(int userId)
        {
            throw new NotImplementedException();
        }

        public object BuddyAdd(int buddyId, string buddyName)
        {
            throw new NotImplementedException();
        }

        public object BuddyDelete(int buddyId)
        {
            throw new NotImplementedException();
        }

        public object BuddyDeny(int userId)
        {
            throw new NotImplementedException();
        }

        public object BuddyList(int? startAt)
        {
            throw new NotImplementedException();
        }

        public object BuddyState(int? startAt)
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

        public object NotificationAdd(string? animeId, string? groupId, int type, int priority)
        {
            throw new NotImplementedException();
        }

        public object NotificationDelete(string? animeId, string? groupId)
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
