using AniDb.Api.Models.Anime;
using AniDb.Api.Models.Hints;
using AniDb.Api.Models.MainPage;
using AniDb.Api.Models.MyListSummary;

namespace AniDb.Api
{
    public interface IAniDbHttpApi: IDisposable
    {

        /// <summary>
        /// Allows retrieval of non-file or episode related information for a specific anime by AID (AniDB anime id).
        /// </summary>
        /// <param name="animeId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Data about requested anime.</returns>
        Task<Anime> GetAnime(int animeId, CancellationToken cancellationToken = default);

        /// <summary>
        /// This command mirrors the type of data provided on the main web page. Use this instead of scraping the HTML. Please note, however, that the 'random recommendations' are, in fact, random. Please do not expect random results here to match random results there.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>Random recommended anime.</returns>
        Task<RandomRecommendations> GetRandomRecommendationAnime(CancellationToken cancellationToken = default);

        /// <summary>
        /// This command mirrors the type of data provided on the main web page. Use this instead of scraping the HTML. Please note, however, that the 'random similar' are, in fact, random. Please do not expect random results here to match random results there.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>Pairs of random anime that are somehow similar.</returns>
        Task<RandomSimilar> GetRandomSimilarAnime(CancellationToken cancellationToken = default);

        /// <summary>
        /// This command mirrors the type of data provided on the main web page. Use this instead of scraping the HTML. Unlike the two random result commands, the results here will match the results as supplied by the main web page (with some possible variance of a few hours, depending on cache life.)
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>List of trending (hot anime) in AniDB.</returns>
        Task<HotAnimeCollection> GetHotAnime(CancellationToken cancellationToken = default);

        /// <summary>
        /// A one-stop command returning the combined results of random recommendation, random similar, and hot anime. Use this command instead of scraping the HTML, and if you need more than one of the individual replies.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>Combined results of random recommendation, random similar and hot anime queries.</returns>
        Task<string> GetMainPageData(CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns a list of the user's anime list in summary form, roughly matching the data in the "my list" page of the web interface.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>User's summarized anime list.</returns>
        Task<MyListSummary> GetUserMyListSummmary(string username, string password, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns a list of unwatched titles and a calculated rating, based upon existing votes. The list may be empty if the requested user is very new, has not voted for enough titles, or has very stale (a number of months old) data. Hints are calculated once a day.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>List of recommended anime.</returns>
        Task<HintCollection> GetUserHints(string username, string password, CancellationToken cancellationToken = default);

    }
}
