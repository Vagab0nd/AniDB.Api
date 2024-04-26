using System.Xml.Serialization;

namespace AniDb.Api.Models.MainPage
{
    [XmlRoot(ElementName = "main")]
    public record MainPage
    {
        [XmlElement(ElementName = "hotanime")]
        public HotAnimeCollection HotAnime { get; set; } = new HotAnimeCollection();

        [XmlElement(ElementName = "randomsimilar")]
        public RandomSimilar RandomSimilarAnime { get; set; } = new RandomSimilar();

        [XmlElement(ElementName = "randomrecommendation")]
        public RandomRecommendations RandomRecommendations { get; set; } = new RandomRecommendations();
    }
}
