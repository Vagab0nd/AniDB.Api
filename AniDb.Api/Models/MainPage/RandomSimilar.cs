using System.Xml.Serialization;

namespace AniDb.Api.Models.MainPage
{
    [XmlRoot(ElementName = "randomsimilar")]
    public record RandomSimilar
    {
        [XmlElement(ElementName = "similar")]
        public Similar[] SimilarAnime { get; set; } = [];
    }
}
