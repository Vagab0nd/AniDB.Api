using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{

    [XmlRoot(ElementName = "anime")]
    public record Anime
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "restricted")]
        public bool Restricted { get; set; }

        public string Type { get; set; }

        public int EpisodeCount { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Title> Titles { get; set; }

        public List<AnimeRelated> RelatedAnime { get; set; }

        public List<AnimeSimilar> SimilarAnime { get; set; }

        public List<Recommendation> Recommendations { get; set; }

        public string Url { get; set; }

        public List<Creator> Creators { get; set; }

        public string Description { get; set; }

        public Ratings Ratings { get; set; }

        public string Picture { get; set; }

        public List<Resource> Resources { get; set; }

        public List<Tag> Tags { get; set; }

        public List<Character> Characters { get; set; }

        public List<Episode> Episodes { get; set; }
    }
}
