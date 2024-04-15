using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Tag
    {
        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "parentid")]
        public int ParentId { get; set; }

        [XmlAttribute(AttributeName = "weight")]
        public int Weight { get; set; }

        [XmlAttribute(AttributeName = "localspoiler")]
        public bool LocalSpoiler { get; set; }

        [XmlAttribute(AttributeName = "globalspoiler")]
        public bool GlobalSpoiler { get; set; }

        [XmlAttribute(AttributeName = "verified")]
        public bool Verified { get; set; }

        [XmlAttribute(AttributeName = "update")]
        public DateTime Update { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "picurl")]
        public string PictureUrl { get; set; }
    }
}
