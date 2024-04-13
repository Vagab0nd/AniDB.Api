using System.Xml.Serialization;

namespace AniDb.Api.Models.MyListSummary
{
    public record MyListItem
    {
        [XmlAttribute(AttributeName = "aid")]
        public int AnimeId { get; set; }

        [XmlAttribute(AttributeName = "state")]
        public int State { get; set; }

        public int EpisodeCount { get; set; }

        public int SeenCount { get; set; }

        public int SpecialCount { get; set; }

        public int SeenSpecialCount { get; set; }
    }
}
