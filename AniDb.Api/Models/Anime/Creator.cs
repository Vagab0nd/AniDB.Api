using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Creator
    {
        [XmlAttribute(AttributeName = "id")]
        public string CreatorId { get; set; } = null!;

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; } = null!;

        [XmlText]
        public string Text { get; set; } = string.Empty;
    }
}
