using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Tag
    {
        [XmlAttribute(AttributeName = "id")]
        public string TagId { get; set; } = null!;

        [XmlAttribute(AttributeName = "parentid")]
        public string? ParentId { get; set; }

        [XmlAttribute(AttributeName = "weight")]
        public int Weight { get; set; }

        [XmlAttribute(AttributeName = "localspoiler")]
        public bool LocalSpoiler { get; set; }

        [XmlAttribute(AttributeName = "globalspoiler")]
        public bool GlobalSpoiler { get; set; }

        [XmlAttribute(AttributeName = "verified")]
        public bool Verified { get; set; }

        [XmlAttribute(AttributeName = "update")]
        public string? Updated
        {
            get { return this.UpdatedDate.ToString(); }
            set { this.UpdatedDate = value != null ? DateOnly.Parse(value) : null; }
        }

        [XmlIgnore]
        public DateOnly? UpdatedDate { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; } = string.Empty;

        [XmlElement(ElementName = "description")]
        public string Description { get; set; } = string.Empty;

        [XmlElement(ElementName = "picurl")]
        public string PictureUrl { get; set; } = string.Empty;
    }
}
