using AniDb.Api.Models.Anime;
using System.Xml.Serialization;

namespace AniDb.Api.Models.MainPage
{    public record Ratings
    {
        [XmlElement(ElementName = "permanent")]
        public AnimeRating Permanent { get; set; } = new AnimeRating();

        [XmlElement(ElementName = "recommendations")]
        public int Recommendations { get; set; }
    }
}
