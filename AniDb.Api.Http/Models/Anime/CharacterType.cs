using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public enum CharacterType
    {
        [XmlEnum(Name = "main character in")]
        Character,

        [XmlEnum(Name = "secondary cast in")]
        Secondary,

        [XmlEnum(Name = "appears in")]
        AppearsIn,

        [XmlEnum(Name = "cameo appearance in")]
        Cameo,
    }
}