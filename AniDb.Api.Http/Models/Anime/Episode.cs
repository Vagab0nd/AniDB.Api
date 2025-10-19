using System.Xml.Serialization;
using AniDb.Api.Models.Common;

namespace AniDb.Api.Models.Anime
{
    public record Episode
    {
        [XmlElement("title")]
        public Title[] Titles { get; init; } = [];

        [XmlElement("description")]
        public string Description { get; init; } = string.Empty;

        [XmlElement("airdate")]
        public DateTime AirDate { get; init; }

        [XmlAttribute("id")]
        public string EpisodeId { get; init; } = null!;

        [XmlElement("epno")]
        public EpisodeNumber EpisodeNumber { get; init; } = null!;

        /// <summary>
        /// The play length of episode in minutes. Rounded up to multiple of 5 minutes if over 10 minutes or to 1 minute if less.
        /// </summary>
        [XmlElement("length")]
        public int PlayLength { get; init; }

        [XmlAttribute("update")]
        public string? Updated
        {
            get => this.UpdatedDate?.ToString();
            init => this.UpdatedDate = !string.IsNullOrWhiteSpace(value) ? DateOnly.Parse(value) : null;
        }

        [XmlIgnore]
        public DateOnly? UpdatedDate { get; init; }
    }
}