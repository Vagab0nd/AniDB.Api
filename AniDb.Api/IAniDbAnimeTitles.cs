using AniDb.Api.Models.Titles;

namespace AniDb.Api
{
    public interface IAniDbAnimeTitles
    {
        AnimeTitlesCollection GetAnimeTitles();
    }
}
