using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Character
    {
        [XmlAttribute(AttributeName = "id")]
        public string CharacterId { get; init; } = null!;

        [XmlAttribute(AttributeName = "type")]
        public CharacterType Type { get; init; }

        [XmlAttribute(AttributeName = "update")]
        public string Update { get; init; } = string.Empty;

        [XmlElement(ElementName = "rating")]
        public CharacterRating Rating { get; init; } = new CharacterRating();

        [XmlElement(ElementName = "name")]
        public string Name { get; init; } = string.Empty;

        [XmlElement(ElementName = "gender")]
        public string Gender { get; init; } = string.Empty;

        [XmlElement(ElementName = "charactertype")]
        public string CharacterType { get; init; } = string.Empty;

        [XmlElement(ElementName = "description")]
        public string Description { get; init; } = string.Empty;

        [XmlElement(ElementName = "picture")]
        public string Picture { get; init; } = string.Empty;

        [XmlElement(ElementName = "seiyuu")]
        public Seiyuu? Seiyuu { get; init; }
    }
}
