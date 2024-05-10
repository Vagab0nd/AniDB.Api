using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Seiyuu
    {
        [XmlAttribute(AttributeName = "id")]
        public int CreatorId { get; init; }

        [XmlAttribute(AttributeName = "picture")]
        public string Picture { get; init; } = string.Empty;

        [XmlText]
        public string Text { get; init; } = string.Empty;
    }
}
