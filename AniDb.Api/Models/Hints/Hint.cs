using System.Xml.Serialization;

namespace AniDb.Api.Models.Hints
{
    public record Hint
    {
        [XmlAttribute("adddate")]
        public DateTime AddedDate { get; set; }

        [XmlElement("relid")]
        public int RelId { get; set; }

        [XmlElement("calculated")]
        public decimal Calculated { get; set; }
    }
}
