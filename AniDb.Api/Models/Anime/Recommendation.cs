using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Recommendation
    {
        [XmlAttribute(AttributeName = "type")]
        public RecommendationType Type { get; init; }

        [XmlAttribute(AttributeName = "uid")]
        public string UserId { get; init; } = null!;

        [XmlText]
        public string Text { get; init; } = string.Empty;
    }
}
