using System.Xml.Serialization;

namespace AniDb.Api.Models.Hints
{
    [XmlRoot("hints")]
    public record HintCollection
    {
        [XmlAttribute("uid")]
        public int UserId { get; set; }

        [XmlAttribute("type")]
        public int Type { get; set; }

        [XmlElement("hint")]
        public Hint[] Hints { get; set; }
    }
}
