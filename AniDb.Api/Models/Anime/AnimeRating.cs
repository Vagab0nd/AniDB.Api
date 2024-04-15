using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record AnimeRating
    {
        [XmlAttribute(AttributeName = "count")]
        public int Votes { get; set; }

        [XmlText]
        public decimal Value { get; set; }
    }
}
