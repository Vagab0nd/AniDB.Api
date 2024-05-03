using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Creator
    {
        [XmlAttribute(AttributeName = "id")]
        public string CreatorId { get; init; } = null!;

        // Too many values to create enum
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; init; } = null!;

        [XmlText]
        public string Text { get; init; } = string.Empty;
    }
}
