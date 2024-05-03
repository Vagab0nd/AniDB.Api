using System.Xml.Serialization;

namespace AniDb.Api.Models.Common
{
    public enum TitleType
    {
        [XmlEnum(Name = "main")]
        Main,
        
        [XmlEnum(Name = "official")]
        Official,

        [XmlEnum(Name = "short")]
        Short,

        [XmlEnum(Name = "synonym")]
        Synonym,

        [XmlEnum(Name = "kanareading")]
        KanaReading,

        [XmlEnum(Name = "titlecard")]
        TitleCard
    }
}