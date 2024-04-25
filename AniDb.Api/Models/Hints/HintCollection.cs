using System.Xml.Serialization;

namespace AniDb.Api.Models.Hints
{
    [XmlRoot("hints")]
    public record HintCollection
    {
        [XmlAttribute("uid")]
        public string UserId { get; set; } = null!;

        [XmlAttribute("type")]
        public string Type { get; set; } = null!;

        [XmlElement("hint")]
        public Hint[] Hints { get; set; } = [];
    }
}
