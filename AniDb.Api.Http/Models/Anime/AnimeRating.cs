using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record AnimeRating
    {
        [XmlAttribute(AttributeName = "count")]
        public int Votes { get; init; }

        [XmlText]
        public decimal Value { get; init; }
    }
}
