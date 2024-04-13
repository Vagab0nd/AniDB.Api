using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Character
    {
        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "update")]
        public string Update { get; set; }

        public Rating Rating { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string Charactertype { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

        public Seiyuu Seiyuu { get; set; }
    }




}
