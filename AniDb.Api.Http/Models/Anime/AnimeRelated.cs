using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record AnimeRelated
    {
        [XmlAttribute(AttributeName = "id")]
        public string AnimeId { get; init; } = null!;

        [XmlAttribute(AttributeName = "type")]
        public AnimeRelationType Type { get; init; }

        [XmlText]
        public string Text { get; init; } = string.Empty;
    }

}
