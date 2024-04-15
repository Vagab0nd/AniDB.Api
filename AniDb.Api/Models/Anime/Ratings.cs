using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Ratings
    {
        [XmlElement(ElementName = "permanent")]
        public AnimeRating Permanent { get; set; }

        [XmlElement(ElementName = "temporary")]
        public AnimeRating Temporary { get; set; }

        [XmlElement(ElementName = "review")]
        public AnimeRating Review { get; set; }
    }
}
