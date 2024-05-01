using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record AnimeSimilar
    {
        [XmlAttribute(AttributeName = "id")]
        public string AnimeId { get; init; } = null!;

        [XmlAttribute(AttributeName = "approval")]
        public int Approval { get; init; }

        [XmlAttribute(AttributeName = "total")]
        public int Total { get; init; }

        [XmlText]
        public string Text { get; init; } = string.Empty;
    }
}
