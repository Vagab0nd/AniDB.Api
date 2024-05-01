using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record CharacterRating
    {
        [XmlAttribute(AttributeName = "votes")]
        public int Votes { get; init; }

        [XmlText]
        public decimal Value { get; init; }
    }
}
