using System.Xml.Serialization;

namespace AniDb.Api.Models.Common
{
    public record Title
    {
        [XmlAttribute(AttributeName = "lang")]
        public string Language { get; set; } = string.Empty;

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; } = null!;

        [XmlText]
        public string Text { get; set; } = string.Empty;
    }
}
