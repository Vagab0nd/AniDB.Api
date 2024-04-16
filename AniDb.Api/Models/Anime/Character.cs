using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public record Character
    {
        [XmlAttribute(AttributeName = "id")]
        public int CharacterId { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "update")]
        public string Update { get; set; }

        [XmlElement(ElementName = "rating")]
        public CharacterRating Rating { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "gender")]
        public string Gender { get; set; }

        [XmlElement(ElementName = "charactertype")]
        public string CharacterType { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "picture")]
        public string Picture { get; set; }

        [XmlElement(ElementName = "seiyuu")]
        public Seiyuu Seiyuu { get; set; }
    }
}
