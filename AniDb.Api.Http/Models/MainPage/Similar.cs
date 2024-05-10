using System.Xml.Serialization;

namespace AniDb.Api.Models.MainPage
{
    public record Similar
    {
        [XmlElement(ElementName = "source")]
        public AnimeSimilar Source { get; set; } = new AnimeSimilar();

        [XmlElement(ElementName = "target")]
        public AnimeSimilar Target { get; set; } = new AnimeSimilar();
    }
}
