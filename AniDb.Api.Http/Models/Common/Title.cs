using System.Xml.Serialization;

namespace AniDb.Api.Models.Common
{
    public record Title
    {
        [XmlAttribute(AttributeName = "xml:lang")]
        public string Language { get; set; } = string.Empty;

        [XmlAttribute(AttributeName = "type")]
        public TitleType Type { get; set; }

        [XmlText]
        public string Text { get; set; } = string.Empty;
    }
}
