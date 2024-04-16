using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Creator
    {
        [XmlAttribute(AttributeName = "id")]
        public string CreatorId { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }
    }




}
