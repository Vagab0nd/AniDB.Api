using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Rating
    {
        [XmlAttribute(AttributeName = "votes")]
        public int Votes { get; set; }

        [XmlText]
        public decimal Value { get; set; }
    }




}
