using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Resource
    {
        [XmlAttribute(AttributeName = "type")]
        public int Type { get; init; }

        [XmlElement(ElementName = "externalentity")]
        public ExternalEntity ExternalEntity { get; init; } = new ExternalEntity();
    }
}
