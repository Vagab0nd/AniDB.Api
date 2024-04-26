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
        public string? Updated
        {
            get { return this.UpdatedDate.ToString(); }
            set { this.UpdatedDate = value != null ? DateOnly.Parse(value) : null; }
        }

        [XmlIgnore]
        public DateOnly? UpdatedDate { get; set; }

        [XmlElement(ElementName = "title")]
        public Title[] Titles { get; set; } = [];

        [XmlElement(ElementName = "description")]
        public string Description { get; set; } = string.Empty;

        [XmlElement(ElementName = "airdate")]
        public DateTime AirDate { get; set; }
    }
}