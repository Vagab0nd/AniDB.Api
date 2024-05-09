using System.Xml.Serialization;
using AniDb.Api.Models.Common;

namespace AniDb.Api.Models.Anime
{
    public record Episode
    {
        [XmlAttribute(AttributeName = "id")]
        public string EpisodeId { get; init; } = null!;

        [XmlAttribute(AttributeName = "length")]
        public string PlayLength { get; init; } = string.Empty;

        [XmlAttribute(AttributeName = "update")]
        public string? Updated
        {
            get { return this.UpdatedDate.ToString(); }
            init { this.UpdatedDate = value != null ? DateOnly.Parse(value) : null; }
        }

        [XmlIgnore]
        public DateOnly? UpdatedDate { get; init; }

        [XmlElement(ElementName = "title")]
        public Title[] Titles { get; init; } = [];

        [XmlElement(ElementName = "description")]
        public string Description { get; init; } = string.Empty;

        [XmlElement(ElementName = "airdate")]
        public DateTime AirDate { get; init; }
    }
}