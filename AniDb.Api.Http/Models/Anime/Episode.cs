using System.Xml.Serialization;
using AniDb.Api.Models.Common;

namespace AniDb.Api.Models.Anime
{
    public record Episode
    {
        [XmlElement(ElementName = "title")]
        public Title[] Titles { get; init; } = [];

        [XmlElement(ElementName = "description")]
        public string Description { get; init; } = string.Empty;

        [XmlElement(ElementName = "airdate")]
        public DateTime AirDate { get; init; }

        [XmlAttribute(AttributeName = "id")]
        public string EpisodeId { get; init; } = null!;

        [XmlElement(ElementName = "epno")]
        public string EpisodeNumber { get; init; } = string.Empty;

        [XmlAttribute(AttributeName = "length")]
        public string PlayLength { get; init; } = string.Empty;

        [XmlAttribute(AttributeName = "update")]
        public string? Updated
        {
            get => this.UpdatedDate.ToString();
            init => this.UpdatedDate = value != null ? DateOnly.Parse(value) : null;
        }

        [XmlIgnore]
        public DateOnly? UpdatedDate { get; init; }
    }
}