using System.Xml.Serialization;
using AniDb.Api.Models.Common;

namespace AniDb.Api.Models.Anime
{
    public record Episode
    {
        [XmlAttribute(AttributeName = "id")]
        public string EpisodeId { get; set; } = null!;

        [XmlAttribute(AttributeName = "length")]
        public string PlayLength { get; set; } = string.Empty;

        [XmlAttribute(AttributeName = "update")]
        public string Update { get; set; } = string.Empty;

        [XmlElement(ElementName = "title")]
        public Title[] Titles { get; set; } = [];

        [XmlElement(ElementName = "description")]
        public string Description { get; set; } = string.Empty;

        [XmlElement(ElementName = "airdate")]
        public string AirDate { get; set; } = string.Empty;
    }
}