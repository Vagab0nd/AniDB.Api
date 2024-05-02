using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record ExternalEntity
    {
        [XmlElement(ElementName = "identifier")]
        public string[] Identifiers { get; init; } = [];

        [XmlElement(ElementName = "url")]
        public string Url { get; init; } = string.Empty;
    }
}
