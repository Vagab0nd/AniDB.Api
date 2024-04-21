using AniDb.Api.Models.Common;
using System.Xml.Serialization;

namespace AniDb.Api.Models.Titles
{
    public record AnimeTitles
    {
        [XmlAttribute(AttributeName = "aid")]
        public string AnimeId { get; set; }

        [XmlElement(ElementName = "title")]
        public Title[] Titles { get; set; }
    }
}
