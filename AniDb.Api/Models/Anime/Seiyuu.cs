using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Seiyuu
    {
        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "picture")]
        public string Picture { get; set; }

        [XmlText]
        public string Text { get; set; }
    }




}
