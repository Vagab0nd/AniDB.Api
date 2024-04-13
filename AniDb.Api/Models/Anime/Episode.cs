using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Episode
    {
        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "length")]
        public string Length { get; set; }

        [XmlAttribute(AttributeName = "update")]
        public string Update { get; set; }

        public List<Title> Titles { get; set; }

        public string Description { get; set; }

        public string AirDate { get; set; }
    }




}
