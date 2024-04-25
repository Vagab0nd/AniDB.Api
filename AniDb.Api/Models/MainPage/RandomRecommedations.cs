using System.Xml.Serialization;

namespace AniDb.Api.Models.MainPage
{
    [XmlRoot(ElementName = "randomrecommendation")]
    public record RandomRecommedations
    {
        [XmlElement(ElementName = "recommendation")]
        public AnimeRecommendation[] Recommendation { get; set; } = [];
    }
}
