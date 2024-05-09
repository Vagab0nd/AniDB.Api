using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Tag
    {
        [XmlAttribute(AttributeName = "id")]
        public string TagId { get; init; } = null!;

        [XmlAttribute(AttributeName = "parentid")]
        public string? ParentId { get; init; }

        [XmlAttribute(AttributeName = "weight")]
        public int Weight { get; init; }

        [XmlAttribute(AttributeName = "localspoiler")]
        public bool LocalSpoiler { get; init; }

        [XmlAttribute(AttributeName = "globalspoiler")]
        public bool GlobalSpoiler { get; init; }

        [XmlAttribute(AttributeName = "verified")]
        public bool Verified { get; init; }

        [XmlAttribute(AttributeName = "update")]
        public string? Updated
        {
            get { return this.UpdatedDate.ToString(); }
            init { this.UpdatedDate = value != null ? DateOnly.Parse(value) : null; }
        }

        [XmlIgnore]
        public DateOnly? UpdatedDate { get; init; }

        [XmlElement(ElementName = "name")]
        public string Name { get; init; } = string.Empty;

        [XmlElement(ElementName = "description")]
        public string Description { get; init; } = string.Empty;

        [XmlElement(ElementName = "picurl")]
        public string PictureUrl { get; init; } = string.Empty;
    }
}
