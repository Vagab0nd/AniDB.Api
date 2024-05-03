using System.Xml.Serialization;

namespace AniDb.Api.Models.Common
{
    public enum AnimeType
    {
        [XmlEnum(Name = "TV Series")]
        TvSeries,
        [XmlEnum(Name = "OVA")]
        Ova,
        Movie,
        Other,
        Web,
        [XmlEnum(Name = "TV Special")]
        TvSpecial,
        [XmlEnum(Name = "Music Video")]
        MusicVideo,
        [XmlEnum(Name = "unknown")]
        Unknown
    }
}
