using System.Xml.Serialization;
using AniDb.Api.Models.Common;

namespace AniDb.Api.Models.Anime
{
    public record Episode
    {
        [XmlAttribute(AttributeName = "id")]
        public int EpisodeId { get; set; }

        [XmlAttribute(AttributeName = "length")]
        public string PlayLength { get; set; }

        [XmlAttribute(AttributeName = "update")]
        public string Update { get; set; }

        [XmlElement(ElementName = "title")]
        public Title[] Titles { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "airdate")]
        public string AirDate { get; set; }
    }
}