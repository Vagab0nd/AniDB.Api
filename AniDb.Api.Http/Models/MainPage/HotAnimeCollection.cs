using System.Xml.Serialization;

namespace AniDb.Api.Models.MainPage
{
    [XmlRoot(ElementName = "hotanime")]
    public record HotAnimeCollection
    {
        [XmlElement(ElementName = "anime")]
        public AnimeHot[] HotAnime { get; set; } = [];
    }
}
