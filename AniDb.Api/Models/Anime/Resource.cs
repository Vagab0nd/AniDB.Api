using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Resource
    {
        [XmlAttribute(AttributeName = "type")]
        public int Type { get; set; }

        [XmlElement(ElementName = "externalentity")]
        public ExternalEntity ExternalEntity { get; set; } = new ExternalEntity();
    }
}
