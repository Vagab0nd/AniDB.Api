using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Seiyuu
    {
        [XmlAttribute(AttributeName = "id")]
        public int CreatorId { get; set; }

        [XmlAttribute(AttributeName = "picture")]
        public string Picture { get; set; } = string.Empty;

        [XmlText]
        public string Text { get; set; } = string.Empty;
    }
}
