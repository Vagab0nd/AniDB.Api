using AniDb.Api.Models.Anime;
using AniDb.Api.Models.Common;
using System.Xml.Serialization;

[XmlRoot(ElementName = "anime")]
public record Anime
{
    [XmlAttribute(AttributeName = "id")]
    public string AnimeId { get; set; } = null!;

    [XmlAttribute(AttributeName = "restricted")]
    public bool Restricted { get; set; }

    [XmlElement(ElementName = "type")]
    public string Type { get; set; } = null!;

    [XmlElement(ElementName = "episodecount")]
    public int EpisodeCount { get; set; }

    [XmlElement(ElementName = "startdate")]
    public DateTime StartDate { get; set; }

    [XmlElement(ElementName = "enddate")]
    public DateTime EndDate { get; set; }

    [XmlArray(ElementName = "titles")]
    [XmlArrayItem(ElementName = "title")]
    public Title[] Titles { get; set; } = [];

    [XmlArray(ElementName = "relatedanime")]
    [XmlArrayItem(ElementName = "anime")]
    public AnimeRelated[]? RelatedAnime { get; set; }

    [XmlArray(ElementName = "similaranime")]
    [XmlArrayItem(ElementName = "anime")]
    public AnimeSimilar[] SimilarAnime { get; set; } = [];

    [XmlArray(ElementName = "recommendations")]
    [XmlArrayItem(ElementName = "recommendation")]
    public Recommendation[] Recommendations { get; set; } = [];

    [XmlElement(ElementName = "url")]
    public string Url { get; set; } = string.Empty;

    [XmlArray(ElementName = "creators")]
    [XmlArrayItem(ElementName = "name")]
    public Creator[] Creators { get; set; } = [];

    [XmlElement(ElementName = "description")]
    public string Description { get; set; } = string.Empty;

    [XmlElement(ElementName = "ratings")]
    public Ratings Ratings { get; set; } = new Ratings();

    [XmlElement(ElementName = "picture")]
    public string Picture { get; set; } = string.Empty;

    [XmlArray(ElementName = "resources")]
    [XmlArrayItem(ElementName = "resource")]
    public Resource[] Resources { get; set; } = [];

    [XmlArray(ElementName = "tags")]
    [XmlArrayItem(ElementName = "tag")]
    public Tag[] Tags { get; set; } = [];

    [XmlArray(ElementName = "characters")]
    [XmlArrayItem(ElementName = "character")]
    public Character[] Characters { get; set; } = [];

    [XmlArray(ElementName = "episodes")]
    [XmlArrayItem(ElementName = "episode")]
    public Episode[] Episodes { get; set; } = [];
}
