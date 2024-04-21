using System.Xml.Serialization;

namespace AniDb.Api.Models.Titles
{
    [XmlRoot(ElementName = "animetitles")]
    public record AnimeTitlesCollection
    {
        [XmlElement(ElementName = "anime")]
        public AnimeTitles[] AnimeTitles { get; set; }
    }
}
