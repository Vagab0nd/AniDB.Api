using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record AnimeSimilar
    {
        [XmlAttribute(AttributeName = "id")]
        public string AnimeId { get; set; } = null!;

        [XmlAttribute(AttributeName = "approval")]
        public int Approval { get; set; }

        [XmlAttribute(AttributeName = "total")]
        public int Total { get; set; }

        [XmlText]
        public string Text { get; set; } = string.Empty;
    }

}
