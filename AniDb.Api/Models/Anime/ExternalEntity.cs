using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record ExternalEntity
    {
        [XmlArrayItem(ElementName = "identifier")]
        public string[] Identifiers { get; set; }

        [XmlElement(ElementName = "url")]
        public string Url { get; set; }
    }
}
