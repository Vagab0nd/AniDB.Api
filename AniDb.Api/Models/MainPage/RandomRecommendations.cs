using System.Xml.Serialization;

namespace AniDb.Api.Models.MainPage
{
    [XmlRoot(ElementName = "randomrecommendation")]
    public record RandomRecommendations
    {
        [XmlElement(ElementName = "recommendation")]
        public Recommendation[] Recommendation { get; set; } = [];
    }
}
