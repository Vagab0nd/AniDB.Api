using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Tag
    {
        [XmlAttribute("id")]
        public string TagId { get; init; } = null!;

        [XmlAttribute("parentid")]
        public string? ParentId { get; init; }

        [XmlAttribute("weight")]
        public int Weight { get; init; }

        [XmlAttribute("localspoiler")]
        public bool LocalSpoiler { get; init; }

        [XmlAttribute("globalspoiler")]
        public bool GlobalSpoiler { get; init; }

        [XmlAttribute("verified")]
        public bool Verified { get; init; }

        [XmlAttribute("update")]
        public string? Updated
        {
            get { return this.UpdatedDate?.ToString(); }
            init { this.UpdatedDate = !string.IsNullOrWhiteSpace(value) ? DateOnly.Parse(value) : null; }
        }

        [XmlIgnore]
        public DateOnly? UpdatedDate { get; init; }

        [XmlElement("name")]
        public string Name { get; init; } = string.Empty;

        [XmlElement("description")]
        public string Description { get; init; } = string.Empty;

        [XmlElement("picurl")]
        public string PictureUrl { get; init; } = string.Empty;
    }
}
