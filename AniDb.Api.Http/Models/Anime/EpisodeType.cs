using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public enum EpisodeType
    {
        /// <summary>
        /// Normal Episode
        /// </summary>
        [XmlEnum(Name = "1")]
        Normal,
        
        /// <summary>
        /// Special/Extra Episode (BD/DVD Specials, Bonus eps) (S1, S2, ...)
        /// </summary>
        [XmlEnum(Name = "2")]
        Special,
        
        /// <summary>
        /// Opening/Ending (C1, C2, ...)
        /// </summary>
        [XmlEnum(Name = "3")]
        OpeningEnding,
        
        /// <summary>
        /// Trailer/Promo/Commercial (T1, T2, ...)
        /// </summary>
        [XmlEnum(Name = "4")]
        Promo,
        
        /// <summary>
        /// Parody Episode (P1, P2, ...)
        /// </summary>
        [XmlEnum(Name = "5")]
        Parody,
        
        /// <summary>
        /// Other Episode (official repackages such as the Psycho-Pass New Edit , US Chopjobs, certain supportfiles (AC3 modpacks, fontpacks).) (O1, O2, ...)
        /// </summary>
        [XmlEnum(Name = "6")]
        Other,
    }
}