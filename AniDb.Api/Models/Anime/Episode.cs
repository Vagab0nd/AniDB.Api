using System.Collections.Generic;
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

        [XmlArray(ElementName = "titles")]
        [XmlArrayItem(ElementName = "title")]
        public List<Title> Titles { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "airDate")]
        public string AirDate { get; set; }
    }
}