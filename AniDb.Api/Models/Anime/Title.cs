using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Title
    {
        [XmlAttribute(AttributeName = "lang")]
        public string Language { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }
    }




}
