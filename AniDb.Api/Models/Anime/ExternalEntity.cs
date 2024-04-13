using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record ExternalEntity
    {
        [XmlElement(ElementName = "identifier")]
        public List<string> Identifier { get; set; }

        [XmlElement(ElementName = "url")]
        public string Url { get; set; }
    }




}
