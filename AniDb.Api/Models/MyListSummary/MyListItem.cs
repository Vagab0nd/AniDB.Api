using System.Xml.Serialization;

namespace AniDb.Api.Models.MyListSummary
{
    public record MyListItem
    {
        [XmlAttribute(AttributeName = "aid")]
        public int AnimeId { get; set; }

        [XmlAttribute(AttributeName = "state")]
        public int State { get; set; }

        [XmlElement(ElementName = "episodecount")]
        public int EpisodeCount { get; set; }

        [XmlElement(ElementName = "seencount")]
        public int SeenCount { get; set; }

        [XmlElement(ElementName = "specialcount")]
        public int SpecialCount { get; set; }

        [XmlElement(ElementName = "seenspecialcount")]
        public int SeenSpecialCount { get; set; }
    }
}
