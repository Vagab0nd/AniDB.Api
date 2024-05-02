using System.Xml.Serialization;

namespace AniDb.Api.Models.Common
{
    [XmlRoot(ElementName = "error")]
    public record Error
    {
        [XmlText]
        public string Text { get; set; } = string.Empty;
    }
}
