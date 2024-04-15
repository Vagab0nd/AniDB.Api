using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Ratings
    {
        [XmlElement(ElementName = "permanentcount")]
        public int PermanentCount { get; set; }

        [XmlElement(ElementName = "permanentvalue")]
        public decimal PermanentValue { get; set; }

        [XmlElement(ElementName = "temporarycount")]
        public int TemporaryCount { get; set; }

        [XmlElement(ElementName = "temporaryvalue")]
        public decimal TemporaryValue { get; set; }

        [XmlElement(ElementName = "reviewcount")]
        public int ReviewCount { get; set; }

        [XmlElement(ElementName = "reviewvalue")]
        public decimal ReviewValue { get; set; }
    }
}
