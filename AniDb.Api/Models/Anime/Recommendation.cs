using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Recommendation
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; } = null!;

        [XmlAttribute(AttributeName = "uid")]
        public string UserId { get; set; } = null!;

        [XmlText]
        public string Text { get; set; } = string.Empty;
    }
}
