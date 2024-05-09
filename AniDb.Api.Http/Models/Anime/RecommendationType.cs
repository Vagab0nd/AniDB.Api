using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public enum RecommendationType
    {
        [XmlEnum(Name = "For Fans")]
        ForFans,
        Recommended,
        [XmlEnum(Name = "Must See")]
        MustSee
    }
}