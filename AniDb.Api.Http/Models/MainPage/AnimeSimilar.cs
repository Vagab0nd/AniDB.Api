using AniDb.Api.Models.Common;
using System.Xml.Serialization;

namespace AniDb.Api.Models.MainPage
{
    public record AnimeSimilar
    {
        [XmlAttribute(AttributeName = "aid")]
        public string AnimeId { get; set; } = null!;

        [XmlAttribute(AttributeName = "restricted")]
        public bool Restricted { get; set; }

        [XmlElement(ElementName = "title")]
        public Title Title { get; set; } = new Title();

        [XmlElement(ElementName = "picture")]
        public string Picture { get; set; } = string.Empty;
    }
}
