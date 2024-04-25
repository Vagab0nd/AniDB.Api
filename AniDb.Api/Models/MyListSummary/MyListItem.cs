using System.Xml.Serialization;

namespace AniDb.Api.Models.MyListSummary
{
    public record MyListItem
    {
        [XmlAttribute(AttributeName = "aid")]
        public string AnimeId { get; set; } = null!;

        [XmlAttribute(AttributeName = "state")]
        public string State { get; set; } = null!;

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
