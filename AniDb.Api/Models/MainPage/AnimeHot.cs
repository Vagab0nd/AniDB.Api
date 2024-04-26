using AniDb.Api.Models.Common;
using System.Xml.Serialization;

namespace AniDb.Api.Models.MainPage
{
    public record AnimeHot
    {
        [XmlAttribute(AttributeName = "id")]
        public string AnimeId { get; set; } = null!;

        [XmlAttribute(AttributeName = "restricted")]
        public bool Restricted { get; set; }        

        [XmlElement(ElementName = "episodecount")]
        public int EpisodeCount { get; set; }

        [XmlElement(ElementName = "startdate")]
        public DateTime StartDate { get; set; }

        [XmlElement(ElementName = "enddate")]
        public DateTime? EndDate { get; set; }

        [XmlElement(ElementName = "title")]
        public Title Title { get; set; } = new Title();

        [XmlElement(ElementName = "picture")]
        public string Picture { get; set; } = string.Empty;

        [XmlElement(ElementName = "ratings")]
        public Ratings Ratings { get; set; } = new Ratings();
    }
}
