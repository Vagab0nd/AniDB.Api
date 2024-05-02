using System.Xml.Serialization;

namespace AniDb.Api.Models.Anime
{
    public enum AnimeRelationType
    {
        /// <summary>
        /// Story that happens before the original.
        /// </summary>
        Prequel,
        /// <summary>
        /// Same setting, same characters, story is told differently.
        /// </summary>
        [XmlEnum(Name = "Alternative Version")]
        AlternativeVersion,
        /// <summary>
        /// Shares one or more characters, story is unrelated.
        /// </summary>
        Character,
        /// <summary>
        /// Unspecified relation.
        /// </summary>
        Other,
        /// <summary>
        /// Same characters, different universe/world/reality/timeline.
        /// </summary>
        [XmlEnum(Name = "Alternative Setting")]
        AlternativeSetting,
        /// <summary>
        /// Full version of the summarised story.
        /// </summary>
        [XmlEnum(Name = "Full Story")]
        FullStory,
        /// <summary>
        /// Summarises full story, may contain additional stuff.
        /// </summary>
        Summary,
        /// <summary>
        /// Same universe/world/reality/timeline, completely different characters.
        /// </summary>
        [XmlEnum(Name = "Same Setting")]
        SameSetting,
        /// <summary>
        /// Takes place sometime during the parent storyline.
        /// </summary>
        [XmlEnum(Name = "Side Story")]
        SideStory,
        /// <summary>
        /// Parent story for another story that takes place sometime during the same time.
        /// </summary>
        [XmlEnum(Name = "Parent Story")]
        ParentStory,
        /// <summary>
        /// Direct continuation of the story.
        /// </summary>
        Sequel
    }
}
