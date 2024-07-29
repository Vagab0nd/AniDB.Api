namespace AniDb.Api.Udp
{
    public interface IAniDbUdpApi
    {
        #region Authing Commands

        /// <summary>
        /// Authenticate to AnimeDB.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password">The password is the normal AniDB website password! The password listed in the profile as API Password in only used for the optional encryption feature.</param>
        /// <param name="nat"></param>
        /// <param name="comp"></param>
        /// <param name="imgServer"></param>
        /// <param name="mtu"></param>
        object Auth(string username, string password, bool nat = false, bool comp = false, bool imgServer = false, int? mtu = null);

        /// <summary>
        /// Logout from AnimeDB.
        /// </summary>
        /// <returns></returns>
        void Logout();

        /// <summary>
        /// Start encrypted session.
        /// </summary>
        /// <returns></returns>
        object Encrypt();

        #endregion

        #region Notify Commands

        /// <summary>
        /// Register your client as an observer for AniDB notification events for the current user. If you are registered for one or more event types the AniDB server will send an UDP packet (format see below) on each change which affects the current user.
        /// </summary>
        /// <param name="notify"></param>
        /// <param name="message"></param>
        /// <param name="buddy"></param>
        void Push(bool notify, bool message, bool? buddy);

        /// <summary>
        /// Get number of pending notifications (and number of online buddies).
        /// </summary>
        /// <param name="buddy"></param>
        object Notify(bool? buddy);

        /// <summary>
        /// List id of all pending (not acknowledged) new private message and new file notifications. Buddy events cannot be acknowledged.
        /// </summary>
        /// <returns></returns>
        object NotifyList();

        /// <summary>
        /// Receive private message or file notification.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        object NotifyGet(string type, int id);

        #endregion

        #region Notification Commands

        /// <summary>
        /// Add Anime or Group to Notify List.
        /// </summary>
        /// <param name="animeId"></param>
        /// <param name="groupId"></param>
        /// <param name="type"></param>
        /// <param name="priority"></param>
        /// <returns></returns>
        object NotificationAdd(string? animeId, string? groupId, int type, int priority);

        /// <summary>
        /// Remove Anime or Group from Notify List.
        /// </summary>
        /// <param name="animeId"></param>
        /// <param name="groupId"></param>
        /// <returns></returns>
        object NotificationDelete(string? animeId, string? groupId);

        #endregion
    }
}