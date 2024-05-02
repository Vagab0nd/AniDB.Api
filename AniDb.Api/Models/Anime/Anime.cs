using AniDb.Api.Models.Common;
using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    [XmlRoot(ElementName = "anime")]
    public record Anime
    {
        [XmlAttribute(AttributeName = "id")]
        public string AnimeId { get; init; } = null!;

        [XmlAttribute(AttributeName = "restricted")]
        public bool Restricted { get; init; }

        [XmlElement(ElementName = "type")]
        public AnimeType? Type { get; init; }

        [XmlElement(ElementName = "episodecount")]
        public int EpisodeCount { get; init; }

        [XmlElement(ElementName = "startdate")]
        public DateTime StartDate { get; init; }

        [XmlElement(ElementName = "enddate")]
        public DateTime? EndDate { get; init; }

        [XmlArray(ElementName = "titles")]
        [XmlArrayItem(ElementName = "title")]
        public Title[] Titles { get; init; } = [];

        [XmlArray(ElementName = "relatedanime")]
        [XmlArrayItem(ElementName = "anime")]
        public AnimeRelated[]? RelatedAnime { get; init; }

        [XmlArray(ElementName = "similaranime")]
        [XmlArrayItem(ElementName = "anime")]
        public AnimeSimilar[] SimilarAnime { get; init; } = [];

        [XmlArray(ElementName = "recommendations")]
        [XmlArrayItem(ElementName = "recommendation")]
        public Recommendation[] Recommendations { get; init; } = [];

        [XmlElement(ElementName = "url")]
        public string Url { get; init; } = string.Empty;

        [XmlArray(ElementName = "creators")]
        [XmlArrayItem(ElementName = "name")]
        public Creator[] Creators { get; init; } = [];

        [XmlElement(ElementName = "description")]
        public string Description { get; init; } = string.Empty;

        [XmlElement(ElementName = "ratings")]
        public Ratings Ratings { get; init; } = new Ratings();

        [XmlElement(ElementName = "picture")]
        public string Picture { get; init; } = string.Empty;

        [XmlArray(ElementName = "resources")]
        [XmlArrayItem(ElementName = "resource")]
        public Resource[] Resources { get; init; } = [];

        [XmlArray(ElementName = "tags")]
        [XmlArrayItem(ElementName = "tag")]
        public Tag[] Tags { get; init; } = [];

        [XmlArray(ElementName = "characters")]
        [XmlArrayItem(ElementName = "character")]
        public Character[] Characters { get; init; } = [];

        [XmlArray(ElementName = "episodes")]
        [XmlArrayItem(ElementName = "episode")]
        public Episode[] Episodes { get; init; } = [];
    }
}
