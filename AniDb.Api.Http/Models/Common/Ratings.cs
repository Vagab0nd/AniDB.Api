using System.Xml.Serialization;
using AniDb.Api.Models.Anime;

namespace AniDb.Api.Models.Common
{
    public record Ratings
    {
        [XmlElement(ElementName = "permanent")]
        public AnimeRating? Permanent { get; set; }

        [XmlElement(ElementName = "temporary")]
        public AnimeRating? Temporary { get; set; }

        [XmlElement(ElementName = "review")]
        public AnimeRating? Review { get; set; }
    }
}
