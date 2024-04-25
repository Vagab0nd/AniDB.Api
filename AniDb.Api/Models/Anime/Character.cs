using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Character
    {
        [XmlAttribute(AttributeName = "id")]
        public string CharacterId { get; set; } = null!;

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; } = null!;

        [XmlAttribute(AttributeName = "update")]
        public string Update { get; set; } = string.Empty;

        [XmlElement(ElementName = "rating")]
        public CharacterRating Rating { get; set; } = new CharacterRating();

        [XmlElement(ElementName = "name")]
        public string Name { get; set; } = string.Empty;

        [XmlElement(ElementName = "gender")]
        public string Gender { get; set; } = string.Empty;

        [XmlElement(ElementName = "charactertype")]
        public string CharacterType { get; set; } = string.Empty;

        [XmlElement(ElementName = "description")]
        public string Description { get; set; } = string.Empty;

        [XmlElement(ElementName = "picture")]
        public string Picture { get; set; } = string.Empty;

        [XmlElement(ElementName = "seiyuu")]
        public Seiyuu? Seiyuu { get; set; }
    }
}
