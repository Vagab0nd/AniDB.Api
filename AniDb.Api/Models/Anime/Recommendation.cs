using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Recommendation
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }

        [XmlText]
        public string Text { get; set; }
    }




}
