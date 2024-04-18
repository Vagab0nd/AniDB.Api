using AniDb.Api.Models.Titles;

namespace AniDb.Api
{
    public interface IAniDbAnimeTitles
    {
        Task<AnimeTitlesCollection> GetAnimeTitles(CancellationToken cancellationToken = default);
    }
}
